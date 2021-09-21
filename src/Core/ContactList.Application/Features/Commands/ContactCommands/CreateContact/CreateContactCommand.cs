using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.CreateContact
{
    public class CreateContactCommand:IRequest<bool>
    {
        [Required]
        public Guid PersonId { get; set; }

        [Required(ErrorMessage = "Kontak ismi girilmelidir.")]
        [DisplayName("Kontak İsmi")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Kontak ismi minimum 3 ve maksimum 50 karakterden oluşmalıdır.")]
        [DataType(DataType.Text)]
        public string ContactName { get; set; }



        [Required(ErrorMessage = "Telefon numarası girilmelidir.")]
        [DisplayName("Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Hatalı telefon numarası.")]
        public string PhoneNumber { get; set; }
    }
}
