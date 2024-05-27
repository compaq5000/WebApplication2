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
    /// Strongly-typed collection for the ViewContestacionCorrespon class.
    /// </summary>
    [Serializable]
    public partial class ViewContestacionCorresponCollection : ReadOnlyList<ViewContestacionCorrespon, ViewContestacionCorresponCollection>
    {        
        public ViewContestacionCorresponCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_ContestacionCorrespon view.
    /// </summary>
    [Serializable]
    public partial class ViewContestacionCorrespon : ReadOnlyRecord<ViewContestacionCorrespon>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_ContestacionCorrespon", TableType.View, DataService.GetInstance("Default"));
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
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Boolean;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
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
                
                TableSchema.TableColumn colvarIDTipo = new TableSchema.TableColumn(schema);
                colvarIDTipo.ColumnName = "IDTipo";
                colvarIDTipo.DataType = DbType.Int32;
                colvarIDTipo.MaxLength = 0;
                colvarIDTipo.AutoIncrement = false;
                colvarIDTipo.IsNullable = true;
                colvarIDTipo.IsPrimaryKey = false;
                colvarIDTipo.IsForeignKey = false;
                colvarIDTipo.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDTipo);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 4000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarIDUserCarga = new TableSchema.TableColumn(schema);
                colvarIDUserCarga.ColumnName = "IDUserCarga";
                colvarIDUserCarga.DataType = DbType.Int32;
                colvarIDUserCarga.MaxLength = 0;
                colvarIDUserCarga.AutoIncrement = false;
                colvarIDUserCarga.IsNullable = true;
                colvarIDUserCarga.IsPrimaryKey = false;
                colvarIDUserCarga.IsForeignKey = false;
                colvarIDUserCarga.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDUserCarga);
                
                TableSchema.TableColumn colvarNombreCompleto = new TableSchema.TableColumn(schema);
                colvarNombreCompleto.ColumnName = "NombreCompleto";
                colvarNombreCompleto.DataType = DbType.String;
                colvarNombreCompleto.MaxLength = 650;
                colvarNombreCompleto.AutoIncrement = false;
                colvarNombreCompleto.IsNullable = true;
                colvarNombreCompleto.IsPrimaryKey = false;
                colvarNombreCompleto.IsForeignKey = false;
                colvarNombreCompleto.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombreCompleto);
                
                TableSchema.TableColumn colvarInventario = new TableSchema.TableColumn(schema);
                colvarInventario.ColumnName = "inventario";
                colvarInventario.DataType = DbType.String;
                colvarInventario.MaxLength = 50;
                colvarInventario.AutoIncrement = false;
                colvarInventario.IsNullable = true;
                colvarInventario.IsPrimaryKey = false;
                colvarInventario.IsForeignKey = false;
                colvarInventario.IsReadOnly = false;
                
                schema.Columns.Add(colvarInventario);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("View_ContestacionCorrespon",schema);
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
	    public ViewContestacionCorrespon()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewContestacionCorrespon(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewContestacionCorrespon(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewContestacionCorrespon(string columnName, object columnValue)
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
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public bool? Status 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("status");
		    }
            set 
		    {
			    SetColumnValue("status", value);
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
	      
        [XmlAttribute("IDTipo")]
        [Bindable(true)]
        public int? IDTipo 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDTipo");
		    }
            set 
		    {
			    SetColumnValue("IDTipo", value);
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
	      
        [XmlAttribute("IDUserCarga")]
        [Bindable(true)]
        public int? IDUserCarga 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDUserCarga");
		    }
            set 
		    {
			    SetColumnValue("IDUserCarga", value);
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
	      
        [XmlAttribute("Inventario")]
        [Bindable(true)]
        public string Inventario 
	    {
		    get
		    {
			    return GetColumnValue<string>("inventario");
		    }
            set 
		    {
			    SetColumnValue("inventario", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Nombre = @"Nombre";
            
            public static string Extencion = @"Extencion";
            
            public static string Status = @"status";
            
            public static string IDExpediente = @"IDExpediente";
            
            public static string Id = @"ID";
            
            public static string Fecha = @"Fecha";
            
            public static string IDTipo = @"IDTipo";
            
            public static string Descripcion = @"Descripcion";
            
            public static string IDUserCarga = @"IDUserCarga";
            
            public static string NombreCompleto = @"NombreCompleto";
            
            public static string Inventario = @"inventario";
            
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
