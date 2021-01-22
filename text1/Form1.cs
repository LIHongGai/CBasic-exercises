using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Intermediary(string inte)
        {
            Console.WriteLine(inte);
        }
        public string PostOffice(int area, int price)
        {
            return "张三想买这套房，愿意出价" + (area * price - 1) + "元";
        }

        public void Football()
        {
            Console.WriteLine("梅西会打篮球");
        }
    }
}
