﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    internal class ViewCbb
    {
        public string IdDayTro { get; set; }
        public string TenDayTro { get; set; }
        public override string ToString()
        {
            return TenDayTro;
        }
    }
}
