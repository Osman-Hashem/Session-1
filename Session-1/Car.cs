namespace Session_1
{
    internal class Car
    {
        // Id 
        //private int id;
        // propfull : → short cut ← : 

        #region Attributes
        //private int id; // 4
        //private int speed; // 4
        //private string model; // 8
        #endregion

        #region Properties
        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        //public int Speed
        //{
        //    get { return speed; }
        //    set { speed = value; }
        //}

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        #endregion




        // CLR : Will Generate Parameterless Cinstructor :
        // This Constructor 

        // ctor : → short cut ← :
        //public Car()
        //{

        //} // Do Nothing  


        //public Car() //********************
        //{
        //    Id = default;
        //    Model = default;
        //    Speed = default;
        //}


        //public Car(int id , int speed , string model)
        //{
        //    Id = id;
        //    Speed = speed;
        //    Model = model;
        //}
        //public Car(int id, int speed)
        //{
        //    Id = id;
        //    Speed = speed;
        //}
        //public Car(int id)
        //{
        //    Id = id;
        //}

        //public Car(int id, int speed, string model) : this (id, speed )
        //{
        //    //Id = id;
        //    //Speed = speed;
        //    Model = model;
        //}
        //public Car(int id, int speed) : this (id) 
        //{
        //    //Id = id;
        //    Speed = speed;
        //}
        //public Car(int id)
        //{
        //    Id = id;
        //}




        //public override string ToString()
        //{
        //    return $"Id : {id} :: Speed : {speed} :: Model : {model}";
        //}





    }
}
