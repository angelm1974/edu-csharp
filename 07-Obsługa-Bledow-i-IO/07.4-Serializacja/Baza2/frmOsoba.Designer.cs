namespace Baza2
{
    partial class frmCzlowiek
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
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label wiekLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.czlowiekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.wiekNumericUpDown = new System.Windows.Forms.NumericUpDown();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            wiekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiekNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(38, 34);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(28, 13);
            imieLabel.TabIndex = 2;
            imieLabel.Text = "imie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(12, 75);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 4;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // wiekLabel
            // 
            wiekLabel.AutoSize = true;
            wiekLabel.Location = new System.Drawing.Point(34, 108);
            wiekLabel.Name = "wiekLabel";
            wiekLabel.Size = new System.Drawing.Size(32, 13);
            wiekLabel.TabIndex = 6;
            wiekLabel.Text = "wiek:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(192, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // czlowiekBindingSource
            // 
            this.czlowiekBindingSource.DataSource = typeof(Baza2.czlowiekSet);
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.czlowiekBindingSource, "imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(72, 31);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(186, 20);
            this.imieTextBox.TabIndex = 3;
            this.imieTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imieTextBox_KeyDown);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.czlowiekBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(72, 72);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(186, 20);
            this.nazwiskoTextBox.TabIndex = 5;
            this.nazwiskoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nazwiskoTextBox_KeyDown);
            // 
            // wiekNumericUpDown
            // 
            this.wiekNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.czlowiekBindingSource, "wiek", true));
            this.wiekNumericUpDown.Location = new System.Drawing.Point(72, 108);
            this.wiekNumericUpDown.Name = "wiekNumericUpDown";
            this.wiekNumericUpDown.Size = new System.Drawing.Size(186, 20);
            this.wiekNumericUpDown.TabIndex = 7;
            this.wiekNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wiekNumericUpDown_KeyDown);
            // 
            // frmCzlowiek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 357);
            this.Controls.Add(wiekLabel);
            this.Controls.Add(this.wiekNumericUpDown);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.button1);
            this.Name = "frmCzlowiek";
            this.Text = "Osoba";
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiekNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource czlowiekBindingSource;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.NumericUpDown wiekNumericUpDown;
    }
}

