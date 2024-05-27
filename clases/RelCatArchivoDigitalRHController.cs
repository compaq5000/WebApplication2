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
    /// Controller class for RelCatArchivoDigitalRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelCatArchivoDigitalRHController
    {
        // Preload our schema..
        RelCatArchivoDigitalRH thisSchemaLoad = new RelCatArchivoDigitalRH();
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
        public RelCatArchivoDigitalRHCollection FetchAll()
        {
            RelCatArchivoDigitalRHCollection coll = new RelCatArchivoDigitalRHCollection();
            Query qry = new Query(RelCatArchivoDigitalRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatArchivoDigitalRHCollection FetchByID(object Id)
        {
            RelCatArchivoDigitalRHCollection coll = new RelCatArchivoDigitalRHCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatArchivoDigitalRHCollection FetchByQuery(Query qry)
        {
            RelCatArchivoDigitalRHCollection coll = new RelCatArchivoDigitalRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelCatArchivoDigitalRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelCatArchivoDigitalRH.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDArcivodigital,int? IDUasuario,bool? Status,string Extension,DateTime? FechaCarga,string Detalle,int? CargadoPor,string NombreArchivo)
	    {
		    RelCatArchivoDigitalRH item = new RelCatArchivoDigitalRH();
		    
            item.IDArcivodigital = IDArcivodigital;
            
            item.IDUasuario = IDUasuario;
            
            item.Status = Status;
            
            item.Extension = Extension;
            
            item.FechaCarga = FechaCarga;
            
            item.Detalle = Detalle;
            
            item.CargadoPor = CargadoPor;
            
            item.NombreArchivo = NombreArchivo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDArcivodigital,int? IDUasuario,bool? Status,string Extension,DateTime? FechaCarga,string Detalle,int? CargadoPor,string NombreArchivo)
	    {
		    RelCatArchivoDigitalRH item = new RelCatArchivoDigitalRH();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDArcivodigital = IDArcivodigital;
				
			item.IDUasuario = IDUasuario;
				
			item.Status = Status;
				
			item.Extension = Extension;
				
			item.FechaCarga = FechaCarga;
				
			item.Detalle = Detalle;
				
			item.CargadoPor = CargadoPor;
				
			item.NombreArchivo = NombreArchivo;
				
	        item.Save(UserName);
	    }
    }
}
