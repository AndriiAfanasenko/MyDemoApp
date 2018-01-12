using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFIct.Core.Services
{
    public interface ISigninService
    {
        Task<bool> SigninAsync(string email);
    }
}
