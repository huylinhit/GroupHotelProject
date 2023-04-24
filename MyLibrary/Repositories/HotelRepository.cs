﻿using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        public void AddHotel(Hotel hotel) => HotelDAO.Instance.AddHotel(hotel);

        public void DeleteHotel(int id) => HotelDAO.Instance.RemoveHotelByID(id);

        public Hotel GetHotelById(int id) => HotelDAO.Instance.GetHotelByID(id);

        public IEnumerable<Hotel> GetHotels() => HotelDAO.Instance.GetHotels();

        public void UpdateHotel(Hotel hotel) => HotelDAO.Instance.UpdateHotel(hotel);
    }
}
