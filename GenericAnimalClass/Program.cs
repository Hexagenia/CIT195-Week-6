using System;

namespace GenericAnimalClass
{
    class Animal<T>
    {
        private T data;

        // Constructor
        public Animal(T animalData)
        {
            data = animalData;
        }

        // Getter
        public T GetAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Animal objects
            Animal<string> animalName = new Animal<string>("Persian Cat");
            Animal<string> animalHabitat = new Animal<string>("Human house");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);


                //12-17 years
                Animal<int> averageLifespan = new Animal<int>(15);

            // Print print values from GetAnimal
            Console.WriteLine("Animal Name: " + animalName.GetAnimal());

            Console.WriteLine("Animal Habitat: " + animalHabitat.GetAnimal());

            Console.WriteLine("Endangered: " + endangered.GetAnimal());

            Console.WriteLine("Extinct: " + extinct.GetAnimal());

            Console.WriteLine("Average Lifespan: " + averageLifespan.GetAnimal() + " years");
        }
    }
}
