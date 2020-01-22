using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public interface IHaveAOwner
    {
        string OwnerId { get; set; }
    }
}
