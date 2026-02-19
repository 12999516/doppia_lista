using System;

namespace es
{
    [Serializable]
    public class Student
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceIdentificativo { get; set; }
        public string Classe { get; set; }

        public Student() { }

        public Student(string nome, string cognome, string codice, string classe)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceIdentificativo = codice;
            Classe = classe;
        }

        public override string ToString()
        {
            return $"{CodiceIdentificativo} - {Cognome} {Nome} ({Classe})";
        }
    }
}
