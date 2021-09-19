using System.Windows;
using System.Windows.Controls;

namespace ClientWPF.Pages
{
    public partial class PageNewTopic : Page
    {
        public PageNewTopic()
        {
            InitializeComponent();
        }

        private void bttnAddTopic_Click(object sender, RoutedEventArgs e)
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
