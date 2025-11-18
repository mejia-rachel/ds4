class ClaseConcreta1 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcetra1";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta1";
    }
}