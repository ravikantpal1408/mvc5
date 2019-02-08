using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foothill.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name="Date Of Birth")]
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribed { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }
    }

    public class MembershipType
    {

        public byte Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}