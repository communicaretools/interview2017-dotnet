using System;

namespace PasReg.Model
{
    public class Study
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string[] Groups { get; set; }
    }
}