using System;
using System.Linq;
using System.Windows.Forms;
using GestionStockApp.Model;

namespace GestionStockApp
{
    public partial class frmProduit : Form
    {

        gestionstockEntities db = new gestionstockEntities();
        
        public frmProduit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCategorie.DataSource = db.categorie.Select(name => new { ID = name.id, Nom = name.Categorie }).ToList();
            cbbCategorie.DisplayMember = "Nom";
            cbbCategorie.ValueMember = "ID";
            var request = (from p in db.produit join cat in db.categorie on p.codeCat
                               equals cat.id select new { p.id, p.libelle, p.description,
                               p.quantite, p.quantiteMin, p.prix, cat.Categorie} ).ToList();
            dbProduit.DataSource = request;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtDescription.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtPrix.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtQuantiteMinimale.Text = string.Empty;
            dbProduit.DataSource = db.produit.ToList();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            approvisionnement appro = new approvisionnement();
            produit produit = new produit();
            produit.libelle = txtLibelle.Text;
            produit.prix = double.Parse(txtPrix.Text);
            produit.quantite = double.Parse(txtQuantite.Text);
            produit.quantiteMin = double.Parse(txtQuantiteMinimale.Text);
            produit.description = txtDescription.Text;
            produit.codeCat = int.Parse(cbbCategorie.SelectedValue.ToString());
            db.produit.Add(produit);
            db.SaveChanges();
            effacer();
        }

        private void effacer()
        {
            txtDescription.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtPrix.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtQuantiteMinimale.Text = string.Empty;

            dbProduit.DataSource = db.produit.ToList();
            txtLibelle.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = dbProduit.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dbProduit.CurrentRow.Cells[2].Value.ToString();
            txtQuantite.Text = dbProduit.CurrentRow.Cells[3].Value.ToString();
            txtQuantiteMinimale.Text = dbProduit.CurrentRow.Cells[4].Value.ToString();
            txtPrix.Text = dbProduit.CurrentRow.Cells[5].Value.ToString();
            cbbCategorie.Text = dbProduit.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dbProduit.CurrentRow.Cells[0].Value.ToString());
            produit produit = db.produit.Find(id);
            produit.libelle = txtLibelle.Text;
            produit.prix = double.Parse(txtPrix.Text);
            produit.quantite = double.Parse(txtQuantite.Text);
            produit.quantiteMin = double.Parse(txtQuantiteMinimale.Text);
            produit.description = txtDescription.Text;
            produit.codeCat = int.Parse(cbbCategorie.SelectedValue.ToString());
            db.SaveChanges();
            effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dbProduit.CurrentRow.Cells[0].Value.ToString());
            produit produit = db.produit.Find(id);
            db.produit.Remove(produit);
            db.SaveChanges();
            effacer();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var lesProduits = db.produit.ToList();

            if(!string.IsNullOrEmpty(txtLibelle.Text))
            {
                lesProduits = lesProduits.Where(a =>
                a.libelle.ToUpper().Contains(
                    txtLibelle.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                lesProduits = lesProduits.Where(a =>
                a.description.ToUpper().Contains(
                    txtDescription.Text.ToUpper())).ToList();
            }

            dbProduit.DataSource = lesProduits.ToList();
        }

        
    }
}