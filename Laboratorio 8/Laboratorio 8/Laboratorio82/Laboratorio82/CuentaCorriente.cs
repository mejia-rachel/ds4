public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmttIdCuenta) : base(prmttIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }
}
