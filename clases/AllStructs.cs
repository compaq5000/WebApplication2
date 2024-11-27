using SubSonic;
namespace SubSonicDB
{
    #region Tables Struct
    public partial struct Tables
    {

        public static string Anexo = @"Anexos";

        public static string ArchivoCorrespondencium = @"ArchivoCorrespondencia";

        public static string CatMunicipioFortamun = @"Cat_Municipio_fortamun";

        public static string CatTipoContactoFortamun = @"Cat_TipoContacto_fortamun";

        public static string CatAbogadoActor = @"CatAbogadoActor";

        public static string CatAcceso = @"CatAcceso";

        public static string CatActor = @"CatActor";

        public static string CatAdscripcionRh = @"CatAdscripcion_RH";

        public static string CatAnoVacacionesRh = @"CatAnoVacaciones_RH";

        public static string CatArchivoDigitalRh = @"CatArchivoDigital_RH";

        public static string CatAutocaso = @"CatAutocaso";

        public static string CatCarpetum = @"CatCarpeta";

        public static string CatCategoriaRh = @"CatCategoria_RH";

        public static string CatDemandado = @"CatDemandado";

        public static string CatDestinoCorrespondencium = @"CatDestinoCorrespondencia";

        public static string CatEstatusCorrespondencium = @"CatEstatusCorrespondencia";

        public static string CatJefeAdscripcionRH = @"CatJefeAdscripcionRH";

        public static string CatOrigenCorrespondencium = @"CatOrigenCorrespondencia";

        public static string CatPeriodoVAcaionesRh = @"CatPeriodoVAcaiones_RH";

        public static string CatRHJustificar = @"CatRHJustificar";

        public static string CatRHTipoInsidencium = @"CatRHTipoInsidencia";

        public static string CatStatusMinutum = @"CatStatusMinuta";

        public static string CatStatusTitular = @"CatStatusTitular";

        public static string CatTipoArchivoInventario = @"CatTipoArchivo__Inventarios";

        public static string CatTipoContenido = @"CatTipoContenido";

        public static string CatTipoExpediente = @"CatTipoExpediente";

        public static string CattipoJuicio = @"CattipoJuicio";

        public static string CatTipoPermisoRH = @"CatTipoPermisoRH";

        public static string CatTipoPlazaRh = @"CatTipoPlaza_RH";

        public static string CatTipoUser = @"CatTipoUser";

        public static string CatTipoUserRh = @"CatTipoUser_RH";

        public static string CatTomo = @"CatTomos";

        public static string CatUsuario = @"CatUsuarios";

        public static string CorresCatTipoArchivo = @"CorresCatTipoArchivo";

        public static string Expediente = @"Expedientes";

        public static string HistirlaExpediente = @"HistirlaExpediente";

        public static string Historialnavegacion = @"Historialnavegacion";

        public static string Imprimirinsidencia = @"imprimirinsidencias";

        public static string RelAcumulado = @"RelAcumulado";

        public static string RelCatAdscripcion = @"RelCatAdscripcion";

        public static string RelCatArchivoDigitalRH = @"RelCatArchivoDigitalRH";

        public static string RelCatCategoriaRh = @"RelCatCategoria__RH";

        public static string RelCatTipoplazaRh = @"RelCatTipoplaza_RH";

        public static string RelEtapasDeExpediente = @"RelEtapasDeExpediente";

        public static string RelExpedienteActor = @"relExpedienteActor";

        public static string RelFuncionesUsuarioRH = @"RelFuncionesUsuarioRH";

        public static string RelTipoPermisoRH = @"RelTipoPermisoRH";

        public static string SoporteCatServicio = @"Soporte_Cat_Servicio";

        public static string SoporteTranServicio = @"Soporte_Tran_servicio";

        public static string TablaExiste = @"TablaExiste";

        public static string TableBitacora = @"TableBitacora";

        public static string TableTipoOperacion = @"TableTipoOperacion";

        public static string TemAbogado = @"TemAbogado";

        public static string TemAutoridad = @"TemAutoridad";

        public static string TemDemandado = @"TemDemandado";

        public static string TempActore = @"TempActores";

        public static string TempExpediente = @"TempExpedientes";

        public static string TemTipojuicio = @"TemTipojuicio";

        public static string TitularesRH = @"TitularesRH";

