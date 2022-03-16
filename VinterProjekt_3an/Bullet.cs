using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace VinterProjekt_3an
{
    public class Bullet
    {

        public Vector2 bulletPos;
        public Vector2 target;

        private Vector2 movement;

        public bool alive = true;

        public Bullet(float x, float y)
        {
            target = Raylib.GetMousePosition();   //tar mus positionen 
            bulletPos = new Vector2(x, y);

            Vector2 bulletDiff = target - bulletPos; // gör så att kulan rör sig mot där musen var när man tryckte SPACE
            movement = Vector2.Normalize(bulletDiff);
        }

        public void Update()    //uppdaterar rörelsen och om kulan ska vara kvar eller inte
        {
            bulletPos += movement * 7.5f;     //movement

            Vector2 distance = bulletPos - target;
            if (distance.Length() < 2)
            {
                alive = false;
            }


            for (int i = 0; i < Enemy.enemies.Count; i++)
            {
                if (Raylib.CheckCollisionCircles(bulletPos, 10, Enemy.enemies[i].position, 45))
                {

                    alive = false;
                    Enemy.enemies[i].hp -= 50;

                }

            }
        }

        public void Draw()    // ritar ut kulan
        {
            Raylib.DrawCircleV(bulletPos, 10, Color.GRAY);

        }








    }
}