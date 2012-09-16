using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class ConcreteSubject : Subject {
        private string _subjectState;

        // Gets or sets subject state
        public string SubjectState {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
