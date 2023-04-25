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
                    list = db.Bookings.Include(b => b.User)
                                      .Include(b => b.Room)
                                      .ThenInclude(room => room.RoomType)
                                      .ThenInclude(roomtype => roomtype.Hotel)
                                      .OrderByDescending(b => b.BookingId)
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        //for admin view
        public IEnumerable<Booking> GetBookingsByHotelID(int hotelID)
        {
            IEnumerable<Booking> list = new List<Booking>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings.Include(b => b.User)
                                      .Include(b => b.Room)
                                      .ThenInclude(room => room.RoomType)
                                      .ThenInclude(roomtype => roomtype.Hotel)
                                      .Where(b => b.Room.RoomType.HotelId == hotelID)
                                      .OrderByDescending(b => b.BookingId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        //for manager view
        public IEnumerable<Booking> GetBookingsByManagerID(int managerID)
        {
            IEnumerable<Booking> list = new List<Booking>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings.Include(b => b.User)
                                      .Include(b => b.Room)
                                      .ThenInclude(room => room.RoomType)
                                      .ThenInclude(roomtype => roomtype.Hotel)
                                      .Where(b => b.Room.RoomType.Hotel.ManagerId == managerID)
                                      .OrderByDescending(b => b.BookingId);
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

        public int GetNewBookingID()
        {
            return GetBookings().Count() + 1;
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
                    item.Status = "pending";
                    item.BookingId = GetNewBookingID();
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
                    item.Status = "removed";
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
                    item.Status = "removed";
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

        public void UpdateBookingStatusByBookingID(int id, string status)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    Booking item = GetBookingByID(id);
                    item.Status = status;
                    db.Entry<Booking>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Booking> GetBookingByBookingID(int BookingID)
        {
            IEnumerable<Booking> list = null;
            try{
                using (var db = new HotelProjectContext())
                {
                    list = db.Bookings
                        .Include(item => item.User)
                        .Include(item => item.Room)
                            .ThenInclude(item => item.RoomType)
                        .Where(item => item.BookingId == BookingID)
                        .ToList();
                }
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}
