using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.Platform.Windows;
using Tao.OpenGl;
using Tao.DevIl;

namespace GalacticConflict {
    public partial class MainWindow : Form {
        FastLoop _fastLoop;
        bool _fullscreen = false;
        StateSystem _system = new StateSystem();
        TextureManager _textureManager = new TextureManager();

        public MainWindow() {
            InitializeComponent();
            _openGlControl.InitializeContexts();

            Il.ilInit();
            Ilu.iluInit();
            Ilut.ilutInit();
            Ilut.ilutRenderer(Ilut.ILUT_OPENGL);

            _textureManager.LoadTexture("face", "face.tif");
            _textureManager.LoadTexture("face_alpha", "face_alpha.tif");
            _textureManager.LoadTexture("font", "font.tga");

            _system.AddState("splash", new SplashScreenState(_system));
            _system.AddState("title_menu", new TitleMenuState());
            _system.AddState("sprite_test", new DrawSpriteState(_textureManager));
            _system.AddState("test_sprite_class", new TestSpriteClassState(_textureManager));
            _system.AddState("text_test", new TextTestState(_textureManager));
            _system.AddState("text_render", new TextRenderState(_textureManager));
            _system.AddState("fps", new FPSTestState(_textureManager));
            _system.AddState("Waveform", new WaveformGraphState());
            _system.AddState("SpecialEffect", new SpecialEffectsState(_textureManager));

            _system.ChangeState("SpecialEffect");

            if (_fullscreen) {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            } else {
                ClientSize = new Size(1280, 720);
            }
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
            _fastLoop = new FastLoop(GameLoop);
        }
        void GameLoop(double elapsedTime) {
            _system.Update(elapsedTime);
            _system.Render();
            _openGlControl.Refresh();
        }

        protected override void OnClientSizeChanged(EventArgs e) {
            base.OnClientSizeChanged(e);
            Gl.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
        }

        private void Setup2DGraphics(double width, double height) {
            double halfWidth = width / 2;
            double halfHeight = height / 2;
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-halfWidth, halfWidth, -halfHeight, halfHeight, -100, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }
    }
}
