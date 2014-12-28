using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GalacticConflict {
    class TextRenderState : IGameObject {
        TextureManager _textureManager;
        Font _font;
        Text _helloWorld;
        Renderer _renderer = new Renderer();

        public TextRenderState(TextureManager textureManager) {
            _textureManager = textureManager;
            _font = new Font(textureManager.Get("font"), FontParser.Parse("font.fnt"));
            _helloWorld = new Text("The quick brown fox jumps over the lazy dog", _font, 400);
        }

        public void Update(double elapsedTime) {

        }

        public void Render() {
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            _renderer.DrawText(_helloWorld);
        }
    }
}
