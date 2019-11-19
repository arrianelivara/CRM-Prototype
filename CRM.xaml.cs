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
            int zOrder2 = Panel.GetZIndex(Deals1) + 1;
            Panel.SetZIndex(Leads1, zOrder2);
            
        }

        private void BtnContacts_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder2 = Panel.GetZIndex(Deals1) + 1;
            Panel.SetZIndex(Contacts1, zOrder2);
        }

        private void BtnDeals_Click(object sender, RoutedEventArgs e)
        {
            int zOrder = Panel.GetZIndex(Leads1) + 1;
            int zOrder2 = Panel.GetZIndex(Contacts1) + 1;
            Panel.SetZIndex(Deals1, zOrder2);
        }

       
}
}
