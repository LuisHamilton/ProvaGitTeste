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
}

public class BranchGalho2
{
    public string? Funcao { get; set; }
    public int Posicao { get; set; }
    public DateTime Data { get; set; }
    public string? Local { get; set; }
    public int Salario { get; set; }
}