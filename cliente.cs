using System;

public class Cliente {
  public long cpf {get; set;}
  public string nome {get; set;}
  public int idade {get; set;}

  public Cliente(long cpf, String nome, int idade){
    this.cpf = cpf;
    this.nome = nome;
    this.idade = idade;
  }

    public Cliente()
    {
    }
}