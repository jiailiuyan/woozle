﻿using System.Collections.Generic;
using Woozle.Model.Validation;
using Woozle.Model.Validation.Creation;

namespace Woozle.Services
{
    /// <summary>
    /// Result class for each service operation between client and server.
    /// </summary>
    /// <typeparam name="T">Type of the service entity</typeparam>
    public class SaveResultDto<T> : ISaveResult<T>
    {
        /// <summary>
        /// ctor.
        /// </summary>
        public SaveResultDto()
        {
            this.Errors = new List<Error>();
        }

        #region ICreationResult<T,Error> Members

        /// <summary>
        /// Target entity
        /// </summary>
        public T TargetObject { get; set; }

        /// <summary>
        /// Flag, which indicates if there is an error.
        /// </summary>
        public bool HasErrors
        {
            get { return this.Errors != null && this.Errors.Count > 0; }
        }

        /// <summary>
        /// Flag, which indicactes if there is a system error.
        /// </summary>
        public bool HasSystemErrors { get; set; }

        /// <summary>
        /// A list with <see cref="Error">errors</see>
        /// </summary>
        public List<Error> Errors { get; set; }

        #endregion
    }
}
