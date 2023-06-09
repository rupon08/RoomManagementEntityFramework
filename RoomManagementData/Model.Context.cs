﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace RoomManagementData
{
    public partial class RoomManagementNewEntities : ObjectContext
    {
        public const string ConnectionString = "name=RoomManagementNewEntities";
        public const string ContainerName = "RoomManagementNewEntities";
    
        #region Constructors
    
        public RoomManagementNewEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public RoomManagementNewEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public RoomManagementNewEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Tbl_cityMaster> Tbl_cityMaster
        {
            get { return _tbl_cityMaster  ?? (_tbl_cityMaster = CreateObjectSet<Tbl_cityMaster>("Tbl_cityMaster")); }
        }
        private ObjectSet<Tbl_cityMaster> _tbl_cityMaster;
    
        public ObjectSet<Tbl_CountryMaster> Tbl_CountryMaster
        {
            get { return _tbl_CountryMaster  ?? (_tbl_CountryMaster = CreateObjectSet<Tbl_CountryMaster>("Tbl_CountryMaster")); }
        }
        private ObjectSet<Tbl_CountryMaster> _tbl_CountryMaster;
    
        public ObjectSet<Tbl_DailyMarketEntry> Tbl_DailyMarketEntry
        {
            get { return _tbl_DailyMarketEntry  ?? (_tbl_DailyMarketEntry = CreateObjectSet<Tbl_DailyMarketEntry>("Tbl_DailyMarketEntry")); }
        }
        private ObjectSet<Tbl_DailyMarketEntry> _tbl_DailyMarketEntry;
    
        public ObjectSet<Tbl_DailyMealEntry> Tbl_DailyMealEntry
        {
            get { return _tbl_DailyMealEntry  ?? (_tbl_DailyMealEntry = CreateObjectSet<Tbl_DailyMealEntry>("Tbl_DailyMealEntry")); }
        }
        private ObjectSet<Tbl_DailyMealEntry> _tbl_DailyMealEntry;
    
        public ObjectSet<Tbl_ExtraExpensesDtlsEntry> Tbl_ExtraExpensesDtlsEntry
        {
            get { return _tbl_ExtraExpensesDtlsEntry  ?? (_tbl_ExtraExpensesDtlsEntry = CreateObjectSet<Tbl_ExtraExpensesDtlsEntry>("Tbl_ExtraExpensesDtlsEntry")); }
        }
        private ObjectSet<Tbl_ExtraExpensesDtlsEntry> _tbl_ExtraExpensesDtlsEntry;
    
        public ObjectSet<Tbl_extraExpensesMst> Tbl_extraExpensesMst
        {
            get { return _tbl_extraExpensesMst  ?? (_tbl_extraExpensesMst = CreateObjectSet<Tbl_extraExpensesMst>("Tbl_extraExpensesMst")); }
        }
        private ObjectSet<Tbl_extraExpensesMst> _tbl_extraExpensesMst;
    
        public ObjectSet<Tbl_Login> Tbl_Login
        {
            get { return _tbl_Login  ?? (_tbl_Login = CreateObjectSet<Tbl_Login>("Tbl_Login")); }
        }
        private ObjectSet<Tbl_Login> _tbl_Login;
    
        public ObjectSet<Tbl_maritalStatusMaster> Tbl_maritalStatusMaster
        {
            get { return _tbl_maritalStatusMaster  ?? (_tbl_maritalStatusMaster = CreateObjectSet<Tbl_maritalStatusMaster>("Tbl_maritalStatusMaster")); }
        }
        private ObjectSet<Tbl_maritalStatusMaster> _tbl_maritalStatusMaster;
    
        public ObjectSet<Tbl_PersonDetailsEntry> Tbl_PersonDetailsEntry
        {
            get { return _tbl_PersonDetailsEntry  ?? (_tbl_PersonDetailsEntry = CreateObjectSet<Tbl_PersonDetailsEntry>("Tbl_PersonDetailsEntry")); }
        }
        private ObjectSet<Tbl_PersonDetailsEntry> _tbl_PersonDetailsEntry;
    
        public ObjectSet<Tbl_PersonPhoto> Tbl_PersonPhoto
        {
            get { return _tbl_PersonPhoto  ?? (_tbl_PersonPhoto = CreateObjectSet<Tbl_PersonPhoto>("Tbl_PersonPhoto")); }
        }
        private ObjectSet<Tbl_PersonPhoto> _tbl_PersonPhoto;
    
        public ObjectSet<Tbl_qualificationMaster> Tbl_qualificationMaster
        {
            get { return _tbl_qualificationMaster  ?? (_tbl_qualificationMaster = CreateObjectSet<Tbl_qualificationMaster>("Tbl_qualificationMaster")); }
        }
        private ObjectSet<Tbl_qualificationMaster> _tbl_qualificationMaster;

        #endregion
    }
}
