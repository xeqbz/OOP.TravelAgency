﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelAgencyApp.Models
{
    public class User : Entity
    {
        public string Email;
        public double Balance;
        public List<string> ReservationBook;

        public User(string email, string id)
        {
            Id = id;
            Email = email;
            ReservationBook = new List<string>();
            Balance = 0.0;
        }

        public User()
        {
            ReservationBook = new List<string>();
            Balance = 0.0;
        }

        public void AddTourToBook(Tour tour)
        {
            ReservationBook.Add(tour.Id);
        }

        public void RemoveTourFromBook(Tour tour)
        {
            ReservationBook.Remove(tour.Id);
        }
    }
}
