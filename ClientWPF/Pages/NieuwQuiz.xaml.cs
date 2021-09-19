using DTO;
using DTO.Read;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Net.Http;

namespace ClientWPF.Pages
{
    /// <summary>
    /// Interaction logic for NieuwQuiz.xaml
    /// </summary>
    public partial class NieuwQuiz : Page
    {
        public CreateQuizDTO create;
        public bool isEmpty => !string.IsNullOrEmpty(create.Title) && !string.IsNullOrEmpty(create.Replicationkey);
        public List<LanguageReadDTO> lang = (List<LanguageReadDTO>)Context.Instance.Get("Lang");
        public List<OfficeApplicationReadDTO> apps = (List<OfficeApplicationReadDTO>)Context.Instance.Get("Apps");

        public NieuwQuiz()
        {
            InitializeComponent();
            create = new CreateQuizDTO { InstructionsLanguageId = 1, OfficeApplicationId = 1, UserinterfaceLanguageId = 1, Replicationkey = Guid.NewGuid().ToString(), Title = textBoxQuizTitel.Text, Intro = textBoxIntro.Text, ShortIntro = textBoxShortIntro.Text, IdentificationCode = Guid.NewGuid().ToString(), DefaultTimeLimit = TimeSpan.Parse(textBoxTimeLimit.Text), DefaultMinimumScore = Decimal.Parse(textBoxMinimumScore.Text) };
            DataContext = create;

            InstructionsLanguage.SelectionChanged += InstructionsLanguage_SelectionChanged;
            UserinterfaceLanguage.SelectionChanged += UserinterfaceLanguag_SelectionChanged;
            OfficeApplication.SelectionChanged += OfficeApplication_SelectionChanged;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lang.ForEach(x =>
            {
                InstructionsLanguage.Items.Add(x);
                UserinterfaceLanguage.Items.Add(x);
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

        private async void buttonToevoegenQuiz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("https://localhost:5001/api/Quiz/", create))
                {
                    _ = response;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cursus is succesvol toegevoegd!", "Informatie", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.NavigationService.GoBack();
                    }
                    else
                    {
                        MessageBox.Show("Er is iets verkeerd gelopen!", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
            catch { }
        }

        private void ButtonTerug_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u wil afsluiten, alle ingevoerde gegevens zullen dan verloren gaan", "Waarschuwing", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
