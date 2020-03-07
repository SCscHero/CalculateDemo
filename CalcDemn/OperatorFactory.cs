using System;
using System.Reflection;

namespace CalculateDemo
{
    class OperatorFactory
    {
        /// <summary>
        /// 利用反射
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Operator Create(string name)
        {
            Operator opr = null;
            Type cls = Type.GetType(name);
            ConstructorInfo ci = cls.GetConstructor(Type.EmptyTypes);
            opr = (Operator)ci.Invoke(null);
            return opr;
        }
    }
}
