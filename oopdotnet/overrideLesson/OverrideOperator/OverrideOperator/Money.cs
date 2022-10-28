using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideOperator
{
    public class Number
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        public int SomeValue { get; set; }
        public static explicit operator Number(Money m)
        {
            return new Number { Amount = m.Amount };
        }
    }
    public class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        public Money(decimal Amount, string Unit)
        {
            this.Amount = Amount;
            this.Unit = Unit;
        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Unit != b.Unit)
                throw new InvalidOperationException("Нельзя");
            return new Money(a.Amount + b.Amount, a.Unit);
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Amount, this.Unit);
        }
        public override bool Equals(object obj)
        {
            return ((Money)obj).Amount == this.Amount;
        }

        public static bool operator ==(Money a, Money b)
        {
            return a.Amount == b.Amount;
        }
        public static bool operator !=(Money a, Money b)
        {
            return a.Amount != b.Amount;
        }

    }
}
