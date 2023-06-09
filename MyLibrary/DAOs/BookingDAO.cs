﻿using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Booking> GetBookingsShort()
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
        public IEnumerable<Booking> ManagerGetBookingsByHotelID(int hotelID)
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
                                      .OrderByDescending(b => b.BookingId).ToList();
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
                    list = db.Bookings.Include(b => b.User)
                                      .Include(b=>b.Room)
                                      .ThenInclude(b => b.RoomType)
                                      .Where(b => b.UserId == userID).ToList();
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

        public IEnumerable<RoomViewModel> ViewBookableRoom(int SelectedRoomTypeID, int HotelID, DateTime CheckIn, DateTime CheckOut)
        {
            IEnumerable<RoomViewModel> list = new List<RoomViewModel>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = (
                        from h in db.Hotels
                        join rt in db.RoomTypes on h.HotelId equals rt.HotelId
                        join r in db.Rooms on rt.RoomTypeId equals r.RoomTypeId
                        where !db.Bookings.Any(b => b.RoomId == r.RoomId &&
                                                    (b.Status.Equals("pending") || b.Status.Equals("confirmed")) &&
                                                    ((CheckIn >= b.CheckInDate && CheckIn <= b.CheckOutDate) ||
                                                        (CheckOut >= b.CheckInDate && CheckOut <= b.CheckOutDate)))
                                && rt.RoomTypeId == SelectedRoomTypeID
                                && rt.Status.Equals("active")
                                && h.Status.Equals("active")
                                && h.HotelId == HotelID
                        select new RoomViewModel
                        {
                            RoomID = r.RoomId,
                            Number = r.RoomNumber,
                        }).ToList().Distinct();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return list;
        }

        //Search Filter Here

        public IEnumerable<Booking> GetBookingDetailSearchName(string name)
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
                                      .Where(item => item.User.FirstName.ToLower().Contains(name.ToLower())
                                      || item.User.LastName.ToLower().Contains(name.ToLower()))
                                      .OrderBy(item => item.User.FirstName)
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public IEnumerable<Booking> GetBookingDetailSearchUserID(int userID)
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
                                      .Where(item => item.UserId == userID)
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public IEnumerable<Booking> GetBookingDetailSearchHotelRoom(string hotelroom)
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
                                      .Where(item => item.Room.RoomType.RoomTypeName.Contains(hotelroom))
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public IEnumerable<Booking> GetBookingDetailSearchHotelStatus(string bookingstatus)
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
                                      .Where(item => item.Status.ToLower().Contains(bookingstatus.ToLower()))
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public IEnumerable<Booking> GetBookingDetailSearchRole(string role)
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
                                      .Where(item => item.User.Role.ToLower().Contains(role.ToLower()))
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }


        public IEnumerable<Booking> GetBookingDetailPriceAscending()
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
                                      .OrderBy(item => item.TotalPrice)
                                      .ToList();


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public IEnumerable<Booking> GetBookingDetailPriceDescending()
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
                                      .OrderByDescending(b => b.TotalPrice)
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public IEnumerable<Booking> GetBookingDetailByStatus(string status)
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

        public IEnumerable<Booking> GetBookingDetailByRole()
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

        public IEnumerable<Booking> GetBookingDetailByRoomType()
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
    }
}
