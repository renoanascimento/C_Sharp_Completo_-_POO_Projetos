namespace TotalStudents.Entities
{
    class Student
    {
        public int Matricula { get; set; }

        public override int GetHashCode()
        {
            return Matricula.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;

            return Matricula.Equals(other.Matricula);
        }
    }
}
