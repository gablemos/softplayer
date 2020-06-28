﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowmeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "https://github.com/gablemos/softplayer";
        }
    }
}