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
            //GetConstructor(), GetConstructors()：返回ConstructorInfo类型，用于取得该类的构造函数的信息
            ConstructorInfo ci = cls.GetConstructor(Type.EmptyTypes);
            //调用具有指定参数的实例反映的构造函数，为不常用的参数提供默认值
            opr = (Operator)ci.Invoke(null);
            return opr;
        }
    }
}
