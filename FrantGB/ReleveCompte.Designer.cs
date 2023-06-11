namespace FrantGB
{
    partial class ReleveCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleveCompte));
            this.comboBoxComptes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMouvements = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMouvements)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxComptes
            // 
            this.comboBoxComptes.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboBoxComptes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxComptes.FormattingEnabled = true;
            this.comboBoxComptes.Location = new System.Drawing.Point(216, 122);
            this.comboBoxComptes.Name = "comboBoxComptes";
            this.comboBoxComptes.Size = new System.Drawing.Size(146, 21);
            this.comboBoxComptes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(276, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compte Bancaire";
            // 
            // dataGridViewMouvements
            // 
            this.dataGridViewMouvements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMouvements.Location = new System.Drawing.Point(12, 175);
            this.dataGridViewMouvements.Name = "dataGridViewMouvements";
            this.dataGridViewMouvements.Size = new System.Drawing.Size(461, 184);
            this.dataGridViewMouvements.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(275, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ReleveCompte";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.SaddleBrown;
            this.ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok.Location = new System.Drawing.Point(416, 120);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(48, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ReleveCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(495, 371);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMouvements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComptes);
            this.Name = "ReleveCompte";
            this.Text = "Releve  Compte";
            this.Load += new System.EventHandler(this.ReleveCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMouvements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComptes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMouvements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok;
    }
}