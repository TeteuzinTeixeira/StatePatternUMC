class EstadoConcretoErro : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoErro capta a primeira requisição");
        Console.WriteLine("EstadoConcretoErro deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoImportado());
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoErro capta a segunda requisição");
    }
}