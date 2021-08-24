namespace Rent_Books
{
    partial class StartRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListView();
            this.boxType = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar usuario que fara o emprestimo por:";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(105, 26);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 20);
            this.textUser.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(208, 199);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Selecionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listUsers
            // 
            this.listUsers.FullRowSelect = true;
            this.listUsers.GridLines = true;
            this.listUsers.Location = new System.Drawing.Point(14, 51);
            this.listUsers.MultiSelect = false;
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(256, 142);
            this.listUsers.TabIndex = 3;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            // 
            // boxType
            // 
            this.boxType.FormattingEnabled = true;
            this.boxType.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "Email"});
            this.boxType.Location = new System.Drawing.Point(14, 25);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(85, 21);
            this.boxType.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(211, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(62, 21);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // StartRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 234);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.boxType);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label1);
            this.Name = "StartRent";
            this.Text = "StartRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ComboBox boxType;
        private System.Windows.Forms.Button buttonSearch;
    }
}