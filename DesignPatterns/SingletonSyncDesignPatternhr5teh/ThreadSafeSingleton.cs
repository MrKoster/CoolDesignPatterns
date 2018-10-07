using System;

namespace SingletonSyncDesignPattern
{

    /// <summary>
    /// This version of singleton is thread safe, meaning that it can be used by many threads at once
    /// without risk of creating instance of singleton multiple times (if many threads go inside if statement
    /// at the same time).
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// On top of standard instance reference, there is also locker object, used to well... locking threads.
        /// </summary>
        private static ThreadSafeSingleton _instance;
        private static readonly object locker = new object();

        /// <summary>
        /// Private constructor ensures that it's impossible to create new instance of singleton
        /// outside singleton class (just like in thread unsafe version).
        /// </summary>
        private ThreadSafeSingleton()
        { }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                // First if statment to prevent creating multiple instances
                if (_instance is null)
                {
                    // Lock to prevent multiple threads to enter further code at once
                    lock (locker)
                    {
                        // Again we have to check instance for null, since instance could
                        // have already been created by another thread, while this one were in progress
                        // of locking itself
                        if (_instance is null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }
                    }
                }          
                return _instance;
            }
        }

    }
}
