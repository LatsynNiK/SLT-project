﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPDP.Structure
{
    public class LabelsTable
    {
        List<Label> Table;

        public LabelsTable()
        {
            this.Table = new List<Label>();
        }

        //???
        public void Add(Label label)
        {
            //if (this.Table.Exists(l => l.Subprogram == label.Subprogram))
            //{
            //    Label old_label = this.Table.Find(l => l.Subprogram == label.Subprogram);
            //    if (old_label.Visible == false)
            //    {
            //    }
            //    else
            //    {
            //        //error
            //    }
            //}
            this.Table.Add(label);
        }

        public Label FindFirstBySubprogram(Subprogram subp)
        {
            return this.Table.Find(l => l.Subprogram == subp);
        }

        //public void Delete(int id_rec)
        //{
        //    Label rec = this.Table.Find(r => r.SubprogramID == id_rec);
        //    this.Table.Remove(rec);
        //}
    }
}
