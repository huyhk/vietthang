using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.Common
{
    public abstract class Identifier<T>
    {
        private T _Id;

        public T ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
	
    }
}
