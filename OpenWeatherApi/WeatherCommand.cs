using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;


namespace OpenWeatherApi
{
    class WeatherCommand
    {

		private string connectionString;

        public WeatherCommand(string connectionString)
        {
			this.connectionString = connectionString;
        }

        public List<Weather> GetWeathers()
		{
			OpenWeatherApiConnection conn = new OpenWeatherApiConnection(connectionString);

            using (conn)
			{
				conn.open();
				OpenWeatherApiCommand command = conn.CreateCommand();
				OpenWeatherApiReader reader = cmd.ExecuteReader();
			}
		}
    }
}
