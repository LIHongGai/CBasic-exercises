using System;

namespace Practice
{
    class Program
    {/// <summary>
    /// 练习例题
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //案例一
            /*
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
            
            */

            //*如果达到10元就打折（如26元）只给20元打折，该怎么算呢?
            double price = 1.9;//价格
            double number = 26; //买的数量
            double discount = 0.75;//优惠的价格
            double total;          //设置总价的变量


            //计算总价钱
            total = number * price;
            //计算整十的数
            int n = (int)(total / 10);

            //计算整十打折后的得数
            //给打折后的整十设置变量
            double zhe=0;
            //计算整十打折后的得数
            for (int i = 0; i < n; i++)
            {
                zhe = zhe+10 * discount;
            }
            //取余
            double y = total % 10;
            //整十打折后的得数加余数
            total = zhe + y;
            Console.WriteLine(total);
        }
    }
}
