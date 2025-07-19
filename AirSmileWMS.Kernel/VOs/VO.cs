using System;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Базовый VO с хранением значения, валидацией и сравнением.
    /// </summary>
    public abstract class VO<TSelf, TValue> : IEquatable<TSelf>, IComparable<TSelf>, IComparable
    where TSelf : VO<TSelf, TValue>
    where TValue : IComparable
    {
        // Основной конструктор скрыт, создание нового экземпляра идет через фабрику.
        protected VO(TValue value) => Value = Guard(value);

        // Конструктор для EF.
        protected VO() { }

        /// <summary>
        /// Хранимое значение.
        /// </summary>
        public TValue Value { get; private set; }

        /// <summary>
        /// Защищает от неккоректных данных, вызывающих непредсказуемое поведение. 
        /// Каждый наследник сам решает, как валидировать
        /// </summary>
        protected abstract TValue Guard(TValue value);

        #region Переопределение системных методов

        public static implicit operator TValue(VO<TSelf, TValue> vo)
        {
            if (vo is null)
                throw new InvalidCastException($"Параметр {typeof(TSelf).Name} является null.");

            return vo.Value;
        }

        public bool Equals(TSelf other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return EqualityComparer<TValue>.Default.Equals(Value, other.Value);
        }

        public sealed override bool Equals(object obj) => Equals(obj as TSelf);

        public sealed override int GetHashCode() => Value == null ? 0 : EqualityComparer<TValue>.Default.GetHashCode(Value);

        public static bool operator ==(VO<TSelf, TValue> a, VO<TSelf, TValue> b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return EqualityComparer<TValue>.Default.Equals(a.Value, b.Value);
        }

        public static bool operator !=(VO<TSelf, TValue> a, VO<TSelf, TValue> b) => !(a == b);

        public int CompareTo(TSelf other) => other == null ? 1 : Comparer<TValue>.Default.Compare(Value, other.Value);

        int IComparable.CompareTo(object obj)
        {
            if (obj is TSelf other)
                return CompareTo(other);

            throw new ArgumentException($"Объект не является {typeof(TSelf).Name}");
        }

        public sealed override string ToString() => Value?.ToString();

        #endregion
    }
}
