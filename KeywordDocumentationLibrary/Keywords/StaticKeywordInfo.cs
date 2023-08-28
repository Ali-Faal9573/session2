using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class StaticKeywordInfo : KeywordInfoBase
    {
        public StaticKeywordInfo() : base("It is also applicable to properties, event, and operators. To create a static member(class, variable, methods, constructor), precede its declaration with the keyword static. When a member is declared static, it can be accessed with the name of its class directly.\r\n\r\nStatic Class\r\nA static class is declared with the help of static keyword. A static class can only contain static data members, static methods, and a static constructor. It is not allowed to create objects of the static class. Static classes are sealed, means one cannot inherit a static class from another class.\r\n\r\nStatic Variable\r\nA static variable is declared with the help of static keyword. When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level. Static variables are accessed with the name of the class, they do not require any object for access.\r\n\r\nStatic Method\r\nA static method is declared with the help of static keyword. Static methods are accessed with the name of the class. A static method can access static and non-static fields, static fields are directly accessed by the static method without class name whereas non-static fields require objects.\r\n\r\nStatic Constructor\r\nA static constructor is declared with the help of static keyword. Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first reference to a static member in the class. A static constructor is initialized static fields or data of the class and to be executed only once.")
        {
            Keyword = "static";
        }
    }
}
