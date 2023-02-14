using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public abstract class EntityBaseAuth<TIdentifier> : IEntity<TIdentifier>
    {
        public TIdentifier Id { get; set; }
    }
}
