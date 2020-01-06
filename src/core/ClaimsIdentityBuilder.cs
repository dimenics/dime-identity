namespace System.Security.Claims
{
    /// <summary>
    /// Allows for easy assembling claims for ClaimsIdentity with a fluent interface
    /// </summary>
    public class ClaimsIdentityBuilder
    {
        private ClaimsIdentity Identity { get; } = new ClaimsIdentity();

        /// <summary>
        /// Creates a claim for type <see cref="ClaimTypes.PrimarySid"/>
        /// </summary>
        /// <param name="id">The value to assign</param>
        /// <returns>The current instance to allow chaining method calls</returns>
        public ClaimsIdentityBuilder WithId(int id)
            => With(ClaimTypes.PrimarySid, id.ToString());

        /// <summary>
        /// Creates a claim for type <see cref="ClaimTypes.Name"/>
        /// </summary>
        /// <param name="name">The value to assign</param>
        /// <returns>The current instance to allow chaining method calls</returns>
        public ClaimsIdentityBuilder WithName(string name)
            => With(ClaimTypes.Name, name);

        /// <summary>
        /// Creates a claim for type <see cref="ClaimTypes.Locality"/>
        /// </summary>
        /// <param name="locality">The value to assign</param>
        /// <returns>The current instance to allow chaining method calls</returns>
        public ClaimsIdentityBuilder WithLocale(string locality)
            => With(ClaimTypes.Locality, locality);

        /// <summary>
        /// Creates a claim for type <see cref="ClaimTypes.Role"/>
        /// </summary>
        /// <param name="role">The value to assign</param>
        /// <returns>The current instance to allow chaining method calls</returns>
        public ClaimsIdentityBuilder WithRole(string role)
            => With(ClaimTypes.Role, role);

        /// <summary>
        /// Creates a claim for type <see cref="ClaimTypes.PrimarySid"/>
        /// </summary>
        /// <param name="claimType">The claim type</param>
        /// <param name="value">The value to assign</param>
        /// <returns>The current instance to allow chaining method calls</returns>
        public ClaimsIdentityBuilder With(string claimType, string value)
        {
            Identity.AddClaim(new Claim(claimType, value));
            return this;
        }

        /// <summary>
        /// Builds the claims identity
        /// </summary>
        /// <returns>The instance with all claims assigned in the fluent api</returns>
        public ClaimsIdentity Build()
            => Identity;
    }
}