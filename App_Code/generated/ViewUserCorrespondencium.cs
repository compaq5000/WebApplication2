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
    /// Strongly-typed collection for the ViewUserCorrespondencium class.
    /// </summary>
    [Serializable]
    public partial class ViewUserCorrespondenciumCollection : ReadOnlyList<ViewUserCorrespondencium, ViewUserCorrespondenciumCollection>
    {        
        public ViewUserCorrespondenciumCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_UserCorrespondencia view.
    /// </summary>
    [Serializable]
    public partial class ViewUserCorrespondencium : ReadOnlyRecord<ViewUserCorrespondencium>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_UserCorrespondencia", TableType.View, DataService.GetInstance("Default"));
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
                
                TableSchema.TableColumn colvarValueX = new TableSchema.TableColumn(schema);
                colvarValueX.ColumnName = "value";
                colvarValueX.DataType = DbType.String;
                colvarValueX.MaxLength = 50;
                colvarValueX.AutoIncrement = false;
                colvarValueX.IsNullable = true;
                colvarValueX.IsPrimaryKey = false;
                colvarValueX.IsForeignKey = false;
                colvarValueX.IsReadOnly = false;
                
                schema.Columns.Add(colvarValueX);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_UserCorrespondencia",schema);
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
	    public ViewUserCorrespondencium()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewUserCorrespondencium(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewUserCorrespondencium(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewUserCorrespondencium(string columnName, object columnValue)
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
	      
        [XmlAttribute("ValueX")]
        [Bindable(true)]
        public string ValueX 
	    {
		    get
		    {
			    return GetColumnValue<string>("value");
		    }
            set 
		    {
			    SetColumnValue("value", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Descripcion = @"Descripcion";
            
            public static string Nombre = @"Nombre";
            
            public static string Id = @"ID";
            
            public static string ValueX = @"value";
            
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
