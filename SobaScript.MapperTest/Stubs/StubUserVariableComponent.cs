using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Components;
using net.r_eg.SobaScript.Mapper;

namespace SobaScript.MapperTest.Stubs
{
    [Definition(nameof(StubUserVariableComponent), "")]
    internal sealed class StubUserVariableComponent: ComponentAbstract
    {
        public override string Activator => nameof(StubUserVariableComponent);

        public override string Eval(string data) => data;

        public StubUserVariableComponent()
        {

        }

        public StubUserVariableComponent(ISobaScript soba)
        {

        }
    }
}