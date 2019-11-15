using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegado
{
    public class MetodosPropiedadesGlobales
    {
        /// <summary>
        /// Progressbar principal
        /// </summary>
        static public ProgressBar pg=null;
        
        /// <summary>
        /// Metodo que actualiza el avance del progresbar principal
        /// </summary>
        /// <param name="value">Valor de incremento</param>
        static public void RefreshProgress(decimal value)
        {
            if (pg.Value<pg.Maximum)
            {
                pg.Value += (int)value;
            }                       
        }

        /// <summary>
        /// Metodo para establecer dos propiedades del progresbar principal
        /// </summary>
        /// <param name="maxValue">Valor maximo</param>
        /// <param name="stepValue">Valor de avance</param>
        static public void SetPropietiesProgressBar(int maxValue,int stepValue) {
            pg.Maximum = maxValue;
            pg.Step = (stepValue * maxValue)/100;
        }
        
    }
}
