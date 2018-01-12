using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFIct.Core.Services
{
    internal class SigninService : ISigninService
    {
        public async Task<bool> SigninAsync(string email)
        {
            // simulate network access
            await Task.Delay(TimeSpan.FromSeconds(3));
            return true;
        }

        public void Signout()
        {
        }
    }
}
