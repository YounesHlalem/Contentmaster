using System;
using System.Collections.Generic;
using System.Text;

namespace ClientWPF.Mocks
{
    class MockCourse
    {
        public string OfficeApplicatieNaam { get; set; }
        public string Cursusnaam { get; set; }
        public string Instructietaal { get; set; }
        public string GebruikersinterfaceTaal { get; set; }
        public int AantalModules { get; }
        private List<MockModule> modules { get; set; }

        public MockCourse(string officeApplicatieNaam, string cursusnaam, string instructietaal, string gebruikersinterfaceTaal)
        {
            OfficeApplicatieNaam = officeApplicatieNaam;
            Cursusnaam = cursusnaam;
            Instructietaal = instructietaal;
            GebruikersinterfaceTaal = gebruikersinterfaceTaal;
            AantalModules = modules.Count;
            modules = new List<MockModule>();
        }

        public MockCourse()
        {
            modules = new List<MockModule>();
        }

        public void AddModule(MockModule m)
        {
            modules.Add(m);
        }

        public List<MockModule> GetModulesList()
        {
            return modules;
        }



    }
}
