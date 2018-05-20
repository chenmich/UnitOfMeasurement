using System;

namespace UOM.Units.Converter
{
    public interface IConverter
    {
        double toPrimary(double value);
        double fromPrimary(double value);
    }
}
