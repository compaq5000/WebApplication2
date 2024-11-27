using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the CattipoJuicio class.
    /// </summary>
    [Serializable]
    public partial class CattipoJuicioCollection : ActiveList<CattipoJuicio, CattipoJuicioCollection>
    {
        public CattipoJuicioCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CattipoJuicioCollection</returns>
        public CattipoJuicioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CattipoJuicio o = this[i];
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
    /// This is an ActiveRecord class which wraps the CattipoJuicio table.
    /// </summary>
    [Serializable]
    public partial class CattipoJuicio : ActiveRecord<CattipoJuicio>, IActiveRecord
    {
        #region .ctors and Default Settings

        public CattipoJuicio()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public CattipoJuicio(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public CattipoJuicio(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public CattipoJuicio(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("CattipoJuicio", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarIDTipojuicio = new TableSchema.TableColumn(schema);
                colvarIDTipojuicio.ColumnName = "IDTipojuicio";
                colvarIDTipojuicio.DataType = DbType.Int32;
                colvarIDTipojuicio.MaxLength = 0;
                colvarIDTipojuicio.AutoIncrement = true;
                colvarIDTipojuicio.IsNullable = false;
                colvarIDTipojuicio.IsPrimaryKey = true;
                colvarIDTipojuicio.IsForeignKey = false;
                colvarIDTipojuicio.IsReadOnly = false;
                colvarIDTipojuicio.DefaultSetting = @"";
                colvarIDTipojuicio.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIDTipojuicio);

                TableSchema.TableColumn colvarDescripocion = new TableSchema.TableColumn(schema);
                colvarDescripocion.ColumnName = "descripocion";
                colvarDescripocion.DataType = DbType.String;
                colvarDescripocion.MaxLength = 500;
                colvarDescripocion.AutoIncrement = false;
                colvarDescripocion.IsNullable = true;
                colvarDescripocion.IsPrimaryKey = false;
                colvarDescripocion.IsForeignKey = false;
                colvarDescripocion.IsReadOnly = false;
                colvarDescripocion.DefaultSetting = @"";
                colvarDescripocion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripocion);

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
                DataService.Providers["Default"].AddSchema("CattipoJuicio", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("IDTipojuicio")]
        [Bindable(true)]
        public int IDTipojuicio
        {
            get { return GetColumnValue<int>(Columns.IDTipojuicio); }
            set { SetColumnValue(Columns.IDTipojuicio, value); }
        }

        [XmlAttribute("Descripocion")]
        [Bindable(true)]
        public string Descripocion
        {
            get { return GetColumnValue<string>(Columns.Descripocion); }
            set { SetColumnValue(Columns.Descripocion, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        #endregion


        #region PrimaryKey Methods		

        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);

            SetPKValues();
        }


        public SubSonicDB.RelEtapasDeExpedienteCollection RelEtapasDeExpedienteRecords()
        {
            return new SubSonicDB.RelEtapasDeExpedienteCollection().Where(RelEtapasDeExpediente.Columns.IDTipoExpediente, IDTipojuicio).Load();
        }
        #endregion



        //no foreign key tables defined (0)



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripocion, bool? varStatus)
        {
            CattipoJuicio item = new CattipoJuicio();

            item.Descripocion = varDescripocion;

            item.Status = varStatus;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varIDTipojuicio, string varDescripocion, bool? varStatus)
        {
            CattipoJuicio item = new CattipoJuicio();

            item.IDTipojuicio = varIDTipojuicio;

            item.Descripocion = varDescripocion;

            item.Status = varStatus;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn IDTipojuicioColumn
        {
            get { return Schema.Columns[0]; }
        }



        public static TableSchema.TableColumn DescripocionColumn
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
            public static string IDTipojuicio = @"IDTipojuicio";
            public static string Descripocion = @"descripocion";
            public static string Status = @"status";

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
