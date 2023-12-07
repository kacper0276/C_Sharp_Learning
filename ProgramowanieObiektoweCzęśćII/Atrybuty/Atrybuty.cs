using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

[assembly: InternalsVisibleTo("ToDoApp")] // Nadanie atrybutu, jeśli specyficzny to przedrostek assembly
namespace ProgramowanieObiektoweCzęśćII.Atrybuty
{
    internal class Atrybuty
    {
        public Atrybuty()
        {
            Person person = new()
            {
                FirstName = "Tester",
                LastName = ""
            };
            ValidationContext context = new(person, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(person, context, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }

    // Atrybuty dodają metadane do programu(Opisujące typy i elementy)





    class Person
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
    }
}
