using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj;
        [Fact]
        public void GetReturnValue()
        {
            obj= new WeatherForecastController();
            var res = obj.Get(1);
            Assert.Equal("Shilpa Maheshwarii",res.Value);
        }
    }
}
