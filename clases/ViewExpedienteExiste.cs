using SubSonic;
using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace SubSonicDB
{
    /// <summary>
    /// Strongly-typed collection for the ViewExpedienteExiste class.
    /// </summary>
    [Serializable]
    public partial class ViewExpedienteExisteCollection : ReadOnlyList<ViewExpedienteExiste, ViewExpedienteExisteCollection>
    {
        public ViewExpedienteExisteCollection() { }
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_ExpedienteExiste view.
    /// </summary>
    [Serializable]
    public partial class ViewExpedienteExiste : ReadOnlyRecord<ViewExpedienteExiste>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_ExpedienteExiste", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                TableSchema.TableColumn colvarUsuarios = new TableSchema.TableColumn(schema);
                colvarUsuarios.ColumnName = "usuarios";
                colvarUsuarios.DataType = DbType.String;
                colvarUsuarios.MaxLength = 50;
                colvarUsuarios.AutoIncrement = false;
                colvarUsuarios.IsNullable = true;
                colvarUsuarios.IsPrimaryKey = false;
                colvarUsuarios.IsForeignKey = false;
                colvarUsuarios.IsReadOnly = false;

                schema.Columns.Add(colvarUsuarios);

                TableSchema.TableColumn colvarIDDepende = new TableSchema.TableColumn(schema);
                colvarIDDepende.ColumnName = "IDDepende";
                colvarIDDepende.DataType = DbType.Int32;
                colvarIDDepende.MaxLength = 0;
                colvarIDDepende.AutoIncrement = false;
                colvarIDDepende.IsNullable = true;
                colvarIDDepende.IsPrimaryKey = false;
                colvarIDDepende.IsForeignKey = false;
                colvarIDDepende.IsReadOnly = false;

                schema.Columns.Add(colvarIDDepende);

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

                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 3000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;

                schema.Columns.Add(colvarDescripcion);

                TableSchema.TableColumn colvarIDActor = new TableSchema.TableColumn(schema);
                colvarIDActor.ColumnName = "IDActor";
                colvarIDActor.DataType = DbType.Int32;
                colvarIDActor.MaxLength = 0;
                colvarIDActor.AutoIncrement = false;
                colvarIDActor.IsNullable = true;
                colvarIDActor.IsPrimaryKey = false;
                colvarIDActor.IsForeignKey = false;
                colvarIDActor.IsReadOnly = false;

                schema.Columns.Add(colvarIDActor);

                TableSchema.TableColumn colvarIDAbogadoActor = new TableSchema.TableColumn(schema);
                colvarIDAbogadoActor.ColumnName = "IDAbogadoActor";
                colvarIDAbogadoActor.DataType = DbType.Int32;
                colvarIDAbogadoActor.MaxLength = 0;
                colvarIDAbogadoActor.AutoIncrement = false;
                colvarIDAbogadoActor.IsNullable = true;
                colvarIDAbogadoActor.IsPrimaryKey = false;
                colvarIDAbogadoActor.IsForeignKey = false;
                colvarIDAbogadoActor.IsReadOnly = false;

                schema.Columns.Add(colvarIDAbogadoActor);

                TableSchema.TableColumn colvarIDDemandado = new TableSchema.TableColumn(schema);
                colvarIDDemandado.ColumnName = "IDDemandado";
                colvarIDDemandado.DataType = DbType.Int32;
                colvarIDDemandado.MaxLength = 0;
                colvarIDDemandado.AutoIncrement = false;
                colvarIDDemandado.IsNullable = true;
                colvarIDDemandado.IsPrimaryKey = false;
                colvarIDDemandado.IsForeignKey = false;
                colvarIDDemandado.IsReadOnly = false;

                schema.Columns.Add(colvarIDDemandado);

                TableSchema.TableColumn colvarIDAutocaso = new TableSchema.TableColumn(schema);
                colvarIDAutocaso.ColumnName = "IDAutocaso";
                colvarIDAutocaso.DataType = DbType.Int32;
                colvarIDAutocaso.MaxLength = 0;
                colvarIDAutocaso.AutoIncrement = false;
                colvarIDAutocaso.IsNullable = true;
                colvarIDAutocaso.IsPrimaryKey = false;
                colvarIDAutocaso.IsForeignKey = false;
                colvarIDAutocaso.IsReadOnly = false;

                schema.Columns.Add(colvarIDAutocaso);

                TableSchema.TableColumn colvarIDTipojuicio = new TableSchema.TableColumn(schema);
                colvarIDTipojuicio.ColumnName = "IDTipojuicio";
                colvarIDTipojuicio.DataType = DbType.Int32;
                colvarIDTipojuicio.MaxLength = 0;
                colvarIDTipojuicio.AutoIncrement = false;
                colvarIDTipojuicio.IsNullable = true;
                colvarIDTipojuicio.IsPrimaryKey = false;
                colvarIDTipojuicio.IsForeignKey = false;
                colvarIDTipojuicio.IsReadOnly = false;

                schema.Columns.Add(colvarIDTipojuicio);

                TableSchema.TableColumn colvarCausa = new TableSchema.TableColumn(schema);
                colvarCausa.ColumnName = "Causa";
                colvarCausa.DataType = DbType.String;
                colvarCausa.MaxLength = 3000;
                colvarCausa.AutoIncrement = false;
                colvarCausa.IsNullable = true;
                colvarCausa.IsPrimaryKey = false;
                colvarCausa.IsForeignKey = false;
                colvarCausa.IsReadOnly = false;

                schema.Columns.Add(colvarCausa);

                TableSchema.TableColumn colvarEtapa = new TableSchema.TableColumn(schema);
                colvarEtapa.ColumnName = "Etapa";
                colvarEtapa.DataType = DbType.String;
                colvarEtapa.MaxLength = 3000;
                colvarEtapa.AutoIncrement = false;
                colvarEtapa.IsNullable = true;
                colvarEtapa.IsPrimaryKey = false;
                colvarEtapa.IsForeignKey = false;
                colvarEtapa.IsReadOnly = false;

                schema.Columns.Add(colvarEtapa);

                TableSchema.TableColumn colvarIDEtapa = new TableSchema.TableColumn(schema);
                colvarIDEtapa.ColumnName = "IDEtapa";
                colvarIDEtapa.DataType = DbType.Int32;
                colvarIDEtapa.MaxLength = 0;
                colvarIDEtapa.AutoIncrement = false;
                colvarIDEtapa.IsNullable = true;
                colvarIDEtapa.IsPrimaryKey = false;
                colvarIDEtapa.IsForeignKey = false;
                colvarIDEtapa.IsReadOnly = false;

                schema.Columns.Add(colvarIDEtapa);

                TableSchema.TableColumn colvarFechaconoce = new TableSchema.TableColumn(schema);
                colvarFechaconoce.ColumnName = "fechaconoce";
                colvarFechaconoce.DataType = DbType.DateTime;
                colvarFechaconoce.MaxLength = 0;
                colvarFechaconoce.AutoIncrement = false;
                colvarFechaconoce.IsNullable = true;
                colvarFechaconoce.IsPrimaryKey = false;
                colvarFechaconoce.IsForeignKey = false;
                colvarFechaconoce.IsReadOnly = false;

                schema.Columns.Add(colvarFechaconoce);

                TableSchema.TableColumn colvarFechainterpone = new TableSchema.TableColumn(schema);
                colvarFechainterpone.ColumnName = "fechainterpone";
                colvarFechainterpone.DataType = DbType.AnsiString;
                colvarFechainterpone.MaxLength = 4;
                colvarFechainterpone.AutoIncrement = false;
                colvarFechainterpone.IsNullable = true;
                colvarFechainterpone.IsPrimaryKey = false;
                colvarFechainterpone.IsForeignKey = false;
                colvarFechainterpone.IsReadOnly = false;

                schema.Columns.Add(colvarFechainterpone);

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

                TableSchema.TableColumn colvarActualizacion = new TableSchema.TableColumn(schema);
                colvarActualizacion.ColumnName = "Actualizacion";
                colvarActualizacion.DataType = DbType.DateTime;
                colvarActualizacion.MaxLength = 0;
                colvarActualizacion.AutoIncrement = false;
                colvarActualizacion.IsNullable = true;
                colvarActualizacion.IsPrimaryKey = false;
                colvarActualizacion.IsForeignKey = false;
                colvarActualizacion.IsReadOnly = false;

                schema.Columns.Add(colvarActualizacion);

                TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
                colvarIDUser.ColumnName = "IDUser";
                colvarIDUser.DataType = DbType.Int32;
                colvarIDUser.MaxLength = 0;
                colvarIDUser.AutoIncrement = false;
                colvarIDUser.IsNullable = true;
                colvarIDUser.IsPrimaryKey = false;
                colvarIDUser.IsForeignKey = false;
                colvarIDUser.IsReadOnly = false;

                schema.Columns.Add(colvarIDUser);

                TableSchema.TableColumn colvarTomo = new TableSchema.TableColumn(schema);
                colvarTomo.ColumnName = "Tomo";
                colvarTomo.DataType = DbType.String;
                colvarTomo.MaxLength = 50;
                colvarTomo.AutoIncrement = false;
                colvarTomo.IsNullable = true;
                colvarTomo.IsPrimaryKey = false;
                colvarTomo.IsForeignKey = false;
                colvarTomo.IsReadOnly = false;

                schema.Columns.Add(colvarTomo);

                TableSchema.TableColumn colvarIDOrigenCorres = new TableSchema.TableColumn(schema);
                colvarIDOrigenCorres.ColumnName = "IDOrigenCorres";
                colvarIDOrigenCorres.DataType = DbType.Int32;
                colvarIDOrigenCorres.MaxLength = 0;
                colvarIDOrigenCorres.AutoIncrement = false;
                colvarIDOrigenCorres.IsNullable = true;
                colvarIDOrigenCorres.IsPrimaryKey = false;
                colvarIDOrigenCorres.IsForeignKey = false;
                colvarIDOrigenCorres.IsReadOnly = false;

                schema.Columns.Add(colvarIDOrigenCorres);

                TableSchema.TableColumn colvarIDStatusCorrespondencia = new TableSchema.TableColumn(schema);
                colvarIDStatusCorrespondencia.ColumnName = "IDStatusCorrespondencia";
                colvarIDStatusCorrespondencia.DataType = DbType.Int32;
                colvarIDStatusCorrespondencia.MaxLength = 0;
                colvarIDStatusCorrespondencia.AutoIncrement = false;
                colvarIDStatusCorrespondencia.IsNullable = true;
                colvarIDStatusCorrespondencia.IsPrimaryKey = false;
                colvarIDStatusCorrespondencia.IsForeignKey = false;
                colvarIDStatusCorrespondencia.IsReadOnly = false;

                schema.Columns.Add(colvarIDStatusCorrespondencia);

                TableSchema.TableColumn colvarStatusRetornado = new TableSchema.TableColumn(schema);
                colvarStatusRetornado.ColumnName = "StatusRetornado";
                colvarStatusRetornado.DataType = DbType.Boolean;
                colvarStatusRetornado.MaxLength = 0;
                colvarStatusRetornado.AutoIncrement = false;
                colvarStatusRetornado.IsNullable = true;
                colvarStatusRetornado.IsPrimaryKey = false;
                colvarStatusRetornado.IsForeignKey = false;
                colvarStatusRetornado.IsReadOnly = false;

                schema.Columns.Add(colvarStatusRetornado);

                TableSchema.TableColumn colvarIDDestinoCorrespondencia = new TableSchema.TableColumn(schema);
                colvarIDDestinoCorrespondencia.ColumnName = "IDDestinoCorrespondencia";
                colvarIDDestinoCorrespondencia.DataType = DbType.Int32;
                colvarIDDestinoCorrespondencia.MaxLength = 0;
                colvarIDDestinoCorrespondencia.AutoIncrement = false;
                colvarIDDestinoCorrespondencia.IsNullable = true;
                colvarIDDestinoCorrespondencia.IsPrimaryKey = false;
                colvarIDDestinoCorrespondencia.IsForeignKey = false;
                colvarIDDestinoCorrespondencia.IsReadOnly = false;

                schema.Columns.Add(colvarIDDestinoCorrespondencia);

                TableSchema.TableColumn colvarPaginas = new TableSchema.TableColumn(schema);
                colvarPaginas.ColumnName = "Paginas";
                colvarPaginas.DataType = DbType.String;
                colvarPaginas.MaxLength = 50;
                colvarPaginas.AutoIncrement = false;
                colvarPaginas.IsNullable = true;
                colvarPaginas.IsPrimaryKey = false;
                colvarPaginas.IsForeignKey = false;
                colvarPaginas.IsReadOnly = false;

                schema.Columns.Add(colvarPaginas);

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


                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_ExpedienteExiste", schema);
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
        public ViewExpedienteExiste()
        {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewExpedienteExiste(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
            {
                ForceDefaults();
            }
            MarkNew();
        }

        public ViewExpedienteExiste(object keyID)
        {
            SetSQLProps();
            LoadByKey(keyID);
        }

        public ViewExpedienteExiste(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName, columnValue);
        }

        #endregion

        #region Props


        [XmlAttribute("Usuarios")]
        [Bindable(true)]
        public string Usuarios
        {
            get
            {
                return GetColumnValue<string>("usuarios");
            }
            set
            {
                SetColumnValue("usuarios", value);
            }
        }

        [XmlAttribute("IDDepende")]
        [Bindable(true)]
        public int? IDDepende
        {
            get
            {
                return GetColumnValue<int?>("IDDepende");
            }
            set
            {
                SetColumnValue("IDDepende", value);
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

        [XmlAttribute("IDActor")]
        [Bindable(true)]
        public int? IDActor
        {
            get
            {
                return GetColumnValue<int?>("IDActor");
            }
            set
            {
                SetColumnValue("IDActor", value);
            }
        }

        [XmlAttribute("IDAbogadoActor")]
        [Bindable(true)]
        public int? IDAbogadoActor
        {
            get
            {
                return GetColumnValue<int?>("IDAbogadoActor");
            }
            set
            {
                SetColumnValue("IDAbogadoActor", value);
            }
        }

        [XmlAttribute("IDDemandado")]
        [Bindable(true)]
        public int? IDDemandado
        {
            get
            {
                return GetColumnValue<int?>("IDDemandado");
            }
            set
            {
                SetColumnValue("IDDemandado", value);
            }
        }

        [XmlAttribute("IDAutocaso")]
        [Bindable(true)]
        public int? IDAutocaso
        {
            get
            {
                return GetColumnValue<int?>("IDAutocaso");
            }
            set
            {
                SetColumnValue("IDAutocaso", value);
            }
        }

        [XmlAttribute("IDTipojuicio")]
        [Bindable(true)]
        public int? IDTipojuicio
        {
            get
            {
                return GetColumnValue<int?>("IDTipojuicio");
            }
            set
            {
                SetColumnValue("IDTipojuicio", value);
            }
        }

        [XmlAttribute("Causa")]
        [Bindable(true)]
        public string Causa
        {
            get
            {
                return GetColumnValue<string>("Causa");
            }
            set
            {
                SetColumnValue("Causa", value);
            }
        }

        [XmlAttribute("Etapa")]
        [Bindable(true)]
        public string Etapa
        {
            get
            {
                return GetColumnValue<string>("Etapa");
            }
            set
            {
                SetColumnValue("Etapa", value);
            }
        }

        [XmlAttribute("IDEtapa")]
        [Bindable(true)]
        public int? IDEtapa
        {
            get
            {
                return GetColumnValue<int?>("IDEtapa");
            }
            set
            {
                SetColumnValue("IDEtapa", value);
            }
        }

        [XmlAttribute("Fechaconoce")]
        [Bindable(true)]
        public DateTime? Fechaconoce
        {
            get
            {
                return GetColumnValue<DateTime?>("fechaconoce");
            }
            set
            {
                SetColumnValue("fechaconoce", value);
            }
        }

        [XmlAttribute("Fechainterpone")]
        [Bindable(true)]
        public string Fechainterpone
        {
            get
            {
                return GetColumnValue<string>("fechainterpone");
            }
            set
            {
                SetColumnValue("fechainterpone", value);
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

        [XmlAttribute("Actualizacion")]
        [Bindable(true)]
        public DateTime? Actualizacion
        {
            get
            {
                return GetColumnValue<DateTime?>("Actualizacion");
            }
            set
            {
                SetColumnValue("Actualizacion", value);
            }
        }

        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int? IDUser
        {
            get
            {
                return GetColumnValue<int?>("IDUser");
            }
            set
            {
                SetColumnValue("IDUser", value);
            }
        }

        [XmlAttribute("Tomo")]
        [Bindable(true)]
        public string Tomo
        {
            get
            {
                return GetColumnValue<string>("Tomo");
            }
            set
            {
                SetColumnValue("Tomo", value);
            }
        }

        [XmlAttribute("IDOrigenCorres")]
        [Bindable(true)]
        public int? IDOrigenCorres
        {
            get
            {
                return GetColumnValue<int?>("IDOrigenCorres");
            }
            set
            {
                SetColumnValue("IDOrigenCorres", value);
            }
        }

        [XmlAttribute("IDStatusCorrespondencia")]
        [Bindable(true)]
        public int? IDStatusCorrespondencia
        {
            get
            {
                return GetColumnValue<int?>("IDStatusCorrespondencia");
            }
            set
            {
                SetColumnValue("IDStatusCorrespondencia", value);
            }
        }

        [XmlAttribute("StatusRetornado")]
        [Bindable(true)]
        public bool? StatusRetornado
        {
            get
            {
                return GetColumnValue<bool?>("StatusRetornado");
            }
            set
            {
                SetColumnValue("StatusRetornado", value);
            }
        }

        [XmlAttribute("IDDestinoCorrespondencia")]
        [Bindable(true)]
        public int? IDDestinoCorrespondencia
        {
            get
            {
                return GetColumnValue<int?>("IDDestinoCorrespondencia");
            }
            set
            {
                SetColumnValue("IDDestinoCorrespondencia", value);
            }
        }

        [XmlAttribute("Paginas")]
        [Bindable(true)]
        public string Paginas
        {
            get
            {
                return GetColumnValue<string>("Paginas");
            }
            set
            {
                SetColumnValue("Paginas", value);
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

        #endregion

        #region Columns Struct
        public struct Columns
        {


            public static string Usuarios = @"usuarios";

            public static string IDDepende = @"IDDepende";

            public static string IDTIpoContenido = @"IDTIpoContenido";

            public static string Descripcion = @"Descripcion";

            public static string IDActor = @"IDActor";

            public static string IDAbogadoActor = @"IDAbogadoActor";

            public static string IDDemandado = @"IDDemandado";

            public static string IDAutocaso = @"IDAutocaso";

            public static string IDTipojuicio = @"IDTipojuicio";

            public static string Causa = @"Causa";

            public static string Etapa = @"Etapa";

            public static string IDEtapa = @"IDEtapa";

            public static string Fechaconoce = @"fechaconoce";

            public static string Fechainterpone = @"fechainterpone";

            public static string Status = @"status";

            public static string Actualizacion = @"Actualizacion";

            public static string IDUser = @"IDUser";

            public static string Tomo = @"Tomo";

            public static string IDOrigenCorres = @"IDOrigenCorres";

            public static string IDStatusCorrespondencia = @"IDStatusCorrespondencia";

            public static string StatusRetornado = @"StatusRetornado";

            public static string IDDestinoCorrespondencia = @"IDDestinoCorrespondencia";

            public static string Paginas = @"Paginas";

            public static string Id = @"ID";

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
