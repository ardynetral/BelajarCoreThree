using BelajarCoreThree.Infrastructures.DataAccess;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelajarCoreThree.Domains.Movie.Entites
{
    [Table("movies")]
    public class MovieEntity
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("title")]
        public string title { get; set; }

        [Column("overview")]
        public string overview { get; set; }

        [Column("poster")]
        public string poster { get; set; }


    }
}
