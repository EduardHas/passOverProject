using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStatusApi.DAL;

namespace WeatherStatusApi.Entities
{
    public class Request
    {
        public async static void GetCity(string cityName)
        {
            
            APICityRequest r = new APICityRequest();
            var p = await r.GetCityData(cityName);

        }
    }
}
