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
	/// Strongly-typed collection for the TemTipojuicio class.
	/// </summary>
    [Serializable]
	public partial class TemTipojuicioCollection : ActiveList<TemTipojuicio, TemTipojuicioCollection>
	{	   
		public TemTipojuicioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TemTipojuicioCollection</returns>
		public TemTipojuicioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TemTipojuicio o = this[i];
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
	/// This is an ActiveRecord class which wraps the TemTipojuicio table.
	/// </summary>
	[Serializable]
	public partial class TemTipojuicio : ActiveRecord<TemTipojuicio>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TemTipojuicio()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TemTipojuicio(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TemTipojuicio(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TemTipojuicio(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TemTipojuicio", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIDTipoJuicio = new TableSchema.TableColumn(schema);
				colvarIDTipoJuicio.ColumnName = "IDTipoJuicio";
				colvarIDTipoJuicio.DataType = DbType.Int32;
				colvarIDTipoJuicio.MaxLength = 0;
				colvarIDTipoJuicio.AutoIncrement = true;
				colvarIDTipoJuicio.IsNullable = false;
				colvarIDTipoJuicio.IsPrimaryKey = true;
				colvarIDTipoJuicio.IsForeignKey = false;
				colvarIDTipoJuicio.IsReadOnly = false;
				colvarIDTipoJuicio.DefaultSetting = @"";
				colvarIDTipoJuicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDTipoJuicio);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "Descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 550;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TemTipojuicio",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IDTipoJuicio")]
		[Bindable(true)]
		public int IDTipoJuicio 
		{
			get { return GetColumnValue<int>(Columns.IDTipoJuicio); }
			set { SetColumnValue(Columns.IDTipoJuicio, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.TempExpedienteCollection TempExpedientes()
		{
			return new SubSonicDB.TempExpedienteCollection().Where(TempExpediente.Columns.Idtipojuicio, IDTipoJuicio).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion)
		{
			TemTipojuicio item = new TemTipojuicio();
			
			item.Descripcion = varDescripcion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIDTipoJuicio,string varDescripcion)
		{
			TemTipojuicio item = new TemTipojuicio();
			
				item.IDTipoJuicio = varIDTipoJuicio;
			
				item.Descripcion = varDescripcion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IDTipoJuicioColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IDTipoJuicio = @"IDTipoJuicio";
			 public static string Descripcion = @"Descripcion";
						
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
