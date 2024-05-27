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
    /// Controller class for TranInsidenciasRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TranInsidenciasRHController
    {
        // Preload our schema..
        TranInsidenciasRH thisSchemaLoad = new TranInsidenciasRH();
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
        public TranInsidenciasRHCollection FetchAll()
        {
            TranInsidenciasRHCollection coll = new TranInsidenciasRHCollection();
            Query qry = new Query(TranInsidenciasRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranInsidenciasRHCollection FetchByID(object Id)
        {
            TranInsidenciasRHCollection coll = new TranInsidenciasRHCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranInsidenciasRHCollection FetchByQuery(Query qry)
        {
            TranInsidenciasRHCollection coll = new TranInsidenciasRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TranInsidenciasRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TranInsidenciasRH.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDUser,DateTime? Fecha,string Asunto,bool? Status,int? IDJustificar,string Salida,string Entrada,int? Idtipoinsid,bool? Autorizado)
	    {
		    TranInsidenciasRH item = new TranInsidenciasRH();
		    
            item.IDUser = IDUser;
            
            item.Fecha = Fecha;
            
            item.Asunto = Asunto;
            
            item.Status = Status;
            
            item.IDJustificar = IDJustificar;
            
            item.Salida = Salida;
            
            item.Entrada = Entrada;
            
            item.Idtipoinsid = Idtipoinsid;
            
            item.Autorizado = Autorizado;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDUser,DateTime? Fecha,string Asunto,bool? Status,int? IDJustificar,string Salida,string Entrada,int? Idtipoinsid,bool? Autorizado)
	    {
		    TranInsidenciasRH item = new TranInsidenciasRH();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDUser = IDUser;
				
			item.Fecha = Fecha;
				
			item.Asunto = Asunto;
				
			item.Status = Status;
				
			item.IDJustificar = IDJustificar;
				
			item.Salida = Salida;
				
			item.Entrada = Entrada;
				
			item.Idtipoinsid = Idtipoinsid;
				
			item.Autorizado = Autorizado;
				
	        item.Save(UserName);
	    }
    }
}
