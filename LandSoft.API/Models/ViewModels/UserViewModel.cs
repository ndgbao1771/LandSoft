using LandSoft.Data.Enums;

namespace LandSoft.API.Models.ViewModels
{
    public class UserViewModel
    {
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public Status Status { get; set; }
    }
}
