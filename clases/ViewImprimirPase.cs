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
    /// Strongly-typed collection for the ViewImprimirPase class.
    /// </summary>
    [Serializable]
    public partial class ViewImprimirPaseCollection : ReadOnlyList<ViewImprimirPase, ViewImprimirPaseCollection>
    {        
        public ViewImprimirPaseCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_ImprimirPases view.
    /// </summary>
    [Serializable]
    public partial class ViewImprimirPase : ReadOnlyRecord<ViewImprimirPase>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_ImprimirPases", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdadscripcion = new TableSchema.TableColumn(schema);
                colvarIdadscripcion.ColumnName = "IDADSCRIPCION";
                colvarIdadscripcion.DataType = DbType.Int32;
                colvarIdadscripcion.MaxLength = 0;
                colvarIdadscripcion.AutoIncrement = false;
                colvarIdadscripcion.IsNullable = true;
                colvarIdadscripcion.IsPrimaryKey = false;
                colvarIdadscripcion.IsForeignKey = false;
                colvarIdadscripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdadscripcion);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_ImprimirPases",schema);
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
	    public ViewImprimirPase()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewImprimirPase(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewImprimirPase(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewImprimirPase(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Idadscripcion")]
        [Bindable(true)]
        public int? Idadscripcion 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDADSCRIPCION");
		    }
            set 
		    {
			    SetColumnValue("IDADSCRIPCION", value);
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
		    
		    
            public static string Idadscripcion = @"IDADSCRIPCION";
            
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
