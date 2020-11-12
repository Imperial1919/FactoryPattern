using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    /// <summary>
    /// Creates different types of phone objects
    /// </summary>
    static class AutomobileFactory
    {
        /// <summary>
        /// Takes the users input and returns a phone type that conforms to the ICallable interface
        /// </summary>
        /// <param name="phoneType"></param>
        /// <returns>
        /// ICallable
        /// </returns>
        public static ICallable GetCar(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "3 wheels":
                case "3":
                case "three":
                case "three wheeler":

                    return new ReliantRobin();

                case "2 wheeler":
                case "two":
                case "two wheels":
                case "2":
                    return new TwoWheeler();

                case "4 wheels":
                case "four wheels":
                case "4":
                case "four":
                    ; return new Fourwheeler();
                default:
                    return new ReliantRobin();
            }
        }
    }
}
