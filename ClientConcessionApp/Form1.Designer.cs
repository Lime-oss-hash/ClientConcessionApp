namespace ClientConcessionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtConcession = new RichTextBox();
            dtpBirthday = new DateTimePicker();
            btnSubmit = new Button();
            btnUpdate = new Button();
            lstUserList = new ListBox();
            AddConcession = new Button();
            RemoveConcession = new Button();
            btnAdd5 = new Button();
            btnRemove5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 83);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 215);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 80);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Concession:";
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 80);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // txtConcession
            // 
            txtConcession.Location = new Point(410, 107);
            txtConcession.Name = "txtConcession";
            txtConcession.Size = new Size(282, 58);
            txtConcession.TabIndex = 6;
            txtConcession.Text = "";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(162, 215);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(262, 288);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Sumbit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(162, 288);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // lstUserList
            // 
            lstUserList.FormattingEnabled = true;
            lstUserList.ItemHeight = 15;
            lstUserList.Location = new Point(408, 215);
            lstUserList.Name = "lstUserList";
            lstUserList.Size = new Size(284, 244);
            lstUserList.TabIndex = 11;
            lstUserList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddConcession
            // 
            AddConcession.Location = new Point(162, 337);
            AddConcession.Name = "AddConcession";
            AddConcession.Size = new Size(75, 23);
            AddConcession.TabIndex = 12;
            AddConcession.Text = "Add + 1";
            AddConcession.UseVisualStyleBackColor = true;
            AddConcession.Click += AddConcession_Click;
            // 
            // RemoveConcession
            // 
            RemoveConcession.Location = new Point(262, 337);
            RemoveConcession.Name = "RemoveConcession";
            RemoveConcession.Size = new Size(75, 23);
            RemoveConcession.TabIndex = 13;
            RemoveConcession.Text = "Remove -1";
            RemoveConcession.UseVisualStyleBackColor = true;
            RemoveConcession.Click += RemoveConcession_Click;
            // 
            // btnAdd5
            // 
            btnAdd5.Location = new Point(162, 382);
            btnAdd5.Name = "btnAdd5";
            btnAdd5.Size = new Size(75, 23);
            btnAdd5.TabIndex = 14;
            btnAdd5.Text = "Add + 5";
            btnAdd5.UseVisualStyleBackColor = true;
            btnAdd5.Click += btnAdd5_Click;
            // 
            // btnRemove5
            // 
            btnRemove5.Location = new Point(262, 382);
            btnRemove5.Name = "btnRemove5";
            btnRemove5.Size = new Size(75, 23);
            btnRemove5.TabIndex = 15;
            btnRemove5.Text = "Remove -5";
            btnRemove5.UseVisualStyleBackColor = true;
            btnRemove5.Click += btnRemove5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 494);
            Controls.Add(btnRemove5);
            Controls.Add(btnAdd5);
            Controls.Add(RemoveConcession);
            Controls.Add(AddConcession);
            Controls.Add(lstUserList);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(dtpBirthday);
            Controls.Add(txtConcession);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private RichTextBox txtConcession;
        private DateTimePicker dtpBirthday;
        private Button btnSubmit;
        private Button btnUpdate;
        private ListBox lstUserList;
        private Button AddConcession;
        private Button RemoveConcession;
        private Button btnAdd5;
        private Button btnRemove5;
    }
}