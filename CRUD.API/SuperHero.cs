using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.API
{
    public class SuperHero
    {
        public int Id { get; set; }
        public String Name { get; set; } = string.Empty;
        public String FirstName { get; set; } = string.Empty;
        public String LastName { get; set; } = string.Empty;
        public String Place { get; set; } = string.Empty;

    }
}