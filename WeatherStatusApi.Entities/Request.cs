using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStatusApi.DAL;
using System.IO;
using WeatherStatusApi.Model;

namespace WeatherStatusApi.Entities
{
    public class Request
    {
        public async static Task<float> GetCity(string cityName)
        {
            
            APICityRequest r = new APICityRequest();
            var cityData = await r.GetCityData(cityName);
           // cityData = System.Text.Json.JsonSerializer.Serialize(cityData);

            WeatherCallResult cityDataObj = System.Text.Json.JsonSerializer.Deserialize<WeatherCallResult>(cityData);




            //string cityDictionary = System.IO.File.ReadAllText("serializֹ_edi.txt");
            //cityDictionary = System.Text.Json.JsonSerializer.Serialize(cityDictionary);

            //cityDictionary[cityName] = cityData;


            System.IO.File.WriteAllText(@cityName+".txt", cityData);

            float cityTemp = cityDataObj.current.temp_c;
            return cityTemp;


        }
        public  static float GetCityTempFromFile(string cityName)
        {

            string cityData = System.IO.File.ReadAllText(@cityName + ".txt");
            WeatherCallResult cityDataObj = System.Text.Json.JsonSerializer.Deserialize<WeatherCallResult>(cityData);




            float cityTemp = cityDataObj.current.temp_c;
            return cityTemp;
        }
    }
}
