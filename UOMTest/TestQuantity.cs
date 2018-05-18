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
    }
}
