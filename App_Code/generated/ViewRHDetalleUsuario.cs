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
    /// Strongly-typed collection for the ViewRHDetalleUsuario class.
    /// </summary>
    [Serializable]
    public partial class ViewRHDetalleUsuarioCollection : ReadOnlyList<ViewRHDetalleUsuario, ViewRHDetalleUsuarioCollection>
    {        
        public ViewRHDetalleUsuarioCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_RHDetalleUsuarios view.
    /// </summary>
    [Serializable]
    public partial class ViewRHDetalleUsuario : ReadOnlyRecord<ViewRHDetalleUsuario>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_RHDetalleUsuarios", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = true;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
                schema.Columns.Add(colvarId);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 152;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarAdscripcion = new TableSchema.TableColumn(schema);
                colvarAdscripcion.ColumnName = "Adscripcion";
                colvarAdscripcion.DataType = DbType.String;
                colvarAdscripcion.MaxLength = 50;
                colvarAdscripcion.AutoIncrement = false;
                colvarAdscripcion.IsNullable = true;
                colvarAdscripcion.IsPrimaryKey = false;
                colvarAdscripcion.IsForeignKey = false;
                colvarAdscripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarAdscripcion);
                
                TableSchema.TableColumn colvarImagen = new TableSchema.TableColumn(schema);
                colvarImagen.ColumnName = "Imagen";
                colvarImagen.DataType = DbType.String;
                colvarImagen.MaxLength = 500;
                colvarImagen.AutoIncrement = false;
                colvarImagen.IsNullable = true;
                colvarImagen.IsPrimaryKey = false;
                colvarImagen.IsForeignKey = false;
                colvarImagen.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarExtension);
                
                TableSchema.TableColumn colvarCategoria = new TableSchema.TableColumn(schema);
                colvarCategoria.ColumnName = "Categoria";
                colvarCategoria.DataType = DbType.String;
                colvarCategoria.MaxLength = 50;
                colvarCategoria.AutoIncrement = false;
                colvarCategoria.IsNullable = true;
                colvarCategoria.IsPrimaryKey = false;
                colvarCategoria.IsForeignKey = false;
                colvarCategoria.IsReadOnly = false;
                
                schema.Columns.Add(colvarCategoria);
                
                TableSchema.TableColumn colvarFunciones = new TableSchema.TableColumn(schema);
                colvarFunciones.ColumnName = "Funciones";
                colvarFunciones.DataType = DbType.String;
                colvarFunciones.MaxLength = 2000;
                colvarFunciones.AutoIncrement = false;
                colvarFunciones.IsNullable = true;
                colvarFunciones.IsPrimaryKey = false;
                colvarFunciones.IsForeignKey = false;
                colvarFunciones.IsReadOnly = false;
                
                schema.Columns.Add(colvarFunciones);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "STATUS";
                colvarStatus.DataType = DbType.Boolean;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                TableSchema.TableColumn colvarExpr1 = new TableSchema.TableColumn(schema);
                colvarExpr1.ColumnName = "Expr1";
                colvarExpr1.DataType = DbType.Int32;
                colvarExpr1.MaxLength = 0;
                colvarExpr1.AutoIncrement = false;
                colvarExpr1.IsNullable = true;
                colvarExpr1.IsPrimaryKey = false;
                colvarExpr1.IsForeignKey = false;
                colvarExpr1.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr1);
                
                TableSchema.TableColumn colvarBusqueda = new TableSchema.TableColumn(schema);
                colvarBusqueda.ColumnName = "BUSQUEDA";
                colvarBusqueda.DataType = DbType.String;
                colvarBusqueda.MaxLength = 2306;
                colvarBusqueda.AutoIncrement = false;
                colvarBusqueda.IsNullable = true;
                colvarBusqueda.IsPrimaryKey = false;
                colvarBusqueda.IsForeignKey = false;
                colvarBusqueda.IsReadOnly = false;
                
                schema.Columns.Add(colvarBusqueda);
                
                TableSchema.TableColumn colvarNoempleado = new TableSchema.TableColumn(schema);
                colvarNoempleado.ColumnName = "NOEMPLEADO";
                colvarNoempleado.DataType = DbType.String;
                colvarNoempleado.MaxLength = 50;
                colvarNoempleado.AutoIncrement = false;
                colvarNoempleado.IsNullable = true;
                colvarNoempleado.IsPrimaryKey = false;
                colvarNoempleado.IsForeignKey = false;
                colvarNoempleado.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoempleado);
                
                TableSchema.TableColumn colvarStatusUser = new TableSchema.TableColumn(schema);
                colvarStatusUser.ColumnName = "StatusUser";
                colvarStatusUser.DataType = DbType.Boolean;
                colvarStatusUser.MaxLength = 0;
                colvarStatusUser.AutoIncrement = false;
                colvarStatusUser.IsNullable = true;
                colvarStatusUser.IsPrimaryKey = false;
                colvarStatusUser.IsForeignKey = false;
                colvarStatusUser.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatusUser);
                
                TableSchema.TableColumn colvarExpr2 = new TableSchema.TableColumn(schema);
                colvarExpr2.ColumnName = "Expr2";
                colvarExpr2.DataType = DbType.Int32;
                colvarExpr2.MaxLength = 0;
                colvarExpr2.AutoIncrement = false;
                colvarExpr2.IsNullable = true;
                colvarExpr2.IsPrimaryKey = false;
                colvarExpr2.IsForeignKey = false;
                colvarExpr2.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr2);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_RHDetalleUsuarios",schema);
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
	    public ViewRHDetalleUsuario()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewRHDetalleUsuario(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewRHDetalleUsuario(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewRHDetalleUsuario(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Id")]
        [Bindable(true)]
        public int? Id 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ID");
		    }
            set 
		    {
			    SetColumnValue("ID", value);
            }
        }
	      
        [XmlAttribute("Nombre")]
        [Bindable(true)]
        public string Nombre 
	    {
		    get
		    {
			    return GetColumnValue<string>("Nombre");
		    }
            set 
		    {
			    SetColumnValue("Nombre", value);
            }
        }
	      
        [XmlAttribute("Adscripcion")]
        [Bindable(true)]
        public string Adscripcion 
	    {
		    get
		    {
			    return GetColumnValue<string>("Adscripcion");
		    }
            set 
		    {
			    SetColumnValue("Adscripcion", value);
            }
        }
	      
        [XmlAttribute("Imagen")]
        [Bindable(true)]
        public string Imagen 
	    {
		    get
		    {
			    return GetColumnValue<string>("Imagen");
		    }
            set 
		    {
			    SetColumnValue("Imagen", value);
            }
        }
	      
        [XmlAttribute("Extension")]
        [Bindable(true)]
        public string Extension 
	    {
		    get
		    {
			    return GetColumnValue<string>("Extension");
		    }
            set 
		    {
			    SetColumnValue("Extension", value);
            }
        }
	      
        [XmlAttribute("Categoria")]
        [Bindable(true)]
        public string Categoria 
	    {
		    get
		    {
			    return GetColumnValue<string>("Categoria");
		    }
            set 
		    {
			    SetColumnValue("Categoria", value);
            }
        }
	      
        [XmlAttribute("Funciones")]
        [Bindable(true)]
        public string Funciones 
	    {
		    get
		    {
			    return GetColumnValue<string>("Funciones");
		    }
            set 
		    {
			    SetColumnValue("Funciones", value);
            }
        }
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("STATUS");
		    }
            set 
		    {
			    SetColumnValue("STATUS", value);
            }
        }
	      
        [XmlAttribute("Expr1")]
        [Bindable(true)]
        public int? Expr1 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Expr1");
		    }
            set 
		    {
			    SetColumnValue("Expr1", value);
            }
        }
	      
        [XmlAttribute("Busqueda")]
        [Bindable(true)]
        public string Busqueda 
	    {
		    get
		    {
			    return GetColumnValue<string>("BUSQUEDA");
		    }
            set 
		    {
			    SetColumnValue("BUSQUEDA", value);
            }
        }
	      
        [XmlAttribute("Noempleado")]
        [Bindable(true)]
        public string Noempleado 
	    {
		    get
		    {
			    return GetColumnValue<string>("NOEMPLEADO");
		    }
            set 
		    {
			    SetColumnValue("NOEMPLEADO", value);
            }
        }
	      
        [XmlAttribute("StatusUser")]
        [Bindable(true)]
        public bool? StatusUser 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("StatusUser");
		    }
            set 
		    {
			    SetColumnValue("StatusUser", value);
            }
        }
	      
        [XmlAttribute("Expr2")]
        [Bindable(true)]
        public int? Expr2 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Expr2");
		    }
            set 
		    {
			    SetColumnValue("Expr2", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"ID";
            
            public static string Nombre = @"Nombre";
            
            public static string Adscripcion = @"Adscripcion";
            
            public static string Imagen = @"Imagen";
            
            public static string Extension = @"Extension";
            
            public static string Categoria = @"Categoria";
            
            public static string Funciones = @"Funciones";
            
            public static string Status = @"STATUS";
            
            public static string Expr1 = @"Expr1";
            
            public static string Busqueda = @"BUSQUEDA";
            
            public static string Noempleado = @"NOEMPLEADO";
            
            public static string StatusUser = @"StatusUser";
            
            public static string Expr2 = @"Expr2";
            
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
