using displayModal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace displayModal.crRecord
{
    public class Data
    {
        public static List<CSRData> crRecord => allcrRecord;

        static List<CSRData> allcrRecord = new List<CSRData>
        {
            new CSRData()
            {
               Id = "CR-1",
                Name="Emma",
                Email="xyz@aksj.com",
                PhoneNumber="097485754",
                Issue="6 issues found"

            },
             new CSRData()
            {
                 Id = "CR-2",
                Name="ALexandra",
                Email="xyz@aksj.com",
                PhoneNumber="097485754",
                Issue="1 issues found"
            },

              new CSRData()
            {  Id = "CR-3",
                Name="Billy",
                Email="xyz@aksj.com",
                PhoneNumber="097485754",
                Issue="10 issues found"

            },
        };
    }
}