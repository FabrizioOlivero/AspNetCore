class Apple {
    public string Color { get; set; }
    public int Weight { get; set; }
}

List<Apple> apples = new List<Apple>{
    new Apple{Color = "Red", Weight=180},
    new Apple{Color = "Green", Weight=195},
    new Apple{Color = "Red", Weight=190},
    new Apple{Color = "Green", Weight=185},
};

//Func<Apple, bool> takeRedApples = apple => apple.Color=="Red";
IEnumerable<Apple> redApples = apples.Where(apple => apple.Color=="Red");
IEnumerable<int> weightOfRedApples = apples
                            .Where(apple => apple.Color=="Red")
                            .Select(apple => apple.Weight);

double average = weightOfRedApples.Average();
Console.WriteLine();

// Mela con il peso minimo
int pesoMin = apples.Select(apples=>apples.Weight).Min();
Console.WriteLine("La mela con il peso minimo è: " + pesoMin.ToString());

//  Colore mela che pesa 190 grammi
IEnumerable<string> colore = apples
                    .Where(apple => apple.Weight==190)
                    .Select(apple => apple.Color);
Console.WriteLine("Il colore della mela con il peso 190 è: " + colore);
    
// Numero mele rosse
int numeroMeleRosse = apples.Where(apple=> apple.Color=="Red").Count();
Console.WriteLine("Il numero delle mele rosse è: " + numeroMeleRosse.ToString());

// Peso totale mele verdi
int pesoTotale = apples
                    .Where(apple=>apple.Color=="Green")
                    .Select(apple=>apple.Weight).Sum();
Console.WriteLine("Il peso totale delle mele verdi è: " + pesoTotale.ToString());
