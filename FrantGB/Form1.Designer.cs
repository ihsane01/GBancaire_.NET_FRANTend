namespace FrantGB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxComptes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crd = new System.Windows.Forms.RadioButton();
            this.dbt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnt = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.trn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxComptes
            // 
            this.comboBoxComptes.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboBoxComptes.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxComptes.FormattingEnabled = true;
            this.comboBoxComptes.Location = new System.Drawing.Point(231, 133);
            this.comboBoxComptes.Name = "comboBoxComptes";
            this.comboBoxComptes.Size = new System.Drawing.Size(206, 21);
            this.comboBoxComptes.TabIndex = 0;
            this.comboBoxComptes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(300, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // crd
            // 
            this.crd.AutoSize = true;
            this.crd.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.crd.Location = new System.Drawing.Point(231, 197);
            this.crd.Name = "crd";
            this.crd.Size = new System.Drawing.Size(69, 20);
            this.crd.TabIndex = 4;
            this.crd.TabStop = true;
            this.crd.Text = "Crédit";
            this.crd.UseVisualStyleBackColor = true;
            // 
            // dbt
            // 
            this.dbt.AutoSize = true;
            this.dbt.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dbt.Location = new System.Drawing.Point(375, 197);
            this.dbt.Name = "dbt";
            this.dbt.Size = new System.Drawing.Size(62, 20);
            this.dbt.TabIndex = 5;
            this.dbt.TabStop = true;
            this.dbt.Text = "Débit";
            this.dbt.UseVisualStyleBackColor = true;
            this.dbt.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type d\'operation ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(33, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Montant";
            // 
            // mnt
            // 
            this.mnt.BackColor = System.Drawing.Color.SaddleBrown;
            this.mnt.ForeColor = System.Drawing.SystemColors.Window;
            this.mnt.Location = new System.Drawing.Point(231, 267);
            this.mnt.Name = "mnt";
            this.mnt.Size = new System.Drawing.Size(206, 20);
            this.mnt.TabIndex = 8;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.SaddleBrown;
            this.ok.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok.Location = new System.Drawing.Point(378, 308);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(59, 32);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // trn
            // 
            this.trn.AutoSize = true;
            this.trn.BackColor = System.Drawing.Color.Tan;
            this.trn.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.trn.Location = new System.Drawing.Point(212, 19);
            this.trn.Name = "trn";
            this.trn.Size = new System.Drawing.Size(237, 21);
            this.trn.TabIndex = 10;
            this.trn.Text = "Transaction Bncaire";
            this.trn.Click += new System.EventHandler(this.trn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Relevé";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(488, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trn);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.mnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbt);
            this.Controls.Add(this.crd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComptes);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComptes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton crd;
        private System.Windows.Forms.RadioButton dbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mnt;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label trn;
        private System.Windows.Forms.Button button1;
    }
}

