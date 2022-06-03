namespace WindowsFormsApp1
{
    partial class fRegisterAccount
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.RetypePassTextbox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel28.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel30);
            this.panel2.Controls.Add(this.panel29);
            this.panel2.Controls.Add(this.panel28);
            this.panel2.Location = new System.Drawing.Point(22, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 175);
            this.panel2.TabIndex = 3;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.RetypePassTextbox);
            this.panel30.Controls.Add(this.label28);
            this.panel30.Location = new System.Drawing.Point(4, 114);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(570, 51);
            this.panel30.TabIndex = 3;
            // 
            // RetypePassTextbox
            // 
            this.RetypePassTextbox.Location = new System.Drawing.Point(155, 18);
            this.RetypePassTextbox.Name = "RetypePassTextbox";
            this.RetypePassTextbox.Size = new System.Drawing.Size(400, 22);
            this.RetypePassTextbox.TabIndex = 1;
            this.RetypePassTextbox.UseSystemPasswordChar = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(38, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(102, 24);
            this.label28.TabIndex = 0;
            this.label28.Text = "RetypePass";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.passwordTextbox);
            this.panel29.Controls.Add(this.labelPassword);
            this.panel29.Location = new System.Drawing.Point(4, 57);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(570, 51);
            this.panel29.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(155, 18);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(400, 22);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(38, 18);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 24);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.usernameTextBox);
            this.panel28.Controls.Add(this.label26);
            this.panel28.Location = new System.Drawing.Point(4, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(570, 48);
            this.panel28.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(155, 18);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(400, 22);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(38, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 24);
            this.label26.TabIndex = 0;
            this.label26.Text = "Username";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 24);
            this.label25.TabIndex = 5;
            this.label25.Text = "Account";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(453, 262);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(127, 51);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "PRE-STEP";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 325);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel2);
            this.Name = "fRegisterAccount";
            this.Text = "fRegisterAccount";
            this.panel2.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.TextBox RetypePassTextbox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}