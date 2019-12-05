namespace ASL_ClemJane
{
    partial class formAsl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAsl));
            this.tabAsl = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAtelier = new System.Windows.Forms.TabPage();
            this.tabStand = new System.Windows.Forms.TabPage();
            this.tabAsl.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAsl
            // 
            this.tabAsl.Controls.Add(this.tabAccueil);
            this.tabAsl.Controls.Add(this.tabAtelier);
            this.tabAsl.Controls.Add(this.tabStand);
            this.tabAsl.Location = new System.Drawing.Point(0, 0);
            this.tabAsl.Name = "tabAsl";
            this.tabAsl.SelectedIndex = 0;
            this.tabAsl.Size = new System.Drawing.Size(894, 503);
            this.tabAsl.TabIndex = 0;
            // 
            // tabAccueil
            // 
            this.tabAccueil.Controls.Add(this.label3);
            this.tabAccueil.Controls.Add(this.pictureBox1);
            this.tabAccueil.Controls.Add(this.label2);
            this.tabAccueil.Controls.Add(this.label1);
            this.tabAccueil.Location = new System.Drawing.Point(4, 22);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(886, 477);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright Décembre 2019, CARDS - JANE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 180);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application de gestion des Assises du Sport Lorrain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maison des Ligues de Lorraine";
            // 
            // tabAtelier
            // 
            this.tabAtelier.Location = new System.Drawing.Point(4, 22);
            this.tabAtelier.Name = "tabAtelier";
            this.tabAtelier.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtelier.Size = new System.Drawing.Size(886, 477);
            this.tabAtelier.TabIndex = 1;
            this.tabAtelier.Text = "Gestion Atelier";
            this.tabAtelier.UseVisualStyleBackColor = true;
            // 
            // tabStand
            // 
            this.tabStand.Location = new System.Drawing.Point(4, 22);
            this.tabStand.Name = "tabStand";
            this.tabStand.Padding = new System.Windows.Forms.Padding(3);
            this.tabStand.Size = new System.Drawing.Size(886, 477);
            this.tabStand.TabIndex = 2;
            this.tabStand.Text = "Affectation Stand";
            this.tabStand.UseVisualStyleBackColor = true;
            // 
            // formAsl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 506);
            this.Controls.Add(this.tabAsl);
            this.Name = "formAsl";
            this.Text = "Application ASL";
            this.Load += new System.EventHandler(this.formAsl_Load);
            this.tabAsl.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAsl;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAtelier;
        private System.Windows.Forms.TabPage tabStand;
    }
}

