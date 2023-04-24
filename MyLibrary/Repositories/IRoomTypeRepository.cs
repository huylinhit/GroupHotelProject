using MyLibrary.DAOs;
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
         RoomType? GetRoomTypeByID(int id);
         void AddRoomType(RoomType item);
         void RemoveRoomType(RoomType item);
         void RemoveRoomTypeByID(int id);
         void UpdateRoomType(RoomType item);
    }
}
