using System;
using UOM.Quantities;
using UOM.Units;
using UOM.Units.UnitSys;
using UOM.UOMException;
using Xunit;
namespace UOMTest
{
    public class TestQuantity
    {
        [Fact]
        public void TestMultiply(){
            IUnitSys tsys = new TimeUnitSys();
            IUnit tunit = tsys.Primary;
            IUnitSys vsys = new VelocityUnitSys();
            IUnit vunit = vsys.Primary;
            IQuantity t = new Quantity(tunit);
            IQuantity v = new Quantity(vunit);

            IQuantity l = t.Multiply(v);
            Assert.Equal("Length", l.Type.Id.Name);
            Assert.IsType<Length>(l);
            IQuantity l1 = v.Multiply(t);
            Assert.Equal("Length", l1.Type.Id.Name);
            Assert.IsType<Length>(l1);
        }
        [Fact]
        public void TestDivide(){
            IUnitSys lsys = new LengthUnitSys();
            IUnit lunit = lsys.Primary;
            IQuantity l = new Quantity(lunit);
            IUnitSys tsys = new TimeUnitSys();
            IUnit tunit = tsys.Primary;
            IQuantity t = new Quantity(tunit);

            IQuantity v = l.Divide(t);
            Assert.Equal("Velocity", v.Type.Id.Name);
            Assert.IsType<Velocity>(v);
        }
        [Fact]
        public void TestCombinatedMultiplyAndDivide(){
            Length l = new Length();
            Time t = new Time();
            Mass m = new Mass();
            IQuantity v = l.Divide(t);
            IQuantity a = v.Divide(t);
            IQuantity f = m.Multiply(a);
            IQuantity f1 = a.Multiply(m);
            Assert.IsType<Velocity>(v);
            Assert.IsType<Acceleration>(a);
            Assert.IsType<Force>(f);
            Assert.IsType<Force>(f1);
        }
        [Fact]
        public void TestAdd_Substract(){
            IUnitSys lsys = new LengthUnitSys();
            IUnit lunit = lsys.Primary;
            IQuantity l = new Quantity(lunit);
            IQuantity l1 = new Quantity(lunit);

            IUnitSys tsys = new TimeUnitSys();
            IUnit tunit = tsys.Primary;
            IQuantity t = new Quantity(tunit);

            IQuantity l2 = l.Add(l1);
            Assert.IsType<Length>(l2);
            Assert.Throws<NotSameQuantityForAddOrSubstractException>(()=>l.Add(t));

            IQuantity l3 = l.Substract(l1);
            Assert.IsType<Length>(l3);
            Assert.Throws<NotSameQuantityForAddOrSubstractException>(()=>l.Substract(t));
        }
        [Fact]
        public void Test_toUnit_ForScaleConverter(){
            IUnitSys lsys = new LengthUnitSys();
            IQuantity l = new Quantity(lsys.Primary, 2000f);
            IQuantity l1 = l.toUnit(lsys.k);
            Assert.IsType<Length>(l1);
            Assert.Equal(2.0f, l1.Value);
        }
        [Fact]
        public void Test_ComputeredValue(){
            IUnitSys lsys = new LengthUnitSys();
            IUnitSys tsys = new TimeUnitSys();
            IUnitSys msys = new MassUnitSys();

            IQuantity l = new Quantity(lsys.k, 2048f);
            IQuantity t = new Quantity(tsys.Primary, 20f);
            IQuantity m = new Quantity(msys.k, 15);
            IQuantity v = l.Divide(t);
            IQuantity a = l.Divide(t).Divide(t);
            IQuantity f = a.Multiply(m);

            Assert.Equal((2048f * 1000) /20f, v.Value);
            Assert.Equal((2048f * 1000) / 20f /20f, a.Value);
            Assert.Equal((2048f * 1000) /20f /20f * (15f), f.Value);
            Assert.IsType<meterpersecond>(v.Unit);
            Assert.IsType<meterpersecondsquare>(a.Unit);
            Assert.IsType<newton>(f.Unit);

            //test add and substract
            IQuantity l1 = new Quantity(lsys.Primary,22);
            IQuantity l2 = new Quantity(lsys.k, 55);

            Assert.Equal(2048f * 1000f + 22, l.Add(l1).Value);
            Assert.IsType<meter>(l.Add(l1).Unit);
            Assert.Equal(2048f * 1000f - 55f * 1000f, l.Substract(l2).Value);
            Assert.IsType<meter>(l.Substract(l2).Unit);
        }
    }
}
