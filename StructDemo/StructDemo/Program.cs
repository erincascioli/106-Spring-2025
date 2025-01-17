using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects and check values
            StructThing st = new StructThing("a");
            ClassThing ct = new ClassThing("a");
            st.PrintInformation();
            ct.PrintInformation();

            // Change them and check values again!
            st.Number = 5;
            ct.Number = 5;
            st.PrintInformation();
            ct.PrintInformation();
            
            // Why did this work?  
            // Both the objects are on the stack - 
            //   the struct thing is on the heap because its a locally defined
            //   variable within the scope of Main, and a reference to the class
            //   object is on the stack, too.

            // Now grab them from a list!
            List<StructThing> structList = new List<StructThing>();
            List<ClassThing> classList = new List<ClassThing>();

            structList.Add(st);
            classList.Add(ct);

            structList[0].PrintInformation();
            classList[0].PrintInformation();

            // Change them and check values again!
            // Can't do this because it's a struct and you are
            //   accessing the struct via a reference (the list)
            //structList[0].Number = 305;

            // Instead you have to either:
            // 1. Copy Alter Replace
            StructThing copyOfData = structList[0];
            copyOfData.Number = 305;
            structList[0] = copyOfData;
            // OR
            // 2. Set = a New thing
            structList[0] = new StructThing(305);

            classList[0].Number = 50;
            structList[0].PrintInformation();
            classList[0].PrintInformation();               
        }
    }
}
