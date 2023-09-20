using System.ComponentModel.DataAnnotations;

namespace WebApi_Autores.Helper
{
    public class TituloLibroValidationAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                if ( char.IsUpper(value.ToString()[0] ) )
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("El Titulo del libro no empieza con mayuscula.");
                }

            }
            return new ValidationResult("El Titulo del libro debe empezar con mayuscula.");
        }

    }
}
