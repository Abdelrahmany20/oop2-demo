using System.Security.Claims;

namespace oop2_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Encapsulation
            //What You Can Write Inside Struct Or Class?
            //1.Attributes [Fields] -> Member Variables.
            //2. Functions (Constructor, Getter Setter , Methods);
            //3. Properties(Full Property, Automatic Prop, Indexer) ;
            //4.Events




            //Before Encapsulation
            //1.Name Chages
            //2.Prevent set
            //3.Control Range

            //public class Employee
            //{
            ////1.Attributes
            //public int id;//0
            //public string name;
            //public decimal salary; //0

            ////2.Constructor
            //public Employee(int _id, string _name, decimal _salary)
            //{
            //id = _id;
            //name = _name;
            //salary = _salary;
            //}
            //public override string ToString()
            //{
            //return $"ID: {id} \n Name: {name} \n Salary: {salary}";
            //}

            //}




            //Employee emp = new Empldyee(1, "Ahmed", 5000);
            //Console.WriteLine(emp.ToString());



            //Encapsulation With Getter Setter
            //Getter
            //public string GetName()
            //        { return empName; }
            //// Setter
            //public void SetName(string _name)
            //      {empName = name.Length <= 5 ? name :  _name!_ name. Substring(0, 5D }

            //2.2 Encapsulation With Property


            //public decimal Salary
            //{ 

            //get { return salary; }

            //set { salary = value; }

            //}


            //Proptles
            //emp.Salary = 10_000; //For Setting
            //emp.salary;
            //Console.WriteLine(emp.Salary);//For Getting
            // Compiler will Generate the Attribute (Backing Field)


            //Automatic
            //public string Address { get; set; }

            ////private int discount;

            //public int Discount
            ////{
            ////get { return discount; }
            ////set { discount = value; }
            ////}
            #endregion


            #region indexer


            //Special Propety

            //This
            //Indexer
            //public long this[string name]
            ////{
            ////get
            //set

            //public string this[int index]
            ////{ 
            ////get {return $"{index} :: {names[index]}" }
            //}
            //}

            //struct PhoneBook
            //{
            ////attributes
            //string[] names;
            //long[] numbers; 
            //int size;


            //public int Size
            //{
            //get { return size; }
            //}//ReadOnly

            //public PhoneBook(int _size)
            //{
            //size = _size;
            //names = new string[size];
            //numbers = new long[size];
            //}

            //public void AddPerson(int postion, string Name, long Num)
            //{
            //if (names is not null && numbers is not null)
            //{
            //if (postion >= 0 && postion < size)
            //{
            //names[postion] = Name;
            //numbers[postion] = Num;
            //}
            //}

            //public long GetPersonNumber(string Name)
            //{
            //for (int i = 0; i < names.Length; i++)
            //{
            //if (Name == names[i] && numbers is not null)
            //{
            //return numbers[i];
            //}
            //}
            //}



            #endregion


            #region class


            //internal class Car
            //{


            //Attributes [Fields]
            //Functions [Cosntructor \\ Getter Setter \\ Methods]
            //Propties [Full Prop \ Automatic Prop \\ indexer]
            //Events

            //Private
            //Private Protected
            //Protected
            // internal
            // internal Protected
            //Public



            //private int id;

            //public int Id
            //{
            //get { return id; }
            //set { id = value; }
            //}


            //    private string modeL


            //public int MyProperty

            //get { return model; }
            //  set { model = value; }


            //public override string Tostring()
            //{
            //return $"Car Id: {id}\nCar Model: {model}\nCar Speed: {speed}";
            //}


            //Car C1;
            //Declate For Reference C1 From Type Car; 4Byte
            //Can Refer to Object From Type Car
            //or Object From Onther Class [Inherting From Car]
            //CLR Will Allocate 4 Byte Stack 0 Byte Heap

            //C1 = new
            //New:
            //1)Allocate Requerd Numbers Of Bytes at Heap 16 Byte
            //2) Initialize tge Allocated Bytes with Default Values of DataTYPE
            //3) Calling User Defined Constructor [if exstis]
            //4) Assign The Reference C1 to Allocted Object at heap

            //New Struct
            // Just For only Selection of Constructor for Initializtion of all attr


            //Constructor
            // Struct Always CLR GENERATE ParamterLess Constructor + Initialize DEFULT VALUE
            //Class CLR Generate ParameterLess Constructor [Empty].
            //Compiler Will no Longer Generate ParameterLess Constructor




            //public Car(int id, string model, double speed)

            //this.id = id;




            //            public Car(int id, string model):this(id, model, 290)
            //        {
            //            this.id = id;//1
            //            this.model = model; //BMW
            //            speed = 290;
            //        }
            //public Car(int id):this(id, model, 290)
            //        {
            //            this.id = id;//1
            //            model = "BMW";
            //            speed = 290; }
            #endregion


            #region CLASS VS STRUCT

            //            Class

            //Support 4 Pillars Of OOP
            //More Flexible
            //Does Not Support Inheritance
            //6 Access Modifier Allowed Inside It
            //If You Defined a user defined
            //Constructor, Compiler Will no
            //longer Generate Empty
            //Parameterless Constructor



            //            Struct
            //· Value Type
            //· Support Encapsulation and
            //Overloading in Polymorphism
            //Doesn't Support Inheritance
            //· 3 Access Modifier Allowed Inside It
            //.If You Defined a user defined
            //Constructor, Compiler Will
            //always Generate Empty
            //- Parameterless Constructor


            #endregion
















        }
    }
}










