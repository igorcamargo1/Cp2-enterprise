using System.ComponentModel.DataAnnotations;

namespace MyPet.Models;

public class Consulta
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? NomeDoPet { get; set; }

    public TipoPet TipoPet { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataConsulta { get; set; }

    [DataType(DataType.Time)]
    public DateTime HoraConsulta { get; set; }

    public TipoPagamento TipoPagamento { get; set; }

}

public enum TipoPet
{
    Cachorro, Gato, Pássaro, Peixe, Outros
}

public enum TipoPagamento
{
    Cartão, Dinheiro, Pix
}

