using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Foothill.Models;
namespace Foothill.ViewModels
{
    public class RandomMovieViewModels
    {
        public Cinema Movies{ get; set; }
        public List<Customer> Customers { get; set; }
    }
}