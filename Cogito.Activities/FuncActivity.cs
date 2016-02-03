﻿using System;
using System.Activities;

namespace Cogito.Activities
{

    public static partial class Activities
    {

        public static FuncActivity<TResult> Invoke<TResult>(Func<TResult> func)
        {
            return new FuncActivity<TResult>(context => func());
        }

        public static FuncActivity<TResult> InvokeWithContext<TResult>(Func<ActivityContext, TResult> func)
        {
            return new FuncActivity<TResult>(func);
        }

        public static FuncActivity<TSource, TResult> ThenWith<TSource, TResult>(this Activity<TSource> activity, Func<TSource, TResult> func)
        {
            return new FuncActivity<TSource, TResult>((arg, context) => func(arg), activity);
        }

        public static FuncActivity<TSource, TResult> ThenWith<TSource, TResult>(this Activity<TSource> activity, Func<TSource, ActivityContext, TResult> func)
        {
            return new FuncActivity<TSource, TResult>(func, activity);
        }

    }

    /// <summary>
    /// Provides an <see cref="Activity"/> that executes the given function.
    /// </summary>
    public class FuncActivity<TResult> :
        NativeActivity<TResult>
    {

        public static implicit operator ActivityFunc<TResult>(FuncActivity<TResult> activity)
        {
            return Activities.Delegate<TResult>(result =>
            {
                activity.Result = result;
                return activity;
            });
        }

        public static implicit operator ActivityDelegate(FuncActivity<TResult> activity)
        {
            return activity;
        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public FuncActivity()
        {

        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="func"></param>
        public FuncActivity(Func<ActivityContext, TResult> func)
            : this()
        {
            Func = func;
        }

        /// <summary>
        /// Gets or sets the action to be invoked.
        /// </summary>
        [RequiredArgument]
        public Func<ActivityContext, TResult> Func { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            Result.Set(context, Func(context));
        }

    }

}