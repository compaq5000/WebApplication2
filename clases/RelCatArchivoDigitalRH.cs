using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the RelCatArchivoDigitalRH class.
    /// </summary>
    [Serializable]
    public partial class RelCatArchivoDigitalRHCollection : ActiveList<RelCatArchivoDigitalRH, RelCatArchivoDigitalRHCollection>
    {
        public RelCatArchivoDigitalRHCollection() { }

        /// <summary>
        /// Filters an existing collection based on the set criteria. This is an in-memory filter
        /// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelCatArchivoDigitalRHCollection</returns>
        public RelCatArchivoDigitalRHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelCatArchivoDigitalRH o = this[i];
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
    /// This is an ActiveRecord class which wraps the RelCatArchivoDigitalRH table.
    /// </summary>
    [Serializable]
    public partial class RelCatArchivoDigitalRH : ActiveRecord<RelCatArchivoDigitalRH>, IActiveRecord
    {
        #region .ctors and Default Settings

        public RelCatArchivoDigitalRH()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        private void InitSetDefaults() { SetDefaults(); }

        public RelCatArchivoDigitalRH(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public RelCatArchivoDigitalRH(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public RelCatArchivoDigitalRH(string columnName, object columnValue)
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
                TableSchema.Table schema = new TableSchema.Table("RelCatArchivoDigitalRH", TableType.Table, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarIDArcivodigital = new TableSchema.TableColumn(schema);
                colvarIDArcivodigital.ColumnName = "IDArcivodigital";
                colvarIDArcivodigital.DataType = DbType.Int32;
                colvarIDArcivodigital.MaxLength = 0;
                colvarIDArcivodigital.AutoIncrement = false;
                colvarIDArcivodigital.IsNullable = true;
                colvarIDArcivodigital.IsPrimaryKey = false;
                colvarIDArcivodigital.IsForeignKey = true;
                colvarIDArcivodigital.IsReadOnly = false;
                colvarIDArcivodigital.DefaultSetting = @"";

                colvarIDArcivodigital.ForeignKeyTableName = "CatArchivoDigital_RH";
                schema.Columns.Add(colvarIDArcivodigital);

                TableSchema.TableColumn colvarIDUasuario = new TableSchema.TableColumn(schema);
                colvarIDUasuario.ColumnName = "IDUasuario";
                colvarIDUasuario.DataType = DbType.Int32;
                colvarIDUasuario.MaxLength = 0;
                colvarIDUasuario.AutoIncrement = false;
                colvarIDUasuario.IsNullable = true;
                colvarIDUasuario.IsPrimaryKey = false;
                colvarIDUasuario.IsForeignKey = true;
                colvarIDUasuario.IsReadOnly = false;
                colvarIDUasuario.DefaultSetting = @"";

                colvarIDUasuario.ForeignKeyTableName = "CatUsuarios";
                schema.Columns.Add(colvarIDUasuario);

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

                TableSchema.TableColumn colvarExtension = new TableSchema.TableColumn(schema);
                colvarExtension.ColumnName = "extension";
                colvarExtension.DataType = DbType.String;
                colvarExtension.MaxLength = 50;
                colvarExtension.AutoIncrement = false;
                colvarExtension.IsNullable = true;
                colvarExtension.IsPrimaryKey = false;
                colvarExtension.IsForeignKey = false;
                colvarExtension.IsReadOnly = false;
                colvarExtension.DefaultSetting = @"";
                colvarExtension.ForeignKeyTableName = "";
                schema.Columns.Add(colvarExtension);

                TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
                colvarFechaCarga.ColumnName = "FechaCarga";
                colvarFechaCarga.DataType = DbType.DateTime;
                colvarFechaCarga.MaxLength = 0;
                colvarFechaCarga.AutoIncrement = false;
                colvarFechaCarga.IsNullable = true;
                colvarFechaCarga.IsPrimaryKey = false;
                colvarFechaCarga.IsForeignKey = false;
                colvarFechaCarga.IsReadOnly = false;
                colvarFechaCarga.DefaultSetting = @"";
                colvarFechaCarga.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFechaCarga);

                TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
                colvarDetalle.ColumnName = "Detalle";
                colvarDetalle.DataType = DbType.String;
                colvarDetalle.MaxLength = 200;
                colvarDetalle.AutoIncrement = false;
                colvarDetalle.IsNullable = true;
                colvarDetalle.IsPrimaryKey = false;
                colvarDetalle.IsForeignKey = false;
                colvarDetalle.IsReadOnly = false;
                colvarDetalle.DefaultSetting = @"";
                colvarDetalle.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDetalle);

                TableSchema.TableColumn colvarCargadoPor = new TableSchema.TableColumn(schema);
                colvarCargadoPor.ColumnName = "CargadoPor";
                colvarCargadoPor.DataType = DbType.Int32;
                colvarCargadoPor.MaxLength = 0;
                colvarCargadoPor.AutoIncrement = false;
                colvarCargadoPor.IsNullable = true;
                colvarCargadoPor.IsPrimaryKey = false;
                colvarCargadoPor.IsForeignKey = true;
                colvarCargadoPor.IsReadOnly = false;
                colvarCargadoPor.DefaultSetting = @"";

                colvarCargadoPor.ForeignKeyTableName = "CatUsuarios";
                schema.Columns.Add(colvarCargadoPor);

                TableSchema.TableColumn colvarNombreArchivo = new TableSchema.TableColumn(schema);
                colvarNombreArchivo.ColumnName = "NombreArchivo";
                colvarNombreArchivo.DataType = DbType.String;
                colvarNombreArchivo.MaxLength = 500;
                colvarNombreArchivo.AutoIncrement = false;
                colvarNombreArchivo.IsNullable = true;
                colvarNombreArchivo.IsPrimaryKey = false;
                colvarNombreArchivo.IsForeignKey = false;
                colvarNombreArchivo.IsReadOnly = false;
                colvarNombreArchivo.DefaultSetting = @"";
                colvarNombreArchivo.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNombreArchivo);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("RelCatArchivoDigitalRH", schema);
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

        [XmlAttribute("IDArcivodigital")]
        [Bindable(true)]
        public int? IDArcivodigital
        {
            get { return GetColumnValue<int?>(Columns.IDArcivodigital); }
            set { SetColumnValue(Columns.IDArcivodigital, value); }
        }

        [XmlAttribute("IDUasuario")]
        [Bindable(true)]
        public int? IDUasuario
        {
            get { return GetColumnValue<int?>(Columns.IDUasuario); }
            set { SetColumnValue(Columns.IDUasuario, value); }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get { return GetColumnValue<bool?>(Columns.Status); }
            set { SetColumnValue(Columns.Status, value); }
        }

        [XmlAttribute("Extension")]
        [Bindable(true)]
        public string Extension
        {
            get { return GetColumnValue<string>(Columns.Extension); }
            set { SetColumnValue(Columns.Extension, value); }
        }

        [XmlAttribute("FechaCarga")]
        [Bindable(true)]
        public DateTime? FechaCarga
        {
            get { return GetColumnValue<DateTime?>(Columns.FechaCarga); }
            set { SetColumnValue(Columns.FechaCarga, value); }
        }

        [XmlAttribute("Detalle")]
        [Bindable(true)]
        public string Detalle
        {
            get { return GetColumnValue<string>(Columns.Detalle); }
            set { SetColumnValue(Columns.Detalle, value); }
        }

        [XmlAttribute("CargadoPor")]
        [Bindable(true)]
        public int? CargadoPor
        {
            get { return GetColumnValue<int?>(Columns.CargadoPor); }
            set { SetColumnValue(Columns.CargadoPor, value); }
        }

        [XmlAttribute("NombreArchivo")]
        [Bindable(true)]
        public string NombreArchivo
        {
            get { return GetColumnValue<string>(Columns.NombreArchivo); }
            set { SetColumnValue(Columns.NombreArchivo, value); }
        }

        #endregion




        #region ForeignKey Properties

        /// <summary>
        /// Returns a CatArchivoDigitalRh ActiveRecord object related to this RelCatArchivoDigitalRH
        /// 
        /// </summary>
        public SubSonicDB.CatArchivoDigitalRh CatArchivoDigitalRh
        {
            get { return SubSonicDB.CatArchivoDigitalRh.FetchByID(this.IDArcivodigital); }
            set { SetColumnValue("IDArcivodigital", value.Id); }
        }


        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this RelCatArchivoDigitalRH
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuario
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.IDUasuario); }
            set { SetColumnValue("IDUasuario", value.Id); }
        }


        /// <summary>
        /// Returns a CatUsuario ActiveRecord object related to this RelCatArchivoDigitalRH
        /// 
        /// </summary>
        public SubSonicDB.CatUsuario CatUsuarioToCargadoPor
        {
            get { return SubSonicDB.CatUsuario.FetchByID(this.CargadoPor); }
            set { SetColumnValue("CargadoPor", value.Id); }
        }


        #endregion



        //no ManyToMany tables defined (0)



        #region ObjectDataSource support


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(int? varIDArcivodigital, int? varIDUasuario, bool? varStatus, string varExtension, DateTime? varFechaCarga, string varDetalle, int? varCargadoPor, string varNombreArchivo)
        {
            RelCatArchivoDigitalRH item = new RelCatArchivoDigitalRH();

            item.IDArcivodigital = varIDArcivodigital;

            item.IDUasuario = varIDUasuario;

            item.Status = varStatus;

            item.Extension = varExtension;

            item.FechaCarga = varFechaCarga;

            item.Detalle = varDetalle;

            item.CargadoPor = varCargadoPor;

            item.NombreArchivo = varNombreArchivo;


            if (System.Web.HttpContext.Current != null)
                item.Save(System.Web.HttpContext.Current.User.Identity.Name);
            else
                item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, int? varIDArcivodigital, int? varIDUasuario, bool? varStatus, string varExtension, DateTime? varFechaCarga, string varDetalle, int? varCargadoPor, string varNombreArchivo)
        {
            RelCatArchivoDigitalRH item = new RelCatArchivoDigitalRH();

            item.Id = varId;

            item.IDArcivodigital = varIDArcivodigital;

            item.IDUasuario = varIDUasuario;

            item.Status = varStatus;

            item.Extension = varExtension;

            item.FechaCarga = varFechaCarga;

            item.Detalle = varDetalle;

            item.CargadoPor = varCargadoPor;

            item.NombreArchivo = varNombreArchivo;

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



        public static TableSchema.TableColumn IDArcivodigitalColumn
        {
            get { return Schema.Columns[1]; }
        }



        public static TableSchema.TableColumn IDUasuarioColumn
        {
            get { return Schema.Columns[2]; }
        }



        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[3]; }
        }



        public static TableSchema.TableColumn ExtensionColumn
        {
            get { return Schema.Columns[4]; }
        }



        public static TableSchema.TableColumn FechaCargaColumn
        {
            get { return Schema.Columns[5]; }
        }



        public static TableSchema.TableColumn DetalleColumn
        {
            get { return Schema.Columns[6]; }
        }



        public static TableSchema.TableColumn CargadoPorColumn
        {
            get { return Schema.Columns[7]; }
        }



        public static TableSchema.TableColumn NombreArchivoColumn
        {
            get { return Schema.Columns[8]; }
        }



        #endregion
        #region Columns Struct
        public struct Columns
        {
            public static string Id = @"ID";
            public static string IDArcivodigital = @"IDArcivodigital";
            public static string IDUasuario = @"IDUasuario";
            public static string Status = @"STATUS";
            public static string Extension = @"extension";
            public static string FechaCarga = @"FechaCarga";
            public static string Detalle = @"Detalle";
            public static string CargadoPor = @"CargadoPor";
            public static string NombreArchivo = @"NombreArchivo";

        }
        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion
    }
}
