// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SubscriptionsOperations.
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Lsit all the subscriptions under a specified topic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            public static IPage<SubscriptionResource> ListAll(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                return Task.Factory.StartNew(s => ((ISubscriptionsOperations)s).ListAllAsync(resourceGroupName, namespaceName, topicName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lsit all the subscriptions under a specified topic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SubscriptionResource>> ListAllAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a topic subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topicName name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscriptionName name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a subscription Resource.
            /// </param>
            public static SubscriptionResource CreateOrUpdate(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, SubscriptionCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((ISubscriptionsOperations)s).CreateOrUpdateAsync(resourceGroupName, namespaceName, topicName, subscriptionName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a topic subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topicName name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscriptionName name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a subscription Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionResource> CreateOrUpdateAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, SubscriptionCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a subscription from the specified topic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            public static void Delete(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
            {
                Task.Factory.StartNew(s => ((ISubscriptionsOperations)s).DeleteAsync(resourceGroupName, namespaceName, topicName, subscriptionName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a subscription from the specified topic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a subscription description for the specified topic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            public static SubscriptionResource Get(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
            {
                return Task.Factory.StartNew(s => ((ISubscriptionsOperations)s).GetAsync(resourceGroupName, namespaceName, topicName, subscriptionName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a subscription description for the specified topic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionResource> GetAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lsit all the subscriptions under a specified topic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SubscriptionResource> ListAllNext(this ISubscriptionsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ISubscriptionsOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lsit all the subscriptions under a specified topic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SubscriptionResource>> ListAllNextAsync(this ISubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
