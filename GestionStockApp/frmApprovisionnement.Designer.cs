
namespace GestionStockApp
{
    partial class frmApprovisionnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgApprovisionnement = new System.Windows.Forms.DataGridView();
            this.txtIdApprovisionnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgApprovisionnement
            // 
            this.dgApprovisionnement.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgApprovisionnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApprovisionnement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdApprovisionnement});
            this.dgApprovisionnement.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgApprovisionnement.Location = new System.Drawing.Point(68, 37);
            this.dgApprovisionnement.Name = "dgApprovisionnement";
            this.dgApprovisionnement.RowHeadersWidth = 62;
            this.dgApprovisionnement.RowTemplate.Height = 28;
            this.dgApprovisionnement.Size = new System.Drawing.Size(1681, 511);
            this.dgApprovisionnement.TabIndex = 0;
            // 
            // txtIdApprovisionnement
            // 
            this.txtIdApprovisionnement.DataPropertyName = "idApp";
            this.txtIdApprovisionnement.HeaderText = "ID Approvisionnement";
            this.txtIdApprovisionnement.MinimumWidth = 8;
            this.txtIdApprovisionnement.Name = "txtIdApprovisionnement";
            this.txtIdApprovisionnement.Width = 150;
            // 
            // frmApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 560);
            this.ControlBox = false;
            this.Controls.Add(this.dgApprovisionnement);
            this.Name = "frmApprovisionnement";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.frmApprovisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgApprovisionnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdApprovisionnement;
    }
}