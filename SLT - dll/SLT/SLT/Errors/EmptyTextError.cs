﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLT
{
    public class EmptyTextError:UserError
    {
        public EmptyTextError()
        {
            this.Text = "Нет текста модели";
        }
    }
}
