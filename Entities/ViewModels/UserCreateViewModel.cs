using System.ComponentModel.DataAnnotations;

namespace AuthGuardExample.Entities.Models
{
    public class UserCreateViewModel
    {
        public UserCreateViewModel() { }
        public string Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        public string NomeCompleto { get; set; }

        [StringLength(11, ErrorMessage = "O campo {0} deve ter {1} dígitos")]
        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        public string Celular { get; set; }

        [StringLength(11, ErrorMessage = "O campo {0} deve ter {1} dígitos")]
        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        public string Email { get; set; }

        [MaxLength(16, ErrorMessage = "O tamanho máximo do campo {0} é de  {1} dígitos")]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo {0} é de  {1} dígitos")]
        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        public string Senha { get; set; }

        [MaxLength(16, ErrorMessage = "O tamanho máximo do campo {0} é de  {1} dígitos")]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo {0} é de  {1} dígitos")]
        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não coincidem")]
        public string ConfSenha { get; set; }
    }
}