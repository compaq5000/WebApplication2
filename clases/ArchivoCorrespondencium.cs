using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ArchivoCorrespondencium class.
    /// </summary>
    [Serializable]
    public partial class ArchivoCorrespondenciumCollection : ActiveList<ArchivoCorrespondencium, ArchivoCorrespondenciumCollection>
    {
        public ArchivoCorrespondenciumCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ArchivoCorrespondenciumCollection</returns>
        public ArchivoCorrespondenciumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ArchivoCorrespondencium o = this[i];
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
    /// This is an ActiveRecord class which wraps the ArchivoCorrespondencia table.
    /// </summary>
    [Serializable]
    public partial class ArchivoCorrespondencium : ActiveRecord<ArchivoCorrespondencium>, IActiveRecord
    {
        #region .ctors and Default Settings

        public ArchivoCorrespondencium()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public ArchivoCorrespondencium(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public ArchivoCorrespondencium(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public ArchivoCorrespondencium(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("ArchivoCorrespondencia", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 500;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                colvarNombre.DefaultSetting = @"";
                colvarNombre.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNombre);

                TableSchema.TableColumn colvarExtencion = new TableSchema.TableColumn(schema);
                colvarExtencion.ColumnName = "Extencion";
                colvarExtencion.DataType = DbType.String;
                colvarExtencion.MaxLength = 5;
                colvarExtencion.AutoIncrement = false;
                colvarExtencion.IsNullable = false;
                colvarExtencion.IsPrimaryKey = false;
                colvarExtencion.IsForeignKey = false;
                colvarExtencion.IsReadOnly = false;
                colvarExtencion.DefaultSetting = @"";
                colvarExtencion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarExtencion);

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

                TableSchema.TableColumn colvarDateX = new TableSchema.TableColumn(schema);
                colvarDateX.ColumnName = "Date";
                colvarDateX.DataType = DbType.DateTime;
                colvarDateX.MaxLength = 0;
                colvarDateX.AutoIncrement = false;
                colvarDateX.IsNullable = true;
                colvarDateX.IsPrimaryKey = false;
                colvarDateX.IsForeignKey = false;
                colvarDateX.IsReadOnly = false;
                colvarDateX.DefaultSetting = @"";
                colvarDateX.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDateX);

                TableSchema.TableColumn colvarIDTipo = new TableSchema.TableColumn(schema);
                colvarIDTipo.ColumnName = "IDTipo";
                colvarIDTipo.DataType = DbType.Int32;
                colvarIDTipo.MaxLength = 0;
                colvarIDTipo.AutoIncrement = false;
                colvarIDTipo.IsNullable = true;
                colvarIDTipo.IsPrimaryKey = false;
                colvarIDTipo.IsForeignKey = true;
                colvarIDTipo.IsReadOnly = false;
                colvarIDTipo.DefaultSetting = @"";

                colvarIDTipo.ForeignKeyTableName = "CorresCatTipoArchivo";
                schema.Columns.Add(colvarIDTipo);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 4000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                colvarDescripcion.DefaultSetting = @"";
                colvarDescripcion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripcion);

                TableSchema.TableColumn colvarIDUserCarga = new TableSchema.TableColumn(schema);
                colvarIDUserCarga.ColumnName = "IDUserCarga";
                colvarIDUserCarga.DataType = DbType.Int32;
                colvarIDUserCarga.MaxLength = 0;
                colvarIDUserCarga.AutoIncrement = false;
                colvarIDUserCarga.IsNullable = true;
                colvarIDUserCarga.IsPrimaryKey = false;
                colvarIDUserCarga.IsForeignKey = false;
                colvarIDUserCarga.IsReadOnly = false;
                colvarIDUserCarga.DefaultSetting = @"";
                colvarIDUserCarga.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIDUserCarga);

                TableSchema.TableColumn colvarStatusCorresponde = new TableSchema.TableColumn(schema);
                colvarStatusCorresponde.ColumnName = "StatusCorresponde";
                colvarStatusCorresponde.DataType = DbType.Boolean;
                colvarStatusCorresponde.MaxLength = 0;
                colvarStatusCorresponde.AutoIncrement = false;
                colvarStatusCorresponde.IsNullable = true;
                colvarStatusCorresponde.IsPrimaryKey = false;
                colvarStatusCorresponde.IsForeignKey = false;
                colvarStatusCorresponde.IsReadOnly = false;
                colvarStatusCorresponde.DefaultSetting = @"";
                colvarStatusCorresponde.ForeignKeyTableName = "";
                schema.Columns.Add(colvarStatusCorresponde);

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

                TableSchema.TableColumn colvarIDInventario = new TableSchema.TableColumn(schema);
                colvarIDInventario.ColumnName = "IDInventario";
                colvarIDInventario.DataType = DbType.Int32;
                colvarIDInventario.MaxLength = 0;
                colvarIDInventario.AutoIncrement = false;
                colvarIDInventario.IsNullable = true;
                colvarIDInventario.IsPrimaryKey = false;
                colvarIDInventario.IsForeignKey = true;
                colvarIDInventario.IsReadOnly = false;
                colvarIDInventario.DefaultSetting = @"";

                colvarIDInventario.ForeignKeyTableName = "CatTipoArchivo__Inventarios";
                schema.Columns.Add(colvarIDInventario);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("ArchivoCorrespondencia", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("Nombre")]
        [Bindable(true)]
        public string Nombre
        {
            get { return GetColumnValue<string>(Columns.Nombre); }
            set { SetColumnValue(Columns.Nombre, value); }
        }

        [XmlAttribute("Extencion")]
        [Bindable(true)]
        public string Extencion
        {
            get { return GetColumnValue<string>(Columns.Extencion); }
            set { SetColumnValue(Columns.Extencion, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int? IDExpediente
        {
            get { return GetColumnValue<int?>(Columns.IDExpediente); }
            set { SetColumnValue(Columns.IDExpediente, value); }
        }

        [XmlAttribute("DateX")]
        [Bindable(true)]
        public DateTime? DateX
        {
            get { return GetColumnValue<DateTime?>(Columns.DateX); }
            set { SetColumnValue(Columns.DateX, value); }
        }

        [XmlAttribute("IDTipo")]
        [Bindable(true)]
        public int? IDTipo
        {
            get { return GetColumnValue<int?>(Columns.IDTipo); }
            set { SetColumnValue(Columns.IDTipo, value); }
        }

        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion
        {
            get { return GetColumnValue<string>(Columns.Descripcion); }
            set { SetColumnValue(Columns.Descripcion, value); }
        }

        [XmlAttribute("IDUserCarga")]
        [Bindable(true)]
        public int? IDUserCarga
        {
            get { return GetColumnValue<int?>(Columns.IDUserCarga); }
            set { SetColumnValue(Columns.IDUserCarga, value); }
        }

        [XmlAttribute("StatusCorresponde")]
        [Bindable(true)]
        public bool? StatusCorresponde
        {
            get { return GetColumnValue<bool?>(Columns.StatusCorresponde); }
            set { SetColumnValue(Columns.StatusCorresponde, value); }
        }

        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id
        {
            get { return GetColumnValue<int>(Columns.Id); }
            set { SetColumnValue(Columns.Id, value); }
        }

        [XmlAttribute("IDInventario")]
        [Bindable(true)]
        public int? IDInventario
        {
            get { return GetColumnValue<int?>(Columns.IDInventario); }
            set { SetColumnValue(Columns.IDInventario, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatTipoArchivoInventario ActiveRecord object related to this ArchivoCorrespondencium
        /// 
        /// </summary>
        public SubSonicDB.CatTipoArchivoInventario CatTipoArchivoInventario
        {
            get { return SubSonicDB.CatTipoArchivoInventario.FetchByID(this.IDInventario); }
            set { SetColumnValue("IDInventario", value.Id); }
        }


        /// <summary>
        /// Returns a CorresCatTipoArchivo ActiveRecord object related to this ArchivoCorrespondencium
        /// 
        /// </summary>
        public SubSonicDB.CorresCatTipoArchivo CorresCatTipoArchivo
        {
            get { return SubSonicDB.CorresCatTipoArchivo.FetchByID(this.IDTipo); }
            set { SetColumnValue("IDTipo", value.Id); }
        }


        /// <summary>
        /// Returns a Expediente ActiveRecord object related to this ArchivoCorrespondencium
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
        public static void Insert(string varNombre, string varExtencion, bool? varStatus, int? varIDExpediente, DateTime? varDateX, int? varIDTipo, string varDescripcion, int? varIDUserCarga, bool? varStatusCorresponde, int? varIDInventario)
        {
            ArchivoCorrespondencium item = new ArchivoCorrespondencium();

            item.Nombre = varNombre;

            item.Extencion = varExtencion;

            item.Status = varStatus;

            item.IDExpediente = varIDExpediente;

            item.DateX = varDateX;

            item.IDTipo = varIDTipo;

            item.Descripcion = varDescripcion;

            item.IDUserCarga = varIDUserCarga;

            item.StatusCorresponde = varStatusCorresponde;

            item.IDInventario = varIDInventario;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(string varNombre, string varExtencion, bool? varStatus, int? varIDExpediente, DateTime? varDateX, int? varIDTipo, string varDescripcion, int? varIDUserCarga, bool? varStatusCorresponde, int varId, int? varIDInventario)
        {
            ArchivoCorrespondencium item = new ArchivoCorrespondencium();

            item.Nombre = varNombre;

            item.Extencion = varExtencion;

            item.Status = varStatus;

            item.IDExpediente = varIDExpediente;

            item.DateX = varDateX;

            item.IDTipo = varIDTipo;

            item.Descripcion = varDescripcion;

            item.IDUserCarga = varIDUserCarga;

            item.StatusCorresponde = varStatusCorresponde;

            item.Id = varId;

            item.IDInventario = varIDInventario;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[0]; }
        }



        public static TableSchema.TableColumn ExtencionColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn IDExpedienteColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn DateXColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn IDTipoColumn
        {
            get { return Schema.Columns[5]; }
        }



        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[6]; }
        }



        public static TableSchema.TableColumn IDUserCargaColumn
        {
            get { return Schema.Columns[7]; }
        }



        public static TableSchema.TableColumn StatusCorrespondeColumn
        {
            get { return Schema.Columns[8]; }
        }



        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[9]; }
        }



        public static TableSchema.TableColumn IDInventarioColumn
        {
            get { return Schema.Columns[10]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Nombre = @"Nombre";
            public static string Extencion = @"Extencion";
            public static string Status = @"status";
            public static string IDExpediente = @"IDExpediente";
            public static string DateX = @"Date";
            public static string IDTipo = @"IDTipo";
            public static string Descripcion = @"Descripcion";
            public static string IDUserCarga = @"IDUserCarga";
            public static string StatusCorresponde = @"StatusCorresponde";
            public static string Id = @"ID";
            public static string IDInventario = @"IDInventario";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
