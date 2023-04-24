using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DAOs
{
    public class BookingDAO
    {
        private static BookingDAO instance;
        private static object instanceLock = new object();

        public static BookingDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Booking> GetBookings()
        {
            IEnumerable<Booking> list = new List<Booking>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Booking? GetBookingByID(int id)
        {
            Booking? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.Bookings.SingleOrDefault(p => p.BookingId == id);
            }
            return i;
        }

        //for user booking history
        public IEnumerable<Booking> GetBookingsByUserID(int userID)
        {
            IEnumerable<Booking> list = new List<Booking>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings.Where(b => b.UserId == userID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public IEnumerable<Booking> GetBookingsByRoomID(int roomID)
        {
            IEnumerable<Booking> list = new List<Booking>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings.Where(b => b.RoomId == roomID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public void AddBooking(Booking item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "active";
                    db.Bookings.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveBooking(Booking item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    item.Status = "inactive";
                    db.Entry<Booking>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveBookingByID(int id)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var item = db.Bookings.SingleOrDefault(p => p.BookingId == id);
                    item.Status = "inactive";
                    db.Entry<Booking>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateBooking(Booking item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    db.Entry<Booking>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
