using System;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDeCarros.Models
{
    public class ClienteViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatorio.")]
        [Display(Name = "Nome e sobrenome")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Endereço residencial")]
        public string Endereco { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string CarteiraDeMotorista { get; set; }
    }
}
