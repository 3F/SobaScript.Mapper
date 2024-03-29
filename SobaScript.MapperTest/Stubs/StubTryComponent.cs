﻿using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Components;
using net.r_eg.SobaScript.Mapper;

namespace SobaScript.MapperTest.Stubs
{
    [Definition(nameof(StubTryComponent), "")]
    internal sealed class StubTryComponent: ComponentAbstract
    {
        public override string Activator => nameof(StubTryComponent);

        public override string Eval(string data) => data;

        public StubTryComponent()
        {

        }

        public StubTryComponent(ISobaScript soba)
        {

        }
    }
}