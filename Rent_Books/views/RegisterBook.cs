using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Books
{
    public partial class RegisterBook : Form
    {
        private int _id;
        private Boolean update;
        public RegisterBook()
        {
            InitializeComponent();
            textName.Enabled = true;
            textAuthor.Enabled = true;
            textQuantity.Enabled = true;
            update = false;

        }

        public RegisterBook(int id)
        {
            InitializeComponent();
            textName.Enabled = true;
            textAuthor.Enabled = true;
            _id = id;
            update = true;
            CarregarDados();
        }

        public void CarregarDados()
        {
            using (var db = new Model1Container())
            {
                var query = db.BookSet.Where(s => s.Id == _id).FirstOrDefault();
                if (query != null)
                {
                    textName.Text = query.Name;
                    textAuthor.Text = query.Author;
                    textQuantity.Text = query.Quantity.ToString();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.TextLength < 1 | textAuthor.TextLength < 1)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos");
                }
                else
                {


                    using (var db = new Model1Container())
                    {
                        if (update == false)
                        {
                            var book = new Book { Name = textName.Text, Author = textAuthor.Text, Quantity = Convert.ToInt16(textQuantity.Text) };
                            db.BookSet.Add(book);
                        }
                        else
                        {
                            var query = db.BookSet.Where(s => s.Id == _id).FirstOrDefault();

                            query.Name = textName.Text;
                            query.Author = textAuthor.Text;
                            query.Quantity = Convert.ToInt16(textQuantity.Text);


                        }

                        db.SaveChanges();

                        Close();
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Erro: Quantidade deve ser um valor inteiro ");
            }
        }
    }
}
