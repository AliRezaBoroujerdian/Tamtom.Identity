using System;

namespace Tamtom.Identity.Authentication.Models
{
    public class LoginResultModel
    {
        public int Result { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public Guid? UserToken { get; set; }
        public Guid? SessionID { get; set; }
        public string FullName { get; set; }
        public string LanguageID { get; set; }
    }
}


