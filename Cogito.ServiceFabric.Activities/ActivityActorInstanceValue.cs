﻿using System.Activities.Hosting;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Cogito.ServiceFabric.Activities
{

    /// <summary>
    /// Wraps a serialized activity instance data object.
    /// </summary>
    [DataContract]
    [KnownType(typeof(XName))]
    [KnownType(typeof(ReadOnlyCollection<BookmarkInfo>))]
    [KnownType(typeof(ActivityActorInstanceValueAsString))]
    class ActivityActorInstanceValue
    {

        [DataMember]
        public object Value { get; set; }

    }

}