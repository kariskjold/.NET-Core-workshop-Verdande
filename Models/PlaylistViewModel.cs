using System;
using System.Collections.Generic;

namespace music.Models
{
    public class PlaylistViewModel
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
    }
}