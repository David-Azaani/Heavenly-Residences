﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoomDTO> UpdateHotelRoom(int roomId,HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoomDTO> GetHotelRoom(int roomId, string checkInDateStr = null, string checkOutDatestr = null);
        public Task<int> DeleteHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoomDTO>>GetAllHotelRooms(string checkInDate = null, string checkOutDate = null);
        public Task<HotelRoomDTO> IsRoomUniq(string name,int roomId=0);
        public Task<bool> IsRoomBooked(int RoomId, string checkInDate, string checkOutDate);

    }
}