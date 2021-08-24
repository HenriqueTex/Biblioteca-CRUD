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
    public partial class SearchUser : Form
    {

        public SearchUser()
        {
            InitializeComponent();
            txtUserSearch.Select();
            All_Users();

        }


        private void Search_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                if (txtUserSearch.TextLength < 1)
                {
                    All_Users();
                }
                else
                {
                    var query = from item in db.UserSet
                                where item.Name.ToLower() == txtUserSearch.Text.ToLower()
                                select item;
                    Load_List(query);
                }

            }
        }

        public void All_Users()
        {
            using (var db = new Model1Container())
            {
                var query = from item in db.UserSet
                            select item;
                Load_List(query);
            }
        }

        public void Load_List(IQueryable<User> list)
        {
            listUsers.Clear();
            listUsers.View = View.Details;
            listUsers.Columns.Add("Id", 100, HorizontalAlignment.Center);
            listUsers.Columns.Add("Nome", 150, HorizontalAlignment.Center);
            listUsers.Columns.Add("Email", 150, HorizontalAlignment.Center);

            foreach (var item in list)
            {
                var linha = new string[3];
                linha[0] = item.User_id.ToString();
                linha[1] = item.Name.ToString();
                linha[2] = item.Email.ToString();
                var itmx = new ListViewItem(linha);



                listUsers.Items.Add(itmx);
            }
        }

        private void deletUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                var itmx = listUsers.SelectedItems[0].Text;
                using (var db = new Model1Container())
                {
                    var query = db.UserSet.Where(s => s.User_id.ToString().ToLower() == itmx.ToString().ToLower()).FirstOrDefault();

                    db.UserSet.Remove(query);
                    db.SaveChanges();
                    MessageBox.Show("Usuario Excluido");
                    All_Users();


                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Necessario selecionar o usuario a ser excluido");
            }
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(listUsers.SelectedItems[0].Text);
                UsuarioCadastro cadastro = new UsuarioCadastro(id);
                cadastro.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Necessario selecionar o usuario a ser editado");
            }
        }


    }
}
