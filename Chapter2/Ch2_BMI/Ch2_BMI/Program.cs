namespace Ch2_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI計算APP V1.0");
            //體重 (公斤) 除以身高 (公尺) 的平方

            Console.Write("請輸入身高:");
            double height = double.Parse(Console.ReadLine()!);
            Console.Write("請輸入體重:");
            double weight = double.Parse(Console.ReadLine()!);

            /*
             * 計算BMI，並輸出
             * 
             */
            double bmi = weight / ((height / 100) * (height / 100));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"身高:{height}cm\n體重:{weight}kg\nBMI:{bmi:F2}");

            //18.5 ≤ BMI < 24
            // 恭喜！「健康體重」，要繼續保持！ && =>以及的意思
            if (bmi >= 18.5 && bmi < 24)
            {
                Console.WriteLine("恭喜！「健康體重」，要繼續保持！");
            }
            else
            {
                Console.WriteLine("需要注意BMI...");
            }
        }
    }
}
