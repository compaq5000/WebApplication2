using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace SubSonicDB
{
	/// <summary>
	/// Strongly-typed collection for the TempExpediente class.
	/// </summary>
    [Serializable]
	public partial class TempExpedienteCollection : ActiveList<TempExpediente, TempExpedienteCollection>
	{	   
		public TempExpedienteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TempExpedienteCollection</returns>
		public TempExpedienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TempExpediente o = this[i];
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
	/// This is an ActiveRecord class which wraps the TempExpedientes table.
	/// </summary>
	[Serializable]
	public partial class TempExpediente : ActiveRecord<TempExpediente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TempExpediente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TempExpediente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TempExpediente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TempExpediente(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
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
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("TempExpedientes", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdcarpeta = new TableSchema.TableColumn(schema);
				colvarIdcarpeta.ColumnName = "IDCARPETA";
				colvarIdcarpeta.DataType = DbType.String;
				colvarIdcarpeta.MaxLength = 50;
				colvarIdcarpeta.AutoIncrement = false;
				colvarIdcarpeta.IsNullable = true;
				colvarIdcarpeta.IsPrimaryKey = false;
				colvarIdcarpeta.IsForeignKey = false;
				colvarIdcarpeta.IsReadOnly = false;
				colvarIdcarpeta.DefaultSetting = @"";
				colvarIdcarpeta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdcarpeta);
				
				TableSchema.TableColumn colvarRuta = new TableSchema.TableColumn(schema);
				colvarRuta.ColumnName = "Ruta";
				colvarRuta.DataType = DbType.AnsiString;
				colvarRuta.MaxLength = 2147483647;
				colvarRuta.AutoIncrement = false;
				colvarRuta.IsNullable = true;
				colvarRuta.IsPrimaryKey = false;
				colvarRuta.IsForeignKey = false;
				colvarRuta.IsReadOnly = false;
				colvarRuta.DefaultSetting = @"";
				colvarRuta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRuta);
				
				TableSchema.TableColumn colvarNombreExpe = new TableSchema.TableColumn(schema);
				colvarNombreExpe.ColumnName = "NombreExpe";
				colvarNombreExpe.DataType = DbType.String;
				colvarNombreExpe.MaxLength = 500;
				colvarNombreExpe.AutoIncrement = false;
				colvarNombreExpe.IsNullable = true;
				colvarNombreExpe.IsPrimaryKey = false;
				colvarNombreExpe.IsForeignKey = false;
				colvarNombreExpe.IsReadOnly = false;
				colvarNombreExpe.DefaultSetting = @"";
				colvarNombreExpe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombreExpe);
				
				TableSchema.TableColumn colvarNoEXPEDIENTE = new TableSchema.TableColumn(schema);
				colvarNoEXPEDIENTE.ColumnName = "NoEXPEDIENTE";
				colvarNoEXPEDIENTE.DataType = DbType.String;
				colvarNoEXPEDIENTE.MaxLength = 500;
				colvarNoEXPEDIENTE.AutoIncrement = false;
				colvarNoEXPEDIENTE.IsNullable = true;
				colvarNoEXPEDIENTE.IsPrimaryKey = false;
				colvarNoEXPEDIENTE.IsForeignKey = false;
				colvarNoEXPEDIENTE.IsReadOnly = false;
				colvarNoEXPEDIENTE.DefaultSetting = @"";
				colvarNoEXPEDIENTE.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoEXPEDIENTE);
				
				TableSchema.TableColumn colvarIdactor = new TableSchema.TableColumn(schema);
				colvarIdactor.ColumnName = "IDACTOR";
				colvarIdactor.DataType = DbType.Int32;
				colvarIdactor.MaxLength = 0;
				colvarIdactor.AutoIncrement = false;
				colvarIdactor.IsNullable = true;
				colvarIdactor.IsPrimaryKey = false;
				colvarIdactor.IsForeignKey = true;
				colvarIdactor.IsReadOnly = false;
				colvarIdactor.DefaultSetting = @"";
				
					colvarIdactor.ForeignKeyTableName = "TempActores";
				schema.Columns.Add(colvarIdactor);
				
				TableSchema.TableColumn colvarNombredelactor = new TableSchema.TableColumn(schema);
				colvarNombredelactor.ColumnName = "NOMBREDELACTOR";
				colvarNombredelactor.DataType = DbType.String;
				colvarNombredelactor.MaxLength = 500;
				colvarNombredelactor.AutoIncrement = false;
				colvarNombredelactor.IsNullable = true;
				colvarNombredelactor.IsPrimaryKey = false;
				colvarNombredelactor.IsForeignKey = false;
				colvarNombredelactor.IsReadOnly = false;
				colvarNombredelactor.DefaultSetting = @"";
				colvarNombredelactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombredelactor);
				
				TableSchema.TableColumn colvarIdabogado = new TableSchema.TableColumn(schema);
				colvarIdabogado.ColumnName = "IDABOGADO";
				colvarIdabogado.DataType = DbType.Int32;
				colvarIdabogado.MaxLength = 0;
				colvarIdabogado.AutoIncrement = false;
				colvarIdabogado.IsNullable = true;
				colvarIdabogado.IsPrimaryKey = false;
				colvarIdabogado.IsForeignKey = true;
				colvarIdabogado.IsReadOnly = false;
				colvarIdabogado.DefaultSetting = @"";
				
					colvarIdabogado.ForeignKeyTableName = "TemAbogado";
				schema.Columns.Add(colvarIdabogado);
				
				TableSchema.TableColumn colvarAbogadodelactor = new TableSchema.TableColumn(schema);
				colvarAbogadodelactor.ColumnName = "ABOGADODELACTOR";
				colvarAbogadodelactor.DataType = DbType.String;
				colvarAbogadodelactor.MaxLength = 500;
				colvarAbogadodelactor.AutoIncrement = false;
				colvarAbogadodelactor.IsNullable = true;
				colvarAbogadodelactor.IsPrimaryKey = false;
				colvarAbogadodelactor.IsForeignKey = false;
				colvarAbogadodelactor.IsReadOnly = false;
				colvarAbogadodelactor.DefaultSetting = @"";
				colvarAbogadodelactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAbogadodelactor);
				
				TableSchema.TableColumn colvarIddemandado = new TableSchema.TableColumn(schema);
				colvarIddemandado.ColumnName = "IDDEMANDADO";
				colvarIddemandado.DataType = DbType.Int32;
				colvarIddemandado.MaxLength = 0;
				colvarIddemandado.AutoIncrement = false;
				colvarIddemandado.IsNullable = true;
				colvarIddemandado.IsPrimaryKey = false;
				colvarIddemandado.IsForeignKey = true;
				colvarIddemandado.IsReadOnly = false;
				colvarIddemandado.DefaultSetting = @"";
				
					colvarIddemandado.ForeignKeyTableName = "TemDemandado";
				schema.Columns.Add(colvarIddemandado);
				
				TableSchema.TableColumn colvarDemandado = new TableSchema.TableColumn(schema);
				colvarDemandado.ColumnName = "DEMANDADO";
				colvarDemandado.DataType = DbType.String;
				colvarDemandado.MaxLength = 500;
				colvarDemandado.AutoIncrement = false;
				colvarDemandado.IsNullable = true;
				colvarDemandado.IsPrimaryKey = false;
				colvarDemandado.IsForeignKey = false;
				colvarDemandado.IsReadOnly = false;
				colvarDemandado.DefaultSetting = @"";
				colvarDemandado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDemandado);
				
				TableSchema.TableColumn colvarIdautoridadconocecaso = new TableSchema.TableColumn(schema);
				colvarIdautoridadconocecaso.ColumnName = "IDAUTORIDADCONOCECASO";
				colvarIdautoridadconocecaso.DataType = DbType.Int32;
				colvarIdautoridadconocecaso.MaxLength = 0;
				colvarIdautoridadconocecaso.AutoIncrement = false;
				colvarIdautoridadconocecaso.IsNullable = true;
				colvarIdautoridadconocecaso.IsPrimaryKey = false;
				colvarIdautoridadconocecaso.IsForeignKey = true;
				colvarIdautoridadconocecaso.IsReadOnly = false;
				colvarIdautoridadconocecaso.DefaultSetting = @"";
				
					colvarIdautoridadconocecaso.ForeignKeyTableName = "TemAutoridad";
				schema.Columns.Add(colvarIdautoridadconocecaso);
				
				TableSchema.TableColumn colvarAutoridadconocecaso = new TableSchema.TableColumn(schema);
				colvarAutoridadconocecaso.ColumnName = "AUTORIDADCONOCECASO";
				colvarAutoridadconocecaso.DataType = DbType.String;
				colvarAutoridadconocecaso.MaxLength = 500;
				colvarAutoridadconocecaso.AutoIncrement = false;
				colvarAutoridadconocecaso.IsNullable = true;
				colvarAutoridadconocecaso.IsPrimaryKey = false;
				colvarAutoridadconocecaso.IsForeignKey = false;
				colvarAutoridadconocecaso.IsReadOnly = false;
				colvarAutoridadconocecaso.DefaultSetting = @"";
				colvarAutoridadconocecaso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAutoridadconocecaso);
				
				TableSchema.TableColumn colvarCausamotivajuicio = new TableSchema.TableColumn(schema);
				colvarCausamotivajuicio.ColumnName = "CAUSAMOTIVAJUICIO";
				colvarCausamotivajuicio.DataType = DbType.String;
				colvarCausamotivajuicio.MaxLength = 3000;
				colvarCausamotivajuicio.AutoIncrement = false;
				colvarCausamotivajuicio.IsNullable = true;
				colvarCausamotivajuicio.IsPrimaryKey = false;
				colvarCausamotivajuicio.IsForeignKey = false;
				colvarCausamotivajuicio.IsReadOnly = false;
				colvarCausamotivajuicio.DefaultSetting = @"";
				colvarCausamotivajuicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCausamotivajuicio);
				
				TableSchema.TableColumn colvarIdtipojuicio = new TableSchema.TableColumn(schema);
				colvarIdtipojuicio.ColumnName = "IDTIPOJUICIO";
				colvarIdtipojuicio.DataType = DbType.Int32;
				colvarIdtipojuicio.MaxLength = 0;
				colvarIdtipojuicio.AutoIncrement = false;
				colvarIdtipojuicio.IsNullable = true;
				colvarIdtipojuicio.IsPrimaryKey = false;
				colvarIdtipojuicio.IsForeignKey = true;
				colvarIdtipojuicio.IsReadOnly = false;
				colvarIdtipojuicio.DefaultSetting = @"";
				
					colvarIdtipojuicio.ForeignKeyTableName = "TemTipojuicio";
				schema.Columns.Add(colvarIdtipojuicio);
				
				TableSchema.TableColumn colvarTipojuicio = new TableSchema.TableColumn(schema);
				colvarTipojuicio.ColumnName = "TIPOJUICIO";
				colvarTipojuicio.DataType = DbType.String;
				colvarTipojuicio.MaxLength = 500;
				colvarTipojuicio.AutoIncrement = false;
				colvarTipojuicio.IsNullable = true;
				colvarTipojuicio.IsPrimaryKey = false;
				colvarTipojuicio.IsForeignKey = false;
				colvarTipojuicio.IsReadOnly = false;
				colvarTipojuicio.DefaultSetting = @"";
				colvarTipojuicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipojuicio);
				
				TableSchema.TableColumn colvarEtapa = new TableSchema.TableColumn(schema);
				colvarEtapa.ColumnName = "ETAPA";
				colvarEtapa.DataType = DbType.String;
				colvarEtapa.MaxLength = 1500;
				colvarEtapa.AutoIncrement = false;
				colvarEtapa.IsNullable = true;
				colvarEtapa.IsPrimaryKey = false;
				colvarEtapa.IsForeignKey = false;
				colvarEtapa.IsReadOnly = false;
				colvarEtapa.DefaultSetting = @"";
				colvarEtapa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEtapa);
				
				TableSchema.TableColumn colvarDependencia = new TableSchema.TableColumn(schema);
				colvarDependencia.ColumnName = "DEPENDENCIA";
				colvarDependencia.DataType = DbType.String;
				colvarDependencia.MaxLength = 300;
				colvarDependencia.AutoIncrement = false;
				colvarDependencia.IsNullable = true;
				colvarDependencia.IsPrimaryKey = false;
				colvarDependencia.IsForeignKey = false;
				colvarDependencia.IsReadOnly = false;
				colvarDependencia.DefaultSetting = @"";
				colvarDependencia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDependencia);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "Fecha";
				colvarFecha.DataType = DbType.String;
				colvarFecha.MaxLength = 500;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = true;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "OBSERVACIONES";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 1000;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarMonto = new TableSchema.TableColumn(schema);
				colvarMonto.ColumnName = "MONTO";
				colvarMonto.DataType = DbType.String;
				colvarMonto.MaxLength = 500;
				colvarMonto.AutoIncrement = false;
				colvarMonto.IsNullable = true;
				colvarMonto.IsPrimaryKey = false;
				colvarMonto.IsForeignKey = false;
				colvarMonto.IsReadOnly = false;
				colvarMonto.DefaultSetting = @"";
				colvarMonto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMonto);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TempExpedientes",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Idcarpeta")]
		[Bindable(true)]
		public string Idcarpeta 
		{
			get { return GetColumnValue<string>(Columns.Idcarpeta); }
			set { SetColumnValue(Columns.Idcarpeta, value); }
		}
		  
		[XmlAttribute("Ruta")]
		[Bindable(true)]
		public string Ruta 
		{
			get { return GetColumnValue<string>(Columns.Ruta); }
			set { SetColumnValue(Columns.Ruta, value); }
		}
		  
		[XmlAttribute("NombreExpe")]
		[Bindable(true)]
		public string NombreExpe 
		{
			get { return GetColumnValue<string>(Columns.NombreExpe); }
			set { SetColumnValue(Columns.NombreExpe, value); }
		}
		  
		[XmlAttribute("NoEXPEDIENTE")]
		[Bindable(true)]
		public string NoEXPEDIENTE 
		{
			get { return GetColumnValue<string>(Columns.NoEXPEDIENTE); }
			set { SetColumnValue(Columns.NoEXPEDIENTE, value); }
		}
		  
		[XmlAttribute("Idactor")]
		[Bindable(true)]
		public int? Idactor 
		{
			get { return GetColumnValue<int?>(Columns.Idactor); }
			set { SetColumnValue(Columns.Idactor, value); }
		}
		  
		[XmlAttribute("Nombredelactor")]
		[Bindable(true)]
		public string Nombredelactor 
		{
			get { return GetColumnValue<string>(Columns.Nombredelactor); }
			set { SetColumnValue(Columns.Nombredelactor, value); }
		}
		  
		[XmlAttribute("Idabogado")]
		[Bindable(true)]
		public int? Idabogado 
		{
			get { return GetColumnValue<int?>(Columns.Idabogado); }
			set { SetColumnValue(Columns.Idabogado, value); }
		}
		  
		[XmlAttribute("Abogadodelactor")]
		[Bindable(true)]
		public string Abogadodelactor 
		{
			get { return GetColumnValue<string>(Columns.Abogadodelactor); }
			set { SetColumnValue(Columns.Abogadodelactor, value); }
		}
		  
		[XmlAttribute("Iddemandado")]
		[Bindable(true)]
		public int? Iddemandado 
		{
			get { return GetColumnValue<int?>(Columns.Iddemandado); }
			set { SetColumnValue(Columns.Iddemandado, value); }
		}
		  
		[XmlAttribute("Demandado")]
		[Bindable(true)]
		public string Demandado 
		{
			get { return GetColumnValue<string>(Columns.Demandado); }
			set { SetColumnValue(Columns.Demandado, value); }
		}
		  
		[XmlAttribute("Idautoridadconocecaso")]
		[Bindable(true)]
		public int? Idautoridadconocecaso 
		{
			get { return GetColumnValue<int?>(Columns.Idautoridadconocecaso); }
			set { SetColumnValue(Columns.Idautoridadconocecaso, value); }
		}
		  
		[XmlAttribute("Autoridadconocecaso")]
		[Bindable(true)]
		public string Autoridadconocecaso 
		{
			get { return GetColumnValue<string>(Columns.Autoridadconocecaso); }
			set { SetColumnValue(Columns.Autoridadconocecaso, value); }
		}
		  
		[XmlAttribute("Causamotivajuicio")]
		[Bindable(true)]
		public string Causamotivajuicio 
		{
			get { return GetColumnValue<string>(Columns.Causamotivajuicio); }
			set { SetColumnValue(Columns.Causamotivajuicio, value); }
		}
		  
		[XmlAttribute("Idtipojuicio")]
		[Bindable(true)]
		public int? Idtipojuicio 
		{
			get { return GetColumnValue<int?>(Columns.Idtipojuicio); }
			set { SetColumnValue(Columns.Idtipojuicio, value); }
		}
		  
		[XmlAttribute("Tipojuicio")]
		[Bindable(true)]
		public string Tipojuicio 
		{
			get { return GetColumnValue<string>(Columns.Tipojuicio); }
			set { SetColumnValue(Columns.Tipojuicio, value); }
		}
		  
		[XmlAttribute("Etapa")]
		[Bindable(true)]
		public string Etapa 
		{
			get { return GetColumnValue<string>(Columns.Etapa); }
			set { SetColumnValue(Columns.Etapa, value); }
		}
		  
		[XmlAttribute("Dependencia")]
		[Bindable(true)]
		public string Dependencia 
		{
			get { return GetColumnValue<string>(Columns.Dependencia); }
			set { SetColumnValue(Columns.Dependencia, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public string Fecha 
		{
			get { return GetColumnValue<string>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Monto")]
		[Bindable(true)]
		public string Monto 
		{
			get { return GetColumnValue<string>(Columns.Monto); }
			set { SetColumnValue(Columns.Monto, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TemAbogado ActiveRecord object related to this TempExpediente
		/// 
		/// </summary>
		public SubSonicDB.TemAbogado TemAbogado
		{
			get { return SubSonicDB.TemAbogado.FetchByID(this.Idabogado); }
			set { SetColumnValue("IDABOGADO", value.IdAbogado); }
		}
		
		
		/// <summary>
		/// Returns a TemAutoridad ActiveRecord object related to this TempExpediente
		/// 
		/// </summary>
		public SubSonicDB.TemAutoridad TemAutoridad
		{
			get { return SubSonicDB.TemAutoridad.FetchByID(this.Idautoridadconocecaso); }
			set { SetColumnValue("IDAUTORIDADCONOCECASO", value.Idautoridad); }
		}
		
		
		/// <summary>
		/// Returns a TemDemandado ActiveRecord object related to this TempExpediente
		/// 
		/// </summary>
		public SubSonicDB.TemDemandado TemDemandado
		{
			get { return SubSonicDB.TemDemandado.FetchByID(this.Iddemandado); }
			set { SetColumnValue("IDDEMANDADO", value.Iddemandado); }
		}
		
		
		/// <summary>
		/// Returns a TempActore ActiveRecord object related to this TempExpediente
		/// 
		/// </summary>
		public SubSonicDB.TempActore TempActore
		{
			get { return SubSonicDB.TempActore.FetchByID(this.Idactor); }
			set { SetColumnValue("IDACTOR", value.Idactor); }
		}
		
		
		/// <summary>
		/// Returns a TemTipojuicio ActiveRecord object related to this TempExpediente
		/// 
		/// </summary>
		public SubSonicDB.TemTipojuicio TemTipojuicio
		{
			get { return SubSonicDB.TemTipojuicio.FetchByID(this.Idtipojuicio); }
			set { SetColumnValue("IDTIPOJUICIO", value.IDTipoJuicio); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varIdcarpeta,string varRuta,string varNombreExpe,string varNoEXPEDIENTE,int? varIdactor,string varNombredelactor,int? varIdabogado,string varAbogadodelactor,int? varIddemandado,string varDemandado,int? varIdautoridadconocecaso,string varAutoridadconocecaso,string varCausamotivajuicio,int? varIdtipojuicio,string varTipojuicio,string varEtapa,string varDependencia,string varFecha,string varObservaciones,string varMonto)
		{
			TempExpediente item = new TempExpediente();
			
			item.Idcarpeta = varIdcarpeta;
			
			item.Ruta = varRuta;
			
			item.NombreExpe = varNombreExpe;
			
			item.NoEXPEDIENTE = varNoEXPEDIENTE;
			
			item.Idactor = varIdactor;
			
			item.Nombredelactor = varNombredelactor;
			
			item.Idabogado = varIdabogado;
			
			item.Abogadodelactor = varAbogadodelactor;
			
			item.Iddemandado = varIddemandado;
			
			item.Demandado = varDemandado;
			
			item.Idautoridadconocecaso = varIdautoridadconocecaso;
			
			item.Autoridadconocecaso = varAutoridadconocecaso;
			
			item.Causamotivajuicio = varCausamotivajuicio;
			
			item.Idtipojuicio = varIdtipojuicio;
			
			item.Tipojuicio = varTipojuicio;
			
			item.Etapa = varEtapa;
			
			item.Dependencia = varDependencia;
			
			item.Fecha = varFecha;
			
			item.Observaciones = varObservaciones;
			
			item.Monto = varMonto;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varIdcarpeta,string varRuta,string varNombreExpe,string varNoEXPEDIENTE,int? varIdactor,string varNombredelactor,int? varIdabogado,string varAbogadodelactor,int? varIddemandado,string varDemandado,int? varIdautoridadconocecaso,string varAutoridadconocecaso,string varCausamotivajuicio,int? varIdtipojuicio,string varTipojuicio,string varEtapa,string varDependencia,string varFecha,string varObservaciones,string varMonto,int varId)
		{
			TempExpediente item = new TempExpediente();
			
				item.Idcarpeta = varIdcarpeta;
			
				item.Ruta = varRuta;
			
				item.NombreExpe = varNombreExpe;
			
				item.NoEXPEDIENTE = varNoEXPEDIENTE;
			
				item.Idactor = varIdactor;
			
				item.Nombredelactor = varNombredelactor;
			
				item.Idabogado = varIdabogado;
			
				item.Abogadodelactor = varAbogadodelactor;
			
				item.Iddemandado = varIddemandado;
			
				item.Demandado = varDemandado;
			
				item.Idautoridadconocecaso = varIdautoridadconocecaso;
			
				item.Autoridadconocecaso = varAutoridadconocecaso;
			
				item.Causamotivajuicio = varCausamotivajuicio;
			
				item.Idtipojuicio = varIdtipojuicio;
			
				item.Tipojuicio = varTipojuicio;
			
				item.Etapa = varEtapa;
			
				item.Dependencia = varDependencia;
			
				item.Fecha = varFecha;
			
				item.Observaciones = varObservaciones;
			
				item.Monto = varMonto;
			
				item.Id = varId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdcarpetaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn RutaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreExpeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NoEXPEDIENTEColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdactorColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NombredelactorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdabogadoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn AbogadodelactorColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IddemandadoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DemandadoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdautoridadconocecasoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn AutoridadconocecasoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn CausamotivajuicioColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdtipojuicioColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn TipojuicioColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn EtapaColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn DependenciaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn MontoColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Idcarpeta = @"IDCARPETA";
			 public static string Ruta = @"Ruta";
			 public static string NombreExpe = @"NombreExpe";
			 public static string NoEXPEDIENTE = @"NoEXPEDIENTE";
			 public static string Idactor = @"IDACTOR";
			 public static string Nombredelactor = @"NOMBREDELACTOR";
			 public static string Idabogado = @"IDABOGADO";
			 public static string Abogadodelactor = @"ABOGADODELACTOR";
			 public static string Iddemandado = @"IDDEMANDADO";
			 public static string Demandado = @"DEMANDADO";
			 public static string Idautoridadconocecaso = @"IDAUTORIDADCONOCECASO";
			 public static string Autoridadconocecaso = @"AUTORIDADCONOCECASO";
			 public static string Causamotivajuicio = @"CAUSAMOTIVAJUICIO";
			 public static string Idtipojuicio = @"IDTIPOJUICIO";
			 public static string Tipojuicio = @"TIPOJUICIO";
			 public static string Etapa = @"ETAPA";
			 public static string Dependencia = @"DEPENDENCIA";
			 public static string Fecha = @"Fecha";
			 public static string Observaciones = @"OBSERVACIONES";
			 public static string Monto = @"MONTO";
			 public static string Id = @"ID";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
