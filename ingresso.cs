using System;

public class Ingresso {
  public int tipo {get; set;}
  public Funcionario func {get; set;}
  public Cliente cliente {get; set;}

  public Ingresso(int tipo, Funcionario func, Cliente cliente){
    this.tipo = tipo;
    this.func = func;
    this.cliente = cliente;
  }

  public Ingresso()
  {
  }

    public void getIngresso() {
    Console.WriteLine("tipo: " + tipo);
    Console.WriteLine("cliente: " + cliente.nome);
    Console.WriteLine("funcionario: " + func.nome);
  }
}