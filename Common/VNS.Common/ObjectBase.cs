using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
namespace VNS.Common
{
    
    public abstract class ObjectBase : ICloneable//,IEditableObject
    {
        
        /// <summary>
        /// Checks if a field has DBNull value
        /// </summary>
        /// <param name="fieldName">Database field name</param>
        /// <param name="reader">Data Reader</param>
        /// <returns></returns>
        public bool isNull(string fieldName, IDataReader reader)
        {
            int i = 0;
            try
            {
                i = reader.GetOrdinal(fieldName);
            }
            catch { return true; }

            if (i>=0)
            {
                return reader.IsDBNull(i);
            }
            else 
                return true;
        }
        /// <summary>
        /// Copies property values from a data reader, must be overriden in derived classes
        /// </summary>
        /// <param name="reader">Data Reader contains values to copy</param>
        public virtual void FromDataReader(IDataReader reader)
        { 
        }
        public virtual void FromDataRow(DataRow row)
        { }
        public virtual void LoadFromReader(DbDataReader reader)
        {
        }
        public virtual void LoadFromDataRow(DataRow row)
        { }
        protected int _Id;

        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
	
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
            
            this.CopyProperties(newObject);
            return newObject;
        }
        /// <summary>
        /// Copies property values to another object
        /// </summary>
        /// <param name="objNew">The object which properties will be overriden </param>
        public void CopyProperties(object objNew)
        {
            int i = 0;

            #region Coppies Object's Fields

            FieldInfo[] fields = objNew.GetType().GetFields();
            foreach (FieldInfo fi in this.GetType().GetFields(BindingFlags.SetField))
            {
                Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);
                if (ICloneType != null && !fi.FieldType.IsArray)
                {
                    ICloneable IClone = (ICloneable)fi.GetValue(this);
                    if (IClone !=null)
                        fi.SetValue(objNew, IClone.Clone());
                }
                else
                {
                    
                    Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
                    if (IEnumerableType == null)
                        fi.SetValue(objNew, fi.GetValue(this));
                    else //if (IEnumerableType != null)
                    {
                        IEnumerable IEnum = (IEnumerable)fi.GetValue(this);

                        Type IListType = fi.FieldType.GetInterface("IList", true);
                        Type IDicType = fi.FieldType.GetInterface("IDictionary", true);

                        int j = 0;
                        if (IListType != null && IEnum != null)
                        {
                            IList list = this.CloneList(fi.GetValue(this) as IList);
                            fi.SetValue(objNew, list);
                            
                        }
                        else if (IDicType != null && IEnum != null)
                        {                            
                            IDictionary dic = this.CloneDictionary(fi.GetValue(this) as IDictionary);
                            fi.SetValue(objNew, dic);
                            
                        }
                    }
                }
                i++;
            }

            #endregion

            i = 0;
            #region Coppies Object's Properties
            
            PropertyInfo[] properties = objNew.GetType().GetProperties();
            foreach (PropertyInfo pro in properties)
            {
                if (!pro.CanWrite) continue; 
                Type ICloneType = pro.PropertyType.GetInterface("ICloneable", true);
                
                if (ICloneType != null && !pro.PropertyType.IsArray)
                {
                    ICloneable IClone = (ICloneable)pro.GetValue(this, null);
                    if (IClone != null)
                        pro.SetValue(objNew, IClone.Clone(), null);
                    
                }
                else
                {

                    Type IEnumerableType = pro.PropertyType.GetInterface("IEnumerable", true);
                    if (IEnumerableType == null) 
                    {
                        //pro.SetValue(objNew, pro.GetValue(this, null), null); 
                        if (pro.PropertyType == typeof(DataTable))
                        {
                            object val = pro.GetValue(this, null);
                            if (val != null)
                                pro.SetValue(objNew, (val as DataTable).Copy(), null);
                            else
                                pro.SetValue(objNew, null,null);
                        }
                        else
                            pro.SetValue(objNew, pro.GetValue(this, null), null);
                    }
                    else //if (IEnumerableType != null)
                    {
                        IEnumerable IEnum = (IEnumerable)pro.GetValue(this, null);

                        Type IListType = pro.PropertyType.GetInterface("IList", true);
                        Type IDicType = pro.PropertyType.GetInterface("IDictionary", true);

                        int j = 0;
                        if (IListType != null  && IEnum != null)
                        {

                            //IList list = Activator.CreateInstance(pro.PropertyType) as IList;// (IList)pro.GetValue(objNew, null);                            
                            IList list = this.CloneList(pro.GetValue(this, null) as IList);
                            pro.SetValue(objNew, list, null);
                        }
                        else if (IDicType != null && IEnum != null)
                        {
                            IDictionary dic = this.CloneDictionary(pro.GetValue(this, null) as IDictionary);

                             pro.SetValue(objNew, dic, null);
                            
                        }
                    }
                }
                i++;
            }

