using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAdvisor.Supports
{
    class RequestJSON
    {
        public class Exception
        {
            string _name = "";
            string _text = "";

            public string name
            {
                set
                {
                    _name = value;
                }
                get
                {
                    return _name;
                }
            }

            public string text
            {
                set
                {
                    _text = value;
                }
                get
                {
                    return _text;
                }
            }

            public Exception(string _name, string _text)
            {
                this._name = _name;
                this._text = _text;
            }
        }

        private Exception _exception;

        public Exception exception
        {
            set
            {
                _exception = value;
            }
            get
            {
                return _exception;
            }
        }

        string[] _functions = null;

        public string[] functions
        {
            set
            {
                _functions = value;
            }
            get
            {
                return _functions;
            }
        }

        public RequestJSON(string ex, string exText, string[] funcs)
        {
            this._exception = new Exception(ex, exText);
            this._functions = funcs;
        }
    }
}
