﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Contents = new List<Content>();
        }
        public Subject(int code, string fullName, string name)
        {
            this.Code = code;
            this.FullName = fullName;
            this.Name = name;

            Contents = new List<Content>();
        }
        public void AddContent(Content c) {
            Contents.Add(c);
        }
    }
}
