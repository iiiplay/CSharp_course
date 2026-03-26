using System.Threading.Channels;

namespace TodoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到代辦事項管理APP");
            List<string> todos= new List<string>() { "測試程式","去買牛奶!"};

            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("1.新增事項");
                Console.WriteLine("2.檢視事項");
                Console.WriteLine("3.更新事項");
                Console.WriteLine("4.刪除事項");
                Console.WriteLine("5.離開");
                Console.WriteLine("===============================");

                Console.Write("請輸入選項:");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine()!);
                }
                catch (Exception)
                {
                    Console.WriteLine("輸入錯誤，請重新輸入!");
                    continue;
                }


                if (choice == 1)
                {
                    //1.新增事項
                    Console.WriteLine("請輸入新增事項:");
                    string todo = Console.ReadLine()!;
                    todos.Add(todo);
                    Console.WriteLine($"新增事項完成，目前共有{todos.Count}個代辦事項");
                }

                if (choice == 2)
                {
                    Console.WriteLine($"目前代辦事項:{todos.Count}");
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{todos[i]}");
                    }                   
                }

                if (choice == 3)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增!");
                        continue;
                    }

                    Console.Write("請輸入要更新的事項(編號):");
                    if (int.TryParse(Console.ReadLine()!, out int index))
                    {
                        int realIndex = index - 1;
                        if (realIndex < 0 || realIndex >= todos.Count)
                        {
                            Console.WriteLine("無此事項編號，請重新輸入!");
                            continue;
                        }

                        Console.WriteLine("請輸入更新事項:");
                        string todo = Console.ReadLine()!;
                        todos[realIndex] =todo;
                        Console.WriteLine($"更新事項完成，目前共有{todos.Count}個代辦事項");                      
                    }
                    else
                    {
                        Console.WriteLine("輸入錯誤，請重新輸入!");
                    }
                }


                if (choice == 4)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增!");
                        continue;
                    }

                    Console.Write("請輸入要刪除的事項(編號):");
                    if (int.TryParse(Console.ReadLine()!,out int index))
                    {
                        int realIndex = index - 1;
                        if (realIndex < 0 || realIndex >= todos.Count)
                        {
                            Console.WriteLine("無此事項編號，請重新輸入!");
                            continue;
                        }

                        todos.RemoveAt(realIndex);
                        Console.WriteLine($"事項:{index} 刪除成功，代辦事項:{todos.Count}");

                    }
                    else
                    {
                        Console.WriteLine("輸入錯誤，請重新輸入!");
                    }       
                }

                Console.ReadKey();
            }


            //todos.Add("去買牛奶!");

            //todos.Add("研讀C#課程");

            //string todo = todos[0];

            //Console.WriteLine($"目前共{todos.Count}代辦事項");

            //foreach (string item in todos)
            //{
            //    Console.WriteLine($"{item}");
            //}



            //string removeTodo = "123";
            //if (!todos.Remove(removeTodo))
            //{
            //    Console.WriteLine($"移除 {removeTodo} 失敗!");
            //}

            todos.Clear();
            //todos.RemoveAt(0);
            Console.WriteLine($"目前剩下{todos.Count}代辦事項");
            Console.ReadKey();





        }
    }
}
