using System;
using System.Collections.Generic;
using System.Globalization;

public class Sessao {
  public DateTime dtSessao {get;set;}
  public bool encerrada {get;set;}
  public TimeSpan horSessao {get; set;}
  public string indicadorDublado {get; set;}
  public double valorInteira {get; set;}
  public double valorMeia {get; set;}
  public Sala salas {get; set;}
  public List<Ingresso> ingressos {get; set;}
  public Funcionario funcionarios {get; set;}
  public Filme filmes {get; set;}
  
    public Sessao(DateTime dtSessao, TimeSpan horSessao, string indicadorDublado, double valorInteira, Sala salas, Funcionario funcionarios, Filme filmes)
    {
        this.dtSessao = dtSessao;
        this.encerrada = false;
        this.horSessao = horSessao;
        this.indicadorDublado = indicadorDublado;
        this.valorInteira = valorInteira;
        this.valorMeia = valorInteira/2;
        this.salas = salas;
        this.ingressos = new List<Ingresso>();
        this.funcionarios = funcionarios;
        this.filmes = filmes;
    }

    public Sessao()
    {
    }

    public void selSessao() {
    Console.WriteLine($"Data: {this.dtSessao.ToString("dd/MM/yyyy")}.");
    Console.WriteLine($"Status: {(this.encerrada ? "Encerrada" : "Aberta")}.");
    Console.WriteLine($"Hora da Sessão: {this.horSessao.Hours}h{this.horSessao.Minutes}m.");
    Console.WriteLine($"Dublado: {this.indicadorDublado}.");
    Console.WriteLine($"Inteira: {this.valorInteira.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}.");
    Console.WriteLine($"Meia: {this.valorMeia.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}.");
    Console.WriteLine($"Sala Nº: {this.salas.numSala}.");
    Console.WriteLine($"Capacidade: {this.salas.capacidade} lugares.");
    Console.WriteLine("Ingressos vendidos: " + ingressos.Count);
  }

}