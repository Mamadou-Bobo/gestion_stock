using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using GestionStockApp.Model;

namespace GestionStockApp
{
    public partial class frmLogin : Form
    {
        public static string userId { get; set; }

        gestionstockEntities db = new gestionstockEntities();
        
        public frmLogin()
        {
            InitializeComponent();
        }
   
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnConnecter_Click_1(object sender, EventArgs e)
        {
            frmResetPassword frmReset = new frmResetPassword();
            utilisateur ut = new utilisateur();
            
            var user = db.utilisateur.Where(a => a.login ==
            txtIdentifiant.Text).FirstOrDefault();
            string hash = user != null ? user.password : string.Empty;

            bool firstConnexion = true;

            if (user != null)
            {
                firstConnexion = user.firstConnexion;
            }
            else
            {
                lblMessage.Text = "Identifiant ou mot de passe incorrecte";
            }         

            using (MD5 md5Hash = MD5.Create())
            {
                if(user == null)
                {
                    lblMessage.Text = "Identifiant ou mot de passe incorrect";
                }
                else if (user.statut.Equals("non_actif"))
                {
                     hash = string.Empty;
                     lblMessage.Text = "";
                     MessageBox.Show("Votre compte est désactivé");       
                }
                else if (VerifyMd5Hash(md5Hash, txtMotDePasse.Text, hash))
                {
                    // rédirige la personne vers une fenêtre pour qu'il modifie son mot de passe
                    if (firstConnexion == true)
                    {
                        frmReset.currentUser = txtIdentifiant.Text;
                        frmReset.Show();
                        this.Hide();
                    } else
                    {
                        frmMDI f = new frmMDI();
                        frmMDI.txtIdentifiant = txtIdentifiant.Text;
                        userId = txtIdentifiant.Text;
                        f.Show();
                        this.Hide();       
                    }

                }
                else
                {
                    lblMessage.Text = "Identifiant ou mot de passe incorrect";
                }
            }
        }

        private void cbAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAfficherMotDePasse.Checked)
            {
                txtMotDePasse.UseSystemPasswordChar = false;
            } else
            {
                txtMotDePasse.UseSystemPasswordChar = true;
            }
        }

       

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
