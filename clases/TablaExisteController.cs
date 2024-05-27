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
    /// Controller class for TablaExiste
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TablaExisteController
    {
        // Preload our schema..
        TablaExiste thisSchemaLoad = new TablaExiste();
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
        public TablaExisteCollection FetchAll()
        {
            TablaExisteCollection coll = new TablaExisteCollection();
            Query qry = new Query(TablaExiste.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TablaExisteCollection FetchByID(object Id)
        {
            TablaExisteCollection coll = new TablaExisteCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TablaExisteCollection FetchByQuery(Query qry)
        {
            TablaExisteCollection coll = new TablaExisteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TablaExiste.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TablaExiste.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Folio,string Mpio)
	    {
		    TablaExiste item = new TablaExiste();
		    
            item.Folio = Folio;
            
            item.Mpio = Mpio;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Folio,string Mpio,int Id)
	    {
		    TablaExiste item = new TablaExiste();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Folio = Folio;
				
			item.Mpio = Mpio;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
