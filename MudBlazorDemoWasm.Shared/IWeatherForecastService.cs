using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MudBlazorDemoWasm.Shared
{
    [ServiceContract]
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> ListForecastsAsync();
    }
}
