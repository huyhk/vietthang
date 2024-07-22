using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VNS.Common
{
    public abstract class BaseObject : ICloneable
    {
        /// <summary>
        /// Clone the object, and returning a reference to a cloned object.
        /// </summary>
        /// <returns>Reference to the new cloned 
        /// object.</returns>
        public object Clone()
        {
            
            object newObject;
            try
            {
                newObject = this.MemberwiseClone();// Activator.CreateInstance(this.GetType(), true);
            }
            catch
            {
                return null;
            }
            
            int i = 0;

            #region Coppies Object's Fields

            FieldInfo[] fields = newObject.GetType().GetFields();
            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);
                if (ICloneType != null)
                {
                    ICloneable IClone = (ICloneable)fi.GetValue(this);
                    fields[i].SetValue(newObject, IClone.Clone());
                }
                else
                    fields[i].SetValue(newObject, fi.GetValue(this));

                Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
                if (IEnumerableType != null)
                {
                    IEnumerable IEnum = (IEnumerable)fi.GetValue(this);

                    Type IListType = fields[i].FieldType.GetInterface("IList", true);
                    Type IDicType = fields[i].FieldType.GetInterface("IDictionary", true);

                    int j = 0;
                    if (IListType != null)
                    {
                        IList list = (IList)fields[i].GetValue(newObject);
                        foreach (object obj in IEnum)
                        {
                            ICloneType = obj.GetType().GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)obj;

                                list[j] = clone.Clone();
                            }
                            j++;
                        }
                    }
                    else if (IDicType != null)
                    {
                        IDictionary dic = (IDictionary)fields[i].GetValue(newObject);
                        j = 0;

                        foreach (DictionaryEntry de in IEnum)
                        {
                            ICloneType = de.Value.GetType().GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)de.Value;
                                dic[de.Key] = clone.Clone();
                            }
                            j++;
                        }
                    }
                }
                i++;
            }

            #endregion

            i = 0;
            #region Coppies Object's Properties

            PropertyInfo[] properties = newObject.GetType().GetProperties();
            foreach (PropertyInfo pro in properties)
            {
                Type ICloneType = pro.PropertyType.GetInterface("ICloneable", true);
                if (ICloneType != null)
                {
                    ICloneable IClone = (ICloneable)pro.GetValue(this, null);
                    properties[i].SetValue(newObject, IClone.Clone(), null);
                }
                else
                    properties[i].SetValue(newObject, pro.GetValue(this, null), null);

                Type IEnumerableType = pro.PropertyType.GetInterface("IEnumerable", true);
                if (IEnumerableType != null)
                {
                    IEnumerable IEnum = (IEnumerable)pro.GetValue(this, null);

                    Type IListType = properties[i].PropertyType.GetInterface("IList", true);
                    Type IDicType = properties[i].PropertyType.GetInterface("IDictionary", true);

                    int j = 0;
                    if (IListType != null)
                    {
                        IList list = (IList)properties[i].GetValue(newObject, null);
                        foreach (object obj in IEnum)
                        {
                            ICloneType = obj.GetType().GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)obj;
                                list[j] = clone.Clone();
                            }
                            j++;
                        }
                    }
                    else if (IDicType != null)
                    {
                        IDictionary dic = (IDictionary)properties[i].GetValue(newObject, null);
                        j = 0;

                        foreach (DictionaryEntry de in IEnum)
                        {
                            ICloneType = de.Value.GetType().GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)de.Value;
                                dic[de.Key] = clone.Clone();
                            }
                            j++;
                        }
                    }
                }
                i++;
            }

            #endregion

            return newObject;
        }                


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        
    }
}
