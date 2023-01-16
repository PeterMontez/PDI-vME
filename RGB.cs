using System.Collections.Generic;
using System.Drawing;

public class RGB
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public RGB(byte R, byte G, byte B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }
}

public class Close
{
    public List<Color> CloseColor = new List<Color>();
    public List<int> CloseIndex = new List<int>();

    public void Adicionar(Color pixel)
    {
        CloseColor.Add(pixel);
    }

    public void AdicionarIndex(int Index)
    {
        CloseIndex.Add(Index);
    }

}