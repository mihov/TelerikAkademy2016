using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public abstract class People : HasName, Icommentable
    {
          private String comment;

        public People(String name):base(name)
        {
            this.Comment = "No comment";
        }
        
        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }
    }
}