using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcCine.Models
{
    public class MovieGenreViewModel
    {
        // Lista de películas
        public List<Movie>? Movies { get; set; }
        
        // Contenedor de la lista de géneros
        public SelectList? Genres { get; set; }

        // Género seleccionado
        public string? MovieGenre { get; set; }

        // Texto introducido en el cuadro de búsqueda
        public string? SearchString { get; set; }
    }
}
