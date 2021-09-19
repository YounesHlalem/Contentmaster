using System.Windows.Controls;

namespace ClientWPF.Pages
{
    public partial class DetailsCursus : Page
    {
        public DetailsCursus(/*CourseReadDTO data*/)
        {
            InitializeComponent();
            //DataContext = data;
        }

        #region WPF Event handlers
        //private void buttonGoBack_Click(object sender, RoutedEventArgs e)
        //{
        //    if (checkFieldsEmpty())
        //    {
        //        MessageBoxResult result = MessageBox.Show("Bent u zeker dat u wil afsluiten, alle ingevoerde gegevens zullen dan verloren gaan", "Waarschuwing", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        //        if (result == MessageBoxResult.Yes)
        //        {
        //            this.NavigationService.Navigate(new Uri("/Pages/StartschermCursussen.xaml", UriKind.Relative));
        //        }
        //        else if (result == MessageBoxResult.No)
        //        {
        //        }
        //    }
        //    else
        //    {
        //        this.NavigationService.Navigate(new Uri("/Pages/StartschermCursussen.xaml", UriKind.Relative));
        //    }
        //}
        #endregion

        #region Selfmade methods
        //public bool checkFieldsEmpty()
        //{
        //    bool check = true;
        //    if (textBoxCursusNaam.Text.Length == 0 && textBoxGebruikersInterfaceTaal.Text.Length == 0 && textBoxInstructieTaal.Text.Length == 0 && textBoxOfficeAppNaam.Text.Length == 0 && textBoxModules.Text.Length == 0 && textBoxTopics.Text.Length == 0)
        //    {
        //        check = false;
        //    }
        //    return check;
        //}
        #endregion

        private void ButtonNavigateBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
