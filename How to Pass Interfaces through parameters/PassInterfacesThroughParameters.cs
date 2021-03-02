using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace How_to_Call_Interfaces_through_parameters
{
   public class PassInterfacesThroughParameters
    {
        public PassInterfacesThroughParameters()
        {
            Car mycar = new Car(new Lampo(), new Ferrari());
        }
    }

    public class Car
    {
        IEngine _engine;
        IWheel _wheel;

        public Car(IEngine engine, IWheel wheel)
        {
            _engine = engine;
            _wheel = wheel;
        }
    }

    public interface IEngine
    {
    }

    public interface IWheel
    {
    }

    public class Lampo : IEngine
    {

    }
    public class Ferrari : IWheel
    {

    }
}
