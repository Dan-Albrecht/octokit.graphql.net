namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateProjectNext
    /// </summary>
    public class UpdateProjectNextPayload : QueryableValue<UpdateProjectNextPayload>
    {
        internal UpdateProjectNextPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated Project.
        /// </summary>
        public ProjectNext ProjectNext => this.CreateProperty(x => x.ProjectNext, Octokit.GraphQL.Model.ProjectNext.Create);

        internal static UpdateProjectNextPayload Create(Expression expression)
        {
            return new UpdateProjectNextPayload(expression);
        }
    }
}