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
	/// Strongly-typed collection for the TranMinutum class.
	/// </summary>
    [Serializable]
	public partial class TranMinutumCollection : ActiveList<TranMinutum, TranMinutumCollection>
	{	   
		public TranMinutumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TranMinutumCollection</returns>
		public TranMinutumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TranMinutum o = this[i];
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
	/// This is an ActiveRecord class which wraps the TranMinuta table.
	/// </summary>
	[Serializable]
	public partial class TranMinutum : ActiveRecord<TranMinutum>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TranMinutum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TranMinutum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TranMinutum(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TranMinutum(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TranMinuta", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarStaus = new TableSchema.TableColumn(schema);
				colvarStaus.ColumnName = "staus";
				colvarStaus.DataType = DbType.Boolean;
				colvarStaus.MaxLength = 0;
				colvarStaus.AutoIncrement = false;
				colvarStaus.IsNullable = true;
				colvarStaus.IsPrimaryKey = false;
				colvarStaus.IsForeignKey = false;
				colvarStaus.IsReadOnly = false;
				colvarStaus.DefaultSetting = @"";
				colvarStaus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStaus);
				
				TableSchema.TableColumn colvarFolio = new TableSchema.TableColumn(schema);
				colvarFolio.ColumnName = "Folio";
				colvarFolio.DataType = DbType.String;
				colvarFolio.MaxLength = 50;
				colvarFolio.AutoIncrement = false;
				colvarFolio.IsNullable = true;
				colvarFolio.IsPrimaryKey = false;
				colvarFolio.IsForeignKey = false;
				colvarFolio.IsReadOnly = false;
				colvarFolio.DefaultSetting = @"";
				colvarFolio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFolio);
				
				TableSchema.TableColumn colvarPara = new TableSchema.TableColumn(schema);
				colvarPara.ColumnName = "Para";
				colvarPara.DataType = DbType.String;
				colvarPara.MaxLength = 50;
				colvarPara.AutoIncrement = false;
				colvarPara.IsNullable = true;
				colvarPara.IsPrimaryKey = false;
				colvarPara.IsForeignKey = false;
				colvarPara.IsReadOnly = false;
				colvarPara.DefaultSetting = @"";
				colvarPara.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPara);
				
				TableSchema.TableColumn colvarEn = new TableSchema.TableColumn(schema);
				colvarEn.ColumnName = "En";
				colvarEn.DataType = DbType.String;
				colvarEn.MaxLength = 200;
				colvarEn.AutoIncrement = false;
				colvarEn.IsNullable = true;
				colvarEn.IsPrimaryKey = false;
				colvarEn.IsForeignKey = false;
				colvarEn.IsReadOnly = false;
				colvarEn.DefaultSetting = @"";
				colvarEn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEn);
				
				TableSchema.TableColumn colvarAsunto = new TableSchema.TableColumn(schema);
				colvarAsunto.ColumnName = "Asunto";
				colvarAsunto.DataType = DbType.String;
				colvarAsunto.MaxLength = 200;
				colvarAsunto.AutoIncrement = false;
				colvarAsunto.IsNullable = true;
				colvarAsunto.IsPrimaryKey = false;
				colvarAsunto.IsForeignKey = false;
				colvarAsunto.IsReadOnly = false;
				colvarAsunto.DefaultSetting = @"";
				colvarAsunto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAsunto);
				
				TableSchema.TableColumn colvarContenido = new TableSchema.TableColumn(schema);
				colvarContenido.ColumnName = "Contenido";
				colvarContenido.DataType = DbType.AnsiString;
				colvarContenido.MaxLength = 2147483647;
				colvarContenido.AutoIncrement = false;
				colvarContenido.IsNullable = true;
				colvarContenido.IsPrimaryKey = false;
				colvarContenido.IsForeignKey = false;
				colvarContenido.IsReadOnly = false;
				colvarContenido.DefaultSetting = @"";
				colvarContenido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContenido);
				
				TableSchema.TableColumn colvarStatusMinuta = new TableSchema.TableColumn(schema);
				colvarStatusMinuta.ColumnName = "statusMinuta";
				colvarStatusMinuta.DataType = DbType.Int32;
				colvarStatusMinuta.MaxLength = 0;
				colvarStatusMinuta.AutoIncrement = false;
				colvarStatusMinuta.IsNullable = true;
				colvarStatusMinuta.IsPrimaryKey = false;
				colvarStatusMinuta.IsForeignKey = true;
				colvarStatusMinuta.IsReadOnly = false;
				colvarStatusMinuta.DefaultSetting = @"";
				
					colvarStatusMinuta.ForeignKeyTableName = "CatStatusMinuta";
				schema.Columns.Add(colvarStatusMinuta);
				
				TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
				colvarIDExpediente.ColumnName = "IDExpediente";
				colvarIDExpediente.DataType = DbType.Int32;
				colvarIDExpediente.MaxLength = 0;
				colvarIDExpediente.AutoIncrement = false;
				colvarIDExpediente.IsNullable = true;
				colvarIDExpediente.IsPrimaryKey = false;
				colvarIDExpediente.IsForeignKey = true;
				colvarIDExpediente.IsReadOnly = false;
				colvarIDExpediente.DefaultSetting = @"";
				
					colvarIDExpediente.ForeignKeyTableName = "Expedientes";
				schema.Columns.Add(colvarIDExpediente);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TranMinuta",schema);
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
		  
		[XmlAttribute("Staus")]
		[Bindable(true)]
		public bool? Staus 
		{
			get { return GetColumnValue<bool?>(Columns.Staus); }
			set { SetColumnValue(Columns.Staus, value); }
		}
		  
		[XmlAttribute("Folio")]
		[Bindable(true)]
		public string Folio 
		{
			get { return GetColumnValue<string>(Columns.Folio); }
			set { SetColumnValue(Columns.Folio, value); }
		}
		  
		[XmlAttribute("Para")]
		[Bindable(true)]
		public string Para 
		{
			get { return GetColumnValue<string>(Columns.Para); }
			set { SetColumnValue(Columns.Para, value); }
		}
		  
		[XmlAttribute("En")]
		[Bindable(true)]
		public string En 
		{
			get { return GetColumnValue<string>(Columns.En); }
			set { SetColumnValue(Columns.En, value); }
		}
		  
		[XmlAttribute("Asunto")]
		[Bindable(true)]
		public string Asunto 
		{
			get { return GetColumnValue<string>(Columns.Asunto); }
			set { SetColumnValue(Columns.Asunto, value); }
		}
		  
		[XmlAttribute("Contenido")]
		[Bindable(true)]
		public string Contenido 
		{
			get { return GetColumnValue<string>(Columns.Contenido); }
			set { SetColumnValue(Columns.Contenido, value); }
		}
		  
		[XmlAttribute("StatusMinuta")]
		[Bindable(true)]
		public int? StatusMinuta 
		{
			get { return GetColumnValue<int?>(Columns.StatusMinuta); }
			set { SetColumnValue(Columns.StatusMinuta, value); }
		}
		  
		[XmlAttribute("IDExpediente")]
		[Bindable(true)]
		public int? IDExpediente 
		{
			get { return GetColumnValue<int?>(Columns.IDExpediente); }
			set { SetColumnValue(Columns.IDExpediente, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatStatusMinutum ActiveRecord object related to this TranMinutum
		/// 
		/// </summary>
		public SubSonicDB.CatStatusMinutum CatStatusMinutum
		{
			get { return SubSonicDB.CatStatusMinutum.FetchByID(this.StatusMinuta); }
			set { SetColumnValue("statusMinuta", value.IntX); }
		}
		
		
		/// <summary>
		/// Returns a CatUsuario ActiveRecord object related to this TranMinutum
		/// 
		/// </summary>
		public SubSonicDB.CatUsuario CatUsuario
		{
			get { return SubSonicDB.CatUsuario.FetchByID(this.IDUser); }
			set { SetColumnValue("IDUser", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a Expediente ActiveRecord object related to this TranMinutum
		/// 
		/// </summary>
		public SubSonicDB.Expediente Expediente
		{
			get { return SubSonicDB.Expediente.FetchByID(this.IDExpediente); }
			set { SetColumnValue("IDExpediente", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIDUser,bool? varStaus,string varFolio,string varPara,string varEn,string varAsunto,string varContenido,int? varStatusMinuta,int? varIDExpediente)
		{
			TranMinutum item = new TranMinutum();
			
			item.IDUser = varIDUser;
			
			item.Staus = varStaus;
			
			item.Folio = varFolio;
			
			item.Para = varPara;
			
			item.En = varEn;
			
			item.Asunto = varAsunto;
			
			item.Contenido = varContenido;
			
			item.StatusMinuta = varStatusMinuta;
			
			item.IDExpediente = varIDExpediente;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varIDUser,bool? varStaus,string varFolio,string varPara,string varEn,string varAsunto,string varContenido,int? varStatusMinuta,int? varIDExpediente)
		{
			TranMinutum item = new TranMinutum();
			
				item.Id = varId;
			
				item.IDUser = varIDUser;
			
				item.Staus = varStaus;
			
				item.Folio = varFolio;
			
				item.Para = varPara;
			
				item.En = varEn;
			
				item.Asunto = varAsunto;
			
				item.Contenido = varContenido;
			
				item.StatusMinuta = varStatusMinuta;
			
				item.IDExpediente = varIDExpediente;
			
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
        
        
        
        public static TableSchema.TableColumn StausColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FolioColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ParaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EnColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn AsuntoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ContenidoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusMinutaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IDExpedienteColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string IDUser = @"IDUser";
			 public static string Staus = @"staus";
			 public static string Folio = @"Folio";
			 public static string Para = @"Para";
			 public static string En = @"En";
			 public static string Asunto = @"Asunto";
			 public static string Contenido = @"Contenido";
			 public static string StatusMinuta = @"statusMinuta";
			 public static string IDExpediente = @"IDExpediente";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
