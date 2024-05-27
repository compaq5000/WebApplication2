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
    /// Strongly-typed collection for the ViewConsultaexiste class.
    /// </summary>
    [Serializable]
    public partial class ViewConsultaexisteCollection : ReadOnlyList<ViewConsultaexiste, ViewConsultaexisteCollection>
    {        
        public ViewConsultaexisteCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_consultaexiste view.
    /// </summary>
    [Serializable]
    public partial class ViewConsultaexiste : ReadOnlyRecord<ViewConsultaexiste>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_consultaexiste", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarIDDepende = new TableSchema.TableColumn(schema);
                colvarIDDepende.ColumnName = "IDDepende";
                colvarIDDepende.DataType = DbType.Int32;
                colvarIDDepende.MaxLength = 0;
                colvarIDDepende.AutoIncrement = false;
                colvarIDDepende.IsNullable = true;
                colvarIDDepende.IsPrimaryKey = false;
                colvarIDDepende.IsForeignKey = false;
                colvarIDDepende.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDDepende);
                
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
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 500;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarIDTIpoContenido = new TableSchema.TableColumn(schema);
                colvarIDTIpoContenido.ColumnName = "IDTIpoContenido";
                colvarIDTIpoContenido.DataType = DbType.Int32;
                colvarIDTIpoContenido.MaxLength = 0;
                colvarIDTIpoContenido.AutoIncrement = false;
                colvarIDTIpoContenido.IsNullable = true;
                colvarIDTIpoContenido.IsPrimaryKey = false;
                colvarIDTIpoContenido.IsForeignKey = false;
                colvarIDTIpoContenido.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDTIpoContenido);
                
                TableSchema.TableColumn colvarIDRegistro = new TableSchema.TableColumn(schema);
                colvarIDRegistro.ColumnName = "IDRegistro";
                colvarIDRegistro.DataType = DbType.Int32;
                colvarIDRegistro.MaxLength = 0;
                colvarIDRegistro.AutoIncrement = false;
                colvarIDRegistro.IsNullable = false;
                colvarIDRegistro.IsPrimaryKey = false;
                colvarIDRegistro.IsForeignKey = false;
                colvarIDRegistro.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDRegistro);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_consultaexiste",schema);
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
	    public ViewConsultaexiste()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewConsultaexiste(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewConsultaexiste(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewConsultaexiste(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("IDDepende")]
        [Bindable(true)]
        public int? IDDepende 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDDepende");
		    }
            set 
		    {
			    SetColumnValue("IDDepende", value);
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
	      
        [XmlAttribute("IDTIpoContenido")]
        [Bindable(true)]
        public int? IDTIpoContenido 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDTIpoContenido");
		    }
            set 
		    {
			    SetColumnValue("IDTIpoContenido", value);
            }
        }
	      
        [XmlAttribute("IDRegistro")]
        [Bindable(true)]
        public int IDRegistro 
	    {
		    get
		    {
			    return GetColumnValue<int>("IDRegistro");
		    }
            set 
		    {
			    SetColumnValue("IDRegistro", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Descripcion = @"Descripcion";
            
            public static string IDDepende = @"IDDepende";
            
            public static string Id = @"ID";
            
            public static string Nombre = @"Nombre";
            
            public static string IDTIpoContenido = @"IDTIpoContenido";
            
            public static string IDRegistro = @"IDRegistro";
            
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
