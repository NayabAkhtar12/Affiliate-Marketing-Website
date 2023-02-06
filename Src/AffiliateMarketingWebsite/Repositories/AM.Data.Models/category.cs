using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public class category : BaseEntity
    {
        public category() 
        {
            Categories=new HashSet<category>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;

        public ICollection<category> Categories { get; set; }
    }
}
