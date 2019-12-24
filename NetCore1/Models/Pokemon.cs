// Editar -> Pegado Especial -> Pegar JSON como clases
public class Pokemon
{
    public int height { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public Sprites sprites { get; set; }
    public int weight { get; set; }
}

public class Sprites
{
    public string back_default { get; set; }
    public string back_female { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_female { get; set; }
    public string front_default { get; set; }
    public string front_female { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_female { get; set; }
}

