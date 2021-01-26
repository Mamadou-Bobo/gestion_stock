using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionStockApp.Model;
using System.Security.Cryptography;


namespace GestionStockApp
{
    public partial class frmResetPasswordByAdmin : Form
    {
        gestionstockEntities db = new gestionstockEntities();

        public frmResetPasswordByAdmin()
        {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

            var user = db.utilisateur.Where(a => a.login == txtIdenfiant.Text).FirstOrDefault();

            using(MD5 md5Hash = MD5.Create())
            {
                if(user == null)
                {
                    MessageBox.Show("Cet utilisateur n'existe pas");
                    lblMessage.Text = "";
                }  else
                {
                    if (txtMotDePasse.Text == txtConfimerMotDePasse.Text && (txtIdenfiant.Text != "" && txtMotDePasse.Text != ""))
                    {
                        user.password = GetMd5Hash(md5Hash, txtMotDePasse.Text);
                        db.SaveChanges();
                        MessageBox.Show("Le mot de passe a été modifié avec succès");
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Les mots de passe ne correspondent pas";
                    }
                }               
            }
        }
    }
}
