using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    public class enemy
    {

        public float enemyX = 1200;
        public float enemyY = 800;
        public void enemyvectors(float playerX, float playerY)
        {

            Raylib.DrawCircle((int)enemyX, (int)enemyY, 40, Color.RED);

            Vector2 enemyVec = new Vector2(enemyX, enemyY);
            Vector2 playerVec = new Vector2(playerX, playerY);
            Vector2 difference = playerVec - enemyVec;
            difference = Vector2.Normalize(difference);
            enemyVec += difference * 1.5f;


        }










    }
}