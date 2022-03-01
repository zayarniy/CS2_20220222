using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asteroids
{
    internal abstract class BaseObject: ICollision
    {
        //Point pos;//поле
         protected Point Pos { get; set; } //автоматическое свойство
        protected Point Dir { get; set; }//VX,VY

        protected Size Size { get; set; }

        public Rectangle Rect => new Rectangle(Pos, Size);

        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public abstract void Draw();

        public virtual  void Update()
        {
            Pos=new Point(Pos.X+Dir.X,Pos.Y+Dir.Y);
            //Pos.Offset(Dir);
            if (Pos.X < 0 || Pos.X>Game.Width) Dir = new Point(-Dir.X, Dir.Y);
            if (Pos.Y < 0 || Pos.Y > Game.Height) Dir = new Point(Dir.X, -Dir.Y);
        }

        public bool Collision(ICollision obj)
        {
            return this.Rect.IntersectsWith(obj.Rect);
        }
    }

    internal class Star: BaseObject
    {
        static Image img=Image.FromFile(@"Pictures\star.png");
        public Star(Point pos,Point dir):base(pos,dir,new Size(img.Width,img.Height))
        {

        }

        public override void Draw()//полиморфизм
        {
            Game.Buffer.Graphics.DrawImage(img, Pos);
        }

    }

    #region Вариант 1
    internal class Planet : BaseObject
    {       
        Image img;
        public Planet(Point pos, Point dir,string imgFilename) : base(pos, dir, Size.Empty)
        {
            img = Image.FromFile(imgFilename);
            Size=new Size(img.Width,img.Height);
        }

        public override void Draw()//полиморфизм
        {
            Game.Buffer.Graphics.DrawImage(img, Pos);
        }
    }
    #endregion

    internal class Planet2 : Star
    {
        Image img;
        public Planet2(Point pos, Point dir, string imgFilename) : base(pos, dir)
        {
            img = Image.FromFile(imgFilename);
            Size = new Size(img.Width, img.Height);
        }

    }

    internal class Bullet : Star
    {
        Image img;

        public bool CanFire { get; private set; } = true;
        public Bullet(Point pos, Point dir, string imgFilename) : base(pos, dir)
        {
            img = Image.FromFile(imgFilename);
            Size = new Size(img.Width, img.Height);
        }

        public void Update()//убрать зеленое подчеркивание
        {
            Pos=new Point(Pos.X+Dir.X,Pos.Y);
            if (Pos.X > Game.Width)
            {
               // Pos = new Point(0, Game.Random.Next(0, Game.Height));
               CanFire = true;
            }
        }
        


        public override void Draw()//полиморфизм
        {
            Game.Buffer.Graphics.DrawImage(img, Pos);
        }

        public void Fire(Point pos, Point dir)
        {
            CanFire = false;
            Pos = pos;
            Dir = dir;
        }

    }

    internal class Ship : Star
    {
        Image img;
        public Ship(Point pos, Point dir, string imgFilename) : base(pos, dir)
        {
            img = Image.FromFile(imgFilename);
            Size = new Size(img.Width, img.Height);
        }

        public override void Update()//убрать зеленое подчеркивание
        {
            Pos = new Point(Pos.X + Dir.X, Pos.Y+Dir.Y);
        }

        public void Up()
        {
            Dir = new Point(Dir.X, -Math.Abs(Dir.Y));
        }
        public void Down()
        {
            Dir = new Point(Dir.X, Math.Abs(Dir.Y));
        }

        public void Left()
        {
            Dir = new Point(-Math.Abs(Dir.X), Dir.Y);
        }
        public void Right()
        {
            Dir = new Point(Math.Abs(Dir.X), Dir.Y);
        }

        public override void Draw()//полиморфизм
        {
            Game.Buffer.Graphics.DrawImage(img, Pos);
        }


    }



}
