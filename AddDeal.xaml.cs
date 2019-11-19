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
    /// Interaction logic for AddDeal.xaml
    /// </summary>
    public partial class AddDeal : Window
    {
        public AddDeal()
        {
            InitializeComponent();
        }

        private void CloseDeal_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
