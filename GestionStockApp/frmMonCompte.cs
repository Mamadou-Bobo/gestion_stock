using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using GestionStockApp.Model;
using System.Text;

namespace GestionStockApp
{
    public partial class frmMonCompte : Form
    {
        public static string date { get; set; }

        gestionstockEntities db = new gestionstockEntities();

        public frmMonCompte()
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

        private void cbAncienMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAncienMotDePasse.Checked)
            {
                txtAncienMotDePasse.UseSystemPasswordChar = false;
            } else
            {
                txtAncienMotDePasse.UseSystemPasswordChar = true;
            }
        }

        private void frmMonCompte_Load(object sender, EventArgs e)
        {
            var user = db.utilisateur.Where(a => a.login == frmLogin.userId).FirstOrDefault();
            lblIdentifiant.Text = user.login;
            lblDateCreation.Text = user.createdAt.ToString();
            lblDateDerniereConnexion.Text = user.connectedAt.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var user = db.utilisateur.Where(a => a.login ==
            frmLogin.userId).FirstOrDefault();

            using (MD5 md5Hash = MD5.Create())
            {
                string lastPassword = GetMd5Hash(md5Hash, txtAncienMotDePasse.Text);

                if (!lastPassword.Equals(user.password) && txtAncienMotDePasse.Text != "")
                {
                    lblMessage.Text = "Le mot de passe est incorrecte";
                } else if(!txtNouveauMotDePasse.Text.Equals(txtConfirmerMotDePasse.Text)
                          && (txtNouveauMotDePasse.Text != "" && txtConfirmerMotDePasse.Text != ""))
                {
                    lblMessage.Text = "Les mots de passe ne correspondent pas";
                } else if(txtNouveauMotDePasse.Text == "" || txtConfirmerMotDePasse.Text == ""
                    || txtAncienMotDePasse.Text == "")
                {
                    lblMessage.Text = "Vueillez renseigner tous les champs";
                }
                else
                {
                    user.password = GetMd5Hash(md5Hash, txtNouveauMotDePasse.Text);
                    db.SaveChanges();
                    txtAncienMotDePasse.Clear();
                    txtNouveauMotDePasse.Clear();
                    txtConfirmerMotDePasse.Clear();
                    MessageBox.Show("Le mot de passe a été modifié avec succès");                    
                    lblMessage.Text = "";
                }
            }
        }
    }
}
