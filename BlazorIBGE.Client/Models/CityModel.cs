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
        public string City { get; set; }
        public string State { get; set; }
    }
}
