namespace Ch4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("陣列的宣告");
            // 預設值為0
            //int[] scores = new int[10];
            // 賦值方式
            //scores[2] = 66;
            //scores[4] = 77;
            //scores[8] = 99;
            //scores[9] = 100;

            // 宣告即使用
            //double[] scores = { 66.6, 78.8, 99.5, 100, 76.5 };
            Random rand = new Random();

            for (int i = 0; ; i++)
            {
                int number = rand.Next(20);
                Console.WriteLine($"亂數{i + 1}:{number}");
                if (number == 0) break;
            }

            // 透過外部輸入
            double[] scores = new double[5];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}次分數:");
                scores[i] = double.Parse(Console.ReadLine()!);
            }

            // 取值方式
            Console.WriteLine(scores[0]);
            // 取最後位置的最好方式
            Console.WriteLine(scores[scores.Length - 1]);
            // Length (長度)
            Console.WriteLine($"陣列的長度:{scores.Length}");
            // 透過迴圈取值
            double total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"陣列位置:{i} => {scores[i]}");
                total += scores[i]; //total=total+score
            }

            Console.WriteLine($"總分為:{total} 平均分:{(total / scores.Length):F2}");
            Console.WriteLine("-------------------------------");
            // 計算平均分
            // 使用foreach
            total = 0;
            foreach (double score in scores)
            {
                Console.WriteLine($"陣列的值: => {score}");
                total += score; //total=total+score
            }

            total = scores.Sum();
            double avg = scores.Average();
            int count = scores.Count(s => s >= 60);


            Console.WriteLine($"總分為:{total} 平均分:{(total / scores.Length):F2}");

            Console.WriteLine($"總分為:{total} 平均分:{avg:F2}  及格人數:{count}");


          

        }
    }
}
