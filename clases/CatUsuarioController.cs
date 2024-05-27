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
    /// Controller class for CatUsuarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatUsuarioController
    {
        // Preload our schema..
        CatUsuario thisSchemaLoad = new CatUsuario();
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
        public CatUsuarioCollection FetchAll()
        {
            CatUsuarioCollection coll = new CatUsuarioCollection();
            Query qry = new Query(CatUsuario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatUsuarioCollection FetchByID(object Id)
        {
            CatUsuarioCollection coll = new CatUsuarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatUsuarioCollection FetchByQuery(Query qry)
        {
            CatUsuarioCollection coll = new CatUsuarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatUsuario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatUsuario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Nom,string Paterno,string Materno,bool? Status,string Passw,string Usuario,int? IDTipoUser,string Imagen,string Extension,int? Skin,string Correo,string Noempleado,decimal? Sueldo,string Rfc,DateTime? FechaIngreso,string Calle,string Colonila,string NoCalle,string Celular,string TelCasa,string NombreContacto,string TelContacto,int? IDTipoPlaza)
	    {
		    CatUsuario item = new CatUsuario();
		    
            item.Nombre = Nombre;
            
            item.Nom = Nom;
            
            item.Paterno = Paterno;
            
            item.Materno = Materno;
            
            item.Status = Status;
            
            item.Passw = Passw;
            
            item.Usuario = Usuario;
            
            item.IDTipoUser = IDTipoUser;
            
            item.Imagen = Imagen;
            
            item.Extension = Extension;
            
            item.Skin = Skin;
            
            item.Correo = Correo;
            
            item.Noempleado = Noempleado;
            
            item.Sueldo = Sueldo;
            
            item.Rfc = Rfc;
            
            item.FechaIngreso = FechaIngreso;
            
            item.Calle = Calle;
            
            item.Colonila = Colonila;
            
            item.NoCalle = NoCalle;
            
            item.Celular = Celular;
            
            item.TelCasa = TelCasa;
            
            item.NombreContacto = NombreContacto;
            
            item.TelContacto = TelContacto;
            
            item.IDTipoPlaza = IDTipoPlaza;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Nombre,string Nom,string Paterno,string Materno,bool? Status,string Passw,string Usuario,int? IDTipoUser,string Imagen,string Extension,int? Skin,string Correo,string Noempleado,decimal? Sueldo,string Rfc,DateTime? FechaIngreso,string Calle,string Colonila,string NoCalle,string Celular,string TelCasa,string NombreContacto,string TelContacto,int? IDTipoPlaza)
	    {
		    CatUsuario item = new CatUsuario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Nombre = Nombre;
				
			item.Nom = Nom;
				
			item.Paterno = Paterno;
				
			item.Materno = Materno;
				
			item.Status = Status;
				
			item.Passw = Passw;
				
			item.Usuario = Usuario;
				
			item.IDTipoUser = IDTipoUser;
				
			item.Imagen = Imagen;
				
			item.Extension = Extension;
				
			item.Skin = Skin;
				
			item.Correo = Correo;
				
			item.Noempleado = Noempleado;
				
			item.Sueldo = Sueldo;
				
			item.Rfc = Rfc;
				
			item.FechaIngreso = FechaIngreso;
				
			item.Calle = Calle;
				
			item.Colonila = Colonila;
				
			item.NoCalle = NoCalle;
				
			item.Celular = Celular;
				
			item.TelCasa = TelCasa;
				
			item.NombreContacto = NombreContacto;
				
			item.TelContacto = TelContacto;
				
			item.IDTipoPlaza = IDTipoPlaza;
				
	        item.Save(UserName);
	    }
    }
}
