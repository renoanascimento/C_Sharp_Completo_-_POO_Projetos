﻿namespace VetoresObjetos
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
