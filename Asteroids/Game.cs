using System;
using System.Drawing;
using System.Windows.Forms;

namespace Asteroids
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        // Свойства
        // Ширина и высота игрового поля
        public static int Width { get; set; }
        public static int Height { get; set; }
        static public Random Random { get; set; }=new Random();

        static int Frames = 0;
        static int xBackground = 800;
        static BaseObject[] _obj;
        static Star star;

        static Game()
        {
        }
        public static void Init(Form form)
        {
            // Графическое устройство для вывода графики            
            Graphics g;
            // Предоставляет доступ к главному буферу графического контекста для текущего приложения
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            // Создаем объект (поверхность рисования) и связываем его с формой
            // Запоминаем размеры формы
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            // Связываем буфер в памяти с графическим объектом, чтобы рисовать в буфере
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public static void Load()
        {
            _obj = new BaseObject[20];
            for(int i = 0; i < _obj.Length/2; i++)
                _obj[i]=new BaseObject(new Point(Game.Width -10*i, Game.Height -10*i), new Point(i*2, i*3), new Size(20, 20));
            for (int i = _obj.Length/2; i < _obj.Length ; i++)
                _obj[i] = new Star(new Point(Game.Width - 10 * i, Game.Height - 10 * i), new Point(i * 2, i * 3));

            star = new Star(new Point(200, 200), new Point(10, 10));
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        public static void Draw()
        {
            Frames++;
            // Проверяем вывод графики
            Buffer.Graphics.Clear(Color.Black);
            Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(xBackground, 100, 200, 200));
            Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(xBackground, 100, 200, 200));

            Buffer.Graphics.DrawString($"Frames:{Frames}", SystemFonts.DefaultFont, Brushes.AliceBlue, 600, 0);
            foreach (BaseObject obj in _obj)

            {
                obj.Draw();               
            }
            star.Draw();
            Buffer.Render();
        }

        public static void Update()
        {
            xBackground-=10;
            if (xBackground < -200) xBackground = 800;
            foreach(BaseObject obj in _obj)
                obj.Update();
            star.Update(); 
        }

    }

}
