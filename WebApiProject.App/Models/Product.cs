﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.App.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockRemaining { get; set; }
    }
}