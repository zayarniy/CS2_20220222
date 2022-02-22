using System;
using System.Windows.Forms;
using System.Drawing;

namespace Asteroids
{

    static class Program
    {
        static void Main(string[] args)
        {
           
            Form form= new Form();
            form.Width = 800;
            form.Height = 600;
            form.MaximumSize = new Size(800, 600);
            form.MinimumSize = new Size(800, 600);
            form.Text = "Иванов Иван (C) Версия от 2022.02.22";
            //form.Icon = new System.Drawing.Icon("file.ico");
            form.Show();
            Game.Init(form);            
            Application.Run(form);
        }
    }
}
