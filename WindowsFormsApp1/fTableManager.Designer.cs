namespace WindowsFormsApp1
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.Pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SsnDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdmin = new System.Windows.Forms.RichTextBox();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PRICE = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LOC_TO = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TYPEPAY = new System.Windows.Forms.RichTextBox();
            this.SSN_CR = new System.Windows.Forms.RichTextBox();
            this.SSN_EMP = new System.Windows.Forms.RichTextBox();
            this.SSN_CS = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.flipTable = new System.Windows.Forms.FlowLayoutPanel();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.profileToolStripMenuItem.Text = "UpdateAccount";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewAdmin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(485, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 343);
            this.panel2.TabIndex = 0;
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pid,
            this.Type,
            this.TypeLevel,
            this.Weight,
            this.SsnDriver,
            this.Time,
            this.Location});
            this.listViewAdmin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listViewAdmin.GridLines = true;
            this.listViewAdmin.HideSelection = false;
            this.listViewAdmin.Location = new System.Drawing.Point(3, 0);
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(443, 340);
            this.listViewAdmin.TabIndex = 0;
            this.listViewAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewAdmin.View = System.Windows.Forms.View.Details;
            this.listViewAdmin.SelectedIndexChanged += new System.EventHandler(this.listViewAdmin_SelectedIndexChanged);
            // 
            // Pid
            // 
            this.Pid.Text = "Pid";
            this.Pid.Width = 54;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // TypeLevel
            // 
            this.TypeLevel.Text = "TypeLevel";
            this.TypeLevel.Width = 78;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            // 
            // SsnDriver
            // 
            this.SsnDriver.Text = "SssDriver";
            this.SsnDriver.Width = 72;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 50;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 71);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBoxAdmin);
            this.panel4.Controls.Add(this.deleteAdminButton);
            this.panel4.Location = new System.Drawing.Point(485, 489);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 48);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Location = new System.Drawing.Point(218, 8);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(216, 29);
            this.textBoxAdmin.TabIndex = 7;
            this.textBoxAdmin.Text = "";
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.Location = new System.Drawing.Point(119, 8);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(93, 32);
            this.deleteAdminButton.TabIndex = 4;
            this.deleteAdminButton.Text = "DELETE";
            this.deleteAdminButton.UseVisualStyleBackColor = true;
            this.deleteAdminButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PRICE);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.LOC_TO);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.TYPEPAY);
            this.panel5.Controls.Add(this.SSN_CR);
            this.panel5.Controls.Add(this.SSN_EMP);
            this.panel5.Controls.Add(this.SSN_CS);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.labelUsername);
            this.panel5.Location = new System.Drawing.Point(485, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 102);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // PRICE
            // 
            this.PRICE.Location = new System.Drawing.Point(315, 72);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(128, 26);
            this.PRICE.TabIndex = 12;
            this.PRICE.Text = "";
            this.PRICE.TextChanged += new System.EventHandler(this.PRICE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE_O";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LOC_TO
            // 
            this.LOC_TO.Location = new System.Drawing.Point(87, 72);
            this.LOC_TO.Name = "LOC_TO";
            this.LOC_TO.Size = new System.Drawing.Size(109, 26);
            this.LOC_TO.TabIndex = 10;
            this.LOC_TO.Text = "";
            this.LOC_TO.TextChanged += new System.EventHandler(this.LOC_TO_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "LOC_TO";
            // 
            // TYPEPAY
            // 
            this.TYPEPAY.Location = new System.Drawing.Point(315, 40);
            this.TYPEPAY.Name = "TYPEPAY";
            this.TYPEPAY.Size = new System.Drawing.Size(128, 26);
            this.TYPEPAY.TabIndex = 8;
            this.TYPEPAY.Text = "";
            this.TYPEPAY.TextChanged += new System.EventHandler(this.TYPEPAY_TextChanged);
            // 
            // SSN_CR
            // 
            this.SSN_CR.Location = new System.Drawing.Point(87, 40);
            this.SSN_CR.Name = "SSN_CR";
            this.SSN_CR.Size = new System.Drawing.Size(109, 26);
            this.SSN_CR.TabIndex = 7;
            this.SSN_CR.Text = "";
            // 
            // SSN_EMP
            // 
            this.SSN_EMP.Location = new System.Drawing.Point(315, 3);
            this.SSN_EMP.Name = "SSN_EMP";
            this.SSN_EMP.Size = new System.Drawing.Size(128, 26);
            this.SSN_EMP.TabIndex = 6;
            this.SSN_EMP.Text = "";
            // 
            // SSN_CS
            // 
            this.SSN_CS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSN_CS.Location = new System.Drawing.Point(87, 3);
            this.SSN_CS.Name = "SSN_CS";
            this.SSN_CS.Size = new System.Drawing.Size(109, 26);
            this.SSN_CS.TabIndex = 5;
            this.SSN_CS.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "TYPEPAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "SSN_EMP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SSN_CR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(3, 3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(78, 26);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "SSN_CS";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // flipTable
            // 
            this.flipTable.AutoScroll = true;
            this.flipTable.Location = new System.Drawing.Point(0, 35);
            this.flipTable.Name = "flipTable";
            this.flipTable.Size = new System.Drawing.Size(479, 502);
            this.flipTable.TabIndex = 5;
            this.flipTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flipTable_Paint);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.driverToolStripMenuItem.Text = "Driver";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 549);
            this.Controls.Add(this.flipTable);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManager";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listViewAdmin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flipTable;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TYPEPAY;
        private System.Windows.Forms.RichTextBox SSN_CR;
        private System.Windows.Forms.RichTextBox SSN_EMP;
        private System.Windows.Forms.RichTextBox SSN_CS;
        private System.Windows.Forms.RichTextBox LOC_TO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Pid;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader TypeLevel;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader SsnDriver;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox PRICE;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textBoxAdmin;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
    }
}