        public static string TranPermiso = @"TRAN__PERMISOS";

        public static string TranContactoFortamun = @"Tran_Contacto_fortamun";

        public static string TranInsidenciasRH = @"TranInsidenciasRH";

        public static string TranMinutum = @"TranMinuta";

        public static string TranTitularesRH = @"TranTitularesRH";

    }
    #endregion
    #region Schemas
    public partial class Schemas
    {

        public static TableSchema.Table Anexo
        {
            get { return DataService.GetSchema("Anexos", "Default"); }
        }

        public static TableSchema.Table ArchivoCorrespondencium
        {
            get { return DataService.GetSchema("ArchivoCorrespondencia", "Default"); }
        }

        public static TableSchema.Table CatMunicipioFortamun
        {
            get { return DataService.GetSchema("Cat_Municipio_fortamun", "Default"); }
        }

        public static TableSchema.Table CatTipoContactoFortamun
        {
            get { return DataService.GetSchema("Cat_TipoContacto_fortamun", "Default"); }
        }

        public static TableSchema.Table CatAbogadoActor
        {
            get { return DataService.GetSchema("CatAbogadoActor", "Default"); }
        }

        public static TableSchema.Table CatAcceso
        {
            get { return DataService.GetSchema("CatAcceso", "Default"); }
        }

        public static TableSchema.Table CatActor
        {
            get { return DataService.GetSchema("CatActor", "Default"); }
        }

        public static TableSchema.Table CatAdscripcionRh
        {
            get { return DataService.GetSchema("CatAdscripcion_RH", "Default"); }
        }

        public static TableSchema.Table CatAnoVacacionesRh
        {
            get { return DataService.GetSchema("CatAnoVacaciones_RH", "Default"); }
        }

        public static TableSchema.Table CatArchivoDigitalRh
        {
            get { return DataService.GetSchema("CatArchivoDigital_RH", "Default"); }
        }

        public static TableSchema.Table CatAutocaso
        {
            get { return DataService.GetSchema("CatAutocaso", "Default"); }
        }

        public static TableSchema.Table CatCarpetum
        {
            get { return DataService.GetSchema("CatCarpeta", "Default"); }
        }

        public static TableSchema.Table CatCategoriaRh
        {
            get { return DataService.GetSchema("CatCategoria_RH", "Default"); }
        }

        public static TableSchema.Table CatDemandado
        {
            get { return DataService.GetSchema("CatDemandado", "Default"); }
        }

        public static TableSchema.Table CatDestinoCorrespondencium
        {
            get { return DataService.GetSchema("CatDestinoCorrespondencia", "Default"); }
        }

        public static TableSchema.Table CatEstatusCorrespondencium
        {
            get { return DataService.GetSchema("CatEstatusCorrespondencia", "Default"); }
        }

        public static TableSchema.Table CatJefeAdscripcionRH
        {
            get { return DataService.GetSchema("CatJefeAdscripcionRH", "Default"); }
        }

        public static TableSchema.Table CatOrigenCorrespondencium
        {
            get { return DataService.GetSchema("CatOrigenCorrespondencia", "Default"); }
        }

        public static TableSchema.Table CatPeriodoVAcaionesRh
        {
            get { return DataService.GetSchema("CatPeriodoVAcaiones_RH", "Default"); }
        }

        public static TableSchema.Table CatRHJustificar
        {
            get { return DataService.GetSchema("CatRHJustificar", "Default"); }
        }

        public static TableSchema.Table CatRHTipoInsidencium
        {
            get { return DataService.GetSchema("CatRHTipoInsidencia", "Default"); }
        }

        public static TableSchema.Table CatStatusMinutum
        {
            get { return DataService.GetSchema("CatStatusMinuta", "Default"); }
        }

        public static TableSchema.Table CatStatusTitular
        {
            get { return DataService.GetSchema("CatStatusTitular", "Default"); }
        }

        public static TableSchema.Table CatTipoArchivoInventario
        {
            get { return DataService.GetSchema("CatTipoArchivo__Inventarios", "Default"); }
        }

        public static TableSchema.Table CatTipoContenido
        {
            get { return DataService.GetSchema("CatTipoContenido", "Default"); }
        }

