namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of PublishSponsorsTier
    /// </summary>
    public class PublishSponsorsTierInput
    {
        /// <summary>
        /// The ID of the draft tier to publish.
        /// </summary>
        public ID TierId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}