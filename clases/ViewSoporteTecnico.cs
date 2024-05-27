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
namespace SubSonicDB{
    /// <summary>
    /// Strongly-typed collection for the ViewSoporteTecnico class.
    /// </summary>
    [Serializable]
    public partial class ViewSoporteTecnicoCollection : ReadOnlyList<ViewSoporteTecnico, ViewSoporteTecnicoCollection>
    {        
        public ViewSoporteTecnicoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_SoporteTecnico view.
    /// </summary>
    [Serializable]
    public partial class ViewSoporteTecnico : ReadOnlyRecord<ViewSoporteTecnico>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("View_SoporteTecnico", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarNombreCompleto = new TableSchema.TableColumn(schema);
                colvarNombreCompleto.ColumnName = "NombreCompleto";
                colvarNombreCompleto.DataType = DbType.String;
                colvarNombreCompleto.MaxLength = 752;
                colvarNombreCompleto.AutoIncrement = false;
                colvarNombreCompleto.IsNullable = true;
                colvarNombreCompleto.IsPrimaryKey = false;
                colvarNombreCompleto.IsForeignKey = false;
                colvarNombreCompleto.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombreCompleto);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 50;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
                colvarIDUser.ColumnName = "IDUser";
                colvarIDUser.DataType = DbType.Int32;
                colvarIDUser.MaxLength = 0;
                colvarIDUser.AutoIncrement = false;
                colvarIDUser.IsNullable = true;
                colvarIDUser.IsPrimaryKey = false;
                colvarIDUser.IsForeignKey = false;
                colvarIDUser.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDUser);
                
                TableSchema.TableColumn colvarFechaAlta = new TableSchema.TableColumn(schema);
                colvarFechaAlta.ColumnName = "FechaAlta";
                colvarFechaAlta.DataType = DbType.DateTime;
                colvarFechaAlta.MaxLength = 0;
                colvarFechaAlta.AutoIncrement = false;
                colvarFechaAlta.IsNullable = true;
                colvarFechaAlta.IsPrimaryKey = false;
                colvarFechaAlta.IsForeignKey = false;
                colvarFechaAlta.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaAlta);
                
                TableSchema.TableColumn colvarFechaAtencion = new TableSchema.TableColumn(schema);
                colvarFechaAtencion.ColumnName = "FechaAtencion";
                colvarFechaAtencion.DataType = DbType.DateTime;
                colvarFechaAtencion.MaxLength = 0;
                colvarFechaAtencion.AutoIncrement = false;
                colvarFechaAtencion.IsNullable = true;
                colvarFechaAtencion.IsPrimaryKey = false;
                colvarFechaAtencion.IsForeignKey = false;
                colvarFechaAtencion.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaAtencion);
                
                TableSchema.TableColumn colvarServicio = new TableSchema.TableColumn(schema);
                colvarServicio.ColumnName = "Servicio";
                colvarServicio.DataType = DbType.String;
                colvarServicio.MaxLength = 500;
                colvarServicio.AutoIncrement = false;
                colvarServicio.IsNullable = true;
                colvarServicio.IsPrimaryKey = false;
                colvarServicio.IsForeignKey = false;
                colvarServicio.IsReadOnly = false;
                
                schema.Columns.Add(colvarServicio);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Boolean;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
                schema.Columns.Add(colvarId);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_SoporteTecnico",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public ViewSoporteTecnico()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewSoporteTecnico(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewSoporteTecnico(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewSoporteTecnico(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("NombreCompleto")]
        [Bindable(true)]
        public string NombreCompleto 
	    {
		    get
		    {
			    return GetColumnValue<string>("NombreCompleto");
		    }
            set 
		    {
			    SetColumnValue("NombreCompleto", value);
            }
        }
	      
        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion 
	    {
		    get
		    {
			    return GetColumnValue<string>("Descripcion");
		    }
            set 
		    {
			    SetColumnValue("Descripcion", value);
            }
        }
	      
        [XmlAttribute("IDUser")]
        [Bindable(true)]
        public int? IDUser 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDUser");
		    }
            set 
		    {
			    SetColumnValue("IDUser", value);
            }
        }
	      
        [XmlAttribute("FechaAlta")]
        [Bindable(true)]
        public DateTime? FechaAlta 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("FechaAlta");
		    }
            set 
		    {
			    SetColumnValue("FechaAlta", value);
            }
        }
	      
        [XmlAttribute("FechaAtencion")]
        [Bindable(true)]
        public DateTime? FechaAtencion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("FechaAtencion");
		    }
            set 
		    {
			    SetColumnValue("FechaAtencion", value);
            }
        }
	      
        [XmlAttribute("Servicio")]
        [Bindable(true)]
        public string Servicio 
	    {
		    get
		    {
			    return GetColumnValue<string>("Servicio");
		    }
            set 
		    {
			    SetColumnValue("Servicio", value);
            }
        }
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("status");
		    }
            set 
		    {
			    SetColumnValue("status", value);
            }
        }
	      
        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id 
	    {
		    get
		    {
			    return GetColumnValue<int>("ID");
		    }
            set 
		    {
			    SetColumnValue("ID", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string NombreCompleto = @"NombreCompleto";
            
            public static string Descripcion = @"Descripcion";
            
            public static string IDUser = @"IDUser";
            
            public static string FechaAlta = @"FechaAlta";
            
            public static string FechaAtencion = @"FechaAtencion";
            
            public static string Servicio = @"Servicio";
            
            public static string Status = @"status";
            
            public static string Id = @"ID";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
