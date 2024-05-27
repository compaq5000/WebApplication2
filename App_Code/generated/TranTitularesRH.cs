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
	/// Strongly-typed collection for the TranTitularesRH class.
	/// </summary>
    [Serializable]
	public partial class TranTitularesRHCollection : ActiveList<TranTitularesRH, TranTitularesRHCollection>
	{	   
		public TranTitularesRHCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TranTitularesRHCollection</returns>
		public TranTitularesRHCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TranTitularesRH o = this[i];
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
	/// This is an ActiveRecord class which wraps the TranTitularesRH table.
	/// </summary>
	[Serializable]
	public partial class TranTitularesRH : ActiveRecord<TranTitularesRH>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TranTitularesRH()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TranTitularesRH(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TranTitularesRH(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TranTitularesRH(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TranTitularesRH", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "Descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 150;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarIDStatusNombramiento = new TableSchema.TableColumn(schema);
				colvarIDStatusNombramiento.ColumnName = "IDStatusNombramiento";
				colvarIDStatusNombramiento.DataType = DbType.Int32;
				colvarIDStatusNombramiento.MaxLength = 0;
				colvarIDStatusNombramiento.AutoIncrement = false;
				colvarIDStatusNombramiento.IsNullable = true;
				colvarIDStatusNombramiento.IsPrimaryKey = false;
				colvarIDStatusNombramiento.IsForeignKey = true;
				colvarIDStatusNombramiento.IsReadOnly = false;
				colvarIDStatusNombramiento.DefaultSetting = @"";
				
					colvarIDStatusNombramiento.ForeignKeyTableName = "CatStatusTitular";
				schema.Columns.Add(colvarIDStatusNombramiento);
				
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
				
				TableSchema.TableColumn colvarIDTitular = new TableSchema.TableColumn(schema);
				colvarIDTitular.ColumnName = "IDTitular";
				colvarIDTitular.DataType = DbType.Int32;
				colvarIDTitular.MaxLength = 0;
				colvarIDTitular.AutoIncrement = false;
				colvarIDTitular.IsNullable = true;
				colvarIDTitular.IsPrimaryKey = false;
				colvarIDTitular.IsForeignKey = true;
				colvarIDTitular.IsReadOnly = false;
				colvarIDTitular.DefaultSetting = @"";
				
					colvarIDTitular.ForeignKeyTableName = "TitularesRH";
				schema.Columns.Add(colvarIDTitular);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TranTitularesRH",schema);
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
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("IDStatusNombramiento")]
		[Bindable(true)]
		public int? IDStatusNombramiento 
		{
			get { return GetColumnValue<int?>(Columns.IDStatusNombramiento); }
			set { SetColumnValue(Columns.IDStatusNombramiento, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("IDTitular")]
		[Bindable(true)]
		public int? IDTitular 
		{
			get { return GetColumnValue<int?>(Columns.IDTitular); }
			set { SetColumnValue(Columns.IDTitular, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatStatusTitular ActiveRecord object related to this TranTitularesRH
		/// 
		/// </summary>
		public SubSonicDB.CatStatusTitular CatStatusTitular
		{
			get { return SubSonicDB.CatStatusTitular.FetchByID(this.IDStatusNombramiento); }
			set { SetColumnValue("IDStatusNombramiento", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a TitularesRH ActiveRecord object related to this TranTitularesRH
		/// 
		/// </summary>
		public SubSonicDB.TitularesRH TitularesRH
		{
			get { return SubSonicDB.TitularesRH.FetchByID(this.IDTitular); }
			set { SetColumnValue("IDTitular", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion,int? varIDStatusNombramiento,bool? varStatus,int? varIDTitular)
		{
			TranTitularesRH item = new TranTitularesRH();
			
			item.Descripcion = varDescripcion;
			
			item.IDStatusNombramiento = varIDStatusNombramiento;
			
			item.Status = varStatus;
			
			item.IDTitular = varIDTitular;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varDescripcion,int? varIDStatusNombramiento,bool? varStatus,int? varIDTitular)
		{
			TranTitularesRH item = new TranTitularesRH();
			
				item.Id = varId;
			
				item.Descripcion = varDescripcion;
			
				item.IDStatusNombramiento = varIDStatusNombramiento;
			
				item.Status = varStatus;
			
				item.IDTitular = varIDTitular;
			
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
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IDStatusNombramientoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTitularColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Descripcion = @"Descripcion";
			 public static string IDStatusNombramiento = @"IDStatusNombramiento";
			 public static string Status = @"status";
			 public static string IDTitular = @"IDTitular";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
