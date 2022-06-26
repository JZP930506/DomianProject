using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABPProject.Pages;

public class Index_Tests : ABPProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
