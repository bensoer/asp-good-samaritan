﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralSourceModel
    {
        public string ReferralSource { get; set; }

        public ClientModel Client { get; set; }
    }
}