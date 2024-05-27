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
	/// Strongly-typed collection for the CatEjercicioInventario class.
	/// </summary>
    [Serializable]
	public partial class CatEjercicioInventarioCollection : ActiveList<CatEjercicioInventario, CatEjercicioInventarioCollection>
	{	   
		public CatEjercicioInventarioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatEjercicioInventarioCollection</returns>
		public CatEjercicioInventarioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatEjercicioInventario o = this[i];
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
	/// This is an ActiveRecord class which wraps the CatEjercicio_Inventarios table.
	/// </summary>
	[Serializable]
	public partial class CatEjercicioInventario : ActiveRecord<CatEjercicioInventario>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatEjercicioInventario()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatEjercicioInventario(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatEjercicioInventario(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatEjercicioInventario(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CatEjercicio_Inventarios", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarValor = new TableSchema.TableColumn(schema);
				colvarValor.ColumnName = "valor";
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
				DataService.Providers["Default"].AddSchema("CatEjercicio_Inventarios",schema);
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
		  
		[XmlAttribute("Staus")]
		[Bindable(true)]
		public bool? Staus 
		{
			get { return GetColumnValue<bool?>(Columns.Staus); }
			set { SetColumnValue(Columns.Staus, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.ExpedienteCollection Expedientes()
		{
			return new SubSonicDB.ExpedienteCollection().Where(Expediente.Columns.IDEjercicio, Id).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varValor,string varDescripcion,bool? varStaus)
		{
			CatEjercicioInventario item = new CatEjercicioInventario();
			
			item.Valor = varValor;
			
			item.Descripcion = varDescripcion;
			
			item.Staus = varStaus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varValor,string varDescripcion,bool? varStaus,int varId)
		{
			CatEjercicioInventario item = new CatEjercicioInventario();
			
				item.Valor = varValor;
			
				item.Descripcion = varDescripcion;
			
				item.Staus = varStaus;
			
				item.Id = varId;
			
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
        
        
        
        public static TableSchema.TableColumn StausColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Valor = @"valor";
			 public static string Descripcion = @"Descripcion";
			 public static string Staus = @"staus";
			 public static string Id = @"ID";
						
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
