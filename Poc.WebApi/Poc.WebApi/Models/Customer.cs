﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poc.WebApi.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
