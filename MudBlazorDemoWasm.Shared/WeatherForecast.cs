﻿using System;
using System.Runtime.Serialization;

namespace MudBlazorDemoWasm.Shared
{
    [DataContract]
    public class WeatherForecast
    {
        [DataMember(Order = 1)]
        public DateTime Date { get; set; }

        [DataMember(Order = 2)]
        public int TemperatureC { get; set; }

        [DataMember(Order = 3)]
        public string Summary { get; set; }

        [DataMember(Order = 4)]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
