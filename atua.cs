using System;
using static Ator;

public class Atua {
  public string papel {get; set;}
  public Ator ator {get; set;}

    public Atua(string papel, String ator)
    {
        this.papel = papel;
        this.ator = new Ator(ator);
    }

    public Atua()
    {
    }
}