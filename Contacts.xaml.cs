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
    /// Interaction logic for Contacts.xaml
    /// </summary>
    public partial class Contacts : UserControl
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Contacts()
        {
            InitializeComponent();
        }

        public static bool Topmost { get; internal set; }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            var addContact  = new AddContact(); //create your new form.
            addContact.Show(); //show the new form.
        }

        private void ContactDgd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ContactDgd_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);


            try
            {
                cnn.Open();
                MessageBox.Show("Connected");
                string query = ("Select FirstName,AccountName,CompanyName,JobTitle,Email,ContactNo, Address,Industry,ContactOwner, Email from tblContacts");
                SqlCommand com = new SqlCommand(query, cnn);
                da = new SqlDataAdapter(com);

                dt = new DataTable("tblContacts");
                da.Fill(dt);
                ContactDgd.ItemsSource = dt.DefaultView;



                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
