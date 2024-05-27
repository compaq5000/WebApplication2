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
    /// Controller class for RelCatCategoria__RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelCatCategoriaRhController
    {
        // Preload our schema..
        RelCatCategoriaRh thisSchemaLoad = new RelCatCategoriaRh();
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
        public RelCatCategoriaRhCollection FetchAll()
        {
            RelCatCategoriaRhCollection coll = new RelCatCategoriaRhCollection();
            Query qry = new Query(RelCatCategoriaRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatCategoriaRhCollection FetchByID(object Id)
        {
            RelCatCategoriaRhCollection coll = new RelCatCategoriaRhCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatCategoriaRhCollection FetchByQuery(Query qry)
        {
            RelCatCategoriaRhCollection coll = new RelCatCategoriaRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelCatCategoriaRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelCatCategoriaRh.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDCategoria,bool? Status,int? IDUsuario)
	    {
		    RelCatCategoriaRh item = new RelCatCategoriaRh();
		    
            item.IDCategoria = IDCategoria;
            
            item.Status = Status;
            
            item.IDUsuario = IDUsuario;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDCategoria,bool? Status,int? IDUsuario)
	    {
		    RelCatCategoriaRh item = new RelCatCategoriaRh();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDCategoria = IDCategoria;
				
			item.Status = Status;
				
			item.IDUsuario = IDUsuario;
				
	        item.Save(UserName);
	    }
    }
}
