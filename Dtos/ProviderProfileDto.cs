﻿namespace ServiceManagementAPI.Dtos
{
    public class ProviderProfileDto
    {
        public int Id { get; set; }
        public string? DisplayName { get; set; }
        public string? Bio { get; set; }
        public string? Skills { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? UserName { get; set; } // From AspNetUser
        public string? Email { get; set; }    // From AspNetUser
    }
}