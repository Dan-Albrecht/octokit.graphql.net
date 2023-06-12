namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of TransferEnterpriseOrganization
    /// </summary>
    public class TransferEnterpriseOrganizationInput
    {
        /// <summary>
        /// The ID of the organization to transfer.
        /// </summary>
        public ID OrganizationId { get; set; }

        /// <summary>
        /// The ID of the enterprise where the organization should be transferred.
        /// </summary>
        public ID DestinationEnterpriseId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}