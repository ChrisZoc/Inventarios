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
using System.Data;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace CapaPersistencia
{
    public partial class SIGINEntities : ObjectContext
    {
        public const string ConnectionString = "name=SIGINEntities";
        public const string ContainerName = "SIGINEntities";
    
        #region Constructors
    
        public SIGINEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public SIGINEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public SIGINEntities(EntityConnection connection)
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
    
        public ObjectSet<COMPRADEMATERIAPRIMA> COMPRADEMATERIAPRIMAs
        {
            get { return _cOMPRADEMATERIAPRIMAs  ?? (_cOMPRADEMATERIAPRIMAs = CreateObjectSet<COMPRADEMATERIAPRIMA>("COMPRADEMATERIAPRIMAs")); }
        }
        private ObjectSet<COMPRADEMATERIAPRIMA> _cOMPRADEMATERIAPRIMAs;
    
        public ObjectSet<DEVOLUCIONDEMATERIAPRIMA> DEVOLUCIONDEMATERIAPRIMAs
        {
            get { return _dEVOLUCIONDEMATERIAPRIMAs  ?? (_dEVOLUCIONDEMATERIAPRIMAs = CreateObjectSet<DEVOLUCIONDEMATERIAPRIMA>("DEVOLUCIONDEMATERIAPRIMAs")); }
        }
        private ObjectSet<DEVOLUCIONDEMATERIAPRIMA> _dEVOLUCIONDEMATERIAPRIMAs;
    
        public ObjectSet<DEVOLUCIONPRODUCTOTERMINADO> DEVOLUCIONPRODUCTOTERMINADOes
        {
            get { return _dEVOLUCIONPRODUCTOTERMINADOes  ?? (_dEVOLUCIONPRODUCTOTERMINADOes = CreateObjectSet<DEVOLUCIONPRODUCTOTERMINADO>("DEVOLUCIONPRODUCTOTERMINADOes")); }
        }
        private ObjectSet<DEVOLUCIONPRODUCTOTERMINADO> _dEVOLUCIONPRODUCTOTERMINADOes;
    
        public ObjectSet<LOTE> LOTEs
        {
            get { return _lOTEs  ?? (_lOTEs = CreateObjectSet<LOTE>("LOTEs")); }
        }
        private ObjectSet<LOTE> _lOTEs;
    
        public ObjectSet<PRODUCTOTERMINADO> PRODUCTOTERMINADOes
        {
            get { return _pRODUCTOTERMINADOes  ?? (_pRODUCTOTERMINADOes = CreateObjectSet<PRODUCTOTERMINADO>("PRODUCTOTERMINADOes")); }
        }
        private ObjectSet<PRODUCTOTERMINADO> _pRODUCTOTERMINADOes;
    
        public ObjectSet<PROVEEDOR> PROVEEDORs
        {
            get { return _pROVEEDORs  ?? (_pROVEEDORs = CreateObjectSet<PROVEEDOR>("PROVEEDORs")); }
        }
        private ObjectSet<PROVEEDOR> _pROVEEDORs;
    
        public ObjectSet<TIPOMATERIAPRIMA> TIPOMATERIAPRIMAs
        {
            get { return _tIPOMATERIAPRIMAs  ?? (_tIPOMATERIAPRIMAs = CreateObjectSet<TIPOMATERIAPRIMA>("TIPOMATERIAPRIMAs")); }
        }
        private ObjectSet<TIPOMATERIAPRIMA> _tIPOMATERIAPRIMAs;
    
        public ObjectSet<TIPOPRODUCTOTERMINADO> TIPOPRODUCTOTERMINADOes
        {
            get { return _tIPOPRODUCTOTERMINADOes  ?? (_tIPOPRODUCTOTERMINADOes = CreateObjectSet<TIPOPRODUCTOTERMINADO>("TIPOPRODUCTOTERMINADOes")); }
        }
        private ObjectSet<TIPOPRODUCTOTERMINADO> _tIPOPRODUCTOTERMINADOes;

        #endregion

    }
}
