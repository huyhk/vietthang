using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VNS.Common
{
    public delegate void DataChanged(object sender, DataChangedEventArgs e);
    public class DataChangedEventArgs : EventArgs
    {
        private object _oldValue = null;
        public object OldValue
        {
            get { return _oldValue; }
        }

        private object _newValue = null;
        public object NewValue
        {
            get { return _newValue; }
        }

        public DataChangedEventArgs(object value)
        {
            if (value != null)
                _newValue = (value as ObjectBase).Clone();
        }
        public void UpdateCurrentValue(object value)
        {
            if (value == null) return;

            if (_newValue != null)
                _oldValue = (_newValue as ObjectBase).Clone();
            _newValue = (value as ObjectBase).Clone();
        }
        
    }


    
   
}
