using System.ComponentModel.DataAnnotations;

namespace ClassDemo.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int ApplicantId { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool IsMailing { get; set; }

        public virtual CustomerInfo Customer { get; set; }
    }
}