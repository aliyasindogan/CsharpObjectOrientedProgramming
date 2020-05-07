using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBaseKeyword
{
    internal class BaseEntity
    {
        public BaseEntity()
        {
            MessageBox.Show("BaseEntity Constructor Çalıştı.");
        }

        public BaseEntity(DateTime dateTime)
        {
            MessageBox.Show("BaseEntity Tarihli Constructor Çalıştı." + dateTime.ToString());
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserID { get; set; }
    }
}