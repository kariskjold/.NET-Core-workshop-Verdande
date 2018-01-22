using System;

namespace music.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public int NumPlays { get; set; }
    }
}