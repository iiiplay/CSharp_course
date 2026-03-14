namespace Ch3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("比較運算子測試");

            int x = 10;
            int y = 20;
            Console.WriteLine(x == y);    //false
            Console.WriteLine(x > y);     //false
            Console.WriteLine(x < y);     //true
            Console.WriteLine(x >= y);    //false
            Console.WriteLine(x <= y);    //true
            Console.WriteLine(x != y);    //true


            int z = 30;
            Console.WriteLine("邏輯運算子測試");
            // &&  =>and  || =>or  ! =>not

            bool result = x < y && z > y && !(x > z);

            Console.WriteLine($"result:{result}");


            Console.WriteLine("分數評等=============");

            int score = 0;

            Console.WriteLine($"分數為:{score}");
            if (score == 100)
            {
                Console.WriteLine("評等為:A+");
                Console.WriteLine("及格!");
            }
            else if (score >= 90)
            {
                Console.WriteLine("評等:A");
                Console.WriteLine("及格!");
            }
            else if (score >= 80)
            {
                Console.WriteLine("評等:B");
                Console.WriteLine("及格!");
            }
            else if (score >= 70)
            {
                Console.WriteLine("評等:C");
                Console.WriteLine("及格!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("評等:D");
                Console.WriteLine("及格!");
            }
            else
            {
                Console.WriteLine("評等:E");
                Console.WriteLine("不及格!");
            }


            Console.WriteLine("咖啡計價：");
            string drink = "綠茶";
            string size = "中杯";
            int price = 0;
            // 問題
            if (drink == "美式咖啡" && size == "大杯") { price = 80; }
            if (drink == "美式咖啡" && size == "小杯") { price = 60; }
            if (drink == "拿鐵" && size == "大杯") { price = 110; }
            if (drink == "拿鐵" && size == "小杯") { price = 90; }
            //  drink 
            Console.WriteLine($"{size}，{drink}是 {price} 元");


            if (drink == "美式咖啡")
            {
                if (size == "大杯")
                {
                    price = 80;
                }
                else
                {
                    price = 60;
                }

            }
            else if (drink == "拿鐵")
            {
                if (size == "大杯")
                {
                    price = 110;
                }
                else if (size == "中杯")
                {
                    price = 100;
                }
                else
                {
                    price = 90;
                }
            }
            else
            {
                Console.WriteLine("目前無此品項...");
            }

            Console.WriteLine($"{size}，{drink}是 {price} 元");

        }
    }
}
