using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcKoll.Models
{
    public class AddressBookPost
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Added { get; set; }
        public DateTime Changed { get; set; }
    }
}