namespace BlazorIBGE
{
    public static class RoutesConfiguration
    {
        public static string GetApiIbgeCities { get; set; } = "https://localhost:7277/ibge/GetByCity";
        public static string GetApiIbgeState { get; set; } = "https://localhost:7277/ibge/GetByState";
        public static string GetApiIbgeId { get; set; } = "https://localhost:7277/ibge/GetById";
        public static string PostNewCity { get; set; } = "https://localhost:7277/ibge/create";
    }
}
