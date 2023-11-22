namespace BibliotekaProjekt
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
            this.btnKnUnos = new System.Windows.Forms.Button();
            this.btnKnPopis = new System.Windows.Forms.Button();
            this.btnKoUnos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKnBrisanje = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKoBrisanje = new System.Windows.Forms.Button();
            this.btnKoPopis = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEvRaz = new System.Windows.Forms.Button();
            this.btnEvPov = new System.Windows.Forms.Button();
            this.btnEvZad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKnUnos
            // 
            this.btnKnUnos.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKnUnos.Location = new System.Drawing.Point(6, 35);
            this.btnKnUnos.Name = "btnKnUnos";
            this.btnKnUnos.Size = new System.Drawing.Size(75, 34);
            this.btnKnUnos.TabIndex = 0;
            this.btnKnUnos.Text = "Unos";
            this.btnKnUnos.UseVisualStyleBackColor = false;
            this.btnKnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKnPopis
            // 
            this.btnKnPopis.BackColor = System.Drawing.Color.Yellow;
            this.btnKnPopis.Location = new System.Drawing.Point(309, 35);
            this.btnKnPopis.Name = "btnKnPopis";
            this.btnKnPopis.Size = new System.Drawing.Size(75, 34);
            this.btnKnPopis.TabIndex = 1;
            this.btnKnPopis.Text = "Popis";
            this.btnKnPopis.UseVisualStyleBackColor = false;
            this.btnKnPopis.Click += new System.EventHandler(this.btnKnPopis_Click);
            // 
            // btnKoUnos
            // 
            this.btnKoUnos.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKoUnos.Location = new System.Drawing.Point(6, 38);
            this.btnKoUnos.Name = "btnKoUnos";
            this.btnKoUnos.Size = new System.Drawing.Size(75, 34);
            this.btnKoUnos.TabIndex = 2;
            this.btnKoUnos.Text = "Unos";
            this.btnKoUnos.UseVisualStyleBackColor = false;
            this.btnKoUnos.Click += new System.EventHandler(this.btnKoUnos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKnBrisanje);
            this.groupBox1.Controls.Add(this.btnKnUnos);
            this.groupBox1.Controls.Add(this.btnKnPopis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Knjige";
            // 
            // btnKnBrisanje
            // 
            this.btnKnBrisanje.BackColor = System.Drawing.Color.Red;
            this.btnKnBrisanje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKnBrisanje.Location = new System.Drawing.Point(156, 35);
            this.btnKnBrisanje.Name = "btnKnBrisanje";
            this.btnKnBrisanje.Size = new System.Drawing.Size(86, 34);
            this.btnKnBrisanje.TabIndex = 2;
            this.btnKnBrisanje.Text = "Brisanje";
            this.btnKnBrisanje.UseVisualStyleBackColor = false;
            this.btnKnBrisanje.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKoBrisanje);
            this.groupBox2.Controls.Add(this.btnKoPopis);
            this.groupBox2.Controls.Add(this.btnKoUnos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisnici";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnKoBrisanje
            // 
            this.btnKoBrisanje.BackColor = System.Drawing.Color.Red;
            this.btnKoBrisanje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKoBrisanje.Location = new System.Drawing.Point(156, 38);
            this.btnKoBrisanje.Name = "btnKoBrisanje";
            this.btnKoBrisanje.Size = new System.Drawing.Size(86, 34);
            this.btnKoBrisanje.TabIndex = 4;
            this.btnKoBrisanje.Text = "Brisanje";
            this.btnKoBrisanje.UseVisualStyleBackColor = false;
            // 
            // btnKoPopis
            // 
            this.btnKoPopis.BackColor = System.Drawing.Color.Yellow;
            this.btnKoPopis.Location = new System.Drawing.Point(309, 38);
            this.btnKoPopis.Name = "btnKoPopis";
            this.btnKoPopis.Size = new System.Drawing.Size(75, 34);
            this.btnKoPopis.TabIndex = 3;
            this.btnKoPopis.Text = "Popis";
            this.btnKoPopis.UseVisualStyleBackColor = false;
            this.btnKoPopis.Click += new System.EventHandler(this.btnKoPopis_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEvRaz);
            this.groupBox3.Controls.Add(this.btnEvPov);
            this.groupBox3.Controls.Add(this.btnEvZad);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 522);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evidencija";
            // 
            // btnEvRaz
            // 
            this.btnEvRaz.BackColor = System.Drawing.Color.Red;
            this.btnEvRaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvRaz.Location = new System.Drawing.Point(140, 37);
            this.btnEvRaz.Name = "btnEvRaz";
            this.btnEvRaz.Size = new System.Drawing.Size(121, 34);
            this.btnEvRaz.TabIndex = 2;
            this.btnEvRaz.Text = "Brisanje";
            this.btnEvRaz.UseVisualStyleBackColor = false;
            // 
            // btnEvPov
            // 
            this.btnEvPov.BackColor = System.Drawing.Color.Yellow;
            this.btnEvPov.Location = new System.Drawing.Point(286, 37);
            this.btnEvPov.Name = "btnEvPov";
            this.btnEvPov.Size = new System.Drawing.Size(98, 34);
            this.btnEvPov.TabIndex = 1;
            this.btnEvPov.Text = "Povijest";
            this.btnEvPov.UseVisualStyleBackColor = false;
            this.btnEvPov.Click += new System.EventHandler(this.btnEvPov_Click);
            // 
            // btnEvZad
            // 
            this.btnEvZad.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEvZad.Location = new System.Drawing.Point(6, 37);
            this.btnEvZad.Name = "btnEvZad";
            this.btnEvZad.Size = new System.Drawing.Size(110, 34);
            this.btnEvZad.TabIndex = 0;
            this.btnEvZad.Text = "Unos";
            this.btnEvZad.UseVisualStyleBackColor = false;
            this.btnEvZad.Click += new System.EventHandler(this.btnEvZad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Cyan;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(414, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(414, 626);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Clein Books System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKnUnos;
        private System.Windows.Forms.Button btnKnPopis;
        private System.Windows.Forms.Button btnKoUnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKnBrisanje;
        private System.Windows.Forms.Button btnKoBrisanje;
        private System.Windows.Forms.Button btnKoPopis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEvRaz;
        private System.Windows.Forms.Button btnEvPov;
        private System.Windows.Forms.Button btnEvZad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

