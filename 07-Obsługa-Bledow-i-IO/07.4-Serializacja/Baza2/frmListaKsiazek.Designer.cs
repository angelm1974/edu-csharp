namespace Baza2
{
    partial class frmListaKsiazek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaKsiazek));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ksiazkaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ksiazkaSetDataGridView
            // 
            this.ksiazkaSetDataGridView.AllowUserToAddRows = false;
            this.ksiazkaSetDataGridView.AllowUserToDeleteRows = false;
            this.ksiazkaSetDataGridView.AllowUserToOrderColumns = true;
            this.ksiazkaSetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ksiazkaSetDataGridView.AutoGenerateColumns = false;
            this.ksiazkaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ksiazkaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ksiazkaSetDataGridView.DataSource = this.ksiazkaSetBindingSource;
            this.ksiazkaSetDataGridView.Location = new System.Drawing.Point(12, 81);
            this.ksiazkaSetDataGridView.Name = "ksiazkaSetDataGridView";
            this.ksiazkaSetDataGridView.ReadOnly = true;
            this.ksiazkaSetDataGridView.Size = new System.Drawing.Size(772, 280);
            this.ksiazkaSetDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnZamknij);
            this.panel1.Controls.Add(this.btnUsun);
            this.panel1.Controls.Add(this.btnNowy);
            this.panel1.Controls.Add(this.btnEdytuj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 62);
            this.panel1.TabIndex = 13;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.ImageIndex = 5;
            this.btnZamknij.ImageList = this.imageList1;
            this.btnZamknij.Location = new System.Drawing.Point(695, 15);
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
            this.panel2.Size = new System.Drawing.Size(794, 62);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista książek";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tytul";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "tytul";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn3.HeaderText = "autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "wydanie";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn4.HeaderText = "wydanie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "wydawca";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn5.HeaderText = "wydawca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ksiazkaSetBindingSource
            // 
            this.ksiazkaSetBindingSource.DataSource = typeof(Baza2.ksiazkaSet);
            // 
            // frmListaKsiazek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ksiazkaSetDataGridView);
            this.Name = "frmListaKsiazek";
            this.Text = "Lista ksiażek";
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ksiazkaSetBindingSource;
        private System.Windows.Forms.DataGridView ksiazkaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}