using System;

namespace DesignOnPanel
{
    public class Vector
    {
        public CoordenadaDeVector Punto1 { get; }
        public CoordenadaDeVector Punto2 { get; }

        public Vector(CoordenadaDeVector punto1, CoordenadaDeVector punto2)
        {
            Punto1 = punto1;
            Punto2 = punto2;
        }
    }
}