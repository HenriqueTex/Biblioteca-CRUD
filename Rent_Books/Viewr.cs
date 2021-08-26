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
        public Viewr()
        {
            InitializeComponent();
            using(var db= new Model1Container())
            {
                
                CrystalReport1.Database.Tables["Rent_Books_Book"].SetDataSource(db.BookSet.ToList());
                CrystalReport1.Database.Tables["Rent_Books_User"].SetDataSource(db.UserSet.ToList());
                CrystalReport1.Database.Tables["Rent_Books_Rent"].SetDataSource(db.RentSet.ToList());
            }
        }
    }
}
