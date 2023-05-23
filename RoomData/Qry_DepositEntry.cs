//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace RoomData
{
    [DataContract(IsReference = true)]
    public partial class Qry_DepositEntry: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public Nullable<int> ItemID
        {
            get { return _itemID; }
            set
            {
                if (_itemID != value)
                {
                    _itemID = value;
                    OnPropertyChanged("ItemID");
                }
            }
        }
        private Nullable<int> _itemID;
    
        [DataMember]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    OnPropertyChanged("ItemName");
                }
            }
        }
        private string _itemName;
    
        [DataMember]
        public Nullable<int> TotalYear
        {
            get { return _totalYear; }
            set
            {
                if (_totalYear != value)
                {
                    _totalYear = value;
                    OnPropertyChanged("TotalYear");
                }
            }
        }
        private Nullable<int> _totalYear;
    
        [DataMember]
        public long rowID
        {
            get { return _rowID; }
            set
            {
                if (_rowID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'rowID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _rowID = value;
                    OnPropertyChanged("rowID");
                }
            }
        }
        private long _rowID;
    
        [DataMember]
        public Nullable<int> PersonID
        {
            get { return _personID; }
            set
            {
                if (_personID != value)
                {
                    _personID = value;
                    OnPropertyChanged("PersonID");
                }
            }
        }
        private Nullable<int> _personID;
    
        [DataMember]
        public Nullable<double> Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    OnPropertyChanged("Amount");
                }
            }
        }
        private Nullable<double> _amount;
    
        [DataMember]
        public Nullable<System.DateTime> EntryDate
        {
            get { return _entryDate; }
            set
            {
                if (_entryDate != value)
                {
                    _entryDate = value;
                    OnPropertyChanged("EntryDate");
                }
            }
        }
        private Nullable<System.DateTime> _entryDate;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
        }

        #endregion
    }
}
