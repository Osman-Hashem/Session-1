namespace Session_1
{
    internal struct Employee
    {
        //private int id;
        //private string name;
        //private double salary;

        #region Apply Encapsulation User Setter Getter Method

        //Apply Encapsulation User Setter Getter Method

        // Setter
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        // Getter

        //public int GetId()
        //{
        //    return id;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length > 8 && name.Length <= 20) 
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary (double salary)
        //{
        //    if (salary > 0) 
        //    this.salary = salary;
        //}

        //public double GetSalary ()
        //{
        //    return salary;
        //} 


        // =============================================================

        //public Employee(int id, string name, double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}

        // =============================================================
        #endregion


        // Apply Encapsulation User Properties
        // 1- Full Porperty 

        // id
        //public int Id
        //{
        //    set
        //    {
        //        id = value;
        //    }
        //    get
        //    {
        //        return id;
        //    }
        //}

        ////// Name 

        //public string Name
        //{
        //    set
        //    {
        //        if (value.Length > 8 && value.Length <= 20)
        //            name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        ////// Salary 

        //public double Salary
        //{
        //    set
        //    {
        //        if (value > 0)
        //            salary = value;
        //    }
        //    get
        //    {
        //        return salary;
        //    }
        //}

        // =========================================

        // 2- Automatic Porperty 

        //public string Address  { set; get; }




        // 3- Special Porperty [Indexer]


        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id : {id} :: Name : {name} :: Salary : {salary} :: Address : {Address}";
        //}











    }
}
