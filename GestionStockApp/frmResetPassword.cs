using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionStockApp.Model;
using System.Security.Cryptography;

namespace GestionStockApp
{
    public partial class frmResetPassword : Form
    {
        gestionstockEntities db = new gestionstockEntities();

        public string currentUser { get; set; }

        public frmResetPassword()
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

        private void btnRéinitialiser_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                
                var id = db.utilisateur.Where(a => a.login == currentUser).FirstOrDefault().id;
                utilisateur user = db.utilisateur.Find(id);

                if(!txtNouveauMotDePasse.Text.Equals(txtConfirmerMotDePasse.Text)
                    && (txtNouveauMotDePasse.Text != "" && txtConfirmerMotDePasse.Text != ""))
                {
                    lblMessage.Text = "Les mots de passe ne correspondent pas";
                } else if(txtNouveauMotDePasse.Text == "" || txtConfirmerMotDePasse.Text == "")
                {
                    lblMessage.Text = "Veuillez saisir tous les champs";
                } else
                {
                    user.password = GetMd5Hash(md5Hash, txtNouveauMotDePasse.Text);
                    user.firstConnexion = false;//la valeur devient 0 dans la bd si on réinitialise le mdp
                    db.SaveChanges();
                    MessageBox.Show("Le mot de passe a été modifié avec succès");
                    frmLogin f = new frmLogin();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void cbAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficherMotDePasse.Checked)
            {
                txtNouveauMotDePasse.UseSystemPasswordChar = false;
            }
            else
            {
                txtNouveauMotDePasse.UseSystemPasswordChar = true;
            }
        }
    }
}


