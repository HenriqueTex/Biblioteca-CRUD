namespace Rent_Books
{
    partial class RegisterBook
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
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(33, 159);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 20);
            this.textQuantity.TabIndex = 11;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(33, 106);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(100, 20);
            this.textAuthor.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(33, 54);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 9;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(32, 141);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(65, 13);
            this.quantity.TabIndex = 8;
            this.quantity.Text = "Quantidade ";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(35, 89);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(32, 13);
            this.author.TabIndex = 7;
            this.author.Text = "Autor";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 6;
            this.name.Text = "Nome";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(178, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RegisterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.author);
            this.Controls.Add(this.name);
            this.Name = "RegisterBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button SaveButton;
    }
}