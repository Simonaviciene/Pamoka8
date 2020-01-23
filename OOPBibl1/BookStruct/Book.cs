using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStruct
{
    public struct Book
    {
        private string _name;
        private string _Id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string LocalID
        {
            get 
            {
                if (_name == "")
                {
                    return _Id;
                }
                if (_Id == "")
                {
                    return _name;
                }
                return _name + "_" + _Id; 

            }
            set { }

        }
    }
}
