using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the HistirlaExpediente class.
    /// </summary>
    [Serializable]
    public partial class HistirlaExpedienteCollection : ActiveList<HistirlaExpediente, HistirlaExpedienteCollection>
    {
        public HistirlaExpedienteCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>HistirlaExpedienteCollection</returns>
        public HistirlaExpedienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                HistirlaExpediente o = this[i];
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
    /// This is an ActiveRecord class which wraps the HistirlaExpediente table.
    /// </summary>
    [Serializable]
    public partial class HistirlaExpediente : ActiveRecord<HistirlaExpediente>, IActiveRecord
    {
        #region .ctors and Default Settings

        public HistirlaExpediente()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public HistirlaExpediente(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public HistirlaExpediente(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public HistirlaExpediente(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("HistirlaExpediente", TableType.Table, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
                colvarIDExpediente.ColumnName = "IDExpediente";
                colvarIDExpediente.DataType = DbType.Int32;
                colvarIDExpediente.MaxLength = 0;
                colvarIDExpediente.AutoIncrement = false;
                colvarIDExpediente.IsNullable = false;
                colvarIDExpediente.IsPrimaryKey = false;
                colvarIDExpediente.IsForeignKey = true;
                colvarIDExpediente.IsReadOnly = false;
                colvarIDExpediente.DefaultSetting = @"";

                colvarIDExpediente.ForeignKeyTableName = "Expedientes";
                schema.Columns.Add(colvarIDExpediente);

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

                TableSchema.TableColumn colvarActualizado = new TableSchema.TableColumn(schema);
                colvarActualizado.ColumnName = "actualizado";
                colvarActualizado.DataType = DbType.DateTime;
                colvarActualizado.MaxLength = 0;
                colvarActualizado.AutoIncrement = false;
                colvarActualizado.IsNullable = true;
                colvarActualizado.IsPrimaryKey = false;
                colvarActualizado.IsForeignKey = false;
                colvarActualizado.IsReadOnly = false;
                colvarActualizado.DefaultSetting = @"";
                colvarActualizado.ForeignKeyTableName = "";
                schema.Columns.Add(colvarActualizado);

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

                TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
                colvarDetalle.ColumnName = "Detalle";
                colvarDetalle.DataType = DbType.AnsiString;
                colvarDetalle.MaxLength = 2147483647;
                colvarDetalle.AutoIncrement = false;
                colvarDetalle.IsNullable = true;
                colvarDetalle.IsPrimaryKey = false;
                colvarDetalle.IsForeignKey = false;
                colvarDetalle.IsReadOnly = false;
                colvarDetalle.DefaultSetting = @"";
                colvarDetalle.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDetalle);

                TableSchema.TableColumn colvarIDEtapa = new TableSchema.TableColumn(schema);
                colvarIDEtapa.ColumnName = "IDEtapa";
                colvarIDEtapa.DataType = DbType.Int32;
                colvarIDEtapa.MaxLength = 0;
                colvarIDEtapa.AutoIncrement = false;
                colvarIDEtapa.IsNullable = true;
                colvarIDEtapa.IsPrimaryKey = false;
                colvarIDEtapa.IsForeignKey = true;
                colvarIDEtapa.IsReadOnly = false;
                colvarIDEtapa.DefaultSetting = @"";

                colvarIDEtapa.ForeignKeyTableName = "RelEtapasDeExpediente";
                schema.Columns.Add(colvarIDEtapa);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("HistirlaExpediente", schema);
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

        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int IDExpediente
        {
            get { return GetColumnValue<int>(Columns.IDExpediente); }
            set { SetColumnValue(Columns.IDExpediente, value); }
        }

        [XmlAttribute("IDUsuario")]
        [Bindable(true)]
        public int? IDUsuario
        {
            get { return GetColumnValue<int?>(Columns.IDUsuario); }
            set { SetColumnValue(Columns.IDUsuario, value); }
        }

        [XmlAttribute("Actualizado")]
        [Bindable(true)]
        public DateTime? Actualizado
        {
            get { return GetColumnValue<DateTime?>(Columns.Actualizado); }
            set { SetColumnValue(Columns.Actualizado, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("Detalle")]
        [Bindable(true)]
        public string Detalle
        {
            get { return GetColumnValue<string>(Columns.Detalle); }
            set { SetColumnValue(Columns.Detalle, value); }
        }

        [XmlAttribute("IDEtapa")]
        [Bindable(true)]
        public int? IDEtapa
        {
            get { return GetColumnValue<int?>(Columns.IDEtapa); }
            set { SetColumnValue(Columns.IDEtapa, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this HistirlaExpediente
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuario
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.IDUsuario); }
            set { SetColumnValue("IDUsuario", value.Id); }
        }


        /// <summary>
        /// Returns a Expediente ActiveRecord object related to this HistirlaExpediente
        /// 
        /// </summary>
        public SubSonicDB.Expediente Expediente
        {
            get { return SubSonicDB.Expediente.FetchByID(this.IDExpediente); }
            set { SetColumnValue("IDExpediente", value.Id); }
        }


        /// <summary>
        /// Returns a RelEtapasDeExpediente ActiveRecord object related to this HistirlaExpediente
        /// 
        /// </summary>
        public SubSonicDB.RelEtapasDeExpediente RelEtapasDeExpediente
        {
            get { return SubSonicDB.RelEtapasDeExpediente.FetchByID(this.IDEtapa); }
            set { SetColumnValue("IDEtapa", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(int varIDExpediente, int? varIDUsuario, DateTime? varActualizado, bool? varStatus, string varDetalle, int? varIDEtapa)
        {
            HistirlaExpediente item = new HistirlaExpediente();

            item.IDExpediente = varIDExpediente;

            item.IDUsuario = varIDUsuario;

            item.Actualizado = varActualizado;

            item.Status = varStatus;

            item.Detalle = varDetalle;

            item.IDEtapa = varIDEtapa;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, int varIDExpediente, int? varIDUsuario, DateTime? varActualizado, bool? varStatus, string varDetalle, int? varIDEtapa)
        {
            HistirlaExpediente item = new HistirlaExpediente();

            item.Id = varId;

            item.IDExpediente = varIDExpediente;

            item.IDUsuario = varIDUsuario;

            item.Actualizado = varActualizado;

            item.Status = varStatus;

            item.Detalle = varDetalle;

            item.IDEtapa = varIDEtapa;

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



        public static TableSchema.TableColumn IDExpedienteColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn IDUsuarioColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn ActualizadoColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn DetalleColumn
        {
            get { return Schema.Columns[5]; }
        }



        public static TableSchema.TableColumn IDEtapaColumn
        {
            get { return Schema.Columns[6]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string IDExpediente = @"IDExpediente";
            public static string IDUsuario = @"IDUsuario";
            public static string Actualizado = @"actualizado";
            public static string Status = @"status";
            public static string Detalle = @"Detalle";
            public static string IDEtapa = @"IDEtapa";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
