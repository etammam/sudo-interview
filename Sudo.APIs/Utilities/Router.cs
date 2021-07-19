namespace Sudo.APIs.Utilities
{
    public static class Router
    {
        private const string Version = "v1";
        private const string Root = "apis";
        private const string Rule = Version + "/" + Root + "/";

        public static class Client
        {
            private const string Prefix = Rule + "clients/";
            public const string Create = Prefix + "create";
        }
    }
}
