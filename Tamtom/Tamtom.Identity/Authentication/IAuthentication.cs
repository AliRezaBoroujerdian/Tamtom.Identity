using System.Threading.Tasks;
using Tamtom.Identity.Authentication.Models;

namespace Tamtom.Identity.Authentication
{
    public interface IAuthentication
    {
        Task<LoginResultModel> Login(LoginModel model);
    }
}
