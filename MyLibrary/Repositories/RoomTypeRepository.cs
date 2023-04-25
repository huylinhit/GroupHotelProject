using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class RoomTypeRepository:IRoomTypeRepository
    {
        public IEnumerable<RoomType> GetRoomTypes() => RoomTypeTypeDAO.Instance.GetRoomTypes();
        public IEnumerable<RoomType> GetRoomTypesByHotelID(int hotelID) => RoomTypeTypeDAO.Instance.GetRoomTypesByHotelID(hotelID);
        public RoomType? GetRoomTypeByID(int id) => RoomTypeTypeDAO.Instance.GetRoomTypeByID(id);
        public RoomType? GetRoomTypeByName(string name, int hotelID) => RoomTypeTypeDAO.Instance.GetRoomTypeByName(name, hotelID);
        public void AddRoomType(RoomType item) => RoomTypeTypeDAO.Instance.AddRoomType(item);
        public void RemoveRoomType(RoomType item) => RoomTypeTypeDAO.Instance.RemoveRoomType(item);
        public void RemoveRoomTypeByID(int id) => RoomTypeTypeDAO.Instance.RemoveRoomTypeByID(id);
        public void UpdateRoomType(RoomType item) => RoomTypeTypeDAO.Instance.UpdateRoomType(item);
        public void DeleteRoomType(int id) => RoomTypeTypeDAO.Instance.DeleteRoomType(id);
    }
}
