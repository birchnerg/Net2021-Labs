﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get
            {
                return m_radio;
            }
            set
            {
                m_radio = value;
            }
        }

        public void calcularSuperficie()
        {
            throw new System.NotImplementedException();
        }

        public void calcularPerimetro()
        {
            throw new System.NotImplementedException();
        }
    }
}
