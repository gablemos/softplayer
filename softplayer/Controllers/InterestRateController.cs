﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using softplayer.Modules.Juro.Models;
using softplayer.Modules.Juro.Services;

namespace softplayer.Controllers
{
    [Route("api/v1/taxajuros")]
    [ApiController]
    [Produces("application/json")]
    public class InterestRateController : ControllerBase
    {
        ShowInterestRateService InterestRateService = new ShowInterestRateService();
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            await Task.Delay(1);

            InterestRateDTO interestRate = InterestRateService.Execute();

            return Ok(interestRate);
        }
    }
}
