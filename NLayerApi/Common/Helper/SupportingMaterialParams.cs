﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class SupportingMaterialParams:PaginationParams
    {
        public string? OrderBy { get; set; }
        public bool InActive { get; set; }
    }
}
