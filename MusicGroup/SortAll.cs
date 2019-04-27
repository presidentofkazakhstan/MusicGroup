using System;

namespace MusicGroup
{
    public class SortAll
    {
        public SortAll()
        {
            using (var context = new MusicContext())
            {
               
                Console.WriteLine("1 - сортировка по возрастанию");
                Console.WriteLine("2 - сортировка по убыванию");
                Console.Write("Select number: ");
                int selectNumber = int.Parse(Console.ReadLine());
                if(selectNumber == 1)
                {
                    
                }
            }
        }
    }
}