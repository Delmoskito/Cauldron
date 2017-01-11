# Extensions Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Provides usefull extension methods


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;Cauldron.Core.Extensions.Extensions<br />
**Namespace:**&nbsp;<a href="N_Cauldron_Core_Extensions">Cauldron.Core.Extensions</a><br />**Assembly:**&nbsp;Cauldron.Core (in Cauldron.Core.dll) Version: 1.0.0.5 (1.0.0.5)

## Syntax

**C#**<br />
``` C#
public static class Extensions
```

The Extensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Compress">Compress(Byte[])</a></td><td>
Compresses data using gzip</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Compress_1">Compress(String)</a></td><td>
Compresses a utf8 encoded string using gzip</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Concat__1">Concat(T)</a></td><td>
Concatenates a jagged array to a one-dimensional array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Contains">Contains</a></td><td>
Returns a value indicating whether a specified substring occurs within this string.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Copy">Copy</a></td><td>
Creates a new instance of System.String with the same value as a specified System.String.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Distinct__1">Distinct(TSource)</a></td><td>
Returns distinct elements from a sequence by using a selector to compare values.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_EnclosedIn">EnclosedIn</a></td><td>
Gets the string enclosed by two strings</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_FillWithRandomValues">FillWithRandomValues</a></td><td>
Replaces the values of data in memory with random values. The GC handle will be freed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Foreach__1">Foreach(T)</a></td><td>
Performs the specified action on each element of the IEnumerable(T)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetBytes_1">GetBytes(Byte[], UInt32)</a></td><td>
Gets a specified length of bytes. 

 If the specified length *length* is longer than the source array the source array will be returned instead.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetBytes">GetBytes(Byte[], Int32, Int32)</a></td><td>
Gets a specified length of bytes</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetHash">GetHash(String)</a></td><td>
Get the hash representing the string. The hash algorithm used is <a href="T_Cauldron_Core_HashAlgorithms">Md5</a></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetHash_1">GetHash(String, HashAlgorithms)</a></td><td>
Get the hash representing the string</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetLines">GetLines</a></td><td>
Splits a string into lines</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetStackTrace">GetStackTrace</a></td><td>
Gets the stacktrace of the exception and the inner exceptions recursively</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetTarget__1">GetTarget(T)</a></td><td>
Retrieves the target object referenced by the current WeakReference(T) object 

 Returns null if the target is not available</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_GetTypes">GetTypes</a></td><td>
Retrieves the types of the object array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IndexOf">IndexOf(Byte[], Byte[])</a></td><td>
Searches for the specified byte array and returns the zero-based index of the first occurrence within the entire Array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IndexOf__1">IndexOf(T)(T[], T)</a></td><td>
Searches for the specified object and returns the zero-based index of the first occurrence within the entire Array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IsBase64String">IsBase64String</a></td><td>
Checkes if the string is encoded in Base64.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IsDerivedFrom__1">IsDerivedFrom(T)</a></td><td>
Checks if an object is not compatible (does not derive) with a given type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IsNotNull__1">IsNotNull(T)(T, Action(T))</a></td><td>
Checks if the value is null. If not, it will invoke *action*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_IsNotNull__2">IsNotNull(T, TResult)(T, Func(T, TResult))</a></td><td>
Checks if the value is null. If not, it will invoke *func*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Join">Join(IEnumerable(String), String)</a></td><td>
Concatenates the members of a constructed IEnumerable(T) collection of type String, using the specified *separator* between each member.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Join_1">Join(Object[], String)</a></td><td>
Concatenates the elements of an object array, using the specified *separator* between each element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Join_2">Join(String[], String)</a></td><td>
Concatenates all the elements of a string array, using the specified *separator* between each element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Join__1">Join(T)(IEnumerable(T), String)</a></td><td>
Concatenates the members of a collection, using the specified *separator* between each member.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Left">Left</a></td><td>
Returns a string containing a specified number of characters from the left side of a string.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_LowerFirstCharacter">LowerFirstCharacter</a></td><td>
Replaces the first char of a string against a lower cased char</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Move__1">Move(T)</a></td><td>
Moves the specified item to a new location in the collection</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_OrderBy__1">OrderBy(TElements)</a></td><td>
Sorts the elements of a sequence in ascending order according to a key.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_ParseQueryString">ParseQueryString</a></td><td>
Parses a query string into a NameValueCollection using UTF8 encoding.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_RandomPick__1">RandomPick(T)</a></td><td>
Picks a random element from the given array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_ReadToEnd">ReadToEnd</a></td><td>
Reads all characters from the current position to the end of the stream.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Right">Right</a></td><td>
Returns a string containing a specified number of characters from the right side of a string.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_RunSync">RunSync(Task)</a></td><td>
Runs the Task synchronously on the default TaskScheduler.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_RunSync__1">RunSync(TResult)(Task(TResult))</a></td><td>
Runs the Task synchronously on the default TaskScheduler.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_SliceColumn__1">SliceColumn(T)</a></td><td>
Returns the elements of the first dimension of a multidimensional array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_SliceRow__1">SliceRow(T)</a></td><td>
Returns the elements of the second dimension of a multidimensional array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Swap__1">Swap(T)</a></td><td>
Swaps two elements in a collection</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_TryDispose">TryDispose</a></td><td>
Tries to performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. 

 This will dispose an object if it implements the IDisposable interface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_TryEncode">TryEncode</a></td><td>
Tries to encode a byte array to a string by detecting its encoding. 

 It will try to detect the encoding for for UTF-7, UTF-8/16/32 (bom, no bom, little and big endian), and local default codepage, and potentially other codepages.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_Uncompress">Uncompress</a></td><td>
Uncompresses a gzip compressed data</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_Extensions_UncompressString">UncompressString</a></td><td>
Uncompresses a gzip compressed string</td></tr></table>&nbsp;
<a href="#extensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Cauldron_Core_Extensions">Cauldron.Core.Extensions Namespace</a><br />