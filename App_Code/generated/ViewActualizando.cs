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
    /// Strongly-typed collection for the ViewActualizando class.
    /// </summary>
    [Serializable]
    public partial class ViewActualizandoCollection : ReadOnlyList<ViewActualizando, ViewActualizandoCollection>
    {        
        public ViewActualizandoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_actualizando view.
    /// </summary>
    [Serializable]
    public partial class ViewActualizando : ReadOnlyRecord<ViewActualizando>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_actualizando", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_actualizando",schema);
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
	    public ViewActualizando()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewActualizando(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewActualizando(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewActualizando(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IDDepende = @"IDDepende";
            
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
