using System;
using UOM.Quantities;
using UOM.Units;
using UOM.Units.UnitSys;
using Xunit;
namespace UOMTest
{
    public class TestQuantity
    {
        [Fact]
        public  void TestMultiplyandDivide(){
            Length l = new Length();
            Time t = new Time();
            Mass m = new Mass();
            Velocity v = l.Divide(t) as Velocity;
            Acceleration a = v.Divide(t) as Acceleration;
            Force f = m.Multiply(a) as Force;
            Force f1 = a.Multiply(m) as Force;

            Assert.IsType<Velocity>(v);
            Assert.IsType<Acceleration>(a);
            Assert.IsType<Force>(f);
            Assert.IsType<Force>(f1);

            Assert.IsType<meterpersecond>(v.Unit);
            Assert.IsType<meterpersecondsquare>(a.Unit);
            Assert.IsType<newton>(f.Unit);
            Assert.IsType<newton>(f1.Unit);
        }
    }
}
