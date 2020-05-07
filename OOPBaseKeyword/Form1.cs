using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBaseKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User(DateTime.Now)
            {
                FirstName = "Ali Yasin",
                LastName = "Doğan",
                CreatedDate = DateTime.Now,
                GsmPhone = "05554443355",
                Password = "12345",
                UserName = "aliyasin",
                CreatedUserID = 1,
            };
        }
    }
}