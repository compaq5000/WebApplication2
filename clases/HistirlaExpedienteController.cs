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
    /// Controller class for HistirlaExpediente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class HistirlaExpedienteController
    {
        // Preload our schema..
        HistirlaExpediente thisSchemaLoad = new HistirlaExpediente();
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
        public HistirlaExpedienteCollection FetchAll()
        {
            HistirlaExpedienteCollection coll = new HistirlaExpedienteCollection();
            Query qry = new Query(HistirlaExpediente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HistirlaExpedienteCollection FetchByID(object Id)
        {
            HistirlaExpedienteCollection coll = new HistirlaExpedienteCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public HistirlaExpedienteCollection FetchByQuery(Query qry)
        {
            HistirlaExpedienteCollection coll = new HistirlaExpedienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (HistirlaExpediente.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (HistirlaExpediente.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IDExpediente,int? IDUsuario,DateTime? Actualizado,bool? Status,string Detalle,int? IDEtapa)
	    {
		    HistirlaExpediente item = new HistirlaExpediente();
		    
            item.IDExpediente = IDExpediente;
            
            item.IDUsuario = IDUsuario;
            
            item.Actualizado = Actualizado;
            
            item.Status = Status;
            
            item.Detalle = Detalle;
            
            item.IDEtapa = IDEtapa;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int IDExpediente,int? IDUsuario,DateTime? Actualizado,bool? Status,string Detalle,int? IDEtapa)
	    {
		    HistirlaExpediente item = new HistirlaExpediente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDExpediente = IDExpediente;
				
			item.IDUsuario = IDUsuario;
				
			item.Actualizado = Actualizado;
				
			item.Status = Status;
				
			item.Detalle = Detalle;
				
			item.IDEtapa = IDEtapa;
				
	        item.Save(UserName);
	    }
    }
}
