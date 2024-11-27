using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewCorrespondenciaAbrir class.
    /// </summary>
    [Serializable]
    public partial class ViewCorrespondenciaAbrirCollection : ReadOnlyList<ViewCorrespondenciaAbrir, ViewCorrespondenciaAbrirCollection>
    {
        public ViewCorrespondenciaAbrirCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_CorrespondenciaAbrir view.
    /// </summary>
    [Serializable]
    public partial class ViewCorrespondenciaAbrir : ReadOnlyRecord<ViewCorrespondenciaAbrir>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_CorrespondenciaAbrir", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 500;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;

                schema.Columns.Add(colvarNombre);

                TableSchema.TableColumn colvarExtencion = new TableSchema.TableColumn(schema);
                colvarExtencion.ColumnName = "Extencion";
                colvarExtencion.DataType = DbType.String;
                colvarExtencion.MaxLength = 5;
                colvarExtencion.AutoIncrement = false;
                colvarExtencion.IsNullable = false;
                colvarExtencion.IsPrimaryKey = false;
                colvarExtencion.IsForeignKey = false;
                colvarExtencion.IsReadOnly = false;

                schema.Columns.Add(colvarExtencion);

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

                TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
                colvarIDExpediente.ColumnName = "IDExpediente";
                colvarIDExpediente.DataType = DbType.Int32;
                colvarIDExpediente.MaxLength = 0;
                colvarIDExpediente.AutoIncrement = false;
                colvarIDExpediente.IsNullable = true;
                colvarIDExpediente.IsPrimaryKey = false;
                colvarIDExpediente.IsForeignKey = false;
                colvarIDExpediente.IsReadOnly = false;

                schema.Columns.Add(colvarIDExpediente);

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

                TableSchema.TableColumn colvarDateX = new TableSchema.TableColumn(schema);
                colvarDateX.ColumnName = "Date";
                colvarDateX.DataType = DbType.AnsiString;
                colvarDateX.MaxLength = 0;
                colvarDateX.AutoIncrement = false;
                colvarDateX.IsNullable = true;
                colvarDateX.IsPrimaryKey = false;
                colvarDateX.IsForeignKey = false;
                colvarDateX.IsReadOnly = false;

                schema.Columns.Add(colvarDateX);

                TableSchema.TableColumn colvarIDTIpoContenido = new TableSchema.TableColumn(schema);
                colvarIDTIpoContenido.ColumnName = "IDTIpoContenido";
                colvarIDTIpoContenido.DataType = DbType.Int32;
                colvarIDTIpoContenido.MaxLength = 0;
                colvarIDTIpoContenido.AutoIncrement = false;
                colvarIDTIpoContenido.IsNullable = true;
                colvarIDTIpoContenido.IsPrimaryKey = false;
                colvarIDTIpoContenido.IsForeignKey = false;
                colvarIDTIpoContenido.IsReadOnly = false;

                schema.Columns.Add(colvarIDTIpoContenido);


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_CorrespondenciaAbrir", schema);
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
        public ViewCorrespondenciaAbrir()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewCorrespondenciaAbrir(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewCorrespondenciaAbrir(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewCorrespondenciaAbrir(string columnName, object columnValue)
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

        [XmlAttribute("Extencion")]
        [Bindable(true)]
        public string Extencion
        {
            get
            {
                return GetColumnValue<string>("Extencion");
            }
            set
            {
                SetColumnValue("Extencion", value);
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

        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int? IDExpediente
        {
            get
            {
                return GetColumnValue<int?>("IDExpediente");
            }
            set
            {
                SetColumnValue("IDExpediente", value);
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

        [XmlAttribute("DateX")]
        [Bindable(true)]
        public string DateX
        {
            get
            {
                return GetColumnValue<string>("Date");
            }
            set
            {
                SetColumnValue("Date", value);
            }
        }

        [XmlAttribute("IDTIpoContenido")]
        [Bindable(true)]
        public int? IDTIpoContenido
        {
            get
            {
                return GetColumnValue<int?>("IDTIpoContenido");
            }
            set
            {
                SetColumnValue("IDTIpoContenido", value);
            }
        }

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string Nombre = @"Nombre";

            public static string Extencion = @"Extencion";

            public static string Status = @"status";

            public static string IDExpediente = @"IDExpediente";

            public static string Id = @"ID";

            public static string DateX = @"Date";

            public static string IDTIpoContenido = @"IDTIpoContenido";

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
