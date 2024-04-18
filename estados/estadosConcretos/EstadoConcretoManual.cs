class EstadoConcretoManual : Estado
{
    public override void Handle1()
    {
        Console.WriteLine("EstadoConcretoManual capta a primeira requisição");
    }

    public override void Handle2()
    {
        Console.WriteLine("EstadoConcretoManual capta a segunda requisição");
    }
    
    public override void Handle3()
    {
        Console.WriteLine("EstadoConcretoManual capta a terceira requisição");
    }
}