            #endregion
        }
        /// <summary>
        /// Copies property values from another object
        /// </summary>
        /// <param name="objFrom">the object contains values to copy</param>
        public void CopyPropertiesFrom(ObjectBase objFrom)
        {
            objFrom.CopyProperties(this);
        }
        #region IEditableObject Members
        ObjectBase backup = null;
        //public void BeginEdit()
        //{
        //    //if (this.backup == null)
        //        //this.backup = this.Clone() as ObjectBase;
        //}

        //public void CancelEdit()
        //{
        //    //this.backup.CopyProperties(this);
        //}

        //public void EndEdit()
        //{
        //    //this.CopyProperties(this.backup);
        //}
        public void BeginEdit2()
        {
            //if (this.backup == null)
            this.backup = this.Clone() as ObjectBase;
        }

        public void CancelEdit2()
        {
            this.backup.CopyProperties(this);
        }

        public void EndEdit2()
        {
            //this.CopyProperties(this.backup);
        }
        private IDictionary CloneDictionary(IDictionary dic)
        {
            IDictionary cloneDic;
            Type dicType = dic.GetType();
            
            
            cloneDic = Activator.CreateInstance(dicType) as IDictionary;
            foreach (DictionaryEntry de in dic)
            {
                if (de.Value != null)
                {
                    if (de.Value.GetType().GetInterface("ICloneable") != null)
                    {
                        cloneDic.Add(de.Key,(de.Value as ICloneable).Clone());
                    }
                    else if (de.Value.GetType().GetInterface("IList") != null)
                        cloneDic.Add(de.Key, this.CloneList(de.Value as IList));
                    else if (de.Value.GetType().GetInterface("IDictionary") != null)
                        cloneDic.Add(de.Key, this.CloneDictionary(de.Value as IDictionary));
                }
                else
                    cloneDic.Add(de.Key,de.Value);

            }
            return cloneDic;

        }

        private IList CloneList(IList list)
        {
            IList cloneList ;
            Type listType = list.GetType();
            int j = 0;
            if (!listType.IsArray)
            {
                cloneList = Activator.CreateInstance(listType) as IList;
                foreach(object obj in list)
                {
                    if (obj != null)
                    {
                        if (obj.GetType().GetInterface("ICloneable") != null)
                        {
                            cloneList.Add((obj as ICloneable).Clone());
                        }
                        else if (obj.GetType().GetInterface("IList") != null)
                            cloneList.Add(this.CloneList(obj as IList));
                        else if (obj.GetType().GetInterface("IDictionary") != null)
                            cloneList.Add(this.CloneDictionary(obj as IDictionary));
                    }
                    else
                        cloneList.Add(obj);
                    
                }
            }
            else                
            {
                cloneList = (list as ICloneable).Clone() as IList;
                foreach (object obj in list)
                {
                    if (obj != null)
                    {                        
                        if (obj.GetType().GetInterface("ICloneable", true) != null)
                        {
                            ICloneable clone = (ICloneable)obj;
                            
                            cloneList[j] = clone.Clone();
                        }
                        else if (obj.GetType().GetInterface("IList") != null)
                            cloneList[j] = this.CloneList(obj as IList);
                        else if (obj.GetType().GetInterface("IDictionary") != null)
                            cloneList[j] = this.CloneDictionary(obj as IDictionary);
                    }
                    j++;
                }

                
            }
            return cloneList;
        }

        #endregion
        protected bool CheckNull(string columnName, DbDataReader reader)
        {
            int n;
            try
            {
                n = reader.GetOrdinal(columnName);
            }
            catch
            { n = -1; }

            if (n >= 0)
                return reader.IsDBNull(n);
            else
                return true;
        }
    }
}
