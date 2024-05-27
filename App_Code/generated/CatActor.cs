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
	/// Strongly-typed collection for the CatActor class.
	/// </summary>
    [Serializable]
	public partial class CatActorCollection : ActiveList<CatActor, CatActorCollection>
	{	   
		public CatActorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatActorCollection</returns>
		public CatActorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatActor o = this[i];
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
	/// This is an ActiveRecord class which wraps the CatActor table.
	/// </summary>
	[Serializable]
	public partial class CatActor : ActiveRecord<CatActor>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatActor()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatActor(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatActor(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatActor(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CatActor", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
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
				
				TableSchema.TableColumn colvarIDActor = new TableSchema.TableColumn(schema);
				colvarIDActor.ColumnName = "IDActor";
				colvarIDActor.DataType = DbType.Int32;
				colvarIDActor.MaxLength = 0;
				colvarIDActor.AutoIncrement = true;
				colvarIDActor.IsNullable = false;
				colvarIDActor.IsPrimaryKey = true;
				colvarIDActor.IsForeignKey = false;
				colvarIDActor.IsReadOnly = false;
				colvarIDActor.DefaultSetting = @"";
				colvarIDActor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDActor);
				
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
				DataService.Providers["Default"].AddSchema("CatActor",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("IDActor")]
		[Bindable(true)]
		public int IDActor 
		{
			get { return GetColumnValue<int>(Columns.IDActor); }
			set { SetColumnValue(Columns.IDActor, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion,bool? varStatus)
		{
			CatActor item = new CatActor();
			
			item.Descripcion = varDescripcion;
			
			item.Status = varStatus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varDescripcion,int varIDActor,bool? varStatus)
		{
			CatActor item = new CatActor();
			
				item.Descripcion = varDescripcion;
			
				item.IDActor = varIDActor;
			
				item.Status = varStatus;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IDActorColumn
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
			 public static string Descripcion = @"Descripcion";
			 public static string IDActor = @"IDActor";
			 public static string Status = @"status";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
