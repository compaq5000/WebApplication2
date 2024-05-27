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
    /// Strongly-typed collection for the ArboladoGrid class.
    /// </summary>
    [Serializable]
    public partial class ArboladoGridCollection : ReadOnlyList<ArboladoGrid, ArboladoGridCollection>
    {        
        public ArboladoGridCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the ArboladoGrid view.
    /// </summary>
    [Serializable]
    public partial class ArboladoGrid : ReadOnlyRecord<ArboladoGrid>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("ArboladoGrid", TableType.View, DataService.GetInstance("Default"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarUsuarios = new TableSchema.TableColumn(schema);
                colvarUsuarios.ColumnName = "usuarios";
                colvarUsuarios.DataType = DbType.String;
                colvarUsuarios.MaxLength = 50;
                colvarUsuarios.AutoIncrement = false;
                colvarUsuarios.IsNullable = true;
                colvarUsuarios.IsPrimaryKey = false;
                colvarUsuarios.IsForeignKey = false;
                colvarUsuarios.IsReadOnly = false;
                
                schema.Columns.Add(colvarUsuarios);
                
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
                
                TableSchema.TableColumn colvarIDActor = new TableSchema.TableColumn(schema);
                colvarIDActor.ColumnName = "IDActor";
                colvarIDActor.DataType = DbType.Int32;
                colvarIDActor.MaxLength = 0;
                colvarIDActor.AutoIncrement = false;
                colvarIDActor.IsNullable = true;
                colvarIDActor.IsPrimaryKey = false;
                colvarIDActor.IsForeignKey = false;
                colvarIDActor.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDActor);
                
                TableSchema.TableColumn colvarIDAbogadoActor = new TableSchema.TableColumn(schema);
                colvarIDAbogadoActor.ColumnName = "IDAbogadoActor";
                colvarIDAbogadoActor.DataType = DbType.Int32;
                colvarIDAbogadoActor.MaxLength = 0;
                colvarIDAbogadoActor.AutoIncrement = false;
                colvarIDAbogadoActor.IsNullable = true;
                colvarIDAbogadoActor.IsPrimaryKey = false;
                colvarIDAbogadoActor.IsForeignKey = false;
                colvarIDAbogadoActor.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDAbogadoActor);
                
                TableSchema.TableColumn colvarIDDemandado = new TableSchema.TableColumn(schema);
                colvarIDDemandado.ColumnName = "IDDemandado";
                colvarIDDemandado.DataType = DbType.Int32;
                colvarIDDemandado.MaxLength = 0;
                colvarIDDemandado.AutoIncrement = false;
                colvarIDDemandado.IsNullable = true;
                colvarIDDemandado.IsPrimaryKey = false;
                colvarIDDemandado.IsForeignKey = false;
                colvarIDDemandado.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDDemandado);
                
                TableSchema.TableColumn colvarIDAutocaso = new TableSchema.TableColumn(schema);
                colvarIDAutocaso.ColumnName = "IDAutocaso";
                colvarIDAutocaso.DataType = DbType.Int32;
                colvarIDAutocaso.MaxLength = 0;
                colvarIDAutocaso.AutoIncrement = false;
                colvarIDAutocaso.IsNullable = true;
                colvarIDAutocaso.IsPrimaryKey = false;
                colvarIDAutocaso.IsForeignKey = false;
                colvarIDAutocaso.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDAutocaso);
                
                TableSchema.TableColumn colvarIDTipojuicio = new TableSchema.TableColumn(schema);
                colvarIDTipojuicio.ColumnName = "IDTipojuicio";
                colvarIDTipojuicio.DataType = DbType.Int32;
                colvarIDTipojuicio.MaxLength = 0;
                colvarIDTipojuicio.AutoIncrement = false;
                colvarIDTipojuicio.IsNullable = true;
                colvarIDTipojuicio.IsPrimaryKey = false;
                colvarIDTipojuicio.IsForeignKey = false;
                colvarIDTipojuicio.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDTipojuicio);
                
                TableSchema.TableColumn colvarCausa = new TableSchema.TableColumn(schema);
                colvarCausa.ColumnName = "Causa";
                colvarCausa.DataType = DbType.String;
                colvarCausa.MaxLength = 3000;
                colvarCausa.AutoIncrement = false;
                colvarCausa.IsNullable = true;
                colvarCausa.IsPrimaryKey = false;
                colvarCausa.IsForeignKey = false;
                colvarCausa.IsReadOnly = false;
                
                schema.Columns.Add(colvarCausa);
                
                TableSchema.TableColumn colvarEtapa = new TableSchema.TableColumn(schema);
                colvarEtapa.ColumnName = "Etapa";
                colvarEtapa.DataType = DbType.String;
                colvarEtapa.MaxLength = 3000;
                colvarEtapa.AutoIncrement = false;
                colvarEtapa.IsNullable = true;
                colvarEtapa.IsPrimaryKey = false;
                colvarEtapa.IsForeignKey = false;
                colvarEtapa.IsReadOnly = false;
                
                schema.Columns.Add(colvarEtapa);
                
                TableSchema.TableColumn colvarFechaconoce = new TableSchema.TableColumn(schema);
                colvarFechaconoce.ColumnName = "fechaconoce";
                colvarFechaconoce.DataType = DbType.DateTime;
                colvarFechaconoce.MaxLength = 0;
                colvarFechaconoce.AutoIncrement = false;
                colvarFechaconoce.IsNullable = true;
                colvarFechaconoce.IsPrimaryKey = false;
                colvarFechaconoce.IsForeignKey = false;
                colvarFechaconoce.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaconoce);
                
                TableSchema.TableColumn colvarFechainterpone = new TableSchema.TableColumn(schema);
                colvarFechainterpone.ColumnName = "fechainterpone";
                colvarFechainterpone.DataType = DbType.AnsiString;
                colvarFechainterpone.MaxLength = 4;
                colvarFechainterpone.AutoIncrement = false;
                colvarFechainterpone.IsNullable = true;
                colvarFechainterpone.IsPrimaryKey = false;
                colvarFechainterpone.IsForeignKey = false;
                colvarFechainterpone.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechainterpone);
                
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
                
                TableSchema.TableColumn colvarAbogadoactor = new TableSchema.TableColumn(schema);
                colvarAbogadoactor.ColumnName = "abogadoactor";
                colvarAbogadoactor.DataType = DbType.String;
                colvarAbogadoactor.MaxLength = 500;
                colvarAbogadoactor.AutoIncrement = false;
                colvarAbogadoactor.IsNullable = true;
                colvarAbogadoactor.IsPrimaryKey = false;
                colvarAbogadoactor.IsForeignKey = false;
                colvarAbogadoactor.IsReadOnly = false;
                
                schema.Columns.Add(colvarAbogadoactor);
                
                TableSchema.TableColumn colvarActor = new TableSchema.TableColumn(schema);
                colvarActor.ColumnName = "actor";
                colvarActor.DataType = DbType.String;
                colvarActor.MaxLength = 500;
                colvarActor.AutoIncrement = false;
                colvarActor.IsNullable = true;
                colvarActor.IsPrimaryKey = false;
                colvarActor.IsForeignKey = false;
                colvarActor.IsReadOnly = false;
                
                schema.Columns.Add(colvarActor);
                
                TableSchema.TableColumn colvarDemandado = new TableSchema.TableColumn(schema);
                colvarDemandado.ColumnName = "demandado";
                colvarDemandado.DataType = DbType.String;
                colvarDemandado.MaxLength = 500;
                colvarDemandado.AutoIncrement = false;
                colvarDemandado.IsNullable = true;
                colvarDemandado.IsPrimaryKey = false;
                colvarDemandado.IsForeignKey = false;
                colvarDemandado.IsReadOnly = false;
                
                schema.Columns.Add(colvarDemandado);
                
                TableSchema.TableColumn colvarDescripocion = new TableSchema.TableColumn(schema);
                colvarDescripocion.ColumnName = "descripocion";
                colvarDescripocion.DataType = DbType.String;
                colvarDescripocion.MaxLength = 500;
                colvarDescripocion.AutoIncrement = false;
                colvarDescripocion.IsNullable = true;
                colvarDescripocion.IsPrimaryKey = false;
                colvarDescripocion.IsForeignKey = false;
                colvarDescripocion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripocion);
                
                TableSchema.TableColumn colvarAutoCaso = new TableSchema.TableColumn(schema);
                colvarAutoCaso.ColumnName = "AutoCaso";
                colvarAutoCaso.DataType = DbType.String;
                colvarAutoCaso.MaxLength = 500;
                colvarAutoCaso.AutoIncrement = false;
                colvarAutoCaso.IsNullable = true;
                colvarAutoCaso.IsPrimaryKey = false;
                colvarAutoCaso.IsForeignKey = false;
                colvarAutoCaso.IsReadOnly = false;
                
                schema.Columns.Add(colvarAutoCaso);
                
                TableSchema.TableColumn colvarBusqueda = new TableSchema.TableColumn(schema);
                colvarBusqueda.ColumnName = "busqueda";
                colvarBusqueda.DataType = DbType.String;
                colvarBusqueda.MaxLength = 4000;
                colvarBusqueda.AutoIncrement = false;
                colvarBusqueda.IsNullable = true;
                colvarBusqueda.IsPrimaryKey = false;
                colvarBusqueda.IsForeignKey = false;
                colvarBusqueda.IsReadOnly = false;
                
                schema.Columns.Add(colvarBusqueda);
                
                TableSchema.TableColumn colvarActualizacion = new TableSchema.TableColumn(schema);
                colvarActualizacion.ColumnName = "Actualizacion";
                colvarActualizacion.DataType = DbType.DateTime;
                colvarActualizacion.MaxLength = 0;
                colvarActualizacion.AutoIncrement = false;
                colvarActualizacion.IsNullable = true;
                colvarActualizacion.IsPrimaryKey = false;
                colvarActualizacion.IsForeignKey = false;
                colvarActualizacion.IsReadOnly = false;
                
                schema.Columns.Add(colvarActualizacion);
                
                TableSchema.TableColumn colvarIdetapa = new TableSchema.TableColumn(schema);
                colvarIdetapa.ColumnName = "idetapa";
                colvarIdetapa.DataType = DbType.Int32;
                colvarIdetapa.MaxLength = 0;
                colvarIdetapa.AutoIncrement = false;
                colvarIdetapa.IsNullable = true;
                colvarIdetapa.IsPrimaryKey = false;
                colvarIdetapa.IsForeignKey = false;
                colvarIdetapa.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdetapa);
                
                TableSchema.TableColumn colvarOrigenCorresp = new TableSchema.TableColumn(schema);
                colvarOrigenCorresp.ColumnName = "OrigenCorresp";
                colvarOrigenCorresp.DataType = DbType.String;
                colvarOrigenCorresp.MaxLength = 500;
                colvarOrigenCorresp.AutoIncrement = false;
                colvarOrigenCorresp.IsNullable = true;
                colvarOrigenCorresp.IsPrimaryKey = false;
                colvarOrigenCorresp.IsForeignKey = false;
                colvarOrigenCorresp.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrigenCorresp);
                
                TableSchema.TableColumn colvarIDStatusCorrespondencia = new TableSchema.TableColumn(schema);
                colvarIDStatusCorrespondencia.ColumnName = "IDStatusCorrespondencia";
                colvarIDStatusCorrespondencia.DataType = DbType.Int32;
                colvarIDStatusCorrespondencia.MaxLength = 0;
                colvarIDStatusCorrespondencia.AutoIncrement = false;
                colvarIDStatusCorrespondencia.IsNullable = true;
                colvarIDStatusCorrespondencia.IsPrimaryKey = false;
                colvarIDStatusCorrespondencia.IsForeignKey = false;
                colvarIDStatusCorrespondencia.IsReadOnly = false;
                
                schema.Columns.Add(colvarIDStatusCorrespondencia);
                
                TableSchema.TableColumn colvarBuscaCorres = new TableSchema.TableColumn(schema);
                colvarBuscaCorres.ColumnName = "BuscaCorres";
                colvarBuscaCorres.DataType = DbType.String;
                colvarBuscaCorres.MaxLength = 4000;
                colvarBuscaCorres.AutoIncrement = false;
                colvarBuscaCorres.IsNullable = true;
                colvarBuscaCorres.IsPrimaryKey = false;
                colvarBuscaCorres.IsForeignKey = false;
                colvarBuscaCorres.IsReadOnly = false;
                
                schema.Columns.Add(colvarBuscaCorres);
                
                TableSchema.TableColumn colvarDestiny = new TableSchema.TableColumn(schema);
                colvarDestiny.ColumnName = "Destiny";
                colvarDestiny.DataType = DbType.String;
                colvarDestiny.MaxLength = 500;
                colvarDestiny.AutoIncrement = false;
                colvarDestiny.IsNullable = true;
                colvarDestiny.IsPrimaryKey = false;
                colvarDestiny.IsForeignKey = false;
                colvarDestiny.IsReadOnly = false;
                
                schema.Columns.Add(colvarDestiny);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Default"].AddSchema("ArboladoGrid",schema);
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
	    public ArboladoGrid()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ArboladoGrid(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ArboladoGrid(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ArboladoGrid(string columnName, object columnValue)
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
			    return GetColumnValue<string>("value");
		    }
            set 
		    {
			    SetColumnValue("value", value);
            }
        }
	      
        [XmlAttribute("Usuarios")]
        [Bindable(true)]
        public string Usuarios 
	    {
		    get
		    {
			    return GetColumnValue<string>("usuarios");
		    }
            set 
		    {
			    SetColumnValue("usuarios", value);
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
	      
        [XmlAttribute("IDActor")]
        [Bindable(true)]
        public int? IDActor 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDActor");
		    }
            set 
		    {
			    SetColumnValue("IDActor", value);
            }
        }
	      
        [XmlAttribute("IDAbogadoActor")]
        [Bindable(true)]
        public int? IDAbogadoActor 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDAbogadoActor");
		    }
            set 
		    {
			    SetColumnValue("IDAbogadoActor", value);
            }
        }
	      
        [XmlAttribute("IDDemandado")]
        [Bindable(true)]
        public int? IDDemandado 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDDemandado");
		    }
            set 
		    {
			    SetColumnValue("IDDemandado", value);
            }
        }
	      
        [XmlAttribute("IDAutocaso")]
        [Bindable(true)]
        public int? IDAutocaso 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDAutocaso");
		    }
            set 
		    {
			    SetColumnValue("IDAutocaso", value);
            }
        }
	      
        [XmlAttribute("IDTipojuicio")]
        [Bindable(true)]
        public int? IDTipojuicio 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDTipojuicio");
		    }
            set 
		    {
			    SetColumnValue("IDTipojuicio", value);
            }
        }
	      
        [XmlAttribute("Causa")]
        [Bindable(true)]
        public string Causa 
	    {
		    get
		    {
			    return GetColumnValue<string>("Causa");
		    }
            set 
		    {
			    SetColumnValue("Causa", value);
            }
        }
	      
        [XmlAttribute("Etapa")]
        [Bindable(true)]
        public string Etapa 
	    {
		    get
		    {
			    return GetColumnValue<string>("Etapa");
		    }
            set 
		    {
			    SetColumnValue("Etapa", value);
            }
        }
	      
        [XmlAttribute("Fechaconoce")]
        [Bindable(true)]
        public DateTime? Fechaconoce 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("fechaconoce");
		    }
            set 
		    {
			    SetColumnValue("fechaconoce", value);
            }
        }
	      
        [XmlAttribute("Fechainterpone")]
        [Bindable(true)]
        public string Fechainterpone 
	    {
		    get
		    {
			    return GetColumnValue<string>("fechainterpone");
		    }
            set 
		    {
			    SetColumnValue("fechainterpone", value);
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
	      
        [XmlAttribute("Abogadoactor")]
        [Bindable(true)]
        public string Abogadoactor 
	    {
		    get
		    {
			    return GetColumnValue<string>("abogadoactor");
		    }
            set 
		    {
			    SetColumnValue("abogadoactor", value);
            }
        }
	      
        [XmlAttribute("Actor")]
        [Bindable(true)]
        public string Actor 
	    {
		    get
		    {
			    return GetColumnValue<string>("actor");
		    }
            set 
		    {
			    SetColumnValue("actor", value);
            }
        }
	      
        [XmlAttribute("Demandado")]
        [Bindable(true)]
        public string Demandado 
	    {
		    get
		    {
			    return GetColumnValue<string>("demandado");
		    }
            set 
		    {
			    SetColumnValue("demandado", value);
            }
        }
	      
        [XmlAttribute("Descripocion")]
        [Bindable(true)]
        public string Descripocion 
	    {
		    get
		    {
			    return GetColumnValue<string>("descripocion");
		    }
            set 
		    {
			    SetColumnValue("descripocion", value);
            }
        }
	      
        [XmlAttribute("AutoCaso")]
        [Bindable(true)]
        public string AutoCaso 
	    {
		    get
		    {
			    return GetColumnValue<string>("AutoCaso");
		    }
            set 
		    {
			    SetColumnValue("AutoCaso", value);
            }
        }
	      
        [XmlAttribute("Busqueda")]
        [Bindable(true)]
        public string Busqueda 
	    {
		    get
		    {
			    return GetColumnValue<string>("busqueda");
		    }
            set 
		    {
			    SetColumnValue("busqueda", value);
            }
        }
	      
        [XmlAttribute("Actualizacion")]
        [Bindable(true)]
        public DateTime? Actualizacion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("Actualizacion");
		    }
            set 
		    {
			    SetColumnValue("Actualizacion", value);
            }
        }
	      
        [XmlAttribute("Idetapa")]
        [Bindable(true)]
        public int? Idetapa 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idetapa");
		    }
            set 
		    {
			    SetColumnValue("idetapa", value);
            }
        }
	      
        [XmlAttribute("OrigenCorresp")]
        [Bindable(true)]
        public string OrigenCorresp 
	    {
		    get
		    {
			    return GetColumnValue<string>("OrigenCorresp");
		    }
            set 
		    {
			    SetColumnValue("OrigenCorresp", value);
            }
        }
	      
        [XmlAttribute("IDStatusCorrespondencia")]
        [Bindable(true)]
        public int? IDStatusCorrespondencia 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IDStatusCorrespondencia");
		    }
            set 
		    {
			    SetColumnValue("IDStatusCorrespondencia", value);
            }
        }
	      
        [XmlAttribute("BuscaCorres")]
        [Bindable(true)]
        public string BuscaCorres 
	    {
		    get
		    {
			    return GetColumnValue<string>("BuscaCorres");
		    }
            set 
		    {
			    SetColumnValue("BuscaCorres", value);
            }
        }
	      
        [XmlAttribute("Destiny")]
        [Bindable(true)]
        public string Destiny 
	    {
		    get
		    {
			    return GetColumnValue<string>("Destiny");
		    }
            set 
		    {
			    SetColumnValue("Destiny", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ValueX = @"value";
            
            public static string Usuarios = @"usuarios";
            
            public static string IDDepende = @"IDDepende";
            
            public static string IDTIpoContenido = @"IDTIpoContenido";
            
            public static string Descripcion = @"Descripcion";
            
            public static string IDActor = @"IDActor";
            
            public static string IDAbogadoActor = @"IDAbogadoActor";
            
            public static string IDDemandado = @"IDDemandado";
            
            public static string IDAutocaso = @"IDAutocaso";
            
            public static string IDTipojuicio = @"IDTipojuicio";
            
            public static string Causa = @"Causa";
            
            public static string Etapa = @"Etapa";
            
            public static string Fechaconoce = @"fechaconoce";
            
            public static string Fechainterpone = @"fechainterpone";
            
            public static string Status = @"status";
            
            public static string Id = @"ID";
            
            public static string Abogadoactor = @"abogadoactor";
            
            public static string Actor = @"actor";
            
            public static string Demandado = @"demandado";
            
            public static string Descripocion = @"descripocion";
            
            public static string AutoCaso = @"AutoCaso";
            
            public static string Busqueda = @"busqueda";
            
            public static string Actualizacion = @"Actualizacion";
            
            public static string Idetapa = @"idetapa";
            
            public static string OrigenCorresp = @"OrigenCorresp";
            
            public static string IDStatusCorrespondencia = @"IDStatusCorrespondencia";
            
            public static string BuscaCorres = @"BuscaCorres";
            
            public static string Destiny = @"Destiny";
            
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
