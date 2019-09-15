using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Components;
using net.r_eg.SobaScript.Mapper;

namespace SobaScript.MapperTest.Stubs
{
    [Definition(nameof(StubBoxComponent), "")]
    internal sealed class StubBoxComponent: ComponentAbstract
    {
        public override string Activator => nameof(StubBoxComponent);

        public override string Eval(string data) => data;

        public StubBoxComponent()
        {

        }

        public StubBoxComponent(ISobaScript soba)
        {

        }
    }
}