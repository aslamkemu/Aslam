using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aslam.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public byte Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NUmberInStock { get; set; }

    }
}