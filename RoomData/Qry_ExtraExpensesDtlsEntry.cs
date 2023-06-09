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
    public partial class Qry_ExtraExpensesDtlsEntry: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
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
        public Nullable<System.DateTime> entryDate
        {
            get { return _entryDate; }
            set
            {
                if (_entryDate != value)
                {
                    _entryDate = value;
                    OnPropertyChanged("entryDate");
                }
            }
        }
        private Nullable<System.DateTime> _entryDate;
    
        [DataMember]
        public Nullable<long> expAmt
        {
            get { return _expAmt; }
            set
            {
                if (_expAmt != value)
                {
                    _expAmt = value;
                    OnPropertyChanged("expAmt");
                }
            }
        }
        private Nullable<long> _expAmt;
    
        [DataMember]
        public long ExtraDetailRowID
        {
            get { return _extraDetailRowID; }
            set
            {
                if (_extraDetailRowID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ExtraDetailRowID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _extraDetailRowID = value;
                    OnPropertyChanged("ExtraDetailRowID");
                }
            }
        }
        private long _extraDetailRowID;
    
        [DataMember]
        public Nullable<bool> IsExpenses
        {
            get { return _isExpenses; }
            set
            {
                if (_isExpenses != value)
                {
                    _isExpenses = value;
                    OnPropertyChanged("IsExpenses");
                }
            }
        }
        private Nullable<bool> _isExpenses;
    
        [DataMember]
        public Nullable<bool> IsUtilities
        {
            get { return _isUtilities; }
            set
            {
                if (_isUtilities != value)
                {
                    _isUtilities = value;
                    OnPropertyChanged("IsUtilities");
                }
            }
        }
        private Nullable<bool> _isUtilities;
    
        [DataMember]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        private string _description;
    
        [DataMember]
        public Nullable<bool> IsExtratExpenses
        {
            get { return _isExtratExpenses; }
            set
            {
                if (_isExtratExpenses != value)
                {
                    _isExtratExpenses = value;
                    OnPropertyChanged("IsExtratExpenses");
                }
            }
        }
        private Nullable<bool> _isExtratExpenses;
    
        [DataMember]
        public Nullable<long> expID
        {
            get { return _expID; }
            set
            {
                if (_expID != value)
                {
                    _expID = value;
                    OnPropertyChanged("expID");
                }
            }
        }
        private Nullable<long> _expID;
    
        [DataMember]
        public Nullable<int> PersonName
        {
            get { return _personName; }
            set
            {
                if (_personName != value)
                {
                    _personName = value;
                    OnPropertyChanged("PersonName");
                }
            }
        }
        private Nullable<int> _personName;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;

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
