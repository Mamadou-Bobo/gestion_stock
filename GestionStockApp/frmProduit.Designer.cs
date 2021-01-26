
namespace GestionStockApp
{
    partial class frmProduit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtQuantiteMinimale = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.dbProduit = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionstockDataSet = new GestionStockApp.gestionstockDataSet();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.categorieTableAdapter = new GestionStockApp.gestionstockDataSetTableAdapters.categorieTableAdapter();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantité minimale";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(36, 63);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(229, 26);
            this.txtLibelle.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(36, 148);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(36, 233);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(229, 26);
            this.txtQuantite.TabIndex = 7;
            // 
            // txtQuantiteMinimale
            // 
            this.txtQuantiteMinimale.Location = new System.Drawing.Point(36, 318);
            this.txtQuantiteMinimale.Name = "txtQuantiteMinimale";
            this.txtQuantiteMinimale.Size = new System.Drawing.Size(229, 26);
            this.txtQuantiteMinimale.TabIndex = 8;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(36, 403);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(229, 26);
            this.txtPrix.TabIndex = 9;
            // 
            // dbProduit
            // 
            this.dbProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dbProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtLb,
            this.txtDesc,
            this.txtQt,
            this.txtQtMin,
            this.txtPr,
            this.txtCat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dbProduit.EnableHeadersVisualStyles = false;
            this.dbProduit.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dbProduit.Location = new System.Drawing.Point(310, 63);
            this.dbProduit.MultiSelect = false;
            this.dbProduit.Name = "dbProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dbProduit.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HP Simplified", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbProduit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dbProduit.RowTemplate.Height = 28;
            this.dbProduit.Size = new System.Drawing.Size(1115, 672);
            this.dbProduit.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "id";
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 8;
            this.txtID.Name = "txtID";
            this.txtID.Width = 150;
            // 
            // txtLb
            // 
            this.txtLb.DataPropertyName = "libelle";
            this.txtLb.HeaderText = "Libellé";
            this.txtLb.MinimumWidth = 8;
            this.txtLb.Name = "txtLb";
            this.txtLb.Width = 150;
            // 
            // txtDesc
            // 
            this.txtDesc.DataPropertyName = "description";
            this.txtDesc.HeaderText = "Description";
            this.txtDesc.MinimumWidth = 8;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Width = 150;
            // 
            // txtQt
            // 
            this.txtQt.DataPropertyName = "quantite";
            this.txtQt.HeaderText = "Quantité";
            this.txtQt.MinimumWidth = 8;
            this.txtQt.Name = "txtQt";
            this.txtQt.Width = 150;
            // 
            // txtQtMin
            // 
            this.txtQtMin.DataPropertyName = "quantiteMin";
            this.txtQtMin.HeaderText = "Quantité Minimale";
            this.txtQtMin.MinimumWidth = 8;
            this.txtQtMin.Name = "txtQtMin";
            this.txtQtMin.Width = 150;
            // 
            // txtPr
            // 
            this.txtPr.DataPropertyName = "prix";
            this.txtPr.HeaderText = "Prix";
            this.txtPr.MinimumWidth = 8;
            this.txtPr.Name = "txtPr";
            this.txtPr.Width = 150;
            // 
            // txtCat
            // 
            this.txtCat.DataPropertyName = "categorie";
            this.txtCat.HeaderText = "Catégorie";
            this.txtCat.MinimumWidth = 8;
            this.txtCat.Name = "txtCat";
            this.txtCat.Width = 150;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(36, 831);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(145, 48);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(211, 831);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(145, 48);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(386, 831);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(145, 48);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(561, 831);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(145, 48);
            this.btnEffacer.TabIndex = 14;
            this.btnEffacer.Text = "&Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(661, 12);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(144, 38);
            this.btnSelectionner.TabIndex = 16;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(310, 12);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(288, 35);
            this.btnRechercher.TabIndex = 17;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(36, 472);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(229, 28);
            this.cbbCategorie.TabIndex = 19;
            // 
            // categorieBindingSource1
            // 
            this.categorieBindingSource1.DataMember = "categorie";
            this.categorieBindingSource1.DataSource = this.gestionstockDataSet;
            // 
            // gestionstockDataSet
            // 
            this.gestionstockDataSet.DataSetName = "gestionstockDataSet";
            this.gestionstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(31, 448);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(78, 20);
            this.lblCategorie.TabIndex = 20;
            this.lblCategorie.Text = "Catégorie";
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(GestionStockApp.Model.categorie);
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dbProduit);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQuantiteMinimale);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtQuantiteMinimale;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.DataGridView dbProduit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.Label lblCategorie;
        private gestionstockDataSet gestionstockDataSet;
        private System.Windows.Forms.BindingSource categorieBindingSource1;
        private gestionstockDataSetTableAdapters.categorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCat;
    }
}

