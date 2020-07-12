using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.Identity.Tests
{
    [TestClass]
    public class ClaimsIdentityBuilderTests
    {
        [TestMethod]
        public void ClaimsIdentityBuilder_WithId_ShouldSetClaim()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.WithId(250).Build();

            Assert.IsTrue(claimsIdentity.Claims.First(x => x.Type == ClaimTypes.PrimarySid).Value == "250");
        }

        [TestMethod]
        public void ClaimsIdentityBuilder_WithName_ShouldSetClaim()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.WithName("Handsome B. Wonderful").Build();

            string name = claimsIdentity.Claims.First(x => x.Type == ClaimTypes.Name).Value;
            Assert.IsTrue(name == "Handsome B. Wonderful");
        }

        [TestMethod]
        public void ClaimsIdentityBuilder_WithName_CallsWrongClaim_ShouldThrowInvalidOperationException()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.WithName("Handsome B. Wonderful").Build();

            Assert.ThrowsException<InvalidOperationException>(() => claimsIdentity.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
        }

        [TestMethod]
        public void ClaimsIdentityBuilder_WithLocale_ShouldSetClaim()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.WithLocale("America/Cancun").Build();

            Assert.IsTrue(claimsIdentity.Claims.First(x => x.Type == ClaimTypes.Locality).Value == "America/Cancun");
        }

        [TestMethod]
        public void ClaimsIdentityBuilder_WithRole_ShouldSetClaim()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.WithRole("Admin").Build();

            Assert.IsTrue(claimsIdentity.Claims.First(x => x.Type == ClaimTypes.Role).Value == "Admin");
        }

        [TestMethod]
        public void ClaimsIdentityBuilder_With_ShouldSetClaim()
        {
            ClaimsIdentityBuilder builder = new ClaimsIdentityBuilder();
            ClaimsIdentity claimsIdentity = builder.With("CustomClaim", "CustomValue").Build();

            Assert.IsTrue(claimsIdentity.Claims.First(x => x.Type == "CustomClaim").Value == "CustomValue");
        }
    }
}