namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// A Gist.
    /// </summary>
    public class Gist : QueryEntity
    {
        public Gist(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        /// <summary>
        /// The gist description.
        /// </summary>
        public string Description { get; }

        public string Id { get; }

        /// <summary>
        /// Whether the gist is public or not.
        /// </summary>
        public bool IsPublic { get; }

        /// <summary>
        /// The gist name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The gist owner.
        /// </summary>
        public IRepositoryOwner Owner => this.CreateProperty(x => x.Owner, Octokit.GraphQL.Internal.StubIRepositoryOwner.Create);

        /// <summary>
        /// A list of users who have starred this starrable.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="orderBy">Order for connection</param>
        public StargazerConnection Stargazers(int? first = null, string after = null, int? last = null, string before = null, StarOrder orderBy = null) => this.CreateMethodCall(x => x.Stargazers(first, after, last, before, orderBy), Octokit.GraphQL.StargazerConnection.Create);

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public string UpdatedAt { get; }

        /// <summary>
        /// Returns a boolean indicating whether the viewing user has starred this starrable.
        /// </summary>
        public bool ViewerHasStarred { get; }

        internal static Gist Create(IQueryProvider provider, Expression expression)
        {
            return new Gist(provider, expression);
        }
    }
}