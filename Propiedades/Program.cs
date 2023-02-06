//=========== PROPIEDADES ==================
// Las propiedades son similares a los atributos, la diferencia
// es que las propiedades tienes accesors que son permiten, acceder , leer y escribir.


Sale mySale = new Sale(20, DateTime.Now);
Console.WriteLine(mySale.Total);
mySale.Total = -20;
Console.WriteLine(mySale.Total);

class Sale
{
    // Atributos
    private int total;
    private DateTime date;



    //* Las propiedades que son publicas normalmente empiezan con Mayuscula
    public int Total { 
        get { return total; } 
        set
        { 
            if(value < 0)
                value = 0;
            total = value;
        } 
    } 

    public string Date 
    {
        get { return date.ToString(); }
    }


    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }
}