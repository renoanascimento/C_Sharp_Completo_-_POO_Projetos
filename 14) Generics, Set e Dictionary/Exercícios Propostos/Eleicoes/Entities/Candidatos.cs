namespace Eleicoes.Entities
{
    class Candidatos
    {
        public string Nome { get; set; }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Candidatos))
            {
                return false;
            }

            Candidatos other = obj as Candidatos;

            return Nome.Equals(other.Nome);
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
