using ClientWPF.Mocks;
using DTO;
using DTO.Read;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ClientWPF.Pages
{

    public partial class CursusLayout : Page
    {
        MockCourse course;
        ContextMenu menuModules = new ContextMenu();
        MenuItem itemNewModule = new MenuItem()
        {
            Header = "Nieuwe module...",
        };
        ContextMenu menuitems = new ContextMenu();
        MenuItem itemNewTopic = new MenuItem()
        {
            Header = "Nieuwe topic...",
        };

        public CursusLayout()
        {
            InitializeComponent();
            //LoadData();
            //LoadTree();
            menuModules.Items.Add(itemNewModule);
            menuitems.Items.Add(itemNewTopic);
            lblCursus.ContextMenu = menuModules;
            itemNewModule.Click += itemNewModule_Click;
            itemNewTopic.Click += itemNewTopic_Click;
            DataContext = new CourseReadDTO();
        }

        private void LoadTree()
        {

            //ModulesTreeView(root);
        }

        //private TreeView ModulesTreeView(TreeView root)
        //{

        //    //foreach (MockModule m in course.GetModulesList())
        //    //{
        //    //    TreeViewItem modules = new TreeViewItem
        //    //    {
        //    //        Header = m.Title

        //    //    };
        //    //    modules.ContextMenu = menuModules;
        //    //    GetModules(m, modules);
        //    //    root.Items.Add(modules);
        //    //}
        //    //return root;
        //}

        //private TreeViewItem GetModules(MockModule mockModule, TreeViewItem root)
        //{

        //    //foreach (MockModuleTopic item in mockModule.GetMockModuleTopics())
        //    //{
        //    //    TreeViewItem child = new TreeViewItem
        //    //    {
        //    //        Header = item.Title
        //    //    };
        //    //    GetTopics(item, child);
        //    //    root.Items.Add(child);
        //    //    child.ContextMenu = menuitems;
        //    //}
        //    //return root;
        //}
        //private TreeViewItem GetTopics(MockModuleTopic mockTopic, TreeViewItem root)
        //{

        //    //foreach (var item in mockTopic.GetElementList())
        //    //{
        //    //    var child = new TreeViewItem
        //    //    {
        //    //        Header = item.Title
        //    //    };
        //    //    root.Items.Add(child);
        //    //}
        //    //return root;
        //}

        private void LoadData()
        {
            //course = new MockCourse { OfficeApplicatieNaam = "Word 365", Cursusnaam = "Formatting", GebruikersinterfaceTaal = "Engels", Instructietaal = "Engels" };

            //{
            //    MockModule module = CreateMockModule("Module 1");
            //    AddModuleToCourse(new List<MockModule> { module });
            //    //MockModuleTopic topic1 = CreateMockTopic("Topic 1.1");
            //    //MockModuleTopic topic2 = CreateMockTopic("Topic 1.2");
            //    //AddTopicToModule(new List<MockModuleTopic> { topic1, topic2 }, module);
            //    //ModuleTopicElement element1 = CreateMockTopicElement("Element 1.1.1");
            //    //ModuleTopicElement element2 = CreateMockTopicElement("Element 1.1.2");
            //    //AddTopicElementToTopic(new List<ModuleTopicElement> { element1, element2 }, topic1);
            //    //ModuleTopicElement element21 = CreateMockTopicElement("Element 1.2.1");
            //    //ModuleTopicElement element22 = CreateMockTopicElement("Element 1.2.2");
            //    //AddTopicElementToTopic(new List<ModuleTopicElement> { element21, element22 }, topic2);

            //}

            //{
            //    MockModule module = CreateMockModule("Module 2");
            //    AddModuleToCourse(new List<MockModule> { module });
            //    MockModuleTopic topic1 = CreateMockTopic("Topic 2.1");
            //    MockModuleTopic topic2 = CreateMockTopic("Topic 2.2");
            //    AddTopicToModule(new List<MockModuleTopic> { topic1, topic2 }, module);
            //    ModuleTopicElement element1 = CreateMockTopicElement("Element 2.1.1");
            //    ModuleTopicElement element2 = CreateMockTopicElement("Element 2.1.2");
            //    AddTopicElementToTopic(new List<ModuleTopicElement> { element1, element2 }, topic1);
            //    ModuleTopicElement element21 = CreateMockTopicElement("Element 2.2.1");
            //    ModuleTopicElement element22 = CreateMockTopicElement("Element 2.2.2");
            //    AddTopicElementToTopic(new List<ModuleTopicElement> { element21, element22 }, topic2);
            //}


            DataContext = course;
        }

        private ContextMenu CreateContextMenu(List<MenuItem> items)
        {
            var contextMenu = new ContextMenu();
            foreach (var item in items)
            {
                contextMenu.Items.Add(item);
            }

            return contextMenu;
        }

        private MockModule CreateMockModule(string title)
        {
            if (!IsNull(title))
            {
                return new MockModule(title);
            }
            else
            {
                return new MockModule();
            }
        }

        private MockModuleTopic CreateMockTopic(string title)
        {
            if (!IsNull(title))
            {
                return new MockModuleTopic(title);
            }
            else
            {
                return new MockModuleTopic();
            }
        }

        private ModuleTopicElement CreateMockTopicElement(string title)
        {
            if (!IsNull(title))
            {
                return new ModuleTopicElement(title);
            }
            else
            {
                return new ModuleTopicElement();
            }
        }

        private bool AddModuleToCourse(List<MockModule> modules)
        {

            if (modules.Count != 0 || !IsNull(modules))
            {
                foreach (MockModule module in modules)
                {
                    course.AddModule(module);
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool AddTopicToModule(List<MockModuleTopic> topics, MockModule module)
        {

            if (topics.Count != 0 || !IsNull(topics))
            {
                foreach (MockModuleTopic topic in topics)
                {
                    module.AddTopic(topic);
                }

                return true;
            }
            else
            {
                return false;
            }

        }

        private bool AddTopicElementToTopic(List<ModuleTopicElement> topicElements, MockModuleTopic topic)
        {
            if (topicElements.Count != 0 || !IsNull(topicElements))
            {
                foreach (ModuleTopicElement topicElement in topicElements)
                {
                    topic.AddTopicElement(topicElement);
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool IsNull(object input)
        {
            return input == null;

        }

        void itemNewModule_Click(object sender, RoutedEventArgs e)
        {
            //course.AddModule(new MockModule {Title="Module 3" });
            //root.Items.Clear();
            //LoadTree();
            PageNewModule pv = new PageNewModule();
            pv.DataContext = new CreateModuleDTO { CourseId = 1 };
            NavigationService.Navigate(pv);

        }

        private void itemNewTopic_Click(object sender, RoutedEventArgs e)
        {
            //PageNewTopic tp = new PageNewTopic();
            //tp.DataContext = new CreateTopicDTO { TopicID = (TopicDTO)(DataContext).Id };
            //NavigationService.Navigate(tp);
        }

        private void ButtonNavigateBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://localhost:5001/api/Cursus/1"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        CourseReadDTO d = await response.Content.ReadAsAsync<CourseReadDTO>();
                        DataContext = d;
                    }
                }
            }
            catch { }
        }

        private void buttonEditModule_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
