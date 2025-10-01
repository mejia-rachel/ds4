public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmttIdCuenta)
    {
        this.idCuenta = prmttIdCuenta;
        System.Console.WriteLine(
            "Constructor Clase Base para cuenta {0}", prmttIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine(
            "Cuenta.CalcularIntereses() efectuado para la cuenta {0}",
            this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}


