﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace GalacticConflict {
    class Rectangle {
        Vector BottomLeft { get; set; }
        Vector TopRight { get; set; }
        Color _color = new Color(1, 1, 1, 1);

        public Color Color {
            get { return _color; }
            set { _color = value; } 
        }

        public Rectangle(Vector bottomLeft, Vector topRight) {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }

        internal bool Intersects(Point point) {
            if (point.X >= BottomLeft.X &&
                point.X <= TopRight.X &&
                point.Y <= TopRight.Y &&
                point.Y >= BottomLeft.Y) 
            {
                    return true;
            }
            return false;
        }

        internal void Render() {
            Gl.glColor3f(_color.Red, _color.Green, _color.Blue);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            {
                Gl.glVertex2d(BottomLeft.X, BottomLeft.Y);
                Gl.glVertex2d(BottomLeft.X, TopRight.Y);
                Gl.glVertex2d(TopRight.X, TopRight.Y);
                Gl.glVertex2d(TopRight.X, BottomLeft.Y);
            }
            Gl.glEnd();
        }
    }
}