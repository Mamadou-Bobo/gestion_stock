using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using GestionStockApp.Model;

namespace GestionStockApp
{
    public partial class frmMDI : Form
    {
        public static string txtIdentifiant { get; set; }

        gestionstockEntities db = new gestionstockEntities();

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = SystemColors.Control;
            Computer computer = new Computer();
            this.Width = computer.Screen.Bounds.Width;
            this.Height = computer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

            var user = db.utilisateur.Where(a => a.login ==
            txtIdentifiant).FirstOrDefault();

            if (user.profil.Equals("Gestionnaire"))
            {
                administrationToolStripMenuItem.Visible = false;
                venteToolStripMenuItem.Visible = false;
            }
            else if (user.profil.Equals("Vendeur"))
            {
                administrationToolStripMenuItem.Visible = false;
                codificationToolStripMenuItem.Visible = false;
            }
            else if (user.profil.Equals("Admin"))
            {
                codificationToolStripMenuItem.Visible = false;
                venteToolStripMenuItem.Visible = false;
            } else
            {
                administrationToolStripMenuItem.Visible = true;
                codificationToolStripMenuItem.Visible = true;
                venteToolStripMenuItem.Visible = true;
            }
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            foreach(Form charForm in charr)
            {
                charForm.Close();
            }
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = db.utilisateur.Where(a => a.login == frmLogin.userId).FirstOrDefault();
            user.connectedAt = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");
            db.SaveChanges();
            Application.Exit();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie f = new frmCategorie();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmLogin f = new frmLogin();
            var user = db.utilisateur.Where(a => a.login == frmLogin.userId).FirstOrDefault();
            user.connectedAt = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss"); 
            db.SaveChanges();
            f.Show();
            this.Hide();
        }

        private void approvisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmApprovisionnement f = new frmApprovisionnement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMonCompte f = new frmMonCompte();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
