﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLT
{
    class Scalar:Object
    {
        string Value;

        public Scalar(string name, string unit)
            : base(name, unit)
        {
            base.Type = ObjectType.Scalar;
            this.Value = "";
        }

        public Scalar(string name, string unit, string value)
            : base(name, unit)
        {
            base.Type = ObjectType.Scalar;
            this.Value = value;
        }

        public Scalar(int id, string name, string unit)
            : base(id, name, unit)
        {
            base.Type = ObjectType.Scalar;
            this.Value = "";
        }

        public Scalar(int id, string name, string unit, string value)
            : base(id, name, unit)
        {
            base.Type = ObjectType.Scalar;
            this.Value = value;
        }

        public Scalar(int id)
            : base(id)
        {
            base.Type = ObjectType.Scalar;
            this.Value = "";
        }

        ///////////////////////////////

        public override void SetValue(object value)
        {
            this.Value = Convert.ToString(value);
        }

        public override object GetValue()
        {
            return this.Value;
        }

    }
}
