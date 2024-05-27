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
	/// Strongly-typed collection for the TablaExiste class.
	/// </summary>
    [Serializable]
	public partial class TablaExisteCollection : ActiveList<TablaExiste, TablaExisteCollection>
	{	   
		public TablaExisteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TablaExisteCollection</returns>
		public TablaExisteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TablaExiste o = this[i];
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
	/// This is an ActiveRecord class which wraps the TablaExiste table.
	/// </summary>
	[Serializable]
	public partial class TablaExiste : ActiveRecord<TablaExiste>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TablaExiste()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TablaExiste(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TablaExiste(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TablaExiste(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TablaExiste", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFolio = new TableSchema.TableColumn(schema);
				colvarFolio.ColumnName = "folio";
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
				
				TableSchema.TableColumn colvarMpio = new TableSchema.TableColumn(schema);
				colvarMpio.ColumnName = "MPIO";
				colvarMpio.DataType = DbType.String;
				colvarMpio.MaxLength = 500;
				colvarMpio.AutoIncrement = false;
				colvarMpio.IsNullable = true;
				colvarMpio.IsPrimaryKey = false;
				colvarMpio.IsForeignKey = false;
				colvarMpio.IsReadOnly = false;
				colvarMpio.DefaultSetting = @"";
				colvarMpio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMpio);
				
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
				DataService.Providers["Default"].AddSchema("TablaExiste",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Folio")]
		[Bindable(true)]
		public string Folio 
		{
			get { return GetColumnValue<string>(Columns.Folio); }
			set { SetColumnValue(Columns.Folio, value); }
		}
		  
		[XmlAttribute("Mpio")]
		[Bindable(true)]
		public string Mpio 
		{
			get { return GetColumnValue<string>(Columns.Mpio); }
			set { SetColumnValue(Columns.Mpio, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFolio,string varMpio)
		{
			TablaExiste item = new TablaExiste();
			
			item.Folio = varFolio;
			
			item.Mpio = varMpio;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varFolio,string varMpio,int varId)
		{
			TablaExiste item = new TablaExiste();
			
				item.Folio = varFolio;
			
				item.Mpio = varMpio;
			
				item.Id = varId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FolioColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MpioColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Folio = @"folio";
			 public static string Mpio = @"MPIO";
			 public static string Id = @"ID";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
