using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the SoporteTranServicio class.
    /// </summary>
    [Serializable]
    public partial class SoporteTranServicioCollection : ActiveList<SoporteTranServicio, SoporteTranServicioCollection>
    {
        public SoporteTranServicioCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SoporteTranServicioCollection</returns>
        public SoporteTranServicioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SoporteTranServicio o = this[i];
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
    /// This is an ActiveRecord class which wraps the Soporte_Tran_servicio table.
    /// </summary>
    [Serializable]
    public partial class SoporteTranServicio : ActiveRecord<SoporteTranServicio>, IActiveRecord
    {
        #region .ctors and Default Settings

        public SoporteTranServicio()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public SoporteTranServicio(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public SoporteTranServicio(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public SoporteTranServicio(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("Soporte_Tran_servicio", TableType.Table, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 50;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                colvarDescripcion.DefaultSetting = @"";
                colvarDescripcion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripcion);

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

                TableSchema.TableColumn colvarFechaAlta = new TableSchema.TableColumn(schema);
                colvarFechaAlta.ColumnName = "FechaAlta";
                colvarFechaAlta.DataType = DbType.DateTime;
                colvarFechaAlta.MaxLength = 0;
                colvarFechaAlta.AutoIncrement = false;
                colvarFechaAlta.IsNullable = true;
                colvarFechaAlta.IsPrimaryKey = false;
                colvarFechaAlta.IsForeignKey = false;
                colvarFechaAlta.IsReadOnly = false;
                colvarFechaAlta.DefaultSetting = @"";
                colvarFechaAlta.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFechaAlta);

                TableSchema.TableColumn colvarFechaAtencion = new TableSchema.TableColumn(schema);
                colvarFechaAtencion.ColumnName = "FechaAtencion";
                colvarFechaAtencion.DataType = DbType.DateTime;
                colvarFechaAtencion.MaxLength = 0;
                colvarFechaAtencion.AutoIncrement = false;
                colvarFechaAtencion.IsNullable = true;
                colvarFechaAtencion.IsPrimaryKey = false;
                colvarFechaAtencion.IsForeignKey = false;
                colvarFechaAtencion.IsReadOnly = false;
                colvarFechaAtencion.DefaultSetting = @"";
                colvarFechaAtencion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFechaAtencion);

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

                TableSchema.TableColumn colvarIDSoporte = new TableSchema.TableColumn(schema);
                colvarIDSoporte.ColumnName = "IDSoporte";
                colvarIDSoporte.DataType = DbType.Int32;
                colvarIDSoporte.MaxLength = 0;
                colvarIDSoporte.AutoIncrement = false;
                colvarIDSoporte.IsNullable = true;
                colvarIDSoporte.IsPrimaryKey = false;
                colvarIDSoporte.IsForeignKey = true;
                colvarIDSoporte.IsReadOnly = false;
                colvarIDSoporte.DefaultSetting = @"";

                colvarIDSoporte.ForeignKeyTableName = "Soporte_Cat_Servicio";
                schema.Columns.Add(colvarIDSoporte);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("Soporte_Tran_servicio", schema);
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

        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion
        {
            get { return GetColumnValue<string>(Columns.Descripcion); }
            set { SetColumnValue(Columns.Descripcion, value); }
        }

        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int? IDUser
        {
            get { return GetColumnValue<int?>(Columns.IDUser); }
            set { SetColumnValue(Columns.IDUser, value); }
        }

        [XmlAttribute("FechaAlta")]
        [Bindable(true)]
        public DateTime? FechaAlta
        {
            get { return GetColumnValue<DateTime?>(Columns.FechaAlta); }
            set { SetColumnValue(Columns.FechaAlta, value); }
        }

        [XmlAttribute("FechaAtencion")]
        [Bindable(true)]
        public DateTime? FechaAtencion
        {
            get { return GetColumnValue<DateTime?>(Columns.FechaAtencion); }
            set { SetColumnValue(Columns.FechaAtencion, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("IDSoporte")]
        [Bindable(true)]
        public int? IDSoporte
        {
            get { return GetColumnValue<int?>(Columns.IDSoporte); }
            set { SetColumnValue(Columns.IDSoporte, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this SoporteTranServicio
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuario
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.IDUser); }
            set { SetColumnValue("IDUser", value.Id); }
        }


        /// <summary>
        /// Returns a SoporteCatServicio ActiveRecord object related to this SoporteTranServicio
        /// 
        /// </summary>
        public SubSonicDB.SoporteCatServicio SoporteCatServicio
        {
            get { return SubSonicDB.SoporteCatServicio.FetchByID(this.IDSoporte); }
            set { SetColumnValue("IDSoporte", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripcion, int? varIDUser, DateTime? varFechaAlta, DateTime? varFechaAtencion, bool? varStatus, int? varIDSoporte)
        {
            SoporteTranServicio item = new SoporteTranServicio();

            item.Descripcion = varDescripcion;

            item.IDUser = varIDUser;

            item.FechaAlta = varFechaAlta;

            item.FechaAtencion = varFechaAtencion;

            item.Status = varStatus;

            item.IDSoporte = varIDSoporte;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, string varDescripcion, int? varIDUser, DateTime? varFechaAlta, DateTime? varFechaAtencion, bool? varStatus, int? varIDSoporte)
        {
            SoporteTranServicio item = new SoporteTranServicio();

            item.Id = varId;

            item.Descripcion = varDescripcion;

            item.IDUser = varIDUser;

            item.FechaAlta = varFechaAlta;

            item.FechaAtencion = varFechaAtencion;

            item.Status = varStatus;

            item.IDSoporte = varIDSoporte;

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



        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn IDUserColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn FechaAltaColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn FechaAtencionColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[5]; }
        }



        public static TableSchema.TableColumn IDSoporteColumn
        {
            get { return Schema.Columns[6]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string Descripcion = @"Descripcion";
            public static string IDUser = @"IDUser";
            public static string FechaAlta = @"FechaAlta";
            public static string FechaAtencion = @"FechaAtencion";
            public static string Status = @"status";
            public static string IDSoporte = @"IDSoporte";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
