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
    public partial class Viewr : Form
    {
        public Viewr(string type, string atribute)
        {
            InitializeComponent();
            using (var db = new Model1Container())
            {
                switch (type)
                {
                    case "Todos Registros":
                        CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(db.BookSet.ToList());
                        CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(db.UserSet.ToList());
                        CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
                        break;
                    case "Usuario":
                        if ( atribute.Length <1)
                        {
                            CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(db.BookSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(db.UserSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
                        }
                        else
                        {
                            var queryUser = db.UserSet.Where(s => s.Name.ToLower() == atribute.ToLower());
                            CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(db.BookSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(queryUser.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
                        }
                        break;
                    case "Livro":
                        if (atribute.Length < 1)
                        {
                            CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(db.BookSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(db.UserSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
                        }
                        else
                        {
                            var queryBook = db.BookSet.Where(s => s.Name.ToLower() == atribute.ToLower());
                            CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(queryBook.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(db.UserSet.ToList());
                            CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
                        }
                        break;
                    
                }
                
                
            }
        }
    }
}
