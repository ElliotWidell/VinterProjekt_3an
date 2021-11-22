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
            enemy firstEnemy = new enemy();




            Raylib.InitWindow(1600, 900, "Vinter");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {

                mePlayer.Update();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GREEN);

                mePlayer.playerchar();
                firstEnemy.enemyvectors();









                Raylib.EndDrawing();
            }



        }
    }
}
