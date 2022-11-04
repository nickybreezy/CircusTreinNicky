namespace CircusTrein
{
    public class Animal
    {
        private AnimalType dierType;
        private bool eetDieren;
        private int punt;

        public AnimalType DierType { get { return dierType; } set { dierType = value; } }
        public Animal(bool Eetdieren, AnimalType animalType)
        {
            eetDieren = Eetdieren;
            dierType = animalType;
        }
        public bool EetDieren()
        {
            if (eetDieren)
            {
                return true;
            }
            else
                return false;
        }

        public bool BenIkEetbaar(Animal animal)
        {
            {
                if (animal.EetDieren() && !this.EetDieren())
                {
                    if (animal.CheckDierenPunt() <= this.CheckDierenPunt())
                    {
                        return false;
                    }
                }
                else if (!animal.EetDieren() && this.EetDieren())
                {
                    if (this.CheckDierenPunt() <= animal.CheckDierenPunt())
                    {
                        return false;
                    }
                }
                else if (!animal.EetDieren() && !this.EetDieren())
                {                   
                        return false;                    
                }
                return true;
            }
        }
            public int CheckDierenPunt()
            {
                if (dierType == AnimalType.klein)
                {
                    punt = 1;
                }
                else if (dierType == AnimalType.middelgroot)
                {
                    punt = 3;
                }
                else if (dierType == AnimalType.groot)
                {
                    punt = 5;
                }
                return punt;
            }
            public string GetInfo()
            {
                if (eetDieren)
                {
                    return $"Deze wagon bezit  {this.dierType}e dier die dieren eet";
                }
                else
                {
                    return $"Deze wagon bezit een {this.dierType} dier die gelukkig geen dieren eet";
                }

            }


        }



    }
