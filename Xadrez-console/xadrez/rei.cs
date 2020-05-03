﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class rei : Peca
    {

        public rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
