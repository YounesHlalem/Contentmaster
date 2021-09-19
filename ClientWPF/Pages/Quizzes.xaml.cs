using ClientWPF.DataBinding.Container;
using DTO.Read;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace ClientWPF.Pages
{
    public partial class Quizzes : Page
    {
        public Quizzes()
        {
            InitializeComponent();
            this.KeepAlive = true;
            Container = new ItemsContainer();
            DataContext = Container;
            //Container.quizzes.Add(new QuizDTO { Title = "test" });
        }

        public ItemsContainer Container { get; set; }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://localhost:5001/api/Quiz/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var filteredQuizzesList = await response.Content.ReadAsAsync<List<QuizReadDTO>>();
                        filteredQuizzesList.Where(x => x.OfficeApplications.Name == "Excel");
                        filteredQuizzesList.OrderByDescending(x => x.Id).Take(50);
                        Container.quizzes = filteredQuizzesList;
                        DataGridQuizzes.ItemsSource = Container.quizzes;
                    }
                }
            }
            catch { }
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            //Dit hoort niet in deze knop
            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u wil afsluiten, alle ingevoerde gegevens zullen dan verloren gaan", "Waarschuwing", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                this.NavigationService.GoBack();
            }
        }
        private void TextBoxFilterChanged(object sender, TextChangedEventArgs e)
        {
            Container.FilterItem.ForceResetFilter = true;
        }
        private void ButtonResetFilter_Click(object sender, RoutedEventArgs e)
        {
            Container.FilterItem.ForceResetFilter = false;
            ClearFilterTextboxes();
            ButtonActivateFilter_Click(sender, e);
        }
        private void ButtonActivateFilter_Click(object sender, RoutedEventArgs e)
        {
            List<QuizReadDTO> res = new List<QuizReadDTO>();// from o in Container.FilterItem where IsFiltered(o) select o).ToList();

            DataGridQuizzes.ItemsSource = res.ToList();
        }
        private void menuItemDetails_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            var contextMenu = (ContextMenu)menuItem.Parent;
            var item = (DataGrid)contextMenu.PlacementTarget;
            QuizReadDTO toDeleteFromBindedList = (QuizReadDTO)item.SelectedCells[0].Item;

            this.NavigationService.Navigate(new DetailsQuiz(toDeleteFromBindedList));
        }
        private void Nieuw_Click(object sender, RoutedEventArgs e)
        {
            NieuwQuiz nieuwQuizPage = new NieuwQuiz();
            this.NavigationService.Navigate(nieuwQuizPage);
        }
        private void ButtonDetails_Click(object sender, RoutedEventArgs e)
        {
            DetailsQuiz detailsQuizPage = new DetailsQuiz(this);
            this.NavigationService.Navigate(detailsQuizPage);
        }

        public void ClearFilterTextboxes()
        {
            Container.FilterItem.Titel = "";
        }
        bool IsFiltered(QuizReadDTO t)
        {
            return true;
            var a = Container.FilterItem.Identificatiecode;
            var b = Container.FilterItem.Titel;
            var c = Container.FilterItem.Taal;
            var d = Container.FilterItem.OfficeApp;

            var aa = a.Length > 0;
            var bb = b.Length > 0;
            var cc = c.NativeName.Length > 0;
            var dd = d.Name.Length > 0;

            if (aa && !bb && !cc && !dd)
            {
                return  t.IdentificationCode.Like(a);
            }
            else if (!aa && bb && !cc && !dd)
            {
                return t.Title.Like(c.NativeName);
            }
            else if (!aa && !bb && cc && !dd)
            {
                return t.InstructionsLanguage.NativeName.Like(b) || t.UserinterfaceLanguage.NativeName.Like(b);
            }
            else if (!aa && !bb && !cc && dd)
            {
                return t.OfficeApplications.Name.Like(c.NativeName);
            }
            else
            {
                return true;
            }
        }

        private void DataGridQuizzes_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
