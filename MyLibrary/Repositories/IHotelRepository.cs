using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> GetHotels();
        Hotel GetHotelById(int id);
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);

        IEnumerable<Hotel> SearchHotelByNameOrAddress(string search);
        public IEnumerable<HotelViewModel> GetHotelsBySearchParameters(string? search, DateTime checkIn, DateTime checkOut, int guest);

        public Hotel GetHotelsByManagerID(int managerID);

        public IEnumerable<Hotel> GetManagerWithNoJob();


    }
}
