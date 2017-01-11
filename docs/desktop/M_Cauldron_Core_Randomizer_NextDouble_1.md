# Randomizer.NextDouble Method (Double, Double)
 _**\[This is preliminary documentation and is subject to change.\]**_

Returns a random number within a specified range. Cryptographic secure.

**Namespace:**&nbsp;<a href="N_Cauldron_Core">Cauldron.Core</a><br />**Assembly:**&nbsp;Cauldron.Core (in Cauldron.Core.dll) Version: 1.0.0.5 (1.0.0.5)

## Syntax

**C#**<br />
``` C#
public static double NextDouble(
	double minValue,
	double maxValue
)
```


#### Parameters
&nbsp;<dl><dt>minValue</dt><dd>Type: System.Double<br />The inclusive lower bound of the random number returned.</dd><dt>maxValue</dt><dd>Type: System.Double<br />The exclusive upper bound of the random number to be generated. maxValue must be greater than or equal to 0.</dd></dl>

#### Return Value
Type: Double<br />A random value

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentOutOfRangeException</td><td>*minValue* is greater than *maxValue*</td></tr></table>

## See Also


#### Reference
<a href="T_Cauldron_Core_Randomizer">Randomizer Class</a><br /><a href="Overload_Cauldron_Core_Randomizer_NextDouble">NextDouble Overload</a><br /><a href="N_Cauldron_Core">Cauldron.Core Namespace</a><br />