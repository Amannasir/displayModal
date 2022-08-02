using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using displayModal.crRecord;

namespace displayModal.Models
{
    public class impCutomerReq : ICustomerReq
    {
        public async Task GetListAsync()
        {
            //var CRRecord = new List<CSRData>() {
            //    new CSRData(){ Id = "CR-1", Name="Bill",Email="xyz@aksj.com",PhoneNumber="097485754",Issue="10 issues found"},
            //    new CSRData(){ Id = "CR-2", Name="Steve",Email="xyz@aksj.com",PhoneNumber="097485754",Issue="10 issues found"},
            //    new CSRData(){ Id = "CR-3", Name="Ram",Email="xyz@aksj.com",PhoneNumber="097485754",Issue="10 issues found"},
            //    new CSRData(){ Id = "CR-4", Name="Abdul",Email="xyz@aksj.com",PhoneNumber="097485754",Issue="10 issues found"}
            //};
        }
        public CSRData GetCRDataById(string id)
        {

            return crRecord.Data.crRecord.FirstOrDefault(n => n.Id == id);
        }

        public CSRData GetRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public CSRData GetRecordById(string id)
        {
            throw new NotImplementedException();
        }
    }
}