using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the Imprimirinsidencia class.
    /// </summary>
    [Serializable]
    public partial class ImprimirinsidenciaCollection : ActiveList<Imprimirinsidencia, ImprimirinsidenciaCollection>
    {
        public ImprimirinsidenciaCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ImprimirinsidenciaCollection</returns>
        public ImprimirinsidenciaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Imprimirinsidencia o = this[i];
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
    /// This is an ActiveRecord class which wraps the imprimirinsidencias table.
    /// </summary>
    [Serializable]
    public partial class Imprimirinsidencia : ActiveRecord<Imprimirinsidencia>, IActiveRecord
    {
        #region .ctors and Default Settings

        public Imprimirinsidencia()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public Imprimirinsidencia(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public Imprimirinsidencia(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public Imprimirinsidencia(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("imprimirinsidencias", TableType.Table, DataService.GetInstance("Default"));
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
                colvarDescripcion.ColumnName = "DESCRIPCION";
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

                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "STATUS";
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

                TableSchema.TableColumn colvarIdadscripcion = new TableSchema.TableColumn(schema);
                colvarIdadscripcion.ColumnName = "IDADSCRIPCION";
                colvarIdadscripcion.DataType = DbType.Int32;
                colvarIdadscripcion.MaxLength = 0;
                colvarIdadscripcion.AutoIncrement = false;
                colvarIdadscripcion.IsNullable = true;
                colvarIdadscripcion.IsPrimaryKey = false;
                colvarIdadscripcion.IsForeignKey = true;
                colvarIdadscripcion.IsReadOnly = false;
                colvarIdadscripcion.DefaultSetting = @"";

                colvarIdadscripcion.ForeignKeyTableName = "CatAdscripcion_RH";
                schema.Columns.Add(colvarIdadscripcion);

                TableSchema.TableColumn colvarRecibo = new TableSchema.TableColumn(schema);
                colvarRecibo.ColumnName = "recibo";
                colvarRecibo.DataType = DbType.Int32;
                colvarRecibo.MaxLength = 0;
                colvarRecibo.AutoIncrement = false;
                colvarRecibo.IsNullable = true;
                colvarRecibo.IsPrimaryKey = false;
                colvarRecibo.IsForeignKey = false;
                colvarRecibo.IsReadOnly = false;
                colvarRecibo.DefaultSetting = @"";
                colvarRecibo.ForeignKeyTableName = "";
                schema.Columns.Add(colvarRecibo);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("imprimirinsidencias", schema);
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

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("Idadscripcion")]
        [Bindable(true)]
        public int? Idadscripcion
        {
            get { return GetColumnValue<int?>(Columns.Idadscripcion); }
            set { SetColumnValue(Columns.Idadscripcion, value); }
        }

        [XmlAttribute("Recibo")]
        [Bindable(true)]
        public int? Recibo
        {
            get { return GetColumnValue<int?>(Columns.Recibo); }
            set { SetColumnValue(Columns.Recibo, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatAdscripcionRh ActiveRecord object related to this Imprimirinsidencia
        /// 
        /// </summary>
        public SubSonicDB.CatAdscripcionRh CatAdscripcionRh
        {
            get { return SubSonicDB.CatAdscripcionRh.FetchByID(this.Idadscripcion); }
            set { SetColumnValue("IDADSCRIPCION", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripcion, bool? varStatus, int? varIdadscripcion, int? varRecibo)
        {
            Imprimirinsidencia item = new Imprimirinsidencia();

            item.Descripcion = varDescripcion;

            item.Status = varStatus;

            item.Idadscripcion = varIdadscripcion;

            item.Recibo = varRecibo;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, string varDescripcion, bool? varStatus, int? varIdadscripcion, int? varRecibo)
        {
            Imprimirinsidencia item = new Imprimirinsidencia();

            item.Id = varId;

            item.Descripcion = varDescripcion;

            item.Status = varStatus;

            item.Idadscripcion = varIdadscripcion;

            item.Recibo = varRecibo;

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



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn IdadscripcionColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn ReciboColumn
        {
            get { return Schema.Columns[4]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string Descripcion = @"DESCRIPCION";
            public static string Status = @"STATUS";
            public static string Idadscripcion = @"IDADSCRIPCION";
            public static string Recibo = @"recibo";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
