using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Room
    {
        public int Id { get; set; }

        public List<Table> Tables { get; set; }

        public Guid TableId { get; set; }

        public Guid ChairId { get; set; }

        public List<Guest> AvailableGuest { get; set; }

        public int SelectedGuestId { get; set; }
    }
}
