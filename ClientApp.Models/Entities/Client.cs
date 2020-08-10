using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.Models.Entities
{
    public class Client
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public string Picture { get; set; }
    }
}
