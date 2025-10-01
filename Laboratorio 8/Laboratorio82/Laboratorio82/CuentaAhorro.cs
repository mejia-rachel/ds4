public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prmttIdCuenta) : base(prmttIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaAhorro.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }

}
