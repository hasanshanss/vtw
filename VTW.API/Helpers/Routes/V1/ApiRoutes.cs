namespace VTW.API.Helpers.Routes.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Games
        {
            public const string Base = "games";
            public const string GetAll = ApiRoutes.Base + "/" + Base;
            public const string Create = ApiRoutes.Base + "/create";
        }

        public static class TeamCategory
        {
            public const string Base = ApiRoutes.Base + "/teamCategories";
            public const string Get =  Base + "/{id}";
            public const string GetAll = Base;
            public const string Create = Base + "/create";
            public const string Update = Base + "/update";
            public const string Delete = Base + "/delete";
        }
        public static class Team
        {
            public const string Base = ApiRoutes.Base + "/teams";
            public const string Get =  Base + "/{id}";
            public const string GetAll = Base;
            public const string Create = Base + "/create";
            public const string Update = Base + "/update";
            public const string Delete = Base + "/delete";
        }

    }
}
