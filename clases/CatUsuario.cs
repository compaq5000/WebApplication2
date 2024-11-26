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
	/// Strongly-typed collection for the CatUsuario class.
	/// </summary>
    [Serializable]
	public partial class CatUsuarioCollection : ActiveList<CatUsuario, CatUsuarioCollection>
	{	   
		public CatUsuarioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatUsuarioCollection</returns>
		public CatUsuarioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatUsuario o = this[i];
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
	/// This is an ActiveRecord class which wraps the CatUsuarios table.
	/// </summary>
	[Serializable]
	public partial class CatUsuario : ActiveRecord<CatUsuario>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatUsuario()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatUsuario(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatUsuario(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatUsuario(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CatUsuarios", TableType.Table, DataService.GetInstance("Default"));
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
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 650;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarNom = new TableSchema.TableColumn(schema);
				colvarNom.ColumnName = "Nom";
				colvarNom.DataType = DbType.String;
				colvarNom.MaxLength = 50;
				colvarNom.AutoIncrement = false;
				colvarNom.IsNullable = true;
				colvarNom.IsPrimaryKey = false;
				colvarNom.IsForeignKey = false;
				colvarNom.IsReadOnly = false;
				colvarNom.DefaultSetting = @"";
				colvarNom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNom);
				
				TableSchema.TableColumn colvarPaterno = new TableSchema.TableColumn(schema);
				colvarPaterno.ColumnName = "Paterno";
				colvarPaterno.DataType = DbType.String;
				colvarPaterno.MaxLength = 50;
				colvarPaterno.AutoIncrement = false;
				colvarPaterno.IsNullable = true;
				colvarPaterno.IsPrimaryKey = false;
				colvarPaterno.IsForeignKey = false;
				colvarPaterno.IsReadOnly = false;
				colvarPaterno.DefaultSetting = @"";
				colvarPaterno.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPaterno);
				
				TableSchema.TableColumn colvarMaterno = new TableSchema.TableColumn(schema);
				colvarMaterno.ColumnName = "Materno";
				colvarMaterno.DataType = DbType.String;
				colvarMaterno.MaxLength = 50;
				colvarMaterno.AutoIncrement = false;
				colvarMaterno.IsNullable = true;
				colvarMaterno.IsPrimaryKey = false;
				colvarMaterno.IsForeignKey = false;
				colvarMaterno.IsReadOnly = false;
				colvarMaterno.DefaultSetting = @"";
				colvarMaterno.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaterno);
				
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
				
				TableSchema.TableColumn colvarPassw = new TableSchema.TableColumn(schema);
				colvarPassw.ColumnName = "Passw";
				colvarPassw.DataType = DbType.String;
				colvarPassw.MaxLength = 50;
				colvarPassw.AutoIncrement = false;
				colvarPassw.IsNullable = true;
				colvarPassw.IsPrimaryKey = false;
				colvarPassw.IsForeignKey = false;
				colvarPassw.IsReadOnly = false;
				colvarPassw.DefaultSetting = @"";
				colvarPassw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPassw);
				
				TableSchema.TableColumn colvarUsuario = new TableSchema.TableColumn(schema);
				colvarUsuario.ColumnName = "Usuario";
				colvarUsuario.DataType = DbType.String;
				colvarUsuario.MaxLength = 50;
				colvarUsuario.AutoIncrement = false;
				colvarUsuario.IsNullable = true;
				colvarUsuario.IsPrimaryKey = false;
				colvarUsuario.IsForeignKey = false;
				colvarUsuario.IsReadOnly = false;
				colvarUsuario.DefaultSetting = @"";
				colvarUsuario.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUsuario);
				
				TableSchema.TableColumn colvarIDTipoUser = new TableSchema.TableColumn(schema);
				colvarIDTipoUser.ColumnName = "IDTipoUser";
				colvarIDTipoUser.DataType = DbType.Int32;
				colvarIDTipoUser.MaxLength = 0;
				colvarIDTipoUser.AutoIncrement = false;
				colvarIDTipoUser.IsNullable = true;
				colvarIDTipoUser.IsPrimaryKey = false;
				colvarIDTipoUser.IsForeignKey = false;
				colvarIDTipoUser.IsReadOnly = false;
				colvarIDTipoUser.DefaultSetting = @"";
				colvarIDTipoUser.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDTipoUser);
				
				TableSchema.TableColumn colvarImagen = new TableSchema.TableColumn(schema);
				colvarImagen.ColumnName = "Imagen";
				colvarImagen.DataType = DbType.String;
				colvarImagen.MaxLength = 500;
				colvarImagen.AutoIncrement = false;
				colvarImagen.IsNullable = true;
				colvarImagen.IsPrimaryKey = false;
				colvarImagen.IsForeignKey = false;
				colvarImagen.IsReadOnly = false;
				colvarImagen.DefaultSetting = @"";
				colvarImagen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarImagen);
				
				TableSchema.TableColumn colvarExtension = new TableSchema.TableColumn(schema);
				colvarExtension.ColumnName = "Extension";
				colvarExtension.DataType = DbType.String;
				colvarExtension.MaxLength = 4;
				colvarExtension.AutoIncrement = false;
				colvarExtension.IsNullable = true;
				colvarExtension.IsPrimaryKey = false;
				colvarExtension.IsForeignKey = false;
				colvarExtension.IsReadOnly = false;
				colvarExtension.DefaultSetting = @"";
				colvarExtension.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExtension);
				
				TableSchema.TableColumn colvarSkin = new TableSchema.TableColumn(schema);
				colvarSkin.ColumnName = "skin";
				colvarSkin.DataType = DbType.Int32;
				colvarSkin.MaxLength = 0;
				colvarSkin.AutoIncrement = false;
				colvarSkin.IsNullable = true;
				colvarSkin.IsPrimaryKey = false;
				colvarSkin.IsForeignKey = false;
				colvarSkin.IsReadOnly = false;
				colvarSkin.DefaultSetting = @"";
				colvarSkin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSkin);
				
				TableSchema.TableColumn colvarCorreo = new TableSchema.TableColumn(schema);
				colvarCorreo.ColumnName = "Correo";
				colvarCorreo.DataType = DbType.String;
				colvarCorreo.MaxLength = 50;
				colvarCorreo.AutoIncrement = false;
				colvarCorreo.IsNullable = true;
				colvarCorreo.IsPrimaryKey = false;
				colvarCorreo.IsForeignKey = false;
				colvarCorreo.IsReadOnly = false;
				colvarCorreo.DefaultSetting = @"";
				colvarCorreo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCorreo);
				
				TableSchema.TableColumn colvarNoempleado = new TableSchema.TableColumn(schema);
				colvarNoempleado.ColumnName = "NOEMPLEADO";
				colvarNoempleado.DataType = DbType.String;
				colvarNoempleado.MaxLength = 50;
				colvarNoempleado.AutoIncrement = false;
				colvarNoempleado.IsNullable = true;
				colvarNoempleado.IsPrimaryKey = false;
				colvarNoempleado.IsForeignKey = false;
				colvarNoempleado.IsReadOnly = false;
				colvarNoempleado.DefaultSetting = @"";
				colvarNoempleado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoempleado);
				
				TableSchema.TableColumn colvarSueldo = new TableSchema.TableColumn(schema);
				colvarSueldo.ColumnName = "SUELDO";
				colvarSueldo.DataType = DbType.Currency;
				colvarSueldo.MaxLength = 0;
				colvarSueldo.AutoIncrement = false;
				colvarSueldo.IsNullable = true;
				colvarSueldo.IsPrimaryKey = false;
				colvarSueldo.IsForeignKey = false;
				colvarSueldo.IsReadOnly = false;
				colvarSueldo.DefaultSetting = @"";
				colvarSueldo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSueldo);
				
				TableSchema.TableColumn colvarRfc = new TableSchema.TableColumn(schema);
				colvarRfc.ColumnName = "RFC";
				colvarRfc.DataType = DbType.String;
				colvarRfc.MaxLength = 50;
				colvarRfc.AutoIncrement = false;
				colvarRfc.IsNullable = true;
				colvarRfc.IsPrimaryKey = false;
				colvarRfc.IsForeignKey = false;
				colvarRfc.IsReadOnly = false;
				colvarRfc.DefaultSetting = @"";
				colvarRfc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRfc);
				
				TableSchema.TableColumn colvarFechaIngreso = new TableSchema.TableColumn(schema);
				colvarFechaIngreso.ColumnName = "FechaIngreso";
				colvarFechaIngreso.DataType = DbType.DateTime;
				colvarFechaIngreso.MaxLength = 0;
				colvarFechaIngreso.AutoIncrement = false;
				colvarFechaIngreso.IsNullable = true;
				colvarFechaIngreso.IsPrimaryKey = false;
				colvarFechaIngreso.IsForeignKey = false;
				colvarFechaIngreso.IsReadOnly = false;
				colvarFechaIngreso.DefaultSetting = @"";
				colvarFechaIngreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaIngreso);
				
				TableSchema.TableColumn colvarCalle = new TableSchema.TableColumn(schema);
				colvarCalle.ColumnName = "Calle";
				colvarCalle.DataType = DbType.String;
				colvarCalle.MaxLength = 50;
				colvarCalle.AutoIncrement = false;
				colvarCalle.IsNullable = true;
				colvarCalle.IsPrimaryKey = false;
				colvarCalle.IsForeignKey = false;
				colvarCalle.IsReadOnly = false;
				colvarCalle.DefaultSetting = @"";
				colvarCalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCalle);
				
				TableSchema.TableColumn colvarColonila = new TableSchema.TableColumn(schema);
				colvarColonila.ColumnName = "Colonila";
				colvarColonila.DataType = DbType.String;
				colvarColonila.MaxLength = 50;
				colvarColonila.AutoIncrement = false;
				colvarColonila.IsNullable = true;
				colvarColonila.IsPrimaryKey = false;
				colvarColonila.IsForeignKey = false;
				colvarColonila.IsReadOnly = false;
				colvarColonila.DefaultSetting = @"";
				colvarColonila.ForeignKeyTableName = "";
				schema.Columns.Add(colvarColonila);
				
				TableSchema.TableColumn colvarNoCalle = new TableSchema.TableColumn(schema);
				colvarNoCalle.ColumnName = "NoCalle";
				colvarNoCalle.DataType = DbType.String;
				colvarNoCalle.MaxLength = 50;
				colvarNoCalle.AutoIncrement = false;
				colvarNoCalle.IsNullable = true;
				colvarNoCalle.IsPrimaryKey = false;
				colvarNoCalle.IsForeignKey = false;
				colvarNoCalle.IsReadOnly = false;
				colvarNoCalle.DefaultSetting = @"";
				colvarNoCalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoCalle);
				
				TableSchema.TableColumn colvarCelular = new TableSchema.TableColumn(schema);
				colvarCelular.ColumnName = "Celular";
				colvarCelular.DataType = DbType.String;
				colvarCelular.MaxLength = 50;
				colvarCelular.AutoIncrement = false;
				colvarCelular.IsNullable = true;
				colvarCelular.IsPrimaryKey = false;
				colvarCelular.IsForeignKey = false;
				colvarCelular.IsReadOnly = false;
				colvarCelular.DefaultSetting = @"";
				colvarCelular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCelular);
				
				TableSchema.TableColumn colvarTelCasa = new TableSchema.TableColumn(schema);
				colvarTelCasa.ColumnName = "TelCasa";
				colvarTelCasa.DataType = DbType.String;
				colvarTelCasa.MaxLength = 50;
				colvarTelCasa.AutoIncrement = false;
				colvarTelCasa.IsNullable = true;
				colvarTelCasa.IsPrimaryKey = false;
				colvarTelCasa.IsForeignKey = false;
				colvarTelCasa.IsReadOnly = false;
				colvarTelCasa.DefaultSetting = @"";
				colvarTelCasa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelCasa);
				
				TableSchema.TableColumn colvarNombreContacto = new TableSchema.TableColumn(schema);
				colvarNombreContacto.ColumnName = "NombreContacto";
				colvarNombreContacto.DataType = DbType.String;
				colvarNombreContacto.MaxLength = 50;
				colvarNombreContacto.AutoIncrement = false;
				colvarNombreContacto.IsNullable = true;
				colvarNombreContacto.IsPrimaryKey = false;
				colvarNombreContacto.IsForeignKey = false;
				colvarNombreContacto.IsReadOnly = false;
				colvarNombreContacto.DefaultSetting = @"";
				colvarNombreContacto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombreContacto);
				
				TableSchema.TableColumn colvarTelContacto = new TableSchema.TableColumn(schema);
				colvarTelContacto.ColumnName = "TelContacto";
				colvarTelContacto.DataType = DbType.String;
				colvarTelContacto.MaxLength = 10;
				colvarTelContacto.AutoIncrement = false;
				colvarTelContacto.IsNullable = true;
				colvarTelContacto.IsPrimaryKey = false;
				colvarTelContacto.IsForeignKey = false;
				colvarTelContacto.IsReadOnly = false;
				colvarTelContacto.DefaultSetting = @"";
				colvarTelContacto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelContacto);
				
				TableSchema.TableColumn colvarIDTipoPlaza = new TableSchema.TableColumn(schema);
				colvarIDTipoPlaza.ColumnName = "IDTipoPlaza";
				colvarIDTipoPlaza.DataType = DbType.Int32;
				colvarIDTipoPlaza.MaxLength = 0;
				colvarIDTipoPlaza.AutoIncrement = false;
				colvarIDTipoPlaza.IsNullable = true;
				colvarIDTipoPlaza.IsPrimaryKey = false;
				colvarIDTipoPlaza.IsForeignKey = false;
				colvarIDTipoPlaza.IsReadOnly = false;
				colvarIDTipoPlaza.DefaultSetting = @"";
				colvarIDTipoPlaza.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDTipoPlaza);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("CatUsuarios",schema);
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
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Nom")]
		[Bindable(true)]
		public string Nom 
		{
			get { return GetColumnValue<string>(Columns.Nom); }
			set { SetColumnValue(Columns.Nom, value); }
		}
		  
		[XmlAttribute("Paterno")]
		[Bindable(true)]
		public string Paterno 
		{
			get { return GetColumnValue<string>(Columns.Paterno); }
			set { SetColumnValue(Columns.Paterno, value); }
		}
		  
		[XmlAttribute("Materno")]
		[Bindable(true)]
		public string Materno 
		{
			get { return GetColumnValue<string>(Columns.Materno); }
			set { SetColumnValue(Columns.Materno, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("Passw")]
		[Bindable(true)]
		public string Passw 
		{
			get { return GetColumnValue<string>(Columns.Passw); }
			set { SetColumnValue(Columns.Passw, value); }
		}
		  
		[XmlAttribute("Usuario")]
		[Bindable(true)]
		public string Usuario 
		{
			get { return GetColumnValue<string>(Columns.Usuario); }
			set { SetColumnValue(Columns.Usuario, value); }
		}
		  
		[XmlAttribute("IDTipoUser")]
		[Bindable(true)]
		public int? IDTipoUser 
		{
			get { return GetColumnValue<int?>(Columns.IDTipoUser); }
			set { SetColumnValue(Columns.IDTipoUser, value); }
		}
		  
		[XmlAttribute("Imagen")]
		[Bindable(true)]
		public string Imagen 
		{
			get { return GetColumnValue<string>(Columns.Imagen); }
			set { SetColumnValue(Columns.Imagen, value); }
		}
		  
		[XmlAttribute("Extension")]
		[Bindable(true)]
		public string Extension 
		{
			get { return GetColumnValue<string>(Columns.Extension); }
			set { SetColumnValue(Columns.Extension, value); }
		}
		  
		[XmlAttribute("Skin")]
		[Bindable(true)]
		public int? Skin 
		{
			get { return GetColumnValue<int?>(Columns.Skin); }
			set { SetColumnValue(Columns.Skin, value); }
		}
		  
		[XmlAttribute("Correo")]
		[Bindable(true)]
		public string Correo 
		{
			get { return GetColumnValue<string>(Columns.Correo); }
			set { SetColumnValue(Columns.Correo, value); }
		}
		  
		[XmlAttribute("Noempleado")]
		[Bindable(true)]
		public string Noempleado 
		{
			get { return GetColumnValue<string>(Columns.Noempleado); }
			set { SetColumnValue(Columns.Noempleado, value); }
		}
		  
		[XmlAttribute("Sueldo")]
		[Bindable(true)]
		public decimal? Sueldo 
		{
			get { return GetColumnValue<decimal?>(Columns.Sueldo); }
			set { SetColumnValue(Columns.Sueldo, value); }
		}
		  
		[XmlAttribute("Rfc")]
		[Bindable(true)]
		public string Rfc 
		{
			get { return GetColumnValue<string>(Columns.Rfc); }
			set { SetColumnValue(Columns.Rfc, value); }
		}
		  
		[XmlAttribute("FechaIngreso")]
		[Bindable(true)]
		public DateTime? FechaIngreso 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaIngreso); }
			set { SetColumnValue(Columns.FechaIngreso, value); }
		}
		  
		[XmlAttribute("Calle")]
		[Bindable(true)]
		public string Calle 
		{
			get { return GetColumnValue<string>(Columns.Calle); }
			set { SetColumnValue(Columns.Calle, value); }
		}
		  
		[XmlAttribute("Colonila")]
		[Bindable(true)]
		public string Colonila 
		{
			get { return GetColumnValue<string>(Columns.Colonila); }
			set { SetColumnValue(Columns.Colonila, value); }
		}
		  
		[XmlAttribute("NoCalle")]
		[Bindable(true)]
		public string NoCalle 
		{
			get { return GetColumnValue<string>(Columns.NoCalle); }
			set { SetColumnValue(Columns.NoCalle, value); }
		}
		  
		[XmlAttribute("Celular")]
		[Bindable(true)]
		public string Celular 
		{
			get { return GetColumnValue<string>(Columns.Celular); }
			set { SetColumnValue(Columns.Celular, value); }
		}
		  
		[XmlAttribute("TelCasa")]
		[Bindable(true)]
		public string TelCasa 
		{
			get { return GetColumnValue<string>(Columns.TelCasa); }
			set { SetColumnValue(Columns.TelCasa, value); }
		}
		  
		[XmlAttribute("NombreContacto")]
		[Bindable(true)]
		public string NombreContacto 
		{
			get { return GetColumnValue<string>(Columns.NombreContacto); }
			set { SetColumnValue(Columns.NombreContacto, value); }
		}
		  
		[XmlAttribute("TelContacto")]
		[Bindable(true)]
		public string TelContacto 
		{
			get { return GetColumnValue<string>(Columns.TelContacto); }
			set { SetColumnValue(Columns.TelContacto, value); }
		}
		  
		[XmlAttribute("IDTipoPlaza")]
		[Bindable(true)]
		public int? IDTipoPlaza 
		{
			get { return GetColumnValue<int?>(Columns.IDTipoPlaza); }
			set { SetColumnValue(Columns.IDTipoPlaza, value); }
		}
		  
		[XmlAttribute("IDMunicipio")]
		[Bindable(true)]
		public int? IDMunicipio 
		{
			get { return GetColumnValue<int?>(Columns.IDMunicipio); }
			set { SetColumnValue(Columns.IDMunicipio, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.HistirlaExpedienteCollection HistirlaExpedienteRecords()
		{
			return new SubSonicDB.HistirlaExpedienteCollection().Where(HistirlaExpediente.Columns.IDUsuario, Id).Load();
		}
		public SubSonicDB.RelCatAdscripcionCollection RelCatAdscripcionRecords()
		{
			return new SubSonicDB.RelCatAdscripcionCollection().Where(RelCatAdscripcion.Columns.IDUsuario, Id).Load();
		}
		public SubSonicDB.RelCatArchivoDigitalRHCollection RelCatArchivoDigitalRHRecords()
		{
			return new SubSonicDB.RelCatArchivoDigitalRHCollection().Where(RelCatArchivoDigitalRH.Columns.IDUasuario, Id).Load();
		}
		public SubSonicDB.RelCatArchivoDigitalRHCollection RelCatArchivoDigitalRHRecordsFromCatUsuario()
		{
			return new SubSonicDB.RelCatArchivoDigitalRHCollection().Where(RelCatArchivoDigitalRH.Columns.CargadoPor, Id).Load();
		}
		public SubSonicDB.RelCatCategoriaRhCollection RelCatCategoriaRhRecords()
		{
			return new SubSonicDB.RelCatCategoriaRhCollection().Where(RelCatCategoriaRh.Columns.IDUsuario, Id).Load();
		}
		public SubSonicDB.RelCatTipoplazaRhCollection RelCatTipoplazaRhRecords()
		{
			return new SubSonicDB.RelCatTipoplazaRhCollection().Where(RelCatTipoplazaRh.Columns.IDUsuario, Id).Load();
		}
		public SubSonicDB.RelFuncionesUsuarioRHCollection RelFuncionesUsuarioRHRecords()
		{
			return new SubSonicDB.RelFuncionesUsuarioRHCollection().Where(RelFuncionesUsuarioRH.Columns.IDUsuario, Id).Load();
		}
		public SubSonicDB.RelTipoPermisoRHCollection RelTipoPermisoRHRecords()
		{
			return new SubSonicDB.RelTipoPermisoRHCollection().Where(RelTipoPermisoRH.Columns.IDUser, Id).Load();
		}
		public SubSonicDB.SoporteTranServicioCollection SoporteTranServicioRecords()
		{
			return new SubSonicDB.SoporteTranServicioCollection().Where(SoporteTranServicio.Columns.IDUser, Id).Load();
		}
		public SubSonicDB.TranPermisoCollection TranPermisos()
		{
			return new SubSonicDB.TranPermisoCollection().Where(TranPermiso.Columns.IDUser, Id).Load();
		}
		public SubSonicDB.TranInsidenciasRHCollection TranInsidenciasRHRecords()
		{
			return new SubSonicDB.TranInsidenciasRHCollection().Where(TranInsidenciasRH.Columns.IDUser, Id).Load();
		}
		public SubSonicDB.TranMinutumCollection TranMinuta()
		{
			return new SubSonicDB.TranMinutumCollection().Where(TranMinutum.Columns.IDUser, Id).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatMunicipioFortamun ActiveRecord object related to this CatUsuario
		/// 
		/// </summary>
		public SubSonicDB.CatMunicipioFortamun CatMunicipioFortamun
		{
			get { return SubSonicDB.CatMunicipioFortamun.FetchByID(this.IDMunicipio); }
			set { SetColumnValue("IDMunicipio", value.Id); }
		}
		
		
		#endregion
		
		
		
		#region Many To Many Helpers
		
		 
		public SubSonicDB.CatAnoVacacionesRhCollection GetCatAnoVacacionesRhCollection() { return CatUsuario.GetCatAnoVacacionesRhCollection(this.Id); }
		public static SubSonicDB.CatAnoVacacionesRhCollection GetCatAnoVacacionesRhCollection(int varId)
		{
		    SubSonic.QueryCommand cmd = new SubSonic.QueryCommand("SELECT * FROM [dbo].[CatAnoVacaciones_RH] INNER JOIN [RelTipoPermisoRH] ON [CatAnoVacaciones_RH].[ID] = [RelTipoPermisoRH].[IDano] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmd.AddParameter("@IDUser", varId, DbType.Int32);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			CatAnoVacacionesRhCollection coll = new CatAnoVacacionesRhCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}
		
		public static void SaveCatAnoVacacionesRhMap(int varId, CatAnoVacacionesRhCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (CatAnoVacacionesRh item in items)
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
				varRelTipoPermisoRH.SetColumnValue("IDano", item.GetPrimaryKeyValue());
				varRelTipoPermisoRH.Save();
			}
		}
		public static void SaveCatAnoVacacionesRhMap(int varId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
					varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
					varRelTipoPermisoRH.SetColumnValue("IDano", l.Value);
					varRelTipoPermisoRH.Save();
				}
			}
		}
		public static void SaveCatAnoVacacionesRhMap(int varId , int[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (int item in itemList) 
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
				varRelTipoPermisoRH.SetColumnValue("IDano", item);
				varRelTipoPermisoRH.Save();
			}
		}
		
		public static void DeleteCatAnoVacacionesRhMap(int varId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			DataService.ExecuteQuery(cmdDel);
		}
		
		 
		public SubSonicDB.CatPeriodoVAcaionesRhCollection GetCatPeriodoVAcaionesRhCollection() { return CatUsuario.GetCatPeriodoVAcaionesRhCollection(this.Id); }
		public static SubSonicDB.CatPeriodoVAcaionesRhCollection GetCatPeriodoVAcaionesRhCollection(int varId)
		{
		    SubSonic.QueryCommand cmd = new SubSonic.QueryCommand("SELECT * FROM [dbo].[CatPeriodoVAcaiones_RH] INNER JOIN [RelTipoPermisoRH] ON [CatPeriodoVAcaiones_RH].[ID] = [RelTipoPermisoRH].[IDPeriodo] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmd.AddParameter("@IDUser", varId, DbType.Int32);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			CatPeriodoVAcaionesRhCollection coll = new CatPeriodoVAcaionesRhCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}
		
		public static void SaveCatPeriodoVAcaionesRhMap(int varId, CatPeriodoVAcaionesRhCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (CatPeriodoVAcaionesRh item in items)
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", item.GetPrimaryKeyValue());
				varRelTipoPermisoRH.Save();
			}
		}
		public static void SaveCatPeriodoVAcaionesRhMap(int varId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
					varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
					varRelTipoPermisoRH.SetColumnValue("IDPeriodo", l.Value);
					varRelTipoPermisoRH.Save();
				}
			}
		}
		public static void SaveCatPeriodoVAcaionesRhMap(int varId , int[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (int item in itemList) 
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDUser", varId);
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", item);
				varRelTipoPermisoRH.Save();
			}
		}
		
		public static void DeleteCatPeriodoVAcaionesRhMap(int varId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDUser] = @IDUser", CatUsuario.Schema.Provider.Name);
			cmdDel.AddParameter("@IDUser", varId, DbType.Int32);
			DataService.ExecuteQuery(cmdDel);
		}
		
		#endregion
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varNom,string varPaterno,string varMaterno,bool? varStatus,string varPassw,string varUsuario,int? varIDTipoUser,string varImagen,string varExtension,int? varSkin,string varCorreo,string varNoempleado,decimal? varSueldo,string varRfc,DateTime? varFechaIngreso,string varCalle,string varColonila,string varNoCalle,string varCelular,string varTelCasa,string varNombreContacto,string varTelContacto,int? varIDTipoPlaza,int? varIDMunicipio)
		{
			CatUsuario item = new CatUsuario();
			
			item.Nombre = varNombre;
			
			item.Nom = varNom;
			
			item.Paterno = varPaterno;
			
			item.Materno = varMaterno;
			
			item.Status = varStatus;
			
			item.Passw = varPassw;
			
			item.Usuario = varUsuario;
			
			item.IDTipoUser = varIDTipoUser;
			
			item.Imagen = varImagen;
			
			item.Extension = varExtension;
			
			item.Skin = varSkin;
			
			item.Correo = varCorreo;
			
			item.Noempleado = varNoempleado;
			
			item.Sueldo = varSueldo;
			
			item.Rfc = varRfc;
			
			item.FechaIngreso = varFechaIngreso;
			
			item.Calle = varCalle;
			
			item.Colonila = varColonila;
			
			item.NoCalle = varNoCalle;
			
			item.Celular = varCelular;
			
			item.TelCasa = varTelCasa;
			
			item.NombreContacto = varNombreContacto;
			
			item.TelContacto = varTelContacto;
			
			item.IDTipoPlaza = varIDTipoPlaza;
			
			item.IDMunicipio = varIDMunicipio;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varNombre,string varNom,string varPaterno,string varMaterno,bool? varStatus,string varPassw,string varUsuario,int? varIDTipoUser,string varImagen,string varExtension,int? varSkin,string varCorreo,string varNoempleado,decimal? varSueldo,string varRfc,DateTime? varFechaIngreso,string varCalle,string varColonila,string varNoCalle,string varCelular,string varTelCasa,string varNombreContacto,string varTelContacto,int? varIDTipoPlaza,int? varIDMunicipio)
		{
			CatUsuario item = new CatUsuario();
			
				item.Id = varId;
			
				item.Nombre = varNombre;
			
				item.Nom = varNom;
			
				item.Paterno = varPaterno;
			
				item.Materno = varMaterno;
			
				item.Status = varStatus;
			
				item.Passw = varPassw;
			
				item.Usuario = varUsuario;
			
				item.IDTipoUser = varIDTipoUser;
			
				item.Imagen = varImagen;
			
				item.Extension = varExtension;
			
				item.Skin = varSkin;
			
				item.Correo = varCorreo;
			
				item.Noempleado = varNoempleado;
			
				item.Sueldo = varSueldo;
			
				item.Rfc = varRfc;
			
				item.FechaIngreso = varFechaIngreso;
			
				item.Calle = varCalle;
			
				item.Colonila = varColonila;
			
				item.NoCalle = varNoCalle;
			
				item.Celular = varCelular;
			
				item.TelCasa = varTelCasa;
			
				item.NombreContacto = varNombreContacto;
			
				item.TelContacto = varTelContacto;
			
				item.IDTipoPlaza = varIDTipoPlaza;
			
				item.IDMunicipio = varIDMunicipio;
			
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
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NomColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PaternoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MaternoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PasswColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn UsuarioColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTipoUserColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ImagenColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ExtensionColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SkinColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn CorreoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn NoempleadoColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn SueldoColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn RfcColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaIngresoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn CalleColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn ColonilaColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn NoCalleColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn CelularColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn TelCasaColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreContactoColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn TelContactoColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTipoPlazaColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn IDMunicipioColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Nombre = @"Nombre";
			 public static string Nom = @"Nom";
			 public static string Paterno = @"Paterno";
			 public static string Materno = @"Materno";
			 public static string Status = @"status";
			 public static string Passw = @"Passw";
			 public static string Usuario = @"Usuario";
			 public static string IDTipoUser = @"IDTipoUser";
			 public static string Imagen = @"Imagen";
			 public static string Extension = @"Extension";
			 public static string Skin = @"skin";
			 public static string Correo = @"Correo";
			 public static string Noempleado = @"NOEMPLEADO";
			 public static string Sueldo = @"SUELDO";
			 public static string Rfc = @"RFC";
			 public static string FechaIngreso = @"FechaIngreso";
			 public static string Calle = @"Calle";
			 public static string Colonila = @"Colonila";
			 public static string NoCalle = @"NoCalle";
			 public static string Celular = @"Celular";
			 public static string TelCasa = @"TelCasa";
			 public static string NombreContacto = @"NombreContacto";
			 public static string TelContacto = @"TelContacto";
			 public static string IDTipoPlaza = @"IDTipoPlaza";
			 public static string IDMunicipio = @"IDMunicipio";
						
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
