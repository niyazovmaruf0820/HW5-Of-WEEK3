System.Console.WriteLine("Dog's name :");
string Nameofdog = Console.ReadLine();
Dog dog1 = new Dog();
dog1.SetName(Nameofdog);
System.Console.Write(Nameofdog + " ");
dog1.Eat();