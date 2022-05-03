using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class UsersListingViewModel
    {
        public List<User> Users { get; set; }
        public string SearchTerm { get; set; }
    }

    public class UsersActionViewModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
    }
}