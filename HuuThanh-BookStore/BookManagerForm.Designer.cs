namespace BookStore_HoangNT
{
    partial class BookManagerForm
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
            lblId = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblReleasedDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            lblFormTitle = new Label();
            gbBookInfo.SuspendLayout();
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Cornsilk;
            lblId.Location = new Point(15, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
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
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(15, 98);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
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
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
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
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 260);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
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
            // txtName
            // 
            txtName.Location = new Point(115, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 23);
            txtName.TabIndex = 1;
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
            // txtAuthor
            // 
            txtAuthor.Location = new Point(115, 257);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 6;
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
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(115, 295);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(309, 23);
            cboCategory.TabIndex = 7;
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
            gbBookInfo.ForeColor = Color.Cornsilk;
            gbBookInfo.Location = new Point(22, 68);
            gbBookInfo.Margin = new Padding(3, 2, 3, 2);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(3, 2, 3, 2);
            gbBookInfo.Size = new Size(438, 334);
            gbBookInfo.TabIndex = 0;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
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
            // txtKeyword
            // 
            txtKeyword.Location = new Point(80, 26);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(194, 23);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(16, 28);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(53, 15);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Cornsilk;
            gbTask.Location = new Point(22, 411);
            gbTask.Margin = new Padding(3, 2, 3, 2);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(3, 2, 3, 2);
            gbTask.Size = new Size(438, 60);
            gbTask.TabIndex = 20;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(340, 26);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(231, 26);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(123, 26);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(15, 26);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Cornsilk;
            gbSearch.Location = new Point(494, 68);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(395, 60);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(290, 25);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.AppWorkspace;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(494, 182);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(458, 278);
            dgvBookList.TabIndex = 0;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.FromArgb(192, 0, 0);
            lblBookList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookList.ForeColor = Color.Cornsilk;
            lblBookList.Location = new Point(494, 153);
            lblBookList.Name = "lblBookList";
            lblBookList.Padding = new Padding(5);
            lblBookList.Size = new Size(75, 27);
            lblBookList.TabIndex = 23;
            lblBookList.Text = "Book List";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.LemonChiffon;
            lblFormTitle.Location = new Point(22, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(205, 37);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "Book Manager";
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImage = HuuThanh_BookStore.Properties.Resources.books_1163695_12804;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 484);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDesc;
        private Label lblReleasedDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;     
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
        private GroupBox gbBookInfo;
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Label lblFormTitle;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}