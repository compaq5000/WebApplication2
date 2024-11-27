using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the CatRHTipoInsidencium class.
    /// </summary>
    [Serializable]
    public partial class CatRHTipoInsidenciumCollection : ActiveList<CatRHTipoInsidencium, CatRHTipoInsidenciumCollection>
    {
        public CatRHTipoInsidenciumCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatRHTipoInsidenciumCollection</returns>
        public CatRHTipoInsidenciumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatRHTipoInsidencium o = this[i];
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
    /// This is an ActiveRecord class which wraps the CatRHTipoInsidencia table.
    /// </summary>
    [Serializable]
    public partial class CatRHTipoInsidencium : ActiveRecord<CatRHTipoInsidencium>, IActiveRecord
    {
        #region .ctors and Default Settings

        public CatRHTipoInsidencium()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public CatRHTipoInsidencium(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public CatRHTipoInsidencium(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public CatRHTipoInsidencium(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("CatRHTipoInsidencia", TableType.Table, DataService.GetInstance("Default"));
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

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("CatRHTipoInsidencia", schema);
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

        #endregion


        #region PrimaryKey Methods		

        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);

            SetPKValues();
        }


        public SubSonicDB.TranInsidenciasRHCollection TranInsidenciasRHRecords()
        {
            return new SubSonicDB.TranInsidenciasRHCollection().Where(TranInsidenciasRH.Columns.Idtipoinsid, Id).Load();
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
            CatRHTipoInsidencium item = new CatRHTipoInsidencium();

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
        public static void Update(int varId, string varDescripcion, bool? varStatus)
        {
            CatRHTipoInsidencium item = new CatRHTipoInsidencium();

            item.Id = varId;

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



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string Descripcion = @"DESCRIPCION";
            public static string Status = @"STATUS";

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
