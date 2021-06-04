using Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Core.DataTest
{
    public class DbUsers
    {
        static List<User> users = fillUserTest();
        public static User Find(int id)
        {
            return users.SingleOrDefault(user => user.Id == id);
        }

        public static List<User> ToList()
        {
            return users;
        }

        static List<User> fillUserTest()
        {
            List<User> users = new List<User>();
            users.Add(new User(111111111, "Sebastian Rodirguez", 20, "2001-02-15"));
            users.Add(new User(222222222, "Camilo Alvarez", 23, "1998-04-10"));
            users.Add(new User(333333333, "Pedro Sabogal", 25, "1996-02-15"));
            users.Add(new User(444444444, "Andres Mujica", 24, "1996-09-05"));
            users.Add(new User(555555555, "Eduardo Torrado", 30, "1990-06-06"));
            users.Add(new User(666666666, "German Garcia", 41, "1980-02-30"));
            users.Add(new User(777777777, "Jeison Gaona", 28, "1992-11-25"));
            users.Add(new User(888888888, "David Medina", 52, "1968-10-18"));
            users.Add(new User(999999999, "Yesid Valencia", 35, "1985-08-22"));
            users.Add(new User(123456789, "Carlos Duarte", 62, "1959-04-02"));
            return users;
        }
    }
}
