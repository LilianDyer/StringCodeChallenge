using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCodeChallenge.Model
{
    public class AgeData
    {
        public required string Data { get; set; }

        public int Count()
        {
            var dataArr = Data.Split(',');
            var ages = dataArr.ToList().FindAll(x => x.Contains("age="));
            var agesInt = ages.Select(x => int.Parse(x.Split('=')[1])).ToList();
            int count = agesInt.Count(x => x >= 50);
     
            return count;
        }

        public int GetCount() {
            return Count();
        }

    }
}
