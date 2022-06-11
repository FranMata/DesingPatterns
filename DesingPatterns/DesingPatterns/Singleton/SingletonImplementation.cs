using System;

namespace DesingPatterns.Singleton
{
    class SingletonImplementation
    {
        public void Implementation()
        {
            UserSingleton firstInstance = UserSingleton.GetInstance();
            UserSingleton secondInstance = UserSingleton.GetInstance();

            Console.WriteLine("First instance user name value: {0}\n" +
                "Second instance user name value: {1}\n" +
                "Are they equals?: {2}",
                firstInstance.GetUserName,
                secondInstance.GetUserName,
                firstInstance.Equals(secondInstance));
        }    
    }
}
