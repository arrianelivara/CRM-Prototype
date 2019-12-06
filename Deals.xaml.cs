using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
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

        private void DtgDeals_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);


            try
            {
                cnn.Open();
                string query = ("Select DealName,Amount,Stage,Probability,ExpectedRevenue, DateCreated, ClosingDate from tblDeals");
                SqlCommand com = new SqlCommand(query, cnn);
                da = new SqlDataAdapter(com);

                dt = new DataTable("tblDeals");
                da.Fill(dt);
                DtgDeals.ItemsSource = dt.DefaultView;



                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
