namespace test2
{
    partial class ChangeUsernameForm
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
            btnChangeUsername = new Button();
            label1 = new Label();
            txtNewUsername = new TextBox();
            SuspendLayout();
            // 
            // btnChangeUsername
            // 
            btnChangeUsername.Font = new Font("Segoe UI", 15F);
            btnChangeUsername.Location = new Point(279, 271);
            btnChangeUsername.Margin = new Padding(3, 2, 3, 2);
            btnChangeUsername.Name = "btnChangeUsername";
            btnChangeUsername.Size = new Size(144, 77);
            btnChangeUsername.TabIndex = 0;
            btnChangeUsername.Text = "اعمال تغییرات";
            btnChangeUsername.UseVisualStyleBackColor = true;
            btnChangeUsername.Click += btnChangeUsername_Click;
            btnChangeUsername.KeyDown += btnChangeUsername_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(447, 138);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = ": نام کاربری جدید";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(90, 144);
            txtNewUsername.Margin = new Padding(3, 2, 3, 2);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(260, 25);
            txtNewUsername.TabIndex = 2;
            // 
            // ChangeUsernameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(700, 383);
            Controls.Add(txtNewUsername);
            Controls.Add(label1);
            Controls.Add(btnChangeUsername);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangeUsernameForm";
            Text = "ChangeUsernameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeUsername;
        private Label label1;
        private TextBox txtNewUsername;
    }
}