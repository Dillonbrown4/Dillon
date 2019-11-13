using System;

class BostonZoo {
 //these are the objects
 public struct Animal{
   public string name;
   public string species;
   public int age;
   public string breakfast_hour;
   public string dinner_hours;



  }
  public struct Zone{
    public string Attendents_Name;
    public int Num_Animals;




  }

//this tells us what the objects are
  public static void Main (){



    Zone Bird = new Zone();
    Bird.Attendents_Name = "Kevin James";
    Bird.Num_Animals = 3;

    Animal Parrot = new Animal();
    Parrot.name = "Steve";
    Parrot.species = "Sun Conure";
    Parrot.age = 5;
    Parrot.breakfast_hour = "11:00 A.M";
    Parrot.dinner_hours = "8:00 P.M";

    Animal Raven = new Animal();
    Raven.name = "Deadshot";
    Raven.species =  "Pied Raven";
    Raven.age = 11;
    Raven.breakfast_hour = "4:00 A.M";
    Raven.dinner_hours = "12:00 P.M";

    Animal Owl = new Animal();
    Owl.name = "Night";
    Owl.species = "Barred Owl";
    Owl.age = 13;
    Owl.breakfast_hour = "2:00 A.M";
    Owl.dinner_hours = "7:00 P.M";


    Console.WriteLine(" \n BIRDS ZONE");
    Console.WriteLine("Cleaners Name: " + Bird.Attendents_Name);
    Console.WriteLine("How many Birds in zone: " + Bird.Num_Animals + "\n");

   Console.WriteLine("Parrot name:" + Parrot.name);
   Console.WriteLine("Parrot species: " + Parrot.species);
   Console.WriteLine("Parrot age: " + Parrot.age);
   Console.WriteLine("Parrot breakfast: " + Parrot.breakfast_hour);
   Console.WriteLine("Parrot dinner: " + Parrot.dinner_hours + "\n");


   Console.WriteLine("Raven name:" + Raven.name);
   Console.WriteLine("Raven species: " + Raven.species);
   Console.WriteLine("Raven age: " + Raven.age);
   Console.WriteLine("Raven breakfast: " + Raven.breakfast_hour);
   Console.WriteLine("Raven dinner: " + Raven.dinner_hours + "\n");

   Console.WriteLine("Owl name:" + Owl.name);
   Console.WriteLine("Owl species: " + Owl.species);
   Console.WriteLine("Owl age: " + Owl.age);
   Console.WriteLine("Owl breakfast: " + Owl.breakfast_hour);
   Console.WriteLine("Owl dinner: " + Owl.dinner_hours + "\n");




    Zone Reptile = new Zone();
    Reptile.Attendents_Name = "Adam Sandler";
    Reptile.Num_Animals = 3;

    Animal Lizzard = new Animal();
    Lizzard.name = "Buddy";
    Lizzard.species = "Frilled-Neck Lizzard";
    Lizzard.age = 11;
    Lizzard.breakfast_hour = "9:00 A.M";
    Lizzard.dinner_hours = "5:00 P.M";

    Animal Snake = new Animal();
    Snake.name = "Copper";
    Snake.species = "Copper head";
    Snake.age = 7;
    Snake.breakfast_hour = "11:00 A.M";
    Snake.dinner_hours = "8:00 P.M";

    Animal Turtle = new Animal();
    Turtle.name = "Crush";
    Turtle.species = "Green Sea";
    Turtle.age = 107;
    Turtle.breakfast_hour = "10:00 A.M";
    Turtle.dinner_hours = "8:00 P.M";

    Console.WriteLine("REPTILES ZONE");
    Console.WriteLine("Cleaners name: "+ Reptile.Attendents_Name);
    Console.WriteLine("How many Reptiles in zone: " + Reptile.Num_Animals + "\n");

   Console.WriteLine("Lizzard name: " + Lizzard.name);
   Console.WriteLine("Lizzard species: " + Lizzard.species);
   Console.WriteLine("Lizzard age: " + Lizzard.age);
   Console.WriteLine("Lizzard breakfast: " + Lizzard.breakfast_hour);
   Console.WriteLine("Lizzard dinner: " + Lizzard.dinner_hours + "\n");

   Console.WriteLine("Snake name: " + Snake.name);
   Console.WriteLine("Snake species: " + Snake.species);
   Console.WriteLine("Snake age: " + Snake.age);
   Console.WriteLine("Snake breakfast: " + Snake.breakfast_hour);
   Console.WriteLine("Snake dinner: " + Snake.dinner_hours + "\n");

   Console.WriteLine("Turtle name: " + Turtle.name);
   Console.WriteLine("Turtle species: " + Turtle.species);
   Console.WriteLine("Turtle age: " + Turtle.age);
   Console.WriteLine("Turtle breakfast: " + Turtle.breakfast_hour);
   Console.WriteLine("Turtle dinner: " + Turtle.dinner_hours + "\n");


    Zone Mammals = new Zone();
    Mammals.Attendents_Name = "Chris Rock";
    Mammals.Num_Animals = 3;

    Animal Gorilla = new Animal();
    Gorilla.name = "Harambe";
    Gorilla.species = "Eastern Gorilla";
    Gorilla.age = 3;
    Gorilla.breakfast_hour = "10:00 A.M";
    Gorilla.dinner_hours = "9:00 P.M";

    Animal Lion = new Animal();
    Lion.name = "Derek";
    Lion.species = "Panthera leo";
    Lion.age = 12;
    Lion.breakfast_hour = "8:00  A.M";
    Lion.dinner_hours = " 7:45 P.M";




    Animal Monkey = new Animal();
    Monkey.name = "Marcel";
    Monkey.species = "Primate";
    Monkey.age = 2;
    Monkey.breakfast_hour = "7:30 A.M";
    Monkey.dinner_hours = "7:30 P.M";




     Console.WriteLine("MAMMALS ZONE");
    Console.WriteLine("Cleaners Name: " + Mammals.Attendents_Name);
    Console.WriteLine("How many Mammals in zone: " + Mammals.Num_Animals + "\n");

    Console.WriteLine("Gorilla name: " + Gorilla.name);
    Console.WriteLine("Gorilla species: " + Gorilla.species);
    Console.WriteLine("Gorilla age: " + Gorilla.age);
    Console.WriteLine("Gorilla breakfast: " + Gorilla.breakfast_hour);
    Console.WriteLine("Gorilla dinner: " + Gorilla.dinner_hours + "\n");

    Console.WriteLine("Lion name: " + Lion.name);
    Console.WriteLine("Lion age: " + Lion.age);
    Console.WriteLine("Lion breakfast: " + Lion.breakfast_hour);
    Console.WriteLine("Lion dinner: " + Lion.dinner_hours + "\n");
    Console.WriteLine("Monkey name: " + Monkey.name);
    Console.WriteLine("Monkey species: " + Monkey.species);
    Console.WriteLine("Monkey age: " + Monkey.age);
    Console.WriteLine("Monkey breakfast: " + Monkey.breakfast_hour);
    Console.WriteLine("Monkey dinner: " + Monkey.dinner_hours + "\n");
  }
}
