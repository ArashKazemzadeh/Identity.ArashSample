﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Bugeto.Models.Entities
{
    public class Role: IdentityRole
    {
        public string Description { get; set; }
    }
}
