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
    public partial class UsuarioCadastro : Form
    {

        private int _id;
        private Boolean update;

        
        public UsuarioCadastro()
        {
            InitializeComponent();
            txtNewEmail.Enabled = true;
            txtNewName.Enabled = true;
            update = false;
            

        }
        
        public UsuarioCadastro(int id)
        {
            InitializeComponent();
            txtNewEmail.Enabled = true;
            txtNewName.Enabled = true;
            _id = id;
            update = true;
            CarregarDados();
        }
        
        public void CarregarDados()
        {
            using (var db = new Model1Container())
            {
                var query = db.UserSet.Where(s => s.Id == _id).FirstOrDefault();
                if (query != null)
                {
                    txtNewName.Text = query.Name;
                    txtNewEmail.Text = query.Email;
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (txtNewEmail.TextLength < 1 | txtNewName.TextLength <1 )
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            else
            {
                using (var db = new Model1Container())
                {

                    if (update == false)
                    {
                        var user = new User { Name = txtNewName.Text, Email = txtNewEmail.Text };
                        db.UserSet.Add(user);
                    }

                    else
                    {
                        var query = db.UserSet.Where(s => s.Id == _id).FirstOrDefault();
                        if (query != null)
                        {
                            query.Name = txtNewName.Text;
                            query.Email = txtNewEmail.Text;
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }


                    db.SaveChanges();
                    MessageBox.Show("Usuario " + txtNewName.Text + " Salvo");
                    Close();

                }
            }
        }



    }
}

