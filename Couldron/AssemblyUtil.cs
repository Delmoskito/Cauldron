﻿using Couldron.Collections;
using Couldron.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Couldron
{
    /// <summary>
    /// Contains utilities that helps to manage and gather <see cref="Assembly"/> information
    /// </summary>
    public static partial class AssemblyUtil
    {
        /// <summary>
        /// Returns all Types that implements the interface <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The interface <see cref="Type"/></typeparam>
        /// <returns>A colletion of <see cref="Type"/> that implements the interface <typeparamref name="T"/> otherwise null</returns>
        /// <exception cref="ArgumentException"><typeparamref name="T"/> is not an interface</exception>
        public static IEnumerable<TypeInfo> GetTypesImplementsInterface<T>()
        {
            if (!typeof(T).IsInterface)
                throw new ArgumentException(string.Format("The Type '{0}' is not an interface.", typeof(T).FullName));

            var interfaceType = typeof(T);
            var result = typesWithImplementedInterfaces.Where(x => x.interfaces.Length > 0 && x.interfaces.Contains(interfaceType));

            if (result == null)
                return null;

            return result.Select(x => x.typeInfo);
        }

        /// <summary>
        /// Loads the contents of an assembly file on the specified path.
        /// </summary>
        /// <param name="path">The fully qualified path of the file to load. </param>
        /// <param name="relativPath">A value that indicates if the parameter <paramref name="path"/> is a relative path or not.</param>
        /// <exception cref="ArgumentException">The <paramref name="path"/> argument is not an absolute path.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="path"/> parameter is null.</exception>
        /// <exception cref="FileLoadException">A file that was found could not be loaded</exception>
        /// <exception cref="FileNotFoundException">The <paramref name="path"/> parameter is an empty string ("") or does not exist</exception>
        /// <exception cref="BadImageFormatException"><paramref name="path"/> is not a valid assembly.</exception>
        public static void LoadAssembly(string path, bool relativPath = true)
        {
            var assemblyPath = string.Empty;

            if (relativPath)
                assemblyPath = Path.Combine(ApplicationInfo.ApplicationPath, path);
            else
                assemblyPath = path;

            var assembly = Assembly.LoadFile(assemblyPath);

            typesWithImplementedInterfaces.AddRange(
                assembly.DefinedTypes.Select(x => new TypesWithImplementedInterfaces
                {
                    interfaces = x.ImplementedInterfaces.ToArray(),
                    typeInfo = x
                }));

            AssemblyAndResourceNamesInfo.AddRange(assembly.GetManifestResourceNames().Select(x => new AssemblyAndResourceNameInfo(assembly, x)));
        }

        private static void GetAllAssemblies()
        {
            // Get all assemblies in AppDomain and add them to our list
            // TODO - This will not work in UWP and Core if compiled to native code
            var assemblies = new List<Assembly>();
            assemblies.AddRange(AppDomain.CurrentDomain.GetAssemblies());
            assemblies.Add(typeof(AssemblyUtil).Assembly);
            Assemblies = new ConcurrentList<Assembly>(assemblies.Distinct());
        }
    }
}