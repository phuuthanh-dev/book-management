namespace BookStore_HoangNT
{
    partial class BookForm
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
            lblFormTitle = new Label();
            gbBookInfo = new GroupBox();
            cboCategory = new ComboBox();
            dtpReleasedDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            gbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(46, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(250, 37);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Add/Update Book";
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(46, 76);
            gbBookInfo.Margin = new Padding(3, 2, 3, 2);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(3, 2, 3, 2);
            gbBookInfo.Size = new Size(450, 334);
            gbBookInfo.TabIndex = 22;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(115, 295);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(309, 23);
            cboCategory.TabIndex = 7;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(115, 188);
            dtpReleasedDate.Margin = new Padding(3, 2, 3, 2);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(134, 23);
            dtpReleasedDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(115, 257);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(115, 96);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(309, 78);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 23);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(115, 32);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 297);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 260);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(252, 224);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(15, 192);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(80, 15);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(15, 98);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(15, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(414, 424);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(317, 424);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(308, 221);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(116, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(115, 221);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 4;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(554, 464);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add | Update Book";
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private ComboBox cboCategory;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}