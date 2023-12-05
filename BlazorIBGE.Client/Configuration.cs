namespace BlazorIBGE
{
    public static class Configuration
    {
        public static string ApiUrl { get; set; } = "http://localhost:5095";
        public static string ApiIbgeCities { get; set; } = "http://localhost:5071/ibge/GetByCity";
        public static string ApiIbgeState { get; set; } = "http://localhost:5071/ibge/GetByState";
    }
}
