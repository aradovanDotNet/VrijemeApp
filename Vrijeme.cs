using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VrijemeApp {
  public class Vrijeme {
    public Vrijeme() {
      // TODO: rukovanje s iznimkama
      podaci = DohvatiPodatke();
    }

    public List<VrijemePodatak> DohvatiPodatke() {
      XmlDocument vrijeme = new XmlDocument();
      vrijeme.Load("http://vrijeme.hr/hrvatska_n.xml");

      List<VrijemePodatak> podaci = new List<VrijemePodatak>();

      XmlNodeList gradovi = vrijeme.GetElementsByTagName("Grad");
      foreach (XmlNode grad in gradovi) {
        podaci.Add(new VrijemePodatak(
            grad["GradIme"].InnerText,
            grad["Podatci"]["Temp"].InnerText,
            grad["Podatci"]["Vlaga"].InnerText,
            grad["Podatci"]["Tlak"].InnerText
        ));
      }
      return podaci;
    }

    public IEnumerable<string> DohvatiGradove() {
      // TODO:
      return
        null;
    }

    public VrijemePodatak DohvatiPodatkeZaGrad(string grad) {
      // TODO:
      return
        null;
    }

    public IEnumerable<VrijemePodatak> DohvatiNajtoplijeGradove(int kolicina) {
      // TODO:
      return
        null;
    }

    public IEnumerable<VrijemePodatak> DohvatiNajhladnijeGradove(int kolicina) {
      // TODO:
      return
        null;
    }

    private List<VrijemePodatak>? podaci;
  }
}
