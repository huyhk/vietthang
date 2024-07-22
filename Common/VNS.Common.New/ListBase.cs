using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
namespace VNS.Common
{
    public interface IListBase
    {
        //DateTime LastUpdated;
        object NewItem { get;}
        int CurrentIndex { get; set; }

        object CurrentItem { get; set;}

        void OnPositionChanged(int oldIndex, int newIndex);
    }
    public class ListBase<T> : BindingList<T>, IListBase, ICloneable,IBindingListView
    {
        //public DateTime LastUpdated = DateTime.Now;
        public object NewItem
        {
            get { return default(T); }
        }
        public event IndexChangedEventHander PositionChanged;
        
        public void OnPositionChanged(int oldIndex, int newIndex)
        {
            if (this.PositionChanged != null)
                this.PositionChanged(oldIndex, newIndex);
        }

        public object CurrentItem
        {
            get {
                if (this.currentIndex < this.Count && this.currentIndex>-1)
                    return this[currentIndex];
                else return default(T);
            }
            set {
                if (this.Contains((T)value ))
                {
                    int oldIndex = this.currentIndex;
                    this.currentIndex = this.IndexOf((T)value );
                    OnPositionChanged(oldIndex, this.currentIndex);
                }
                else
                    throw new IndexOutOfRangeException(); 
            }
        }

        private int currentIndex;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                int oldIndex = this.currentIndex;
                currentIndex = value;
                OnPositionChanged(oldIndex, this.currentIndex); 
                
            }
        }
	
        public ListBase()
        {
            
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            base.OnListChanged(e);
            if (this.Count > 0)
                this.currentIndex = 0;
            else
                this.currentIndex = -1;
        }

        public void Sort(string propertyName,ListSortDirection direction)
        {
            if (this.SupportsSortingCore)
            {
                PropertyDescriptor pro = TypeDescriptor.GetProperties(typeof(T)).Find(propertyName,true);
                if (pro != null)
                    this.ApplySortCore(pro, direction);
            }
        }

        public T Search(string propertyName, object value)
        {
            if (this.SupportsSearchingCore && this.Count>0)
            {
                
                PropertyDescriptor pro = TypeDescriptor.GetProperties(typeof(T)).Find(propertyName, true);
                if (pro != null)
                {
                    int index = this.FindCore(pro, value);
                    if (index >= 0)
                        return this[index];
                    else
                        return default(T);

                }
                else
                    return default(T);
            }
            else
                return default(T);
            
        }
        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            
            foreach (T obj in this.Items)
            {
                
                if (prop.GetValue(obj).Equals(key))
                {
                    return this.IndexOf(obj);
                }
            }
            return -1;
        }
        protected override bool SupportsSearchingCore
        {
            get
            {
                return true;
            }
        }


        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            PropertyComparer<T> comparer = new PropertyComparer<T>(prop.Name,direction);
            List<T> items = this.Items as List<T>;
            items.Sort(comparer);
            
        }
        public override void EndNew(int itemIndex)
        {
            base.EndNew(itemIndex);
            
        }




        #region ICloneable Members

        public object Clone()
        {
            ListBase<T> lstObj = new ListBase<T>();
            foreach (T t in this.Items)
            {
                lstObj.Add((T)((ICloneable)t).Clone());
            }
            return lstObj;
        }

        #endregion

        #region IBindingListView Members

        public void ApplySort(ListSortDescriptionCollection sorts)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public string Filter
        {
            get
            {
                
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public void RemoveFilter()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ListSortDescriptionCollection SortDescriptions
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public bool SupportsAdvancedSorting
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public bool SupportsFiltering
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
    public delegate void IndexChangedEventHander(int oldIndex, int newIndex); 
}
