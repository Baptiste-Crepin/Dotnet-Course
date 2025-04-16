using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Animal.Models;
using JetBrains.Annotations;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalApp.Tests;

[TestClass]
[TestSubject(typeof(Animal.Models.Animal))]
public class AnimalTest : PageTest
{
    [TestInitialize]
    public async Task InitAsync()
    {
        await Context.Tracing.StartAsync(new()
        {
            Title = "test-trace",
            Screenshots = true,
            Snapshots = true,
            Sources = true
        });
    }

    [TestCleanup]
    public async Task CleanupAsync()
    {
        await Context.Tracing.StopAsync(new()
        {
            Path = "trace.zip"
        });
    }

    [TestMethod]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://playwright.dev");
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [TestMethod]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://www.supinfo.com/");
        var button = Page.GetByRole(AriaRole.Button, new() { Name = "Do not accept" });
        if (await button.IsVisibleAsync())
        {
            await button.ClickAsync();
        }

        await Page.GetByRole(AriaRole.Link, new() { Name = "Formation" }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "Le programme : vue d’ensemble" }).ClickAsync();
        await Expect(Page.Locator("#h-le-programme-grande-ecole-5-ans-d-etudes-en-informatique-apres-le-bac"))
            .ToContainTextAsync("Le Programme Grande École : 5 ans d’études en informatique après le Bac");
    }
}