
using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    public class Enemy
    {

        Random generator = new Random();
        public int rSide;
        public int spawnPosX;
        public int spawnPosY;
        public int spawnRate = 600;

        public static List<Enemy> enemies = new List<Enemy>();


        public Vector2 position;

        public Enemy()
        {

            enemies.Add(this);
            rSide = generator.Next(4);

            if (rSide == 0)
            {
                spawnPosX = generator.Next(0, 1600);
                spawnPosY = 0;
            }


            if (rSide == 1)
            {
                spawnPosX = generator.Next(0, 1600);
                spawnPosY = 900;
            }

            if (rSide == 2)
            {
                spawnPosY = generator.Next(0, 900);
                spawnPosX = 0;

            }

            if (rSide == 3)
            {
                spawnPosY = generator.Next(0, 900);
                spawnPosX = 1600;

            }

            position = new Vector2(spawnPosX, spawnPosY);


        }

        public void Update(float playerX, float playerY)
        {




            Vector2 playerVec = new Vector2(playerX, playerY);
            Vector2 difference = playerVec - position;
            difference = Vector2.Normalize(difference);
            position += difference * 1.5f;


            Raylib.DrawCircleV(position, 40, Color.RED);


        }









    }
}