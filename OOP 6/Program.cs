using System.Buffers;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
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

            #region Question 3
            //Look at the following code and answer the questions below:
            //=======================================================================================
            //    public abstract class Appliance
            //    {
            //    public string Brand { get; set; }

            //    protected Appliance(string brand) { Brand = brand; }

            //    public abstract double PowerConsumption();

            //    public virtual string Status() => "Standby";

            //    public string Label() => $"{Brand} - {PowerConsumption()}W";
            //    }

            //    public class WashingMachine : Appliance
            //    {
            //        public WashingMachine(string brand) : base(brand) { }
            //        public override double PowerConsumption() => 500;
            //        public override string Status() => "Washing";
            //    }

            //    public class Toaster : Appliance
            //    {
            //        public Toaster(string brand) : base(brand) { }
            //        public override double PowerConsumption() => 800;
            //    }
            //=======================================================================================
            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not? 

                //No.

                //Appliance is an abstract class, so we cannot create an object from it directly.
                //The compiler will give an error:  Cannot create an instance of the abstract type 'Appliance'

                //We can only create objects from concrete derived classes such as:
                //WashingMachine
                //Toaster

            //b) What is the difference between the three methods: PowerConsumption(), Status(), 
            //and Label()? Why did the designer make each one abstract, virtual, or concrete? 

                //PowerConsumption() (Abstract Method)

                //Difference: It has no implementation(no method body) in the base class. Derived classes must provide
                //their own implementation using the override keyword.

                //Design Reason: Every appliance consumes power, but the exact wattage depends entirely on the specific appliance type.
                //The designer forces every child class to supply its own calculation.

                //Status()  (Virtual Method)

                //Difference: It provides a default implementation("Standby") in the base class, but derived classes may choose to override it if they need custom behavior.

                //Design Reason: Most appliances default to "Standby" mode when turned on, so providing a default implementation saves code.However, specific appliances
                //(like WashingMachine, which overrides it to return "Washing") can provide specialized status updates when needed.

                //Label()  (Concrete / Non-Virtual Method)

                //Difference: It has a complete implementation in the base class and cannot be overridden by derived classes.

                //Design Reason: The labeling format ($"{Brand} - {PowerConsumption()}W") is intended to be identical across all appliances.
                //The designer made it non-virtual to enforce a uniform formatting standard that child classes cannot alter.

            //c) If you call Status() on a Toaster object, what will it return? Why?
                //Why: The Toaster class does not override the Status() method in its body.As a result,
                //it inherits and executes the default implementation defined in the Appliance base class, which returns "Standby".


            #endregion
        }
    }
}
