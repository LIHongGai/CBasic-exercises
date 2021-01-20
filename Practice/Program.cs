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


            /*

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
            */


            //案例二
            //班级找赵六
            //班级中有张三、李四、王五、赵六、田七、周八六位同学
            //请找出赵六同学送她回家
            //分别是用for循环和while循环实现
            /*
             
            //for语句

            //把班级里的同学定义成数组
            string[] ban = new string[] { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //获取数组中的长度
            int  chang=ban.Length;
            //用for语句循环找出赵六
            for (int i = 0; i < chang; i++)
            {
                //判断数组从班里获取到的名字，当获取到赵六时输出
                if (ban[i]=="赵六")
                {
                    Console.WriteLine(ban[i] + "找到了");
                    break;           //停止判断、寻找，当已经找到数据时就用break跳出循环
                }
            }
            */


            ////使用whil语句
            ////把班级里的同学定义成数组
            //string[] ban = new string[] { "张三", "李四", "王五", "赵六", "田七", "周八" };
            ////定义变量i
            //int i = 0;
            ////定义变量，用于存放数组遍历（获取）到的学生
            //string name = "";
            ////作为标记使用，便于程序判断是否找到了指定的学生
            //bool zhen = true;
            //while(name != "赵六")
            //{
            //    //如果索引值已经大于等于数组的长度，则说明没有找到指定的学生
            //    if(i>=ban.Length)
            //    {
            //        Console.WriteLine("此班级找不到该名学生。");
            //        zhen = false;
            //        //跳出循环
            //        break;    
            //    }
            //    //将遍历的数组元素赋值给变量name
            //    name = ban[i++];
            //}
            ////如果zhen为真，则说明找到了指定学生，系统输出
            //if (zhen) Console.WriteLine(name + "找到了");


            //do  while语句
            //使用whil语句
            //把班级里的同学定义成数组
            string[] ban = new string[] { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //定义变量i
            int i = 0;
            //定义变量，用于存放数组遍历（获取）到的学生
            string name = "";
            //作为标记使用，便于程序判断是否找到了指定的学生
            bool zhen = true;
            do
            {
                //如果索引值已经大于等于数组的长度，则说明没有找到指定的学生
                if (i >= ban.Length)
                {
                    Console.WriteLine("此班级找不到该名学生。");
                    zhen = false;
                    //跳出循环
                    break;
                }
                //将遍历的数组元素赋值给变量name
                name = ban[i++];
            } while (name != "赵六");
            //如果zhen为真，则说明找到了指定学生，系统输出
            if (zhen) Console.WriteLine(name + "找到了");
        }
    }
}
