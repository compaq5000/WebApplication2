using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the TemAutoridad class.
    /// </summary>
    [Serializable]
    public partial class TemAutoridadCollection : ActiveList<TemAutoridad, TemAutoridadCollection>
    {
        public TemAutoridadCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TemAutoridadCollection</returns>
        public TemAutoridadCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TemAutoridad o = this[i];
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
    /// This is an ActiveRecord class which wraps the TemAutoridad table.
    /// </summary>
    [Serializable]
    public partial class TemAutoridad : ActiveRecord<TemAutoridad>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TemAutoridad()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public TemAutoridad(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TemAutoridad(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TemAutoridad(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("TemAutoridad", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarIdautoridad = new TableSchema.TableColumn(schema);
                colvarIdautoridad.ColumnName = "IDAUTORIDAD";
                colvarIdautoridad.DataType = DbType.Int32;
                colvarIdautoridad.MaxLength = 0;
                colvarIdautoridad.AutoIncrement = true;
                colvarIdautoridad.IsNullable = false;
                colvarIdautoridad.IsPrimaryKey = true;
                colvarIdautoridad.IsForeignKey = false;
                colvarIdautoridad.IsReadOnly = false;
                colvarIdautoridad.DefaultSetting = @"";
                colvarIdautoridad.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIdautoridad);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "DESCRIPCION";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 2500;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                colvarDescripcion.DefaultSetting = @"";
                colvarDescripcion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripcion);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("TemAutoridad", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("Idautoridad")]
        [Bindable(true)]
        public int Idautoridad
        {
            get { return GetColumnValue<int>(Columns.Idautoridad); }
            set { SetColumnValue(Columns.Idautoridad, value); }
        }

        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion
        {
            get { return GetColumnValue<string>(Columns.Descripcion); }
            set { SetColumnValue(Columns.Descripcion, value); }
        }

        #endregion


        #region PrimaryKey Methods		

        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);

            SetPKValues();
        }


        public SubSonicDB.TempExpedienteCollection TempExpedientes()
        {
            return new SubSonicDB.TempExpedienteCollection().Where(TempExpediente.Columns.Idautoridadconocecaso, Idautoridad).Load();
        }
        #endregion



        //no foreign key tables defined (0)



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripcion)
        {
            TemAutoridad item = new TemAutoridad();

            item.Descripcion = varDescripcion;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varIdautoridad, string varDescripcion)
        {
            TemAutoridad item = new TemAutoridad();

            item.Idautoridad = varIdautoridad;

            item.Descripcion = varDescripcion;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn IdautoridadColumn
        {
            get { return Schema.Columns[0]; }
        }



        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Idautoridad = @"IDAUTORIDAD";
            public static string Descripcion = @"DESCRIPCION";

        }
        #endregion

        #region Update PK Collections

        public void SetPKValues()
        {
        }
        #endregion

        #region Deep Save

        public void DeepSave()
        {
            Save();

        }
        #endregion
    }
}
