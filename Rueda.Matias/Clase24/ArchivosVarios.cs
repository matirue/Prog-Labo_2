using Entidades.Clase24;
/**Delegado
 el delegado no le interesa q sea statico o no, la clase, solo le importa la firma q se respete
 es un puntero a funciones 
  * **/
                //                      Firma                         //
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);

public delegate void LimiteSueldoMejoradoDel(Empleado emp, EmpleadoEventArgs e);


public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos,
}

