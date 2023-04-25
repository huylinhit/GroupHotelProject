using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetRooms();
        public IEnumerable<Room> GetRoomsByRoomTypeID(int roomTypeID);
        IEnumerable<Room> GetRoomsByID(int id);
        Room GetRoomByID(int id);
        void AddRoom(Room room);
        void UpdateRoom(Room room);
        void DeleteRoom(int id);
    }
}
