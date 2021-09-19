using ClientWPF.Handlers;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClientWPF.Pages
{
    public partial class MenuBalk : Page
    {
        public class MenuBalkItems
        {
            public string Name { get; set; }
            public event MenuChangeHandler change;
            public string IconName { get; set; }
            public PackIconKind Icon { get; internal set; }

            public void callBack(object sender)
            {
                change?.Invoke(sender, Name);
            }
        }

        public event MenuOpenHandler openMenu;

        private List<MenuBalkItems> buttons = new List<MenuBalkItems>();

        private bool open = false;
        public bool Open { get => open; }

        public MenuBalk()
        {
            InitializeComponent();
        }

        public void AddItem(MenuBalkItems item)
        {
            buttons.Add(item);
            UpdateLayout();
        }
        public void AddRange(ICollection<MenuBalkItems> items)
        {
            buttons.AddRange(items);
            UpdateLayout();
        }
        public void RemoveItem(MenuBalkItems item)
        {
            buttons.Remove(item);
            UpdateLayout();
        }
        public void RemoveItem(int index)
        {
            buttons.RemoveAt(index);
            UpdateLayout();
        }

        private void toggleOpen(object sender, RoutedEventArgs e)
        {
            /*if (openMenu != null) openMenu.Invoke(this, !open);
            open = !open;
            if (open)
            {
                ((Button)Pannel.Children[0]).Content = "<<";
            }
            else
            {
                ((Button)Pannel.Children[0]).Content = ">>";
            }*/
            UpdateLayout();
        }

        private new void UpdateLayout()
        {
            foreach (var item in buttons)
            {
                TabItem ti = new TabItem();
                ti.ToolTip = item.Name;
                ti.MouseDown += (s, e) =>
                {
                    item.callBack(this);
                };

                ti.Width = 50;
                ti.Height = 50;
                ti.Style = test.Style;
                var v = new PackIcon();
                v.FontSize=24;
                v.Kind = item.Icon;
                ti.Foreground = test.Foreground;
                ti.Cursor = test.Cursor;

                ti.Header = v;
                ti.MouseDown += (s, a) =>
                {

                };

                Pannel.Items.Add(ti);
                // ti.Cursor = 
            }
            /*Pannel.Children.RemoveRange(0, Pannel.Children.Count);
            {
                Button btn = new Button();
                btn.Background = Brushes.Gray;
                btn.Content = (open) ? "<<" : ">>";
                btn.Click += toggleOpen;
                Pannel.Children.Add(btn);
            }
            foreach (var item in buttons)
            {
                Button btn = new Button();
                btn.Background = Brushes.Gray;
                if (open | item.IconName == null)
                {
                    btn.Content = item.Name;
                }
                else
                {
                    if (Application.Current.Resources.Contains(item.IconName))
                    {
                        Viewbox vb = new Viewbox();
                        Path p = new Path();
                        p.Data = Application.Current.Resources[item.IconName] as Geometry;
                        p.Fill = Brushes.Black;
                        p.Stroke = Brushes.Black;
                        vb.Child = p;
                        vb.Stretch = Stretch.Uniform;
                        btn.Content = vb;
                    }
                    else
                    {
                        btn.Content = item.Name;
                    }
                }
                btn.Height = 50;
                btn.Click += (s, e) =>
                {
                    item.callBack(this);
                };
                Pannel.Children.Add(btn);
            }*/
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateLayout();
        }

        private void Pannel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = Pannel.SelectedIndex;
            buttons[i].callBack(this);
        }
    }
}
