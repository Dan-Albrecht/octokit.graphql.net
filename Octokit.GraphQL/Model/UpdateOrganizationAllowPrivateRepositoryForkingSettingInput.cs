namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateOrganizationAllowPrivateRepositoryForkingSetting
    /// </summary>
    public class UpdateOrganizationAllowPrivateRepositoryForkingSettingInput
    {
        /// <summary>
        /// The ID of the organization on which to set the allow private repository forking setting.
        /// </summary>
        public ID OrganizationId { get; set; }

        /// <summary>
        /// Enable forking of private repositories in the organization?
        /// </summary>
        public bool ForkingEnabled { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}