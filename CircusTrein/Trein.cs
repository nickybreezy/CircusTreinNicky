using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrein
{
    public class Trein
    {
        List<Wagon> wagonlist = new List<Wagon>();
        public void SorteerEnToevoegenAanWagons(List<Animal> animals)
        {
            if (wagonlist.Count() == 0)
            {
                wagonlist.Add(new Wagon());
            }
            foreach (var animal in animals)
            {            
                bool isDierAlToegevoegd = false;
                foreach (var w in wagonlist)
                {
                    if (w.KanDierToegevoegdWorden(animal) == true)
                    {
                        w.AddDier(animal);
                        isDierAlToegevoegd = true;
                    }
                }

                if (isDierAlToegevoegd == false)
                {
                    wagonlist.Add(new Wagon());
                    wagonlist.Last().AddDier(animal);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(" ");
            foreach(Wagon wagon in wagonlist)
            {
                stringBuilder.AppendLine("\n");
                stringBuilder.AppendLine("◻◻◻◻◻◻◻◻◻◻◻◻◻");
                stringBuilder.AppendLine(wagon.ToString());
                stringBuilder.AppendLine("◻◻◻◻◻◻◻◻◻◻◻◻◻");
            }
            return stringBuilder.ToString();
            
        }
        public List<Wagon> GetWagons()
        {
            return wagonlist;
        }
      

    }
}
