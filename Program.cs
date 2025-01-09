// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using StringCodeChallenge.Model;

var client = new HttpClient();
var response = await client.GetAsync("https://coderbyte.com/api/challenges/json/age-counting");
var data = await response.Content.ReadAsStringAsync();
var ageData = JsonConvert.DeserializeObject<AgeData>(data);
Console.WriteLine(ageData?.GetCount());
