using IndieGames.Models;
using System.Collections.Generic;

namespace IndieGames.Data
{
    public class CelesteData
    {
        public static List<Game> Games => new List<Game>
        {
            new Game
            {
                Name = "Inicio del viaje",
                Date = "Capítulo 1",
                ImageUrl = "https://i.blogs.es/442f82/020119-celeste/1366_2000.jpg",
                Details = "Madeline decide escalar la montaña Celeste como una metáfora de su lucha interna. En este primer capítulo se enfrenta al vértigo físico y emocional de salir de su zona de confort. Un inicio tierno, desafiante y lleno de simbolismo."
            },
            new Game
            {
                Name = "Espejo del miedo",
                Date = "Capítulo 2",
                ImageUrl = "https://i.ytimg.com/vi/mWjt5wQ_6sE/maxresdefault.jpg",
                Details = "Madeline se encuentra con una versión distorsionada de sí misma. Este reflejo representa su ansiedad, miedo y negatividad interna. Es el momento donde el jugador entiende que la montaña no es solo un obstáculo físico."
            }
        };
    }
}
