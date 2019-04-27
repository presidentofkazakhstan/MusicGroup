using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup
{
   public class FindSong
    {
        public FindSong()
        {
            using (var context = new MusicContext())
            {
                Console.Write("Введите название песни которую хотите найти: ");
                string nameSong = Console.ReadLine();
                var results = context.Songs.ToList().Where(x => x.Name == nameSong);
                foreach(var song in results)
                {
                    Console.WriteLine($"{song.Name} + {song.Time} + {song.Rating} + {song.Text} + {song.MusicGroup}");
                }
            }
        }
    }
}
