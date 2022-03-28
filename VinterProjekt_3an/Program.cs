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

            int bulletCD = 30;
            int bigBulletCD = 100;
            int difficulty = 100;
            int score = 0;
            string level = "menu";

            Player mePlayer = new Player();

            List<Bullet> bullets = new List<Bullet>();   // listor över alla kulor

            Random generator = new Random();






            Raylib.InitWindow(1600, 900, "Vinter");    //skapar fönster och sätter frame rate
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (level == "menu")
                {
                    Raylib.ClearBackground(Color.BLUE);
                    Raylib.DrawText("Zombie Survival", 200, 100, 150, Color.GREEN);
                    Raylib.DrawText("Space = Shoot and W A S D to move", 90, 300, 80, Color.BLACK);
                    Raylib.DrawText("Press space to choose difficulty", 100, 450, 80, Color.BLACK);


                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        level = "chooseDiff";
                    }


                }


                if (level == "chooseDiff")
                {
                    Raylib.ClearBackground(Color.DARKBLUE);

                    Rectangle ezRec = new Rectangle(400, 100, 800, 120);
                    Rectangle midRec = new Rectangle(400, 250, 800, 120);
                    Rectangle hardRec = new Rectangle(400, 400, 800, 120);
                    Rectangle insaneRec = new Rectangle(400, 550, 800, 120);
                    Raylib.DrawRectangleRec(ezRec, Color.GREEN);
                    Raylib.DrawRectangleRec(midRec, Color.YELLOW);
                    Raylib.DrawRectangleRec(hardRec, Color.ORANGE);
                    Raylib.DrawRectangleRec(insaneRec, Color.RED);
                    Raylib.DrawText("Easy", 700, 120, 80, Color.BLACK);
                    Raylib.DrawText("Medium", 700, 270, 80, Color.BLACK);
                    Raylib.DrawText("Hard", 700, 420, 80, Color.BLACK);
                    Raylib.DrawText("Filippino", 700, 570, 80, Color.BLACK);



                }

                if (mePlayer.isAlive && level == "inGame")
                {


                    if (mePlayer.isAlive)
                    {
                        score++;   //ökar score
                    }
                    Raylib.DrawText($"Score {score}", 20, 840, 40, Color.BLACK);

                    //kod för alla kulor

                    bulletCD--;
                    bigBulletCD--;      //gör så att cooldownen sänks

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && bulletCD <= 0)     // skapar kulorna 
                    {
                        bullets.Add(new Bullet(mePlayer.playerX, mePlayer.playerY));
                        bulletCD = 30;     //startar om cooldown timer

                    }



                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT_SHIFT) && bigBulletCD <= 0)
                    {
                        bullets.Add(new BigBullet(mePlayer.playerX, mePlayer.playerY));
                        bigBulletCD = 100;

                    }

                    foreach (Bullet e in bullets)       //Uppdaterar info om alla kulor
                    {
                        e.Update();
                        e.Draw();
                    }

                    bullets.RemoveAll(b => b.alive == false);






                    mePlayer.Update();    //kör update metoden så att karaktären flyttas varje frame








                    Raylib.ClearBackground(Color.GREEN);

                    mePlayer.playerchar();   // ritar ut karaktären varje frame

                    foreach (Enemy e in Enemy.enemies)
                    {
                        e.Update(mePlayer.playerX, mePlayer.playerY);    //loop som uppdaterar infon om alla fiender
                    }

                    Enemy.enemies.RemoveAll(e => e.isAlive == false);

                    int enemySpawnRate = generator.Next(0, difficulty);  // generator som bestämer ett numer som kanske spawnar en fiende
                    int enemyType = generator.Next(0, 10); // en generator som ger ett numer som bestämmer om det är en stor fiende eller en vanlig


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
