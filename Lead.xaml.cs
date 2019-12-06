using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for Lead.xaml
    /// </summary>
    public partial class Lead : UserControl
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Lead()
        {
            InitializeComponent();
        }

       

        private void BtnAddLead_Click(object sender, RoutedEventArgs e)
        {
            var addLead = new AddLead(); //create your new form.
            addLead.Show(); //show the new form.
            
        }

        private void LeadsDtGd_Loaded(object sender, RoutedEventArgs e)
        {
            
            string connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
         

            try
            {
                cnn.Open();
                string query= ("Select FirstName,CompanyName,JobTitle,Email,ContactNo, Address, LeadStatus, UserName from tblLead");
                SqlCommand com = new SqlCommand(query,cnn);
                da = new SqlDataAdapter(com);
                
                dt = new DataTable("tblLead");
                da.Fill(dt);
                LeadsDtGd.ItemsSource = dt.DefaultView;

                

                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void LeadsDtGd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            da.Update(dt);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delete = new Delete(); //create your new form.
            delete.Show(); //show the new form.

        }
    }
}
