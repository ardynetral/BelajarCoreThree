using BelajarCoreThree.Infrastructures.DataAccess;

namespace BelajarCoreThree.Models.Request
{
    public class MovieRequest
    {
        public string title { get; set; }

        public string overview { get; set; }

        public string poster { get; set; }
    }
}
