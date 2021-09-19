using ClientWPF.Handlers;
using DTO;
using DTO.Read;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ClientWPF.Pages
{
    public partial class NieuwCursus : Page
    {
        public CreateCourseDTO create;
        public bool isEmpty => !string.IsNullOrEmpty(create.Name) && !string.IsNullOrEmpty(create.Replicationkey) && !string.IsNullOrEmpty(create.Icon);
        public List<LanguageReadDTO> lang = (List<LanguageReadDTO>)Context.Instance.Get("Lang");
        public List<OfficeApplicationReadDTO> apps = (List<OfficeApplicationReadDTO>)Context.Instance.Get("Apps");

        public event CreateHandler<CreateCourseDTO> Created;

        public NieuwCursus()
        {
            InitializeComponent();
            create = new CreateCourseDTO { InstructionsLanguageId = 1, OfficeApplicationId = 1, UserinterfaceLanguageId = 1, Replicationkey = Guid.NewGuid().ToString(), CreatedOn = DateTime.Now,  };
            DataContext = create;

            InstructionsLanguage.SelectionChanged += InstructionsLanguage_SelectionChanged;
            UserinterfaceLanguag.SelectionChanged += UserinterfaceLanguag_SelectionChanged;
            OfficeApplication.SelectionChanged += OfficeApplication_SelectionChanged;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lang.ForEach(x =>
            {
                InstructionsLanguage.Items.Add(x);
                UserinterfaceLanguag.Items.Add(x);
            });
            apps.ForEach(x =>
            {
                OfficeApplication.Items.Add(x);
            });
        }

        private void OfficeApplication_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (ComboBox)sender;
            create.OfficeApplicationId = ((OfficeApplicationReadDTO)box.SelectedItem).Id;
        }

        private void UserinterfaceLanguag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (ComboBox)sender;
            create.UserinterfaceLanguageId = ((LanguageReadDTO)box.SelectedItem).Id;
        }

        private void InstructionsLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (ComboBox)sender;
            create.InstructionsLanguageId = ((LanguageReadDTO)box.SelectedItem).Id;
        }

        private void selectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                var str = dlg.OpenFile();
                byte[] res;
                using (var streamReader = new MemoryStream())
                {
                    str.CopyTo(streamReader);
                    res = streamReader.ToArray();
                }
                str.Close();
                var Yeet = Convert.ToBase64String(res);
                create.Image = Yeet;
                create.Icon = Guid.NewGuid().ToString();

                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri(dlg.FileName);
                logo.EndInit();

                UploadImage.Source = logo;
            }
        }

        private void ButtonNavigateBack_Click(object sender, RoutedEventArgs e)
        {
            //Created?.Invoke(this, create);
            this.NavigationService.GoBack();
        }

        private async void CreateCursus(object sender, RoutedEventArgs e)
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("https://localhost:5001/api/Cursus/", create))
                {
                    _ = response;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cursus is succesvol toegevoegd!", "Informatie", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.NavigationService.GoBack();
                    } else
                    {
                        MessageBox.Show("Er is iets verkeerd gelopen!", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
            catch { }
        }
    }
}
