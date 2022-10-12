/*Создавать словарь*/
using System;
using System.IO;
using System.Text;

var DictionaryMake = new Dictionary<string, string>()
{
    
    ["Book"] = "Книга",
    ["Apple"] = "Яблоко",
    ["Pineapple"] = "Ананас"
};
try
{
    DictionaryMake.Add("Book","Тетрадь");
}
catch
{
    Console.WriteLine("Element with Key = Book already exists");
};

Console.WriteLine("1 -> Удаление" +
                  "2 -> Добавление"+
                  "3 -> Проверка наличия");
int i = int.Parse(Console.ReadLine());
switch (i)
{
    case 1:     //удаление 
        Console.WriteLine("\nRemove(\"Apple\")");
        DictionaryMake.Remove("Apple");

        if (!DictionaryMake.ContainsKey("Apple"))
        {
            Console.WriteLine("Key \"Apple\" is not found.");
        }
        break;
    
    case 2:   //добавление
        DictionaryMake.Add("Laptop","Ноутбук");
        break;
    case 3:
        var Dictionary = DictionaryMake.ContainsValue("Pineapple"); //проверка наличия
        break;
    default:
        Console.WriteLine("Ошибка");
        break;
        
}
foreach(var Dictionary in DictionaryMake)
{
    Console.WriteLine($"key: {Dictionary.Key}  value: {Dictionary.Value}");
}

class Exam
{
    public static void Main()  //Словари должны храниться в файлах
    {
        string path = "Exam.txt";

        try
        {
           
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("This is some text in your file.");
               
                fs.Write(info, 0, info.Length);
            }

           
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}