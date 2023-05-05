namespace ScriptableObjectArchitecture
{
    public static class SOArchitecture_Utility
    {
        public const int ASSET_MENU_ORDER_VARIABLES = 121;
        public const int ASSET_MENU_ORDER_EVENTS = 122;
        public const int ASSET_MENU_ORDER_COLLECTIONS = 123;

        public const string CUSTOM = "Custom/";

        public const string VARIABLE_SUBMENU = "Variables/";
        private const string COLLECTION_SUBMENU = "Collections/";
        public const string GAME_EVENT = "Game Events/";

        public const string GENERIC_GAME_EVENT = GAME_EVENT + "Generic/";

        public const string ADVANCED_GAME_EVENT = GAME_EVENT + "Advanced/";
        public const string ADVANCED_VARIABLE_SUBMENU = VARIABLE_SUBMENU + "Advanced/";

        public const string ADVANCED_LIST_SUBMENU = COLLECTION_LIST + "Advanced/";
        public const string ADVANCED_ARRAY_SUBMENU = COLLECTION_ARRAY + "Advanced/";
        public const string ADVANCED_ARRAY2D_SUBMENU = COLLECTION_ARRAY2D + "Advanced/";

        public const string COLLECTION_LIST = COLLECTION_SUBMENU + "List/";
        public const string COLLECTION_ARRAY = COLLECTION_SUBMENU + "Array/";
        public const string COLLECTION_ARRAY2D = COLLECTION_SUBMENU + "Array2D/";

        public const string COLLECTION_ARRAY3D = COLLECTION_SUBMENU + "Array3D/";

        // Add Component Menus
        public const string ADD_COMPONENT_ROOT_MENU = "SO Architecture/";
        public const string EVENT_LISTENER_SUBMENU = ADD_COMPONENT_ROOT_MENU + "Event Listeners/";
    }
}