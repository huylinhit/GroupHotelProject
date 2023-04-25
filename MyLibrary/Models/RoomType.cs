using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int? Capacity { get; set; }
        public int? BedCount { get; set; }
        public decimal? Price { get; set; }
        public int? HotelId { get; set; }
        public string Status { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
