﻿using System;
using System.Activities;

namespace Cogito.Activities
{

    public static partial class Activities
    {

        public static ActivityAction ActivityAction(Func<Activity> create)
        {
            return new ActivityAction()
            {
                Handler = create(),
            };
        }

        public static ActivityAction<TArg> ActivityAction<TArg>(Func<DelegateInArgument<TArg>, Activity> create)
        {
            var arg = new DelegateInArgument<TArg>();

            return new ActivityAction<TArg>()
            {
                Argument = arg,
                Handler = create(arg),
            };
        }

        public static ActivityAction<TArg1, TArg2> ActivityAction<TArg1, TArg2>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();

            return new ActivityAction<TArg1, TArg2>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Handler = create(arg1, arg2),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3> ActivityAction<TArg1, TArg2, TArg3>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();

            return new ActivityAction<TArg1, TArg2, TArg3>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Handler = create(arg1, arg2, arg3),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3, TArg4> ActivityAction<TArg1, TArg2, TArg3, TArg4>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();

            return new ActivityAction<TArg1, TArg2, TArg3, TArg4>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Handler = create(arg1, arg2, arg3, arg4),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5> ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();

            return new ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Handler = create(arg1, arg2, arg3, arg4, arg5),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();

            return new ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, DelegateInArgument<TArg7>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();
            var arg7 = new DelegateInArgument<TArg7>();

            return new ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Argument7 = arg7,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6, arg7),
            };
        }

        public static ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, DelegateInArgument<TArg7>, DelegateInArgument<TArg8>, Activity> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();
            var arg7 = new DelegateInArgument<TArg7>();
            var arg8 = new DelegateInArgument<TArg8>();

            return new ActivityAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Argument7 = arg7,
                Argument8 = arg8,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8),
            };
        }


        public static ActivityFunc<TResult> ActivityFunc<TResult>(Func<DelegateOutArgument<TResult>, Activity> create)
        {
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TResult>()
            {
                Result = result,
                Handler = create(result),
            };
        }

        public static ActivityFunc<TArg, TResult> ActivityFunc<TArg, TResult>(Func<DelegateInArgument<TArg>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg = new DelegateInArgument<TArg>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg, TResult>()
            {
                Argument = arg,
                Result = result,
                Handler = create(arg, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TResult> ActivityFunc<TArg1, TArg2, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Result = result,
                Handler = create(arg1, arg2, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TResult> ActivityFunc<TArg1, TArg2, TArg3, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Result = result,
                Handler = create(arg1, arg2, arg3, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TArg4, TResult> ActivityFunc<TArg1, TArg2, TArg3, TArg4, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TArg4, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Result = result,
                Handler = create(arg1, arg2, arg3, arg4, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Result = result,
                Handler = create(arg1, arg2, arg3, arg4, arg5, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Result = result,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, DelegateInArgument<TArg7>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();
            var arg7 = new DelegateInArgument<TArg7>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Argument7 = arg7,
                Result = result,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6, arg7, result),
            };
        }

        public static ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<DelegateInArgument<TArg1>, DelegateInArgument<TArg2>, DelegateInArgument<TArg3>, DelegateInArgument<TArg4>, DelegateInArgument<TArg5>, DelegateInArgument<TArg6>, DelegateInArgument<TArg7>, DelegateInArgument<TArg8>, DelegateOutArgument<TResult>, Activity<TResult>> create)
        {
            var arg1 = new DelegateInArgument<TArg1>();
            var arg2 = new DelegateInArgument<TArg2>();
            var arg3 = new DelegateInArgument<TArg3>();
            var arg4 = new DelegateInArgument<TArg4>();
            var arg5 = new DelegateInArgument<TArg5>();
            var arg6 = new DelegateInArgument<TArg6>();
            var arg7 = new DelegateInArgument<TArg7>();
            var arg8 = new DelegateInArgument<TArg8>();
            var result = new DelegateOutArgument<TResult>();

            return new ActivityFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>()
            {
                Argument1 = arg1,
                Argument2 = arg2,
                Argument3 = arg3,
                Argument4 = arg4,
                Argument5 = arg5,
                Argument6 = arg6,
                Argument7 = arg7,
                Argument8 = arg8,
                Result = result,
                Handler = create(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, result),
            };
        }


    }

}

