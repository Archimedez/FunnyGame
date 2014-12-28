using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GalacticConflict {
    class DrawSpriteState : IGameObject {
        TextureManager _textureManager;

        public DrawSpriteState(TextureManager textureManager) {
            _textureManager = textureManager;
        }

        public void Update(double elapsedTime) {
        }

        public void Render() {
            double height = 200;
            double width = 200;
            double halfHeight = height / 2;
            double halfWidth = width / 2;
            double x = 0;
            double y = 0;
            double z = 0;

            Gl.glClearColor(0, 0, 0, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Texture texture = _textureManager.Get("face_alpha");
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture.Id);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            float topUV = 0;
            float bottomUv = 1;
            float leftUV = 0;
            float rightUV = 1;

            Gl.glBegin(Gl.GL_TRIANGLES);
            {
                Gl.glTexCoord2d(leftUV, topUV);
                Gl.glVertex3d(x - halfWidth, y + halfHeight, z);
                Gl.glTexCoord2d(rightUV, topUV);
                Gl.glVertex3d(x + halfWidth, y + halfHeight, z);
                Gl.glTexCoord2d(leftUV, bottomUv);
                Gl.glVertex3d(x - halfWidth, y - halfHeight, z);
                Gl.glTexCoord2d(rightUV, topUV);
                Gl.glVertex3d(x + halfWidth, y + halfHeight, z);
                Gl.glTexCoord2d(rightUV, bottomUv);
                Gl.glVertex3d(x + halfWidth, y - halfHeight, z);
                Gl.glTexCoord2d(leftUV, bottomUv);
                Gl.glVertex3d(x - halfWidth, y - halfHeight, z);
            }
            Gl.glEnd();
        }
    }
}
