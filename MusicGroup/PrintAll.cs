using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup
{
    public class PrintAll
    {
        

        public PrintAll()
        {

            using (var context = new MusicContext())
            {

                Console.WriteLine("Группы: ");
                foreach (var group in context.musicGroups)
                {

                    Console.Write("Группа: "+group.Name + "\nПесня: " + group.Song.Name + "\nВремя: " + group.Song.Time +
                        "\nРейтинг: " + group.Song.Rating + "\n");
                    Console.WriteLine("-----------------------------------");


                }
                
            }
        }
       
    }
}
