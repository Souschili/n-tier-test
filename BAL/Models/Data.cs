using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Models
{
    public class Data
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Data(string text)
        {
            this.Text = text;
        }
    }
}
