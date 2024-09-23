using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosMAUI.Dibujable
{
    internal class DibujoReloj : IDrawable
    {
        public DibujoReloj()
        {
            
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            var centroReloj = new PointF(200, 300);
            var radioCirculo = 100;

            canvas.StrokeColor = Colors.Violet;
            canvas.StrokeSize = 6;

            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            canvas.StrokeSize = 4;
            var horero = GetManecillaHora(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, horero);
        }
    }
}
