﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.services
{
    public class NullMailService : IMailService
    {
        public readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
         
        public void SendMessage(string to,string subject,string body)
        {
            //Log the message
            _logger.LogInformation($"To:{to} Subject:{subject} Body:{body}");
        }
       
    }
}
