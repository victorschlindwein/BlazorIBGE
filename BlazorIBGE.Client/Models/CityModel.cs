using System.ComponentModel.DataAnnotations;

namespace BlazorIBGE.Client.Models
{
    public class CityModel
    {
        public CityModel()
        {

        }

        public CityModel(int id, string city, string state)
        {
            Id = id;
            City = city;
            State = state;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome da cidade")]
        [Length(3, 60, ErrorMessage = "A cidade deve ter entre 3 e 60 caracteres")]
        public string City { get; set; }

        [Required(ErrorMessage = "Informe o nome do estado")]
        [Length(2, 2, ErrorMessage = "O estado deve ter exatamente 2 caracteres")]
        public string State { get; set; }
    }
}
