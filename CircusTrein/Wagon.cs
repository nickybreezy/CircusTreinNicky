using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    public class Wagon
    {
        List<Animal> AnimalLijst { get; } = new List<Animal>();

        private int capaciteit = 10;
        public void AddDier(Animal animal)
        {
            if (KanDierToegevoegdWorden(animal) == true)
            {
                AnimalLijst.Add(animal);
            }


        }

        public int GetPoints()
        {
            int points = 0;
            foreach (Animal animal in AnimalLijst)
            {
                points += animal.CheckDierenPunt();
            }
            return points;
        }

        public override string ToString()
        {
            int value = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Animal animal in AnimalLijst)
            {
                stringBuilder.Append(animal.GetInfo() + " | " + "\n");
                value += (int)animal.CheckDierenPunt();
            }
            stringBuilder.AppendLine(" ");
            stringBuilder.Append($"wagon value = {value}");
            return stringBuilder.ToString();

        }

        public bool KanDierToegevoegdWorden(Animal animal)
        {
            if (AnimalLijst.Count == 0)
            {
                return true;
            }
            else
            {
                int huidigeCapaciteit = GetPoints();
                int dierGrootte = animal.CheckDierenPunt();

                if (huidigeCapaciteit + dierGrootte <= capaciteit)
                {
                    foreach (Animal a in AnimalLijst)
                    {
                        if (a.BenIkEetbaar(animal))
                        {

                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                } 
                else
                {
                    return false;
                }
                
            }

            return false;
        }

        public object GetDieren()
        {
            throw new NotImplementedException();
        }
    }
}

