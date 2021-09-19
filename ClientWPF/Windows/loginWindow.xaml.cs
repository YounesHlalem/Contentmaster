using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ClientWPF.Mocks;
using DTO.Read;
 
using WebService.Models;

namespace ClientWPF.Windows
{
    /// <summary>
    /// Interaction logic for loginWindow.xaml
    /// </summary>
    public partial class loginWindow : Window
    {
        class loginBinding
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        class response
        {
            public string Token { get; set; }
        }
        
        private bool LogginIn = false;

        private loginBinding binding;

        public loginWindow()
        {
            ApiHelper.InitializeClient();
            binding = new loginBinding();

            InitializeComponent();
            DataContext = binding;
        }
        private async void buttonMeldAan_Click(object sender, RoutedEventArgs e)
        {
            await Login();
        }

        private async Task Login()
        {
            if (LogginIn) return;
            LogginIn = true;
            await Login(
                binding.Email,
                binding.Password,
                disableButtons: () => buttonMeldAan.IsEnabled = false,
                enableButtons: () => buttonMeldAan.IsEnabled = true,
                onError: ShowErrorMessage,
                onSuccess: () =>
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Close();
                });
            LogginIn = false;
        }
        private static async Task Login(
            string email,
            string password,
            Action disableButtons = null,
            Action enableButtons = null,
            Action onError = null,
            Action onSuccess = null)
        {
            disableButtons?.Invoke();

            try
            {
                AuthenticateRequest authenticate = new AuthenticateRequest { Email = email, Password = password };

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("https://localhost:5001/users/authenticate", authenticate))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        response authenticateResponse = await response.Content.ReadAsAsync<response>();

                        Context.Instance.Add("AUTHORIZATION", authenticateResponse.Token);
                        ApiHelper.ApiClient.DefaultRequestHeaders.Add("AUTHORIZATION", $"bearer {authenticateResponse.Token}");

                        onSuccess?.Invoke();
                    }
                    else
                    {
                        onError?.Invoke();
                        enableButtons?.Invoke();
                    }
                }
            }
                catch
            {
                onError?.Invoke();
                enableButtons?.Invoke();
            }
        }

        private void ShowErrorMessage()
        {
            LogginIn = false;
            MessageBox.Show("Er is iets misgegaan.", "Fout!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private async void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                await Login();
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://localhost:5001/api/static/lang"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var lang = await response.Content.ReadAsAsync<List<LanguageReadDTO>>();
                        Context.Instance.Add("Lang", lang);
                    }
                }
            }
            catch { }
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://localhost:5001/api/static/app"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var apps = await response.Content.ReadAsAsync<List<OfficeApplicationReadDTO>>();
                        Context.Instance.Add("Apps", apps);
                    }
                }
            }
            catch { }

#if DEBUG
            binding.Email = "admin@local.host";
            binding.Password = "123456789";
            await Login();
#endif
        }
    }
}
