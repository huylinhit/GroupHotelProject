﻿using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public void AddBooking(Booking item) => BookingDAO.Instance.AddBooking(item);

        public Booking? GetBookingByID(int id) => BookingDAO.Instance.GetBookingByID(id);

        public IEnumerable<Booking> GetBookings() => BookingDAO.Instance.GetBookings();

        public IEnumerable<Booking> GetBookingsByHotelID(int hotelID) => BookingDAO.Instance.GetBookingsByHotelID(hotelID);
        public IEnumerable<Booking> ManagerGetBookingsByHotelID(int hotelID) => BookingDAO.Instance.ManagerGetBookingsByHotelID(hotelID);

        public IEnumerable<Booking> GetBookingsByManagerID(int managerID) => BookingDAO.Instance.GetBookingsByManagerID(managerID);

        public IEnumerable<Booking> GetBookingsByRoomID(int roomID) => BookingDAO.Instance.GetBookingsByRoomID(roomID);

        public IEnumerable<Booking> GetBookingsByUserID(int userID) => BookingDAO.Instance.GetBookingsByUserID(userID);

        public int GetNewBookingID() => BookingDAO.Instance.GetNewBookingID();

        public void RemoveBooking(Booking item) => BookingDAO.Instance.RemoveBooking(item);

        public void RemoveBookingByID(int id) => BookingDAO.Instance.RemoveBookingByID(id);

        public void UpdateBooking(Booking item) => BookingDAO.Instance.UpdateBooking(item);

        public void UpdateBookingStatusByBookingID(int id, string status) => BookingDAO.Instance.UpdateBookingStatusByBookingID(id, status);

        public IEnumerable<Booking> GetBookingByBookingID(int BookingID) => BookingDAO.Instance.GetBookingByBookingID(BookingID);
        public IEnumerable<RoomViewModel> ViewBookableRoom(int SelectedRoomTypeID, int HotelID, DateTime CheckIn, DateTime CheckOut) => BookingDAO.Instance.ViewBookableRoom(SelectedRoomTypeID, HotelID, CheckIn, CheckOut);

        public IEnumerable<Booking> GetBookingsShort() => BookingDAO.Instance.GetBookingsShort();

        public IEnumerable<Booking> GetBookingDetailSearchName(string name) => BookingDAO.Instance.GetBookingDetailSearchName(name);

        public IEnumerable<Booking> GetBookingDetailSearchUserID(int userID) => BookingDAO.Instance.GetBookingDetailSearchUserID(userID);

        public IEnumerable<Booking> GetBookingDetailSearchHotelRoom(string hotelroom) => BookingDAO.Instance.GetBookingDetailSearchHotelRoom(hotelroom);

        public IEnumerable<Booking> GetBookingDetailSearchHotelStatus(string bookingstatus) => BookingDAO.Instance.GetBookingDetailSearchHotelStatus(bookingstatus);

        public IEnumerable<Booking> GetBookingDetailSearchRole(string role) => BookingDAO.Instance.GetBookingDetailSearchRole(role);

        public IEnumerable<Booking> GetBookingDetailPriceAscending() => BookingDAO.Instance.GetBookingDetailPriceAscending();
        public IEnumerable<Booking> GetBookingDetailPriceDescending() => BookingDAO.Instance.GetBookingDetailPriceDescending();
    }
}
