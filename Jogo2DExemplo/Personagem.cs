using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo2DExemplo
{
    class Personagem
    {
        public int x;

        public int y;

        public Personagem(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public Vector2 getVector()
        {
            return new Vector2(x, y);
        }

        public void moverX(int qtdPassos)
        {
            x += qtdPassos;
        }

        public void moverY(int qtdPassos)
        {
            y += qtdPassos;
        }

    }
}
