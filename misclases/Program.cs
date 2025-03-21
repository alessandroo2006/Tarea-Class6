using clas6;
using clas6.misclases;

Console.WriteLine("Carro Electrico");
carroElectrico miMazda = new carroElectrico(2006, "M3", "Negro");
miMazda.InformacionVehiculo();
Console.WriteLine("la carga de la bateria del carro electrico es:" + miMazda.verNivelBateria());
Console.WriteLine("Es necesario que lo pongas a cargar lo antes posible");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Auto de Combustible");
AutoDeCombustión miKia = new AutoDeCombustión(2018, "kia spord", "blanco");
miKia.InformacionVehiculo();
Console.WriteLine("nivel de combustion del auto:" + miKia.verNivelGasolina());

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Camion");
Camion miFreightliner = new Camion(2010, "cascadaia", "Rojo");
miFreightliner.InformacionVehiculo();
Console.WriteLine("la capacidad que tiene el camion en carga es de:" + miFreightliner.verCargaDelCmaion());

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Motocicleta");
motocicleta miSuzuki = new motocicleta(2019, "GN", "Gris Cromo");
miSuzuki.InformacionVehiculo();
Console.WriteLine("La manera de encenderla es:" +miSuzuki.verencendido());









