using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     NetworkPolicyList is a list of NetworkPolicy objects.
    /// </summary>
    [KubeObject("NetworkPolicyList", "networking.k8s.io/v1")]
    public class NetworkPolicyListV1 : KubeResourceListV1<NetworkPolicyV1>
    {
        /// <summary>
        ///     Items is a list of schema objects.
        /// </summary>
        [JsonProperty("items", ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        public override List<NetworkPolicyV1> Items { get; } = new List<NetworkPolicyV1>();
    }
}
