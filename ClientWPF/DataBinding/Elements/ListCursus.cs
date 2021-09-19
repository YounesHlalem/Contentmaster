using ClientWPF.MockData;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ClientWPF.DataBinding.Elements
{
    public class ListCursus : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<MockModel> mockCollectionCursus = new ObservableCollection<MockModel>();

        public ObservableCollection<MockModel> MockCollectionCursus
        {
            get { return mockCollectionCursus; }
            set
            {
                mockCollectionCursus = value;
                OnPropertyChanged(nameof(mockCollectionCursus));
            }
        }

        public MockModel MockModel { get; }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
