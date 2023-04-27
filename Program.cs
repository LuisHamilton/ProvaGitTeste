public class BranchMaster
{
    public string? Nome { get; set; }
    public int Numero { get; set; }
    public float Dinheiro { get; set; }
}

public class BranchGalho1
{
    public string? Tipo { get; set; }
    public int Valor { get; set; }
    public bool Ativo { get; set; }
    public DateTime Atualizado { get; set; }
}