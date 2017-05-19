namespace jogodaforca
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
            this.pnjogo = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtbpalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtotaltentativas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtrestantes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.txtbletra = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbdica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnjogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnjogo
            // 
            this.pnjogo.Controls.Add(this.panel1);
            this.pnjogo.Controls.Add(this.groupBox4);
            this.pnjogo.Controls.Add(this.groupBox3);
            this.pnjogo.Controls.Add(this.groupBox2);
            this.pnjogo.Controls.Add(this.groupBox1);
            this.pnjogo.Controls.Add(this.label1);
            this.pnjogo.Controls.Add(this.txtbpalavra);
            this.pnjogo.Location = new System.Drawing.Point(12, 12);
            this.pnjogo.Name = "pnjogo";
            this.pnjogo.Size = new System.Drawing.Size(626, 403);
            this.pnjogo.TabIndex = 0;
            this.pnjogo.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(21, 421);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(602, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtbpalavra
            // 
            this.txtbpalavra.Enabled = false;
            this.txtbpalavra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbpalavra.Location = new System.Drawing.Point(3, 50);
            this.txtbpalavra.Name = "txtbpalavra";
            this.txtbpalavra.Size = new System.Drawing.Size(608, 33);
            this.txtbpalavra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifique a palavra secreta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtotaltentativas);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Tentativas";
            // 
            // lbtotaltentativas
            // 
            this.lbtotaltentativas.AutoSize = true;
            this.lbtotaltentativas.Location = new System.Drawing.Point(101, 29);
            this.lbtotaltentativas.Name = "lbtotaltentativas";
            this.lbtotaltentativas.Size = new System.Drawing.Size(23, 26);
            this.lbtotaltentativas.TabIndex = 0;
            this.lbtotaltentativas.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtrestantes);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(382, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentativas Restantes";
            // 
            // lbtrestantes
            // 
            this.lbtrestantes.AutoSize = true;
            this.lbtrestantes.Location = new System.Drawing.Point(101, 33);
            this.lbtrestantes.Name = "lbtrestantes";
            this.lbtrestantes.Size = new System.Drawing.Size(23, 26);
            this.lbtrestantes.TabIndex = 0;
            this.lbtrestantes.Text = "5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbletra);
            this.groupBox3.Controls.Add(this.btOk);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escreva uma Letra";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(6, 88);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(346, 42);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Identificar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtbletra
            // 
            this.txtbletra.Location = new System.Drawing.Point(6, 32);
            this.txtbletra.Name = "txtbletra";
            this.txtbletra.Size = new System.Drawing.Size(346, 33);
            this.txtbletra.TabIndex = 1;
            this.txtbletra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbletra.TextChanged += new System.EventHandler(this.txtbletra_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbdica);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dica";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lbdica
            // 
            this.lbdica.AutoSize = true;
            this.lbdica.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdica.Location = new System.Drawing.Point(6, 29);
            this.lbdica.Name = "lbdica";
            this.lbdica.Size = new System.Drawing.Size(38, 19);
            this.lbdica.TabIndex = 0;
            this.lbdica.Text = "Dica";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 403);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogodaforca.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 484);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnjogo);
            this.Name = "Form1";
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnjogo.ResumeLayout(false);
            this.pnjogo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnjogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbpalavra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbletra;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbtrestantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtotaltentativas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbdica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

