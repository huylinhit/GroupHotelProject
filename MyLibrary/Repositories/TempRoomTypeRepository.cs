using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class TempRoomTypeRepository
    {
        public IEnumerable<RoomType> GetRoomTypes() => RoomTypeTypeDAO.Instance.GetRoomTypes();
        public RoomType? GetRoomTypeByID(int id) => RoomTypeTypeDAO.Instance.GetRoomTypeByID(id);
        public void AddRoomType(RoomType item) => RoomTypeTypeDAO.Instance.AddRoomType(item);
        public void RemoveRoomType(RoomType item) => RoomTypeTypeDAO.Instance.RemoveRoomType(item);
        public void RemoveRoomTypeByID(int id) => RoomTypeTypeDAO.Instance.RemoveRoomTypeByID(id);
        public void UpdateRoomType(RoomType item) => RoomTypeTypeDAO.Instance.UpdateRoomType(item);

    }
}
