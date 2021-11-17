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

            Raylib.InitWindow(1600, 900, "Vinter");
            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();
                Raylib.SetTargetFPS(60);
                Raylib.ClearBackground(Color.GREEN);


                Raylib.EndDrawing();








            }



        }
    }
}
