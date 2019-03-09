using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    

    class Planet
    {
        //Lists
        private static List<object>listOfPlanets = new List<object>();
        private static List<object>meanTemperetures = new List<object>();
        private static List<object>diameterList = new List<object>();

        private string name;
        private float mass;
        private float diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemp;
        private double numberOfMoons;
        private bool ringSystem;

        //Properties
        #region Get/set

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public float Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public int Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }

        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }

        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;
            }
        }

        public double DistanceToSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }

        public double OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                orbitalVelocity = value;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;
            }
        }

        public double MeanTemp
        {
            get
            {
                return meanTemp;
            }
            set
            {
                meanTemp = value;
            }
        }

        public double NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;
            }
        }

        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                ringSystem = value;
            }
        }

        #endregion
        public Planet()
        {
        }

        //Constructor
        public Planet(string name,float mass,float diameter,int density,double gravity,double rotationPeriod,double lengthOfDay,double distanceFromSun,double orbitalPeriod,double orbitalVelocity,
            double meanTemp,double numberOfMoons,bool ringSystem)
        {
            this.name = name;
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotationPeriod = rotationPeriod;
            this.lengthOfDay = lengthOfDay;
            this.distanceFromSun = distanceFromSun;
            this.orbitalPeriod = orbitalPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.meanTemp = meanTemp;
            this.numberOfMoons = numberOfMoons;
            this.ringSystem = ringSystem;
            
        }
        //Method that returns a list to main
        public static List<object>getList()
        {
            return listOfPlanets;
        }
       
        //here we add all the plantes to the list (listOfPlanets)
        public void AddPlanets()
        {
            Planet mercury = new Planet("Mercury", 0.330f, 4879f, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet earth = new Planet("Earth", 5.97f, 12756f, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars", 0.642f, 6792f, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter", 1898f, 142.984f, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn", 568f, 120536f, 687, 9, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus", 86.8f, 51118f, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
            Planet neptune = new Planet("Neptune", 102f, 49528f, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto", 0.0146f, 2370f, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            listOfPlanets.Add(mercury);
            listOfPlanets.Add(earth);
            listOfPlanets.Add(mars);
            listOfPlanets.Add(jupiter);
            listOfPlanets.Add(saturn);
            listOfPlanets.Add(uranus);
            listOfPlanets.Add(neptune);
            listOfPlanets.Add(pluto);
        }

        //Here we add venus to the list on index 1
        public void InsertVenus()
        {
            Planet venus = new Planet("Venus", 4.87f, 12104f, 5243, 8.9, -5832.5, 2802, 108.2, 224.7, 35, 464, 0, false);
            listOfPlanets.Insert(1, venus);
        }
        //Remove pluto

        public void RemovePluto()
        {

            listOfPlanets.RemoveAt(8);
        }
        //Insert pluto
        public void Insertpluto()
        {
            Planet pluto = new Planet("Pluto", 0.0146f, 2370f, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);
            listOfPlanets.Insert(8, pluto);
        }

        //Elements in the list
        public int AmountOfElements()
        {
            return listOfPlanets.Count();
        }

        public static List<object> Meanlist()
        {
            return meanTemperetures;
        }
      
        //Find mean temperature under 0
        public void MeanTempereture()
        {

            foreach (Planet item in listOfPlanets)
            {
                if (item.meanTemp < 0)
                {
                    meanTemperetures.Add(item);
                }
            }
        }

        
        public static List<object> Diameterlist()
        {
            return diameterList;
        }
        
        //Find all the planets with a diameter between 10000 - 50000
        public void Dia()
        {
            foreach (Planet item in listOfPlanets)
            {
                if (item.diameter > 10000 && item.diameter < 50000)
                {
                    diameterList.Add(item);
                }
                
            }
        }
        
        public void RemoveAll()
        {
            listOfPlanets.Clear();
        }
    }
}