        public static TableSchema.Table CatTipoExpediente
        {
            get { return DataService.GetSchema("CatTipoExpediente", "Default"); }
        }

        public static TableSchema.Table CattipoJuicio
        {
            get { return DataService.GetSchema("CattipoJuicio", "Default"); }
        }

        public static TableSchema.Table CatTipoPermisoRH
        {
            get { return DataService.GetSchema("CatTipoPermisoRH", "Default"); }
        }

        public static TableSchema.Table CatTipoPlazaRh
        {
            get { return DataService.GetSchema("CatTipoPlaza_RH", "Default"); }
        }

        public static TableSchema.Table CatTipoUser
        {
            get { return DataService.GetSchema("CatTipoUser", "Default"); }
        }

        public static TableSchema.Table CatTipoUserRh
        {
            get { return DataService.GetSchema("CatTipoUser_RH", "Default"); }
        }

        public static TableSchema.Table CatTomo
        {
            get { return DataService.GetSchema("CatTomos", "Default"); }
        }

        public static TableSchema.Table CatUsuario
        {
            get { return DataService.GetSchema("CatUsuarios", "Default"); }
        }

        public static TableSchema.Table CorresCatTipoArchivo
        {
            get { return DataService.GetSchema("CorresCatTipoArchivo", "Default"); }
        }

        public static TableSchema.Table Expediente
        {
            get { return DataService.GetSchema("Expedientes", "Default"); }
        }

        public static TableSchema.Table HistirlaExpediente
        {
            get { return DataService.GetSchema("HistirlaExpediente", "Default"); }
        }

        public static TableSchema.Table Historialnavegacion
        {
            get { return DataService.GetSchema("Historialnavegacion", "Default"); }
        }

        public static TableSchema.Table Imprimirinsidencia
        {
            get { return DataService.GetSchema("imprimirinsidencias", "Default"); }
        }

        public static TableSchema.Table RelAcumulado
        {
            get { return DataService.GetSchema("RelAcumulado", "Default"); }
        }

        public static TableSchema.Table RelCatAdscripcion
        {
            get { return DataService.GetSchema("RelCatAdscripcion", "Default"); }
        }

        public static TableSchema.Table RelCatArchivoDigitalRH
        {
            get { return DataService.GetSchema("RelCatArchivoDigitalRH", "Default"); }
        }

        public static TableSchema.Table RelCatCategoriaRh
        {
            get { return DataService.GetSchema("RelCatCategoria__RH", "Default"); }
        }

        public static TableSchema.Table RelCatTipoplazaRh
        {
            get { return DataService.GetSchema("RelCatTipoplaza_RH", "Default"); }
        }

        public static TableSchema.Table RelEtapasDeExpediente
        {
            get { return DataService.GetSchema("RelEtapasDeExpediente", "Default"); }
        }

        public static TableSchema.Table RelExpedienteActor
        {
            get { return DataService.GetSchema("relExpedienteActor", "Default"); }
        }

        public static TableSchema.Table RelFuncionesUsuarioRH
        {
            get { return DataService.GetSchema("RelFuncionesUsuarioRH", "Default"); }
        }

        public static TableSchema.Table RelTipoPermisoRH
        {
            get { return DataService.GetSchema("RelTipoPermisoRH", "Default"); }
        }

        public static TableSchema.Table SoporteCatServicio
        {
            get { return DataService.GetSchema("Soporte_Cat_Servicio", "Default"); }
        }

        public static TableSchema.Table SoporteTranServicio
        {
            get { return DataService.GetSchema("Soporte_Tran_servicio", "Default"); }
        }

        public static TableSchema.Table TablaExiste
        {
            get { return DataService.GetSchema("TablaExiste", "Default"); }
        }

        public static TableSchema.Table TableBitacora
        {
            get { return DataService.GetSchema("TableBitacora", "Default"); }
        }

        public static TableSchema.Table TableTipoOperacion
        {
            get { return DataService.GetSchema("TableTipoOperacion", "Default"); }
        }

        public static TableSchema.Table TemAbogado
        {
            get { return DataService.GetSchema("TemAbogado", "Default"); }
        }

        public static TableSchema.Table TemAutoridad
        {
            get { return DataService.GetSchema("TemAutoridad", "Default"); }
        }

        public static TableSchema.Table TemDemandado
        {
            get { return DataService.GetSchema("TemDemandado", "Default"); }
        }

