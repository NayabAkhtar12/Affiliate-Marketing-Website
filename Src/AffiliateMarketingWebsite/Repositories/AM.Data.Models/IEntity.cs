using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public interface IEntity
    {
    }

    public interface IEntity<TIdentifier> : IEntity
    {
        TIdentifier Id { get; set; }
    }
}
