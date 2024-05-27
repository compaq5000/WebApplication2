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
    /// Controller class for TemAbogado
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TemAbogadoController
    {
        // Preload our schema..
        TemAbogado thisSchemaLoad = new TemAbogado();
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
        public TemAbogadoCollection FetchAll()
        {
            TemAbogadoCollection coll = new TemAbogadoCollection();
            Query qry = new Query(TemAbogado.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemAbogadoCollection FetchByID(object IdAbogado)
        {
            TemAbogadoCollection coll = new TemAbogadoCollection().Where("idAbogado", IdAbogado).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemAbogadoCollection FetchByQuery(Query qry)
        {
            TemAbogadoCollection coll = new TemAbogadoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdAbogado)
        {
            return (TemAbogado.Delete(IdAbogado) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdAbogado)
        {
            return (TemAbogado.Destroy(IdAbogado) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string EXpediente,string Abogado)
	    {
		    TemAbogado item = new TemAbogado();
		    
            item.EXpediente = EXpediente;
            
            item.Abogado = Abogado;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string EXpediente,int IdAbogado,string Abogado)
	    {
		    TemAbogado item = new TemAbogado();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.EXpediente = EXpediente;
				
			item.IdAbogado = IdAbogado;
				
			item.Abogado = Abogado;
				
	        item.Save(UserName);
	    }
    }
}
