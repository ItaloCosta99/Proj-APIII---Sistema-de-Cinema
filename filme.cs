using System;
using static Genero;
using static Atua;
using System.Collections.Generic;

public class Filme {
  public string titulo {get; set;}
  public TimeSpan duracao {get; set;}
  public Genero generoFilme {get; set;}
  public List<Atua> atua {get; set;}

  public Filme(String titulo, TimeSpan duracao, Genero genero, List<Atua> atores){
    this.titulo = titulo;
    this.duracao = duracao;
    this.generoFilme = genero;
    this.atua = atores;
  }

  public Filme()
  {
    
  }

  public void conFilme() {
    Console.WriteLine("Titulo: " + this.titulo + "\n"+
                      "Duração: " +  this.duracao + "\n" + "Descrição: " + this.generoFilme.descricao + "\n" + "Atores: ");
    foreach (Atua ator in this.atua)
    {
      Console.WriteLine($"{ator.papel} ({ator.ator.nome})");
    }
  }

  public void addAtor(Atua papel){
    this.atua.Add(papel);
  }
  
}