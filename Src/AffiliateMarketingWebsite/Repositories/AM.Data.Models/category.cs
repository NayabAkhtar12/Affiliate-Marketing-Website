using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public class category : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
    }
}
