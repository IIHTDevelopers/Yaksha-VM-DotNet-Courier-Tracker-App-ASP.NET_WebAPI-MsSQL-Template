﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourierTrackerApp.Models
{
    public class Courier
    {
        [Key]
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Destination { get; set; }
    }
}