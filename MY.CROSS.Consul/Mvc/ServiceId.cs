using System;

namespace MS.COTAS.Cross.Consul.Mvc
{
    public class ServiceId : IServiceId
    {
        private static readonly string UniqueId = $"{Guid.NewGuid():N}";

        public string Id => UniqueId;
    }
}