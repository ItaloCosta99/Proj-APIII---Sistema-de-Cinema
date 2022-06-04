using System;

public class Sala {
  public int numSala {get; set;}
  public int capacidade {get; set;}

    public Sala(int numSala, int capacidade)
    {
        this.numSala = numSala;
        this.capacidade = capacidade;
    }

    public Sala()
    {
    }

    public void conSala() {
    Console.WriteLine("Nº da Sala:" + this.numSala + "\n" + "Capacidade: " + this.capacidade);
  }
}