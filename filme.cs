using System;
using static Genero;
using static Atua;
using System.Collections.Generic;

public class Filme {
  public string titulo {get; set;}
  public TimeSpan duracao {get; set;}
  public Genero generoFilme {get; set;}
  public List<Atua> atua {get; set;}

  public Filme(String titulo, TimeSpan duracao){
    this.titulo = titulo;
    this.duracao = duracao;
    this.atua = new List<Atua>();
  }

  public Filme()
  {
    
  }

  public void conFilme() {
    Console.WriteLine($"\nTitulo: {this.titulo}.\nDuração: {this.duracao.Hours}h{this.duracao.Minutes}m{this.duracao.Seconds}s.\nDescrição: {this.generoFilme.descricao}.\nAtores: ");
    foreach (Atua ator in this.atua)
    {
      Console.WriteLine($"{ator.papel} ({ator.ator.nome}).");
    }
  }

  public void addAtor(Atua papel){
    this.atua.Add(papel);
  }
  
}