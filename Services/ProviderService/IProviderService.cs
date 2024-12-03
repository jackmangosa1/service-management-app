﻿using ServiceManagementAPI.Dtos;
using ServiceManagementAPI.Enums;

namespace ServiceManagementAPI.Services.ProviderService
{
    public interface IProviderService
    {
        Task<ProviderProfileDto?> GetProviderProfileAsync(string providerId);
        Task<bool> UpdateProviderProfileAsync(int providerId, UpdateProviderProfileDto updateProviderProfileDto, Stream imageStream = null!);
        Task<bool> AddServiceAsync(string providerId, AddServiceDto addServiceDto, Stream imageStream = null!);
        Task<bool> UpdateBookingStatusAsync(int bookingId, BookingStatus bookingStatus);
    }
}
