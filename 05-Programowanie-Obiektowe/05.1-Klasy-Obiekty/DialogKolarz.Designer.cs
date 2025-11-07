namespace FormyPdstawy
{
    partial class DialogKolarz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogKolarz));
            btnOk = new Button();
            btnAnuluj = new Button();
            txtImie = new TextBox();
            lblImie = new Label();
            label1 = new Label();
            txtNazwisko = new TextBox();
            label2 = new Label();
            txtTeam = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            chkWpisowe = new CheckBox();
            label5 = new Label();
            nmRanking = new NumericUpDown();
            pnTop = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            nmWiek = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmRanking).BeginInit();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmWiek).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.ImageKey = "close.png";
            btnOk.Location = new Point(316, 641);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Padding = new Padding(6, 0, 0, 0);
            btnOk.Size = new Size(145, 49);
            btnOk.TabIndex = 6;
            btnOk.Text = "Zapisz";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnuluj.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnuluj.ImageKey = "close.png";
            btnAnuluj.Location = new Point(469, 641);
            btnAnuluj.Margin = new Padding(4);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Padding = new Padding(6, 0, 0, 0);
            btnAnuluj.Size = new Size(145, 49);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // txtImie
            // 
            txtImie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImie.Location = new Point(115, 168);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(499, 29);
            txtImie.TabIndex = 8;
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(57, 168);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(41, 21);
            lblImie.TabIndex = 9;
            lblImie.Text = "imię";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 231);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 11;
            label1.Text = "nazwisko";
            // 
            // txtNazwisko
            // 
            txtNazwisko.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNazwisko.Location = new Point(115, 228);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(499, 29);
            txtNazwisko.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 296);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 13;
            label2.Text = "team";
            // 
            // txtTeam
            // 
            txtTeam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTeam.Location = new Point(115, 293);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(499, 29);
            txtTeam.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 360);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 15;
            label3.Text = "email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(115, 357);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(499, 29);
            txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 419);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 16;
            label4.Text = "wpisowe";
            // 
            // chkWpisowe
            // 
            chkWpisowe.AutoSize = true;
            chkWpisowe.Location = new Point(115, 419);
            chkWpisowe.Name = "chkWpisowe";
            chkWpisowe.Size = new Size(101, 25);
            chkWpisowe.TabIndex = 17;
            chkWpisowe.Text = "wpłacono";
            chkWpisowe.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 481);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 18;
            label5.Text = "ranking";
            // 
            // nmRanking
            // 
            nmRanking.Location = new Point(115, 479);
            nmRanking.Margin = new Padding(4);
            nmRanking.Name = "nmRanking";
            nmRanking.Size = new Size(120, 29);
            nmRanking.TabIndex = 19;
            // 
            // pnTop
            // 
            pnTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnTop.BackColor = Color.RoyalBlue;
            pnTop.Controls.Add(pictureBox1);
            pnTop.Controls.Add(label6);
            pnTop.Location = new Point(12, 12);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(606, 100);
            pnTop.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(118, 30);
            label6.Name = "label6";
            label6.Size = new Size(179, 32);
            label6.TabIndex = 0;
            label6.Text = "Edytor kolarza";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nmWiek
            // 
            nmWiek.Location = new Point(377, 479);
            nmWiek.Margin = new Padding(4);
            nmWiek.Name = "nmWiek";
            nmWiek.Size = new Size(120, 29);
            nmWiek.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 481);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 21;
            label7.Text = "wiek";
            // 
            // DialogKolarz
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(630, 707);
            Controls.Add(nmWiek);
            Controls.Add(label7);
            Controls.Add(pnTop);
            Controls.Add(nmRanking);
            Controls.Add(label5);
            Controls.Add(chkWpisowe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtTeam);
            Controls.Add(label1);
            Controls.Add(txtNazwisko);
            Controls.Add(lblImie);
            Controls.Add(txtImie);
            Controls.Add(btnAnuluj);
            Controls.Add(btnOk);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogKolarz";
            Text = "Kolarz";
            ((System.ComponentModel.ISupportInitialize)nmRanking).EndInit();
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmWiek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnAnuluj;
        private TextBox txtImie;
        private Label lblImie;
        private Label label1;
        private TextBox txtNazwisko;
        private Label label2;
        private TextBox txtTeam;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private CheckBox chkWpisowe;
        private Label label5;
        private NumericUpDown nmRanking;
        private Panel pnTop;
        private PictureBox pictureBox1;
        private Label label6;
        private NumericUpDown nmWiek;
        private Label label7;
    }
}