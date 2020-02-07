Tested with:

* MacOS 10.15.3
* VS Code 1.41.1
* Omni Sharp 1.34.11-beta.24

# Steps to Reproduce

1. Open project in VS Code with OmniSharp Roslyn extension installed.
2. Open [Test.cshtml](Pages/Test.cshtml) and wait for the red squigly lines to appear.
3. Open [Test.cshtml.cs](Pages/Test.cshtml.cs). Omni Sharp should crash.

Exception Details:

```
[ERROR] FATAL UNHANDLED EXCEPTION: System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
Parameter name: index
  at Microsoft.CodeAnalysis.Text.SourceText+LineInfo.get_Item (System.Int32 index) [0x0000f] in <5a27fd083507435b81a01127fc008020>:0 
  at OmniSharp.Helpers.LocationExtensions.GetQuickFix (Microsoft.CodeAnalysis.Location location, OmniSharp.OmniSharpWorkspace workspace) [0x0007a] in <603c304251c74d09a39d8a403f846882>:0 
  at OmniSharp.Roslyn.CSharp.Services.Navigation.FindUsagesService+<>c__DisplayClass2_0.<Handle>b__2 (Microsoft.CodeAnalysis.Location l) [0x00000] in <603c304251c74d09a39d8a403f846882>:0 
  at System.Linq.Enumerable+SelectEnumerableIterator`2[TSource,TResult].MoveNext () [0x00048] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at System.Linq.Set`1[TElement].UnionWith (System.Collections.Generic.IEnumerable`1[T] other) [0x00018] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at System.Linq.Enumerable+DistinctIterator`1[TSource].FillSet () [0x0000b] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at System.Linq.Enumerable+DistinctIterator`1[TSource].ToArray () [0x00000] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at System.Linq.Buffer`1[TElement]..ctor (System.Collections.Generic.IEnumerable`1[T] source) [0x0000a] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at System.Linq.OrderedEnumerable`1+<GetEnumerator>d__3[TElement].MoveNext () [0x0001e] in <b62ff15cbb8d435193cbdcd26f86d362>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeList (Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x000e1] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeValue (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x000d4] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeObject (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x0008d] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeValue (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x000b0] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeObject (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x0008d] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.SerializeValue (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) [0x000b0] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.Serialize (Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) [0x00079] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.JsonSerializer.SerializeInternal (Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) [0x00253] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.JsonSerializer.Serialize (Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) [0x00000] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.JsonConvert.SerializeObjectInternal (System.Object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer) [0x00028] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.JsonConvert.SerializeObject (System.Object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) [0x00007] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at Newtonsoft.Json.JsonConvert.SerializeObject (System.Object value) [0x00000] in <07e3893119a945b29a35e81930b1c8ad>:0 
  at OmniSharp.Protocol.Packet.ToString () [0x00000] in <d1c4448fc2e54bb08e466d2bf5c757ae>:0 
  at System.IO.TextWriter.WriteLine (System.Object value) [0x00028] in <f759957039b44a0190b1110fdfe3030f>:0 
  at System.IO.TextWriter+SyncTextWriter.WriteLine (System.Object value) [0x00000] in <f759957039b44a0190b1110fdfe3030f>:0 
  at (wrapper synchronized) System.IO.TextWriter+SyncTextWriter.WriteLine(object)
  at OmniSharp.Services.SharedTextWriter.ProcessWriteQueue () [0x0001d] in <d1c4448fc2e54bb08e466d2bf5c757ae>:0 
  at System.Threading.ThreadHelper.ThreadStart_Context (System.Object state) [0x00014] in <f759957039b44a0190b1110fdfe3030f>:0 
  at System.Threading.ExecutionContext.RunInternal (System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx) [0x00071] in <f759957039b44a0190b1110fdfe3030f>:0 
  at System.Threading.ExecutionContext.Run (System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx) [0x00000] in <f759957039b44a0190b1110fdfe3030f>:0 
  at System.Threading.ExecutionContext.Run (System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state) [0x0002b] in <f759957039b44a0190b1110fdfe3030f>:0 
  at System.Threading.ThreadHelper.ThreadStart () [0x00008] in <f759957039b44a0190b1110fdfe3030f>:0 
```