        public static TableSchema.Table TempActore
        {
            get { return DataService.GetSchema("TempActores", "Default"); }
        }

        public static TableSchema.Table TempExpediente
        {
            get { return DataService.GetSchema("TempExpedientes", "Default"); }
        }

        public static TableSchema.Table TemTipojuicio
        {
            get { return DataService.GetSchema("TemTipojuicio", "Default"); }
        }

        public static TableSchema.Table TitularesRH
        {
            get { return DataService.GetSchema("TitularesRH", "Default"); }
        }

        public static TableSchema.Table TranPermiso
        {
            get { return DataService.GetSchema("TRAN__PERMISOS", "Default"); }
        }

        public static TableSchema.Table TranContactoFortamun
        {
            get { return DataService.GetSchema("Tran_Contacto_fortamun", "Default"); }
        }

        public static TableSchema.Table TranInsidenciasRH
        {
            get { return DataService.GetSchema("TranInsidenciasRH", "Default"); }
        }

        public static TableSchema.Table TranMinutum
        {
            get { return DataService.GetSchema("TranMinuta", "Default"); }
        }

        public static TableSchema.Table TranTitularesRH
        {
            get { return DataService.GetSchema("TranTitularesRH", "Default"); }
        }


    }
    #endregion
    #region View Struct
    public partial struct Views
    {

        public static string Arbolado = @"arbolado";

        public static string ArboladoGrid = @"ArboladoGrid";

        public static string ArboladoGridCorrespondencium = @"ArboladoGridCorrespondencia";

        public static string ViewActualizando = @"View_actualizando";

        public static string ViewBitacoraActividade = @"View_BitacoraActividades";

        public static string ViewConsultaexiste = @"View_consultaexiste";

        public static string ViewContestacionCorrespon = @"View_ContestacionCorrespon";

        public static string ViewCorrespondenciaAbrir = @"View_CorrespondenciaAbrir";

        public static string ViewEnlacesFortamun = @"View_EnlacesFortamun";

        public static string ViewExpedienteExiste = @"View_ExpedienteExiste";

        public static string ViewGraficar = @"View_Graficar";

        public static string ViewHistorialArchivoCorrespondencium = @"View_HistorialArchivoCorrespondencia";

        public static string ViewImprimirPase = @"View_ImprimirPases";

        public static string ViewReporteInventarioExpediente = @"View_ReporteInventarioExpediente";

        public static string ViewRetornaCorrespondencium = @"View_RetornaCorrespondencia";

        public static string ViewRHDetalleUsuario = @"View_RHDetalleUsuarios";

        public static string ViewRHJustificante = @"View_RHJustificantes";

        public static string ViewSoporteTecnico = @"View_SoporteTecnico";

        public static string ViewUserActualiza = @"View_UserActualiza";

        public static string ViewUserCorrespondencium = @"View_UserCorrespondencia";

        public static string ViewVacacionesRh = @"View_Vacaciones_RH";

        public static string ViewArchivoDigitalRH = @"ViewArchivoDigitalRH";

        public static string ViewBitacora = @"ViewBitacora";

        public static string ViewGridExpediente = @"ViewGridExpedientes";

        public static string ViewHistorialExpediente = @"ViewHistorialExpediente";

    }
    #endregion

    #region Query Factories
    public static partial class DB
    {
        public static DataProvider _provider = DataService.Providers["Default"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository
        {
            get
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository;
            }
            set { _repository = value; }
        }

        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
        {
            return Repository.SelectAllColumnsFrom<T>();

        }
        public static Select Select()
        {
            return Repository.Select();
        }

        public static Select Select(params string[] columns)
        {
            return Repository.Select(columns);
        }

        public static Select Select(params Aggregate[] aggregates)
        {
            return Repository.Select(aggregates);
        }

        public static Update Update<T>() where T : RecordBase<T>, new()
        {
            return Repository.Update<T>();
        }


        public static Insert Insert()
        {
            return Repository.Insert();
        }

        public static Delete Delete()
        {

            return Repository.Delete();
        }

        public static InlineQuery Query()
        {

            return Repository.Query();
        }


    }
    #endregion

}
#region Databases
public partial struct Databases
{

    public static string Default = @"Default";

}
#endregion