namespace test2
{
    partial class UpdateProfileForm
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
            txtNationalId = new TextBox();
            label1 = new Label();
            btnChangeUsername = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new Point(90, 60);
            txtNationalId.Margin = new Padding(3, 2, 3, 2);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(255, 25);
            txtNationalId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(549, 54);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 1;
            label1.Text = ": کد ملی";
            // 
            // btnChangeUsername
            // 
            btnChangeUsername.Font = new Font("Segoe UI", 15F);
            btnChangeUsername.Location = new Point(280, 284);
            btnChangeUsername.Margin = new Padding(3, 2, 3, 2);
            btnChangeUsername.Name = "btnChangeUsername";
            btnChangeUsername.Size = new Size(143, 70);
            btnChangeUsername.TabIndex = 2;
            btnChangeUsername.Text = "اعمال تغییرات";
            btnChangeUsername.UseVisualStyleBackColor = true;
            btnChangeUsername.Click += btnChangeUsername_Click;
            btnChangeUsername.KeyDown += btnChangeUsername_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(508, 132);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 3;
            label2.Text = ": شماره تماس";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(508, 207);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 4;
            label3.Text = ": اسم و فامیل";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(90, 132);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(255, 25);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(90, 210);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(255, 25);
            txtFullName.TabIndex = 6;
            // 
            // UpdateProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(700, 383);
            Controls.Add(txtFullName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnChangeUsername);
            Controls.Add(label1);
            Controls.Add(txtNationalId);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateProfileForm";
            Text = "UpdateProfileForm";
            Load += UpdateProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNationalId;
        private Label label1;
        private Button btnChangeUsername;
        private Label label2;
        private Label label3;
        private TextBox txtPhoneNumber;
        private TextBox txtFullName;
    }
}