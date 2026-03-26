using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace TodoApp
{
    internal class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("1.新增事項");
            Console.WriteLine("2.檢視事項");
            Console.WriteLine("3.更新事項");
            Console.WriteLine("4.刪除事項");
            Console.WriteLine("5.離開");
            Console.WriteLine("===============================");
        }

        static bool IsInRange(int index, List<string> todos)
        {
            if (index < 0 || index >= todos.Count)
            {
                Console.WriteLine("無此事項編號，請重新輸入!");
                return false;
            }

            return true;
        }

        static int GetIntInput(string message = "請輸入數字")
        {
            int result;
            // 使用 while(true) 建立一個「不輸入正確就不讓你走」的無限迴圈
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()!;

                // TryParse 會嘗試轉換，成功回傳 true，並把結果塞進 result
                if (int.TryParse(input, out result))
                {
                    return result; // 成功了，直接把成果帶回家！
                }

                // 失敗了，碎碎念一下，然後因為在迴圈裡，它會再問一次
                Console.WriteLine("哎呀！這不是有效的數字，請再試一次。");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到代辦事項管理APP");
            List<string> todos = new List<string>() { "測試程式", "去買牛奶!" };

            while (true)
            {
                ShowMenu();
                int choice = GetIntInput("請輸入選項:");


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

                    int index = GetIntInput("請輸入要更新的事項(編號):");
                    int realIndex = index - 1;

                    if (!IsInRange(realIndex, todos)) continue;                    

                    Console.WriteLine("請輸入更新事項:");
                    string todo = Console.ReadLine()!;
                    todos[realIndex] = todo;
                    Console.WriteLine($"更新事項完成，目前共有{todos.Count}個代辦事項");

                }


                if (choice == 4)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增!");
                        continue;
                    }


                    int index = GetIntInput("請輸入要刪除的事項(編號):");

                    int realIndex = index - 1;
                    if (!IsInRange(realIndex, todos)) continue;

                    todos.RemoveAt(realIndex);
                    Console.WriteLine($"事項:{index} 刪除成功，代辦事項:{todos.Count}");
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
