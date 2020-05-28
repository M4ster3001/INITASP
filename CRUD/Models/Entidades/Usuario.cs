using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.Entidades
{

    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Código do usuário")]

        //Inserir no banco o que está dentro do COLUMN
        [Column("id_user")]
        public int id { get; set; }
        [Display(Description = "Nome do usuário")]
        public string user_name { get; set; }
        [Display(Description = "Idade do usuário")]
        public int num_age { get; set; }
        [Display(Description = "Tipo de usuário")]
        public int flg_type { get; set; }
    }
}
