using System.Drawing;

namespace Convertor
{
    class Animation
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Brush[] _brushes;
        private Rectangle[] _rectangles;
        private int _n;     
        public Animation()
        {
            AnimationInitialization();                    
            _n = 1;                    
        }

        private void AnimationInitialization()
        {          
            _bitmap = new Bitmap(897, 48);
            _graphics = Graphics.FromImage(_bitmap);
            _brushes = new Brush[8];

            _brushes[0] = new SolidBrush(Color.CadetBlue);
            _brushes[1] = new SolidBrush(Color.DodgerBlue);
            _brushes[2] = new SolidBrush(Color.LightSeaGreen);
            _brushes[3] = new SolidBrush(Color.Aquamarine);
            _brushes[4] = new SolidBrush(Color.Aqua);
            _brushes[5] = new SolidBrush(Color.Cyan);
            _brushes[6] = new SolidBrush(Color.CadetBlue);
            _brushes[7] = new SolidBrush(Color.Aqua);

            _rectangles = new Rectangle[8];
            int x = 0, y = 0;
            for (int i = 0; i < 8; i++)
            {

                _rectangles[i] = new Rectangle(x, y, 110, 48);
                x += 112;
            }
        }

        public Bitmap AddRectangles()
        {
            if (_n == 0)
            {
                _graphics.Clear(Color.AliceBlue);
            }
            else
            {
                _graphics.FillRectangle(_brushes[_n - 1], _rectangles[_n - 1]);
            }           
            _n++;
            _n %= 9;
            return _bitmap;
        }
    }
}
