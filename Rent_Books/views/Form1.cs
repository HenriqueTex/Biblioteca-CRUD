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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllBooks();
        }

        public void AllBooks()
        {
            using (var db = new Model1Container())
            {
                var query = from item in db.BookSet
                            select item;
                LoadListBooks(query);
            };

        }

        public void LoadListBooks(IQueryable<Book> list)
        {
            listBooks.Clear();
            listBooks.View = View.Details;
            listBooks.Columns.Add("Codigo", 50, HorizontalAlignment.Center);
            listBooks.Columns.Add("Nome", 150, HorizontalAlignment.Center);
            listBooks.Columns.Add("Autor", 150, HorizontalAlignment.Center);
            listBooks.Columns.Add("Disponiveis", 160, HorizontalAlignment.Center);

            foreach (var item in list)
            {
                var linha = new string[4];
                linha[0] = item.Book_Id.ToString();
                linha[1] = item.Name.ToString();
                linha[2] = item.Author.ToString();
                linha[3] = item.Quantity.ToString();
                var itmx = new ListViewItem(linha);



                listBooks.Items.Add(itmx);
            }
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioCadastro cadastroUser = new UsuarioCadastro();
            cadastroUser.Show();
        }

        private void pesquisarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUser searchUser = new SearchUser();
            searchUser.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            AllBooks();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                var itmx = listBooks.SelectedItems[0].Text;
                using (var db = new Model1Container())
                {
                    var query = db.BookSet.Where(s => s.Book_Id.ToString().ToLower() == itmx.ToString().ToLower()).FirstOrDefault();
                    if (query != null)
                    {
                        db.BookSet.Remove(query);
                        db.SaveChanges();
                        MessageBox.Show("Excluido");
                        AllBooks();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Necessario selecionar o livro a ser deletado");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(listBooks.SelectedItems[0].Text);
                RegisterBook cadastro = new RegisterBook(id);
                cadastro.Show();
                listBooks.Clear();
                AllBooks();
            }
            catch (SystemException)
            {
                MessageBox.Show("Um livro deve ser selecionado para edição");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    var atribute = boxType.SelectedItem.ToString();
                    if (textBusca.TextLength < 1)
                    {
                        AllBooks();
                    }
                    else
                    {
                        switch (atribute)
                        {
                            case "Codigo":
                                var queryCod = from item in db.BookSet
                                               where item.Book_Id.ToString().ToLower() == textBusca.Text.ToLower()
                                               select item;
                                LoadListBooks(queryCod);
                                break;

                            case "Nome":
                                var queryName = from item in db.BookSet
                                                where item.Name.ToString().ToLower() == textBusca.Text.ToLower()
                                                select item;
                                LoadListBooks(queryName);
                                break;

                            case "Autor":
                                var queryAuthor = from item in db.BookSet
                                                  where item.Author.ToString().ToLower() == textBusca.Text.ToLower()
                                                  select item;
                                LoadListBooks(queryAuthor);
                                break;
                        }
                    }
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Error: Campo tipo de busca obrigatorio." );
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    var bookId = Convert.ToInt32(listBooks.SelectedItems[0].Text);
                    var query = db.BookSet.Where(s => s.Book_Id == bookId).FirstOrDefault();
                    if (query.Quantity == 0)
                    {
                        MessageBox.Show("Livro Indisponivel para emprestimo");
                    }
                    else
                    {
                        StartRent rent = new StartRent(bookId);
                        rent.Show();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error: Necessario selecionar um livro para emprestimo");
            }
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rentSearch = new RentsSearch();
            rentSearch.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RegisterBook registerBook = new RegisterBook();
            registerBook.Show();
            AllBooks();
        }
    }
}
