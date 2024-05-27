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
    /// Strongly-typed collection for the ViewGraficar class.
    /// </summary>
    [Serializable]
    public partial class ViewGraficarCollection : ReadOnlyList<ViewGraficar, ViewGraficarCollection>
    {        
        public ViewGraficarCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_Graficar view.
    /// </summary>
    [Serializable]
    public partial class ViewGraficar : ReadOnlyRecord<ViewGraficar>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_Graficar", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarValueX = new TableSchema.TableColumn(schema);
                colvarValueX.ColumnName = "VALUE";
                colvarValueX.DataType = DbType.String;
                colvarValueX.MaxLength = 50;
                colvarValueX.AutoIncrement = false;
                colvarValueX.IsNullable = true;
                colvarValueX.IsPrimaryKey = false;
                colvarValueX.IsForeignKey = false;
                colvarValueX.IsReadOnly = false;
                
                schema.Columns.Add(colvarValueX);
                
                TableSchema.TableColumn colvarTotalRecicbidos = new TableSchema.TableColumn(schema);
                colvarTotalRecicbidos.ColumnName = "totalRecicbidos";
                colvarTotalRecicbidos.DataType = DbType.Int32;
                colvarTotalRecicbidos.MaxLength = 0;
                colvarTotalRecicbidos.AutoIncrement = false;
                colvarTotalRecicbidos.IsNullable = true;
                colvarTotalRecicbidos.IsPrimaryKey = false;
                colvarTotalRecicbidos.IsForeignKey = false;
                colvarTotalRecicbidos.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalRecicbidos);
                
                TableSchema.TableColumn colvarRevisados = new TableSchema.TableColumn(schema);
                colvarRevisados.ColumnName = "REVISADOS";
                colvarRevisados.DataType = DbType.Int32;
                colvarRevisados.MaxLength = 0;
                colvarRevisados.AutoIncrement = false;
                colvarRevisados.IsNullable = true;
                colvarRevisados.IsPrimaryKey = false;
                colvarRevisados.IsForeignKey = false;
                colvarRevisados.IsReadOnly = false;
                
                schema.Columns.Add(colvarRevisados);
                
                TableSchema.TableColumn colvarContestados = new TableSchema.TableColumn(schema);
                colvarContestados.ColumnName = "Contestados";
                colvarContestados.DataType = DbType.Int32;
                colvarContestados.MaxLength = 0;
                colvarContestados.AutoIncrement = false;
                colvarContestados.IsNullable = true;
                colvarContestados.IsPrimaryKey = false;
                colvarContestados.IsForeignKey = false;
                colvarContestados.IsReadOnly = false;
                
                schema.Columns.Add(colvarContestados);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_Graficar",schema);
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
	    public ViewGraficar()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewGraficar(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewGraficar(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewGraficar(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ValueX")]
        [Bindable(true)]
        public string ValueX 
	    {
		    get
		    {
			    return GetColumnValue<string>("VALUE");
		    }
            set 
		    {
			    SetColumnValue("VALUE", value);
            }
        }
	      
        [XmlAttribute("TotalRecicbidos")]
        [Bindable(true)]
        public int? TotalRecicbidos 
	    {
		    get
		    {
			    return GetColumnValue<int?>("totalRecicbidos");
		    }
            set 
		    {
			    SetColumnValue("totalRecicbidos", value);
            }
        }
	      
        [XmlAttribute("Revisados")]
        [Bindable(true)]
        public int? Revisados 
	    {
		    get
		    {
			    return GetColumnValue<int?>("REVISADOS");
		    }
            set 
		    {
			    SetColumnValue("REVISADOS", value);
            }
        }
	      
        [XmlAttribute("Contestados")]
        [Bindable(true)]
        public int? Contestados 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Contestados");
		    }
            set 
		    {
			    SetColumnValue("Contestados", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ValueX = @"VALUE";
            
            public static string TotalRecicbidos = @"totalRecicbidos";
            
            public static string Revisados = @"REVISADOS";
            
            public static string Contestados = @"Contestados";
            
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
