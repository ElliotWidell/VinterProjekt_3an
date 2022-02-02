using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace VinterProjekt_3an
{
    public class Bullet
    {

        public Vector2 bulletPos;
        public Vector2 mousePos;

        private Vector2 target;

        private Vector2 movement;

        public bool alive = true;

        public Bullet(float x, float y)
        {
            target = Raylib.GetMousePosition();
            bulletPos = new Vector2(x, y);

            Vector2 bulletDiff = mousePos - bulletPos;
            movement = Vector2.Normalize(bulletDiff);
        }

        public void Update()
        {
            bulletPos += movement * 2.5f;

            Vector2 distance = bulletPos - mousePos;
            if (distance.Length() < 2)
            {
                alive = false;
            }
        }

        public void Draw()
        {
            Raylib.DrawCircleV(bulletPos, 10, Color.GRAY);

        }








    }
}