﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLT
{
    class Link:Object
    {
        int Value;

        public Link(string name, string unit)
            : base(name, unit)
        {
            base.Type = ObjectType.Link;
        }

        public Link(string name, string unit, int value)
            : base(name, unit)
        {
            base.Type = ObjectType.Link;
            this.Value = value;
        }


        public Link(int id, string name, string unit)
            : base(id, name, unit)
        {
            base.Type = ObjectType.Link;
            this.Value = -1;
        }

        public Link(int id)
            : base(id)
        {
            base.Type = ObjectType.Link;
            this.Value = -1;
        }

        //////////////////

        public override void SetValue(object value)
        {
            this.Value = Convert.ToInt32(value);
        }

        public override object GetValue()
        {
            return this.Value;
        }

    }
}
