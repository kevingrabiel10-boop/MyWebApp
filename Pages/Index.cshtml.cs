using Microsoft.AspNetCore.Mvc.RazorPages;

public class ProductoModel : PageModel
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public void OnGet()
    {
        Nombre = "Consolador Turbo 3000";
        Precio = 79.90m;
    }
}