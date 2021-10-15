using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cukraszda
{
  public partial class Form1 : Form
  {
    List<Sutemeny> lista = new List<Sutemeny>();
    List<Kaphato> suti = new List<Kaphato>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Beolvasas();
      Veletlen();
      DijazottSutik();
      Kiiras();
      Legolcsobb();
      Legdragabb();


      tbDb1.Text = "18400 Ft/24 szeletes";
      tbDb2.Text = "250 Ft/24 szeletes";
    }

    private void Legdragabb()
    {
      
    }

    private void Legolcsobb()
    {
      int ar = int.MaxValue;
      string nev = "";
      for (int i = 0; i < lista.Count; i++)
      {
        if (lista[i].Ar < ar)
        {
          nev = lista[i].Nev;
          ar = lista[i].Ar;
        }
      }
      tbOlcso.Text = $"{nev}";
    }

    private void DijazottSutik()
    {
      int dija = 0;
      foreach (var l in lista)
      {
        if (l.Dij)
        {
          dija++;
        }
      }
      tbEdesseg.Text = $"{dija} féle díjnyertes édességből választhat.";
    }

    private void Kiiras()
    {
      string ki;
      foreach (var s in suti)
      {
        ki = s.Nev + " " + s.Tipus;
      }

    }

    private void Veletlen()
    {
      Random rnd = new Random();
      int ker = rnd.Next(lista.Count); 
      tbRandom.Text = $"Mai ajánlatunk: {lista[ker].Nev}";
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("cuki.txt");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        lista.Add(new Sutemeny(a[0], a[1], Convert.ToBoolean(a[2]), Convert.ToInt32(a[3]), a[4]));
      }
    }
  }
}
