using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cukraszda
{
  class Kaphato
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

    public Kaphato(string nev, string tipus)
    {
      this.nev = nev;
      this.tipus = tipus;
    }
  }
}
