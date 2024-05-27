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
    /// Strongly-typed collection for the ViewBitacoraActividade class.
    /// </summary>
    [Serializable]
    public partial class ViewBitacoraActividadeCollection : ReadOnlyList<ViewBitacoraActividade, ViewBitacoraActividadeCollection>
    {        
        public ViewBitacoraActividadeCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_BitacoraActividades view.
    /// </summary>
    [Serializable]
    public partial class ViewBitacoraActividade : ReadOnlyRecord<ViewBitacoraActividade>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_BitacoraActividades", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 100;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_BitacoraActividades",schema);
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
	    public ViewBitacoraActividade()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewBitacoraActividade(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewBitacoraActividade(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewBitacoraActividade(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"ID";
            
            public static string Actualizado = @"actualizado";
            
            public static string Nombre = @"Nombre";
            
            public static string Detalle = @"Detalle";
            
            public static string Descripcion = @"Descripcion";
            
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
