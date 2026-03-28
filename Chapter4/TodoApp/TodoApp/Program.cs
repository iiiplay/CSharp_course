namespace TodoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("代辦事項APP");
            List<string> todos = new List<string>();

            Console.WriteLine($"目前共有{todos.Count}個代辦事項");

            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("1.新增事項");
                Console.WriteLine("2.檢視事項");
                Console.WriteLine("3.更新事項");
                Console.WriteLine("4.刪除事項");
                Console.WriteLine("5.離開");
                Console.WriteLine("===============================");

                Console.Write("請輸入選擇:");

                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine()!);
                    if (choice < 1 || choice > 5)
                    {
                        Console.WriteLine("輸入選項錯誤，請重新輸入!");
                    }
                }
                catch
                {
                    Console.WriteLine("輸入錯誤，請重新輸入!");
                }

                //離開功能
                if (choice == 5) break;


                //新增功能
                if (choice == 1)
                {
                    Console.WriteLine("請輸入新增事項:");
                    string todo = Console.ReadLine()!;
                    todos.Add(todo);
                    Console.WriteLine($"新增事項成功!目前共有{todos.Count}個代辦事項");
                }

                //檢視功能
                if (choice == 2)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增。");
                        continue;
                    }

                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"事項{i + 1}:{todos[i]}");
                    }
                }

                //更新功能
                if (choice == 3)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增。");
                        continue;
                    }

                    Console.Write("請輸入修改編號:");
                    if (int.TryParse(Console.ReadLine()!, out int index))
                    {
                        //轉換成實際索引值
                        index--;
                        //確認索引在範圍之內
                        if (index < 0 || index >= todos.Count)
                        {
                            Console.WriteLine("無此代辦事項編號");
                        }
                        else
                        {
                            Console.WriteLine("請輸入更新事項:");
                            string todo = Console.ReadLine()!;
                            todos[index] = todo;
                            Console.WriteLine($"更新事項{index + 1}成功!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("輸入編號不正確");
                    }
                }

                //刪除功能
                if (choice == 4)
                {
                    if (todos.Count == 0)
                    {
                        Console.WriteLine("目前無代辦事項，請先新增。");
                        continue;
                    }

                    Console.Write("請輸入刪除編號:");
                    if (int.TryParse(Console.ReadLine()!, out int index))
                    {
                        //轉換成實際索引值
                        index--;
                        //確認索引在範圍之內
                        if (index < 0 || index >= todos.Count)
                        {
                            Console.WriteLine("無此代辦事項編號");
                        }
                        else
                        {
                            todos.RemoveAt(index);
                            Console.WriteLine($"刪除事項{index + 1}成功!目前剩下{todos.Count}個代辦事項");
                        }
                    }
                    else
                    {
                        Console.WriteLine("輸入編號不正確");
                    }
                }



                Console.ReadKey();
            }

            Console.WriteLine("感謝使用");





            // Ctrl+K+C  (U)

            //Console.WriteLine($"第一個事項:{todos[0]}，最後一個事項:{todos[todos.Count - 1]}");

            //for (int i = 0; i < todos.Count; i++)
            //{
            //    Console.WriteLine($"事項{i + 1}:{todos[i]}");
            //}

            ////修改
            //todos[0] = "去大賣場，買牛奶";

            ////刪除元素
            //string removeTodo = "學習C#";
            //if (todos.Remove(removeTodo))
            //{
            //    Console.WriteLine("移除成功!");
            //}
            //else
            //{
            //    Console.WriteLine($"移除{removeTodo}失敗!");
            //}

            ////按照位置
            //todos.RemoveAt(0);
            ////整個清除
            //todos.Clear();

            //Console.WriteLine("=================================");
            //int count = 0;
            ////循環取值
            //foreach (string todo in todos)
            //{
            //    Console.WriteLine($"事項{count + 1}:{todo}");
            //    count++;
            //}


            Console.ReadKey();




        }
    }
}
