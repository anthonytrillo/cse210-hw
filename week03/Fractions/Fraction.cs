using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 0;
        _bottom = 1;
    }

    public int getTop()
    {
        return _top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}