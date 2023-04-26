using System;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
	public class RegistrationFormModel
	{
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public long PhoneNo { get; set; }

        public string Address { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        public RegistrationFormModel(
            string name,
            string email,
            long phoneNo,
            string address,
            string state,
            string city)
        {
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Address = address;
            State = state;
            City = city;
        }
    }
}

