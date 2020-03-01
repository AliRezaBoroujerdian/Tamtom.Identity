using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamtom.Identity.Authentication.Models;
using static Tamtom.Database.Dapper.Generic;

namespace Tamtom.Identity.Authentication
{
    public class Authentication : IAuthentication
    {
        public async Task<LoginResultModel> Login(LoginModel model)
        {
            return await ExecuteStoredProcedureFirstOrDefaultAsync<LoginModel, LoginResultModel>("[Identity].APP_SP_LoginUser", model);
        }
    }
}
