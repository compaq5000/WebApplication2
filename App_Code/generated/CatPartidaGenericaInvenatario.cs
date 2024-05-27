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
	/// Strongly-typed collection for the CatPartidaGenericaInvenatario class.
	/// </summary>
    [Serializable]
	public partial class CatPartidaGenericaInvenatarioCollection : ActiveList<CatPartidaGenericaInvenatario, CatPartidaGenericaInvenatarioCollection>
	{	   
		public CatPartidaGenericaInvenatarioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatPartidaGenericaInvenatarioCollection</returns>
		public CatPartidaGenericaInvenatarioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatPartidaGenericaInvenatario o = this[i];
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
	/// This is an ActiveRecord class which wraps the CatPartidaGenerica_Invenatarios table.
	/// </summary>
	[Serializable]
	public partial class CatPartidaGenericaInvenatario : ActiveRecord<CatPartidaGenericaInvenatario>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatPartidaGenericaInvenatario()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatPartidaGenericaInvenatario(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatPartidaGenericaInvenatario(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatPartidaGenericaInvenatario(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CatPartidaGenerica_Invenatarios", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarValor = new TableSchema.TableColumn(schema);
				colvarValor.ColumnName = "Valor";
				colvarValor.DataType = DbType.String;
				colvarValor.MaxLength = 50;
				colvarValor.AutoIncrement = false;
				colvarValor.IsNullable = false;
				colvarValor.IsPrimaryKey = false;
				colvarValor.IsForeignKey = false;
				colvarValor.IsReadOnly = false;
				colvarValor.DefaultSetting = @"";
				colvarValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValor);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "Descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 500;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
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
				
				TableSchema.TableColumn colvarIDConcepto = new TableSchema.TableColumn(schema);
				colvarIDConcepto.ColumnName = "IDConcepto";
				colvarIDConcepto.DataType = DbType.Int32;
				colvarIDConcepto.MaxLength = 0;
				colvarIDConcepto.AutoIncrement = false;
				colvarIDConcepto.IsNullable = true;
				colvarIDConcepto.IsPrimaryKey = false;
				colvarIDConcepto.IsForeignKey = true;
				colvarIDConcepto.IsReadOnly = false;
				colvarIDConcepto.DefaultSetting = @"";
				
					colvarIDConcepto.ForeignKeyTableName = "CatConcepto_Inventarios";
				schema.Columns.Add(colvarIDConcepto);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("CatPartidaGenerica_Invenatarios",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Valor")]
		[Bindable(true)]
		public string Valor 
		{
			get { return GetColumnValue<string>(Columns.Valor); }
			set { SetColumnValue(Columns.Valor, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("IDConcepto")]
		[Bindable(true)]
		public int? IDConcepto 
		{
			get { return GetColumnValue<int?>(Columns.IDConcepto); }
			set { SetColumnValue(Columns.IDConcepto, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.CatPartidaEspecificaInventarioCollection CatPartidaEspecificaInventarios()
		{
			return new SubSonicDB.CatPartidaEspecificaInventarioCollection().Where(CatPartidaEspecificaInventario.Columns.IDPartidaGnerica, Id).Load();
		}
		public SubSonicDB.ExpedienteCollection Expedientes()
		{
			return new SubSonicDB.ExpedienteCollection().Where(Expediente.Columns.IDPartidaGenerica, Id).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatConceptoInventario ActiveRecord object related to this CatPartidaGenericaInvenatario
		/// 
		/// </summary>
		public SubSonicDB.CatConceptoInventario CatConceptoInventario
		{
			get { return SubSonicDB.CatConceptoInventario.FetchByID(this.IDConcepto); }
			set { SetColumnValue("IDConcepto", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varValor,string varDescripcion,bool? varStatus,int? varIDConcepto)
		{
			CatPartidaGenericaInvenatario item = new CatPartidaGenericaInvenatario();
			
			item.Valor = varValor;
			
			item.Descripcion = varDescripcion;
			
			item.Status = varStatus;
			
			item.IDConcepto = varIDConcepto;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varValor,string varDescripcion,bool? varStatus,int varId,int? varIDConcepto)
		{
			CatPartidaGenericaInvenatario item = new CatPartidaGenericaInvenatario();
			
				item.Valor = varValor;
			
				item.Descripcion = varDescripcion;
			
				item.Status = varStatus;
			
				item.Id = varId;
			
				item.IDConcepto = varIDConcepto;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ValorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IDConceptoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Valor = @"Valor";
			 public static string Descripcion = @"Descripcion";
			 public static string Status = @"status";
			 public static string Id = @"ID";
			 public static string IDConcepto = @"IDConcepto";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
