using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// esta clase se guarda el estore procedure graficar para generar una grafica
/// </summary>
public class ClassGrafica
{
    public ClassGrafica()
    {
    }
    private string _IDUUSER;
    private string _STATUSRECIBIDOS;
    private string _STATUSREVISADO;
    private string _STATUSCONTESTADO;
    private string _STATUSPORREVISAR;
    private string _NOMBREUSER;
    private string _PAG;
    private string _PRODUCTIVIDAD;


    public String PRODUCTIVIDAD
    {
        set { _PRODUCTIVIDAD = value; }
        get { return _PRODUCTIVIDAD; }
    }

    public String Pag
    {
        set { _PAG = value; }
        get { return _PAG; }
    }


    public String IdUser
    {
        set { _IDUUSER = value; }
        get { return _IDUUSER; }
    }
    public string StatusRecibidos
    {
        set { _STATUSRECIBIDOS = value;}
        get { return _STATUSRECIBIDOS; }
    }
    public string StatusRevisados
    {
        set { _STATUSREVISADO = value;}
        get { return _STATUSREVISADO;}
    }
    public string StatusContestados
    {
        set { _STATUSCONTESTADO = value;}
        get { return _STATUSCONTESTADO;}
    }
    public string StatusPorRevisar
    {
        set { _STATUSPORREVISAR = value; }
        get { return _STATUSPORREVISAR; }
    }
    public string NombreUser
    {
        set { _NOMBREUSER = value; }
        get { return _NOMBREUSER; }
    }

    public void Elemento(string Pagina,string IdUserAdd, string StatusRecibidosAdd, string StatusRevisadosAdd, string StatusContestadosAdd, string StatusPorRevisarAdd, string Productividad )
    {
        this.Pag = Pagina;
        this.IdUser = IdUserAdd;
        this.StatusRecibidos = StatusRecibidosAdd;
        this.StatusRevisados = StatusRevisadosAdd;
        this.StatusContestados = StatusContestadosAdd;
        this.StatusPorRevisar = StatusPorRevisarAdd;
        SubSonicDB.CatUsuario Nombre = SubSonicDB.CatUsuario.FetchByID(IdUserAdd);
        this.NombreUser = Nombre.Nom;
        this.PRODUCTIVIDAD = Productividad;
    }

    public string GetNombre(string IdUser)
    {
        SubSonicDB.CatUsuario Nombre = SubSonicDB.CatUsuario.FetchByID(IdUser);
        return Nombre.Nom;

    }
}