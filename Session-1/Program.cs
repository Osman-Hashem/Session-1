namespace Session_1
{

    // 1- Class
    // 2- Struct 
    // 3- Interface 
    // 4- Enum


    internal class Program
    {
        static void Main()
        {
            #region Struct
            // Struct : Value types : STACK


            // Employee 
            // Id , Name , Salary 

            // Point 

            //Point P01;
            // Declare For Object From Type 'Point'
            // P01 : Object 
            // Allocate UnInitialized 8 Bytes At STACK

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X = 10;
            //P01.Y = 10;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(4 , 5);
            //P01 = new Point();
            //// new : Used For Select The Constructor 

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Console.WriteLine(P01);

            //P01.PrintPoint();

            //Console.WriteLine(P01.ToString()); // Session_1.Point
            //Console.WriteLine(P01); // Session_1.Point --> Syntaxts Sugar 
            #endregion

            #region OOP Overview
            // OOP : Object Orianted Programming 
            // Programming Paradgm
            // OOP : The Paradgm Use For Build Any Business

            // Class : Blueprint Of The Object 
            // Object : Specific Instance Form Class

            // 4 Pillars
            // ================→
            // 1- Encapsulation 
            // 2- Inheritance 
            // 3- Ploymorphism
            // 4- Abstraction

            #endregion

            #region Encapsulation
            // 1- Encapsulation : 
            // [Class Or Struct]
            // Seperate The Data (Attributes) Definition From Its Use 

            // Employee 
            // Id , Name , Salary 

            // ==================================
            // 1- End User Access Data Itself
            // 2- No Data Validation
            // 3- No Read Only Filed
            // ==================================

            // Apply Encapsulation :
            // 1- Make All Data (Attributes) Private 
            // 2- Access Data Through : 
            //    2-1- Setter Getter Method 
            //    2-2- Properties 

            // ==================================


            #region Getter & Setter
            //Employee E01 = new Employee(1, "Ahmed Osman", 12000);
            //Console.WriteLine(E01);

            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.salary);
            //Console.WriteLine(E01.name);

            // ==================================

            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());
            #endregion

            //Employee E01 = new Employee();

            //E01.Id = 12;
            //E01.Name = "Ahmed Amin";
            //E01.Salary = 18000;
            //E01.Address = "Cairo";

            //Console.WriteLine(E01);
            #endregion

            #region Indexer
            // Indexer : Special Property 
            //         1- Named this 


            // PhoneBook : 

            //PhoneBook phoneBook = new PhoneBook(3);

            //phoneBook.AddPerson("Ahmed", 111, 0);
            //phoneBook.AddPerson("Ali", 222, 1);
            //phoneBook.AddPerson("Omar", 333, 2);

            //Console.WriteLine(phoneBook.GetNumber("Ali"));
            //Console.WriteLine(phoneBook.GetNumber("Mohamed")); // Invalid [-1]

            //============================================

            //phoneBook.UpdateNumber("Ahmed", 999);
            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));

            //============================================

            //Console.WriteLine(phoneBook["Ahmed"]); // long

            //phoneBook["Ahmed"] = 999; // long

            //Console.WriteLine(phoneBook["Ahmed"]);

            //Console.WriteLine(phoneBook[111]); 
            #endregion

            #region Class
            // class : Reference Types : HEAP

            // Car : Id , Model , Speed 
            //Car C01; ////----------------------
            // Declare For Reference (Pointer) From Type Car 
            // C01 : Can Refer To Object From Type 'Car' Or Any Class Inherited From Car 
            // C01 : Refer To Null 

            //Console.WriteLine(C01);

            // 8 Bytes Will Be Allocated At STACK For The Reference 'C01'
            // 0 Bytes Will Be Allocated At HEAP 

            //C01  = new Car(1 , 300 , "XYZ"); //----------------
            //C01  = new Car(1 , 300 ); 
            //C01  = new Car(1);
            // new : 
            // 1- Allocate The Number Of Required Bytes At HEAP For The Object
            // 2- Initilized The Allocated Bytes With The Default Value Of The Datatypes 
            // 3- Caal User-Defiend Constructor If Exists
            // 4- Assign The Object To The Reference 

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01); //---------------- 
            #endregion




        }
    }
}
