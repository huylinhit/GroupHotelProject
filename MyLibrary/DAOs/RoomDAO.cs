using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DAOs
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        private static object instanceLock = new object();

        public static RoomDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Room> GetRoomsByHotelID(int id)
        {
            IEnumerable<Room> list = new List<Room>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Rooms.
                        Include(r => r.RoomType).
                        ThenInclude(roomtype => roomtype.Hotel).
                        Where(room => room.RoomType.HotelId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public IEnumerable<Room> GetRooms()
        {
            IEnumerable<Room> list = new List<Room>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Rooms.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Room? GetRoomByID(int id)
        {
            Room? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.Rooms.SingleOrDefault(p => p.RoomId == id);
            }
            return i;
        }

        public void AddRoom(Room item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "active";
                    db.Rooms.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveRoom(Room item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "inactive";
                    db.Entry<Room>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveRoomByID(int id)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var item = db.Rooms.SingleOrDefault(p => p.RoomId == id);
                    item.Status = "inactive";
                    db.Entry<Room>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRoom(Room item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    db.Entry<Room>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
