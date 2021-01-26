
namespace GestionStockApp
{
    partial class frmResetPassword
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
            this.btnRéinitialiser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNouveauMotDePasse = new System.Windows.Forms.TextBox();
            this.cbAfficherMotDePasse = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtConfirmerMotDePasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRéinitialiser
            // 
            this.btnRéinitialiser.Location = new System.Drawing.Point(437, 362);
            this.btnRéinitialiser.Name = "btnRéinitialiser";
            this.btnRéinitialiser.Size = new System.Drawing.Size(118, 31);
            this.btnRéinitialiser.TabIndex = 0;
            this.btnRéinitialiser.Text = "&Réinitialiser";
            this.btnRéinitialiser.UseVisualStyleBackColor = true;
            this.btnRéinitialiser.Click += new System.EventHandler(this.btnRéinitialiser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouveau mot de passe";
            // 
            // txtNouveauMotDePasse
            // 
            this.txtNouveauMotDePasse.Location = new System.Drawing.Point(280, 186);
            this.txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
            this.txtNouveauMotDePasse.Size = new System.Drawing.Size(275, 26);
            this.txtNouveauMotDePasse.TabIndex = 2;
            this.txtNouveauMotDePasse.UseSystemPasswordChar = true;
            // 
            // cbAfficherMotDePasse
            // 
            this.cbAfficherMotDePasse.AutoSize = true;
            this.cbAfficherMotDePasse.Location = new System.Drawing.Point(280, 323);
            this.cbAfficherMotDePasse.Name = "cbAfficherMotDePasse";
            this.cbAfficherMotDePasse.Size = new System.Drawing.Size(206, 24);
            this.cbAfficherMotDePasse.TabIndex = 3;
            this.cbAfficherMotDePasse.Text = "Afficher le mot de passe";
            this.cbAfficherMotDePasse.UseVisualStyleBackColor = true;
            this.cbAfficherMotDePasse.CheckedChanged += new System.EventHandler(this.cbAfficherMotDePasse_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "S\'il vous plaît veuillez modifier votre mot de passe";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(280, 362);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(118, 31);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtConfirmerMotDePasse
            // 
            this.txtConfirmerMotDePasse.Location = new System.Drawing.Point(280, 249);
            this.txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            this.txtConfirmerMotDePasse.Size = new System.Drawing.Size(275, 26);
            this.txtConfirmerMotDePasse.TabIndex = 7;
            this.txtConfirmerMotDePasse.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmer le mot de passe";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(80, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 8;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtConfirmerMotDePasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAfficherMotDePasse);
            this.Controls.Add(this.txtNouveauMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRéinitialiser);
            this.Name = "frmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réinitialisation du mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRéinitialiser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNouveauMotDePasse;
        private System.Windows.Forms.CheckBox cbAfficherMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtConfirmerMotDePasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
    }
}