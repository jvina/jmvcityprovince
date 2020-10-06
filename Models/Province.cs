using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProvinceCity.Models
{
    public class Province {
        [Key]
        [Display (Name ="Province Code")]
        public string ProvinceCode { get; set; }
        
        [Display (Name ="Province Name")]
        public string ProvinceName { get; set; }

        // This is the one to many relationship
        public List<City> Cities { get; set; }

        public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>
        {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
             new Province() {
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },
        };
            return provinces;
        }
    }
}