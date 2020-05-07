using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPRefKeyword
{
    public partial class Form1 : Form
    {
        /*
         * int gibi değer tiplere sonradan eklenen değerler herhangi bir ekleme yapmaz
         * Değer tipini ref anahtarı ile referans tipine dönüştürerek istediğimzi sonuçu elde ederiz.
         */

        public Form1()
        {
            InitializeComponent();
            int s = 9;
            int s1 = 9;
            IncreaseTheNumber(s);
            IncreaseTheNumber2(ref s1);
            MessageBox.Show("s  Sayısı: " + s.ToString() + "\n -----------------\n" + "s1 Sayısı: " + s1.ToString());
        }

        /// <summary>
        /// Sayıyı Arttır
        /// </summary>
        private void IncreaseTheNumber(int n)
        {
            n++;
        }

        private void IncreaseTheNumber2(ref int n1)
        {
            n1++;
        }
    }
}