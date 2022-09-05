
namespace CustomerDataEntry
{
    partial class FormCustomerDataEntry
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.checkRead = new System.Windows.Forms.CheckBox();
            this.checkPaint = new System.Windows.Forms.CheckBox();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(59, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(133, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:-";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(372, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(126, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(59, 115);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(85, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country   :-";
            this.lblCountry.Click += new System.EventHandler(this.Country_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(59, 158);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender  :-";
            this.lblGender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(59, 209);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(85, 20);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Hobbies  :-";
            this.lblHobbies.Click += new System.EventHandler(this.Hobbies_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(59, 261);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status  :-";
            this.lblStatus.Click += new System.EventHandler(this.Status_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(59, 312);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(89, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Adderss   :-";
            this.lblAddress.Click += new System.EventHandler(this.Address_Click);
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(372, 107);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(121, 28);
            this.cmbCountries.TabIndex = 7;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkRead
            // 
            this.checkRead.AutoSize = true;
            this.checkRead.Location = new System.Drawing.Point(372, 204);
            this.checkRead.Name = "checkRead";
            this.checkRead.Size = new System.Drawing.Size(95, 24);
            this.checkRead.TabIndex = 10;
            this.checkRead.Text = "Reading";
            this.checkRead.UseVisualStyleBackColor = true;
            // 
            // checkPaint
            // 
            this.checkPaint.AutoSize = true;
            this.checkPaint.Location = new System.Drawing.Point(478, 204);
            this.checkPaint.Name = "checkPaint";
            this.checkPaint.Size = new System.Drawing.Size(92, 24);
            this.checkPaint.TabIndex = 11;
            this.checkPaint.Text = "Painting";
            this.checkPaint.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(478, 257);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(78, 24);
            this.radioSingle.TabIndex = 13;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(372, 257);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(87, 24);
            this.radioMarried.TabIndex = 12;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.Location = new System.Drawing.Point(372, 306);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(126, 26);
            this.txtAddress.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(372, 153);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(69, 24);
            this.checkMale.TabIndex = 18;
            this.checkMale.Text = "Male";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(478, 153);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(88, 24);
            this.checkFemale.TabIndex = 19;
            this.checkFemale.Text = "Female";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(684, 50);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 62;
            this.dtgCustomer.RowTemplate.Height = 28;
            this.dtgCustomer.Size = new System.Drawing.Size(467, 373);
            this.dtgCustomer.TabIndex = 20;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(63, 337);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Enter Email Address";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(435, 39);
            this.txtEmail.TabIndex = 23;
            // 
            // FormCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1190, 466);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.radioMarried);
            this.Controls.Add(this.checkPaint);
            this.Controls.Add(this.checkRead);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FormCustomerDataEntry";
            this.Text = "CustomerDataEntry";
            this.Load += new System.EventHandler(this.FormCustomerDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.CheckBox checkRead;
        private System.Windows.Forms.CheckBox checkPaint;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    }
}

