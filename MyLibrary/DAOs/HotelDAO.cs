using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DAOs
{
    public class HotelDAO
    {
        private static HotelDAO instance;
        private static object instanceLock = new object();

        public static HotelDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HotelDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Hotel> GetHotels()
        {
            IEnumerable<Hotel> list = new List<Hotel>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Hotels.Where(item => item.Status.Equals("active")).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public IEnumerable<HotelViewModel> GetHotelsBySearchParameters(string? search, DateTime checkIn, DateTime checkOut, int guest)
        {
            IEnumerable<HotelViewModel> list = new List<HotelViewModel>();
            try
            {
                using( var db = new HotelProjectContext())
                {
                    list = (
                            from h in db.Hotels
                            join rt in db.RoomTypes on h.HotelId equals rt.HotelId
                            join r in db.Rooms on rt.RoomTypeId equals r.RoomTypeId
                            where !db.Bookings.Any(b => b.RoomId == r.RoomId &&
                                                        (b.Status.Equals("pending") || b.Status.Equals("confirmed")) &&
                                                        ((checkIn >= b.CheckInDate && checkIn <= b.CheckOutDate) ||
                                                            (checkOut >= b.CheckInDate && checkOut <= b.CheckOutDate)))
                                    && rt.Capacity >= guest
                                    && rt.Status.Equals("active")
                                    && h.Status.Equals("active")
                                    && (search == null || search.Trim().Equals(string.Empty) || h.Address.Contains(search))
                            select new HotelViewModel
                            {
                                HotelID = h.HotelId,
                                Name = h.HotelName,
                                Address = h.Address,
                                RoomTypeID = rt.RoomTypeId,
                                RoomTypeName = rt.RoomTypeName,
                                RoomDescription = rt.Description,
                                Price = rt.Price ?? 1,
                                BedCount = rt.BedCount ?? 1,
                                Capacity = rt.Capacity ?? 1,
                                Currency = h.Currency
                            }).Distinct().ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Hotel? GetHotelByID(int id)
        {
            Hotel? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.Hotels.SingleOrDefault(p => p.HotelId == id);
            }
            return i;
        }

/*        public IEnumerable<Hotel> GetHotelsByMemberID(int memberId)
        {
            IEnumerable<Hotel> Hotels = null;

            try
            {
                var context = new HotelProjectContext();
                if (memberId > 0)
                {
                    Hotels = context.Hotels.Where(or => or.HotelId == memberId)
                        .Include(or => or.Member)
                        .Include(or => or.HotelDetails);
                }
                else if (memberId <= 0)
                {
                    Hotels = context.Hotels.Include(or => or.Member)
                        .Include(or => or.HotelDetails);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Hotels;
        }*/

        public void AddHotel(Hotel item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "active";
                    db.Hotels.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveHotel(Hotel item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "inactive";
                    db.Entry<Hotel>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveHotelByID(int id)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var item = db.Hotels.SingleOrDefault(p => p.HotelId == id);
                    item.Status = "inactive";
                    db.Entry<Hotel>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateHotel(Hotel item)
        {
            try {
                using (var db = new HotelProjectContext())
                {
                    db.Entry<Hotel>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Hotel> SearchHotelByNameOrAddress(string search)
        {
            IEnumerable<Hotel> result = null;
            try
            {
                using(var db = new HotelProjectContext())
                {
                    result = db.Hotels.Where(
                        item => item.HotelName.ToLower().Contains(search.ToLower().Trim())
                     || item.Address.ToLower().Contains(search.ToLower().Trim())
                        ).ToList();
                }

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
