using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Components;
using net.r_eg.SobaScript.Mapper;

namespace SobaScript.MapperTest.Stubs
{
    [Definition(nameof(StubEvMSBuildComponent), "")]
    internal sealed class StubEvMSBuildComponent: ComponentAbstract
    {
        public override string Activator => nameof(StubEvMSBuildComponent);

        public override string Eval(string data) => data;

        public StubEvMSBuildComponent()
        {

        }

        public StubEvMSBuildComponent(ISobaScript soba)
        {

        }
    }
}