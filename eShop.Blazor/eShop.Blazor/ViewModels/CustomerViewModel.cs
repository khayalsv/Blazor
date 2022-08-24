using System.ComponentModel.DataAnnotations;

namespace eShop.Blazor.ViewModels
{
    public class CustomerViewModel
    {
        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerCity { get; set; }

        [Required]
        public string CustomerStateProvince { get; set; }

        [Required]
        public string CustomerCountry { get; set; }
    }
}


