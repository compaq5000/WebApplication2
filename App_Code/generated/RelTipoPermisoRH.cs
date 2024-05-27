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
	/// Strongly-typed collection for the RelTipoPermisoRH class.
	/// </summary>
    [Serializable]
	public partial class RelTipoPermisoRHCollection : ActiveList<RelTipoPermisoRH, RelTipoPermisoRHCollection>
	{	   
		public RelTipoPermisoRHCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelTipoPermisoRHCollection</returns>
		public RelTipoPermisoRHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelTipoPermisoRH o = this[i];
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
	/// This is an ActiveRecord class which wraps the RelTipoPermisoRH table.
	/// </summary>
	[Serializable]
	public partial class RelTipoPermisoRH : ActiveRecord<RelTipoPermisoRH>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RelTipoPermisoRH()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RelTipoPermisoRH(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RelTipoPermisoRH(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RelTipoPermisoRH(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RelTipoPermisoRH", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = false;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
				colvarIDUser.ColumnName = "IDUser";
				colvarIDUser.DataType = DbType.Int32;
				colvarIDUser.MaxLength = 0;
				colvarIDUser.AutoIncrement = false;
				colvarIDUser.IsNullable = false;
				colvarIDUser.IsPrimaryKey = true;
				colvarIDUser.IsForeignKey = true;
				colvarIDUser.IsReadOnly = false;
				colvarIDUser.DefaultSetting = @"";
				
					colvarIDUser.ForeignKeyTableName = "CatUsuarios";
				schema.Columns.Add(colvarIDUser);
				
				TableSchema.TableColumn colvarFechaInicio = new TableSchema.TableColumn(schema);
				colvarFechaInicio.ColumnName = "FechaInicio";
				colvarFechaInicio.DataType = DbType.DateTime;
				colvarFechaInicio.MaxLength = 0;
				colvarFechaInicio.AutoIncrement = false;
				colvarFechaInicio.IsNullable = true;
				colvarFechaInicio.IsPrimaryKey = false;
				colvarFechaInicio.IsForeignKey = false;
				colvarFechaInicio.IsReadOnly = false;
				colvarFechaInicio.DefaultSetting = @"";
				colvarFechaInicio.ForeignKeyTableName = "";
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
				colvarFechaFin.DefaultSetting = @"";
				colvarFechaFin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFin);
				
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
				
				TableSchema.TableColumn colvarFechaCaptura = new TableSchema.TableColumn(schema);
				colvarFechaCaptura.ColumnName = "FechaCaptura";
				colvarFechaCaptura.DataType = DbType.DateTime;
				colvarFechaCaptura.MaxLength = 0;
				colvarFechaCaptura.AutoIncrement = false;
				colvarFechaCaptura.IsNullable = true;
				colvarFechaCaptura.IsPrimaryKey = false;
				colvarFechaCaptura.IsForeignKey = false;
				colvarFechaCaptura.IsReadOnly = false;
				colvarFechaCaptura.DefaultSetting = @"";
				colvarFechaCaptura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaCaptura);
				
				TableSchema.TableColumn colvarIDPeriodo = new TableSchema.TableColumn(schema);
				colvarIDPeriodo.ColumnName = "IDPeriodo";
				colvarIDPeriodo.DataType = DbType.Int32;
				colvarIDPeriodo.MaxLength = 0;
				colvarIDPeriodo.AutoIncrement = false;
				colvarIDPeriodo.IsNullable = false;
				colvarIDPeriodo.IsPrimaryKey = true;
				colvarIDPeriodo.IsForeignKey = true;
				colvarIDPeriodo.IsReadOnly = false;
				colvarIDPeriodo.DefaultSetting = @"";
				
					colvarIDPeriodo.ForeignKeyTableName = "CatPeriodoVAcaiones_RH";
				schema.Columns.Add(colvarIDPeriodo);
				
				TableSchema.TableColumn colvarIDano = new TableSchema.TableColumn(schema);
				colvarIDano.ColumnName = "IDano";
				colvarIDano.DataType = DbType.Int32;
				colvarIDano.MaxLength = 0;
				colvarIDano.AutoIncrement = false;
				colvarIDano.IsNullable = false;
				colvarIDano.IsPrimaryKey = true;
				colvarIDano.IsForeignKey = true;
				colvarIDano.IsReadOnly = false;
				colvarIDano.DefaultSetting = @"";
				
					colvarIDano.ForeignKeyTableName = "CatAnoVacaciones_RH";
				schema.Columns.Add(colvarIDano);
				
				TableSchema.TableColumn colvarIDUserCaptura = new TableSchema.TableColumn(schema);
				colvarIDUserCaptura.ColumnName = "IDUserCaptura";
				colvarIDUserCaptura.DataType = DbType.Int32;
				colvarIDUserCaptura.MaxLength = 0;
				colvarIDUserCaptura.AutoIncrement = false;
				colvarIDUserCaptura.IsNullable = true;
				colvarIDUserCaptura.IsPrimaryKey = false;
				colvarIDUserCaptura.IsForeignKey = false;
				colvarIDUserCaptura.IsReadOnly = false;
				colvarIDUserCaptura.DefaultSetting = @"";
				colvarIDUserCaptura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDUserCaptura);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarTotaldias = new TableSchema.TableColumn(schema);
				colvarTotaldias.ColumnName = "totaldias";
				colvarTotaldias.DataType = DbType.Int32;
				colvarTotaldias.MaxLength = 0;
				colvarTotaldias.AutoIncrement = false;
				colvarTotaldias.IsNullable = true;
				colvarTotaldias.IsPrimaryKey = false;
				colvarTotaldias.IsForeignKey = false;
				colvarTotaldias.IsReadOnly = false;
				colvarTotaldias.DefaultSetting = @"";
				colvarTotaldias.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotaldias);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("RelTipoPermisoRH",schema);
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
		  
		[XmlAttribute("IDUser")]
		[Bindable(true)]
		public int IDUser 
		{
			get { return GetColumnValue<int>(Columns.IDUser); }
			set { SetColumnValue(Columns.IDUser, value); }
		}
		  
		[XmlAttribute("FechaInicio")]
		[Bindable(true)]
		public DateTime? FechaInicio 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaInicio); }
			set { SetColumnValue(Columns.FechaInicio, value); }
		}
		  
		[XmlAttribute("FechaFin")]
		[Bindable(true)]
		public DateTime? FechaFin 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaFin); }
			set { SetColumnValue(Columns.FechaFin, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("FechaCaptura")]
		[Bindable(true)]
		public DateTime? FechaCaptura 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaCaptura); }
			set { SetColumnValue(Columns.FechaCaptura, value); }
		}
		  
		[XmlAttribute("IDPeriodo")]
		[Bindable(true)]
		public int IDPeriodo 
		{
			get { return GetColumnValue<int>(Columns.IDPeriodo); }
			set { SetColumnValue(Columns.IDPeriodo, value); }
		}
		  
		[XmlAttribute("IDano")]
		[Bindable(true)]
		public int IDano 
		{
			get { return GetColumnValue<int>(Columns.IDano); }
			set { SetColumnValue(Columns.IDano, value); }
		}
		  
		[XmlAttribute("IDUserCaptura")]
		[Bindable(true)]
		public int? IDUserCaptura 
		{
			get { return GetColumnValue<int?>(Columns.IDUserCaptura); }
			set { SetColumnValue(Columns.IDUserCaptura, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Totaldias")]
		[Bindable(true)]
		public int? Totaldias 
		{
			get { return GetColumnValue<int?>(Columns.Totaldias); }
			set { SetColumnValue(Columns.Totaldias, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatAnoVacacionesRh ActiveRecord object related to this RelTipoPermisoRH
		/// 
		/// </summary>
		public SubSonicDB.CatAnoVacacionesRh CatAnoVacacionesRh
		{
			get { return SubSonicDB.CatAnoVacacionesRh.FetchByID(this.IDano); }
			set { SetColumnValue("IDano", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatPeriodoVAcaionesRh ActiveRecord object related to this RelTipoPermisoRH
		/// 
		/// </summary>
		public SubSonicDB.CatPeriodoVAcaionesRh CatPeriodoVAcaionesRh
		{
			get { return SubSonicDB.CatPeriodoVAcaionesRh.FetchByID(this.IDPeriodo); }
			set { SetColumnValue("IDPeriodo", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatUsuario ActiveRecord object related to this RelTipoPermisoRH
		/// 
		/// </summary>
		public SubSonicDB.CatUsuario CatUsuario
		{
			get { return SubSonicDB.CatUsuario.FetchByID(this.IDUser); }
			set { SetColumnValue("IDUser", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIDUser,DateTime? varFechaInicio,DateTime? varFechaFin,bool? varStatus,DateTime? varFechaCaptura,int varIDPeriodo,int varIDano,int? varIDUserCaptura,string varObservaciones,int? varTotaldias)
		{
			RelTipoPermisoRH item = new RelTipoPermisoRH();
			
			item.IDUser = varIDUser;
			
			item.FechaInicio = varFechaInicio;
			
			item.FechaFin = varFechaFin;
			
			item.Status = varStatus;
			
			item.FechaCaptura = varFechaCaptura;
			
			item.IDPeriodo = varIDPeriodo;
			
			item.IDano = varIDano;
			
			item.IDUserCaptura = varIDUserCaptura;
			
			item.Observaciones = varObservaciones;
			
			item.Totaldias = varTotaldias;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int varIDUser,DateTime? varFechaInicio,DateTime? varFechaFin,bool? varStatus,DateTime? varFechaCaptura,int varIDPeriodo,int varIDano,int? varIDUserCaptura,string varObservaciones,int? varTotaldias)
		{
			RelTipoPermisoRH item = new RelTipoPermisoRH();
			
				item.Id = varId;
			
				item.IDUser = varIDUser;
			
				item.FechaInicio = varFechaInicio;
			
				item.FechaFin = varFechaFin;
			
				item.Status = varStatus;
			
				item.FechaCaptura = varFechaCaptura;
			
				item.IDPeriodo = varIDPeriodo;
			
				item.IDano = varIDano;
			
				item.IDUserCaptura = varIDUserCaptura;
			
				item.Observaciones = varObservaciones;
			
				item.Totaldias = varTotaldias;
			
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
        
        
        
        public static TableSchema.TableColumn IDUserColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInicioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFinColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaCapturaColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IDPeriodoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IDanoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IDUserCapturaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn TotaldiasColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string IDUser = @"IDUser";
			 public static string FechaInicio = @"FechaInicio";
			 public static string FechaFin = @"FechaFin";
			 public static string Status = @"status";
			 public static string FechaCaptura = @"FechaCaptura";
			 public static string IDPeriodo = @"IDPeriodo";
			 public static string IDano = @"IDano";
			 public static string IDUserCaptura = @"IDUserCaptura";
			 public static string Observaciones = @"Observaciones";
			 public static string Totaldias = @"totaldias";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
