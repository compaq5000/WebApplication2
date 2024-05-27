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
	/// Strongly-typed collection for the RelCatTipoplazaRh class.
	/// </summary>
    [Serializable]
	public partial class RelCatTipoplazaRhCollection : ActiveList<RelCatTipoplazaRh, RelCatTipoplazaRhCollection>
	{	   
		public RelCatTipoplazaRhCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelCatTipoplazaRhCollection</returns>
		public RelCatTipoplazaRhCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelCatTipoplazaRh o = this[i];
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
	/// This is an ActiveRecord class which wraps the RelCatTipoplaza_RH table.
	/// </summary>
	[Serializable]
	public partial class RelCatTipoplazaRh : ActiveRecord<RelCatTipoplazaRh>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RelCatTipoplazaRh()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RelCatTipoplazaRh(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RelCatTipoplazaRh(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RelCatTipoplazaRh(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RelCatTipoplaza_RH", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarIDTipoPlaza = new TableSchema.TableColumn(schema);
				colvarIDTipoPlaza.ColumnName = "IDTipoPlaza";
				colvarIDTipoPlaza.DataType = DbType.Int32;
				colvarIDTipoPlaza.MaxLength = 0;
				colvarIDTipoPlaza.AutoIncrement = false;
				colvarIDTipoPlaza.IsNullable = true;
				colvarIDTipoPlaza.IsPrimaryKey = false;
				colvarIDTipoPlaza.IsForeignKey = true;
				colvarIDTipoPlaza.IsReadOnly = false;
				colvarIDTipoPlaza.DefaultSetting = @"";
				
					colvarIDTipoPlaza.ForeignKeyTableName = "CatTipoPlaza_RH";
				schema.Columns.Add(colvarIDTipoPlaza);
				
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
				DataService.Providers["Default"].AddSchema("RelCatTipoplaza_RH",schema);
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
		  
		[XmlAttribute("IDTipoPlaza")]
		[Bindable(true)]
		public int? IDTipoPlaza 
		{
			get { return GetColumnValue<int?>(Columns.IDTipoPlaza); }
			set { SetColumnValue(Columns.IDTipoPlaza, value); }
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
		/// Returns a CatTipoPlazaRh ActiveRecord object related to this RelCatTipoplazaRh
		/// 
		/// </summary>
		public SubSonicDB.CatTipoPlazaRh CatTipoPlazaRh
		{
			get { return SubSonicDB.CatTipoPlazaRh.FetchByID(this.IDTipoPlaza); }
			set { SetColumnValue("IDTipoPlaza", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatUsuario ActiveRecord object related to this RelCatTipoplazaRh
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
		public static void Insert(int? varIDTipoPlaza,int? varIDUsuario,bool? varStatus)
		{
			RelCatTipoplazaRh item = new RelCatTipoplazaRh();
			
			item.IDTipoPlaza = varIDTipoPlaza;
			
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
		public static void Update(int varId,int? varIDTipoPlaza,int? varIDUsuario,bool? varStatus)
		{
			RelCatTipoplazaRh item = new RelCatTipoplazaRh();
			
				item.Id = varId;
			
				item.IDTipoPlaza = varIDTipoPlaza;
			
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
        
        
        
        public static TableSchema.TableColumn IDTipoPlazaColumn
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
			 public static string IDTipoPlaza = @"IDTipoPlaza";
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
