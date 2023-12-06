namespace BlazorIBGE
{
    public static class Configuration
    {
        public static string ApiIbgeCities { get; set; } = "https://localhost:7267/ibge/GetByCity";
        public static string ApiIbgeState { get; set; } = "https://localhost:7267/ibge/GetByState";
        public static string ApiIbgeId { get; set; } = "https://localhost:7267/ibge/GetById";
    }
}
