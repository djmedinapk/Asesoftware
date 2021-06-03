using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            users.Add(new User(111111111, "Sebastian Rodirguez", 20, "15-02-2001"));
            users.Add(new User(222222222, "Camilo Alvarez", 23, "10-04-1998"));
            users.Add(new User(333333333, "Pedro Sabogal", 25, "15-02-1996"));
            users.Add(new User(444444444, "Andres Mujica", 24, "14-09-1996"));
            users.Add(new User(555555555, "Eduardo Torrado", 30, "06-06-1990"));
            users.Add(new User(666666666, "German Garcia", 41, "30-01-1980"));
            users.Add(new User(777777777, "Jeison Gaona", 28, "25-11-1992"));
            users.Add(new User(888888888, "David Medina", 52, "18-10-1968"));
            users.Add(new User(999999999, "Yesid Valencia", 35, "22-08-1985"));
            users.Add(new User(123456789, "Carlos Duarte", 62, "25-04-1959"));
            return users;
        }
    }
}
