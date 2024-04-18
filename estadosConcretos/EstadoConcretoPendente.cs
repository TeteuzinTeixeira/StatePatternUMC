class EstadoConcretoPendente : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoPendente capta a primeira requisição");
        Console.WriteLine("EstadoConcretoPendente deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoInconsistente());
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoPendente capta a segunda requisição");
        Console.WriteLine("EstadoConcretoPendente deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoErro());
    }

    public void Handle3()
    {
        Console.WriteLine("EstadoConcretoPendente capta a terceira requisição");
        Console.WriteLine("EstadoConcretoPendente deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoImportado());
    }
}