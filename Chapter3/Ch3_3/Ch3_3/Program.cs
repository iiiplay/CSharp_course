namespace Ch3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While迴圈的使用方式");
            int i = 0;
            // while true => break
            while (true)
            {
                // 改成提前提示離開(-1 離開)
                Console.Write($"第{i + 1}次輸入(-1:離開):");           
                int score = int.Parse(Console.ReadLine()!);
                if (score == -1) break;

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

                i++;
                //Console.Write("是否離開?(y/n)");
                //string answer = Console.ReadLine()!;
                //if (answer =="y" || answer=="Y") break;             
            }



            int x = 0;

            // if => while 
            // break     (強制跳離)
            // continue  (跳過該次)
            while (x < 11)
            {
                x++;
                if (x == 4)
                {
                    //x++;
                    continue;
                }

                Console.WriteLine($"x={x}");
                //x++
            }



        }
    }
}
