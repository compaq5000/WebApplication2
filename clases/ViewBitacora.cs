using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewBitacora class.
    /// </summary>
    [Serializable]
    public partial class ViewBitacoraCollection : ReadOnlyList<ViewBitacora, ViewBitacoraCollection>
    {
        public ViewBitacoraCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the ViewBitacora view.
    /// </summary>
    [Serializable]
    public partial class ViewBitacora : ReadOnlyRecord<ViewBitacora>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("ViewBitacora", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

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

                TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
                colvarFecha.ColumnName = "Fecha";
                colvarFecha.DataType = DbType.DateTime;
                colvarFecha.MaxLength = 0;
                colvarFecha.AutoIncrement = false;
                colvarFecha.IsNullable = true;
                colvarFecha.IsPrimaryKey = false;
                colvarFecha.IsForeignKey = false;
                colvarFecha.IsReadOnly = false;

                schema.Columns.Add(colvarFecha);

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 554;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;

                schema.Columns.Add(colvarDescripcion);

                TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
                colvarIDUser.ColumnName = "IDUser";
                colvarIDUser.DataType = DbType.Int32;
                colvarIDUser.MaxLength = 0;
                colvarIDUser.AutoIncrement = false;
                colvarIDUser.IsNullable = false;
                colvarIDUser.IsPrimaryKey = false;
                colvarIDUser.IsForeignKey = false;
                colvarIDUser.IsReadOnly = false;

                schema.Columns.Add(colvarIDUser);

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

                TableSchema.TableColumn colvarIDTipoOperacion = new TableSchema.TableColumn(schema);
                colvarIDTipoOperacion.ColumnName = "IDTipoOperacion";
                colvarIDTipoOperacion.DataType = DbType.Int32;
                colvarIDTipoOperacion.MaxLength = 0;
                colvarIDTipoOperacion.AutoIncrement = false;
                colvarIDTipoOperacion.IsNullable = false;
                colvarIDTipoOperacion.IsPrimaryKey = false;
                colvarIDTipoOperacion.IsForeignKey = false;
                colvarIDTipoOperacion.IsReadOnly = false;

                schema.Columns.Add(colvarIDTipoOperacion);

                TableSchema.TableColumn colvarIp = new TableSchema.TableColumn(schema);
                colvarIp.ColumnName = "IP";
                colvarIp.DataType = DbType.String;
                colvarIp.MaxLength = 50;
                colvarIp.AutoIncrement = false;
                colvarIp.IsNullable = true;
                colvarIp.IsPrimaryKey = false;
                colvarIp.IsForeignKey = false;
                colvarIp.IsReadOnly = false;

                schema.Columns.Add(colvarIp);


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("ViewBitacora", schema);
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
        public ViewBitacora()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewBitacora(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewBitacora(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewBitacora(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName, columnValue);
        }

        #endregion

        #region Props


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

        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime? Fecha
        {
            get
            {
                return GetColumnValue<DateTime?>("Fecha");
            }
            set
            {
                SetColumnValue("Fecha", value);
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

        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int IDUser
        {
            get
            {
                return GetColumnValue<int>("IDUser");
            }
            set
            {
                SetColumnValue("IDUser", value);
            }
        }

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

        [XmlAttribute("IDTipoOperacion")]
        [Bindable(true)]
        public int IDTipoOperacion
        {
            get
            {
                return GetColumnValue<int>("IDTipoOperacion");
            }
            set
            {
                SetColumnValue("IDTipoOperacion", value);
            }
        }

        [XmlAttribute("Ip")]
        [Bindable(true)]
        public string Ip
        {
            get
            {
                return GetColumnValue<string>("IP");
            }
            set
            {
                SetColumnValue("IP", value);
            }
        }

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string Nombre = @"Nombre";

            public static string Fecha = @"Fecha";

            public static string Descripcion = @"Descripcion";

            public static string IDUser = @"IDUser";

            public static string Id = @"ID";

            public static string IDTipoOperacion = @"IDTipoOperacion";

            public static string Ip = @"IP";

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
