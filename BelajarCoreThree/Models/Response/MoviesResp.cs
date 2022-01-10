using System;

namespace BelajarCoreThree
{
    public class MoviesResp
    {
        public DateTime Date { get; set; }

        public string Title { get; set; }
        public string Overview { get; set; }
        public TagsResp Tags { get; set; }
    }
}
