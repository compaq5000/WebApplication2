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
    /// Controller class for CatPartidaGenerica_Invenatarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatPartidaGenericaInvenatarioController
    {
        // Preload our schema..
        CatPartidaGenericaInvenatario thisSchemaLoad = new CatPartidaGenericaInvenatario();
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
        public CatPartidaGenericaInvenatarioCollection FetchAll()
        {
            CatPartidaGenericaInvenatarioCollection coll = new CatPartidaGenericaInvenatarioCollection();
            Query qry = new Query(CatPartidaGenericaInvenatario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPartidaGenericaInvenatarioCollection FetchByID(object Id)
        {
            CatPartidaGenericaInvenatarioCollection coll = new CatPartidaGenericaInvenatarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPartidaGenericaInvenatarioCollection FetchByQuery(Query qry)
        {
            CatPartidaGenericaInvenatarioCollection coll = new CatPartidaGenericaInvenatarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatPartidaGenericaInvenatario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatPartidaGenericaInvenatario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Valor,string Descripcion,bool? Status,int? IDConcepto)
	    {
		    CatPartidaGenericaInvenatario item = new CatPartidaGenericaInvenatario();
		    
            item.Valor = Valor;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.IDConcepto = IDConcepto;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Valor,string Descripcion,bool? Status,int Id,int? IDConcepto)
	    {
		    CatPartidaGenericaInvenatario item = new CatPartidaGenericaInvenatario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Valor = Valor;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
			item.IDConcepto = IDConcepto;
				
	        item.Save(UserName);
	    }
    }
}
