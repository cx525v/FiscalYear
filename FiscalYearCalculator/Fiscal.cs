using System;

namespace FiscalYearCalculator
{
    public class Fiscal
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public int Woy { get; set; }

        public int Poy { get; set; }

        public DateTime Wini { get; set; }
    }
}
