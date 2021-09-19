namespace ClientWPF.DataBinding.Elements
{
    public class CheckNewCursus
    {

        private string officeAppNaam;
        private string cursusNaam;
        private string instructieTaal;
        private string gebruikersInterfaceTaal;
        public string OfficeAppNaam { get { return officeAppNaam; } set { officeAppNaam = value.ToLower(); } }
        public string CursusNaam { get { return cursusNaam; } set { cursusNaam = value.ToLower(); } }
        public string InstructieTaal { get { return instructieTaal; } set { instructieTaal = value.ToLower(); } }
        public string GebruikersInterfaceTaal { get { return gebruikersInterfaceTaal; } set { gebruikersInterfaceTaal = value.ToLower(); } }
        public int OnderliggendeModules { get; set; }
        public int OnderliggendeTopics { get; set; }

        public CheckNewCursus()
        {

        }

    }

}

