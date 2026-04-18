public enum EstatusVenta
{
    Exitoso,
    Pendiente,
    Cancelado
}
class Enums
{
    public void ejercicio()
    {
        var estatus = EstatusVenta.Exitoso;

        switch(estatus)
        {
            case EstatusVenta.Exitoso:
                Console.WriteLine("Venta exitosa");
                break;
            case EstatusVenta.Pendiente:
                Console.WriteLine("Venta pendiente");
                break;
            case EstatusVenta.Cancelado:
                Console.WriteLine("Venta cancelada");
                break;
        }
    }    
}