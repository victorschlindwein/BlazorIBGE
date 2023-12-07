namespace BlazorIBGE
{
    public static class Configuration
    {
        public static string GetApiIbgeCities { get; set; } = "https://localhost:7267/ibge/GetByCity";
        public static string GetApiIbgeState { get; set; } = "https://localhost:7267/ibge/GetByState";
        public static string GetApiIbgeId { get; set; } = "https://localhost:7267/ibge/GetById";
        public static string PostNewCity { get; set; } = "https://localhost:7267/ibge/create";
    }
}
