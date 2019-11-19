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

namespace CRMFinal
{
    /// <summary>
    /// Interaction logic for Deals.xaml
    /// </summary>
    public partial class Deals : UserControl
    {
        public Deals()
        {
            InitializeComponent();
        }

        public static bool Topmost { get; internal set; }

        private void AddLeads_Click(object sender, RoutedEventArgs e)
        {
            var addDeals = new AddDeal(); //create your new form.
            addDeals.Show(); //show the new form.
        }
    }
}
