
using DTO.Read;
using System.ComponentModel;

namespace ClientWPF.DataBinding.Elements
{
    public class FilterItem : INotifyPropertyChanged
    {
        //Properties
        public event PropertyChangedEventHandler PropertyChanged;
        private OfficeApplicationReadDTO officeApp;
        private string cursusNaam = "";
        private LanguageReadDTO taal;
        private string titel = "";
        private string identificatiecode = "";

        public string Identificatiecode
        {
            get { return identificatiecode; }
            set
            {
                identificatiecode = value;
                OnPropertyChanged(nameof(identificatiecode));
            }
        }
        public string Titel
        {
            get { return titel; }
            set
            {
                titel = value;
                OnPropertyChanged(nameof(titel));
            }
        }
        public string CursusNaam
        {
            get { return cursusNaam; }
            set
            {
                cursusNaam = value;
                OnPropertyChanged(nameof(cursusNaam));
            }
        }
        public OfficeApplicationReadDTO OfficeApp
        {
            get { return officeApp; }
            set
            {
                officeApp = value;
                OnPropertyChanged(nameof(officeApp));
            }
        }
        public LanguageReadDTO Taal
        {
            get { return Taal1; }
            set
            {
                Taal1 = value;
                OnPropertyChanged(nameof(Taal1));
            }
        }
        public bool ForceResetFilter { get; set; }
        public LanguageReadDTO Taal1 { get => taal; set => taal = value; }

        //Methodes
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
