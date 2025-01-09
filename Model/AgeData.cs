using System.Text.RegularExpressions;

namespace StringCodeChallenge.Model
{
    public class AgeData
    {
        public required string Data { get; set; }

        private int Count()
        {
            var dataArr = Data.Split(',');
            var ages = dataArr.ToList().FindAll(x => x.Contains("age="));
            var agesInt = ages.Select(x => int.Parse(x.Split('=')[1])).ToList();
            int count = agesInt.Count(x => x >= 50);
     
            return count;
        }

        private int CountUsingRegex()
        {
            var count = Regex.Matches(Data, "age=[5-9][0-9]").Count;
            return count;
        }

        public int Count(string data)
        {
            Data = data;
            return Count();
        }

        public int GetCount() {
            return Count();
        }

        public int GetCountUsingRegex()
        {
            return CountUsingRegex();
        }

    }
}
