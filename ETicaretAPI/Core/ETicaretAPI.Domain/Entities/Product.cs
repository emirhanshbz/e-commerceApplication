﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
