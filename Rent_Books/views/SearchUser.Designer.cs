using System.Windows.Forms;

namespace Rent_Books
{
    partial class SearchUser
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
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.listUsers = new System.Windows.Forms.ListView();
            this.Search = new System.Windows.Forms.Button();
            this.deletUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Por:";
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(27, 65);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(100, 20);
            this.txtUserSearch.TabIndex = 1;
            // 
            // listUsers
            // 
            this.listUsers.FullRowSelect = true;
            this.listUsers.GridLines = true;
            this.listUsers.Location = new System.Drawing.Point(27, 103);
            this.listUsers.MultiSelect = false;
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(418, 208);
            this.listUsers.TabIndex = 2;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(133, 62);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Pesquisar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // deletUser
            // 
            this.deletUser.Location = new System.Drawing.Point(370, 336);
            this.deletUser.Name = "deletUser";
            this.deletUser.Size = new System.Drawing.Size(75, 23);
            this.deletUser.TabIndex = 4;
            this.deletUser.Text = "Deletar";
            this.deletUser.UseVisualStyleBackColor = true;
            this.deletUser.Click += new System.EventHandler(this.deletUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(289, 336);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(75, 23);
            this.updateUser.TabIndex = 5;
            this.updateUser.Text = "Alterar";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 382);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.deletUser);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.label1);
            this.Name = "SearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button deletUser;
        private System.Windows.Forms.Button updateUser;
        
    }
}