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
	/// Strongly-typed collection for the CatStatusMinutum class.
	/// </summary>
    [Serializable]
	public partial class CatStatusMinutumCollection : ActiveList<CatStatusMinutum, CatStatusMinutumCollection>
	{	   
		public CatStatusMinutumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatStatusMinutumCollection</returns>
		public CatStatusMinutumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatStatusMinutum o = this[i];
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
	/// This is an ActiveRecord class which wraps the CatStatusMinuta table.
	/// </summary>
	[Serializable]
	public partial class CatStatusMinutum : ActiveRecord<CatStatusMinutum>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatStatusMinutum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatStatusMinutum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatStatusMinutum(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatStatusMinutum(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CatStatusMinuta", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIntX = new TableSchema.TableColumn(schema);
				colvarIntX.ColumnName = "int";
				colvarIntX.DataType = DbType.Int32;
				colvarIntX.MaxLength = 0;
				colvarIntX.AutoIncrement = true;
				colvarIntX.IsNullable = false;
				colvarIntX.IsPrimaryKey = true;
				colvarIntX.IsForeignKey = false;
				colvarIntX.IsReadOnly = false;
				colvarIntX.DefaultSetting = @"";
				colvarIntX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntX);
				
				TableSchema.TableColumn colvarNvarchar = new TableSchema.TableColumn(schema);
				colvarNvarchar.ColumnName = "nvarchar";
				colvarNvarchar.DataType = DbType.String;
				colvarNvarchar.MaxLength = 50;
				colvarNvarchar.AutoIncrement = false;
				colvarNvarchar.IsNullable = true;
				colvarNvarchar.IsPrimaryKey = false;
				colvarNvarchar.IsForeignKey = false;
				colvarNvarchar.IsReadOnly = false;
				colvarNvarchar.DefaultSetting = @"";
				colvarNvarchar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNvarchar);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("CatStatusMinuta",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IntX")]
		[Bindable(true)]
		public int IntX 
		{
			get { return GetColumnValue<int>(Columns.IntX); }
			set { SetColumnValue(Columns.IntX, value); }
		}
		  
		[XmlAttribute("Nvarchar")]
		[Bindable(true)]
		public string Nvarchar 
		{
			get { return GetColumnValue<string>(Columns.Nvarchar); }
			set { SetColumnValue(Columns.Nvarchar, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.TranMinutumCollection TranMinuta()
		{
			return new SubSonicDB.TranMinutumCollection().Where(TranMinutum.Columns.StatusMinuta, IntX).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNvarchar,bool? varStatus)
		{
			CatStatusMinutum item = new CatStatusMinutum();
			
			item.Nvarchar = varNvarchar;
			
			item.Status = varStatus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIntX,string varNvarchar,bool? varStatus)
		{
			CatStatusMinutum item = new CatStatusMinutum();
			
				item.IntX = varIntX;
			
				item.Nvarchar = varNvarchar;
			
				item.Status = varStatus;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IntXColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NvarcharColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IntX = @"int";
			 public static string Nvarchar = @"nvarchar";
			 public static string Status = @"status";
						
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
