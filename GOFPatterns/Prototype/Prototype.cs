using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype {

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class Prototype {
        private string _id;

        // Constructor
        public Prototype(string id) {
            this._id = id;
        }

        // Gets id
        public string Id {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

}
