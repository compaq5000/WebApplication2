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
    /// Strongly-typed collection for the ViewHistorialExpediente class.
    /// </summary>
    [Serializable]
    public partial class ViewHistorialExpedienteCollection : ReadOnlyList<ViewHistorialExpediente, ViewHistorialExpedienteCollection>
    {        
        public ViewHistorialExpedienteCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the ViewHistorialExpediente view.
    /// </summary>
    [Serializable]
    public partial class ViewHistorialExpediente : ReadOnlyRecord<ViewHistorialExpediente>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("ViewHistorialExpediente", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
                colvarIDExpediente.ColumnName = "IDExpediente";
                colvarIDExpediente.DataType = DbType.Int32;
                colvarIDExpediente.MaxLength = 0;
                colvarIDExpediente.AutoIncrement = false;
                colvarIDExpediente.IsNullable = false;
                colvarIDExpediente.IsPrimaryKey = false;
                colvarIDExpediente.IsForeignKey = false;
                colvarIDExpediente.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDExpediente);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 3000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarExpr1 = new TableSchema.TableColumn(schema);
                colvarExpr1.ColumnName = "Expr1";
                colvarExpr1.DataType = DbType.String;
                colvarExpr1.MaxLength = 100;
                colvarExpr1.AutoIncrement = false;
                colvarExpr1.IsNullable = true;
                colvarExpr1.IsPrimaryKey = false;
                colvarExpr1.IsForeignKey = false;
                colvarExpr1.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr1);
                
                TableSchema.TableColumn colvarActualizado = new TableSchema.TableColumn(schema);
                colvarActualizado.ColumnName = "actualizado";
                colvarActualizado.DataType = DbType.DateTime;
                colvarActualizado.MaxLength = 0;
                colvarActualizado.AutoIncrement = false;
                colvarActualizado.IsNullable = true;
                colvarActualizado.IsPrimaryKey = false;
                colvarActualizado.IsForeignKey = false;
                colvarActualizado.IsReadOnly = false;
                
                schema.Columns.Add(colvarActualizado);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 650;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
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
                
                TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
                colvarDetalle.ColumnName = "Detalle";
                colvarDetalle.DataType = DbType.String;
                colvarDetalle.MaxLength = 2000;
                colvarDetalle.AutoIncrement = false;
                colvarDetalle.IsNullable = true;
                colvarDetalle.IsPrimaryKey = false;
                colvarDetalle.IsForeignKey = false;
                colvarDetalle.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetalle);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("ViewHistorialExpediente",schema);
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
	    public ViewHistorialExpediente()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewHistorialExpediente(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewHistorialExpediente(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewHistorialExpediente(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int IDExpediente 
	    {
		    get
		    {
			    return GetColumnValue<int>("IDExpediente");
		    }
            set 
		    {
			    SetColumnValue("IDExpediente", value);
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
	      
        [XmlAttribute("Expr1")]
        [Bindable(true)]
        public string Expr1 
	    {
		    get
		    {
			    return GetColumnValue<string>("Expr1");
		    }
            set 
		    {
			    SetColumnValue("Expr1", value);
            }
        }
	      
        [XmlAttribute("Actualizado")]
        [Bindable(true)]
        public DateTime? Actualizado 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("actualizado");
		    }
            set 
		    {
			    SetColumnValue("actualizado", value);
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
	      
        [XmlAttribute("Detalle")]
        [Bindable(true)]
        public string Detalle 
	    {
		    get
		    {
			    return GetColumnValue<string>("Detalle");
		    }
            set 
		    {
			    SetColumnValue("Detalle", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IDExpediente = @"IDExpediente";
            
            public static string Descripcion = @"Descripcion";
            
            public static string Expr1 = @"Expr1";
            
            public static string Actualizado = @"actualizado";
            
            public static string Nombre = @"Nombre";
            
            public static string Id = @"ID";
            
            public static string Detalle = @"Detalle";
            
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
