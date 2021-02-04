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
            double total = buy(1.9, 6, 0.75);
            MessageBox.Show(total.ToString());
        }
        //*****************************封装函数******************************
        public double buy(double price, double number, double discount)
        {
            double total;          //设置总价的变量
            //计算总价钱
            total = number * price;
            //计算整十的数
            int n = (int)(total / 10);

            //计算整十打折后的得数
            //给打折后的整十设置变量
            double zhe = 0;
            //计算整十打折后的得数
            for (int i = 0; i < n; i++)
            {
                zhe = zhe + 10 * discount;
            }
            //取余
            double y = total % 10;
            //整十打折后的得数加余数
            total = zhe + y;
            return total;
        }
        //public void Intermediary(string inte)
        //{
        //    Console.WriteLine(inte);
        //}
        //public string PostOffice(int area, int price)
        //{
        //    return "张三想买这套房，愿意出价" + (area * price - 1) + "元";
        //}

        //public void Football()
        //{
        //    Console.WriteLine("梅西会打篮球");
        //}
    }
}
