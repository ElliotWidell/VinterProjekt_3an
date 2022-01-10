using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    class Program
    {
        static void Main(string[] args)
        {

            Player mePlayer = new Player();
            Enemy firstEnemy = new Enemy();

            Random generator = new Random();
            int enemySpawnRate = generator.Next();






            Raylib.InitWindow(1600, 900, "Vinter");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (mePlayer.isAlive)
                {
                    mePlayer.Update();








                    Raylib.ClearBackground(Color.GREEN);

                    mePlayer.playerchar();
                    firstEnemy.enemyvectors(mePlayer.playerX, mePlayer.playerY);



                    if (Raylib.IsKeyDown(KeyboardKey.KEY_K))
                    {
                        mePlayer.isAlive = false;
                    }


                }









                Raylib.EndDrawing();
            }



        }
    }
}
