using DesignPatternsCommon;
using System;

namespace SingletonSyncDesignPattern
{
    /// <summary>
    /// Please note that Singleton design pattern is accualy an anti-pattern, since
    /// it does not follow SOLID principle 'D' (Dependency Inversion) by it's own definition.
    /// So try not to use it. Ever.
    /// </summary>
    public class SingletonExample : IExample
    {
        public void RunExample()
        {
            // If You try to uncomment this line, You will see that You can't create new instance like that.
            //var singletonFromNew = new ThreadUnsafeSingleton();

            var threadUnsafeSingleton = ThreadUnsafeSingleton.Instance;
            var threadSafeSingleton = ThreadSafeSingleton.Instance;
        }
    }
}
