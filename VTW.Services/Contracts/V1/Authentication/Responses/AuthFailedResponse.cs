﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.Authentication.Responses
{
    public class AuthFailedReponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
