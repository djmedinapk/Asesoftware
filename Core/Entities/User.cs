using System.ComponentModel.DataAnnotations;

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
