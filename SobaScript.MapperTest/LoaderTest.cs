using System.Linq;
using net.r_eg.SobaScript;
using net.r_eg.SobaScript.Mapper;
using net.r_eg.Varhead;
using SobaScript.MapperTest.Stubs;
using Xunit;

namespace SobaScript.MapperTest
{
    public class LoaderTest
    {
        [Fact]
        public void RegisterUnregisterTest1()
        {
            var soba = new Soba(new UVars());

            Assert.Empty(new Inspector(soba).Root);

            Assert.True(soba.Register(new StubTryComponent(soba)));

            Assert.Single(new Inspector(soba).Root);

            Assert.True(soba.Register(new StubCommentComponent()));
            Assert.True(soba.Register(new StubBoxComponent(soba)));

            Assert.Equal(3, new Inspector(soba).Root.Count());

            Assert.True(soba.Unregister(new StubCommentComponent()));

            Assert.Equal(2, new Inspector(soba).Root.Count());

            var c1 = new StubConditionComponent(soba);
            Assert.True(soba.Register(c1));
            Assert.True(soba.Register(new StubUserVariableComponent(soba)));
            Assert.True(soba.Register(new StubEvMSBuildComponent(soba)));

            Assert.True(soba.Unregister(c1));

            Assert.Equal(4, new Inspector(soba).Root.Count());

            soba.Unregister();

            Assert.Empty(new Inspector(soba).Root);
        }
    }
}
