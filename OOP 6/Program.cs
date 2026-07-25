using System.ComponentModel;
using System.Numerics;
using System.Reflection.Emit;
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
        }
    }
}
