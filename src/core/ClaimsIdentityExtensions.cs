using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace System.Security.Claims
{
    /// <summary>
    ///
    /// </summary>
    public static class ClaimsIdentityExtensions
    {
        ///  <summary>
        /// 
        ///  </summary>
        ///  <typeparam name="T"></typeparam>
        /// <param name="identity"></param>
        /// <param name="claimType"></param>
        ///  <returns></returns>
        public static T GetUserClaim<T>(this ClaimsIdentity identity, string claimType) 
            => (T)Convert.ChangeType(identity.FindFirst(claimType)?.Value, typeof(T));

        ///  <summary>
        /// 
        ///  </summary>
        ///  <typeparam name="T"></typeparam>
        /// <param name="identity"></param>
        /// <param name="claimType"></param>
        ///  <returns></returns>
        public static IEnumerable<T> GetUserClaims<T>(this ClaimsIdentity identity, string claimType) 
            => identity.FindAll(claimType).Select(x => (T)Convert.ChangeType(x.Value, typeof(T)));

        /// <summary>
        ///
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static IEnumerable<string> Roles(this ClaimsIdentity identity) 
            => identity.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();

        /// <summary>
        ///
        /// </summary>
        /// <param name="currentPrincipal"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetClaimValue(this IPrincipal currentPrincipal, string key)
        {
            ClaimsIdentity identity = currentPrincipal.Identity as ClaimsIdentity;
            Claim claim = identity?.Claims.First(c => c.Type == key);
            return claim.Value;
        }
    }
}