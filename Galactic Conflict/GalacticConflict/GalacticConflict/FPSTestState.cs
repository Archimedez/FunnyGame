using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GalacticConflict {
    class FPSTestState : IGameObject {
        TextureManager _textureManager;
        Font _font;
        Text _fpsText;
        Renderer _renderer = new Renderer();
        FramesPerSecond _fps = new FramesPerSecond();

        public FPSTestState(TextureManager textureManager) {
            _textureManager = textureManager;
            _font = new Font(textureManager.Get("font"), FontParser.Parse("font.fnt"));
        }

        public void Update(double elapsedTime) {
            _fps.Process(elapsedTime);
        }

        public void Render() {
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            _fpsText = new Text("FPS: " + _fps.CurrentFPS.ToString("00.0"), _font);
            _renderer.DrawText(_fpsText);
            for (int i = 0; i < 1000; i++) {
                _renderer.DrawText(_fpsText);
            }
            _renderer.Render();
        }
    }
}
