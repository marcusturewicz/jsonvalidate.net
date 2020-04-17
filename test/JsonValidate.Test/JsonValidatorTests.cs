using Bunit;
using Bunit.Mocking.JSInterop;
using JsonValidate.Shared;
using Xunit;

namespace JsonValidate.Test
{
    public class JsonValidateTests : ComponentTestFixture
    {
        public JsonValidateTests()
        {
            Services.AddMockJsRuntime();
        }

        [Fact]
        public void TextAreaEmptyAtStart()
        {
            var cut = RenderComponent<JsonValidator>();
            Assert.Equal(string.Empty, cut.Find("textarea").InnerHtml);
        }

        [Fact]
        public void ValidatingEmptyJsonProducesErrorMessage()
        {
            var cut = RenderComponent<JsonValidator>();
            cut.Find("button.btn.btn-primary").Click();
            Assert.Equal("Error: input was empty.", CleanString(cut.Find("div.alert.alert-danger").TextContent));
        }

        [Fact]
        public void ClearingWorks()
        {
            var cut = RenderComponent<JsonValidator>();
            // Create error message
            cut.Find("button.btn.btn-primary").Click();
            // Clear everything
            cut.Find("button.btn.btn-secondary").Click();
            // Error message is cleared
            Assert.Throws<ElementNotFoundException>(() => cut.Find("div.alert.alert-danger"));
        }             

        private string CleanString(string input)
        {
            return input.Trim().Replace("\n", string.Empty);
        }
    }
}