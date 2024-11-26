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
    /// Strongly-typed collection for the ViewEnlacesFortamun class.
    /// </summary>
    [Serializable]
    public partial class ViewEnlacesFortamunCollection : ReadOnlyList<ViewEnlacesFortamun, ViewEnlacesFortamunCollection>
    {        
        public ViewEnlacesFortamunCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_EnlacesFortamun view.
    /// </summary>
    [Serializable]
    public partial class ViewEnlacesFortamun : ReadOnlyRecord<ViewEnlacesFortamun>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_EnlacesFortamun", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIDMpio = new TableSchema.TableColumn(schema);
                colvarIDMpio.ColumnName = "IDMpio";
                colvarIDMpio.DataType = DbType.Int32;
                colvarIDMpio.MaxLength = 0;
                colvarIDMpio.AutoIncrement = false;
                colvarIDMpio.IsNullable = false;
                colvarIDMpio.IsPrimaryKey = false;
                colvarIDMpio.IsForeignKey = false;
                colvarIDMpio.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDMpio);
                
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
                
                TableSchema.TableColumn colvarTipoContacto = new TableSchema.TableColumn(schema);
                colvarTipoContacto.ColumnName = "TipoContacto";
                colvarTipoContacto.DataType = DbType.String;
                colvarTipoContacto.MaxLength = 500;
                colvarTipoContacto.AutoIncrement = false;
                colvarTipoContacto.IsNullable = true;
                colvarTipoContacto.IsPrimaryKey = false;
                colvarTipoContacto.IsForeignKey = false;
                colvarTipoContacto.IsReadOnly = false;
                
                schema.Columns.Add(colvarTipoContacto);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 500;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_EnlacesFortamun",schema);
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
	    public ViewEnlacesFortamun()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewEnlacesFortamun(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewEnlacesFortamun(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewEnlacesFortamun(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IDMpio")]
        [Bindable(true)]
        public int IDMpio 
	    {
		    get
		    {
			    return GetColumnValue<int>("IDMpio");
		    }
            set 
		    {
			    SetColumnValue("IDMpio", value);
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
	      
        [XmlAttribute("TipoContacto")]
        [Bindable(true)]
        public string TipoContacto 
	    {
		    get
		    {
			    return GetColumnValue<string>("TipoContacto");
		    }
            set 
		    {
			    SetColumnValue("TipoContacto", value);
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
		    
		    
            public static string IDMpio = @"IDMpio";
            
            public static string Id = @"ID";
            
            public static string Nombre = @"Nombre";
            
            public static string TipoContacto = @"TipoContacto";
            
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
