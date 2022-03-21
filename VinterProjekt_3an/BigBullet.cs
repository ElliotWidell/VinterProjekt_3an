using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace VinterProjekt_3an
{
    public class BigBullet : Bullet
    {

        public BigBullet(float x, float y) : base(x, y)
        {
            bulletColor = Color.YELLOW;
            bulletSize = 25;



        }

        public override void Update()
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


                    Enemy.enemies[i].hp -= 999;


                }

            }
        }
    }
}