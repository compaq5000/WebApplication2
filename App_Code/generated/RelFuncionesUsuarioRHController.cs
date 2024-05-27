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
    /// Controller class for RelFuncionesUsuarioRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelFuncionesUsuarioRHController
    {
        // Preload our schema..
        RelFuncionesUsuarioRH thisSchemaLoad = new RelFuncionesUsuarioRH();
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
        public RelFuncionesUsuarioRHCollection FetchAll()
        {
            RelFuncionesUsuarioRHCollection coll = new RelFuncionesUsuarioRHCollection();
            Query qry = new Query(RelFuncionesUsuarioRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelFuncionesUsuarioRHCollection FetchByID(object Id)
        {
            RelFuncionesUsuarioRHCollection coll = new RelFuncionesUsuarioRHCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelFuncionesUsuarioRHCollection FetchByQuery(Query qry)
        {
            RelFuncionesUsuarioRHCollection coll = new RelFuncionesUsuarioRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelFuncionesUsuarioRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelFuncionesUsuarioRH.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,DateTime? Fecha,int? IDCategoria,int? IDUsuario,bool? Status)
	    {
		    RelFuncionesUsuarioRH item = new RelFuncionesUsuarioRH();
		    
            item.Descripcion = Descripcion;
            
            item.Fecha = Fecha;
            
            item.IDCategoria = IDCategoria;
            
            item.IDUsuario = IDUsuario;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion,DateTime? Fecha,int? IDCategoria,int? IDUsuario,bool? Status)
	    {
		    RelFuncionesUsuarioRH item = new RelFuncionesUsuarioRH();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Fecha = Fecha;
				
			item.IDCategoria = IDCategoria;
				
			item.IDUsuario = IDUsuario;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
