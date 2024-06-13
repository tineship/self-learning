using System.ComponentModel.DataAnnotations;

namespace TodoApi;

public class WeatherForecastRequest
{
    [Required]
    [Base64String]
    public string Location { get; set; }
    [Range(1, 100, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public int NumberOfDays { get; set; }
    [AllowedValues("Celsius", "Fahrenheit")]
    public string Units { get; set; }
}