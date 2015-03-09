using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GalacticConflict {
    class TweenTestState : IGameObject {
        Tween _tween = new Tween(0, 1, 5, Tween.EaseInCirc);
        Sprite _faceSprite = new Sprite();
        Color _color = new Color(1, 1, 1, 0);
        Renderer _render = new Renderer();

        public TweenTestState(TextureManager textureManager) {
            _faceSprite.Texture = textureManager.Get("face");
        }
    
        public void Update(double elapsedTime) {
            if(_tween.IsFinished() != true) {
                _tween.Update(elapsedTime);
                _color.Alpha = ((float)_tween.Value());
                _faceSprite.SetColor(_color);
            }
        }

        public void Render() {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            _render.DrawSprite(_faceSprite);
            _render.Render();
        }
    }
}
