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
    public partial class RentsSearch : Form
    {
        public RentsSearch()
        {
            InitializeComponent();
            AllRents();
        }
        public void AllRents()
        {
            using (var db = new Model1Container())
            {
                var query = from item in db.RentSet
                            select item;
                LoadListRents(query);
            }
        }

        public void LoadListRents(IQueryable<Rent> list)
        {
            listRents.Clear();
            listRents.View = View.Details;
            listRents.Columns.Add("Codigo", 50, HorizontalAlignment.Center);
            listRents.Columns.Add("Usuario", 80, HorizontalAlignment.Center);
            listRents.Columns.Add("Livro", 80, HorizontalAlignment.Center);
            listRents.Columns.Add("Estado", 80, HorizontalAlignment.Center);
            listRents.Columns.Add("Data emprestimo", 150, HorizontalAlignment.Center);
            listRents.Columns.Add("Data devolução", 150, HorizontalAlignment.Center);

            foreach (var item in list)
            {
                var linha = new string[6];
                linha[0] = item.Rent_Id.ToString();
                linha[1] = item.User.Name.ToString();
                linha[2] = item.Book.Name.ToString();
                if (item.State == true) { linha[3] = "Ativo"; }
                else { linha[3] = "Finalizado"; }
                linha[4] = item.DateStart.ToString();
                linha[5] = item.DateEnd.ToString();

                ;
                var itmx = new ListViewItem(linha);



                listRents.Items.Add(itmx);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    var state = boxState.SelectedItem.ToString();
                    var atribute = boxAtributte.SelectedItem.ToString();
                    IQueryable<Rent> query;


                    switch (state)
                    {
                        case "Ativos":
                            if (textSearch.TextLength < 1)
                            {
                                query = db.RentSet.Where(s => s.State == true);
                                LoadListRents(query);
                            }
                            else
                            {
                                switch (atribute)
                                {
                                    case "Usuario":
                                        query = db.RentSet.Where(s => s.State == true).Where(s => s.User.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Livro":
                                        query = db.RentSet.Where(s => s.State == true).Where(s => s.Book.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Codigo emprestimo":
                                        var id = Convert.ToInt32(textSearch.Text);
                                        query = db.RentSet.Where(s => s.State == true).Where(s => s.Rent_Id == id);
                                        LoadListRents(query);
                                        break;
                                }
                            }
                            break;

                        case "Finalizados":
                            if (textSearch.TextLength < 1)
                            {
                                query = db.RentSet.Where(s => s.State == false);
                                LoadListRents(query);
                            }
                            else
                            {
                                switch (atribute)
                                {
                                    case "Usuario":
                                        query = db.RentSet.Where(s => s.State == false).Where(s => s.User.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Livro":
                                        query = db.RentSet.Where(s => s.State == false).Where(s => s.Book.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Codigo emprestimo":
                                        var id = Convert.ToInt32(textSearch.Text);
                                        query = db.RentSet.Where(s => s.State == false).Where(s => s.Rent_Id == id);
                                        LoadListRents(query);
                                        break;
                                }
                            }
                            break;

                        case "Todos":
                            if (textSearch.TextLength < 1)
                            {
                                query = db.RentSet.Where(s => s.State == false);
                                LoadListRents(query);
                            }
                            else
                            {
                                switch (atribute)
                                {
                                    case "Usuario":
                                        query = db.RentSet.Where(s => s.User.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Livro":
                                        query = db.RentSet.Where(s => s.Book.Name == textSearch.Text);
                                        LoadListRents(query);
                                        break;
                                    case "Codigo emprestimo":
                                        var id = Convert.ToInt32(textSearch.Text);
                                        query = db.RentSet.Where(s => s.Rent_Id == id);
                                        LoadListRents(query);
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Campos de pesquisa obrigatorios");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Campos de pesquisa obrigatorios");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    var id = Convert.ToInt32(listRents.SelectedItems[0].Text);
                    var query = db.RentSet.Where(s => s.Rent_Id == id).FirstOrDefault();
                    query.State = false;
                    query.DateEnd = DateTime.Now;

                    var book = db.BookSet.Where(s => s.Book_Id == query.Book.Book_Id).FirstOrDefault();
                    book.Quantity += 1;
                    db.SaveChanges();

                    MessageBox.Show("livro "+book.Name+ " devolvido");
                    AllRents();
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um emprestimo para devolução");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            AllRents();
        }
    }
}


