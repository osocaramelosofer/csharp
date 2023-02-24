// Interfaces

// Es un contrato que una clase al momento de implementar esta interfaz, debe de respetar este contrato.
// Si queremos implementar una interfaz, debemos de cumplir con las propiedades y metodos que esta tiene.
// Interfaz es la base de patrones de diseño.

public interface IAnimal
{
    string Name { get; }
}

public interface IFish
{
    public decimal Speed { get; set; }
    public string Swim();
}