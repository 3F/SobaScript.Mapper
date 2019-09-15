using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Components;
using net.r_eg.SobaScript.Mapper;

namespace SobaScript.MapperTest.Stubs
{
    [Definition(nameof(StubConditionComponent), "")]
    internal sealed class StubConditionComponent: ComponentAbstract
    {
        public override string Activator => nameof(StubConditionComponent);

        public override string Eval(string data) => data;

        public StubConditionComponent()
        {

        }

        public StubConditionComponent(ISobaScript soba)
        {

        }
    }
}