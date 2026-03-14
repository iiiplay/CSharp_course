namespace Ch3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //雙迴圈
            int count = 0;
            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    count++;   // count=count+1
                    // {i,-2} 欄位寬度為2，靠左
                    Console.WriteLine($"{i,-2}x{j,2} ={i*j,3}");
                }
                Console.WriteLine("======================");
            }

            Console.WriteLine($"共跑了:{count}次");


            //Console.WriteLine("迴圈測試 ========");
            Console.WriteLine("分數評等 =============");

           
            for (int i = 0; i < 0; i++)
            {
                Console.Write($"第{i + 1}次輸入:");               

                int score = int.Parse(Console.ReadLine()!);

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
            }
        }
    }
}
