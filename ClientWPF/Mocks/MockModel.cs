using System;

namespace ClientWPF.MockData
{
    public class MockModel
    {
        private string officeAppNaam;
        private string cursusNaam;
        private string instructieTaal;
        private string gebruikersInterfaceTaal;
        private static int id = 0;
        public int MockId { get; }
        public string OfficeAppNaam { get { return officeAppNaam; } set { officeAppNaam = value.ToLower(); } }
        public string CursusNaam { get { return cursusNaam; } set { cursusNaam = value.ToLower(); } }
        public string InstructieTaal { get { return instructieTaal; } set { instructieTaal = value.ToLower(); } }
        public string GebruikersInterfaceTaal { get { return gebruikersInterfaceTaal; } set { gebruikersInterfaceTaal = value.ToLower(); } }
        public int OnderliggendeModules { get; set; }
        public int OnderliggendeTopics { get; set; }
        public string DatumCreatie { get; set; }

        public MockModel(string officeAppNaam, string cursusNaam, string instructieTaal, string gebruikeresInterfaceTaal, int onderliggendeModules, int onderliggendeTopics)
        {
            id++;
            this.MockId = id;
            this.OfficeAppNaam = officeAppNaam;
            this.CursusNaam = cursusNaam;
            this.InstructieTaal = instructieTaal;
            this.GebruikersInterfaceTaal = gebruikeresInterfaceTaal;
            this.OnderliggendeModules = onderliggendeModules;
            this.OnderliggendeTopics = onderliggendeTopics;
            this.DatumCreatie = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public MockModel(string officeAppNaam, string cursusNaam, string instructieTaal, string gebruikeresInterfaceTaal)
        {
            id++;
            this.MockId = id;
            this.OfficeAppNaam = officeAppNaam;
            this.CursusNaam = cursusNaam;
            this.InstructieTaal = instructieTaal;
            this.GebruikersInterfaceTaal = gebruikeresInterfaceTaal;
            this.DatumCreatie = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
