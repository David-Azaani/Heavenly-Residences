﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Heavenly_Residences_Client.Service.IService;
using Models;
using Newtonsoft.Json;

namespace Heavenly_Residences_Client.Service
{
    public class HotelAmenityService : IHotelAmenityService
    {
        private readonly HttpClient _client;

        public HotelAmenityService(HttpClient client)
        {
            _client = client;
        }



        public async Task<IEnumerable<HotelAmenityDTO>> GetHotelAmenities()
        {
            var response = await _client.GetAsync($"api/hotelamenity");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelAmenityDTO>>(content);
            return rooms;
        }
    }
}
