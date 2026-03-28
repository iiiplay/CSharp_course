namespace Ch5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("函式宣告");

            //第一種類型，無參數無回傳值
            void Add()
            {
                int a = 10;
                int b = 20;
                Console.WriteLine(a + b);
            }

            Add();

            //第二種類型，有參數無回傳值
            void Add2(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            Console.WriteLine("---------------------------------");

            Add2(5, -10);
            Add2(10, 15);
            Add2(0, 5);

            //第三種類型，有參數有回傳值(return)           
            int Add3(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine("---------------------------------");

            int a = Add3(5, -10);
            int b = Add3(10, 15);
            int c = Add3(0, 5);

            Console.WriteLine($"{a} {b} {c} {(a + b + c) / 3}");



            double CalculateBMIValue(double heightCm, double weightKg)
            {
                double heightM = heightCm / 100;
                double bmi = weightKg / (heightM * heightM);
                return bmi;
            }

            Console.WriteLine(CalculateBMIValue(167.5, 59.6));         




            //特殊函式



            //多載

        }
    }
}
