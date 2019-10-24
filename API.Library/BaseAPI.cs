using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public abstract class BaseAPI
    {
        public string name;

        public BaseAPI(string name)
        {
            this.name = name.ToLower();
        }

        public string GetName()
        {
            return name;
        }
    }
}
