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


            int difficulty = 100;
            int score = 0;

            Player mePlayer = new Player();
            Enemy firstEnemy = new Enemy();
            List<Bullet> bullets = new List<Bullet>();   // listor över alla kulor

            Random generator = new Random();






            Raylib.InitWindow(1600, 900, "Vinter");    //skapar fönster och sätter frame rate
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (mePlayer.isAlive)
                {


                    //kod för alla kulor
                    if (mePlayer.isAlive)
                    {
                        score++;
                    }
                    Raylib.DrawText($"Score {score}", 20, 840, 40, Color.BLACK);


                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))     // skapar kulorna 
                    {
                        bullets.Add(new Bullet(mePlayer.playerX, mePlayer.playerY));

                    }

                    foreach (Bullet e in bullets)       //Uppdaterar info om alla kulor
                    {
                        e.Update();
                        e.Draw();
                    }








                    mePlayer.Update();    //kör update metoden så att karaktären flyttas varje frame

                    int enemySpawnRate = generator.Next(0, difficulty);  // generator som bestämer ett numer som kanske spawnar en fiende
                    int enemyType = generator.Next(0, 10); // en generator som ger ett numer som bestämmer om det är en stor fiende eller en vanlig







                    Raylib.ClearBackground(Color.GREEN);

                    mePlayer.playerchar();   // ritar ut karaktären varje frame

                    foreach (Enemy e in Enemy.enemies)
                    {
                        e.Update(mePlayer.playerX, mePlayer.playerY);    //loop som uppdaterar infon om alla fiender
                    }

                    firstEnemy.Update(mePlayer.playerX, mePlayer.playerY);

                    if (enemySpawnRate == 1)
                    {
                        Console.WriteLine("Fungerar");      // kontrollerar hur ofta fiender spawnar
                        Console.WriteLine(enemyType);
                        if (enemyType == 1)
                        {
                            new BigEnemy();
                        }
                        else
                        {
                            new Enemy();
                        }
                    }



                    if (Raylib.IsKeyDown(KeyboardKey.KEY_K))     // trycka K dödar mig bara för att testa död grejer
                    {
                        mePlayer.isAlive = false;
                    }


                }


                if (mePlayer.isAlive == false)
                {


                    Raylib.DrawText("You Dead lol", 100, 600, 200, Color.BLACK);
                }








                Raylib.EndDrawing();
            }



        }
    }
}
