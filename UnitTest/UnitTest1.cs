using System;
using Xunit;
using HmacGenerator;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = "e54a620a9fe0e096f9c4c56355b6cea4a9b38a48b66f537fed0e1d9ce68c08777caf7682cff6c00330a4674e7f23e11448b2795921512bd3e5879aff7163d080";
            var input = "[{\"id\":\"10000\"},{\"id\":\"10001\"}]";

            var auditor = new Hmac512Generator();
            var result = auditor.GetSignature(input);

            Assert.Equal(expected, result);
        }
    }
}
