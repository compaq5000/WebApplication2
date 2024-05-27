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
	/// Strongly-typed collection for the TranInsidenciasRH class.
	/// </summary>
    [Serializable]
	public partial class TranInsidenciasRHCollection : ActiveList<TranInsidenciasRH, TranInsidenciasRHCollection>
	{	   
		public TranInsidenciasRHCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TranInsidenciasRHCollection</returns>
		public TranInsidenciasRHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TranInsidenciasRH o = this[i];
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
	/// This is an ActiveRecord class which wraps the TranInsidenciasRH table.
	/// </summary>
	[Serializable]
	public partial class TranInsidenciasRH : ActiveRecord<TranInsidenciasRH>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TranInsidenciasRH()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TranInsidenciasRH(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TranInsidenciasRH(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TranInsidenciasRH(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TranInsidenciasRH", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
				colvarIDUser.ColumnName = "IDUser";
				colvarIDUser.DataType = DbType.Int32;
				colvarIDUser.MaxLength = 0;
				colvarIDUser.AutoIncrement = false;
				colvarIDUser.IsNullable = true;
				colvarIDUser.IsPrimaryKey = false;
				colvarIDUser.IsForeignKey = true;
				colvarIDUser.IsReadOnly = false;
				colvarIDUser.DefaultSetting = @"";
				
					colvarIDUser.ForeignKeyTableName = "CatUsuarios";
				schema.Columns.Add(colvarIDUser);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "Fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = true;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
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
				colvarAsunto.DefaultSetting = @"";
				colvarAsunto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAsunto);
				
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
				
				TableSchema.TableColumn colvarIDJustificar = new TableSchema.TableColumn(schema);
				colvarIDJustificar.ColumnName = "IDJustificar";
				colvarIDJustificar.DataType = DbType.Int32;
				colvarIDJustificar.MaxLength = 0;
				colvarIDJustificar.AutoIncrement = false;
				colvarIDJustificar.IsNullable = true;
				colvarIDJustificar.IsPrimaryKey = false;
				colvarIDJustificar.IsForeignKey = true;
				colvarIDJustificar.IsReadOnly = false;
				colvarIDJustificar.DefaultSetting = @"";
				
					colvarIDJustificar.ForeignKeyTableName = "CatRHJustificar";
				schema.Columns.Add(colvarIDJustificar);
				
				TableSchema.TableColumn colvarSalida = new TableSchema.TableColumn(schema);
				colvarSalida.ColumnName = "SALIDA";
				colvarSalida.DataType = DbType.String;
				colvarSalida.MaxLength = 50;
				colvarSalida.AutoIncrement = false;
				colvarSalida.IsNullable = true;
				colvarSalida.IsPrimaryKey = false;
				colvarSalida.IsForeignKey = false;
				colvarSalida.IsReadOnly = false;
				colvarSalida.DefaultSetting = @"";
				colvarSalida.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSalida);
				
				TableSchema.TableColumn colvarEntrada = new TableSchema.TableColumn(schema);
				colvarEntrada.ColumnName = "ENTRADA";
				colvarEntrada.DataType = DbType.String;
				colvarEntrada.MaxLength = 50;
				colvarEntrada.AutoIncrement = false;
				colvarEntrada.IsNullable = true;
				colvarEntrada.IsPrimaryKey = false;
				colvarEntrada.IsForeignKey = false;
				colvarEntrada.IsReadOnly = false;
				colvarEntrada.DefaultSetting = @"";
				colvarEntrada.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEntrada);
				
				TableSchema.TableColumn colvarIdtipoinsid = new TableSchema.TableColumn(schema);
				colvarIdtipoinsid.ColumnName = "IDTIPOINSID";
				colvarIdtipoinsid.DataType = DbType.Int32;
				colvarIdtipoinsid.MaxLength = 0;
				colvarIdtipoinsid.AutoIncrement = false;
				colvarIdtipoinsid.IsNullable = true;
				colvarIdtipoinsid.IsPrimaryKey = false;
				colvarIdtipoinsid.IsForeignKey = true;
				colvarIdtipoinsid.IsReadOnly = false;
				colvarIdtipoinsid.DefaultSetting = @"";
				
					colvarIdtipoinsid.ForeignKeyTableName = "CatRHTipoInsidencia";
				schema.Columns.Add(colvarIdtipoinsid);
				
				TableSchema.TableColumn colvarAutorizado = new TableSchema.TableColumn(schema);
				colvarAutorizado.ColumnName = "Autorizado";
				colvarAutorizado.DataType = DbType.Boolean;
				colvarAutorizado.MaxLength = 0;
				colvarAutorizado.AutoIncrement = false;
				colvarAutorizado.IsNullable = true;
				colvarAutorizado.IsPrimaryKey = false;
				colvarAutorizado.IsForeignKey = false;
				colvarAutorizado.IsReadOnly = false;
				colvarAutorizado.DefaultSetting = @"";
				colvarAutorizado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAutorizado);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TranInsidenciasRH",schema);
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
		public int? IDUser 
		{
			get { return GetColumnValue<int?>(Columns.IDUser); }
			set { SetColumnValue(Columns.IDUser, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Asunto")]
		[Bindable(true)]
		public string Asunto 
		{
			get { return GetColumnValue<string>(Columns.Asunto); }
			set { SetColumnValue(Columns.Asunto, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("IDJustificar")]
		[Bindable(true)]
		public int? IDJustificar 
		{
			get { return GetColumnValue<int?>(Columns.IDJustificar); }
			set { SetColumnValue(Columns.IDJustificar, value); }
		}
		  
		[XmlAttribute("Salida")]
		[Bindable(true)]
		public string Salida 
		{
			get { return GetColumnValue<string>(Columns.Salida); }
			set { SetColumnValue(Columns.Salida, value); }
		}
		  
		[XmlAttribute("Entrada")]
		[Bindable(true)]
		public string Entrada 
		{
			get { return GetColumnValue<string>(Columns.Entrada); }
			set { SetColumnValue(Columns.Entrada, value); }
		}
		  
		[XmlAttribute("Idtipoinsid")]
		[Bindable(true)]
		public int? Idtipoinsid 
		{
			get { return GetColumnValue<int?>(Columns.Idtipoinsid); }
			set { SetColumnValue(Columns.Idtipoinsid, value); }
		}
		  
		[XmlAttribute("Autorizado")]
		[Bindable(true)]
		public bool? Autorizado 
		{
			get { return GetColumnValue<bool?>(Columns.Autorizado); }
			set { SetColumnValue(Columns.Autorizado, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatRHJustificar ActiveRecord object related to this TranInsidenciasRH
		/// 
		/// </summary>
		public SubSonicDB.CatRHJustificar CatRHJustificar
		{
			get { return SubSonicDB.CatRHJustificar.FetchByID(this.IDJustificar); }
			set { SetColumnValue("IDJustificar", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatRHTipoInsidencium ActiveRecord object related to this TranInsidenciasRH
		/// 
		/// </summary>
		public SubSonicDB.CatRHTipoInsidencium CatRHTipoInsidencium
		{
			get { return SubSonicDB.CatRHTipoInsidencium.FetchByID(this.Idtipoinsid); }
			set { SetColumnValue("IDTIPOINSID", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatUsuario ActiveRecord object related to this TranInsidenciasRH
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
		public static void Insert(int? varIDUser,DateTime? varFecha,string varAsunto,bool? varStatus,int? varIDJustificar,string varSalida,string varEntrada,int? varIdtipoinsid,bool? varAutorizado)
		{
			TranInsidenciasRH item = new TranInsidenciasRH();
			
			item.IDUser = varIDUser;
			
			item.Fecha = varFecha;
			
			item.Asunto = varAsunto;
			
			item.Status = varStatus;
			
			item.IDJustificar = varIDJustificar;
			
			item.Salida = varSalida;
			
			item.Entrada = varEntrada;
			
			item.Idtipoinsid = varIdtipoinsid;
			
			item.Autorizado = varAutorizado;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varIDUser,DateTime? varFecha,string varAsunto,bool? varStatus,int? varIDJustificar,string varSalida,string varEntrada,int? varIdtipoinsid,bool? varAutorizado)
		{
			TranInsidenciasRH item = new TranInsidenciasRH();
			
				item.Id = varId;
			
				item.IDUser = varIDUser;
			
				item.Fecha = varFecha;
			
				item.Asunto = varAsunto;
			
				item.Status = varStatus;
			
				item.IDJustificar = varIDJustificar;
			
				item.Salida = varSalida;
			
				item.Entrada = varEntrada;
			
				item.Idtipoinsid = varIdtipoinsid;
			
				item.Autorizado = varAutorizado;
			
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
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn AsuntoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IDJustificarColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SalidaColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EntradaColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdtipoinsidColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn AutorizadoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string IDUser = @"IDUser";
			 public static string Fecha = @"Fecha";
			 public static string Asunto = @"asunto";
			 public static string Status = @"status";
			 public static string IDJustificar = @"IDJustificar";
			 public static string Salida = @"SALIDA";
			 public static string Entrada = @"ENTRADA";
			 public static string Idtipoinsid = @"IDTIPOINSID";
			 public static string Autorizado = @"Autorizado";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
