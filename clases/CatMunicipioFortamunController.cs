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
    /// Controller class for Cat_Municipio_fortamun
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatMunicipioFortamunController
    {
        // Preload our schema..
        CatMunicipioFortamun thisSchemaLoad = new CatMunicipioFortamun();
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
        public CatMunicipioFortamunCollection FetchAll()
        {
            CatMunicipioFortamunCollection coll = new CatMunicipioFortamunCollection();
            Query qry = new Query(CatMunicipioFortamun.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatMunicipioFortamunCollection FetchByID(object Id)
        {
            CatMunicipioFortamunCollection coll = new CatMunicipioFortamunCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatMunicipioFortamunCollection FetchByQuery(Query qry)
        {
            CatMunicipioFortamunCollection coll = new CatMunicipioFortamunCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatMunicipioFortamun.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatMunicipioFortamun.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatMunicipioFortamun item = new CatMunicipioFortamun();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Descripcion,bool? Status,int Id)
	    {
		    CatMunicipioFortamun item = new CatMunicipioFortamun();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
