//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudRiosoft.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        public int CLI_COD { get; set; }
        public string NOME { get; set; }
        public string CPF { get; set; }
        public System.DateTime DATANASCIMENTO { get; set; }
        public string GENERO { get; set; }
    
        public virtual TELEFONE TELEFONE { get; set; }
    }
}
