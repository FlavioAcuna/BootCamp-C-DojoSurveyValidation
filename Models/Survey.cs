#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DojoSurveyModel.Models;
public class Survey
{
    [Required(ErrorMessage = "El nombre es un campo obligatorio")]
    [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "La ubicacion del dojo es un dato obligatorio")]
    public string UbicacionDojo { get; set; }
    [Required(ErrorMessage = "El Lenguaje favorito es un dato obligatorio")]
    public string FavoriteLanguage { get; set; }
    [MaybeNull]
    [MinLength(20, ErrorMessage = "El Comentario debe contener al menos 20 caracteres")]
    public string? Comment { get; set; }
}