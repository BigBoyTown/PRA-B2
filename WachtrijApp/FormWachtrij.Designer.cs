namespace WachtrijApp
{
    partial class FormWachtrij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWachtrij));
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelWachttijd = new System.Windows.Forms.Label();
            this.labelWachttijdMelding = new System.Windows.Forms.Label();
            this.AttractieLogo = new System.Windows.Forms.PictureBox();
            this.labelKar3 = new System.Windows.Forms.Label();
            this.labelKar2 = new System.Windows.Forms.Label();
            this.labelKar1 = new System.Windows.Forms.Label();
            this.btnEasterEgg = new System.Windows.Forms.Button();
            this.pbxEasterEgg1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEasterEgg1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(36, 33);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(191, 40);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Debug Hero";
            this.labelTitel.Click += new System.EventHandler(this.labelTitel_Click);
            // 
            // labelWachttijd
            // 
            this.labelWachttijd.AutoSize = true;
            this.labelWachttijd.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijd.Location = new System.Drawing.Point(36, 183);
            this.labelWachttijd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWachttijd.Name = "labelWachttijd";
            this.labelWachttijd.Size = new System.Drawing.Size(127, 32);
            this.labelWachttijd.TabIndex = 4;
            this.labelWachttijd.Text = "Wachttijd";
            // 
            // labelWachttijdMelding
            // 
            this.labelWachttijdMelding.AutoSize = true;
            this.labelWachttijdMelding.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijdMelding.Location = new System.Drawing.Point(39, 214);
            this.labelWachttijdMelding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWachttijdMelding.Name = "labelWachttijdMelding";
            this.labelWachttijdMelding.Size = new System.Drawing.Size(88, 23);
            this.labelWachttijdMelding.TabIndex = 5;
            this.labelWachttijdMelding.Text = "0 minuten";
            // 
            // AttractieLogo
            // 
            this.AttractieLogo.ErrorImage = null;
            this.AttractieLogo.Image = ((System.Drawing.Image)(resources.GetObject("AttractieLogo.Image")));
            this.AttractieLogo.Location = new System.Drawing.Point(228, 107);
            this.AttractieLogo.Margin = new System.Windows.Forms.Padding(4);
            this.AttractieLogo.Name = "AttractieLogo";
            this.AttractieLogo.Size = new System.Drawing.Size(147, 174);
            this.AttractieLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttractieLogo.TabIndex = 6;
            this.AttractieLogo.TabStop = false;
            this.AttractieLogo.Click += new System.EventHandler(this.AttractieLogo_Click);
            // 
            // labelKar3
            // 
            this.labelKar3.AutoSize = true;
            this.labelKar3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelKar3.Location = new System.Drawing.Point(39, 130);
            this.labelKar3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKar3.Name = "labelKar3";
            this.labelKar3.Size = new System.Drawing.Size(74, 23);
            this.labelKar3.TabIndex = 7;
            this.labelKar3.Text = "Kar 3: ...";
            // 
            // labelKar2
            // 
            this.labelKar2.AutoSize = true;
            this.labelKar2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelKar2.Location = new System.Drawing.Point(39, 107);
            this.labelKar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKar2.Name = "labelKar2";
            this.labelKar2.Size = new System.Drawing.Size(74, 23);
            this.labelKar2.TabIndex = 8;
            this.labelKar2.Text = "Kar 2: ...";
            // 
            // labelKar1
            // 
            this.labelKar1.AutoSize = true;
            this.labelKar1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelKar1.Location = new System.Drawing.Point(39, 84);
            this.labelKar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKar1.Name = "labelKar1";
            this.labelKar1.Size = new System.Drawing.Size(74, 23);
            this.labelKar1.TabIndex = 9;
            this.labelKar1.Text = "Kar 1: ...";
            // 
            // btnEasterEgg
            // 
            this.btnEasterEgg.BackColor = System.Drawing.Color.Transparent;
            this.btnEasterEgg.FlatAppearance.BorderSize = 0;
            this.btnEasterEgg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEasterEgg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEasterEgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasterEgg.ForeColor = System.Drawing.Color.Transparent;
            this.btnEasterEgg.Location = new System.Drawing.Point(1, 253);
            this.btnEasterEgg.Name = "btnEasterEgg";
            this.btnEasterEgg.Size = new System.Drawing.Size(28, 28);
            this.btnEasterEgg.TabIndex = 10;
            this.btnEasterEgg.TabStop = false;
            this.btnEasterEgg.UseVisualStyleBackColor = false;
            this.btnEasterEgg.Click += new System.EventHandler(this.btnEasterEgg_Click);
            // 
            // pbxEasterEgg1
            // 
            this.pbxEasterEgg1.Image = ((System.Drawing.Image)(resources.GetObject("pbxEasterEgg1.Image")));
            this.pbxEasterEgg1.Location = new System.Drawing.Point(228, 6);
            this.pbxEasterEgg1.Name = "pbxEasterEgg1";
            this.pbxEasterEgg1.Size = new System.Drawing.Size(132, 94);
            this.pbxEasterEgg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEasterEgg1.TabIndex = 11;
            this.pbxEasterEgg1.TabStop = false;
            this.pbxEasterEgg1.Visible = false;
            // 
            // FormWachtrij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(372, 279);
            this.Controls.Add(this.btnEasterEgg);
            this.Controls.Add(this.pbxEasterEgg1);
            this.Controls.Add(this.labelKar1);
            this.Controls.Add(this.labelKar2);
            this.Controls.Add(this.labelKar3);
            this.Controls.Add(this.AttractieLogo);
            this.Controls.Add(this.labelWachttijdMelding);
            this.Controls.Add(this.labelWachttijd);
            this.Controls.Add(this.labelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWachtrij";
            this.Text = "Debug Hero";
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEasterEgg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelWachttijd;
        private System.Windows.Forms.Label labelWachttijdMelding;
        private System.Windows.Forms.PictureBox AttractieLogo;
        private System.Windows.Forms.Label labelKar3;
        private System.Windows.Forms.Label labelKar2;
        private System.Windows.Forms.Label labelKar1;
        private System.Windows.Forms.Button btnEasterEgg;
        private System.Windows.Forms.PictureBox pbxEasterEgg1;
    }
}

