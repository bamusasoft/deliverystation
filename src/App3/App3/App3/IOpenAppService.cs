using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public interface IOpenAppService
    {
        Task<bool> Launch(string uri);
    }
}
