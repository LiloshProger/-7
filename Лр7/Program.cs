using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string line = Console.ReadLine(); //исходная строка
    //        HashSet<char> setLine = TranslateLineToSet(line); //множество символов исходной строки
    //        PrintSet(setLine);


    //        HashSet<char> setDigit = new HashSet<char> { '+', '=', '-', '/', '*', '%', '^', '~', ',', '.', '-', '!', '?', ';', ':', ')', '(', '"', ']', '[', '{', '}' };// множество символов, которые нужно найти
    //        PrintSet(setDigit);

    //        HashSet<char> newSet = setLine; // копия исходного множества
    //        newSet.IntersectWith(setDigit); //пересечение 

    //        PrintSet(newSet);
    //        Console.ReadKey();
    //    }
    //    private static HashSet<char> TranslateLineToSet(string word)
    //    {
    //        HashSet<char> setWord = new HashSet<char>();
    //        foreach (char c in word)
    //        {
    //            setWord.Add(c);
    //        }
    //        return setWord;
    //    }
    //    private static void PrintSet(HashSet<char> set)
    //    {
    //        foreach (char c in set)
    //        {
    //            Console.Write($"{c} ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 2");
            string[] allList = {"Strawberry", "Blueberry", "Raspberry", "Apples", "Pears",
                "Apricots", "Plums", "Cherry", "Grapes"};
            string[] list1 = { "Plums", "Raspberry", "Apples", "Pears" };
            string[] list2 = { "Blueberry", "Apples", "Plums", "Apricots" };
            string[] list3 = { "Raspberry", "Pears", "Apricots", "Plums" };
            string[] list4 = { "Apples", "Plums", "Cherry", "Plums" };
            string[] list5 = { "Pears", "Cherry", "Grapes", "Plums" };
            PrintSet(allList);
            PrintSet(list1);
            PrintSet(list2);
            PrintSet(list3);
            PrintSet(list4);
            PrintSet(list5);
            Console.WriteLine("Входит во все множества:");
            PrintSet(list1.Intersect(list2).Intersect(list3).Intersect(list4).Intersect(list5));

            Console.WriteLine("НЕ входит ни в одно множества:");
            PrintSet(allList.Except(list1).Except(list2).Except(list3).Except(list4).Except(list5));
           
            Console.WriteLine("Входят в первое и третье множества, но не входят в пятое:");
            PrintSet(allList.Intersect(list1).Intersect(list3).Except(list5));

        }
            private static void PrintSet(IEnumerable<string> set)
            {
                foreach (string c in set)
                {
                    Console.Write($"{c} ");
                }
                Console.WriteLine();
            }

       

    }
}
