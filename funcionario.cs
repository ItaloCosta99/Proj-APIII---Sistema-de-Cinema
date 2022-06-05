using System;
using static Cliente;
using static Sessao;
using static Filme;

public class Funcionario {
  public int matricula {get; set;}
  public string nome {get; set;}

  public Funcionario(int matricula, String nome){
    this.matricula = matricula;
    this.nome = nome;
  }

    public Funcionario()
    {
    }

    public void venderIngresso(int tipo, Cliente cliente, Sessao sessao){
    sessao.ingressos.Add(new Ingresso(tipo, this, cliente));
    Console.WriteLine("Ingresso vendido para " + cliente.nome + "\n");
  }
  
  public void consultarSessao(Sessao sessao, Filme filme) {
    sessao.selSessao();
    filme.conFilme();
  }
  
  public Cliente cadastrarCliente(long cpf, String nome, int idade){
    Cliente cliente = new Cliente(cpf, nome, idade);
    return cliente;
  }
}