﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class TrustDistrictDto
    {
        public int TrustDistricId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TrustRegionId { get; set; }
    }
}
