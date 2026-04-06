using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrijemeApp {
  public class VrijemePodatak {
    public VrijemePodatak(string grad, string temperatura, string vlaga, string tlak) {
      Grad = grad;
      Temperatura = double.Parse(PripremiString(temperatura));
      Vlaga = int.Parse(PripremiString(vlaga));
      Tlak = double.Parse(PripremiString(tlak));
    }

    public override string ToString() {
      // $ - string interpolation
      // @ - verbatim string
      return $@"{Grad}, {TemperaturaZaPrikaz}";
    }

    private string PripremiString(string unos) {
      return unos.Replace("*", "").Replace("-", "0").Replace(".", ",");
    }

    public string Grad { get; set; }
    public double Temperatura { get; set; }

    public string TemperaturaZaPrikaz { get => $"{Temperatura} °C"; }
                                     // get { return Temperatura + "° C"; }
    public int Vlaga { get; set; }
    public string VlagaZaPrikaz { get => $"{Vlaga} %"; }
    public double Tlak { get; set; }
    public string TlakZaPrikaz { get => $"{Tlak} hPa"; }
  }
}
