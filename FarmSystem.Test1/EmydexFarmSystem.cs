using FarmSystem.Test2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private List<Animal> Animals {get; set;}
        private int counter;

        public EmydexFarmSystem()
        {
            Animals = new List<Animal>();
            counter = 1;
        }

        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");

            Animal newAnimal = (Animal)animal;
            newAnimal._ordinal = counter++;
            Animals.Add(newAnimal);
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach(var animal in Animals.OrderBy(a => a._ordinal))
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in Animals.OrderBy(a => a._ordinal))
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }

            //Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            CheckIfFarmIsEmpty();

            foreach (var animal in Animals.OrderBy(a => a._ordinal))
            {
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
                Animals.Remove(animal);
            }

            CheckIfFarmIsEmpty();

            //Console.WriteLine("There are still animals in the farm, farm is not free");
        }

        private void CheckIfFarmIsEmpty()
        {
            if (!Animals.Any())
            {
                Console.WriteLine("Emydex Farm is now empty");
            }
        }

    }
}