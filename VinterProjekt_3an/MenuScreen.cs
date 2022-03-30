using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    public class MenuScreen : Screen
    {


        public override string Update()
        {

            Raylib.ClearBackground(Color.BLUE);
            Raylib.DrawText("Zombie Survival", 200, 100, 150, Color.GREEN);
            Raylib.DrawText("Space = Shoot and W A S D to move", 90, 300, 80, Color.BLACK);
            Raylib.DrawText("Press space to choose difficulty", 100, 450, 80, Color.BLACK);


            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                return "chooseDiff";
            }




        }

    }
}