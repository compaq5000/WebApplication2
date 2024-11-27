using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewVacacionesRh class.
    /// </summary>
    [Serializable]
    public partial class ViewVacacionesRhCollection : ReadOnlyList<ViewVacacionesRh, ViewVacacionesRhCollection>
    {
        public ViewVacacionesRhCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_Vacaciones_RH view.
    /// </summary>
    [Serializable]
    public partial class ViewVacacionesRh : ReadOnlyRecord<ViewVacacionesRh>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_Vacaciones_RH", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarNombreCompleto = new TableSchema.TableColumn(schema);
                colvarNombreCompleto.ColumnName = "NombreCompleto";
                colvarNombreCompleto.DataType = DbType.String;
                colvarNombreCompleto.MaxLength = 152;
                colvarNombreCompleto.AutoIncrement = false;
                colvarNombreCompleto.IsNullable = true;
                colvarNombreCompleto.IsPrimaryKey = false;
                colvarNombreCompleto.IsForeignKey = false;
                colvarNombreCompleto.IsReadOnly = false;

                schema.Columns.Add(colvarNombreCompleto);

                TableSchema.TableColumn colvarCategoria = new TableSchema.TableColumn(schema);
                colvarCategoria.ColumnName = "Categoria";
                colvarCategoria.DataType = DbType.String;
                colvarCategoria.MaxLength = 50;
                colvarCategoria.AutoIncrement = false;
                colvarCategoria.IsNullable = true;
                colvarCategoria.IsPrimaryKey = false;
                colvarCategoria.IsForeignKey = false;
                colvarCategoria.IsReadOnly = false;

                schema.Columns.Add(colvarCategoria);

                TableSchema.TableColumn colvarNoempleado = new TableSchema.TableColumn(schema);
                colvarNoempleado.ColumnName = "NOEMPLEADO";
                colvarNoempleado.DataType = DbType.String;
                colvarNoempleado.MaxLength = 50;
                colvarNoempleado.AutoIncrement = false;
                colvarNoempleado.IsNullable = true;
                colvarNoempleado.IsPrimaryKey = false;
                colvarNoempleado.IsForeignKey = false;
                colvarNoempleado.IsReadOnly = false;

                schema.Columns.Add(colvarNoempleado);

                TableSchema.TableColumn colvarAdscripcion = new TableSchema.TableColumn(schema);
                colvarAdscripcion.ColumnName = "Adscripcion";
                colvarAdscripcion.DataType = DbType.String;
                colvarAdscripcion.MaxLength = 50;
                colvarAdscripcion.AutoIncrement = false;
                colvarAdscripcion.IsNullable = true;
                colvarAdscripcion.IsPrimaryKey = false;
                colvarAdscripcion.IsForeignKey = false;
                colvarAdscripcion.IsReadOnly = false;

                schema.Columns.Add(colvarAdscripcion);

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

                TableSchema.TableColumn colvarPeriodo = new TableSchema.TableColumn(schema);
                colvarPeriodo.ColumnName = "Periodo";
                colvarPeriodo.DataType = DbType.String;
                colvarPeriodo.MaxLength = 10;
                colvarPeriodo.AutoIncrement = false;
                colvarPeriodo.IsNullable = true;
                colvarPeriodo.IsPrimaryKey = false;
                colvarPeriodo.IsForeignKey = false;
                colvarPeriodo.IsReadOnly = false;

                schema.Columns.Add(colvarPeriodo);

                TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
                colvarObservaciones.ColumnName = "Observaciones";
                colvarObservaciones.DataType = DbType.String;
                colvarObservaciones.MaxLength = 500;
                colvarObservaciones.AutoIncrement = false;
                colvarObservaciones.IsNullable = true;
                colvarObservaciones.IsPrimaryKey = false;
                colvarObservaciones.IsForeignKey = false;
                colvarObservaciones.IsReadOnly = false;

                schema.Columns.Add(colvarObservaciones);

                TableSchema.TableColumn colvarFechaCaptura = new TableSchema.TableColumn(schema);
                colvarFechaCaptura.ColumnName = "FechaCaptura";
                colvarFechaCaptura.DataType = DbType.DateTime;
                colvarFechaCaptura.MaxLength = 0;
                colvarFechaCaptura.AutoIncrement = false;
                colvarFechaCaptura.IsNullable = true;
                colvarFechaCaptura.IsPrimaryKey = false;
                colvarFechaCaptura.IsForeignKey = false;
                colvarFechaCaptura.IsReadOnly = false;

                schema.Columns.Add(colvarFechaCaptura);

                TableSchema.TableColumn colvarFechaInicio = new TableSchema.TableColumn(schema);
                colvarFechaInicio.ColumnName = "FechaInicio";
                colvarFechaInicio.DataType = DbType.DateTime;
                colvarFechaInicio.MaxLength = 0;
                colvarFechaInicio.AutoIncrement = false;
                colvarFechaInicio.IsNullable = true;
                colvarFechaInicio.IsPrimaryKey = false;
                colvarFechaInicio.IsForeignKey = false;
                colvarFechaInicio.IsReadOnly = false;

                schema.Columns.Add(colvarFechaInicio);

                TableSchema.TableColumn colvarFechaFin = new TableSchema.TableColumn(schema);
                colvarFechaFin.ColumnName = "FechaFin";
                colvarFechaFin.DataType = DbType.DateTime;
                colvarFechaFin.MaxLength = 0;
                colvarFechaFin.AutoIncrement = false;
                colvarFechaFin.IsNullable = true;
                colvarFechaFin.IsPrimaryKey = false;
                colvarFechaFin.IsForeignKey = false;
                colvarFechaFin.IsReadOnly = false;

                schema.Columns.Add(colvarFechaFin);

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

                TableSchema.TableColumn colvarJefe = new TableSchema.TableColumn(schema);
                colvarJefe.ColumnName = "Jefe";
                colvarJefe.DataType = DbType.String;
                colvarJefe.MaxLength = 150;
                colvarJefe.AutoIncrement = false;
                colvarJefe.IsNullable = true;
                colvarJefe.IsPrimaryKey = false;
                colvarJefe.IsForeignKey = false;
                colvarJefe.IsReadOnly = false;

                schema.Columns.Add(colvarJefe);

                TableSchema.TableColumn colvarTotaldias = new TableSchema.TableColumn(schema);
                colvarTotaldias.ColumnName = "totaldias";
                colvarTotaldias.DataType = DbType.Int32;
                colvarTotaldias.MaxLength = 0;
                colvarTotaldias.AutoIncrement = false;
                colvarTotaldias.IsNullable = true;
                colvarTotaldias.IsPrimaryKey = false;
                colvarTotaldias.IsForeignKey = false;
                colvarTotaldias.IsReadOnly = false;

                schema.Columns.Add(colvarTotaldias);


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_Vacaciones_RH", schema);
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
        public ViewVacacionesRh()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewVacacionesRh(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewVacacionesRh(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewVacacionesRh(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName, columnValue);
        }

        #endregion

        #region Props


        [XmlAttribute("NombreCompleto")]
        [Bindable(true)]
        public string NombreCompleto
        {
            get
            {
                return GetColumnValue<string>("NombreCompleto");
            }
            set
            {
                SetColumnValue("NombreCompleto", value);
            }
        }

        [XmlAttribute("Categoria")]
        [Bindable(true)]
        public string Categoria
        {
            get
            {
                return GetColumnValue<string>("Categoria");
            }
            set
            {
                SetColumnValue("Categoria", value);
            }
        }

        [XmlAttribute("Noempleado")]
        [Bindable(true)]
        public string Noempleado
        {
            get
            {
                return GetColumnValue<string>("NOEMPLEADO");
            }
            set
            {
                SetColumnValue("NOEMPLEADO", value);
            }
        }

        [XmlAttribute("Adscripcion")]
        [Bindable(true)]
        public string Adscripcion
        {
            get
            {
                return GetColumnValue<string>("Adscripcion");
            }
            set
            {
                SetColumnValue("Adscripcion", value);
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

        [XmlAttribute("Periodo")]
        [Bindable(true)]
        public string Periodo
        {
            get
            {
                return GetColumnValue<string>("Periodo");
            }
            set
            {
                SetColumnValue("Periodo", value);
            }
        }

        [XmlAttribute("Observaciones")]
        [Bindable(true)]
        public string Observaciones
        {
            get
            {
                return GetColumnValue<string>("Observaciones");
            }
            set
            {
                SetColumnValue("Observaciones", value);
            }
        }

        [XmlAttribute("FechaCaptura")]
        [Bindable(true)]
        public DateTime? FechaCaptura
        {
            get
            {
                return GetColumnValue<DateTime?>("FechaCaptura");
            }
            set
            {
                SetColumnValue("FechaCaptura", value);
            }
        }

        [XmlAttribute("FechaInicio")]
        [Bindable(true)]
        public DateTime? FechaInicio
        {
            get
            {
                return GetColumnValue<DateTime?>("FechaInicio");
            }
            set
            {
                SetColumnValue("FechaInicio", value);
            }
        }

        [XmlAttribute("FechaFin")]
        [Bindable(true)]
        public DateTime? FechaFin
        {
            get
            {
                return GetColumnValue<DateTime?>("FechaFin");
            }
            set
            {
                SetColumnValue("FechaFin", value);
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

        [XmlAttribute("Jefe")]
        [Bindable(true)]
        public string Jefe
        {
            get
            {
                return GetColumnValue<string>("Jefe");
            }
            set
            {
                SetColumnValue("Jefe", value);
            }
        }

        [XmlAttribute("Totaldias")]
        [Bindable(true)]
        public int? Totaldias
        {
            get
            {
                return GetColumnValue<int?>("totaldias");
            }
            set
            {
                SetColumnValue("totaldias", value);
            }
        }

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string NombreCompleto = @"NombreCompleto";

            public static string Categoria = @"Categoria";

            public static string Noempleado = @"NOEMPLEADO";

            public static string Adscripcion = @"Adscripcion";

            public static string Descripcion = @"Descripcion";

            public static string Periodo = @"Periodo";

            public static string Observaciones = @"Observaciones";

            public static string FechaCaptura = @"FechaCaptura";

            public static string FechaInicio = @"FechaInicio";

            public static string FechaFin = @"FechaFin";

            public static string Id = @"ID";

            public static string IDUser = @"IDUser";

            public static string Jefe = @"Jefe";

            public static string Totaldias = @"totaldias";

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
