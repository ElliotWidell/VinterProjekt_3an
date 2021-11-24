using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    public class enemy
    {

        public Vector2 position = new Vector2(1200, 600);
        public void enemyvectors(float playerX, float playerY)
        {




            Vector2 playerVec = new Vector2(playerX, playerY);
            Vector2 difference = playerVec - position;
            difference = Vector2.Normalize(difference);
            position += difference * 1.5f;


            Raylib.DrawCircleV(position, 40, Color.RED);


        }

        public void Update()
        {

        }









    }
}