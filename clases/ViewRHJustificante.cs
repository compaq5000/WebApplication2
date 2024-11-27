using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewRHJustificante class.
    /// </summary>
    [Serializable]
    public partial class ViewRHJustificanteCollection : ReadOnlyList<ViewRHJustificante, ViewRHJustificanteCollection>
    {
        public ViewRHJustificanteCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_RHJustificantes view.
    /// </summary>
    [Serializable]
    public partial class ViewRHJustificante : ReadOnlyRecord<ViewRHJustificante>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_RHJustificantes", TableType.View, DataService.GetInstance("Default"));
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

                TableSchema.TableColumn colvarAsunto = new TableSchema.TableColumn(schema);
                colvarAsunto.ColumnName = "asunto";
                colvarAsunto.DataType = DbType.String;
                colvarAsunto.MaxLength = 2500;
                colvarAsunto.AutoIncrement = false;
                colvarAsunto.IsNullable = true;
                colvarAsunto.IsPrimaryKey = false;
                colvarAsunto.IsForeignKey = false;
                colvarAsunto.IsReadOnly = false;

                schema.Columns.Add(colvarAsunto);

                TableSchema.TableColumn colvarJustificar = new TableSchema.TableColumn(schema);
                colvarJustificar.ColumnName = "JUSTIFICAR";
                colvarJustificar.DataType = DbType.String;
                colvarJustificar.MaxLength = 50;
                colvarJustificar.AutoIncrement = false;
                colvarJustificar.IsNullable = true;
                colvarJustificar.IsPrimaryKey = false;
                colvarJustificar.IsForeignKey = false;
                colvarJustificar.IsReadOnly = false;

                schema.Columns.Add(colvarJustificar);

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

                TableSchema.TableColumn colvarExpr1 = new TableSchema.TableColumn(schema);
                colvarExpr1.ColumnName = "Expr1";
                colvarExpr1.DataType = DbType.Int32;
                colvarExpr1.MaxLength = 0;
                colvarExpr1.AutoIncrement = false;
                colvarExpr1.IsNullable = false;
                colvarExpr1.IsPrimaryKey = false;
                colvarExpr1.IsForeignKey = false;
                colvarExpr1.IsReadOnly = false;

                schema.Columns.Add(colvarExpr1);

                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Boolean;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;

                schema.Columns.Add(colvarStatus);

                TableSchema.TableColumn colvarSalida = new TableSchema.TableColumn(schema);
                colvarSalida.ColumnName = "SALIDA";
                colvarSalida.DataType = DbType.String;
                colvarSalida.MaxLength = 5;
                colvarSalida.AutoIncrement = false;
                colvarSalida.IsNullable = true;
                colvarSalida.IsPrimaryKey = false;
                colvarSalida.IsForeignKey = false;
                colvarSalida.IsReadOnly = false;

                schema.Columns.Add(colvarSalida);

                TableSchema.TableColumn colvarEntrada = new TableSchema.TableColumn(schema);
                colvarEntrada.ColumnName = "ENTRADA";
                colvarEntrada.DataType = DbType.String;
                colvarEntrada.MaxLength = 5;
                colvarEntrada.AutoIncrement = false;
                colvarEntrada.IsNullable = true;
                colvarEntrada.IsPrimaryKey = false;
                colvarEntrada.IsForeignKey = false;
                colvarEntrada.IsReadOnly = false;

                schema.Columns.Add(colvarEntrada);

                TableSchema.TableColumn colvarIdtipoinsid = new TableSchema.TableColumn(schema);
                colvarIdtipoinsid.ColumnName = "IDTIPOINSID";
                colvarIdtipoinsid.DataType = DbType.Int32;
                colvarIdtipoinsid.MaxLength = 0;
                colvarIdtipoinsid.AutoIncrement = false;
                colvarIdtipoinsid.IsNullable = true;
                colvarIdtipoinsid.IsPrimaryKey = false;
                colvarIdtipoinsid.IsForeignKey = false;
                colvarIdtipoinsid.IsReadOnly = false;

                schema.Columns.Add(colvarIdtipoinsid);

                TableSchema.TableColumn colvarIDacrip = new TableSchema.TableColumn(schema);
                colvarIDacrip.ColumnName = "IDacrip";
                colvarIDacrip.DataType = DbType.Int32;
                colvarIDacrip.MaxLength = 0;
                colvarIDacrip.AutoIncrement = false;
                colvarIDacrip.IsNullable = true;
                colvarIDacrip.IsPrimaryKey = false;
                colvarIDacrip.IsForeignKey = false;
                colvarIDacrip.IsReadOnly = false;

                schema.Columns.Add(colvarIDacrip);

                TableSchema.TableColumn colvarAutorizado = new TableSchema.TableColumn(schema);
                colvarAutorizado.ColumnName = "Autorizado";
                colvarAutorizado.DataType = DbType.Boolean;
                colvarAutorizado.MaxLength = 0;
                colvarAutorizado.AutoIncrement = false;
                colvarAutorizado.IsNullable = true;
                colvarAutorizado.IsPrimaryKey = false;
                colvarAutorizado.IsForeignKey = false;
                colvarAutorizado.IsReadOnly = false;

                schema.Columns.Add(colvarAutorizado);


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_RHJustificantes", schema);
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
        public ViewRHJustificante()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewRHJustificante(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewRHJustificante(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewRHJustificante(string columnName, object columnValue)
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

        [XmlAttribute("Asunto")]
        [Bindable(true)]
        public string Asunto
        {
            get
            {
                return GetColumnValue<string>("asunto");
            }
            set
            {
                SetColumnValue("asunto", value);
            }
        }

        [XmlAttribute("Justificar")]
        [Bindable(true)]
        public string Justificar
        {
            get
            {
                return GetColumnValue<string>("JUSTIFICAR");
            }
            set
            {
                SetColumnValue("JUSTIFICAR", value);
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

        [XmlAttribute("Expr1")]
        [Bindable(true)]
        public int Expr1
        {
            get
            {
                return GetColumnValue<int>("Expr1");
            }
            set
            {
                SetColumnValue("Expr1", value);
            }
        }

        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status
        {
            get
            {
                return GetColumnValue<bool?>("status");
            }
            set
            {
                SetColumnValue("status", value);
            }
        }

        [XmlAttribute("Salida")]
        [Bindable(true)]
        public string Salida
        {
            get
            {
                return GetColumnValue<string>("SALIDA");
            }
            set
            {
                SetColumnValue("SALIDA", value);
            }
        }

        [XmlAttribute("Entrada")]
        [Bindable(true)]
        public string Entrada
        {
            get
            {
                return GetColumnValue<string>("ENTRADA");
            }
            set
            {
                SetColumnValue("ENTRADA", value);
            }
        }

        [XmlAttribute("Idtipoinsid")]
        [Bindable(true)]
        public int? Idtipoinsid
        {
            get
            {
                return GetColumnValue<int?>("IDTIPOINSID");
            }
            set
            {
                SetColumnValue("IDTIPOINSID", value);
            }
        }

        [XmlAttribute("IDacrip")]
        [Bindable(true)]
        public int? IDacrip
        {
            get
            {
                return GetColumnValue<int?>("IDacrip");
            }
            set
            {
                SetColumnValue("IDacrip", value);
            }
        }

        [XmlAttribute("Autorizado")]
        [Bindable(true)]
        public bool? Autorizado
        {
            get
            {
                return GetColumnValue<bool?>("Autorizado");
            }
            set
            {
                SetColumnValue("Autorizado", value);
            }
        }

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string NombreCompleto = @"NombreCompleto";

            public static string Noempleado = @"NOEMPLEADO";

            public static string Fecha = @"Fecha";

            public static string Asunto = @"asunto";

            public static string Justificar = @"JUSTIFICAR";

            public static string Id = @"ID";

            public static string Descripcion = @"Descripcion";

            public static string Categoria = @"Categoria";

            public static string Expr1 = @"Expr1";

            public static string Status = @"status";

            public static string Salida = @"SALIDA";

            public static string Entrada = @"ENTRADA";

            public static string Idtipoinsid = @"IDTIPOINSID";

            public static string IDacrip = @"IDacrip";

            public static string Autorizado = @"Autorizado";

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
