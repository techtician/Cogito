﻿using System.Threading.Tasks;

using Microsoft.ServiceFabric.Actors;

namespace Cogito.Fabric.Activities.Test.TestActor.Interfaces
{

    public interface ITest : 
        IActor
    {

        Task CallBack(ITest2 test2, int value);

    }

}
