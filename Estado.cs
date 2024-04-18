abstract class Estado
{
    protected Contexto _context;

    public void SetContext(Contexto context)
    {
        this._context = context;
    }

    public abstract void Handle1();

    public abstract void Handle2();
}