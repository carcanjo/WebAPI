using System;
using System.ComponentModel.DataAnnotations;
using UserServices.Models.Enuns;

namespace UserServices.Models
{
    public class Users
    {
        #region Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome do usuário requer o minimo {1} e o maximo {0}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome do usuário requer o minimo {1} e o maximo {0}")]
        public string Surname { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="{0} formato inválido!")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public Education Education { get; set; }

        #endregion

        #region Contructors
        public Users()
        {

        }

        public Users(int id, string name, string surname, string email, DateTime birthDate, Education education)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            Education = education;
        }
        #endregion
    }
}
