﻿using System;
using System.ComponentModel;

namespace MeetAndGo.Model
{
    public partial class RentedOffice
    {
        [Browsable(false)]
        public int RentedOfficeId { get; set; }
        [Browsable(false)]
        public int OfficeId { get; set; }
        [Browsable(false)]
        public int UserId { get; set; }
        [Browsable(false)]
        public DateTime BeginRentalDate { get; set; }
        [Browsable(false)]
        public DateTime EndRentalDate { get; set; }
        [Browsable(false)]
        public bool Rented { get; set; }
        public string Office { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        [Browsable(false)]
        public int Days { get; set; }
        [Browsable(false)]
        public decimal OfficePrice { get; set; }
        [Browsable(false)]
        public decimal Price { get; set; }
        public string Adress { get; set; }
        public byte[] Picture { get; set; }
        //[Browsable(false)]
        //public virtual User User { get; set; }
        //[Browsable(false)]
        //public virtual Office Office { get; set; }
    }
}
