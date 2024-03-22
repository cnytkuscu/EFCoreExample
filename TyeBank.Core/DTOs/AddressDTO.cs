﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyeBank.Core.DTOs
{
    public class AddressDTO : BaseDTO
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string NeighborHood { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

    }
}
