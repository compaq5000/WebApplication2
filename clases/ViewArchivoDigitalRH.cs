using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewArchivoDigitalRH class.
    /// </summary>
    [Serializable]
    public partial class ViewArchivoDigitalRHCollection : ReadOnlyList<ViewArchivoDigitalRH, ViewArchivoDigitalRHCollection>
    {
        public ViewArchivoDigitalRHCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the ViewArchivoDigitalRH view.
    /// </summary>
    [Serializable]
    public partial class ViewArchivoDigitalRH : ReadOnlyRecord<ViewArchivoDigitalRH>, IReadOnlyRecord
    {

        #region Default Settings
        protected static void SetSQLProps()
        {
            GetTableSchema();
        }
        #endregion
        #region Schema Accessor
        public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }

        private static void GetTableSchema()
        {
            if (!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("ViewArchivoDigitalRH", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;

                schema.Columns.Add(colvarId);

                TableSchema.TableColumn colvarIDArcivodigital = new TableSchema.TableColumn(schema);
                colvarIDArcivodigital.ColumnName = "IDArcivodigital";
                colvarIDArcivodigital.DataType = DbType.Int32;
                colvarIDArcivodigital.MaxLength = 0;
                colvarIDArcivodigital.AutoIncrement = false;
                colvarIDArcivodigital.IsNullable = true;
                colvarIDArcivodigital.IsPrimaryKey = false;
                colvarIDArcivodigital.IsForeignKey = false;
                colvarIDArcivodigital.IsReadOnly = false;

                schema.Columns.Add(colvarIDArcivodigital);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 50;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;

                schema.Columns.Add(colvarDescripcion);

                TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
                colvarDetalle.ColumnName = "Detalle";
                colvarDetalle.DataType = DbType.String;
                colvarDetalle.MaxLength = 200;
                colvarDetalle.AutoIncrement = false;
                colvarDetalle.IsNullable = true;
                colvarDetalle.IsPrimaryKey = false;
                colvarDetalle.IsForeignKey = false;
                colvarDetalle.IsReadOnly = false;

                schema.Columns.Add(colvarDetalle);

                TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
                colvarFechaCarga.ColumnName = "FechaCarga";
                colvarFechaCarga.DataType = DbType.DateTime;
                colvarFechaCarga.MaxLength = 0;
                colvarFechaCarga.AutoIncrement = false;
                colvarFechaCarga.IsNullable = true;
                colvarFechaCarga.IsPrimaryKey = false;
                colvarFechaCarga.IsForeignKey = false;
                colvarFechaCarga.IsReadOnly = false;

                schema.Columns.Add(colvarFechaCarga);

                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 650;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;

                schema.Columns.Add(colvarNombre);

                TableSchema.TableColumn colvarIDUasuario = new TableSchema.TableColumn(schema);
                colvarIDUasuario.ColumnName = "IDUasuario";
                colvarIDUasuario.DataType = DbType.Int32;
                colvarIDUasuario.MaxLength = 0;
                colvarIDUasuario.AutoIncrement = false;
                colvarIDUasuario.IsNullable = true;
                colvarIDUasuario.IsPrimaryKey = false;
                colvarIDUasuario.IsForeignKey = false;
                colvarIDUasuario.IsReadOnly = false;

                schema.Columns.Add(colvarIDUasuario);

                TableSchema.TableColumn colvarExtension = new TableSchema.TableColumn(schema);
                colvarExtension.ColumnName = "extension";
                colvarExtension.DataType = DbType.String;
                colvarExtension.MaxLength = 50;
                colvarExtension.AutoIncrement = false;
                colvarExtension.IsNullable = true;
                colvarExtension.IsPrimaryKey = false;
                colvarExtension.IsForeignKey = false;
                colvarExtension.IsReadOnly = false;

                schema.Columns.Add(colvarExtension);

                TableSchema.TableColumn colvarIDArchivo = new TableSchema.TableColumn(schema);
                colvarIDArchivo.ColumnName = "IDArchivo";
                colvarIDArchivo.DataType = DbType.Int32;
                colvarIDArchivo.MaxLength = 0;
                colvarIDArchivo.AutoIncrement = false;
                colvarIDArchivo.IsNullable = false;
                colvarIDArchivo.IsPrimaryKey = false;
                colvarIDArchivo.IsForeignKey = false;
                colvarIDArchivo.IsReadOnly = false;

                schema.Columns.Add(colvarIDArchivo);


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("ViewArchivoDigitalRH", schema);
            }
        }
        #endregion

        #region Query Accessor
        public static Query CreateQuery()
        {
            return new Query(Schema);
        }
        #endregion

        #region .ctors
        public ViewArchivoDigitalRH()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewArchivoDigitalRH(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewArchivoDigitalRH(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewArchivoDigitalRH(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName, columnValue);
        }

        #endregion

        #region Props


        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id
        {
            get
            {
                return GetColumnValue<int>("ID");
            }
            set
            {
                SetColumnValue("ID", value);
            }
        }

        [XmlAttribute("IDArcivodigital")]
        [Bindable(true)]
        public int? IDArcivodigital
        {
            get
            {
                return GetColumnValue<int?>("IDArcivodigital");
            }
            set
            {
                SetColumnValue("IDArcivodigital", value);
            }
        }

        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion
        {
            get
            {
                return GetColumnValue<string>("Descripcion");
            }
            set
            {
                SetColumnValue("Descripcion", value);
            }
        }

        [XmlAttribute("Detalle")]
        [Bindable(true)]
        public string Detalle
        {
            get
            {
                return GetColumnValue<string>("Detalle");
            }
            set
            {
                SetColumnValue("Detalle", value);
            }
        }

        [XmlAttribute("FechaCarga")]
        [Bindable(true)]
        public DateTime? FechaCarga
        {
            get
            {
                return GetColumnValue<DateTime?>("FechaCarga");
            }
            set
            {
                SetColumnValue("FechaCarga", value);
            }
        }

        [XmlAttribute("Nombre")]
        [Bindable(true)]
        public string Nombre
        {
            get
            {
                return GetColumnValue<string>("Nombre");
            }
            set
            {
                SetColumnValue("Nombre", value);
            }
        }

        [XmlAttribute("IDUasuario")]
        [Bindable(true)]
        public int? IDUasuario
        {
            get
            {
                return GetColumnValue<int?>("IDUasuario");
            }
            set
            {
                SetColumnValue("IDUasuario", value);
            }
        }

        [XmlAttribute("Extension")]
        [Bindable(true)]
        public string Extension
        {
            get
            {
                return GetColumnValue<string>("extension");
            }
            set
            {
                SetColumnValue("extension", value);
            }
        }

        [XmlAttribute("IDArchivo")]
        [Bindable(true)]
        public int IDArchivo
        {
            get
            {
                return GetColumnValue<int>("IDArchivo");
            }
            set
            {
                SetColumnValue("IDArchivo", value);
            }
        }

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string Id = @"ID";

            public static string IDArcivodigital = @"IDArcivodigital";

            public static string Descripcion = @"Descripcion";

            public static string Detalle = @"Detalle";

            public static string FechaCarga = @"FechaCarga";

            public static string Nombre = @"Nombre";

            public static string IDUasuario = @"IDUasuario";

            public static string Extension = @"extension";

            public static string IDArchivo = @"IDArchivo";

        }
        #endregion


        #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName)
        {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName)
        {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion

    }
}
