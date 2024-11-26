namespace Sownloader.Api;

public static class ApiEndpoints
{
    private const string ApiBase = "api";

    public static class Performances
    {
        private const string Base = $"{ApiBase}/performances";

        public const string Get = $"{Base}/{{performance_key}}";
    }
}
