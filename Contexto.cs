class Contexto
{
    private Estado _state = null;

    public Contexto(Estado estado)
    {
        this.TransitionTo(estado);
    }

    public void TransitionTo(Estado state)
    {
        Console.WriteLine($"\nContexto: Transicionando para {state.GetType().Name}.");
        this._state = state;
        this._state.SetContext(this);
    }

    public void RequestAll()
    {
        _state.Handle1();
        _state.Handle2();
        _state.Handle3();
    }

    public void ShowMenu()
    {
        if (_state is EstadoConcretoPendente)
        {
            Console.WriteLine("\nDigite a opção desejada");
            Console.WriteLine("1 - Pendente -> Inconsistente");
            Console.WriteLine("2 - Pendente -> Erro de Importação");
            Console.WriteLine("3 - Pendente -> Importado");
            Console.Write("\nOpção: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int opcao))
            {
                EscolhaOpcao(opcao);
                
                RequestAll();
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, insira um número válido.");
            }
        }
    }
    private void EscolhaOpcao(int opcao)
    {
        if (opcao == 1)
        {
            Request1();
        }
        else if (opcao == 2)
        {
            Request2();
        }
        else if (opcao == 3)
        {
            Request3();
        }
    }

    public void Request1()
    {
        this._state.Handle1();
    }

    public void Request2()
    {
        this._state.Handle2();
    }

    public void Request3()
    {
        this._state.Handle3();
    }
}