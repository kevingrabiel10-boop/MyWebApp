using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class CorazonesModel : PageModel
{
    public List<Corazon> Corazones { get; set; }

    public void OnGet()
    {
        Corazones = new List<Corazon>();

        // Genera 30 corazones aleatorios
        var random = new Random();
        for (int i = 0; i < 30; i++)
        {
            Corazones.Add(new Corazon
            {
                Top = random.Next(0, 100),
                Left = random.Next(0, 100)
            });
        }
    }
}

public class Corazon
{
    public int Top { get; set; }
    public int Left { get; set; }
}
