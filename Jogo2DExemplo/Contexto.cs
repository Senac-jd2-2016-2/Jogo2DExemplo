using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo2DExemplo
{
    class Contexto
    {

        public static Personagem [] inimigos = new Personagem[4];

        public static Personagem jogador = new Personagem(150, 240);

        public static Texture2D background;

        public static void inicializar(ContentManager content)
        {
            jogador.texture = content.Load<Texture2D>("shuttle");
            background = content.Load<Texture2D>("stars");

            for (int i = 0; i < inimigos.Length; i++)
            {
                inimigos[i] = new Personagem(100 + (i * 200), 140);
                inimigos[i].texture = content.Load<Texture2D>("earth");
            }
        }

    }
}
