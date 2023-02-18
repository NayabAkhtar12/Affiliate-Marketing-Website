
using System.ComponentModel.DataAnnotations;

namespace AM.Data.Models
{
    public class BaseEntity
    {
    [Key]
     public int Id { get; set; }
     public DateTime CreatedOn { get; set; }




    }
}
