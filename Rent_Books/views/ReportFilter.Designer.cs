namespace Rent_Books
{
    partial class ReportFilter
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxAtribute = new System.Windows.Forms.TextBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Todos Registros",
            "Usuario",
            "Livro"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 37);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 0;
            // 
            // textBoxAtribute
            // 
            this.textBoxAtribute.Location = new System.Drawing.Point(149, 36);
            this.textBoxAtribute.Name = "textBoxAtribute";
            this.textBoxAtribute.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtribute.TabIndex = 4;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(285, 35);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(87, 23);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Gerar Relatorio";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerar relatorio a partir de:";
            // 
            // ReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.textBoxAtribute);
            this.Controls.Add(this.comboBoxType);
            this.Name = "ReportFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxAtribute;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label label1;
    }
}