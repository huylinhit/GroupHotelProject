using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class HotelViewModel
    {
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomDescription { get; set; }
        public int BedCount { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }

    }
}
