using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movies { get; set; }
        public List<Customer> Customer { get; set; }
    }
}