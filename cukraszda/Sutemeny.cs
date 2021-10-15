using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cukraszda
{
  class Sutemeny
  {
    private string nev;
      
    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }
    private string tipus;

    public string Tipus
    {
      get { return tipus; }
      set { tipus = value; }
    }
    private bool dij;

    public bool Dij
    {
      get { return dij; }
      set { dij = value; }
    }
    private int ar;

    public int Ar
    {
      get { return ar; }
      set { ar = value; }
    }
    private string ertekesit;

    public string Ertekesit
    {
      get { return ertekesit; }
      set { ertekesit = value; }
    }

    public Sutemeny(string nev, string tipus, bool dij, int ar, string ertekesit)
    {
      this.nev = nev;
      this.tipus = tipus;
      this.dij = dij;
      this.ar = ar;
      this.ertekesit = ertekesit;
    }
  }
}
