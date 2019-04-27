using System;
using System.Linq;

namespace MusicGroup
{
    public class FindGroup
    {
        public FindGroup()
        {
            using (var context = new MusicContext())
            {
                Console.Write("Введите название группы которую хотите найти: ");
                string nameGroup = Console.ReadLine();
                var results = context.musicGroups.ToList().Where(x => x.Name == nameGroup);
                foreach (var song in results)
                {
                    Console.WriteLine($"{song.Name} + {song.Song.Name} + {song.Song.Time} + {song.Song.Rating}");
                }
            }
        }
    }
}