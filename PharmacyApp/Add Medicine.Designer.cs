
namespace PharmacyApp
{
    partial class Add_Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Medicine));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtExperienceDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ckReceipt = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.ckTagsList = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 30);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine Price";
            // 
            // nmPrice
            // 
            this.nmPrice.DecimalPlaces = 2;
            this.nmPrice.Location = new System.Drawing.Point(51, 131);
            this.nmPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(268, 30);
            this.nmPrice.TabIndex = 3;
            this.nmPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine Quantity";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(51, 209);
            this.nmQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(268, 30);
            this.nmQuantity.TabIndex = 5;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(51, 367);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(268, 125);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicine Description";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Production Date";
            // 
            // dtProductionDate
            // 
            this.dtProductionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtProductionDate.Location = new System.Drawing.Point(586, 53);
            this.dtProductionDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtProductionDate.Name = "dtProductionDate";
            this.dtProductionDate.Size = new System.Drawing.Size(303, 30);
            this.dtProductionDate.TabIndex = 9;
            // 
            // dtExperienceDate
            // 
            this.dtExperienceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtExperienceDate.Location = new System.Drawing.Point(586, 128);
            this.dtExperienceDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtExperienceDate.Name = "dtExperienceDate";
            this.dtExperienceDate.Size = new System.Drawing.Size(303, 30);
            this.dtExperienceDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Experience Date";
            // 
            // ckReceipt
            // 
            this.ckReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckReceipt.AutoSize = true;
            this.ckReceipt.Location = new System.Drawing.Point(586, 166);
            this.ckReceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckReceipt.Name = "ckReceipt";
            this.ckReceipt.Size = new System.Drawing.Size(118, 27);
            this.ckReceipt.TabIndex = 12;
            this.ckReceipt.Text = "IsReceipt ?";
            this.ckReceipt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tags ";
            // 
            // cmbTags
            // 
            this.cmbTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(586, 287);
            this.cmbTags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(303, 31);
            this.cmbTags.TabIndex = 14;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTags_KeyUp);
            // 
            // cmbFirms
            // 
            this.cmbFirms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(586, 227);
            this.cmbFirms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(303, 31);
            this.cmbFirms.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Firms ";
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMedicine.Location = new System.Drawing.Point(0, 531);
            this.dtgMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.Size = new System.Drawing.Size(921, 218);
            this.dtgMedicine.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(586, 422);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 54);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Medicine";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(51, 288);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(268, 30);
            this.txtBarcode.TabIndex = 21;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Barcode";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(582, 480);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(65, 23);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "label10";
            this.lblError.Visible = false;
            // 
            // ckTagsList
            // 
            this.ckTagsList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckTagsList.FormattingEnabled = true;
            this.ckTagsList.Location = new System.Drawing.Point(586, 326);
            this.ckTagsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTagsList.Name = "ckTagsList";
            this.ckTagsList.Size = new System.Drawing.Size(303, 79);
            this.ckTagsList.TabIndex = 23;
            this.ckTagsList.SelectedIndexChanged += new System.EventHandler(this.ckTagsList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(868, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Exit";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Add_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 749);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ckTagsList);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckReceipt);
            this.Controls.Add(this.dtExperienceDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtProductionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Add_Medicine";
            this.Text = "Add Medicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtProductionDate;
        private System.Windows.Forms.DateTimePicker dtExperienceDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckedListBox ckTagsList;
        private System.Windows.Forms.Label label10;
    }
}