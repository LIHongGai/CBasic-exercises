using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例一
            //超市西瓜的价格是1.9元一斤
            //小明下班买了6斤
            //此时正逢双11，购买西瓜满10元优惠7.5折
            //小明卖西瓜花了多少钱？
            double price = 1.9;//价格
            double number = 6; //买的数量
            double discount = 0.75;//优惠的价格
            double total;          //设置总价的变量


            //先算出未折扣时的总价
            total = number * price;

            //做出判断，如果总价超过10元，应优惠7.5的折扣
            if(total>10)
            {
                total = total * discount;
            }
            Console.WriteLine("小明一共花了" + total + "元。");
        }
    }
}
