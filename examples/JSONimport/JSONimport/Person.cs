using System;
using Realms;

namespace JSONimport
{
    public class Person : RealmObject
    {
        public string FullName { get; set; }
        public DateTimeOffset Birthday { get; set;}
        public int NumberOfFriends { get; set; }
    }
}

