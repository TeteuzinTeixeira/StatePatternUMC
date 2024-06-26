class EstadoConcretoImportado : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoImportado capta a primeira requisição");
        Console.WriteLine("EstadoConcretoImportado deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoManual());
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoImportado capta a segunda requisição");
        // Transição para um novo estado aqui
        Console.WriteLine("EstadoConcretoImportado deseja mudar o estado do contexto");
        this._context.TransitionTo(new EstadoConcretoManual());  // Insira a transição desejada
    }

    public override void Handle3()
    {
        Console.WriteLine("EstadoConcretoImportado capta a terceira requisição");
    }
}