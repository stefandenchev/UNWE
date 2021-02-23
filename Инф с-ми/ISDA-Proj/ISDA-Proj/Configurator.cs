using System;

namespace ISDA_Proj
{
    public class Configurator
    {
        private DBManipulator manipulator;

        public Configurator()
        {
            this.manipulator = new DBManipulator();
        }
    }
}
