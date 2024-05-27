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
	/// Strongly-typed collection for the TempActore class.
	/// </summary>
    [Serializable]
	public partial class TempActoreCollection : ActiveList<TempActore, TempActoreCollection>
	{	   
		public TempActoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TempActoreCollection</returns>
		public TempActoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TempActore o = this[i];
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
	/// This is an ActiveRecord class which wraps the TempActores table.
	/// </summary>
	[Serializable]
	public partial class TempActore : ActiveRecord<TempActore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TempActore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TempActore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TempActore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TempActore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TempActores", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarExpediente = new TableSchema.TableColumn(schema);
				colvarExpediente.ColumnName = "EXPEDIENTE";
				colvarExpediente.DataType = DbType.String;
				colvarExpediente.MaxLength = 50;
				colvarExpediente.AutoIncrement = false;
				colvarExpediente.IsNullable = true;
				colvarExpediente.IsPrimaryKey = false;
				colvarExpediente.IsForeignKey = false;
				colvarExpediente.IsReadOnly = false;
				colvarExpediente.DefaultSetting = @"";
				colvarExpediente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExpediente);
				
				TableSchema.TableColumn colvarIdactor = new TableSchema.TableColumn(schema);
				colvarIdactor.ColumnName = "IDACTOR";
				colvarIdactor.DataType = DbType.Int32;
				colvarIdactor.MaxLength = 0;
				colvarIdactor.AutoIncrement = true;
				colvarIdactor.IsNullable = false;
				colvarIdactor.IsPrimaryKey = true;
				colvarIdactor.IsForeignKey = false;
				colvarIdactor.IsReadOnly = false;
				colvarIdactor.DefaultSetting = @"";
				colvarIdactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdactor);
				
				TableSchema.TableColumn colvarNombreactor = new TableSchema.TableColumn(schema);
				colvarNombreactor.ColumnName = "NOMBREACTOR";
				colvarNombreactor.DataType = DbType.String;
				colvarNombreactor.MaxLength = 500;
				colvarNombreactor.AutoIncrement = false;
				colvarNombreactor.IsNullable = true;
				colvarNombreactor.IsPrimaryKey = false;
				colvarNombreactor.IsForeignKey = false;
				colvarNombreactor.IsReadOnly = false;
				colvarNombreactor.DefaultSetting = @"";
				colvarNombreactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombreactor);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TempActores",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Expediente")]
		[Bindable(true)]
		public string Expediente 
		{
			get { return GetColumnValue<string>(Columns.Expediente); }
			set { SetColumnValue(Columns.Expediente, value); }
		}
		  
		[XmlAttribute("Idactor")]
		[Bindable(true)]
		public int Idactor 
		{
			get { return GetColumnValue<int>(Columns.Idactor); }
			set { SetColumnValue(Columns.Idactor, value); }
		}
		  
		[XmlAttribute("Nombreactor")]
		[Bindable(true)]
		public string Nombreactor 
		{
			get { return GetColumnValue<string>(Columns.Nombreactor); }
			set { SetColumnValue(Columns.Nombreactor, value); }
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
			return new SubSonicDB.TempExpedienteCollection().Where(TempExpediente.Columns.Idactor, Idactor).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varExpediente,string varNombreactor)
		{
			TempActore item = new TempActore();
			
			item.Expediente = varExpediente;
			
			item.Nombreactor = varNombreactor;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varExpediente,int varIdactor,string varNombreactor)
		{
			TempActore item = new TempActore();
			
				item.Expediente = varExpediente;
			
				item.Idactor = varIdactor;
			
				item.Nombreactor = varNombreactor;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ExpedienteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdactorColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreactorColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Expediente = @"EXPEDIENTE";
			 public static string Idactor = @"IDACTOR";
			 public static string Nombreactor = @"NOMBREACTOR";
						
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
