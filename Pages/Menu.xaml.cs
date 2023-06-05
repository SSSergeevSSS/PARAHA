using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Administration.Classes;
using Administration.Pages;

namespace Administration.Pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void PopulationBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Population());
        }

        private void StaffBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Staff());
        }

        private void ApplicationsBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Application());
        }
    
        private void AdministrationBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Administration());
        }


        private void MenuFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void MenuFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
