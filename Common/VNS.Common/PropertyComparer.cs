using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Collections;
namespace VNS.Common
{
    public class PropertyComparer<T>:IComparer<T>
    {
        public PropertyComparer(string propName):this(propName,ListSortDirection.Ascending,StringComparison.OrdinalIgnoreCase)
        { }
        public PropertyComparer(string propName, ListSortDirection direction)
            : this(propName, direction, StringComparison.OrdinalIgnoreCase)
        { }
        public PropertyComparer(string propName, StringComparison option)
            : this(propName, ListSortDirection.Ascending, option)
        { }
        public PropertyComparer(string propName, ListSortDirection direction, StringComparison option)
        {
            this.propName = propName;
            this.direction = direction;
            this.option = option;
        }
        private string propName;
        private ListSortDirection direction;
        private StringComparison option;
        #region IComparer<T> Members

        public int Compare(T x, T y)
        {
            if (x==null && y==null)
                return 0;
            if (x==null)
                return -1;
            if (y==null)
                return 1;
            
            PropertyInfo prop =  typeof(T).GetProperty(this.propName);
            IComparable xval = prop.GetValue(x, null) as IComparable;
            if (xval == null)
                throw new ArgumentException("Property does not implement IComparable.");
            else
            {
                return xval.CompareTo(prop.GetValue(y, null));
            }
        }

        #endregion
    }    
    
}
