using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace VinterProjekt_3an
{
    public class Player
    {
        public float playerX = 800;
        public float playerY = 450;

        Vector2 mouseAimVector = new Vector2(0, 0);
        public Boolean isAlive = true;


        public void playerchar()
        {


            Raylib.DrawCircle((int)playerX, (int)playerY, 40, Color.BLUE);


        }
        public void Update()
        {

            Vector2 mouseAimVector = Raylib.GetMousePosition();
            Console.WriteLine(mouseAimVector);



            Vector2 playerPos = new Vector2(playerX, playerY);
            if (Raylib.CheckCollisionCircles(playerPos, 40, Enemy.enemies[0].position, 40))   // Kollar collision
            {
                isAlive = false;
            }




            if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && isAlive)   // Movement if satser
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