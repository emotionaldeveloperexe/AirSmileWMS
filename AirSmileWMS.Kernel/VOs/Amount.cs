using AirSmileWMS.Kernel.Services;
using System;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Количество.
    /// </summary>
    public sealed class Amount : VO<Amount, int>
    {
        // Конструктор для EF.
        public Amount() { }

        private Amount(int value) : base(value) { }

        // Фабрика.
        public static implicit operator Amount(int value) => new Amount(value);

        protected override int Guard(int value) => Validate.Amount(value);

        #region Арифметика
        public static Amount operator +(Amount a, Amount b) => new Amount(a.Value + b.Value);
        public static Amount operator -(Amount a, Amount b) => new Amount(a.Value - b.Value);
        public static Amount operator *(Amount a, int multiplier) => new Amount(a.Value * multiplier);
        public static Amount operator *(int multiplier, Amount a) => new Amount(multiplier * a.Value);
        public static Amount operator /(Amount amount, int divisor) => new Amount(amount.Value / NonZeroDivisor(divisor));
        public static Amount operator %(Amount amount, int divisor) => new Amount(amount.Value % NonZeroDivisor(divisor));

        private static int NonZeroDivisor(int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("На ноль делить нельзя.");

            return divisor;
        }
        #endregion

        #region Сравнение
        public static bool operator >(Amount a, Amount b) => a.Value > b.Value;
        public static bool operator <(Amount a, Amount b) => a.Value < b.Value;
        public static bool operator >=(Amount a, Amount b) => a.Value >= b.Value;
        public static bool operator <=(Amount a, Amount b) => a.Value <= b.Value;
        #endregion
    }
}
