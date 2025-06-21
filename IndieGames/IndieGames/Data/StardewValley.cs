using IndieGames.Models;
using System.Collections.Generic;

namespace IndieGames.Data
{
    public class StardewValley
    {
        public static List<Game> Games => new List<Game>
        {
            new Game
            {
                Name = "Granja inicial",
                Date = "Primavera 1",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2f0mB5SEindNYpxWwAVrcbsCB30W00jfWNA&s",
                Details = "Abandonas tu estresante vida urbana y llegas a una vieja granja heredada. El terreno está descuidado, pero poco a poco se convierte en el corazón de tu nueva vida. " +
                "Aquí empiezas a forjar tu legado, conectado con la tierra y la comunidad."
            },
            new Game
            {
                Name = "Festival de flores",
                Date = "Primavera 24",
                ImageUrl = "https://i.blogs.es/6e877f/sv/1366_2000.jpeg",
                Details = "Uno de los primeros eventos sociales importantes del pueblo. Puedes ver a todos los aldeanos reunidos, disfrutar del ambiente primaveral e incluso invitar a alguien a bailar. " +
                "Un momento clave para formar lazos... o quedarte solo mirando."
            }
        };
    }
}
