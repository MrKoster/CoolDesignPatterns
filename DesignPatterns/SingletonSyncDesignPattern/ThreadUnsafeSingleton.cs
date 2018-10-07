using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSyncDesignPattern
{

    /// <summary>
    /// Singleton class.
    /// In this pattern we want to have only one instance of given class (singleton class),
    /// and be sure that it will never change in runtime.
    /// 
    /// Please note that this version is not suited for multitherading,
    /// for more appropriate version, check out "ThreadSafeSingleton".
    /// 
    /// So basically, never use this ;-)
    /// </summary>
    public class ThreadUnsafeSingleton
    {
        /// <summary>
        ///  Instance field is exacly what it seems like, it's a field
        ///  that represents class instance. It's private so that it can't be accesed directly.
        /// </summary>
        private static ThreadUnsafeSingleton _instance;

        /// <summary>
        /// Private constructor ensures that it's impossible to create new instance of singleton
        /// outside singleton class.
        /// </summary>
        private ThreadUnsafeSingleton()
        { }

        /// <summary>
        /// This is method that will be used to get singleton instance.
        /// It checks if instance (Instance field) of singleton exists,
        /// if yes, it is returned, if no, new Instance is created, and returned.
        /// </summary>
        /// <returns></returns>
        public static ThreadUnsafeSingleton Instance
        {
            get
            {
                // Fun fact, using 'is null' instead of '==' is better,
                // since '==' operator can theoretically be overloaded (although it almost never happens)
                if (_instance is null)
                {
                    _instance = new ThreadUnsafeSingleton();
                }

                return _instance;
            }
        }
    }
}
