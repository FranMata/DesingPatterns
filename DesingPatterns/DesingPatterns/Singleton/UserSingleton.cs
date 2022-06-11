namespace DesingPatterns.Singleton
{
    public sealed class UserSingleton
    {
        public string GetUserName { get => "Nicolas"; }

        private static UserSingleton _userSingleton;
        private UserSingleton() { }

        public static UserSingleton GetInstance()
        {
            if (_userSingleton == null)
                _userSingleton = new UserSingleton();
            return _userSingleton;
        }
    }
}