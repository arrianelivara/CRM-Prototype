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
using System.Windows.Shapes;

namespace CRMFinal
{
    /// <summary>
    /// Interaction logic for CRMain.xaml
    /// </summary>
    public partial class CRMain : Window
    {
        public CRMain()
        {
            InitializeComponent();
        }

       
       
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButton.IsChecked == true)
            {
                date.Visibility = Visibility.Visible;
                date.BringIntoView();
            }
            else
            {
                date.Visibility = Visibility.Hidden;
            }
        }

       
        private void BtnLeads_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Contacts1) + 1;
            int zOrder0 = Panel.GetZIndex(Activities1) + 1;
            int zOrder1 = Panel.GetZIndex(Home1) + 1;
            int zOrder2 = Panel.GetZIndex(Deals1) + 1;
            int zOrder3 = zOrder + zOrder0 + zOrder1 + zOrder2;
            Panel.SetZIndex(Leads1, zOrder3);
            
            
        }

        private void BtnContacts_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder0 = Panel.GetZIndex(Activities1) + 1;
            int zOrder1 = Panel.GetZIndex(Home1) + 1;
            int zOrder2 = Panel.GetZIndex(Deals1) + 1;
            int zOrder3 = zOrder + zOrder0 + zOrder1 + zOrder2;
            Panel.SetZIndex(Contacts1, zOrder3);
             
        }

        private void BtnDeals_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder0 = Panel.GetZIndex(Activities1) + 1;
            int zOrder1 = Panel.GetZIndex(Home1) + 1;
            int zOrder2 = Panel.GetZIndex(Contacts1) + 1;
            int zOrder3 = zOrder + zOrder0 + zOrder1 + zOrder2;
            Panel.SetZIndex(Deals1, zOrder3);
             
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder0 = Panel.GetZIndex(Activities1) + 1;
            int zOrder1 = Panel.GetZIndex(Deals1) + 1;
            int zOrder2 = Panel.GetZIndex(Contacts1) + 1;
            int zOrder3 = zOrder + zOrder0 + zOrder1 + zOrder2 ;
            Panel.SetZIndex(Home1, zOrder3);
        }

        private void BtnActivities_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder0 = Panel.GetZIndex(Home1) + 1;
            int zOrder1 = Panel.GetZIndex(Deals1) + 1;
            int zOrder2 = Panel.GetZIndex(Contacts1) + 1;
            int zOrder3 = zOrder + zOrder0 + zOrder1 + zOrder2;
            Panel.SetZIndex(Activities1, zOrder3);
        }
    }
}
