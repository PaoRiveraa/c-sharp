public class Producto
{
    public string Codigo { get; set; }   
    public string Descripcion { get; set; } 
    public int Existencia { get; set; }

    public Producto(string codigo, string descripcion, int existencia)    // constructor para inicializar la variable 
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
    }
}