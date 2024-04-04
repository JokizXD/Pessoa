public class Pessoa {
    private string nome;
    private int idade;
    private string cpf;
    public Pessoa(string nome, int idade, string cpf){
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public int Idade {
        get { return idade; }
        set { idade = value; }
    }
    public string CPF {
        get { return cpf; }
        set { cpf = value; }
    }
}

public class Estudante: Pessoa{
    private string curso;

    //Construtor da classe Estudante 
    public Estudante(string nome; int idade; string cpf; string curso;) : base(nome, idade, cpf){
        Curso = curso;
    }

    //Propriedades da classe Estudante que permite acesso controlado a um campo privado
    public string Curso{
        get { return curso; }
        set { curso = value; }
    }
}