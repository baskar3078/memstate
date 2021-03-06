using Memstate.JsonNet;
using Xunit;
using Xunit.Abstractions;

namespace Memstate.Tests
{
    public class ConfigTests
    {
        private ITestOutputHelper _log;

        public ConfigTests(ITestOutputHelper log)
        {
            _log = log;
        }
        
        [Fact]
        public void CanGetDefaultSerializer()
        {
            MemstateSettings config = new MemstateSettings();
            var serializer = config.CreateSerializer();
            Assert.NotNull(serializer);
        }

    }
}