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

        //construtor padrao para cadastro
        public UsuarioCadastro()
        {
            InitializeComponent();
            txtNewEmail.Enabled = true;
            txtNewName.Enabled = true;
            update = false;
            

        }
        //construtor para atualização de usuario
        public UsuarioCadastro(int id)
        {
            InitializeComponent();
            txtNewEmail.Enabled = true;
            txtNewName.Enabled = true;
            _id = id;
            update = true;
            CarregarDados();
        }
        //Funcao pré-carrega dados do usuario que sera editado nos campos de entrada
        public void CarregarDados()
        {
            using (var db = new Model1Container())
            {
                var query = db.UserSet.Where(s => s.User_id == _id).FirstOrDefault();
                if (query != null)
                {
                    txtNewName.Text = query.Name;
                    txtNewEmail.Text = query.Email;
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                //verifica se é Update ou Create de User
                if (update == false)
                {
                    var user = new User { Name = txtNewName.Text, Email = txtNewEmail.Text };
                    db.UserSet.Add(user);
                }

                else
                {
                    var query = db.UserSet.Where(s => s.User_id == _id).FirstOrDefault();
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

