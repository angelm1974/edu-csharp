namespace Baza2
{
    partial class frmListaLudzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLudzi));
            this.czlowiekSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czlowiekSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // czlowiekSetDataGridView
            // 
            this.czlowiekSetDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.czlowiekSetDataGridView.AutoGenerateColumns = false;
            this.czlowiekSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.czlowiekSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.czlowiekSetDataGridView.DataSource = this.czlowiekSetBindingSource;
            this.czlowiekSetDataGridView.Location = new System.Drawing.Point(12, 77);
            this.czlowiekSetDataGridView.Name = "czlowiekSetDataGridView";
            this.czlowiekSetDataGridView.Size = new System.Drawing.Size(716, 322);
            this.czlowiekSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "imie";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nazwisko";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "wiek";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "wiek";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // czlowiekSetBindingSource
            // 
            this.czlowiekSetBindingSource.DataSource = typeof(Baza2.czlowiekSet);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document_add24.png");
            this.imageList1.Images.SetKeyName(1, "document_delete24.png");
            this.imageList1.Images.SetKeyName(2, "document_edit.png");
            this.imageList1.Images.SetKeyName(3, "document_info24.png");
            this.imageList1.Images.SetKeyName(4, "close_up_mode-24.png");
            this.imageList1.Images.SetKeyName(5, "lock-24.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnZamknij);
            this.panel1.Controls.Add(this.btnUsun);
            this.panel1.Controls.Add(this.btnNowy);
            this.panel1.Controls.Add(this.btnEdytuj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 62);
            this.panel1.TabIndex = 14;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.ImageIndex = 5;
            this.btnZamknij.ImageList = this.imageList1;
            this.btnZamknij.Location = new System.Drawing.Point(641, 15);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnZamknij.Size = new System.Drawing.Size(87, 35);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "&Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsun.ImageIndex = 1;
            this.btnUsun.ImageList = this.imageList1;
            this.btnUsun.Location = new System.Drawing.Point(198, 15);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnUsun.Size = new System.Drawing.Size(87, 35);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "&Usuń";
            this.btnUsun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowy.ImageIndex = 0;
            this.btnNowy.ImageList = this.imageList1;
            this.btnNowy.Location = new System.Drawing.Point(12, 15);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNowy.Size = new System.Drawing.Size(87, 35);
            this.btnNowy.TabIndex = 1;
            this.btnNowy.Text = "&Nowy";
            this.btnNowy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdytuj.ImageIndex = 2;
            this.btnEdytuj.ImageList = this.imageList1;
            this.btnEdytuj.Location = new System.Drawing.Point(105, 15);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdytuj.Size = new System.Drawing.Size(87, 35);
            this.btnEdytuj.TabIndex = 0;
            this.btnEdytuj.Text = "&Edytuj";
            this.btnEdytuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 62);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista osób";
            // 
            // frmListaLudzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.czlowiekSetDataGridView);
            this.Name = "frmListaLudzi";
            this.Text = "Lista osób";
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource czlowiekSetBindingSource;
        private System.Windows.Forms.DataGridView czlowiekSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}