﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform;

namespace Laborator2_Macovei_Dumitru_Viorel_3133a
{
    class SimpleWindow : GameWindow
    {
        public SimpleWindow() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
        }

        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Exit();

            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
           
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(0, 0);
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(1, 1);
            GL.Color3(Color.Ivory);
            GL.Vertex2(-1, 1);

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Aqua);
            GL.Vertex2(1, 1);
            GL.Color3(Color.Red);
            GL.Vertex2(1, -1);
            GL.Color3(Color.Ivory);
            GL.Vertex2(0, 0);
            GL.End();

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Lime);
            GL.Vertex2(-1, 1);
            GL.Color3(Color.Lavender);
            GL.Vertex2(-1, -1);
            GL.Color3(Color.Cyan);
            GL.Vertex2(0, 0);
            GL.End();

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Orange);
            GL.Vertex2(-1, -1);
            GL.Color3(Color.Beige);
            GL.Vertex2(1, -1);
            GL.Color3(Color.Brown);
            GL.Vertex2(0, 0);
            GL.End();
            //    // Sfârșitul modului imediat!

            this.SwapBuffers();
        }
        static void Main(string[] args)
        {

            using (SimpleWindow example = new SimpleWindow())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}

