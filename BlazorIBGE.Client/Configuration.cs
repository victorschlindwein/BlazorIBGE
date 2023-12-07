namespace BlazorIBGE
{
    public static class Configuration
    {
        public static string GetApiIbgeCities { get; set; } = "https://localhost:7267/ibge/GetByCity";
        public static string GetApiIbgeState { get; set; } = "https://localhost:7267/ibge/GetByState";
        public static string GetApiIbgeId { get; set; } = "https://localhost:7267/ibge/GetById";
        public static string PostNewCity { get; set; } = "https://localhost:7267/ibge/create";

        public static string TempApiAcessToken { get; set; } =
            "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InVzZXJAZXhhbXBsZS5jb20iLCJuYmYiOjE3MDE5NzQ3MTMsImV4cCI6MTcwMjAxNzkxMywiaWF0IjoxNzAxOTc0NzEzfQ.4R0PWQdqNjiNddeA5N1zjX9EtQG_ufvdG9In4CwLHFw";
    }
}
