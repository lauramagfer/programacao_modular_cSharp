using System; 

class ClassePrincipal
{
    public static void Main(string[] args)
    {
        ClasseParcial classeParcial = new ClasseParcial();
        classeParcial.Tarefa = "estudando";
        classeParcial.ExibeTarefa();
    }
}