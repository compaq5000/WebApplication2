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
	/// Strongly-typed collection for the TranContactoFortamun class.
	/// </summary>
    [Serializable]
	public partial class TranContactoFortamunCollection : ActiveList<TranContactoFortamun, TranContactoFortamunCollection>
	{	   
		public TranContactoFortamunCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TranContactoFortamunCollection</returns>
		public TranContactoFortamunCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TranContactoFortamun o = this[i];
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
	/// This is an ActiveRecord class which wraps the Tran_Contacto_fortamun table.
	/// </summary>
	[Serializable]
	public partial class TranContactoFortamun : ActiveRecord<TranContactoFortamun>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TranContactoFortamun()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TranContactoFortamun(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TranContactoFortamun(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TranContactoFortamun(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Tran_Contacto_fortamun", TableType.Table, DataService.GetInstance("Default"));
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
				colvarDescripcion.MaxLength = 500;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
				colvarStatus.ColumnName = "Status";
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
				
				TableSchema.TableColumn colvarIDMunicipio = new TableSchema.TableColumn(schema);
				colvarIDMunicipio.ColumnName = "IDMunicipio";
				colvarIDMunicipio.DataType = DbType.Int32;
				colvarIDMunicipio.MaxLength = 0;
				colvarIDMunicipio.AutoIncrement = false;
				colvarIDMunicipio.IsNullable = true;
				colvarIDMunicipio.IsPrimaryKey = false;
				colvarIDMunicipio.IsForeignKey = true;
				colvarIDMunicipio.IsReadOnly = false;
				colvarIDMunicipio.DefaultSetting = @"";
				
					colvarIDMunicipio.ForeignKeyTableName = "Cat_Municipio_fortamun";
				schema.Columns.Add(colvarIDMunicipio);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "EMAIL";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 50;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = true;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
				TableSchema.TableColumn colvarMovil = new TableSchema.TableColumn(schema);
				colvarMovil.ColumnName = "Movil";
				colvarMovil.DataType = DbType.String;
				colvarMovil.MaxLength = 50;
				colvarMovil.AutoIncrement = false;
				colvarMovil.IsNullable = true;
				colvarMovil.IsPrimaryKey = false;
				colvarMovil.IsForeignKey = false;
				colvarMovil.IsReadOnly = false;
				colvarMovil.DefaultSetting = @"";
				colvarMovil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMovil);
				
				TableSchema.TableColumn colvarOtroTel = new TableSchema.TableColumn(schema);
				colvarOtroTel.ColumnName = "otroTel";
				colvarOtroTel.DataType = DbType.String;
				colvarOtroTel.MaxLength = 50;
				colvarOtroTel.AutoIncrement = false;
				colvarOtroTel.IsNullable = true;
				colvarOtroTel.IsPrimaryKey = false;
				colvarOtroTel.IsForeignKey = false;
				colvarOtroTel.IsReadOnly = false;
				colvarOtroTel.DefaultSetting = @"";
				colvarOtroTel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtroTel);
				
				TableSchema.TableColumn colvarIDTipoContacto = new TableSchema.TableColumn(schema);
				colvarIDTipoContacto.ColumnName = "IDTipoContacto";
				colvarIDTipoContacto.DataType = DbType.Int32;
				colvarIDTipoContacto.MaxLength = 0;
				colvarIDTipoContacto.AutoIncrement = false;
				colvarIDTipoContacto.IsNullable = true;
				colvarIDTipoContacto.IsPrimaryKey = false;
				colvarIDTipoContacto.IsForeignKey = true;
				colvarIDTipoContacto.IsReadOnly = false;
				colvarIDTipoContacto.DefaultSetting = @"";
				
					colvarIDTipoContacto.ForeignKeyTableName = "Cat_TipoContacto_fortamun";
				schema.Columns.Add(colvarIDTipoContacto);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("Tran_Contacto_fortamun",schema);
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
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("IDMunicipio")]
		[Bindable(true)]
		public int? IDMunicipio 
		{
			get { return GetColumnValue<int?>(Columns.IDMunicipio); }
			set { SetColumnValue(Columns.IDMunicipio, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		  
		[XmlAttribute("Movil")]
		[Bindable(true)]
		public string Movil 
		{
			get { return GetColumnValue<string>(Columns.Movil); }
			set { SetColumnValue(Columns.Movil, value); }
		}
		  
		[XmlAttribute("OtroTel")]
		[Bindable(true)]
		public string OtroTel 
		{
			get { return GetColumnValue<string>(Columns.OtroTel); }
			set { SetColumnValue(Columns.OtroTel, value); }
		}
		  
		[XmlAttribute("IDTipoContacto")]
		[Bindable(true)]
		public int? IDTipoContacto 
		{
			get { return GetColumnValue<int?>(Columns.IDTipoContacto); }
			set { SetColumnValue(Columns.IDTipoContacto, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatMunicipioFortamun ActiveRecord object related to this TranContactoFortamun
		/// 
		/// </summary>
		public SubSonicDB.CatMunicipioFortamun CatMunicipioFortamun
		{
			get { return SubSonicDB.CatMunicipioFortamun.FetchByID(this.IDMunicipio); }
			set { SetColumnValue("IDMunicipio", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatTipoContactoFortamun ActiveRecord object related to this TranContactoFortamun
		/// 
		/// </summary>
		public SubSonicDB.CatTipoContactoFortamun CatTipoContactoFortamun
		{
			get { return SubSonicDB.CatTipoContactoFortamun.FetchByID(this.IDTipoContacto); }
			set { SetColumnValue("IDTipoContacto", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion,bool? varStatus,int? varIDMunicipio,string varEmail,string varMovil,string varOtroTel,int? varIDTipoContacto)
		{
			TranContactoFortamun item = new TranContactoFortamun();
			
			item.Descripcion = varDescripcion;
			
			item.Status = varStatus;
			
			item.IDMunicipio = varIDMunicipio;
			
			item.Email = varEmail;
			
			item.Movil = varMovil;
			
			item.OtroTel = varOtroTel;
			
			item.IDTipoContacto = varIDTipoContacto;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varDescripcion,bool? varStatus,int? varIDMunicipio,string varEmail,string varMovil,string varOtroTel,int? varIDTipoContacto)
		{
			TranContactoFortamun item = new TranContactoFortamun();
			
				item.Id = varId;
			
				item.Descripcion = varDescripcion;
			
				item.Status = varStatus;
			
				item.IDMunicipio = varIDMunicipio;
			
				item.Email = varEmail;
			
				item.Movil = varMovil;
			
				item.OtroTel = varOtroTel;
			
				item.IDTipoContacto = varIDTipoContacto;
			
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
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IDMunicipioColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MovilColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn OtroTelColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTipoContactoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Descripcion = @"Descripcion";
			 public static string Status = @"Status";
			 public static string IDMunicipio = @"IDMunicipio";
			 public static string Email = @"EMAIL";
			 public static string Movil = @"Movil";
			 public static string OtroTel = @"otroTel";
			 public static string IDTipoContacto = @"IDTipoContacto";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
