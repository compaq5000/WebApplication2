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
    /// Strongly-typed collection for the ViewRetornaCorrespondencium class.
    /// </summary>
    [Serializable]
    public partial class ViewRetornaCorrespondenciumCollection : ReadOnlyList<ViewRetornaCorrespondencium, ViewRetornaCorrespondenciumCollection>
    {        
        public ViewRetornaCorrespondenciumCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_RetornaCorrespondencia view.
    /// </summary>
    [Serializable]
    public partial class ViewRetornaCorrespondencium : ReadOnlyRecord<ViewRetornaCorrespondencium>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_RetornaCorrespondencia", TableType.View, DataService.GetInstance("Default"));
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
                colvarExpr1.MaxLength = 4000;
                colvarExpr1.AutoIncrement = false;
                colvarExpr1.IsNullable = true;
                colvarExpr1.IsPrimaryKey = false;
                colvarExpr1.IsForeignKey = false;
                colvarExpr1.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr1);
                
                TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
                colvarFecha.ColumnName = "Fecha";
                colvarFecha.DataType = DbType.DateTime;
                colvarFecha.MaxLength = 0;
                colvarFecha.AutoIncrement = false;
                colvarFecha.IsNullable = true;
                colvarFecha.IsPrimaryKey = false;
                colvarFecha.IsForeignKey = false;
                colvarFecha.IsReadOnly = false;
                
                schema.Columns.Add(colvarFecha);
                
                TableSchema.TableColumn colvarNombreCompleto = new TableSchema.TableColumn(schema);
                colvarNombreCompleto.ColumnName = "NombreCompleto";
                colvarNombreCompleto.DataType = DbType.String;
                colvarNombreCompleto.MaxLength = 152;
                colvarNombreCompleto.AutoIncrement = false;
                colvarNombreCompleto.IsNullable = true;
                colvarNombreCompleto.IsPrimaryKey = false;
                colvarNombreCompleto.IsForeignKey = false;
                colvarNombreCompleto.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombreCompleto);
                
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
                
                TableSchema.TableColumn colvarIDExpedienteOri = new TableSchema.TableColumn(schema);
                colvarIDExpedienteOri.ColumnName = "IDExpedienteOri";
                colvarIDExpedienteOri.DataType = DbType.Int32;
                colvarIDExpedienteOri.MaxLength = 0;
                colvarIDExpedienteOri.AutoIncrement = false;
                colvarIDExpedienteOri.IsNullable = true;
                colvarIDExpedienteOri.IsPrimaryKey = false;
                colvarIDExpedienteOri.IsForeignKey = false;
                colvarIDExpedienteOri.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDExpedienteOri);
                
                TableSchema.TableColumn colvarStatusCorresponde = new TableSchema.TableColumn(schema);
                colvarStatusCorresponde.ColumnName = "StatusCorresponde";
                colvarStatusCorresponde.DataType = DbType.Boolean;
                colvarStatusCorresponde.MaxLength = 0;
                colvarStatusCorresponde.AutoIncrement = false;
                colvarStatusCorresponde.IsNullable = true;
                colvarStatusCorresponde.IsPrimaryKey = false;
                colvarStatusCorresponde.IsForeignKey = false;
                colvarStatusCorresponde.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatusCorresponde);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_RetornaCorrespondencia",schema);
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
	    public ViewRetornaCorrespondencium()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewRetornaCorrespondencium(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewRetornaCorrespondencium(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewRetornaCorrespondencium(string columnName, object columnValue)
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
	      
        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime? Fecha 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("Fecha");
		    }
            set 
		    {
			    SetColumnValue("Fecha", value);
            }
        }
	      
        [XmlAttribute("NombreCompleto")]
        [Bindable(true)]
        public string NombreCompleto 
	    {
		    get
		    {
			    return GetColumnValue<string>("NombreCompleto");
		    }
            set 
		    {
			    SetColumnValue("NombreCompleto", value);
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
	      
        [XmlAttribute("IDExpedienteOri")]
        [Bindable(true)]
        public int? IDExpedienteOri 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDExpedienteOri");
		    }
            set 
		    {
			    SetColumnValue("IDExpedienteOri", value);
            }
        }
	      
        [XmlAttribute("StatusCorresponde")]
        [Bindable(true)]
        public bool? StatusCorresponde 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("StatusCorresponde");
		    }
            set 
		    {
			    SetColumnValue("StatusCorresponde", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IDExpediente = @"IDExpediente";
            
            public static string Descripcion = @"Descripcion";
            
            public static string Expr1 = @"Expr1";
            
            public static string Fecha = @"Fecha";
            
            public static string NombreCompleto = @"NombreCompleto";
            
            public static string IDRegistro = @"IDRegistro";
            
            public static string IDExpedienteOri = @"IDExpedienteOri";
            
            public static string StatusCorresponde = @"StatusCorresponde";
            
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
