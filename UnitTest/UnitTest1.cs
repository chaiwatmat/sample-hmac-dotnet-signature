using System;
using Xunit;
using HmacGenerator;
using System.Linq;

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

        [Fact]
        public void Test2()
        {
            var expected = "da8392178a22d342a1cb4e694c5076411704daf6545cad28888bfd89a59ddc70ff11f8d514910b99e3dd8211d55fcdde6c7dcc4e2224ac3346f0f2af2db1b8c0";
            var input = "{\"responseUid\":\"9c07234b-90cb-4c15-a1b6-d277ddda8aca\",\"user\":{\"id\":1001,\"name\":\"Chaiwat Matarak\",\"friend\":null}}";

            var auditor = new Hmac512Generator();
            var result = auditor.GetSignature(input);

            Assert.Equal(expected, result);
        }
    }
}
