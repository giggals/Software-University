﻿using System;
using System.Collections.Generic;


public class PersonAgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Age.CompareTo(y.Age);

        return result;
    }
}
