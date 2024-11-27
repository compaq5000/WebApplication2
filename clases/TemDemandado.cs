using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the TemDemandado class.
    /// </summary>
    [Serializable]
    public partial class TemDemandadoCollection : ActiveList<TemDemandado, TemDemandadoCollection>
    {
        public TemDemandadoCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TemDemandadoCollection</returns>
        public TemDemandadoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TemDemandado o = this[i];
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
    /// This is an ActiveRecord class which wraps the TemDemandado table.
    /// </summary>
    [Serializable]
    public partial class TemDemandado : ActiveRecord<TemDemandado>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TemDemandado()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public TemDemandado(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TemDemandado(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TemDemandado(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("TemDemandado", TableType.Table, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarExpediente = new TableSchema.TableColumn(schema);
                colvarExpediente.ColumnName = "EXPEDIENTE";
                colvarExpediente.DataType = DbType.String;
                colvarExpediente.MaxLength = 500;
                colvarExpediente.AutoIncrement = false;
                colvarExpediente.IsNullable = true;
                colvarExpediente.IsPrimaryKey = false;
                colvarExpediente.IsForeignKey = false;
                colvarExpediente.IsReadOnly = false;
                colvarExpediente.DefaultSetting = @"";
                colvarExpediente.ForeignKeyTableName = "";
                schema.Columns.Add(colvarExpediente);

                TableSchema.TableColumn colvarIddemandado = new TableSchema.TableColumn(schema);
                colvarIddemandado.ColumnName = "IDDEMANDADO";
                colvarIddemandado.DataType = DbType.Int32;
                colvarIddemandado.MaxLength = 0;
                colvarIddemandado.AutoIncrement = true;
                colvarIddemandado.IsNullable = false;
                colvarIddemandado.IsPrimaryKey = true;
                colvarIddemandado.IsForeignKey = false;
                colvarIddemandado.IsReadOnly = false;
                colvarIddemandado.DefaultSetting = @"";
                colvarIddemandado.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIddemandado);

                TableSchema.TableColumn colvarDemandado = new TableSchema.TableColumn(schema);
                colvarDemandado.ColumnName = "DEMANDADO";
                colvarDemandado.DataType = DbType.String;
                colvarDemandado.MaxLength = 1050;
                colvarDemandado.AutoIncrement = false;
                colvarDemandado.IsNullable = true;
                colvarDemandado.IsPrimaryKey = false;
                colvarDemandado.IsForeignKey = false;
                colvarDemandado.IsReadOnly = false;
                colvarDemandado.DefaultSetting = @"";
                colvarDemandado.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDemandado);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("TemDemandado", schema);
            }
        }
        #endregion

        #region Props

        [XmlAttribute("Expediente")]
        [Bindable(true)]
        public string Expediente
        {
            get { return GetColumnValue<string>(Columns.Expediente); }
            set { SetColumnValue(Columns.Expediente, value); }
        }

        [XmlAttribute("Iddemandado")]
        [Bindable(true)]
        public int Iddemandado
        {
            get { return GetColumnValue<int>(Columns.Iddemandado); }
            set { SetColumnValue(Columns.Iddemandado, value); }
        }

        [XmlAttribute("Demandado")]
        [Bindable(true)]
        public string Demandado
        {
            get { return GetColumnValue<string>(Columns.Demandado); }
            set { SetColumnValue(Columns.Demandado, value); }
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
            return new SubSonicDB.TempExpedienteCollection().Where(TempExpediente.Columns.Iddemandado, Iddemandado).Load();
        }
        #endregion



        //no foreign key tables defined (0)



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varExpediente, string varDemandado)
        {
            TemDemandado item = new TemDemandado();

            item.Expediente = varExpediente;

            item.Demandado = varDemandado;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(string varExpediente, int varIddemandado, string varDemandado)
        {
            TemDemandado item = new TemDemandado();

            item.Expediente = varExpediente;

            item.Iddemandado = varIddemandado;

            item.Demandado = varDemandado;

            item.IsNew = false;
            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }
        #endregion



        #region Typed Columns


        public static TableSchema.TableColumn ExpedienteColumn
        {
            get { return Schema.Columns[0]; }
        }



        public static TableSchema.TableColumn IddemandadoColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn DemandadoColumn
        {
            get { return Schema.Columns[2]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Expediente = @"EXPEDIENTE";
            public static string Iddemandado = @"IDDEMANDADO";
            public static string Demandado = @"DEMANDADO";

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
