﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consuming_Microservice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}