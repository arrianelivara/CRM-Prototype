using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace CRMFinal
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = null;
        SqlConnection cnn;
        SqlCommand com = new SqlCommand();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            com.Connection = cnn;
            try
            {
                
                
                cnn.Open();
                string query = ("Select * from tblUserAccounts where Username= '" + LgnUsername.Text + "' and Password='" + LgnPassword.Text + "'");
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                    {
                    MessageBox.Show("Login Successful.");
                    var newForm = new CRMain(); //create your new form.
                    newForm.Show(); //show the new form.
                    this.Close();

                    cnn.Close();
                    }
                else
                {

                    MessageBox.Show("Incorrect Email/Password");
                }

                

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Username/Password.");
            }
        }

      

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
           /* string connectionString = null;
            SqlConnection cnn;
            SqlCommand com = new SqlCommand(); */
            connectionString = @"Data Source=LIVARA\MSSQLSERVER01;Initial Catalog=DbCRM;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            com.Connection = cnn;

            try
            {
                cnn.Open();
                
                com.CommandText = ("Insert into tblUserAccounts (FirstName, LastName, Username, Email, Password, ContactNo) " +
                    "VALUES ('" + FirstName.Text + "' , '" + LastName.Text +"' , '"+Username.Text+"', " +
                    "'"+Email.Text+"','"+Password.Text+"','"+ContactNo.Text+"');");
                com.ExecuteNonQuery();
                var signUp = new SignupPopUp();
                signUp.Show();

                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Not Connected.");
            }
        }

        private void UserAccounts_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
