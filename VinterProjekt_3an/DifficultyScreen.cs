using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

public class DifficultyScreen : Screen
{
    public override string Update()
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
        Raylib.DrawText("Turkish", 700, 570, 80, Color.BLACK);

        Vector2 mousePos = Raylib.GetMousePosition();

        bool ezCollition = Raylib.CheckCollisionPointRec(mousePos, ezRec);
        bool midCollition = Raylib.CheckCollisionPointRec(mousePos, midRec);
        bool hardCollition = Raylib.CheckCollisionPointRec(mousePos, hardRec);
        bool insaneCollition = Raylib.CheckCollisionPointRec(mousePos, insaneRec);

        bool mouseDown = Raylib.IsKeyDown(KeyboardKey.KEY_SPACE);

        if (ezCollition && mouseDown)
        {
            difficulty = 200;
            return "gameBegin";

        }

        if (midCollition && mouseDown)
        {
            difficulty = 100;
            return "gameBegin";

        }

        if (hardCollition && mouseDown)
        {
            difficulty = 50;
            return "gameBegin";

        }

        if (insaneCollition && mouseDown)
        {
            difficulty = 50;
            // enemyTypeDifficulty = 2;
            return "gameBegin";

        }

        return "chooseDiff";
    }

}