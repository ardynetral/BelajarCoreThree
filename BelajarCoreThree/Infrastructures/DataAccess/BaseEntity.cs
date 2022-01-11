using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelajarCoreThree.Infrastructures.DataAccess
{
    public class BaseEntity
    {
        [Column(name: "created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column(name: "updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column(name: "deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}