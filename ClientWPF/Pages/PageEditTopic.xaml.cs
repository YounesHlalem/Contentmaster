using System.Windows;
using System.Windows.Controls;

namespace ClientWPF.Pages
{
    public partial class PageEditTopic : Page
    {
        public PageEditTopic()
        {
            InitializeComponent();
        }

        private void bttnSaveTopicChanges_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bttnSaveTopic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonNavigateBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void txtboxSortOrder_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }
    }
}
