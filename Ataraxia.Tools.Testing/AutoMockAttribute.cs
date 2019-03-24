using System;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace Ataraxia.Tools.Testing
{
    public class AutoMockAttribute : AutoDataAttribute
    {
        public AutoMockAttribute() : base(() => new Fixture().Customize(new AutoMoqCustomization())) { }
    }
}
