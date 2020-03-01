using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tamtom.Identity.Authentication.Google
{
    public class ReCaptcha3
    {
        public static string SecretKey { get; private set; }

        /// <summary>
        /// set secret key
        /// </summary>
        /// <param name="secretKey">secret key for communication between your site and reCAPTCHA</param>
        public static void Initialize(string secretkey)
        {
            SecretKey = secretkey;
        }

        public static async Task<GoogleRecaptcha3VerifyResponseModel> VerifyGoogleToken(string googleToken)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "https://www.google.com/recaptcha/api/siteverify",
                     new StringContent($"secret={SecretKey}&response={googleToken}", Encoding.UTF8, "application/x-www-form-urlencoded"));

                string stringResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<GoogleRecaptcha3VerifyResponseModel>(stringResponse);
            }
        }
    }
}

