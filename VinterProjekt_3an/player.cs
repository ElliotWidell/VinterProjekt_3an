using System;
using System.Numerics;
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
            Vector2 playerPos = new Vector2(playerX, playerY);
            if (Raylib.CheckCollisionCircles(playerPos, 40, Enemy.enemies[0].position, 40))
            {
                isAlive = false;
            }




            if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && isAlive)
            {
                playerY -= 4;

            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && isAlive)
            {
                playerY += 4;

            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && isAlive)
            {
                playerX -= 4;

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && isAlive)
            {
                playerX += 4;

            }
        }
    }
}