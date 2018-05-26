﻿using Cauldron.Activator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Activator_Tests
{
    [Component(typeof(ComponentTest))]
    public class ComponentTest : ComponentTestBase<ComponentTest>
    {
        [ComponentConstructor]
        public ComponentTest()
        {
        }

        [ComponentConstructor]
        public ComponentTest(string arg1, int arg2)
        {
        }

        [ComponentConstructor]
        public ComponentTest(double arg1, int arg2)
        {
        }

        [ComponentConstructor]
        public ComponentTest(double arg1, int arg2, string arg3)
        {
        }
    }

    [Component(typeof(object), FactoryCreationPolicy.Singleton, 34)]
    [Component("Hello", FactoryCreationPolicy.Singleton, 34)]
    public class AllParametersClass
    {
    }

    public class ComponentTestBase<T> where T : new()
    {
        [ComponentConstructor]
        public ComponentTestBase()
        {
        }

        [ComponentConstructor]
        public static T CreateMe(int arg1)
        {
            return new T();
        }
    }

    public class KeyedTestList<TKey, TItem2, TItem> : KeyedCollection<string, TItem>
    {
        public KeyedTestList()
        {
        }

        public KeyedTestList(IEnumerable<TItem> items)
        {
            foreach (var item in items)
                this.Add(item);
        }

        protected override string GetKeyForItem(TItem item)
        {
            return item.ToString();
        }
    }

    public class NestedClassParent
    {
        [Inject]
        private ITestInterface injectMe = null;

        public class NestedClassChild
        {
            private NestedClassParent parent;

            public NestedClassChild(NestedClassParent parent)
            {
                this.parent = parent;
            }

            public double Height { get { return this.parent.injectMe.Height.HasValue ? this.parent.injectMe.Height.Value : -1; } }
        }
    }

    [Component(typeof(ITestInterface))]
    public class TestClass : ITestInterface
    {
        public double? Height { get; set; }

        public int GetFish(string name)
        {
            return Convert.ToInt32(name);
        }
    }

    public class TestList<T> : List<T>
    {
    }
}