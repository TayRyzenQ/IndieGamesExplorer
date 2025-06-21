using IndieGames.Models;
using System.Collections.Generic;

namespace IndieGames.Data
{
    public class HollowNightData
    {
        public static List<Game> Games => new List<Game>
        {
            new Game
            {
                Name = "El Caballero",
                Date = "Protagonista",
                ImageUrl = "https://preview.redd.it/ok-so-like-does-the-knight-have-a-personality-or-is-v0-tkxvlo1432mb1.jpg?auto=webp&s=946de2a411b3bf8a579a3c1fb3b1cc57ee2d912b",
                Details = "Un pequeño guerrero silencioso que explora las profundidades de Hallownest. Su pasado está lleno de misterio, y su presente, de decisiones difíciles. Cada paso lo acerca a la verdad detrás de la corrupción del reino y su propio papel en ella."
            },
            new Game
            {
                Name = "Hornet",
                Date = "Aliada y rival",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQjqBgWRclx-J40AKw3PebB1sEUxk5HrVcl2w&s",
                Details = "Hornet es una guardiana veloz e implacable que pone a prueba tu habilidad y moralidad. A lo largo del viaje se revela como una figura crucial en el destino de Hallownest. Su historia continúa en su propia aventura: Silksong."
            }
        };
    }
}
