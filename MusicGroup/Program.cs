using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 - добавление новой песни и группы");
            Console.WriteLine("2 - вывод всех песен и групп");
            Console.WriteLine("3 - поиск по песни");
            Console.WriteLine("4 - поиск  по группы");
            Console.WriteLine("5 - сортировка");

            int selectNumber = int.Parse(Console.ReadLine());



            if (selectNumber == 1)
            {
                AddNewSong addNewSong = new AddNewSong();
            }
            else if (selectNumber == 2)
            {
                PrintAll print = new PrintAll();
            }

            else if (selectNumber == 3)
            {
                FindSong findSong = new FindSong();
            }

            else if (selectNumber == 4)
            {
                FindGroup find = new FindGroup();
            }

            else if (selectNumber == 5)
            {
                SortAll sortAll = new SortAll();
            }


            Console.ReadLine();
        }
    }
}
