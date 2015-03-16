using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GalacticConflict {
    class MatrixTestState : IGameObject {
        Sprite _faceSprite = new Sprite();
        Renderer _renderer = new Renderer();

        public MatrixTestState(TextureManager textureManager) {
            _faceSprite.Texture = textureManager.Get("face");
            Gl.glEnable(Gl.GL_TEXTURE_2D);

            Matrix m = new Matrix();
            m.SetRotate(new Vector(0, 0, 1), Math.PI/5);

            Matrix mScale = new Matrix();
            mScale.SetScale(new Vector(2.0, 2.0, 2.0));

            m *= mScale;
            Vector scale = m.GetScale();
            m *= m.Inverse();

            for (int i = 0; i < _faceSprite.VertexPositions.Length; i++) {
                _faceSprite.VertexPositions[i] *= m;
            }


        }

        public void Update(double elapsedTime) {
        }

        public void Render() {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            _renderer.DrawSprite(_faceSprite);
            _renderer.Render();
        }
    }
}
