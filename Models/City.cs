using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProvinceCity.Models
{
    public class City {
     public int CityId { get; set; }

     [Display (Name ="City")]
     public string CityName { get; set; }
     public int Population { get; set; }

     // this is the foreign key
     [Display (Name ="Province Code")]
     public string ProvinceCode { get; set; }
     public Province Province {get; set;}

     public static List<City> GetCities() {
            List<City> cities = new List<City> {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 3000,
                    ProvinceCode = "BC"
                },
                new City {
                    CityId = 2,
                    CityName = "Coquitlam",
                    Population = 2000,
                    ProvinceCode = "BC"
                },
                 new City {
                    CityId = 3,
                    CityName = "Richmond",
                    Population = 100,
                    ProvinceCode = "BC"
                },
                new City {
                    CityId = 4,
                    CityName = "Toronto",
                    Population = 12334,
                    ProvinceCode = "ON"
                },
                new City {
                    CityId = 5,
                    CityName = "Ajax",
                    Population = 100,
                    ProvinceCode = "ON"
                },
                new City {
                    CityId = 6,
                    CityName = "Windsor",
                    Population = 100,
                    ProvinceCode = "ON"
                },
                  new City {
                    CityId = 7,
                    CityName = "Gatineau",
                    Population = 1344,
                    ProvinceCode = "QC"
                },
                new City {
                    CityId = 8,
                    CityName = "Quebec City",
                    Population = 3256,
                    ProvinceCode = "QC"
                },
                new City {
                    CityId = 9,
                    CityName = "Montreal",
                    Population = 45029,
                    ProvinceCode = "QC"
                },
            };
            return cities;
    }
    
    }
}