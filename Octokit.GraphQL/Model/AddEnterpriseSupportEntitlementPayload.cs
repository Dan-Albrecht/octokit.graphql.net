namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddEnterpriseSupportEntitlement
    /// </summary>
    public class AddEnterpriseSupportEntitlementPayload : QueryableValue<AddEnterpriseSupportEntitlementPayload>
    {
        internal AddEnterpriseSupportEntitlementPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// A message confirming the result of adding the support entitlement.
        /// </summary>
        public string Message { get; }

        internal static AddEnterpriseSupportEntitlementPayload Create(Expression expression)
        {
            return new AddEnterpriseSupportEntitlementPayload(expression);
        }
    }
}