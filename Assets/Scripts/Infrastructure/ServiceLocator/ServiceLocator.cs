using System;
using System.Collections.Generic;
using UnityEngine;

namespace Logic.Infrastructure.ServiceLocator
{
    public class ServiceLocator
    {
        #region Fields
        private readonly Dictionary<string, IService> _services = new();
        #endregion

        #region Functionality
        public IService this[Type type]
        {
            get => _services [type.Name];
           
            set => _services.Add(type.Name, value);          
        }
        #endregion
    }
}
