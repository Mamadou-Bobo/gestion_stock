using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using GestionStockApp.Model;

namespace GestionStockApp
{
    public partial class frmUtilisateur : Form
    {   

        gestionstockEntities db = new gestionstockEntities();

        public frmUtilisateur()
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

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            dgUtilisateur.DataSource = db.utilisateur.Select(a => new {
                a.id,
                a.login,
                a.profil,
                a.statut
            }).ToList();
        }

        private void formLoad()
        {
            dgUtilisateur.DataSource = db.utilisateur.Select(a => new {
                a.id,
                a.login,
                a.profil,
                a.statut
            }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            utilisateur ut = new utilisateur();

            using (MD5 md5Hash = MD5.Create())
            {
                if (db.utilisateur.SingleOrDefault(userName =>
                 userName.login == txtIdentifiant.Text
                ) == null )
                {
                    ut.login = txtIdentifiant.Text;
                    ut.password = GetMd5Hash(md5Hash, "P@sser123");
                    ut.profil = cbbProfil.Text;
                    ut.firstConnexion = true;
                    ut.statut = "actif";
                    ut.connectedAt = string.Empty;
                    db.utilisateur.Add(ut);
                    db.SaveChanges();
                    MessageBox.Show("L'utilisateur a été ajouté avec succès");
                    txtIdentifiant.Clear();
                    txtIdentifiant.Focus();
                    formLoad();
                } else
                {
                    ut.firstConnexion = false;
                    MessageBox.Show("Cet utilisateur existe déjà");
                }
                
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            utilisateur user = db.utilisateur.Find(id);

            user.login = txtIdentifiant.Text;
            user.profil = cbbProfil.SelectedItem.ToString();
            db.SaveChanges();

            formLoad();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtIdentifiant.Text = dgUtilisateur.CurrentRow.Cells[1].Value.ToString();
            cbbProfil.Text = dgUtilisateur.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnActiverDesactiver_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            utilisateur user = db.utilisateur.Find(id);
            string message = "";
            if(user.statut.Equals("actif"))
            {
                message = "Le compte a été désactivé avec succès";
                user.statut = "non_actif";
            } else if(user.statut.Equals("non_actif"))
            {
                user.statut = "actif";
                message = "Le compte a été activé avec succès";
            }

            db.SaveChanges();
            formLoad();

            MessageBox.Show(message);

            txtIdentifiant.Clear();
            txtIdentifiant.Focus();

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPasswordByAdmin f = new frmResetPasswordByAdmin();

            f.Show();
        }

    }

}
