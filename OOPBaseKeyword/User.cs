using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBaseKeyword
{
    internal class User : BaseEntity
    {
        public User()
        {
            MessageBox.Show("User Constructor Çalıştı.");
        }

        /*
        : base(dateTime) eklediğimde base class taki  (BaseEntity) parametreli metodu çalıştırmaktadır.
        public BaseEntity(DateTime dateTime)
        {
            MessageBox.Show("BaseEntity Tarihli Constructor Çalıştı." + dateTime.ToString());
        }
        */

        public User(DateTime dateTime) : base(dateTime)
        {
            MessageBox.Show("User Constructor Tarih Çalıştı." + dateTime.ToString());
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GsmPhone { get; set; }
        public string Password { get; set; }
    }
}