namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateLinkedBranch
    /// </summary>
    public class CreateLinkedBranchInput
    {
        /// <summary>
        /// ID of the issue to link to.
        /// </summary>
        public ID IssueId { get; set; }

        /// <summary>
        /// The commit SHA to base the new branch on.
        /// </summary>
        public string Oid { get; set; }

        /// <summary>
        /// The name of the new branch. Defaults to issue number and title.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID of the repository to create the branch in. Defaults to the issue repository.
        /// </summary>
        public ID? RepositoryId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}