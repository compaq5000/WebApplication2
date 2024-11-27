using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the CatTipoExpediente class.
    /// </summary>
    [Serializable]
    public partial class CatTipoExpedienteCollection : ActiveList<CatTipoExpediente, CatTipoExpedienteCollection>
    {
        public CatTipoExpedienteCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatTipoExpedienteCollection</returns>
        public CatTipoExpedienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatTipoExpediente o = this[i];
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
    /// This is an ActiveRecord class which wraps the CatTipoExpediente table.
    /// </summary>
    [Serializable]
    public partial class CatTipoExpediente : ActiveRecord<CatTipoExpediente>, IActiveRecord
    {
        #region .ctors and Default Settings

        public CatTipoExpediente()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public CatTipoExpediente(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public CatTipoExpediente(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public CatTipoExpediente(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("CatTipoExpediente", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarIDTipoExpediente = new TableSchema.TableColumn(schema);
                colvarIDTipoExpediente.ColumnName = "IDTipoExpediente";
                colvarIDTipoExpediente.DataType = DbType.Int32;
                colvarIDTipoExpediente.MaxLength = 0;
                colvarIDTipoExpediente.AutoIncrement = true;
                colvarIDTipoExpediente.IsNullable = false;
                colvarIDTipoExpediente.IsPrimaryKey = true;
                colvarIDTipoExpediente.IsForeignKey = false;
                colvarIDTipoExpediente.IsReadOnly = false;
                colvarIDTipoExpediente.DefaultSetting = @"";
                colvarIDTipoExpediente.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIDTipoExpediente);

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
                DataService.Providers["Default"].AddSchema("CatTipoExpediente", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("IDTipoExpediente")]
        [Bindable(true)]
        public int IDTipoExpediente
        {
            get { return GetColumnValue<int>(Columns.IDTipoExpediente); }
            set { SetColumnValue(Columns.IDTipoExpediente, value); }
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

        #endregion




        //no foreign key tables defined (0)



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripcion, bool? varStatus)
        {
            CatTipoExpediente item = new CatTipoExpediente();

            item.Descripcion = varDescripcion;

            item.Status = varStatus;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varIDTipoExpediente, string varDescripcion, bool? varStatus)
        {
            CatTipoExpediente item = new CatTipoExpediente();

            item.IDTipoExpediente = varIDTipoExpediente;

            item.Descripcion = varDescripcion;

            item.Status = varStatus;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn IDTipoExpedienteColumn
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



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string IDTipoExpediente = @"IDTipoExpediente";
            public static string Descripcion = @"Descripcion";
            public static string Status = @"status";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
