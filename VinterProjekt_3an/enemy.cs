
using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace VinterProjekt_3an
{
    public class Enemy
    {

        Random generator = new Random();
        public int size = 40;
        protected Color color = Color.RED;
        public int rSide;
        public int spawnPosX;
        public int spawnPosY;
        public int spawnRate = 600;

        public static List<Enemy> enemies = new List<Enemy>();     //lista över alla fieder


        public Vector2 position;

        public Enemy()
        {

            enemies.Add(this);
            rSide = generator.Next(4);   // random generator som bestämmer vilken av de 4 olika sidorna som fienden ska spawna på

            if (rSide == 0)
            {
                spawnPosX = generator.Next(0, 1600);   // Bestämmer värdet på X positionen vilket bestämmer hur högt upp fienden spawnar längs den västra sidan
                spawnPosY = 0;     // eftersom rSide blev 0 så komemr fienden att spawna vid Y=0 så den kommer att spawna längs den vänstra sidan
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

            position = new Vector2(spawnPosX, spawnPosY);     // här ges fienden sin spawn position beroende på vilken av if satserna som kördes


        }

        public void Update(float playerX, float playerY)
        {




            Vector2 playerVec = new Vector2(playerX, playerY);   // tar fiendens position och spelarens position och får fienden att 
            Vector2 difference = playerVec - position;
            difference = Vector2.Normalize(difference);
            position += difference * 1.5f;

            Raylib.DrawCircleV(position, size, color);


        }









    }
}