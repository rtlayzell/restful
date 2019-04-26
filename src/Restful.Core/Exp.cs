using System;

namespace Restful
{
    /// <summary>
    /// Helper class for building URI templates from link expressions.
    /// </summary>
    public static class Exp
    {
        public static T Var<T>() { throw new NotImplementedException(); }

        public static T Path<T>() { throw new NotImplementedException(); }

        public static T Fragment<T>() { throw new NotImplementedException(); }

        public static T Fragment<T>(string composite) { throw new NotImplementedException(); }

        public static T Query<T>() { throw new NotImplementedException(); }

        public static T Query<T>(string composite) { throw new NotImplementedException(); }

        public static char EncodedChar() { throw new NotImplementedException(); }

        public static string EncodedString() { throw new NotImplementedException(); }
    }
}
