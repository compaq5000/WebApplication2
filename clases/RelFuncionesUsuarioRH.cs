using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the RelFuncionesUsuarioRH class.
    /// </summary>
    [Serializable]
    public partial class RelFuncionesUsuarioRHCollection : ActiveList<RelFuncionesUsuarioRH, RelFuncionesUsuarioRHCollection>
    {
        public RelFuncionesUsuarioRHCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelFuncionesUsuarioRHCollection</returns>
        public RelFuncionesUsuarioRHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelFuncionesUsuarioRH o = this[i];
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
    /// This is an ActiveRecord class which wraps the RelFuncionesUsuarioRH table.
    /// </summary>
    [Serializable]
    public partial class RelFuncionesUsuarioRH : ActiveRecord<RelFuncionesUsuarioRH>, IActiveRecord
    {
        #region .ctors and Default Settings

        public RelFuncionesUsuarioRH()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public RelFuncionesUsuarioRH(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public RelFuncionesUsuarioRH(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public RelFuncionesUsuarioRH(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("RelFuncionesUsuarioRH", TableType.Table, DataService.GetInstance("Default"));
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
                colvarDescripcion.MaxLength = 2000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                colvarDescripcion.DefaultSetting = @"";
                colvarDescripcion.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescripcion);

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

                TableSchema.TableColumn colvarIDCategoria = new TableSchema.TableColumn(schema);
                colvarIDCategoria.ColumnName = "IDCategoria";
                colvarIDCategoria.DataType = DbType.Int32;
                colvarIDCategoria.MaxLength = 0;
                colvarIDCategoria.AutoIncrement = false;
                colvarIDCategoria.IsNullable = true;
                colvarIDCategoria.IsPrimaryKey = false;
                colvarIDCategoria.IsForeignKey = false;
                colvarIDCategoria.IsReadOnly = false;
                colvarIDCategoria.DefaultSetting = @"";
                colvarIDCategoria.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIDCategoria);

                TableSchema.TableColumn colvarIDUsuario = new TableSchema.TableColumn(schema);
                colvarIDUsuario.ColumnName = "IDUsuario";
                colvarIDUsuario.DataType = DbType.Int32;
                colvarIDUsuario.MaxLength = 0;
                colvarIDUsuario.AutoIncrement = false;
                colvarIDUsuario.IsNullable = true;
                colvarIDUsuario.IsPrimaryKey = false;
                colvarIDUsuario.IsForeignKey = true;
                colvarIDUsuario.IsReadOnly = false;
                colvarIDUsuario.DefaultSetting = @"";

                colvarIDUsuario.ForeignKeyTableName = "CatUsuarios";
                schema.Columns.Add(colvarIDUsuario);

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
                DataService.Providers["Default"].AddSchema("RelFuncionesUsuarioRH", schema);
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

        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime? Fecha
        {
            get { return GetColumnValue<DateTime?>(Columns.Fecha); }
            set { SetColumnValue(Columns.Fecha, value); }
        }

        [XmlAttribute("IDCategoria")]
        [Bindable(true)]
        public int? IDCategoria
        {
            get { return GetColumnValue<int?>(Columns.IDCategoria); }
            set { SetColumnValue(Columns.IDCategoria, value); }
        }

        [XmlAttribute("IDUsuario")]
        [Bindable(true)]
        public int? IDUsuario
        {
            get { return GetColumnValue<int?>(Columns.IDUsuario); }
            set { SetColumnValue(Columns.IDUsuario, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this RelFuncionesUsuarioRH
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuario
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.IDUsuario); }
            set { SetColumnValue("IDUsuario", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDescripcion, DateTime? varFecha, int? varIDCategoria, int? varIDUsuario, bool? varStatus)
        {
            RelFuncionesUsuarioRH item = new RelFuncionesUsuarioRH();

            item.Descripcion = varDescripcion;

            item.Fecha = varFecha;

            item.IDCategoria = varIDCategoria;

            item.IDUsuario = varIDUsuario;

            item.Status = varStatus;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, string varDescripcion, DateTime? varFecha, int? varIDCategoria, int? varIDUsuario, bool? varStatus)
        {
            RelFuncionesUsuarioRH item = new RelFuncionesUsuarioRH();

            item.Id = varId;

            item.Descripcion = varDescripcion;

            item.Fecha = varFecha;

            item.IDCategoria = varIDCategoria;

            item.IDUsuario = varIDUsuario;

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



        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn IDCategoriaColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn IDUsuarioColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[5]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string Descripcion = @"Descripcion";
            public static string Fecha = @"Fecha";
            public static string IDCategoria = @"IDCategoria";
            public static string IDUsuario = @"IDUsuario";
            public static string Status = @"status";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
