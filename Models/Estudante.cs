using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMVC_CRUD.Models
{
    public class Estudante
    {
        [Key]
        public int Id { get; set; }
        public string NomeEstudante { get; set; }
        public string CpfEstudante { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NomePai { get; set; }
        public string NomeMae {  get; set; }

    }
}