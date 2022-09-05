
namespace CustomerDataEntry
{
    partial class FormCustomerPreview
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.CustomerData = new System.Windows.Forms.Label();
            this.AddressData = new System.Windows.Forms.Label();
            this.StatusData = new System.Windows.Forms.Label();
            this.HobbiesData = new System.Windows.Forms.Label();
            this.GenderData = new System.Windows.Forms.Label();
            this.CountryData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(133, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:-";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(85, 20);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country   :-";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 82);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender  :-";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(12, 115);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(85, 20);
            this.lblHobbies.TabIndex = 5;
            this.lblHobbies.Text = "Hobbies  :-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status  :-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 178);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(89, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Adderss   :-";
            // 
            // CustomerData
            // 
            this.CustomerData.AutoSize = true;
            this.CustomerData.Location = new System.Drawing.Point(151, 20);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.Size = new System.Drawing.Size(0, 20);
            this.CustomerData.TabIndex = 8;
            // 
            // AddressData
            // 
            this.AddressData.AutoSize = true;
            this.AddressData.Location = new System.Drawing.Point(151, 178);
            this.AddressData.Name = "AddressData";
            this.AddressData.Size = new System.Drawing.Size(0, 20);
            this.AddressData.TabIndex = 9;
            // 
            // StatusData
            // 
            this.StatusData.AutoSize = true;
            this.StatusData.Location = new System.Drawing.Point(151, 145);
            this.StatusData.Name = "StatusData";
            this.StatusData.Size = new System.Drawing.Size(0, 20);
            this.StatusData.TabIndex = 10;
            // 
            // HobbiesData
            // 
            this.HobbiesData.AutoSize = true;
            this.HobbiesData.Location = new System.Drawing.Point(151, 115);
            this.HobbiesData.Name = "HobbiesData";
            this.HobbiesData.Size = new System.Drawing.Size(0, 20);
            this.HobbiesData.TabIndex = 11;
            // 
            // GenderData
            // 
            this.GenderData.AutoSize = true;
            this.GenderData.Location = new System.Drawing.Point(151, 82);
            this.GenderData.Name = "GenderData";
            this.GenderData.Size = new System.Drawing.Size(0, 20);
            this.GenderData.TabIndex = 12;
            // 
            // CountryData
            // 
            this.CountryData.AutoSize = true;
            this.CountryData.Location = new System.Drawing.Point(151, 50);
            this.CountryData.Name = "CountryData";
            this.CountryData.Size = new System.Drawing.Size(0, 20);
            this.CountryData.TabIndex = 13;
            // 
            // FormCustomerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.CountryData);
            this.Controls.Add(this.GenderData);
            this.Controls.Add(this.HobbiesData);
            this.Controls.Add(this.StatusData);
            this.Controls.Add(this.AddressData);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FormCustomerPreview";
            this.Text = "Customer preview";
            this.Load += new System.EventHandler(this.FormCustomPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label CustomerData;
        private System.Windows.Forms.Label AddressData;
        private System.Windows.Forms.Label StatusData;
        private System.Windows.Forms.Label HobbiesData;
        private System.Windows.Forms.Label GenderData;
        private System.Windows.Forms.Label CountryData;
    }
}