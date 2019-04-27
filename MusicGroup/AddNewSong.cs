using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup
{
    public class AddNewSong
    {
        public AddNewSong()
        {
            using (var context = new MusicContext())
            {
                Console.WriteLine("Введите название песни: ");
                var name = Console.ReadLine();
                Console.WriteLine("Введите текст песни: ");
                var text = Console.ReadLine();
                Console.WriteLine("Введите время звучания песни: ");
                double time = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите рейтинг песни(1-5): ");
                int rating = int.Parse(Console.ReadLine());


                var newSong = new Song
                {
                    Name = name,
                    Text = text,
                    Time = time,
                    Rating = rating,
                };

                Console.WriteLine("Введите название группы: ");
                var nameGroup = Console.ReadLine();



                var newMusicGroup = new MusicGroup
                {
                    Name = nameGroup,
                    Song = newSong


                };

                

                context.Songs.Add(newSong);
                context.musicGroups.Add(newMusicGroup);
                context.SaveChanges();
            }
        }
    }
}
