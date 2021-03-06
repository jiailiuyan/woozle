﻿using Woozle.Model.SessionHandling;

namespace Woozle.Domain.ExternalSystem.ExternalSystemFacade
{
    /// <summary>
    /// Interface for an external system facade.
    /// The external system facade is an component which is searching dynamically for 
    /// specific external systems.
    /// </summary>
    /// <typeparam name="T">Type of the target external system</typeparam>
    public interface IExternalSystemFacade<out T> where T : IExternalSystem
    {
        /// <summary>
        /// Get the external system.
        /// </summary>
        /// <remarks>
        /// The external system facade is looking for a specific external system.
        /// The target external system will be loaded dynamically and with a lazy mechnism.
        /// </remarks>
        /// <param name="sessionData"><see cref="SessionData"/></param>
        /// <returns>An instance of the external system (wrapper)</returns>
        T GetExternalSystem(SessionData sessionData);
    }
}
