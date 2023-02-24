// SOBRECARGA DE METODOS 



B b = new B();
Console.WriteLine(b.Hi());


Sale sale = new Sale(5);
sale.Add(1);
sale.Add(1);
Console.WriteLine(sale.GetTotal());

SaleWithTax saleTax = new SaleWithTax(10,1.16m);
saleTax.Add(1);
saleTax.Add(1);
Console.Write(saleTax.GetTotal());


public class Sale
{
    private decimal[] _amounts;
    private int _n;
    private int _end;


    public Sale(int n) 
    { 
        _n = n;
        _amounts = new decimal[n];
        _end = 0;
    }

    public void Add(decimal amount)
    {
        if(_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }

    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;

        foreach (var item in _amounts)
        {
            result += item;
        }
        return result;
    }
}

class SaleWithTax : Sale
{
    private decimal _tax;
    public SaleWithTax(int n, decimal tax) : base(n)
    {
        _tax = tax;
    }

    public override decimal GetTotal()
    {
        return base.GetTotal() * _tax;
    }
}

class A
{
    // Al momento que usamos la palabra reservada virtual, podemos sobreescribir este metodo.
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

class B : A
{
    // Tenemos que ocupar override para poder sobre escribir el metodo Hi() de la clase A.
    public override string Hi() => base.Hi() + "Hola soy b";
}