//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public int CodEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Perfil { get; set; }
        public string RequisitosGenerales { get; set; }
        public string CronogramaConvocatoria { get; set; }
        public string Beneficios { get; set; }
        public Nullable<System.DateTime> fechaLimitePostulacion { get; set; }
        public Nullable<int> CodCoordinador { get; set; }
    
        public virtual CoordinadorEPP CoordinadorEPP { get; set; }
    }
}
