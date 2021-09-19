using ClientWPF.Pages;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;
using static ClientWPF.Pages.MenuBalk;

namespace ClientWPF
{
    public partial class MainWindow : Window
    {
        readonly MenuBalk MenuBalk;
        readonly StartschermCursussen StartschermCursussen;
        readonly List<MenuBalkItems> menuItems = new List<MenuBalkItems>();

        public MainWindow()
        {
            InitializeComponent();
            MenuBalk = new MenuBalk();
            StartschermCursussen = new StartschermCursussen();
            MenuBalk.openMenu += ToggleSideMenu;
            {
                MenuBalkItems Cursussen = new MenuBalkItems { Name = "Cursussen", IconName = "Cursussen", Icon=PackIconKind.TableEye };
                Cursussen.change += (e, a) =>
                {
                    mainWindow.Content = StartschermCursussen;
                };
                menuItems.Add(Cursussen);
            }
            {
                MenuBalkItems Quizen = new MenuBalkItems { Name = "Quizzen", IconName = "Quizzen", Icon=PackIconKind.FileMultiple };
                Quizen.change += (e, a) =>
                {
                    mainWindow.Content = new Quizzes();
                };
                menuItems.Add(Quizen);
            }
            {
                MenuBalkItems Vragen = new MenuBalkItems { Name = "Vragen", IconName = "Vragen", Icon = PackIconKind.Shape };
                Vragen.change += (e, a) =>
                {

                };
                menuItems.Add(Vragen);
            }
            {
                MenuBalkItems Oefenbestanden = new MenuBalkItems { Name = "Oefenbestanden", IconName = "Oefenbestanden", Icon = PackIconKind.AccountSupervisorCircle };
                Oefenbestanden.change += (e, a) =>
                {

                };
                menuItems.Add(Oefenbestanden);
            }
            {
                MenuBalkItems item = new MenuBalkItems { Name = "Themas", IconName = "Themas", Icon = PackIconKind.AccountGroup };
                item.change += (e, a) =>
                {
                   
                };
                menuItems.Add(item);
            }
            {
                MenuBalkItems item = new MenuBalkItems { Name = "Uitrol", IconName = "Uitrol", Icon= PackIconKind.AccountMultipleMinus };
                item.change += (e, a) =>
                {

                };
                menuItems.Add(item);
            }
            {
                MenuBalkItems item = new MenuBalkItems { Name = "Wachtwoord Instellen", IconName = "WachtwoordInstellen", Icon= PackIconKind.Lock };
                item.change += (e, a) =>
                {

                };
                menuItems.Add(item);
            }
            {
                MenuBalkItems item = new MenuBalkItems { Name = "Gebruikers", IconName = "Gebruikers", Icon= PackIconKind.CommentQuestion };
                item.change += (e, a) =>
                {

                };
                menuItems.Add(item);
            }
            /*{
                MenuBalkItems item = new MenuBalkItems { Name = "Rollen", IconName = "Rollen" };
                item.change += (e, a) =>
                {

                };
                menuItems.Add(item);
            }*/
        }

        private void Item_change(object sender, string page)
        {
            throw new NotImplementedException();
        }

        private void ToggleSideMenu(object sender, bool Open)
        {
            if (!Open)
            {
                sideWindow.Width = 50;
            }
            else
            {
                sideWindow.Width = 250;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sideWindow.Content = MenuBalk;
            mainWindow.Content = StartschermCursussen;

            // Load menu items
            MenuBalk.AddRange(menuItems);
        }
    }
}
