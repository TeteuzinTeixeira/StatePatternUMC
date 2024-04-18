class EstadoConcretoInconsistente : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoInconsistente capta a primeira requisição");
        Console.WriteLine("EstadoConcretoInconsistente deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoImportado());
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoInconsistente capta a segunda requisição");
    }
}