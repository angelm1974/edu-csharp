namespace Baza2
{
    partial class frmKsiazka
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label tytulLabel;
            System.Windows.Forms.Label wydawcaLabel;
            System.Windows.Forms.Label wydanieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKsiazka));
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.ksiazkaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tytulTextBox = new System.Windows.Forms.TextBox();
            this.wydawcaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.wydanieNumericUpDown = new System.Windows.Forms.NumericUpDown();
            autorLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            tytulLabel = new System.Windows.Forms.Label();
            wydawcaLabel = new System.Windows.Forms.Label();
            wydanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wydanieNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(54, 70);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(34, 13);
            autorLabel.TabIndex = 1;
            autorLabel.Text = "autor:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(69, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // tytulLabel
            // 
            tytulLabel.AutoSize = true;
            tytulLabel.Location = new System.Drawing.Point(59, 112);
            tytulLabel.Name = "tytulLabel";
            tytulLabel.Size = new System.Drawing.Size(29, 13);
            tytulLabel.TabIndex = 5;
            tytulLabel.Text = "tytul:";
            // 
            // wydawcaLabel
            // 
            wydawcaLabel.AutoSize = true;
            wydawcaLabel.Location = new System.Drawing.Point(33, 154);
            wydawcaLabel.Name = "wydawcaLabel";
            wydawcaLabel.Size = new System.Drawing.Size(55, 13);
            wydawcaLabel.TabIndex = 9;
            wydawcaLabel.Text = "wydawca:";
            // 
            // wydanieLabel
            // 
            wydanieLabel.AutoSize = true;
            wydanieLabel.Location = new System.Drawing.Point(39, 195);
            wydanieLabel.Name = "wydanieLabel";
            wydanieLabel.Size = new System.Drawing.Size(49, 13);
            wydanieLabel.TabIndex = 11;
            wydanieLabel.Text = "wydanie:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ksiazkaSetBindingSource, "autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(94, 67);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(243, 20);
            this.autorTextBox.TabIndex = 2;
            // 
            // ksiazkaSetBindingSource
            // 
            this.ksiazkaSetBindingSource.DataSource = typeof(Baza2.ksiazkaSet);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ksiazkaSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(94, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(243, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // tytulTextBox
            // 
            this.tytulTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ksiazkaSetBindingSource, "tytul", true));
            this.tytulTextBox.Location = new System.Drawing.Point(94, 109);
            this.tytulTextBox.Name = "tytulTextBox";
            this.tytulTextBox.Size = new System.Drawing.Size(243, 20);
            this.tytulTextBox.TabIndex = 6;
            // 
            // wydawcaTextBox
            // 
            this.wydawcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ksiazkaSetBindingSource, "wydawca", true));
            this.wydawcaTextBox.Location = new System.Drawing.Point(94, 151);
            this.wydawcaTextBox.Name = "wydawcaTextBox";
            this.wydawcaTextBox.Size = new System.Drawing.Size(243, 20);
            this.wydawcaTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 62);
            this.panel1.TabIndex = 11;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnuluj.ImageIndex = 1;
            this.btnAnuluj.ImageList = this.imageList1;
            this.btnAnuluj.Location = new System.Drawing.Point(215, 17);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnAnuluj.Size = new System.Drawing.Size(87, 35);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "&Anuluj";
            this.btnAnuluj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ok.png");
            this.imageList1.Images.SetKeyName(1, "cacnel.png");
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(308, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // wydanieNumericUpDown
            // 
            this.wydanieNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ksiazkaSetBindingSource, "wydanie", true));
            this.wydanieNumericUpDown.Location = new System.Drawing.Point(94, 193);
            this.wydanieNumericUpDown.Name = "wydanieNumericUpDown";
            this.wydanieNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.wydanieNumericUpDown.TabIndex = 12;
            // 
            // frmKsiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 307);
            this.ControlBox = false;
            this.Controls.Add(wydanieLabel);
            this.Controls.Add(this.wydanieNumericUpDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(wydawcaLabel);
            this.Controls.Add(this.wydawcaTextBox);
            this.Controls.Add(tytulLabel);
            this.Controls.Add(this.tytulTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.MaximumSize = new System.Drawing.Size(422, 346);
            this.MinimumSize = new System.Drawing.Size(422, 346);
            this.Name = "frmKsiazka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Książka";
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wydanieNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ksiazkaSetBindingSource;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox tytulTextBox;
        private System.Windows.Forms.TextBox wydawcaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown wydanieNumericUpDown;
    }
}