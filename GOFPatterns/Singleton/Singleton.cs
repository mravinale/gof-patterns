using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton {

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class Singleton {

        private static volatile Singleton _instance;
        private static object syncRoot = new Object();

        // Constructor is 'protected'
        protected Singleton() { }

        public static Singleton Instance() {
            if (_instance == null) {
                lock (syncRoot) {
                    _instance = new Singleton();
                }
            }

            return _instance;
        }
    }
}
