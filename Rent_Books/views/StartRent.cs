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
    public partial class StartRent : Form
    {
        private int idBook;
        public StartRent(int _id)
        {
            InitializeComponent();
            boxType.SelectedIndex = 1;
            idBook = _id;
            All_Users();
        }

        public void All_Users()
        {
            using (var db = new Model1Container())
            {
                var query = from item in db.UserSet select item;
                Load_List(query);
            }
        }

        public void Load_List(IQueryable<User> list)
        {
            listUsers.Clear();
            listUsers.View = View.Details;
            listUsers.Columns.Add("Id", 50, HorizontalAlignment.Center);
            listUsers.Columns.Add("Nome", 100, HorizontalAlignment.Center);
            listUsers.Columns.Add("Email", 100, HorizontalAlignment.Center);

            foreach (var item in list)
            {
                var linha = new string[3];
                linha[0] = item.Id.ToString();
                linha[1] = item.Name.ToString();
                linha[2] = item.Email.ToString();
                var itmx = new ListViewItem(linha);
                listUsers.Items.Add(itmx);
            }
        }

        public void AddRent(int idBook, int idUser)
        {
            using (var db = new Model1Container())
            {
                var user = db.UserSet.Where(s => s.Id == idUser).FirstOrDefault();
                var book = db.BookSet.Where(s => s.Id == idBook).FirstOrDefault();
                book.Quantity -= 1;
                var rent = new Rent { DateStart = DateTime.Now, User_id = idUser, Book_Id = idBook, State = true, User = user, Book = book,DateEnd=null };
                db.RentSet.Add(rent);
                db.SaveChanges();
                MessageBox.Show("Realizado emprestimo do livro "+ book.Name+ " para o usuario " + user.Name);
                Close();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                AddRent(idBook, Convert.ToInt32(listUsers.SelectedItems[0].Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Necessario selecionar usuario que fara o emprestimo");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    var atribute = boxType.SelectedItem.ToString();
                    if (textUser.TextLength < 1)
                    {
                        All_Users();
                    }
                    else
                    {
                        switch (atribute)
                        {
                            case "Codigo":
                                var queryCod = from item in db.UserSet
                                               where item.Id.ToString().ToLower() == textUser.Text.ToLower()
                                               select item;
                                Load_List(queryCod);
                                break;

                            case "Nome":
                                var queryName = from item in db.UserSet
                                                where item.Name.ToString().ToLower() == textUser.Text.ToLower()
                                                select item;
                                Load_List(queryName);
                                break;

                            case "Email":
                                var queryAuthor = from item in db.UserSet
                                                  where item.Email.ToString().ToLower() == textUser.Text.ToLower()
                                                  select item;
                                Load_List(queryAuthor);
                                break;
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: Campo tipo de busca obrigatorio.");
            }
        }
    }
}
