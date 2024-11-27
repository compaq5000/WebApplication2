using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the RelEtapasDeExpediente class.
    /// </summary>
    [Serializable]
    public partial class RelEtapasDeExpedienteCollection : ActiveList<RelEtapasDeExpediente, RelEtapasDeExpedienteCollection>
    {
        public RelEtapasDeExpedienteCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelEtapasDeExpedienteCollection</returns>
        public RelEtapasDeExpedienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelEtapasDeExpediente o = this[i];
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
    /// This is an ActiveRecord class which wraps the RelEtapasDeExpediente table.
    /// </summary>
    [Serializable]
    public partial class RelEtapasDeExpediente : ActiveRecord<RelEtapasDeExpediente>, IActiveRecord
    {
        #region .ctors and Default Settings

        public RelEtapasDeExpediente()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public RelEtapasDeExpediente(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public RelEtapasDeExpediente(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public RelEtapasDeExpediente(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("RelEtapasDeExpediente", TableType.Table, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarIDTipoExpediente = new TableSchema.TableColumn(schema);
                colvarIDTipoExpediente.ColumnName = "IDTipoExpediente";
                colvarIDTipoExpediente.DataType = DbType.Int32;
                colvarIDTipoExpediente.MaxLength = 0;
                colvarIDTipoExpediente.AutoIncrement = false;
                colvarIDTipoExpediente.IsNullable = true;
                colvarIDTipoExpediente.IsPrimaryKey = false;
                colvarIDTipoExpediente.IsForeignKey = true;
                colvarIDTipoExpediente.IsReadOnly = false;
                colvarIDTipoExpediente.DefaultSetting = @"";

                colvarIDTipoExpediente.ForeignKeyTableName = "CattipoJuicio";
                schema.Columns.Add(colvarIDTipoExpediente);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 100;
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
                DataService.Providers["Default"].AddSchema("RelEtapasDeExpediente", schema);
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

        [XmlAttribute("IDTipoExpediente")]
        [Bindable(true)]
        public int? IDTipoExpediente
        {
            get { return GetColumnValue<int?>(Columns.IDTipoExpediente); }
            set { SetColumnValue(Columns.IDTipoExpediente, value); }
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


        public SubSonicDB.HistirlaExpedienteCollection HistirlaExpedienteRecords()
        {
            return new SubSonicDB.HistirlaExpedienteCollection().Where(HistirlaExpediente.Columns.IDEtapa, Id).Load();
        }
        #endregion



        #region ForeignKey Properties

        /// <summary>
        /// Returns a CattipoJuicio ActiveRecord object related to this RelEtapasDeExpediente
        /// 
        /// </summary>
        public SubSonicDB.CattipoJuicio CattipoJuicio
        {
            get { return SubSonicDB.CattipoJuicio.FetchByID(this.IDTipoExpediente); }
            set { SetColumnValue("IDTipoExpediente", value.IDTipojuicio); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(int? varIDTipoExpediente, string varDescripcion)
        {
            RelEtapasDeExpediente item = new RelEtapasDeExpediente();

            item.IDTipoExpediente = varIDTipoExpediente;

            item.Descripcion = varDescripcion;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, int? varIDTipoExpediente, string varDescripcion)
        {
            RelEtapasDeExpediente item = new RelEtapasDeExpediente();

            item.Id = varId;

            item.IDTipoExpediente = varIDTipoExpediente;

            item.Descripcion = varDescripcion;

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



        public static TableSchema.TableColumn IDTipoExpedienteColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string IDTipoExpediente = @"IDTipoExpediente";
            public static string Descripcion = @"Descripcion";

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
