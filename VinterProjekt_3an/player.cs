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


            Raylib.DrawCircle((int)playerX, (int)playerY, 40, Color.BLUE);    // karaktärens cirkel


        }
        public void Update()
        {

            Vector2 mouseAimVector = Raylib.GetMousePosition();   // tar musens position för att veta vart kulorna ska




            Vector2 playerPos = new Vector2(playerX, playerY);
            foreach (Enemy enemy in Enemy.enemies)
            {
                if (Raylib.CheckCollisionCircles(playerPos, 40, enemy.position, 40))   // Kollar collision
                {
                    isAlive = false;
                }

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