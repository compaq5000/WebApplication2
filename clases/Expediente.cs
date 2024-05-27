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
namespace SubSonicDB
{
	/// <summary>
	/// Strongly-typed collection for the Expediente class.
	/// </summary>
    [Serializable]
	public partial class ExpedienteCollection : ActiveList<Expediente, ExpedienteCollection>
	{	   
		public ExpedienteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ExpedienteCollection</returns>
		public ExpedienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Expediente o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the Expedientes table.
	/// </summary>
	[Serializable]
	public partial class Expediente : ActiveRecord<Expediente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Expediente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Expediente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Expediente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Expediente(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("Expedientes", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUsuarios = new TableSchema.TableColumn(schema);
				colvarUsuarios.ColumnName = "usuarios";
				colvarUsuarios.DataType = DbType.String;
				colvarUsuarios.MaxLength = 50;
				colvarUsuarios.AutoIncrement = false;
				colvarUsuarios.IsNullable = true;
				colvarUsuarios.IsPrimaryKey = false;
				colvarUsuarios.IsForeignKey = false;
				colvarUsuarios.IsReadOnly = false;
				colvarUsuarios.DefaultSetting = @"";
				colvarUsuarios.ForeignKeyTableName = "";
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
				colvarIDDepende.DefaultSetting = @"";
				colvarIDDepende.ForeignKeyTableName = "";
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
				colvarIDTIpoContenido.DefaultSetting = @"";
				colvarIDTIpoContenido.ForeignKeyTableName = "";
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
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
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
				colvarIDActor.DefaultSetting = @"";
				colvarIDActor.ForeignKeyTableName = "";
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
				colvarIDAbogadoActor.DefaultSetting = @"";
				colvarIDAbogadoActor.ForeignKeyTableName = "";
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
				colvarIDDemandado.DefaultSetting = @"";
				colvarIDDemandado.ForeignKeyTableName = "";
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
				colvarIDAutocaso.DefaultSetting = @"";
				colvarIDAutocaso.ForeignKeyTableName = "";
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
				colvarIDTipojuicio.DefaultSetting = @"";
				colvarIDTipojuicio.ForeignKeyTableName = "";
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
				colvarCausa.DefaultSetting = @"";
				colvarCausa.ForeignKeyTableName = "";
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
				colvarEtapa.DefaultSetting = @"";
				colvarEtapa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEtapa);
				
				TableSchema.TableColumn colvarIDEtapa = new TableSchema.TableColumn(schema);
				colvarIDEtapa.ColumnName = "IDEtapa";
				colvarIDEtapa.DataType = DbType.Int32;
				colvarIDEtapa.MaxLength = 0;
				colvarIDEtapa.AutoIncrement = false;
				colvarIDEtapa.IsNullable = true;
				colvarIDEtapa.IsPrimaryKey = false;
				colvarIDEtapa.IsForeignKey = false;
				colvarIDEtapa.IsReadOnly = false;
				colvarIDEtapa.DefaultSetting = @"";
				colvarIDEtapa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDEtapa);
				
				TableSchema.TableColumn colvarFechaconoce = new TableSchema.TableColumn(schema);
				colvarFechaconoce.ColumnName = "fechaconoce";
				colvarFechaconoce.DataType = DbType.DateTime;
				colvarFechaconoce.MaxLength = 0;
				colvarFechaconoce.AutoIncrement = false;
				colvarFechaconoce.IsNullable = true;
				colvarFechaconoce.IsPrimaryKey = false;
				colvarFechaconoce.IsForeignKey = false;
				colvarFechaconoce.IsReadOnly = false;
				colvarFechaconoce.DefaultSetting = @"";
				colvarFechaconoce.ForeignKeyTableName = "";
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
				colvarFechainterpone.DefaultSetting = @"";
				colvarFechainterpone.ForeignKeyTableName = "";
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
				colvarStatus.DefaultSetting = @"";
				colvarStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatus);
				
