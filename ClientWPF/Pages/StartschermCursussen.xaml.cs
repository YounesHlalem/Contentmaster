using ClientWPF.DataBinding.Container;
using System;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DTO;
using DTO.Read;

namespace ClientWPF.Pages
{
    public partial class StartschermCursussen : Page
    {
        bool loaded = false;
        public List<CreateCourseDTO> createCourseDTOs = new List<CreateCourseDTO>();
        public List<CourseReadDTO> updateCourse = new List<CourseReadDTO>();
        public List<CourseReadDTO> normal = new List<CourseReadDTO>();

        public StartschermCursussen()
        {
            InitializeComponent();
            KeepAlive = true;
            Container = new ItemsContainer();
            DataContext = Container;
        }

        #region Properties
        public ItemsContainer Container { get; set; }
        #endregion

        #region WPF Event handlers
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (loaded) return;
            List<LanguageReadDTO> lang = (List<LanguageReadDTO>)Context.Instance.Get("Lang");
            List<OfficeApplicationReadDTO> apps = (List<OfficeApplicationReadDTO>)Context.Instance.Get("Apps");

            Language.Items.Add(null);
            lang.ForEach(x =>
            {
                Language.Items.Add(x);
            });
            OfficeApp.Items.Add(null);
            apps.ForEach(x =>
            {
                OfficeApp.Items.Add(x);
            });

            try
            {
                using HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://localhost:5001/api/Cursus/");
                if (response.IsSuccessStatusCode)
                {
                    var listOfCursussen = await response.Content.ReadAsAsync<List<CourseReadDTO>>();
                    listOfCursussen.OrderByDescending(x => x.CreatedOn).Take(50);
                    Container.courses = listOfCursussen;
                    DataGridCursussen.ItemsSource = Container.courses;
                }
            }
            catch { }
            loaded = true;
        }
        private void ButtonResetFilter_Click(object sender, RoutedEventArgs e)
        {
            Container.FilterItem.ForceResetFilter = false;
            ClearFilterTextboxes();
            ButtonActivateFilter_Click(sender, e);
        }
        private void ButtonActivateFilter_Click(object sender, RoutedEventArgs e)
        {
            List<CourseReadDTO> res = (from o in Container.courses where IsFiltered(o) select o).ToList();
            
            DataGridCursussen.ItemsSource = res.ToList();
        }
        private void menuItemNieuw_Click(object sender, RoutedEventArgs e)
        {
            NieuwCursus n = new NieuwCursus();
            n.Created += (sender, c) =>
            {
                CreateCourseDTO t = (CreateCourseDTO)n.DataContext;
                createCourseDTOs.Add(t);
                // NavigationService.Navigate(this);

                var ne = from v in createCourseDTOs
                         select new CourseReadDTO
                         {
                             CreatedOn = DateTime.Now,
                             Name = v.Name,
                             Icon = v.Icon,
                             InstructionsLanguage = ((List<LanguageReadDTO>)Context.Instance.Get("Lang")).FirstOrDefault(x => x.Id == v.InstructionsLanguageId),
                             UserinterfaceLanguage = ((List<LanguageReadDTO>)Context.Instance.Get("Lang")).FirstOrDefault(x => x.Id == v.UserinterfaceLanguageId),
                             OfficeApplication = ((List<OfficeApplicationReadDTO>)Context.Instance.Get("Apps")).FirstOrDefault(x => x.Id == v.OfficeApplicationId)
                         };
                Container.courses = (ne.Union(updateCourse).Union(normal)).ToList();
                DataGridCursussen.ItemsSource = Container.courses;
            };
            this.NavigationService.Navigate(n);
        }
        private void menuItemDetails_Click(object sender, RoutedEventArgs e)
        {
            //MenuItem menuItem = (MenuItem)sender;
            //var contextMenu = (ContextMenu)menuItem.Parent;
            //var item = (DataGrid)contextMenu.PlacementTarget;
            //CourseReadDTO toDeleteFromBindedList = (CourseReadDTO)item.SelectedCells[0].Item;

            //this.NavigationService.Navigate(new DetailsCursus(toDeleteFromBindedList));
            this.NavigationService.Navigate(new DetailsCursus());
        }
        private void menuItemLayout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/CursusLayout.xaml", UriKind.Relative));
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            createCourseDTOs.ForEach(x =>
            {

            });

        }
        #endregion

        #region Selfmade methods
        public void ClearFilterTextboxes()
        {
            Container.FilterItem.Taal = null;
            Container.FilterItem.CursusNaam = "";
            Container.FilterItem.OfficeApp = null;
            Language.SelectedItem = Language.Items[0];
        }
        bool IsFiltered(CourseReadDTO t)
        {
            var a = Container.FilterItem.CursusNaam;
            var b = Container.FilterItem.OfficeApp;
            var c = Container.FilterItem.Taal;

            var aa = a.Length > 0;
            var bb = b != null;
            var cc = c != null;
            if (!(aa | bb | cc)) return true;
            // TODO: Fix this filter
            byte by = 0b0;
            if (aa)
            {
                by += 0b1;
            }
            if(bb)
            {
                by += 0b10;
            }
            if (cc)
            {
                by += 0b100;
            }

            aa = (by & (byte)test.Curs) == (byte)test.Curs;
            bb = (by & (byte)test.Office) == (byte)test.Office;
            cc = (by & (byte)test.Lang) == (byte)test.Lang;
            if (aa)
            {
                aa = t.Name.Like(a);
            }
            if (bb)
            {
                bb = t.OfficeApplication.Name.Like(b.Name);
            }
            if (cc)
            {
                cc = t.InstructionsLanguage.NativeName.Like(c.NativeName);
            }
            var res = aa || bb || cc;

            return res;
        }

        enum test
        {
            Curs = 0b001,
            Office = 0b010,
            Lang = 0b100
        }
        #endregion
    }
}
