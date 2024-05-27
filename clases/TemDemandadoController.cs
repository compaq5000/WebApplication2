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
    /// Controller class for TemDemandado
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TemDemandadoController
    {
        // Preload our schema..
        TemDemandado thisSchemaLoad = new TemDemandado();
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
        public TemDemandadoCollection FetchAll()
        {
            TemDemandadoCollection coll = new TemDemandadoCollection();
            Query qry = new Query(TemDemandado.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemDemandadoCollection FetchByID(object Iddemandado)
        {
            TemDemandadoCollection coll = new TemDemandadoCollection().Where("IDDEMANDADO", Iddemandado).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemDemandadoCollection FetchByQuery(Query qry)
        {
            TemDemandadoCollection coll = new TemDemandadoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Iddemandado)
        {
            return (TemDemandado.Delete(Iddemandado) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Iddemandado)
        {
            return (TemDemandado.Destroy(Iddemandado) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Expediente,string Demandado)
	    {
		    TemDemandado item = new TemDemandado();
		    
            item.Expediente = Expediente;
            
            item.Demandado = Demandado;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Expediente,int Iddemandado,string Demandado)
	    {
		    TemDemandado item = new TemDemandado();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Expediente = Expediente;
				
			item.Iddemandado = Iddemandado;
				
			item.Demandado = Demandado;
				
	        item.Save(UserName);
	    }
    }
}
