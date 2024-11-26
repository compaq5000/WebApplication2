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
    /// Strongly-typed collection for the ViewHistorialArchivoCorrespondencium class.
    /// </summary>
    [Serializable]
    public partial class ViewHistorialArchivoCorrespondenciumCollection : ReadOnlyList<ViewHistorialArchivoCorrespondencium, ViewHistorialArchivoCorrespondenciumCollection>
    {        
        public ViewHistorialArchivoCorrespondenciumCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_HistorialArchivoCorrespondencia view.
    /// </summary>
    [Serializable]
    public partial class ViewHistorialArchivoCorrespondencium : ReadOnlyRecord<ViewHistorialArchivoCorrespondencium>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_HistorialArchivoCorrespondencia", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
                colvarFechaCarga.ColumnName = "FechaCarga";
                colvarFechaCarga.DataType = DbType.DateTime;
                colvarFechaCarga.MaxLength = 0;
                colvarFechaCarga.AutoIncrement = false;
                colvarFechaCarga.IsNullable = true;
                colvarFechaCarga.IsPrimaryKey = false;
                colvarFechaCarga.IsForeignKey = false;
                colvarFechaCarga.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaCarga);
                
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
                
                TableSchema.TableColumn colvarExtencion = new TableSchema.TableColumn(schema);
                colvarExtencion.ColumnName = "Extencion";
                colvarExtencion.DataType = DbType.String;
                colvarExtencion.MaxLength = 5;
                colvarExtencion.AutoIncrement = false;
                colvarExtencion.IsNullable = false;
                colvarExtencion.IsPrimaryKey = false;
                colvarExtencion.IsForeignKey = false;
                colvarExtencion.IsReadOnly = false;
                
                schema.Columns.Add(colvarExtencion);
                
                TableSchema.TableColumn colvarNam = new TableSchema.TableColumn(schema);
                colvarNam.ColumnName = "NAM";
                colvarNam.DataType = DbType.String;
                colvarNam.MaxLength = 152;
                colvarNam.AutoIncrement = false;
                colvarNam.IsNullable = true;
                colvarNam.IsPrimaryKey = false;
                colvarNam.IsForeignKey = false;
                colvarNam.IsReadOnly = false;
                
                schema.Columns.Add(colvarNam);
                
                TableSchema.TableColumn colvarIDExpediente = new TableSchema.TableColumn(schema);
                colvarIDExpediente.ColumnName = "IDExpediente";
                colvarIDExpediente.DataType = DbType.Int32;
                colvarIDExpediente.MaxLength = 0;
                colvarIDExpediente.AutoIncrement = false;
                colvarIDExpediente.IsNullable = true;
                colvarIDExpediente.IsPrimaryKey = false;
                colvarIDExpediente.IsForeignKey = false;
                colvarIDExpediente.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDExpediente);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_HistorialArchivoCorrespondencia",schema);
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
	    public ViewHistorialArchivoCorrespondencium()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewHistorialArchivoCorrespondencium(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewHistorialArchivoCorrespondencium(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewHistorialArchivoCorrespondencium(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("FechaCarga")]
        [Bindable(true)]
        public DateTime? FechaCarga 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("FechaCarga");
		    }
            set 
		    {
			    SetColumnValue("FechaCarga", value);
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
	      
        [XmlAttribute("Extencion")]
        [Bindable(true)]
        public string Extencion 
	    {
		    get
		    {
			    return GetColumnValue<string>("Extencion");
		    }
            set 
		    {
			    SetColumnValue("Extencion", value);
            }
        }
	      
        [XmlAttribute("Nam")]
        [Bindable(true)]
        public string Nam 
	    {
		    get
		    {
			    return GetColumnValue<string>("NAM");
		    }
            set 
		    {
			    SetColumnValue("NAM", value);
            }
        }
	      
        [XmlAttribute("IDExpediente")]
        [Bindable(true)]
        public int? IDExpediente 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDExpediente");
		    }
            set 
		    {
			    SetColumnValue("IDExpediente", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Nombre = @"Nombre";
            
            public static string FechaCarga = @"FechaCarga";
            
            public static string Id = @"ID";
            
            public static string Extencion = @"Extencion";
            
            public static string Nam = @"NAM";
            
            public static string IDExpediente = @"IDExpediente";
            
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
