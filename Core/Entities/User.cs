using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDay { get; set; }

        public User(int id, string name, int edad, string birthDay)
        {
            Id = id;
            Name = name;
            Age = edad;
            BirthDay = birthDay;
        }
    }
}
