class EstadoConcretoInicial : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoInicial capta a primeira requisição");
        Console.WriteLine("EstadoConcretoInicial deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoPendente());
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoInicial capta a segunda requisição");
    }
}