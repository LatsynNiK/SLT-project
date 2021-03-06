﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLT
{
    class ConditionsTable
    {
        public List<RecordCT> CondTable;

        public ConditionsTable()
        {
            this.CondTable = new List<RecordCT>();
        }

        public void Add(RecordCT rec)
        {
            this.CondTable.Add(rec);
        }

        public void Insert(RecordCT rec)
        {
            this.CondTable.Insert(0, rec);
        }

        public void Delete(int id_rec)
        {
            RecordCT rec = this.CondTable.Find(r => r.ID == id_rec);
            this.CondTable.Remove(rec);
        }
    }
}
