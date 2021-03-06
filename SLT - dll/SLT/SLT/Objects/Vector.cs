﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLT
{
    class Vector:Object
    {
        List<Object> Value;

        public Vector(string name, string unit, List<Object> value)
            : base(name, unit)
        {
            base.Type = ObjectType.Vector;
            this.Value = value;
        }

        public Vector(int id, string name, string unit)
            : base(id, name, unit)
        {
            base.Type = ObjectType.Vector;
            this.Value = new List<Object>();
        }

        public Vector(int id)
            : base(id)
        {
            base.Type = ObjectType.Vector;
            this.Value = new List<Object>();
        }
        ////
        public override void SetValue(object list_obj)
        {
            this.Value = (List<Object>)list_obj;
        }

        public override object GetValue()
        {
            return this.Value;
        }

        public SLT.Object FindNode(string node_name, Phrase path)
        {
            SLT.Object finded_node;
            finded_node = this.Value.Find(obj => obj.Name == node_name);
            if (path.Value.Count == 0)
            {                
                return finded_node;// = this.Value.Find(obj => obj.Name == node_name);
            }
            else
            {
                node_name = ((Lexeme)path.Value[1]).LValue;
                Phrase inner_node = path.Value[2];
                finded_node = ((Vector)finded_node).FindNode(node_name, inner_node);
            }
            return finded_node;
        }

        public string GetTree()
        {
            string result = "(";
            foreach (Object obj in this.Value)
            {
                if (obj.Type == ObjectType.Vector)
                {
                    Vector NewVector = (Vector)obj;
                    result += NewVector.GetTree();
                }
                else
                {
                    result += obj.Name/*.Substring(obj.Name.LastIndexOf('.') + 1)*/;
                }
                if (this.Value.IndexOf(obj) < this.Value.Count - 1) // если не последний
                {
                    result += ", ";
                }
            }
            result += ")";
            return result;
        }

    }
}
