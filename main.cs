using System;
using System.Collections.Generic;

class Program {

  static List<Sessao> sessoes = new List<Sessao>();
  static List<Filme> filmes = new List<Filme>();

  public static void CadastrarSessao(int opt){
    
  }
  
  public static void SelecionarSessao(int selected){
    Console.WriteLine("1 - Cadastrar Sessao");
    List<Sessao> filtrado = sessoes.FindAll(e => e.filmes.titulo == filmes[selected].titulo);
    for(int i = 0; i < filtrado.Count; i++){
      Console.WriteLine((i + 2) + " - " + filtrado[i].filmes.titulo + " | " + filtrado[i].horSessao.Hours + ":" + filtrado[i].horSessao.Minutes);
    }
    Console.Write("Selecione uma opção: ");
    int opt = int.Parse(Console.ReadLine());
  }
  
  public static void SelecionarFilme(){
    if(filmes.Count == 0){
      Console.WriteLine("Nenhum filme cadastrado!");
      return;
    }
    for(int i = 1; i <= filmes.Count; i++){
      Console.WriteLine(i + " - " + filmes[i-1].titulo);
    }
    Console.Write("Selecione o filme: ");
    int opt = int.Parse(Console.ReadLine());
    if(opt > 0 || opt <= filmes.Count){
      SelecionarSessao(opt-1);
    }
    else{
      Console.WriteLine("Erro ao ler opção de filme da opcao" + opt);
    }
  }

  public static Filme CadastrarFilme(){
    Console.WriteLine("Genero do filme: ");
    Genero genero = new Genero(Console.ReadLine());
    Console.WriteLine("Titulo do filme: ");
    String titulo = Console.ReadLine();
    Console.WriteLine("Duração do filme: ");
    TimeSpan time = TimeSpan.Parse(Console.ReadLine());
    Filme filme = new Filme(titulo, time);
    filme.generoFilme = genero;
    List<Atua> atores = new List<Atua>();
    Console.WriteLine("Numero de atores: ");
    int num = int.Parse(Console.ReadLine());
    for(int i = 0; i < num; i++){
      Console.WriteLine("Digite o nome do ator " + (i + 1) + ": ");
      String nomeAtor = Console.ReadLine();
      Console.WriteLine("Digite o papel do ator " + (i + 1) + ": ");
      String papelAtor = Console.ReadLine();
      Atua atua = new Atua(papelAtor, nomeAtor);
      filme.addAtor(atua);
    }
    filme.conFilme();
    return filme;
  }

  public static Cliente CadastrarCliente(){
    Console.WriteLine("Nome do Cliente: ");
    string nome = Console.ReadLine();
    Console.WriteLine("CPF: ");
    long cpf = long.Parse(Console.ReadLine());
    Console.WriteLine("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Cliente cliente = new Cliente(cpf, nome, idade);
    return cliente;
  }
  
  public static void Main (string[] args) {

    bool rodando = true;
    
    while(rodando){
      int opt = 0;
      Console.WriteLine("1 - Selecionar filme");
      Console.WriteLine("2 - Cadastrar filme");
      Console.WriteLine("3 - Cadastrar cliente");
      Console.WriteLine("0 - Sair");
      Console.Write("Digite: ");

      try {
        opt = int.Parse(Console.ReadLine());
      } catch {
        Console.WriteLine("Opção invalida.");
      }
      switch(opt){
        case 0:
          rodando = false;
          break;
        case 1:
          SelecionarFilme();
          break;
        case 2:
          try{
            filmes.Add(CadastrarFilme());
          } catch(Exception e){
            Console.WriteLine("Erro ao cadastrar filme");
          }
          break;
        case 3:
          try{
            CadastrarCliente();
          } catch(Exception e){
            Console.WriteLine("Erro ao cadastrar cliente");
          }
          break;
        default:
          Console.WriteLine("Opção invalida.");
          break;
      }
    }
 
  }

  /*
   long cpf = 13126470009;
  Funcionario funcionario = new Funcionario(1234, "Teste");
    
  Cliente cliente1 = funcionario.cadastrarCliente(cpf,"Italo",22);
    
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
  
  Sessao sessao = new Sessao(new DateTime(2022, 6, 1), false,new TimeSpan(18, 00, 00), "Português", 45.00, 27.50, new Sala(10, 300),funcionario, filme1);

    funcionario.venderIngresso(1, cliente1, sessao);
    
    funcionario.consultarSessao(sessao, filme1);  
*/
}