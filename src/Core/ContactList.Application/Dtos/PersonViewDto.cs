using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Dtos
{
    public class PersonViewDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "İsmi girilmelidir.")]
        [DisplayName("İsim")]
        [StringLength(20, MinimumLength = 3,
        ErrorMessage = "İsmi minimum 3 ve maksimum 20 karakterden oluşmalıdır.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Soyisim girilmelidir.")]
        [DisplayName("Soyisim")]
        [StringLength(20, MinimumLength = 3,
        ErrorMessage = "Soyisim minimum 3 ve maksimum 20 karakterden oluşmalıdır.")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "Doğum tarihi girilmelidir.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email adresi girilmelidir.")]
        [EmailAddress(ErrorMessage = "Email Addressi hatalı")]
        public string Email { get; set; }
    }
}
