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
	/// Strongly-typed collection for the TemAbogado class.
	/// </summary>
    [Serializable]
	public partial class TemAbogadoCollection : ActiveList<TemAbogado, TemAbogadoCollection>
	{	   
		public TemAbogadoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TemAbogadoCollection</returns>
		public TemAbogadoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TemAbogado o = this[i];
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
	/// This is an ActiveRecord class which wraps the TemAbogado table.
	/// </summary>
	[Serializable]
	public partial class TemAbogado : ActiveRecord<TemAbogado>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TemAbogado()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TemAbogado(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TemAbogado(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TemAbogado(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TemAbogado", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEXpediente = new TableSchema.TableColumn(schema);
				colvarEXpediente.ColumnName = "EXpediente";
				colvarEXpediente.DataType = DbType.String;
				colvarEXpediente.MaxLength = 500;
				colvarEXpediente.AutoIncrement = false;
				colvarEXpediente.IsNullable = true;
				colvarEXpediente.IsPrimaryKey = false;
				colvarEXpediente.IsForeignKey = false;
				colvarEXpediente.IsReadOnly = false;
				colvarEXpediente.DefaultSetting = @"";
				colvarEXpediente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEXpediente);
				
				TableSchema.TableColumn colvarIdAbogado = new TableSchema.TableColumn(schema);
				colvarIdAbogado.ColumnName = "idAbogado";
				colvarIdAbogado.DataType = DbType.Int32;
				colvarIdAbogado.MaxLength = 0;
				colvarIdAbogado.AutoIncrement = true;
				colvarIdAbogado.IsNullable = false;
				colvarIdAbogado.IsPrimaryKey = true;
				colvarIdAbogado.IsForeignKey = false;
				colvarIdAbogado.IsReadOnly = false;
				colvarIdAbogado.DefaultSetting = @"";
				colvarIdAbogado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAbogado);
				
				TableSchema.TableColumn colvarAbogado = new TableSchema.TableColumn(schema);
				colvarAbogado.ColumnName = "abogado";
				colvarAbogado.DataType = DbType.String;
				colvarAbogado.MaxLength = 500;
				colvarAbogado.AutoIncrement = false;
				colvarAbogado.IsNullable = true;
				colvarAbogado.IsPrimaryKey = false;
				colvarAbogado.IsForeignKey = false;
				colvarAbogado.IsReadOnly = false;
				colvarAbogado.DefaultSetting = @"";
				colvarAbogado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAbogado);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("TemAbogado",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EXpediente")]
		[Bindable(true)]
		public string EXpediente 
		{
			get { return GetColumnValue<string>(Columns.EXpediente); }
			set { SetColumnValue(Columns.EXpediente, value); }
		}
		  
		[XmlAttribute("IdAbogado")]
		[Bindable(true)]
		public int IdAbogado 
		{
			get { return GetColumnValue<int>(Columns.IdAbogado); }
			set { SetColumnValue(Columns.IdAbogado, value); }
		}
		  
		[XmlAttribute("Abogado")]
		[Bindable(true)]
		public string Abogado 
		{
			get { return GetColumnValue<string>(Columns.Abogado); }
			set { SetColumnValue(Columns.Abogado, value); }
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
			return new SubSonicDB.TempExpedienteCollection().Where(TempExpediente.Columns.Idabogado, IdAbogado).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varEXpediente,string varAbogado)
		{
			TemAbogado item = new TemAbogado();
			
			item.EXpediente = varEXpediente;
			
			item.Abogado = varAbogado;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varEXpediente,int varIdAbogado,string varAbogado)
		{
			TemAbogado item = new TemAbogado();
			
				item.EXpediente = varEXpediente;
			
				item.IdAbogado = varIdAbogado;
			
				item.Abogado = varAbogado;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EXpedienteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAbogadoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AbogadoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EXpediente = @"EXpediente";
			 public static string IdAbogado = @"idAbogado";
			 public static string Abogado = @"abogado";
						
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
