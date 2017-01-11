# Navigator Class
 _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Cauldron.XAML.Navigation.Navigator"\]


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_Cauldron_Activator_Singleton_1">Cauldron.Activator.Singleton</a>(<a href="T_Cauldron_XAML_Navigation_INavigator">INavigator</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;Cauldron.XAML.Navigation.Navigator<br />
**Namespace:**&nbsp;<a href="N_Cauldron_XAML_Navigation">Cauldron.XAML.Navigation</a><br />**Assembly:**&nbsp;Cauldron.XAML (in Cauldron.XAML.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[ComponentAttribute(typeof(INavigator), FactoryCreationPolicy.Singleton)]
public sealed class Navigator : Singleton<INavigator>, 
	INavigator
```

The Navigator type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator__ctor">Navigator</a></td><td>
Initializes a new instance of the Navigator class</td></tr></table>&nbsp;
<a href="#navigator-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Cauldron_XAML_Navigation_Navigator_CanGoBack">CanGoBack</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Cauldron_XAML_Navigation_Navigator_CanGoForward">CanGoForward</a></td><td /></tr></table>&nbsp;
<a href="#navigator-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_Activator_Singleton_1_Free">Free</a></td><td> (Inherited from <a href="T_Cauldron_Activator_Singleton_1">Singleton(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td>
Serves as the default hash function.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td>
Gets the Type of the current instance.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_GoBack">GoBack</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_GoForward">GoForward</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td>
Creates a shallow copy of the current Object.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync">NavigateAsync(Type)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync_1">NavigateAsync(Type, Object[])</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__1">NavigateAsync(T)()</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__1_1">NavigateAsync(T)(Func(Task))</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__1_3">NavigateAsync(T)(Object[])</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__1_2">NavigateAsync(T)(Func(Task), Object[])</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__2">NavigateAsync(T, TResult)(Func(TResult, Task))</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_NavigateAsync__2_1">NavigateAsync(T, TResult)(Func(TResult, Task), Object[])</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td>
Returns a string that represents the current object.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_TryClose">TryClose</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Cauldron_XAML_Navigation_Navigator_TryCloseFocusedWindow">TryCloseFocusedWindow</a></td><td /></tr></table>&nbsp;
<a href="#navigator-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_As__1">As(T)</a></td><td>
Performs a cast between compatible reference types. If a convertion is not possible then null is returned.
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsConvertions">ExtensionsConvertions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Dynamic_AnonymousTypeWithInterfaceExtension_CreateObject__1">CreateObject(T)</a></td><td> (Defined by <a href="T_Cauldron_Dynamic_AnonymousTypeWithInterfaceExtension">AnonymousTypeWithInterfaceExtension</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsReflection_GetPropertyNonPublicValue__1">GetPropertyNonPublicValue(T)</a></td><td>
Searches for the specified property, using the specified binding constraints and returns its value. 

 Default BindingFlags are Instance and NonPublic
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsReflection">ExtensionsReflection</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsReflection_GetPropertyValue">GetPropertyValue(String, BindingFlags)</a></td><td>Overloaded.  
Searches for the specified property, using the specified binding constraints and returns its value.
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsReflection">ExtensionsReflection</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsReflection_GetPropertyValue__1">GetPropertyValue(T)(String)</a></td><td>Overloaded.  
Searches for the specified property, using the specified binding constraints and returns its value. 

 Default BindingFlags are Instance and Public
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsReflection">ExtensionsReflection</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsReflection_GetPropertyValue__1_1">GetPropertyValue(T)(String, BindingFlags)</a></td><td>Overloaded.  
Searches for the specified property, using the specified binding constraints and returns its value.
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsReflection">ExtensionsReflection</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IsDerivedFrom__1">IsDerivedFrom(T)</a></td><td>
Checks if an object is not compatible (does not derive) with a given type.
 (Defined by <a href="T_Cauldron_Core_Extensions_Extensions">Extensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Activator_ExtensionsCloning_MapTo__1">MapTo(T)</a></td><td> (Defined by <a href="T_Cauldron_Activator_ExtensionsCloning">ExtensionsCloning</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLong_1">ToLong</a></td><td>
Tries to convert a Object to an Int64
 (Defined by <a href="T_Cauldron_Core_Extensions_ExtensionsConvertions">ExtensionsConvertions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_TryDispose">TryDispose</a></td><td>
Tries to performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. 

 This will dispose an object if it implements the IDisposable interface.
 (Defined by <a href="T_Cauldron_Core_Extensions_Extensions">Extensions</a>.)</td></tr></table>&nbsp;
<a href="#navigator-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Cauldron_XAML_Navigation">Cauldron.XAML.Navigation Namespace</a><br />