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
    public partial class frmApprovisionnement : Form
    {
        gestionstockEntities db = new gestionstockEntities();

        public frmApprovisionnement()
        {
            InitializeComponent();
        }

        private void frmApprovisionnement_Load(object sender, EventArgs e)
        {
            
            var request = (from p in db.produit
                           join app in db.approvisionnement on p.id equals app.idProduit
                           join cat in db.categorie on p.codeCat equals cat.id

                            select new
                            {
                                app.idApp,
                                p.codeCat,
                                p.id,
                                p.libelle,
                                p.description,
                                p.quantite,
                                p.quantiteMin,
                                p.prix,
                                cat.Categorie,
                                app.dateApprovisionnement

                            }).ToList();
             dgApprovisionnement.DataSource = request;

            //dgApprovisionnement.DataSource = db.approvisionnement.ToList();
        }

    }
}
