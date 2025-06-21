using IndieGames.Models;
using System.Collections.Generic;

namespace IndieGames.Data
{
    public class UndertaleData
    {
        public static List<Game> Games => new List<Game>
        {
            new Game
            {
                Name = "Toriel",
                Date = "Primer personaje importante",
                ImageUrl = "https://static.wikia.nocookie.net/undertale/images/9/9d/Toriel_sprite-0.png/revision/latest/scale-to-width/360?cb=20160612170203&path-prefix=es",
                Details = "Toriel es una figura maternal que vive en las Ruinas. Te cuida desde el principio, pero también representa el primer gran dilema moral: ¿seguirla o desafiarla? Su dulzura esconde heridas profundas que afectan su forma de protegerte."
            },
            new Game
            {
                Name = "Sans",
                Date = "Juez del jugador",
                ImageUrl = "https://static.wikia.nocookie.net/undertale/images/a/a6/Sans_overworld.png/revision/latest/scale-to-width/360?cb=20220219115125",
                Details = "Sans es un esqueleto relajado con chistes malos... y conocimiento de todo lo que haces. Puede ser tu amigo más leal o tu enemigo más despiadado. En las rutas oscuras, se convierte en el jefe más temido del juego. 'You’re gonna have a bad time...'"
            }
        };
    }
}
