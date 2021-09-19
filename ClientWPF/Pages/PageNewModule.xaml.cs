using DTO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClientWPF.Pages
{
    public partial class PageNewModule : Page
    {
        bool isEmpty => string.IsNullOrEmpty(((CreateModuleDTO)DataContext).Title);

        public PageNewModule()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void bttnAddModule_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty)
            {
                await toevoegenModule();
            }
        }

        public async Task toevoegenModule()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("https://localhost:5001/api/Module/", DataContext))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        this.NavigationService.GoBack();
                    }
                    else
                    {
                        MessageBox.Show("Er is iets misgegaan", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch { }

        }

        private void ButtonNavigateBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
