﻿using System;
using System.Activities;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Cogito.Fabric.Activities
{

    /// <summary>
    /// Various extension methods for working with a <see cref="WorkflowApplication"/>.
    /// </summary>
    static class WorkflowApplicationExtensions
    {

        /// <summary>
        /// Starts or resumes a workflow instance asynchronously.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="instanceId"></param>
        /// <returns></returns>
        public static Task LoadAsync(this WorkflowApplication self, Guid instanceId)
        {
            Contract.Requires<ArgumentNullException>(self != null);

            return Task.Factory.FromAsync(self.BeginLoad, self.EndLoad, instanceId, null);
        }

        /// <summary>
        /// Starts or resumes a workflow instance asynchronously.
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Task RunAsync(this WorkflowApplication self)
        {
            Contract.Requires<ArgumentNullException>(self != null);

            return Task.Factory.FromAsync(self.BeginRun, self.EndRun, null);
        }

        /// <summary>
        /// Initiates an asynchronous operation to resume the bookmark with the specified name, using the specified
        /// value, callback method, and state. The bookmark to be resumed is previously created by an activity within
        /// the workflow instance.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bookmarkName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Task ResumeBookmarkAsync(this WorkflowApplication self, string bookmarkName, object value)
        {
            Contract.Requires<ArgumentNullException>(self != null);
            Contract.Requires<ArgumentNullException>(bookmarkName != null);

            return Task.Factory.FromAsync(self.BeginResumeBookmark, self.EndResumeBookmark, bookmarkName, value, null);
        }

    }

}
