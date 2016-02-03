﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cogito.Activities.Tests
{

    [TestClass]
    public class RetryTests
    {

        /// <summary>
        /// Tests for complete failure.
        /// </summary>
        [TestMethod]
        public void Test_Retry_Failure()
        {
            int runCount = 0;

            try
            {
                WorkflowInvoker.Invoke(new Retry()
                {
                    MaxAttempts = 5,
                    Body = Activities.Invoke<int>(i =>
                    {
                        runCount++;
                        throw new Exception("broke");
                        return;
                    }),
                });
            }
            catch (RetryException e)
            {
                Assert.AreEqual(5, e.InnerExceptions.Count);
                Assert.AreEqual(5, runCount);

                return;
            }

            Assert.Fail();
        }


        [TestMethod]
        public void Test_Retry_Finally()
        {
            int runCount = 0;
            var results = WorkflowInvoker.Invoke(new Retry()
            {
                MaxAttempts = 5,
                Body = Activities.Invoke<int>(i =>
                {
                    if (++runCount < 3)
                        throw new Exception("Exception");
                }),
            });

            Assert.AreEqual(3, runCount);
            Assert.AreEqual(2, ((IEnumerable<Exception>)results["Exceptions"]).ToArray().Length);
        }

        [TestMethod]
        public void Test_Retry_Success()
        {
            var results = WorkflowInvoker.Invoke(new Retry()
            {
                MaxAttempts = 5,
                Body = Activities.Invoke<int>(i => { }),
            });

            Assert.AreEqual(1, (int)results["Attempts"]);
        }

    }
}
