using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class ReadonlyKeywordInfo : KeywordInfoBase
    {
        public ReadonlyKeywordInfo() : base("In C#, a readonly keyword is a modifier which is used in the following ways:\r\n\r\n1. Readonly Fields: \nIn C#, you are allowed to declare a field using readonly modifier. It indicates that the assignment to the fields is only the part of the declaration or in a constructor to the same class. Such types of fields can only be assigned or reassigned multiple times only at the declaration or in a constructor. They are not assigned after the constructor exit. If the readonly modifier is used with a value type field, then the field is immutable. And if the readonly modifier is used with a reference type field, then the readonly modifier prevents the field from replaced by the different instances of the reference type, here the readonly modifier does not stop the instance data of the field from being modified through the read-only field. In static and instance constructors, you are allowed to pass a readonly field as an out or ref parameter.\n2. Readonly Structure: \n In the readonly structure, readonly modifier indicates that the given structure is immutable. When you create a readonly structure, it is necessary to use a readonly modifier with its fields, if you do not do this, then the compiler will give an error.\n3. Readonly Members: \nThis feature is introduced in C# 8.0. In this feature, you are allowed to use a readonly modifier to any member of the structure. This readonly modifier specifies that the member is not allowed to modify. It is better than applying the whole structure readonly.")
        {
            Keyword = "readonly";
        }
    }
}
