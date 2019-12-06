using System;
using System.Data.SqlClient;
using System.Windows;

namespace CRMFinal
{
    /// <summary>
    /// Interaction logic for AddLead.xaml
    /// </summary>
    public partial class AddLead : Window
    {
        
        public AddLead()
        {
            InitializeComponent();
        }

        



        private void CloseLead_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            
            SqlCommand com = new SqlCommand();
            string connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            com.Connection = cnn;

            try
            {
               cnn.Open();
               com.CommandText = ("INSERT INTO tblLead (Username, FirstName, LastName, CompanyName, JobTitle, Industry, Email, ContactNo, Address, LeadStatus) " +
                    "VALUES ('" + btnLeadOwner.Text + "','" + btnFirstName.Text + "' , '" + btnLastName.Text + "' , '" + btnCompany.Text + "', " +
                    "'" + btnJobTitle.Text + "','" + btnIndustry.Text + "','" + btnEmail.Text + "','" + btnContactNo.Text + "','" + btnAddress.Text + "','" + btnLeadStatus.Text + "');");
                //SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                com.ExecuteNonQuery();
                var newForm = new Success(); //create your new form.
                newForm.Show(); //show the new form.
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
