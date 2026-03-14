// See https://aka.ms/new-console-template for more information

using System.Text;

// 將編碼格式改成UTF8
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

// 等待輸入
Console.Write("請輸入姓名:");
string name = Console.ReadLine()!;
Console.Write("請輸入年齡:");
// Console.ReadLine() 回傳是字串
string age = Console.ReadLine()!;

/* 
 * 程式練習:
 * 1.請增加輸入身高跟體重
 * 2.輸出身高體重 身高:{0}cm 體重 {1}kg 
 */

Console.Write("請輸入身高(cm):");
string height = Console.ReadLine()!;
Console.Write("請輸入體重(kg):");
string weight = Console.ReadLine()!;

// 格式化程式碼  CTRL+K+D
Console.Write("Hello," + name);
Console.WriteLine(" 今天天氣很好!");

// 字串格式化用法{0}
Console.WriteLine("Hello, {0} 年齡:{1} 今天天氣很好!", name, age);
// 輸出身高體重 身高:{0}cm 體重 {}kg
Console.WriteLine("身高:{0}cm 體重:{1}kg", height, weight);


// 等待任一鍵輸入
Console.ReadKey();










