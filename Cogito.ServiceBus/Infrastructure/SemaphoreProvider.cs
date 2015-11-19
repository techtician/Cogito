﻿using System;
using System.ComponentModel.Composition;
using System.Diagnostics.Contracts;

namespace Cogito.ServiceBus.Infrastructure
{

    /// <summary>
    /// Exports semaphore types for identities.
    /// </summary>
    public class SemaphoreProvider<TIdentity> :
        IDisposable
    {

        readonly Lazy<Semaphore<TIdentity>> semaphore;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="bus"></param>
        /// <param name="factory"></param>
        [ImportingConstructor]
        public SemaphoreProvider(
            IServiceBus bus, 
            ISemaphoreFactory<TIdentity> factory)
        {
            Contract.Requires<ArgumentNullException>(bus != null);
            Contract.Requires<ArgumentNullException>(factory != null);

            this.semaphore = new Lazy<Semaphore<TIdentity>>(() => factory.Create());
        }

        /// <summary>
        /// Gets the semaphore instance.
        /// </summary>
        [Export(typeof(Semaphore<>))]
        public Semaphore<TIdentity> Semaphore
        {
            get { return semaphore.Value; }
        }

        /// <summary>
        /// Disposes of the instance.
        /// </summary>
        public void Dispose()
        {
            if (semaphore.IsValueCreated)
                semaphore.Value.Dispose();
        }

    }

}
