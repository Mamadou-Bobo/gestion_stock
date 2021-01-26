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

namespace GestionStockApp
{
    public partial class frmCategorie : Form
    {

        gestionstockEntities db = new gestionstockEntities();

        public frmCategorie()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            categorie categ = new categorie();

            if(txtNomCategorie.Text == "")
            {
                MessageBox.Show("Le champ ne peut pas être vide");
            } else if(txtNomCategorie.Text.Length < 4)
            {
                txtNomCategorie.Clear();
                txtNomCategorie.Focus();
                MessageBox.Show("Vueillez saisir au moins 4 caractères");
            } else
            {
                categ.Categorie = txtNomCategorie.Text;
                db.categorie.Add(categ);
                db.SaveChanges();
                MessageBox.Show("Une nouvelle catégorie a été ajoutée");
                txtNomCategorie.Clear();
                txtNomCategorie.Focus();
                refresh();
            }
        }

        private void refresh()
        {
            dgCategorie.DataSource = db.categorie.ToList();
        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.categorie.ToList();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtNomCategorie.Text == "")
            {
                MessageBox.Show("Le champ ne peut pas être vide");
            }
            else if (txtNomCategorie.Text.Length < 4)
            {
                txtNomCategorie.Focus();
                MessageBox.Show("Vueillez saisir au moins 4 caractères");
            } 
            else
            {
                int idCategorie = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());

                categorie cat = db.categorie.Find(idCategorie);
                cat.Categorie = txtNomCategorie.Text;
                db.SaveChanges();
                MessageBox.Show("La catégorie a été modifiée avec succès");
                txtNomCategorie.Clear();
                txtNomCategorie.Focus();
                refresh();
            }


        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtNomCategorie.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
