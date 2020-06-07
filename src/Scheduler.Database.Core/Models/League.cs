using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scheduler.Database.Core.Models
{
    [Table("league")]
    public class League
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("user"), Column("user_id")]
        public int UserId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_active")]
        public int IsActive { get; set; }
        
        public User User { get; set; }
    }
}