using System;
using System.Collections.Generic;

namespace TyggeGummiMaskinen
{
    public class Dispenser
    {
        private List<Bubblegum> _maskine = new List<Bubblegum>();


        public List<Bubblegum> Maskine { get => _maskine; set => _maskine = value; }


    }
}