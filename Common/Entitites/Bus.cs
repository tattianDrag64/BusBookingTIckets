using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entitites
{
    public class Bus : BaseEntity
    {
        public string BusName { get; set; }
        public string BusNumber { get; set; }
        public string SeatСapacity { get; set; }
    }
}
