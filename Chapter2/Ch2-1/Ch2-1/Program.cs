namespace Ch2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;

            Console.WriteLine(x+y); // 加法
            Console.WriteLine(x-y); // 減法
            Console.WriteLine(x*y); // 乘法
            // 整數相除還是整數 ，可以使用型態強制轉換
            Console.WriteLine((double)x/y); // 除法
            Console.WriteLine(x%y); // 餘數



            // 字串
            string drinkName = "黑咖啡";
            // 布林變數 true or false
            bool isHot = false;
            // 浮點數
            double price = 55.5;

            Console.WriteLine("{0} 單價:{1}元，請問要點幾杯:", drinkName, price);
            // 整數 int.Parse() 字串轉整數用法
            int cupCount = int.Parse(Console.ReadLine()!);

            // 總計
            double total = cupCount * price;

            Console.WriteLine("{0} 杯數:{1} 熱飲:{2} 單價:{3} 總計為:{4}",
                drinkName, cupCount, isHot, price, total);

            // \n=>換行 \t=>tab 預設四個空白
            Console.WriteLine($"\t{drinkName}\n杯數:{cupCount}\n熱飲:{isHot}\n單價:{price}\n總計為:{total}");

            Console.WriteLine("開始製作飲料==>");

            if (isHot)
            {
                Console.WriteLine("加入100.c開水，開始沖泡!");
                Console.WriteLine("進行攪拌~~~");
            }
            else
            {
                Console.WriteLine("加入冰塊~~~\n上下搖動!");
            }

        }
    }
}
