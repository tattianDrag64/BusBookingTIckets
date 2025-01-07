using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entitites
{
    public class SeatDetail : BaseEntity
    {
        public int SeatNo { get; set; }
        public string Description { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }


    }
}
