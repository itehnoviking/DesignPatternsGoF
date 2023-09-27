namespace Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance;

        protected Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }
    }
}