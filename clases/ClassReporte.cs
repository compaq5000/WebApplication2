using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ClassReporte
/// </summary>
public class ClassReporte
{
    public ClassReporte()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    private string _ID;
    private string _DESCRIPCION;
    //private string _IDEXPEDIENTE;
    private string _STATUS;
    public String ID
    {
        set { _ID = value; }
        get { return _ID; }
    }
    public String DESCRIPCION
    {
        set { _DESCRIPCION = value; }
        get { return _DESCRIPCION; }
    }
    //public String IDEXPEDIENTE
    //{
    //    set { _IDEXPEDIENTE = value; }
    //    get { return _IDEXPEDIENTE; }
    //}
    public String STATUS
    {
        set { _STATUS = value; }
        get { return _STATUS; }
    }

    public void AgregarElemento(string Id, string Descripcion, string Status)
    {
        this.ID = Id;
        this.DESCRIPCION = Descripcion;
       // this.IDEXPEDIENTE = IdExpediente;
        this.STATUS = Status;

        //this.StatusContestados = StatusContestadosAdd;
        //this.StatusPorRevisar = StatusPorRevisarAdd;
        //SubsonicDB.CatUsuario Nombre = SubsonicDB.CatUsuario.FetchByID(IdUserAdd);
        //this.NombreUser = Nombre.Nom;
        //this.PRODUCTIVIDAD = Productividad;
    }
    public void ChangeStatus(string Status)
    {
        this.STATUS = Status;
    
    }

}