				TableSchema.TableColumn colvarActualizacion = new TableSchema.TableColumn(schema);
				colvarActualizacion.ColumnName = "Actualizacion";
				colvarActualizacion.DataType = DbType.DateTime;
				colvarActualizacion.MaxLength = 0;
				colvarActualizacion.AutoIncrement = false;
				colvarActualizacion.IsNullable = true;
				colvarActualizacion.IsPrimaryKey = false;
				colvarActualizacion.IsForeignKey = false;
				colvarActualizacion.IsReadOnly = false;
				colvarActualizacion.DefaultSetting = @"";
				colvarActualizacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActualizacion);
				
				TableSchema.TableColumn colvarIDUser = new TableSchema.TableColumn(schema);
				colvarIDUser.ColumnName = "IDUser";
				colvarIDUser.DataType = DbType.Int32;
				colvarIDUser.MaxLength = 0;
				colvarIDUser.AutoIncrement = false;
				colvarIDUser.IsNullable = true;
				colvarIDUser.IsPrimaryKey = false;
				colvarIDUser.IsForeignKey = false;
				colvarIDUser.IsReadOnly = false;
				colvarIDUser.DefaultSetting = @"";
				colvarIDUser.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDUser);
				
				TableSchema.TableColumn colvarTomo = new TableSchema.TableColumn(schema);
				colvarTomo.ColumnName = "Tomo";
				colvarTomo.DataType = DbType.String;
				colvarTomo.MaxLength = 50;
				colvarTomo.AutoIncrement = false;
				colvarTomo.IsNullable = true;
				colvarTomo.IsPrimaryKey = false;
				colvarTomo.IsForeignKey = false;
				colvarTomo.IsReadOnly = false;
				colvarTomo.DefaultSetting = @"";
				colvarTomo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTomo);
				
				TableSchema.TableColumn colvarIDOrigenCorres = new TableSchema.TableColumn(schema);
				colvarIDOrigenCorres.ColumnName = "IDOrigenCorres";
				colvarIDOrigenCorres.DataType = DbType.Int32;
				colvarIDOrigenCorres.MaxLength = 0;
				colvarIDOrigenCorres.AutoIncrement = false;
				colvarIDOrigenCorres.IsNullable = true;
				colvarIDOrigenCorres.IsPrimaryKey = false;
				colvarIDOrigenCorres.IsForeignKey = true;
				colvarIDOrigenCorres.IsReadOnly = false;
				colvarIDOrigenCorres.DefaultSetting = @"";
				
					colvarIDOrigenCorres.ForeignKeyTableName = "CatOrigenCorrespondencia";
				schema.Columns.Add(colvarIDOrigenCorres);
				
				TableSchema.TableColumn colvarIDStatusCorrespondencia = new TableSchema.TableColumn(schema);
				colvarIDStatusCorrespondencia.ColumnName = "IDStatusCorrespondencia";
				colvarIDStatusCorrespondencia.DataType = DbType.Int32;
				colvarIDStatusCorrespondencia.MaxLength = 0;
				colvarIDStatusCorrespondencia.AutoIncrement = false;
				colvarIDStatusCorrespondencia.IsNullable = true;
				colvarIDStatusCorrespondencia.IsPrimaryKey = false;
				colvarIDStatusCorrespondencia.IsForeignKey = false;
				colvarIDStatusCorrespondencia.IsReadOnly = false;
				colvarIDStatusCorrespondencia.DefaultSetting = @"";
				colvarIDStatusCorrespondencia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDStatusCorrespondencia);
				
				TableSchema.TableColumn colvarStatusRetornado = new TableSchema.TableColumn(schema);
				colvarStatusRetornado.ColumnName = "StatusRetornado";
				colvarStatusRetornado.DataType = DbType.Boolean;
				colvarStatusRetornado.MaxLength = 0;
				colvarStatusRetornado.AutoIncrement = false;
				colvarStatusRetornado.IsNullable = true;
				colvarStatusRetornado.IsPrimaryKey = false;
				colvarStatusRetornado.IsForeignKey = false;
				colvarStatusRetornado.IsReadOnly = false;
				colvarStatusRetornado.DefaultSetting = @"";
				colvarStatusRetornado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatusRetornado);
				
				TableSchema.TableColumn colvarIDDestinoCorrespondencia = new TableSchema.TableColumn(schema);
				colvarIDDestinoCorrespondencia.ColumnName = "IDDestinoCorrespondencia";
				colvarIDDestinoCorrespondencia.DataType = DbType.Int32;
				colvarIDDestinoCorrespondencia.MaxLength = 0;
				colvarIDDestinoCorrespondencia.AutoIncrement = false;
				colvarIDDestinoCorrespondencia.IsNullable = true;
				colvarIDDestinoCorrespondencia.IsPrimaryKey = false;
				colvarIDDestinoCorrespondencia.IsForeignKey = false;
				colvarIDDestinoCorrespondencia.IsReadOnly = false;
				colvarIDDestinoCorrespondencia.DefaultSetting = @"";
				colvarIDDestinoCorrespondencia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDDestinoCorrespondencia);
				
				TableSchema.TableColumn colvarPaginas = new TableSchema.TableColumn(schema);
				colvarPaginas.ColumnName = "Paginas";
				colvarPaginas.DataType = DbType.String;
				colvarPaginas.MaxLength = 50;
				colvarPaginas.AutoIncrement = false;
				colvarPaginas.IsNullable = true;
				colvarPaginas.IsPrimaryKey = false;
				colvarPaginas.IsForeignKey = false;
				colvarPaginas.IsReadOnly = false;
				colvarPaginas.DefaultSetting = @"";
				colvarPaginas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPaginas);
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarIDDependenciaEjecutora = new TableSchema.TableColumn(schema);
				colvarIDDependenciaEjecutora.ColumnName = "IDDependenciaEjecutora";
				colvarIDDependenciaEjecutora.DataType = DbType.Int32;
				colvarIDDependenciaEjecutora.MaxLength = 0;
				colvarIDDependenciaEjecutora.AutoIncrement = false;
				colvarIDDependenciaEjecutora.IsNullable = true;
				colvarIDDependenciaEjecutora.IsPrimaryKey = false;
				colvarIDDependenciaEjecutora.IsForeignKey = true;
				colvarIDDependenciaEjecutora.IsReadOnly = false;
				colvarIDDependenciaEjecutora.DefaultSetting = @"";
				
					colvarIDDependenciaEjecutora.ForeignKeyTableName = "CatDepeEjecutoria_Inventarios";
				schema.Columns.Add(colvarIDDependenciaEjecutora);
				
				TableSchema.TableColumn colvarIDEje = new TableSchema.TableColumn(schema);
				colvarIDEje.ColumnName = "IDEje";
				colvarIDEje.DataType = DbType.Int32;
				colvarIDEje.MaxLength = 0;
				colvarIDEje.AutoIncrement = false;
				colvarIDEje.IsNullable = true;
				colvarIDEje.IsPrimaryKey = false;
				colvarIDEje.IsForeignKey = true;
				colvarIDEje.IsReadOnly = false;
				colvarIDEje.DefaultSetting = @"";
				
					colvarIDEje.ForeignKeyTableName = "CatEje_invetario";
				schema.Columns.Add(colvarIDEje);
				
				TableSchema.TableColumn colvarIDPrioridadNacional = new TableSchema.TableColumn(schema);
				colvarIDPrioridadNacional.ColumnName = "IDPrioridadNacional";
				colvarIDPrioridadNacional.DataType = DbType.Int32;
				colvarIDPrioridadNacional.MaxLength = 0;
				colvarIDPrioridadNacional.AutoIncrement = false;
				colvarIDPrioridadNacional.IsNullable = true;
				colvarIDPrioridadNacional.IsPrimaryKey = false;
				colvarIDPrioridadNacional.IsForeignKey = true;
				colvarIDPrioridadNacional.IsReadOnly = false;
				colvarIDPrioridadNacional.DefaultSetting = @"";
				
					colvarIDPrioridadNacional.ForeignKeyTableName = "CatProgramaPrioridadNacional_inventarios";
				schema.Columns.Add(colvarIDPrioridadNacional);
				
				TableSchema.TableColumn colvarIDSubprograma = new TableSchema.TableColumn(schema);
				colvarIDSubprograma.ColumnName = "IDSubprograma";
				colvarIDSubprograma.DataType = DbType.Int32;
				colvarIDSubprograma.MaxLength = 0;
				colvarIDSubprograma.AutoIncrement = false;
				colvarIDSubprograma.IsNullable = true;
				colvarIDSubprograma.IsPrimaryKey = false;
				colvarIDSubprograma.IsForeignKey = true;
				colvarIDSubprograma.IsReadOnly = false;
				colvarIDSubprograma.DefaultSetting = @"";
				
					colvarIDSubprograma.ForeignKeyTableName = "CatSubprograma_Invenatarios";
				schema.Columns.Add(colvarIDSubprograma);
				
				TableSchema.TableColumn colvarIDEjercicio = new TableSchema.TableColumn(schema);
				colvarIDEjercicio.ColumnName = "IDEjercicio";
				colvarIDEjercicio.DataType = DbType.Int32;
				colvarIDEjercicio.MaxLength = 0;
				colvarIDEjercicio.AutoIncrement = false;
				colvarIDEjercicio.IsNullable = true;
				colvarIDEjercicio.IsPrimaryKey = false;
				colvarIDEjercicio.IsForeignKey = true;
				colvarIDEjercicio.IsReadOnly = false;
				colvarIDEjercicio.DefaultSetting = @"";
				
					colvarIDEjercicio.ForeignKeyTableName = "CatEjercicio_Inventarios";
				schema.Columns.Add(colvarIDEjercicio);
				
				TableSchema.TableColumn colvarIDCapitulo = new TableSchema.TableColumn(schema);
				colvarIDCapitulo.ColumnName = "IDCapitulo";
				colvarIDCapitulo.DataType = DbType.Int32;
				colvarIDCapitulo.MaxLength = 0;
				colvarIDCapitulo.AutoIncrement = false;
				colvarIDCapitulo.IsNullable = true;
				colvarIDCapitulo.IsPrimaryKey = false;
				colvarIDCapitulo.IsForeignKey = true;
				colvarIDCapitulo.IsReadOnly = false;
				colvarIDCapitulo.DefaultSetting = @"";
				
					colvarIDCapitulo.ForeignKeyTableName = "CatCapitulo_Inventarios";
				schema.Columns.Add(colvarIDCapitulo);
				
				TableSchema.TableColumn colvarIDConcepto = new TableSchema.TableColumn(schema);
				colvarIDConcepto.ColumnName = "IDConcepto";
				colvarIDConcepto.DataType = DbType.Int32;
				colvarIDConcepto.MaxLength = 0;
				colvarIDConcepto.AutoIncrement = false;
				colvarIDConcepto.IsNullable = true;
				colvarIDConcepto.IsPrimaryKey = false;
				colvarIDConcepto.IsForeignKey = true;
				colvarIDConcepto.IsReadOnly = false;
				colvarIDConcepto.DefaultSetting = @"";
				
					colvarIDConcepto.ForeignKeyTableName = "CatConcepto_Inventarios";
				schema.Columns.Add(colvarIDConcepto);
				
				TableSchema.TableColumn colvarIDPartidaGenerica = new TableSchema.TableColumn(schema);
				colvarIDPartidaGenerica.ColumnName = "IDPartidaGenerica";
				colvarIDPartidaGenerica.DataType = DbType.Int32;
				colvarIDPartidaGenerica.MaxLength = 0;
				colvarIDPartidaGenerica.AutoIncrement = false;
				colvarIDPartidaGenerica.IsNullable = true;
				colvarIDPartidaGenerica.IsPrimaryKey = false;
				colvarIDPartidaGenerica.IsForeignKey = true;
				colvarIDPartidaGenerica.IsReadOnly = false;
				colvarIDPartidaGenerica.DefaultSetting = @"";
				
					colvarIDPartidaGenerica.ForeignKeyTableName = "CatPartidaGenerica_Invenatarios";
				schema.Columns.Add(colvarIDPartidaGenerica);
				
				TableSchema.TableColumn colvarIDPartidaEspecifica = new TableSchema.TableColumn(schema);
				colvarIDPartidaEspecifica.ColumnName = "IDPartidaEspecifica";
				colvarIDPartidaEspecifica.DataType = DbType.Int32;
				colvarIDPartidaEspecifica.MaxLength = 0;
				colvarIDPartidaEspecifica.AutoIncrement = false;
				colvarIDPartidaEspecifica.IsNullable = true;
				colvarIDPartidaEspecifica.IsPrimaryKey = false;
				colvarIDPartidaEspecifica.IsForeignKey = true;
				colvarIDPartidaEspecifica.IsReadOnly = false;
				colvarIDPartidaEspecifica.DefaultSetting = @"";
				
					colvarIDPartidaEspecifica.ForeignKeyTableName = "CatPartidaEspecifica_Inventarios";
				schema.Columns.Add(colvarIDPartidaEspecifica);
				
				TableSchema.TableColumn colvarIDTipoRecurso = new TableSchema.TableColumn(schema);
				colvarIDTipoRecurso.ColumnName = "IDTipoRecurso";
				colvarIDTipoRecurso.DataType = DbType.Int32;
				colvarIDTipoRecurso.MaxLength = 0;
				colvarIDTipoRecurso.AutoIncrement = false;
				colvarIDTipoRecurso.IsNullable = true;
				colvarIDTipoRecurso.IsPrimaryKey = false;
				colvarIDTipoRecurso.IsForeignKey = true;
				colvarIDTipoRecurso.IsReadOnly = false;
				colvarIDTipoRecurso.DefaultSetting = @"";
				
					colvarIDTipoRecurso.ForeignKeyTableName = "CatTipoRecurso_Inventarios";
				schema.Columns.Add(colvarIDTipoRecurso);
				
				TableSchema.TableColumn colvarIDExpedienteTecnico = new TableSchema.TableColumn(schema);
				colvarIDExpedienteTecnico.ColumnName = "IDExpedienteTecnico";
				colvarIDExpedienteTecnico.DataType = DbType.Int32;
				colvarIDExpedienteTecnico.MaxLength = 0;
				colvarIDExpedienteTecnico.AutoIncrement = false;
				colvarIDExpedienteTecnico.IsNullable = true;
				colvarIDExpedienteTecnico.IsPrimaryKey = false;
				colvarIDExpedienteTecnico.IsForeignKey = true;
				colvarIDExpedienteTecnico.IsReadOnly = false;
				colvarIDExpedienteTecnico.DefaultSetting = @"";
				
					colvarIDExpedienteTecnico.ForeignKeyTableName = "CatExpedienteTecnico_Inventarios";
				schema.Columns.Add(colvarIDExpedienteTecnico);
				
				TableSchema.TableColumn colvarImporte = new TableSchema.TableColumn(schema);
				colvarImporte.ColumnName = "Importe";
				colvarImporte.DataType = DbType.Currency;
				colvarImporte.MaxLength = 0;
				colvarImporte.AutoIncrement = false;
				colvarImporte.IsNullable = true;
				colvarImporte.IsPrimaryKey = false;
				colvarImporte.IsForeignKey = false;
				colvarImporte.IsReadOnly = false;
				colvarImporte.DefaultSetting = @"";
				colvarImporte.ForeignKeyTableName = "";
				schema.Columns.Add(colvarImporte);
				
				TableSchema.TableColumn colvarCantidadEnLetra = new TableSchema.TableColumn(schema);
				colvarCantidadEnLetra.ColumnName = "CantidadEnLetra";
				colvarCantidadEnLetra.DataType = DbType.String;
				colvarCantidadEnLetra.MaxLength = 300;
				colvarCantidadEnLetra.AutoIncrement = false;
				colvarCantidadEnLetra.IsNullable = true;
				colvarCantidadEnLetra.IsPrimaryKey = false;
				colvarCantidadEnLetra.IsForeignKey = false;
				colvarCantidadEnLetra.IsReadOnly = false;
				colvarCantidadEnLetra.DefaultSetting = @"";
				colvarCantidadEnLetra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidadEnLetra);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("Expedientes",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Usuarios")]
		[Bindable(true)]
		public string Usuarios 
		{
			get { return GetColumnValue<string>(Columns.Usuarios); }
			set { SetColumnValue(Columns.Usuarios, value); }
		}
		  
		[XmlAttribute("IDDepende")]
		[Bindable(true)]
		public int? IDDepende 
		{
			get { return GetColumnValue<int?>(Columns.IDDepende); }
			set { SetColumnValue(Columns.IDDepende, value); }
		}
		  
		[XmlAttribute("IDTIpoContenido")]
		[Bindable(true)]
		public int? IDTIpoContenido 
		{
			get { return GetColumnValue<int?>(Columns.IDTIpoContenido); }
			set { SetColumnValue(Columns.IDTIpoContenido, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("IDActor")]
		[Bindable(true)]
		public int? IDActor 
		{
			get { return GetColumnValue<int?>(Columns.IDActor); }
			set { SetColumnValue(Columns.IDActor, value); }
		}
		  
		[XmlAttribute("IDAbogadoActor")]
		[Bindable(true)]
		public int? IDAbogadoActor 
		{
			get { return GetColumnValue<int?>(Columns.IDAbogadoActor); }
			set { SetColumnValue(Columns.IDAbogadoActor, value); }
		}
		  
		[XmlAttribute("IDDemandado")]
		[Bindable(true)]
		public int? IDDemandado 
		{
			get { return GetColumnValue<int?>(Columns.IDDemandado); }
			set { SetColumnValue(Columns.IDDemandado, value); }
		}
		  
		[XmlAttribute("IDAutocaso")]
		[Bindable(true)]
		public int? IDAutocaso 
		{
			get { return GetColumnValue<int?>(Columns.IDAutocaso); }
			set { SetColumnValue(Columns.IDAutocaso, value); }
		}
		  
		[XmlAttribute("IDTipojuicio")]
		[Bindable(true)]
		public int? IDTipojuicio 
		{
			get { return GetColumnValue<int?>(Columns.IDTipojuicio); }
			set { SetColumnValue(Columns.IDTipojuicio, value); }
		}
		  
		[XmlAttribute("Causa")]
		[Bindable(true)]
		public string Causa 
		{
			get { return GetColumnValue<string>(Columns.Causa); }
			set { SetColumnValue(Columns.Causa, value); }
		}
		  
		[XmlAttribute("Etapa")]
		[Bindable(true)]
		public string Etapa 
		{
			get { return GetColumnValue<string>(Columns.Etapa); }
			set { SetColumnValue(Columns.Etapa, value); }
		}
		  
		[XmlAttribute("IDEtapa")]
		[Bindable(true)]
		public int? IDEtapa 
		{
			get { return GetColumnValue<int?>(Columns.IDEtapa); }
			set { SetColumnValue(Columns.IDEtapa, value); }
		}
		  
		[XmlAttribute("Fechaconoce")]
		[Bindable(true)]
		public DateTime? Fechaconoce 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fechaconoce); }
			set { SetColumnValue(Columns.Fechaconoce, value); }
		}
		  
		[XmlAttribute("Fechainterpone")]
		[Bindable(true)]
		public string Fechainterpone 
		{
			get { return GetColumnValue<string>(Columns.Fechainterpone); }
			set { SetColumnValue(Columns.Fechainterpone, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public bool? Status 
		{
			get { return GetColumnValue<bool?>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("Actualizacion")]
		[Bindable(true)]
		public DateTime? Actualizacion 
		{
			get { return GetColumnValue<DateTime?>(Columns.Actualizacion); }
			set { SetColumnValue(Columns.Actualizacion, value); }
		}
		  
		[XmlAttribute("IDUser")]
		[Bindable(true)]
		public int? IDUser 
		{
			get { return GetColumnValue<int?>(Columns.IDUser); }
			set { SetColumnValue(Columns.IDUser, value); }
		}
		  
		[XmlAttribute("Tomo")]
		[Bindable(true)]
		public string Tomo 
		{
			get { return GetColumnValue<string>(Columns.Tomo); }
			set { SetColumnValue(Columns.Tomo, value); }
		}
		  
		[XmlAttribute("IDOrigenCorres")]
		[Bindable(true)]
		public int? IDOrigenCorres 
		{
			get { return GetColumnValue<int?>(Columns.IDOrigenCorres); }
			set { SetColumnValue(Columns.IDOrigenCorres, value); }
		}
		  
		[XmlAttribute("IDStatusCorrespondencia")]
		[Bindable(true)]
		public int? IDStatusCorrespondencia 
		{
			get { return GetColumnValue<int?>(Columns.IDStatusCorrespondencia); }
			set { SetColumnValue(Columns.IDStatusCorrespondencia, value); }
		}
		  
		[XmlAttribute("StatusRetornado")]
		[Bindable(true)]
		public bool? StatusRetornado 
		{
			get { return GetColumnValue<bool?>(Columns.StatusRetornado); }
			set { SetColumnValue(Columns.StatusRetornado, value); }
		}
		  
		[XmlAttribute("IDDestinoCorrespondencia")]
		[Bindable(true)]
		public int? IDDestinoCorrespondencia 
		{
			get { return GetColumnValue<int?>(Columns.IDDestinoCorrespondencia); }
			set { SetColumnValue(Columns.IDDestinoCorrespondencia, value); }
		}
		  
		[XmlAttribute("Paginas")]
		[Bindable(true)]
		public string Paginas 
		{
			get { return GetColumnValue<string>(Columns.Paginas); }
			set { SetColumnValue(Columns.Paginas, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("IDDependenciaEjecutora")]
		[Bindable(true)]
		public int? IDDependenciaEjecutora 
		{
			get { return GetColumnValue<int?>(Columns.IDDependenciaEjecutora); }
			set { SetColumnValue(Columns.IDDependenciaEjecutora, value); }
		}
		  
		[XmlAttribute("IDEje")]
		[Bindable(true)]
		public int? IDEje 
		{
			get { return GetColumnValue<int?>(Columns.IDEje); }
			set { SetColumnValue(Columns.IDEje, value); }
		}
		  
		[XmlAttribute("IDPrioridadNacional")]
		[Bindable(true)]
		public int? IDPrioridadNacional 
		{
			get { return GetColumnValue<int?>(Columns.IDPrioridadNacional); }
			set { SetColumnValue(Columns.IDPrioridadNacional, value); }
		}
		  
		[XmlAttribute("IDSubprograma")]
		[Bindable(true)]
		public int? IDSubprograma 
		{
			get { return GetColumnValue<int?>(Columns.IDSubprograma); }
			set { SetColumnValue(Columns.IDSubprograma, value); }
		}
		  
		[XmlAttribute("IDEjercicio")]
		[Bindable(true)]
		public int? IDEjercicio 
		{
			get { return GetColumnValue<int?>(Columns.IDEjercicio); }
			set { SetColumnValue(Columns.IDEjercicio, value); }
		}
		  
		[XmlAttribute("IDCapitulo")]
		[Bindable(true)]
		public int? IDCapitulo 
		{
			get { return GetColumnValue<int?>(Columns.IDCapitulo); }
			set { SetColumnValue(Columns.IDCapitulo, value); }
		}
		  
		[XmlAttribute("IDConcepto")]
		[Bindable(true)]
		public int? IDConcepto 
		{
			get { return GetColumnValue<int?>(Columns.IDConcepto); }
			set { SetColumnValue(Columns.IDConcepto, value); }
		}
		  
		[XmlAttribute("IDPartidaGenerica")]
		[Bindable(true)]
		public int? IDPartidaGenerica 
		{
			get { return GetColumnValue<int?>(Columns.IDPartidaGenerica); }
			set { SetColumnValue(Columns.IDPartidaGenerica, value); }
		}
		  
		[XmlAttribute("IDPartidaEspecifica")]
		[Bindable(true)]
		public int? IDPartidaEspecifica 
		{
			get { return GetColumnValue<int?>(Columns.IDPartidaEspecifica); }
			set { SetColumnValue(Columns.IDPartidaEspecifica, value); }
		}
		  
		[XmlAttribute("IDTipoRecurso")]
		[Bindable(true)]
		public int? IDTipoRecurso 
		{
			get { return GetColumnValue<int?>(Columns.IDTipoRecurso); }
			set { SetColumnValue(Columns.IDTipoRecurso, value); }
		}
		  
		[XmlAttribute("IDExpedienteTecnico")]
		[Bindable(true)]
		public int? IDExpedienteTecnico 
		{
			get { return GetColumnValue<int?>(Columns.IDExpedienteTecnico); }
			set { SetColumnValue(Columns.IDExpedienteTecnico, value); }
		}
		  
		[XmlAttribute("Importe")]
		[Bindable(true)]
		public decimal? Importe 
		{
			get { return GetColumnValue<decimal?>(Columns.Importe); }
			set { SetColumnValue(Columns.Importe, value); }
		}
		  
		[XmlAttribute("CantidadEnLetra")]
		[Bindable(true)]
		public string CantidadEnLetra 
		{
			get { return GetColumnValue<string>(Columns.CantidadEnLetra); }
			set { SetColumnValue(Columns.CantidadEnLetra, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.ArchivoCorrespondenciumCollection ArchivoCorrespondencia()
		{
			return new SubSonicDB.ArchivoCorrespondenciumCollection().Where(ArchivoCorrespondencium.Columns.IDExpediente, Id).Load();
		}
		public SubSonicDB.HistirlaExpedienteCollection HistirlaExpedienteRecords()
		{
			return new SubSonicDB.HistirlaExpedienteCollection().Where(HistirlaExpediente.Columns.IDExpediente, Id).Load();
		}
		public SubSonicDB.HistorialnavegacionCollection HistorialnavegacionRecords()
		{
			return new SubSonicDB.HistorialnavegacionCollection().Where(Historialnavegacion.Columns.IDCarpeta, Id).Load();
		}
		public SubSonicDB.TranPermisoCollection TranPermisos()
		{
			return new SubSonicDB.TranPermisoCollection().Where(TranPermiso.Columns.IDExpediente, Id).Load();
		}
		public SubSonicDB.TranMinutumCollection TranMinuta()
		{
			return new SubSonicDB.TranMinutumCollection().Where(TranMinutum.Columns.IDExpediente, Id).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a CatCapituloInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatCapituloInventario CatCapituloInventario
		{
			get { return SubSonicDB.CatCapituloInventario.FetchByID(this.IDCapitulo); }
			set { SetColumnValue("IDCapitulo", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatConceptoInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatConceptoInventario CatConceptoInventario
		{
			get { return SubSonicDB.CatConceptoInventario.FetchByID(this.IDConcepto); }
			set { SetColumnValue("IDConcepto", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatConceptoInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatConceptoInventario CatConceptoInventarioToIDConcepto
		{
			get { return SubSonicDB.CatConceptoInventario.FetchByID(this.IDConcepto); }
			set { SetColumnValue("IDConcepto", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatDepeEjecutoriaInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatDepeEjecutoriaInventario CatDepeEjecutoriaInventario
		{
			get { return SubSonicDB.CatDepeEjecutoriaInventario.FetchByID(this.IDDependenciaEjecutora); }
			set { SetColumnValue("IDDependenciaEjecutora", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatEjeInvetario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatEjeInvetario CatEjeInvetario
		{
			get { return SubSonicDB.CatEjeInvetario.FetchByID(this.IDEje); }
			set { SetColumnValue("IDEje", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatEjercicioInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatEjercicioInventario CatEjercicioInventario
		{
			get { return SubSonicDB.CatEjercicioInventario.FetchByID(this.IDEjercicio); }
			set { SetColumnValue("IDEjercicio", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatExpedienteTecnicoInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatExpedienteTecnicoInventario CatExpedienteTecnicoInventario
		{
			get { return SubSonicDB.CatExpedienteTecnicoInventario.FetchByID(this.IDExpedienteTecnico); }
			set { SetColumnValue("IDExpedienteTecnico", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatOrigenCorrespondencium ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatOrigenCorrespondencium CatOrigenCorrespondencium
		{
			get { return SubSonicDB.CatOrigenCorrespondencium.FetchByID(this.IDOrigenCorres); }
			set { SetColumnValue("IDOrigenCorres", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatPartidaEspecificaInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatPartidaEspecificaInventario CatPartidaEspecificaInventario
		{
			get { return SubSonicDB.CatPartidaEspecificaInventario.FetchByID(this.IDPartidaEspecifica); }
			set { SetColumnValue("IDPartidaEspecifica", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatPartidaGenericaInvenatario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatPartidaGenericaInvenatario CatPartidaGenericaInvenatario
		{
			get { return SubSonicDB.CatPartidaGenericaInvenatario.FetchByID(this.IDPartidaGenerica); }
			set { SetColumnValue("IDPartidaGenerica", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatProgramaPrioridadNacionalInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatProgramaPrioridadNacionalInventario CatProgramaPrioridadNacionalInventario
		{
			get { return SubSonicDB.CatProgramaPrioridadNacionalInventario.FetchByID(this.IDPrioridadNacional); }
			set { SetColumnValue("IDPrioridadNacional", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatSubprogramaInvenatario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatSubprogramaInvenatario CatSubprogramaInvenatario
		{
			get { return SubSonicDB.CatSubprogramaInvenatario.FetchByID(this.IDSubprograma); }
			set { SetColumnValue("IDSubprograma", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a CatTipoRecursoInventario ActiveRecord object related to this Expediente
		/// 
		/// </summary>
		public SubSonicDB.CatTipoRecursoInventario CatTipoRecursoInventario
		{
			get { return SubSonicDB.CatTipoRecursoInventario.FetchByID(this.IDTipoRecurso); }
			set { SetColumnValue("IDTipoRecurso", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUsuarios,int? varIDDepende,int? varIDTIpoContenido,string varDescripcion,int? varIDActor,int? varIDAbogadoActor,int? varIDDemandado,int? varIDAutocaso,int? varIDTipojuicio,string varCausa,string varEtapa,int? varIDEtapa,DateTime? varFechaconoce,string varFechainterpone,bool? varStatus,DateTime? varActualizacion,int? varIDUser,string varTomo,int? varIDOrigenCorres,int? varIDStatusCorrespondencia,bool? varStatusRetornado,int? varIDDestinoCorrespondencia,string varPaginas,int? varIDDependenciaEjecutora,int? varIDEje,int? varIDPrioridadNacional,int? varIDSubprograma,int? varIDEjercicio,int? varIDCapitulo,int? varIDConcepto,int? varIDPartidaGenerica,int? varIDPartidaEspecifica,int? varIDTipoRecurso,int? varIDExpedienteTecnico,decimal? varImporte,string varCantidadEnLetra)
		{
			Expediente item = new Expediente();
			
			item.Usuarios = varUsuarios;
			
			item.IDDepende = varIDDepende;
			
			item.IDTIpoContenido = varIDTIpoContenido;
			
			item.Descripcion = varDescripcion;
			
			item.IDActor = varIDActor;
			
			item.IDAbogadoActor = varIDAbogadoActor;
			
			item.IDDemandado = varIDDemandado;
			
			item.IDAutocaso = varIDAutocaso;
			
			item.IDTipojuicio = varIDTipojuicio;
			
			item.Causa = varCausa;
			
			item.Etapa = varEtapa;
			
			item.IDEtapa = varIDEtapa;
			
			item.Fechaconoce = varFechaconoce;
			
			item.Fechainterpone = varFechainterpone;
			
			item.Status = varStatus;
			
			item.Actualizacion = varActualizacion;
			
			item.IDUser = varIDUser;
			
			item.Tomo = varTomo;
			
			item.IDOrigenCorres = varIDOrigenCorres;
			
			item.IDStatusCorrespondencia = varIDStatusCorrespondencia;
			
			item.StatusRetornado = varStatusRetornado;
			
			item.IDDestinoCorrespondencia = varIDDestinoCorrespondencia;
			
			item.Paginas = varPaginas;
			
			item.IDDependenciaEjecutora = varIDDependenciaEjecutora;
			
			item.IDEje = varIDEje;
			
			item.IDPrioridadNacional = varIDPrioridadNacional;
			
			item.IDSubprograma = varIDSubprograma;
			
			item.IDEjercicio = varIDEjercicio;
			
			item.IDCapitulo = varIDCapitulo;
			
			item.IDConcepto = varIDConcepto;
			
			item.IDPartidaGenerica = varIDPartidaGenerica;
			
			item.IDPartidaEspecifica = varIDPartidaEspecifica;
			
			item.IDTipoRecurso = varIDTipoRecurso;
			
			item.IDExpedienteTecnico = varIDExpedienteTecnico;
			
			item.Importe = varImporte;
			
			item.CantidadEnLetra = varCantidadEnLetra;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varUsuarios,int? varIDDepende,int? varIDTIpoContenido,string varDescripcion,int? varIDActor,int? varIDAbogadoActor,int? varIDDemandado,int? varIDAutocaso,int? varIDTipojuicio,string varCausa,string varEtapa,int? varIDEtapa,DateTime? varFechaconoce,string varFechainterpone,bool? varStatus,DateTime? varActualizacion,int? varIDUser,string varTomo,int? varIDOrigenCorres,int? varIDStatusCorrespondencia,bool? varStatusRetornado,int? varIDDestinoCorrespondencia,string varPaginas,int varId,int? varIDDependenciaEjecutora,int? varIDEje,int? varIDPrioridadNacional,int? varIDSubprograma,int? varIDEjercicio,int? varIDCapitulo,int? varIDConcepto,int? varIDPartidaGenerica,int? varIDPartidaEspecifica,int? varIDTipoRecurso,int? varIDExpedienteTecnico,decimal? varImporte,string varCantidadEnLetra)
		{
			Expediente item = new Expediente();
			
				item.Usuarios = varUsuarios;
			
				item.IDDepende = varIDDepende;
			
				item.IDTIpoContenido = varIDTIpoContenido;
			
				item.Descripcion = varDescripcion;
			
				item.IDActor = varIDActor;
			
				item.IDAbogadoActor = varIDAbogadoActor;
			
				item.IDDemandado = varIDDemandado;
			
				item.IDAutocaso = varIDAutocaso;
			
				item.IDTipojuicio = varIDTipojuicio;
			
				item.Causa = varCausa;
			
				item.Etapa = varEtapa;
			
				item.IDEtapa = varIDEtapa;
			
				item.Fechaconoce = varFechaconoce;
			
				item.Fechainterpone = varFechainterpone;
			
				item.Status = varStatus;
			
				item.Actualizacion = varActualizacion;
			
				item.IDUser = varIDUser;
			
				item.Tomo = varTomo;
			
				item.IDOrigenCorres = varIDOrigenCorres;
			
				item.IDStatusCorrespondencia = varIDStatusCorrespondencia;
			
				item.StatusRetornado = varStatusRetornado;
			
				item.IDDestinoCorrespondencia = varIDDestinoCorrespondencia;
			
				item.Paginas = varPaginas;
			
				item.Id = varId;
			
				item.IDDependenciaEjecutora = varIDDependenciaEjecutora;
			
				item.IDEje = varIDEje;
			
				item.IDPrioridadNacional = varIDPrioridadNacional;
			
				item.IDSubprograma = varIDSubprograma;
			
				item.IDEjercicio = varIDEjercicio;
			
				item.IDCapitulo = varIDCapitulo;
			
				item.IDConcepto = varIDConcepto;
			
				item.IDPartidaGenerica = varIDPartidaGenerica;
			
				item.IDPartidaEspecifica = varIDPartidaEspecifica;
			
				item.IDTipoRecurso = varIDTipoRecurso;
			
				item.IDExpedienteTecnico = varIDExpedienteTecnico;
			
				item.Importe = varImporte;
			
				item.CantidadEnLetra = varCantidadEnLetra;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn UsuariosColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IDDependeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTIpoContenidoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IDActorColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IDAbogadoActorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IDDemandadoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IDAutocasoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTipojuicioColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn CausaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn EtapaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IDEtapaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaconoceColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn FechainterponeColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ActualizacionColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn IDUserColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn TomoColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IDOrigenCorresColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IDStatusCorrespondenciaColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusRetornadoColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn IDDestinoCorrespondenciaColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn PaginasColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IDDependenciaEjecutoraColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn IDEjeColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn IDPrioridadNacionalColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IDSubprogramaColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn IDEjercicioColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn IDCapituloColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IDConceptoColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn IDPartidaGenericaColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn IDPartidaEspecificaColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTipoRecursoColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IDExpedienteTecnicoColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn ImporteColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadEnLetraColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
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
			 public static string IDEtapa = @"IDEtapa";
			 public static string Fechaconoce = @"fechaconoce";
			 public static string Fechainterpone = @"fechainterpone";
			 public static string Status = @"status";
			 public static string Actualizacion = @"Actualizacion";
			 public static string IDUser = @"IDUser";
			 public static string Tomo = @"Tomo";
			 public static string IDOrigenCorres = @"IDOrigenCorres";
			 public static string IDStatusCorrespondencia = @"IDStatusCorrespondencia";
			 public static string StatusRetornado = @"StatusRetornado";
			 public static string IDDestinoCorrespondencia = @"IDDestinoCorrespondencia";
			 public static string Paginas = @"Paginas";
			 public static string Id = @"ID";
			 public static string IDDependenciaEjecutora = @"IDDependenciaEjecutora";
			 public static string IDEje = @"IDEje";
			 public static string IDPrioridadNacional = @"IDPrioridadNacional";
			 public static string IDSubprograma = @"IDSubprograma";
			 public static string IDEjercicio = @"IDEjercicio";
			 public static string IDCapitulo = @"IDCapitulo";
			 public static string IDConcepto = @"IDConcepto";
			 public static string IDPartidaGenerica = @"IDPartidaGenerica";
			 public static string IDPartidaEspecifica = @"IDPartidaEspecifica";
			 public static string IDTipoRecurso = @"IDTipoRecurso";
			 public static string IDExpedienteTecnico = @"IDExpedienteTecnico";
			 public static string Importe = @"Importe";
			 public static string CantidadEnLetra = @"CantidadEnLetra";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
