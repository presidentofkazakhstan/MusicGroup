using System;
using System.Collections.Generic;

namespace MusicGroup
{
    public class Song
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string  Name { get; set; }

        public string Text { get; set; }

        public double Time { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<MusicGroup>  MusicGroup{ get; set; }

    }
}