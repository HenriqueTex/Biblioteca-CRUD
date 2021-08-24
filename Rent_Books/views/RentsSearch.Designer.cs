namespace Rent_Books
{
    partial class RentsSearch
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listRents = new System.Windows.Forms.ListView();
            this.boxState = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxAtributte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(564, 50);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(54, 19);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listRents
            // 
            this.listRents.FullRowSelect = true;
            this.listRents.GridLines = true;
            this.listRents.Location = new System.Drawing.Point(12, 75);
            this.listRents.Name = "listRents";
            this.listRents.Size = new System.Drawing.Size(606, 170);
            this.listRents.TabIndex = 14;
            this.listRents.UseCompatibleStateImageBehavior = false;
            this.listRents.View = System.Windows.Forms.View.Details;
            // 
            // boxState
            // 
            this.boxState.FormattingEnabled = true;
            this.boxState.Items.AddRange(new object[] {
            "Ativos",
            "Finalizados",
            "Todos"});
            this.boxState.Location = new System.Drawing.Point(12, 48);
            this.boxState.Name = "boxState";
            this.boxState.Size = new System.Drawing.Size(121, 21);
            this.boxState.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(415, 49);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(65, 21);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(309, 49);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(100, 20);
            this.textSearch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar  por emprestimos :";
            // 
            // boxAtributte
            // 
            this.boxAtributte.FormattingEnabled = true;
            this.boxAtributte.Items.AddRange(new object[] {
            "Codigo emprestimo",
            "Livro",
            "Usuario"});
            this.boxAtributte.Location = new System.Drawing.Point(182, 48);
            this.boxAtributte.Name = "boxAtributte";
            this.boxAtributte.Size = new System.Drawing.Size(121, 21);
            this.boxAtributte.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "do:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(543, 249);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.Text = "Devolução";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // RentsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 284);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxAtributte);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listRents);
            this.Controls.Add(this.boxState);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Name = "RentsSearch";
            this.Text = "RentsSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListView listRents;
        private System.Windows.Forms.ComboBox boxState;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxAtributte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReturn;
    }
}