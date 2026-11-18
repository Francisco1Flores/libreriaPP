namespace Presentacion;

public class Estilos
{
    public static readonly Color Verde = Color.FromArgb(0xff,0x00,0xff,0x00);
    public static readonly Color Azul  = Color.FromArgb(0xff,0x00,0x00,0xff);
    public static readonly Color Rojo  = Color.FromArgb(0xff,0xff,0x00,0x00);
    
    public static void BotonesVerdes(params Button[] botones)
    {
        foreach (Button b in botones)
        {
            b.BackColor = Verde;
        }
    }
    
    public static void BotonesAzules(params Button[] botones)
    {
        foreach (Button b in botones)
        {
            b.BackColor = Azul;
            b.ForeColor = Color.White;
        }
    }
    
    public static void BotonesRojos(params Button[] botones)
    {
        foreach (Button b in botones)
        {
            b.BackColor = Rojo;
            b.ForeColor = Color.White;
        }
    }
}