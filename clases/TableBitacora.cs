using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the TableBitacora class.
    /// </summary>
    [Serializable]
    public partial class TableBitacoraCollection : ActiveList<TableBitacora, TableBitacoraCollection>
    {
        public TableBitacoraCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TableBitacoraCollection</returns>
        public TableBitacoraCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TableBitacora o = this[i];
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
    /// This is an ActiveRecord class which wraps the TableBitacora table.
    /// </summary>
    [Serializable]
    public partial class TableBitacora : ActiveRecord<TableBitacora>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TableBitacora()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public TableBitacora(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TableBitacora(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TableBitacora(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("TableBitacora", TableType.Table, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarTipoOperacion = new TableSchema.TableColumn(schema);
                colvarTipoOperacion.ColumnName = "TipoOperacion";
                colvarTipoOperacion.DataType = DbType.Int32;
                colvarTipoOperacion.MaxLength = 0;
                colvarTipoOperacion.AutoIncrement = false;
                colvarTipoOperacion.IsNullable = true;
                colvarTipoOperacion.IsPrimaryKey = false;
                colvarTipoOperacion.IsForeignKey = true;
                colvarTipoOperacion.IsReadOnly = false;
                colvarTipoOperacion.DefaultSetting = @"";

                colvarTipoOperacion.ForeignKeyTableName = "TableTipoOperacion";
                schema.Columns.Add(colvarTipoOperacion);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 500;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                colvarDescripcion.DefaultSetting = @"";
                colvarDescripcion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripcion);

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

                TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
                colvarFecha.ColumnName = "Fecha";
                colvarFecha.DataType = DbType.DateTime;
                colvarFecha.MaxLength = 0;
                colvarFecha.AutoIncrement = false;
                colvarFecha.IsNullable = true;
                colvarFecha.IsPrimaryKey = false;
                colvarFecha.IsForeignKey = false;
                colvarFecha.IsReadOnly = false;
                colvarFecha.DefaultSetting = @"";
                colvarFecha.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFecha);

                TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
                colvarIDUser.ColumnName = "IDUser";
                colvarIDUser.DataType = DbType.Int32;
                colvarIDUser.MaxLength = 0;
                colvarIDUser.AutoIncrement = false;
                colvarIDUser.IsNullable = true;
                colvarIDUser.IsPrimaryKey = false;
                colvarIDUser.IsForeignKey = false;
                colvarIDUser.IsReadOnly = false;
                colvarIDUser.DefaultSetting = @"";
                colvarIDUser.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIDUser);

                TableSchema.TableColumn colvarIp = new TableSchema.TableColumn(schema);
                colvarIp.ColumnName = "IP";
                colvarIp.DataType = DbType.String;
                colvarIp.MaxLength = 50;
                colvarIp.AutoIncrement = false;
                colvarIp.IsNullable = true;
                colvarIp.IsPrimaryKey = false;
                colvarIp.IsForeignKey = false;
                colvarIp.IsReadOnly = false;
                colvarIp.DefaultSetting = @"";
                colvarIp.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIp);

                TableSchema.TableColumn colvarMac = new TableSchema.TableColumn(schema);
                colvarMac.ColumnName = "MAC";
                colvarMac.DataType = DbType.String;
                colvarMac.MaxLength = 150;
                colvarMac.AutoIncrement = false;
                colvarMac.IsNullable = true;
                colvarMac.IsPrimaryKey = false;
                colvarMac.IsForeignKey = false;
                colvarMac.IsReadOnly = false;
                colvarMac.DefaultSetting = @"";
                colvarMac.ForeignKeyTableName = "";
                schema.Columns.Add(colvarMac);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("TableBitacora", schema);
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

        [XmlAttribute("TipoOperacion")]
        [Bindable(true)]
        public int? TipoOperacion
        {
            get { return GetColumnValue<int?>(Columns.TipoOperacion); }
            set { SetColumnValue(Columns.TipoOperacion, value); }
        }

        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion
        {
            get { return GetColumnValue<string>(Columns.Descripcion); }
            set { SetColumnValue(Columns.Descripcion, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime? Fecha
        {
            get { return GetColumnValue<DateTime?>(Columns.Fecha); }
            set { SetColumnValue(Columns.Fecha, value); }
        }

        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int? IDUser
        {
            get { return GetColumnValue<int?>(Columns.IDUser); }
            set { SetColumnValue(Columns.IDUser, value); }
        }

        [XmlAttribute("Ip")]
        [Bindable(true)]
        public string Ip
        {
            get { return GetColumnValue<string>(Columns.Ip); }
            set { SetColumnValue(Columns.Ip, value); }
        }

        [XmlAttribute("Mac")]
        [Bindable(true)]
        public string Mac
        {
            get { return GetColumnValue<string>(Columns.Mac); }
            set { SetColumnValue(Columns.Mac, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a TableTipoOperacion ActiveRecord object related to this TableBitacora
        /// 
        /// </summary>
        public SubSonicDB.TableTipoOperacion TableTipoOperacion
        {
            get { return SubSonicDB.TableTipoOperacion.FetchByID(this.TipoOperacion); }
            set { SetColumnValue("TipoOperacion", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(int? varTipoOperacion, string varDescripcion, bool? varStatus, DateTime? varFecha, int? varIDUser, string varIp, string varMac)
        {
            TableBitacora item = new TableBitacora();

            item.TipoOperacion = varTipoOperacion;

            item.Descripcion = varDescripcion;

            item.Status = varStatus;

            item.Fecha = varFecha;

            item.IDUser = varIDUser;

            item.Ip = varIp;

            item.Mac = varMac;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, int? varTipoOperacion, string varDescripcion, bool? varStatus, DateTime? varFecha, int? varIDUser, string varIp, string varMac)
        {
            TableBitacora item = new TableBitacora();

            item.Id = varId;

            item.TipoOperacion = varTipoOperacion;

            item.Descripcion = varDescripcion;

            item.Status = varStatus;

            item.Fecha = varFecha;

            item.IDUser = varIDUser;

            item.Ip = varIp;

            item.Mac = varMac;

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



        public static TableSchema.TableColumn TipoOperacionColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn IDUserColumn
        {
            get { return Schema.Columns[5]; }
        }



        public static TableSchema.TableColumn IpColumn
        {
            get { return Schema.Columns[6]; }
        }



        public static TableSchema.TableColumn MacColumn
        {
            get { return Schema.Columns[7]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string TipoOperacion = @"TipoOperacion";
            public static string Descripcion = @"Descripcion";
            public static string Status = @"status";
            public static string Fecha = @"Fecha";
            public static string IDUser = @"IDUser";
            public static string Ip = @"IP";
            public static string Mac = @"MAC";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
