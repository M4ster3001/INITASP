using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models.Entidades
{

    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Código do usuário")]

        //Inserir no banco o que está dentro do COLUMN
        [Column("id_user")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Nome do usuário")]
        [Required(ErrorMessage = "Nome do usuário é obrigatorio")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,64}$", ErrorMessage = "Somente é permitido letras")]
        public string user_name { get; set; }

        [Display(Name = "Idade do usuário", Description = "A idade deve estar entre 18 e 100 anos")]
        [Range(18, 100, ErrorMessage = "Somente são permitidas idades entre 18 e 100 anos")]
        public int num_age { get; set; }

        [Display(Name = "Tipo de usuário")]
        public int flg_type { get; set; }
    }
}
