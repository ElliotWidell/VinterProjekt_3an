using System;
using Raylib_cs;

namespace VinterProjekt_3an
{
    public class Player
    {
        public float playerX = 0;
        public float playerY = 0;

        public Boolean isAlive = true;


        public void playerchar()
        {


            Raylib.DrawCircle((int)playerX, (int)playerY, 40, Color.BLUE);


        }
        public void Update()
        {


            //Raylib.CheckCollisionCircles()




            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                playerY -= 4;

            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                playerY += 4;

            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                playerX -= 4;

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                playerX += 4;

            }
        }
    }
}