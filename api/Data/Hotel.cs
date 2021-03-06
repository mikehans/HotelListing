using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}