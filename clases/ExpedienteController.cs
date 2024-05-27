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
    /// Controller class for Expedientes
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ExpedienteController
    {
        // Preload our schema..
        Expediente thisSchemaLoad = new Expediente();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ExpedienteCollection FetchAll()
        {
            ExpedienteCollection coll = new ExpedienteCollection();
            Query qry = new Query(Expediente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ExpedienteCollection FetchByID(object Id)
        {
            ExpedienteCollection coll = new ExpedienteCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ExpedienteCollection FetchByQuery(Query qry)
        {
            ExpedienteCollection coll = new ExpedienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (Expediente.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (Expediente.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Usuarios,int? IDDepende,int? IDTIpoContenido,string Descripcion,int? IDActor,int? IDAbogadoActor,int? IDDemandado,int? IDAutocaso,int? IDTipojuicio,string Causa,string Etapa,int? IDEtapa,DateTime? Fechaconoce,string Fechainterpone,bool? Status,DateTime? Actualizacion,int? IDUser,string Tomo,int? IDOrigenCorres,int? IDStatusCorrespondencia,bool? StatusRetornado,int? IDDestinoCorrespondencia,string Paginas,int? IDDependenciaEjecutora,int? IDEje,int? IDPrioridadNacional,int? IDSubprograma,int? IDEjercicio,int? IDCapitulo,int? IDConcepto,int? IDPartidaGenerica,int? IDPartidaEspecifica,int? IDTipoRecurso,int? IDExpedienteTecnico,decimal? Importe,string CantidadEnLetra)
	    {
		    Expediente item = new Expediente();
		    
            item.Usuarios = Usuarios;
            
            item.IDDepende = IDDepende;
            
            item.IDTIpoContenido = IDTIpoContenido;
            
            item.Descripcion = Descripcion;
            
            item.IDActor = IDActor;
            
            item.IDAbogadoActor = IDAbogadoActor;
            
            item.IDDemandado = IDDemandado;
            
            item.IDAutocaso = IDAutocaso;
            
            item.IDTipojuicio = IDTipojuicio;
            
            item.Causa = Causa;
            
            item.Etapa = Etapa;
            
            item.IDEtapa = IDEtapa;
            
            item.Fechaconoce = Fechaconoce;
            
            item.Fechainterpone = Fechainterpone;
            
            item.Status = Status;
            
            item.Actualizacion = Actualizacion;
            
            item.IDUser = IDUser;
            
            item.Tomo = Tomo;
            
            item.IDOrigenCorres = IDOrigenCorres;
            
            item.IDStatusCorrespondencia = IDStatusCorrespondencia;
            
            item.StatusRetornado = StatusRetornado;
            
            item.IDDestinoCorrespondencia = IDDestinoCorrespondencia;
            
            item.Paginas = Paginas;
            
            item.IDDependenciaEjecutora = IDDependenciaEjecutora;
            
            item.IDEje = IDEje;
            
            item.IDPrioridadNacional = IDPrioridadNacional;
            
            item.IDSubprograma = IDSubprograma;
            
            item.IDEjercicio = IDEjercicio;
            
            item.IDCapitulo = IDCapitulo;
            
            item.IDConcepto = IDConcepto;
            
            item.IDPartidaGenerica = IDPartidaGenerica;
            
            item.IDPartidaEspecifica = IDPartidaEspecifica;
            
            item.IDTipoRecurso = IDTipoRecurso;
            
            item.IDExpedienteTecnico = IDExpedienteTecnico;
            
            item.Importe = Importe;
            
            item.CantidadEnLetra = CantidadEnLetra;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Usuarios,int? IDDepende,int? IDTIpoContenido,string Descripcion,int? IDActor,int? IDAbogadoActor,int? IDDemandado,int? IDAutocaso,int? IDTipojuicio,string Causa,string Etapa,int? IDEtapa,DateTime? Fechaconoce,string Fechainterpone,bool? Status,DateTime? Actualizacion,int? IDUser,string Tomo,int? IDOrigenCorres,int? IDStatusCorrespondencia,bool? StatusRetornado,int? IDDestinoCorrespondencia,string Paginas,int Id,int? IDDependenciaEjecutora,int? IDEje,int? IDPrioridadNacional,int? IDSubprograma,int? IDEjercicio,int? IDCapitulo,int? IDConcepto,int? IDPartidaGenerica,int? IDPartidaEspecifica,int? IDTipoRecurso,int? IDExpedienteTecnico,decimal? Importe,string CantidadEnLetra)
	    {
		    Expediente item = new Expediente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Usuarios = Usuarios;
				
			item.IDDepende = IDDepende;
				
			item.IDTIpoContenido = IDTIpoContenido;
				
			item.Descripcion = Descripcion;
				
			item.IDActor = IDActor;
				
			item.IDAbogadoActor = IDAbogadoActor;
				
			item.IDDemandado = IDDemandado;
				
			item.IDAutocaso = IDAutocaso;
				
			item.IDTipojuicio = IDTipojuicio;
				
			item.Causa = Causa;
				
			item.Etapa = Etapa;
				
			item.IDEtapa = IDEtapa;
				
			item.Fechaconoce = Fechaconoce;
				
			item.Fechainterpone = Fechainterpone;
				
			item.Status = Status;
				
			item.Actualizacion = Actualizacion;
				
			item.IDUser = IDUser;
				
			item.Tomo = Tomo;
				
			item.IDOrigenCorres = IDOrigenCorres;
				
			item.IDStatusCorrespondencia = IDStatusCorrespondencia;
				
			item.StatusRetornado = StatusRetornado;
				
			item.IDDestinoCorrespondencia = IDDestinoCorrespondencia;
				
			item.Paginas = Paginas;
				
			item.Id = Id;
				
			item.IDDependenciaEjecutora = IDDependenciaEjecutora;
				
			item.IDEje = IDEje;
				
			item.IDPrioridadNacional = IDPrioridadNacional;
				
			item.IDSubprograma = IDSubprograma;
				
			item.IDEjercicio = IDEjercicio;
				
			item.IDCapitulo = IDCapitulo;
				
			item.IDConcepto = IDConcepto;
				
			item.IDPartidaGenerica = IDPartidaGenerica;
				
			item.IDPartidaEspecifica = IDPartidaEspecifica;
				
			item.IDTipoRecurso = IDTipoRecurso;
				
			item.IDExpedienteTecnico = IDExpedienteTecnico;
				
			item.Importe = Importe;
				
			item.CantidadEnLetra = CantidadEnLetra;
				
	        item.Save(UserName);
	    }
    }
}
