﻿using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public interface IRoomTypeRepository
    {
        IEnumerable<RoomType> GetRoomTypes();
        public IEnumerable<RoomType> GetRoomTypesByHotelID(int hotelID);
        RoomType? GetRoomTypeByID(int id);
        RoomType? GetRoomTypeByName(string name, int hotelID);
        void AddRoomType(RoomType item);
        void RemoveRoomType(RoomType item);
        void RemoveRoomTypeByID(int id);
        void UpdateRoomType(RoomType item);
        void DeleteRoomType(int id);
    }
}
