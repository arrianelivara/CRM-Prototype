using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CRMFinal
{
    /// <summary>
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void CloseContact_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            
        }

        private void ContactSave_Click(object sender, RoutedEventArgs e)
        {

            SqlCommand com = new SqlCommand();
            string connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            com.Connection = cnn;

            try
            {
                cnn.Open();
                     com.CommandText = ("INSERT INTO tblContacts (ContactOwner, FirstName, LastName, AccountName, CompanyName, JobTitle, Industry, Email, ContactNo, Address) " +
                     "VALUES ('" + ContactOwner.Text + "','" + FirstName.Text + "' , '" + LastName.Text + "' , '" + CompanyName.Text + "' , '" + CompanyName.Text + "', " +
                     "'" + JobTitle.Text + "','" + Industry.Text + "','" + ContactEmail.Text + "','" + ContactNo.Text + "','" + Address.Text + "');");
                //SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                com.ExecuteNonQuery();
                cnn.Close();

                var success = new Success(); //create your new form.
                success.Show();
                Thread.Sleep(3000);
                success.Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
