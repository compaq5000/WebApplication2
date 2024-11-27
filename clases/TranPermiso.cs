using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the TranPermiso class.
    /// </summary>
    [Serializable]
    public partial class TranPermisoCollection : ActiveList<TranPermiso, TranPermisoCollection>
    {
        public TranPermisoCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TranPermisoCollection</returns>
        public TranPermisoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TranPermiso o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }


    }
    /// <summary>
    /// This is an ActiveRecord class which wraps the TRAN__PERMISOS table.
    /// </summary>
    [Serializable]
    public partial class TranPermiso : ActiveRecord<TranPermiso>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TranPermiso()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public TranPermiso(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TranPermiso(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TranPermiso(string columnName, object columnValue)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByParam(columnName, columnValue);
        }

        protected static void SetSQLProps() { GetTableSchema(); }

        #endregion

        #region Schema and Query Accessor	
        public static Query CreateQuery() { return new Query(Schema); }
        public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                    SetSQLProps();
                return BaseSchema;
            }
        }

        private static void GetTableSchema()
        {
            if (!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("TRAN__PERMISOS", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = true;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = true;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                colvarId.DefaultSetting = @"";
                colvarId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarId);

                TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
                colvarIDExpediente.ColumnName = "IDExpediente";
                colvarIDExpediente.DataType = DbType.Int32;
                colvarIDExpediente.MaxLength = 0;
                colvarIDExpediente.AutoIncrement = false;
                colvarIDExpediente.IsNullable = true;
                colvarIDExpediente.IsPrimaryKey = false;
                colvarIDExpediente.IsForeignKey = true;
                colvarIDExpediente.IsReadOnly = false;
                colvarIDExpediente.DefaultSetting = @"";

                colvarIDExpediente.ForeignKeyTableName = "Expedientes";
                schema.Columns.Add(colvarIDExpediente);

                TableSchema.TableColumn colvarIDPermiso = new TableSchema.TableColumn(schema);
                colvarIDPermiso.ColumnName = "IDPermiso";
                colvarIDPermiso.DataType = DbType.AnsiStringFixedLength;
                colvarIDPermiso.MaxLength = 1;
                colvarIDPermiso.AutoIncrement = false;
                colvarIDPermiso.IsNullable = true;
                colvarIDPermiso.IsPrimaryKey = false;
                colvarIDPermiso.IsForeignKey = true;
                colvarIDPermiso.IsReadOnly = false;
                colvarIDPermiso.DefaultSetting = @"";

                colvarIDPermiso.ForeignKeyTableName = "CatAcceso";
                schema.Columns.Add(colvarIDPermiso);

                TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
                colvarIDUser.ColumnName = "IDUser";
                colvarIDUser.DataType = DbType.Int32;
                colvarIDUser.MaxLength = 0;
                colvarIDUser.AutoIncrement = false;
                colvarIDUser.IsNullable = true;
                colvarIDUser.IsPrimaryKey = false;
                colvarIDUser.IsForeignKey = true;
                colvarIDUser.IsReadOnly = false;
                colvarIDUser.DefaultSetting = @"";

                colvarIDUser.ForeignKeyTableName = "CatUsuarios";
                schema.Columns.Add(colvarIDUser);

                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Boolean;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                colvarStatus.DefaultSetting = @"";
                colvarStatus.ForeignKeyTableName = "";
                schema.Columns.Add(colvarStatus);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("TRAN__PERMISOS", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id
        {
            get { return GetColumnValue<int>(Columns.Id); }
            set { SetColumnValue(Columns.Id, value); }
        }

        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int? IDExpediente
        {
            get { return GetColumnValue<int?>(Columns.IDExpediente); }
            set { SetColumnValue(Columns.IDExpediente, value); }
        }

        [XmlAttribute("IDPermiso")]
        [Bindable(true)]
        public string IDPermiso
        {
            get { return GetColumnValue<string>(Columns.IDPermiso); }
            set { SetColumnValue(Columns.IDPermiso, value); }
        }

        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int? IDUser
        {
            get { return GetColumnValue<int?>(Columns.IDUser); }
            set { SetColumnValue(Columns.IDUser, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatAcceso ActiveRecord object related to this TranPermiso
        /// 
        /// </summary>
        public SubSonicDB.CatAcceso CatAcceso
        {
            get { return SubSonicDB.CatAcceso.FetchByID(this.IDPermiso); }
            set { SetColumnValue("IDPermiso", value.Id); }
        }


        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this TranPermiso
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuario
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.IDUser); }
            set { SetColumnValue("IDUser", value.Id); }
        }


        /// <summary>
        /// Returns a Expediente ActiveRecord object related to this TranPermiso
        /// 
        /// </summary>
        public SubSonicDB.Expediente Expediente
        {
            get { return SubSonicDB.Expediente.FetchByID(this.IDExpediente); }
            set { SetColumnValue("IDExpediente", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(int? varIDExpediente, string varIDPermiso, int? varIDUser, bool? varStatus)
        {
            TranPermiso item = new TranPermiso();

            item.IDExpediente = varIDExpediente;

            item.IDPermiso = varIDPermiso;

            item.IDUser = varIDUser;

            item.Status = varStatus;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, int? varIDExpediente, string varIDPermiso, int? varIDUser, bool? varStatus)
        {
            TranPermiso item = new TranPermiso();

            item.Id = varId;

            item.IDExpediente = varIDExpediente;

            item.IDPermiso = varIDPermiso;

            item.IDUser = varIDUser;

            item.Status = varStatus;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }



        public static TableSchema.TableColumn IDExpedienteColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn IDPermisoColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn IDUserColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[4]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string IDExpediente = @"IDExpediente";
            public static string IDPermiso = @"IDPermiso";
            public static string IDUser = @"IDUser";
            public static string Status = @"status";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
