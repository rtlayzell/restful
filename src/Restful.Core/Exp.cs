using System;

namespace Restful
{
    public static class Exp
    {
        public static TController Controller<TController>() => throw new NotImplementedException();

        public static T Ignore<T>() { throw new NotImplementedException(); }

        public static T Var<T>() { throw new NotImplementedException(); }

        public static T Var<T>(string composite) { throw new NotImplementedException(); }

        public static T Path<T>() { throw new NotImplementedException(); }

        public static T Path<T>(string composite) { throw new NotImplementedException(); }

        public static T Fragment<T>() { throw new NotImplementedException(); }

        public static T Fragment<T>(string composite) { throw new NotImplementedException(); }

        public static T Query<T>() { throw new NotImplementedException(); }

        public static T Query<T>(string composite) { throw new NotImplementedException(); }

        public static char EncodedChar() { throw new NotImplementedException(); }

        public static char EncodedChar(string composite) { throw new NotImplementedException(); }

        public static string EncodedString() { throw new NotImplementedException(); }

        public static string EncodedString(string composite) { throw new NotImplementedException(); }
    }
}
