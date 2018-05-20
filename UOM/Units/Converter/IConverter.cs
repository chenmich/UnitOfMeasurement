using System;

namespace UOM.Units.Converter
{
    public interface IConverter
    {
        float toPrimary(float value);
        float fromPrimary(float value);
    }
}
