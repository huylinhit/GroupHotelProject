using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DAOs
{
    public class RoomTypeTypeDAO
    {
        private static RoomTypeTypeDAO instance;
        private static object instanceLock = new object();

        public static RoomTypeTypeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomTypeTypeDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<RoomType> GetRoomTypes()
        {
            IEnumerable<RoomType> list = new List<RoomType>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.RoomTypes.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public RoomType? GetRoomTypeByID(int id)
        {
            RoomType? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.RoomTypes.SingleOrDefault(p => p.RoomTypeId == id);
            }
            return i;
        }
        public RoomType? GetRoomTypeByName(string name)
        {
            RoomType? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.RoomTypes.SingleOrDefault(p => p.RoomTypeName.Equals(name));
            }
            return i;
        }
        public void AddRoomType(RoomType item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "active";
                    db.RoomTypes.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveRoomType(RoomType item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "inactive";
                    db.Entry<RoomType>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveRoomTypeByID(int id)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var item = db.RoomTypes.SingleOrDefault(p => p.RoomTypeId == id);
                    item.Status = "inactive";
                    db.Entry<RoomType>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRoomType(RoomType item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    db.Entry<RoomType>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
