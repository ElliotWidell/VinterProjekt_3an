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
        public int deathTimer = 0;


        Vector2 mouseAimVector = new Vector2(0, 0);
        public Boolean isAlive = true;


        public void playerchar()
        {


            Raylib.DrawCircle((int)playerX, (int)playerY, 40, Color.BLUE);    // karaktärens cirkel


        }
        public void Update()
        {

            Vector2 mouseAimVector = Raylib.GetMousePosition();   // tar musens position för att veta vart kulorna ska

            if (playerX > 1620 || playerX < -20 || playerY > 920 || playerY < -20)   //Kollar om spelaren är utanför skärmen
            {
                Raylib.DrawText("GO BACK OR YOU WILL DIE!!!", 150, 400, 100, Color.RED);
                deathTimer++;               // ökar dödstimern

            }
            else
            {
                deathTimer = 0;     // om spelaren inte är utanför skärmen så startar timern om
            }


            if (deathTimer > 300)
            {
                isAlive = false;     //Dödar spelaren om timern når 300
            }


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