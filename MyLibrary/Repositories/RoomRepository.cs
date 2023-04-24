using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public void AddRoom(Room room) => RoomDAO.Instance.AddRoom(room);

        public void DeleteRoom(int id) => RoomDAO.Instance.RemoveRoomByID(id);

        public Room GetRoomByID(int id) => RoomDAO.Instance.GetRoomByID(id);

        public IEnumerable<Room> GetRooms() => RoomDAO.Instance.GetRooms();

        public IEnumerable<Room> GetRoomsByID(int id) => RoomDAO.Instance.GetRoomsByHotelID(id);    

        public void UpdateRoom(Room room) => RoomDAO.Instance.UpdateRoom(room);
    }
}
