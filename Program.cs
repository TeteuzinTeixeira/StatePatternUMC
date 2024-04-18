class Program
{
    static void Main(string[] args)
    {
        var context = new Contexto(new EstadoConcretoPendente());
        context.ShowMenu();
    }
}