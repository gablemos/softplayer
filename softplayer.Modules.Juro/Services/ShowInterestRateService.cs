﻿using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Services
{
    public class ShowInterestRateService
    {
        public InterestRateDTO Execute() => new InterestRateDTO { value = 0.01 };
    }
}
