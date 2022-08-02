using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displayModal.Models
{
    internal interface ICustomerReq
    {
        Task GetListAsync();

       CSRData GetCRDataById(string id);
    }
}
