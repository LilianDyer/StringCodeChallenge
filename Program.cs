using Newtonsoft.Json;
using StringCodeChallenge.Model;

var client = new HttpClient();
var response = await client.GetAsync("https://coderbyte.com/api/challenges/json/age-counting");
var data = await response.Content.ReadAsStringAsync();
var ageData = JsonConvert.DeserializeObject<AgeData>(data);

Console.WriteLine("using lambda: " + ageData?.GetCount());

Console.WriteLine("using regex: " + ageData?.GetCountUsingRegex());
