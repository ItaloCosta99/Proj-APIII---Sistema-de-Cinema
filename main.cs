using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
  long cpf = 13126470009;
  Cliente cliente1 = new Cliente(cpf,"Italo",22);
    
  Funcionario funcionario = new Funcionario(1234, "Teste");
    
  Ingresso ingresso1 = new Ingresso(1, funcionario, cliente1);
  List<Ingresso> listaIngressos = new List<Ingresso>();
  listaIngressos.Add(ingresso1);
  

  Ator ator1 = new Ator("Daniel Radcliffe");
  Ator ator2 = new Ator("Emma Watson");
  Atua papel1 = new Atua("Harry Potter", ator1);
  Atua papel2 = new Atua("Hermione Granger", ator2);
  List<Atua> listaDeAtores = new List<Atua>();
    
  Genero genero1 = new Genero("Ação, Ficção, Aventura");
  Filme filme1 = new Filme("Harry Porter",new TimeSpan(02, 00, 00), genero1, listaDeAtores);

  filme1.addAtor(papel1);
  filme1.addAtor(papel2);
  
  Sessao sessao = new Sessao(new DateTime(2022, 6, 1), false,new TimeSpan(18, 00, 00), "Português", 45.00, 27.50, new Sala(10, 300),listaIngressos ,funcionario, filme1);
    
    funcionario.consultarSessao(sessao, filme1);
  }
}