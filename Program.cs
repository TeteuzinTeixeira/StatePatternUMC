class Program
{
    static void Main(string[] args)
    {
        var context = new Contexto(new EstadoConcretoInicial());
        context.Request1();
        context.Request2();
    }
}