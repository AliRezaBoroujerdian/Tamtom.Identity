using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.Identity.Authentication.Google
{
    public class GoogleRecaptcha3VerifyResponseModel
    {
        public bool success { get; set; }
        public double score { get; set; }
        public string action { get; set; }
        public DateTime challenge_ts { get; set; }
        public string hostname { get; set; }
        public List<string> error_codes { get; set; }
    }
}
