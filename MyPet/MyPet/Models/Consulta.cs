using System.ComponentModel.DataAnnotations;

namespace MyPet.Models;

public class Consulta
{
    public int Id { get; set; }

    [Display(Name ="Nome Completo")]
    public string? Nome { get; set; }

    [Display(Name ="Nome do Pet")]
    public string? NomeDoPet { get; set; }

    [Display(Name = "Tipo do seu pet")]
    public TipoPet TipoPet { get; set; }

    [DataType(DataType.Date), Display(Name ="Data da consulta")]
    public DateTime DataConsulta { get; set; }

    [DataType(DataType.Time), Display(Name = "Hora da consulta")]
    public DateTime HoraConsulta { get; set; }

    [Display(Name ="Escolha o tipo de pagamento")]
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

