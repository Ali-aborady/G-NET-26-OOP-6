using System.Buffers;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Abstraction vs Encapsulation

            //Abstraction is the process of hiding complex implementation details and showing only the essential features to the user. It focuses on what an object does, not how it does it.

            //Encapsulation is the process of bundling data and methods into a single unit, usually a class, and restricting direct access to the internal state using access modifiers
            //such as "private", "protected", and "public".

            // Key Difference

            //Abstraction : hides complexity at the design level, while encapsulation hides and protects data at the implementation level.

            //In other words:

            // -Abstraction decides** what to show.
            // -Encapsulation decides** how to protect the data.

            // Real-World Example: TV Remote Control

            // Abstraction:
            //When using a remote control, you only see buttons such as volume up, volume down, and channel change. You do not need to know how the internal circuits or infrared signals work.


            // Encapsulation:
            //The internal circuit board and electronic components are sealed inside the remote.The user cannot directly access or modify them.


            #endregion

            #region Question 2

            //4 Key Differences:

            //1:Multiple Inheritance

              //Abstract Class: A class can inherit from only one abstract class (single inheritance).
              
              //Interface: A class can implement multiple interfaces simultaneously.

            //2:State and Fields

              //Abstract Class: Can hold instance variables, fields, and constructors to maintain internal state.
              
              //Interface: Cannot store instance state or fields, and cannot have constructors.

            //3:Relationship Intent("Is-A" vs. "Can-Do")

              //Abstract Class: Defines an "IS-A" relationship for closely related classes(e.g., a Dog is an Animal).
              
              //Interface: Defines a "CAN-DO" capability for potentially unrelated classes(e.g., both a Document and an Image can be IPrintable).

            //4:Implementation and Access Modifiers

              //Abstract Class: Members can use any access modifier(public, protected, private) and frequently contain fully implemented shared methods alongside abstract ones.
              
              //Interface: Members form a public contract, so they are typically implicitly public (and historically defined signatures only, without concrete code).

            //When to Use Each One
            
            // Use an abstract class  when several classes share common data and behavior.
               
            // Example:
               
            // All ticket types share "MovieName", "Price", and booking logic.
               
            // Use an interface  when you want to define a capability that different unrelated classes can implement.
               
            // Example:
            
            //IPrintable can be implemented by Ticket, Receipt, or Report.

            #endregion
        }
    }
}
