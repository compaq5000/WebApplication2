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
	/// Strongly-typed collection for the RelCatAdscripcion class.
	/// </summary>
    [Serializable]
	public partial class RelCatAdscripcionCollection : ActiveList<RelCatAdscripcion, RelCatAdscripcionCollection>
	{	   
		public RelCatAdscripcionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelCatAdscripcionCollection</returns>
		public RelCatAdscripcionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelCatAdscripcion o = this[i];
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
	/// This is an ActiveRecord class which wraps the RelCatAdscripcion table.
	/// </summary>
	[Serializable]
	public partial class RelCatAdscripcion : ActiveRecord<RelCatAdscripcion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RelCatAdscripcion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RelCatAdscripcion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RelCatAdscripcion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RelCatAdscripcion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RelCatAdscripcion", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarIDAdscripcion = new TableSchema.TableColumn(schema);
				colvarIDAdscripcion.ColumnName = "IDAdscripcion";
				colvarIDAdscripcion.DataType = DbType.Int32;
				colvarIDAdscripcion.MaxLength = 0;
				colvarIDAdscripcion.AutoIncrement = false;
				colvarIDAdscripcion.IsNullable = true;
				colvarIDAdscripcion.IsPrimaryKey = false;
				colvarIDAdscripcion.IsForeignKey = true;
				colvarIDAdscripcion.IsReadOnly = false;
				colvarIDAdscripcion.DefaultSetting = @"";
				
					colvarIDAdscripcion.ForeignKeyTableName = "CatAdscripcion_RH";
				schema.Columns.Add(colvarIDAdscripcion);
				
				TableSchema.TableColumn colvarIDUsuario = new TableSchema.TableColumn(schema);
				colvarIDUsuario.ColumnName = "IDUsuario";
				colvarIDUsuario.DataType = DbType.Int32;
				colvarIDUsuario.MaxLength = 0;
				colvarIDUsuario.AutoIncrement = false;
				colvarIDUsuario.IsNullable = true;
				colvarIDUsuario.IsPrimaryKey = false;
				colvarIDUsuario.IsForeignKey = true;
				colvarIDUsuario.IsReadOnly = false;
				colvarIDUsuario.DefaultSetting = @"";
				
					colvarIDUsuario.ForeignKeyTableName = "CatUsuarios";
				schema.Columns.Add(colvarIDUsuario);
				
				TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
				colvarStatus.ColumnName = "STATUS";
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
				DataService.Providers["Default"].AddSchema("RelCatAdscripcion",schema);
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
		  
		[XmlAttribute("IDAdscripcion")]
		[Bindable(true)]
		public int? IDAdscripcion 
		{
			get { return GetColumnValue<int?>(Columns.IDAdscripcion); }
			set { SetColumnValue(Columns.IDAdscripcion, value); }
		}
		  
		[XmlAttribute("IDUsuario")]
		[Bindable(true)]
		public int? IDUsuario 
		{
			get { return GetColumnValue<int?>(Columns.IDUsuario); }
			set { SetColumnValue(Columns.IDUsuario, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatAdscripcionRh ActiveRecord object related to this RelCatAdscripcion
		/// 
		/// </summary>
		public SubSonicDB.CatAdscripcionRh CatAdscripcionRh
		{
			get { return SubSonicDB.CatAdscripcionRh.FetchByID(this.IDAdscripcion); }
			set { SetColumnValue("IDAdscripcion", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatUsuario ActiveRecord object related to this RelCatAdscripcion
		/// 
		/// </summary>
		public SubSonicDB.CatUsuario CatUsuario
		{
			get { return SubSonicDB.CatUsuario.FetchByID(this.IDUsuario); }
			set { SetColumnValue("IDUsuario", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIDAdscripcion,int? varIDUsuario,bool? varStatus)
		{
			RelCatAdscripcion item = new RelCatAdscripcion();
			
			item.IDAdscripcion = varIDAdscripcion;
			
			item.IDUsuario = varIDUsuario;
			
			item.Status = varStatus;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varIDAdscripcion,int? varIDUsuario,bool? varStatus)
		{
			RelCatAdscripcion item = new RelCatAdscripcion();
			
				item.Id = varId;
			
				item.IDAdscripcion = varIDAdscripcion;
			
				item.IDUsuario = varIDUsuario;
			
				item.Status = varStatus;
			
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
        
        
        
        public static TableSchema.TableColumn IDAdscripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IDUsuarioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string IDAdscripcion = @"IDAdscripcion";
			 public static string IDUsuario = @"IDUsuario";
			 public static string Status = @"STATUS";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}