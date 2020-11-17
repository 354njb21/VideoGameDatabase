﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDatabase.Models
{
    public class Company
    {
        public int CompanyId { get; }

        public string Name { get; }

        public Company(int companyId, string name)
        {
            CompanyId = companyId;
            Name = name;
        }
    }
}
