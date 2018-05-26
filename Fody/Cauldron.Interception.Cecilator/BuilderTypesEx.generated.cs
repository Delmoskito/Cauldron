﻿

/*
	Generated :)
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using Mono.Cecil;

namespace Cauldron.Interception.Cecilator
{    	
    /// <summary>
    /// Provides predifined types for Cecilator
    /// </summary>
	public static class TypeSystemEx
    {
	
		#region Void
        private static BuilderType _Void;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing void. 
        /// </summary>
        public static BuilderType Void
        {
            get
            {
                if (_Void == null) _Void = Builder.Current.GetType("System.Void");
                return _Void;
            }
        }

		#endregion
		
				
		#region Array
        private static BuilderTypeArray _array;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Array"/>. 
        /// </summary>
        public static BuilderTypeArray Array
        {
            get
            {
                if (_array == null) _array = new BuilderTypeArray(Builder.Current.GetType(typeof(Array)).Import());
                return _array;
            }
        }

		#endregion
				
		#region Boolean
        private static BuilderTypeBoolean _boolean;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Boolean"/>. 
        /// </summary>
        public static BuilderTypeBoolean Boolean
        {
            get
            {
                if (_boolean == null) _boolean = new BuilderTypeBoolean(Builder.Current.GetType(typeof(Boolean)).Import());
                return _boolean;
            }
        }

		#endregion
				
		#region Byte
        private static BuilderTypeByte _byte;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Byte"/>. 
        /// </summary>
        public static BuilderTypeByte Byte
        {
            get
            {
                if (_byte == null) _byte = new BuilderTypeByte(Builder.Current.GetType(typeof(Byte)).Import());
                return _byte;
            }
        }

		#endregion
				
		#region Char
        private static BuilderTypeChar _char;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Char"/>. 
        /// </summary>
        public static BuilderTypeChar Char
        {
            get
            {
                if (_char == null) _char = new BuilderTypeChar(Builder.Current.GetType(typeof(Char)).Import());
                return _char;
            }
        }

		#endregion
				
		#region Convert
        private static BuilderTypeConvert _convert;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Convert"/>. 
        /// </summary>
        public static BuilderTypeConvert Convert
        {
            get
            {
                if (_convert == null) _convert = new BuilderTypeConvert(Builder.Current.GetType(typeof(Convert)).Import());
                return _convert;
            }
        }

		#endregion
				
		#region DateTime
        private static BuilderTypeDateTime _datetime;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.DateTime"/>. 
        /// </summary>
        public static BuilderTypeDateTime DateTime
        {
            get
            {
                if (_datetime == null) _datetime = new BuilderTypeDateTime(Builder.Current.GetType(typeof(DateTime)).Import());
                return _datetime;
            }
        }

		#endregion
				
		#region Decimal
        private static BuilderTypeDecimal _decimal;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Decimal"/>. 
        /// </summary>
        public static BuilderTypeDecimal Decimal
        {
            get
            {
                if (_decimal == null) _decimal = new BuilderTypeDecimal(Builder.Current.GetType(typeof(Decimal)).Import());
                return _decimal;
            }
        }

		#endregion
				
		#region Dictionary`2
        private static BuilderTypeDictionary2 _dictionary_2;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.Dictionary{TKey,TValue}"/>. 
        /// </summary>
        public static BuilderTypeDictionary2 Dictionary2
        {
            get
            {
                if (_dictionary_2 == null) _dictionary_2 = new BuilderTypeDictionary2(Builder.Current.GetType(typeof(Dictionary<,>)).Import());
                return _dictionary_2;
            }
        }

		#endregion
				
		#region Double
        private static BuilderTypeDouble _double;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Double"/>. 
        /// </summary>
        public static BuilderTypeDouble Double
        {
            get
            {
                if (_double == null) _double = new BuilderTypeDouble(Builder.Current.GetType(typeof(Double)).Import());
                return _double;
            }
        }

		#endregion
				
		#region Enum
        private static BuilderTypeEnum _enum;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Enum"/>. 
        /// </summary>
        public static BuilderTypeEnum Enum
        {
            get
            {
                if (_enum == null) _enum = new BuilderTypeEnum(Builder.Current.GetType(typeof(Enum)).Import());
                return _enum;
            }
        }

		#endregion
				
		#region Enumerable
        private static BuilderTypeEnumerable _enumerable;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Linq.Enumerable"/>. 
        /// </summary>
        public static BuilderTypeEnumerable Enumerable
        {
            get
            {
                if (_enumerable == null) _enumerable = new BuilderTypeEnumerable(Builder.Current.GetType(typeof(Enumerable)).Import());
                return _enumerable;
            }
        }

		#endregion
				
		#region EventArgs
        private static BuilderTypeEventArgs _eventargs;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.EventArgs"/>. 
        /// </summary>
        public static BuilderTypeEventArgs EventArgs
        {
            get
            {
                if (_eventargs == null) _eventargs = new BuilderTypeEventArgs(Builder.Current.GetType(typeof(EventArgs)).Import());
                return _eventargs;
            }
        }

		#endregion
				
		#region EventHandler
        private static BuilderTypeEventHandler _eventhandler;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.EventHandler"/>. 
        /// </summary>
        public static BuilderTypeEventHandler EventHandler
        {
            get
            {
                if (_eventhandler == null) _eventhandler = new BuilderTypeEventHandler(Builder.Current.GetType(typeof(EventHandler)).Import());
                return _eventhandler;
            }
        }

		#endregion
				
		#region EventHandler`1
        private static BuilderTypeEventHandler1 _eventhandler_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.EventHandler{TEventArgs}"/>. 
        /// </summary>
        public static BuilderTypeEventHandler1 EventHandler1
        {
            get
            {
                if (_eventhandler_1 == null) _eventhandler_1 = new BuilderTypeEventHandler1(Builder.Current.GetType(typeof(EventHandler<>)).Import());
                return _eventhandler_1;
            }
        }

		#endregion
				
		#region Exception
        private static BuilderTypeException _exception;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Exception"/>. 
        /// </summary>
        public static BuilderTypeException Exception
        {
            get
            {
                if (_exception == null) _exception = new BuilderTypeException(Builder.Current.GetType(typeof(Exception)).Import());
                return _exception;
            }
        }

		#endregion
				
		#region ICollection`1
        private static BuilderTypeICollection1 _icollection_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.ICollection{T}"/>. 
        /// </summary>
        public static BuilderTypeICollection1 ICollection1
        {
            get
            {
                if (_icollection_1 == null) _icollection_1 = new BuilderTypeICollection1(Builder.Current.GetType(typeof(ICollection<>)).Import());
                return _icollection_1;
            }
        }

		#endregion
				
		#region IDictionary
        private static BuilderTypeIDictionary _idictionary;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.IDictionary"/>. 
        /// </summary>
        public static BuilderTypeIDictionary IDictionary
        {
            get
            {
                if (_idictionary == null) _idictionary = new BuilderTypeIDictionary(Builder.Current.GetType(typeof(IDictionary)).Import());
                return _idictionary;
            }
        }

		#endregion
				
		#region IDictionary`2
        private static BuilderTypeIDictionary2 _idictionary_2;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.IDictionary{TKey,TValue}"/>. 
        /// </summary>
        public static BuilderTypeIDictionary2 IDictionary2
        {
            get
            {
                if (_idictionary_2 == null) _idictionary_2 = new BuilderTypeIDictionary2(Builder.Current.GetType(typeof(IDictionary<,>)).Import());
                return _idictionary_2;
            }
        }

		#endregion
				
		#region IEnumerable
        private static BuilderTypeIEnumerable _ienumerable;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.IEnumerable"/>. 
        /// </summary>
        public static BuilderTypeIEnumerable IEnumerable
        {
            get
            {
                if (_ienumerable == null) _ienumerable = new BuilderTypeIEnumerable(Builder.Current.GetType(typeof(IEnumerable)).Import());
                return _ienumerable;
            }
        }

		#endregion
				
		#region IEnumerable`1
        private static BuilderTypeIEnumerable1 _ienumerable_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.IEnumerable{T}"/>. 
        /// </summary>
        public static BuilderTypeIEnumerable1 IEnumerable1
        {
            get
            {
                if (_ienumerable_1 == null) _ienumerable_1 = new BuilderTypeIEnumerable1(Builder.Current.GetType(typeof(IEnumerable<>)).Import());
                return _ienumerable_1;
            }
        }

		#endregion
				
		#region IList
        private static BuilderTypeIList _ilist;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.IList"/>. 
        /// </summary>
        public static BuilderTypeIList IList
        {
            get
            {
                if (_ilist == null) _ilist = new BuilderTypeIList(Builder.Current.GetType(typeof(IList)).Import());
                return _ilist;
            }
        }

		#endregion
				
		#region IList`1
        private static BuilderTypeIList1 _ilist_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.IList{T}"/>. 
        /// </summary>
        public static BuilderTypeIList1 IList1
        {
            get
            {
                if (_ilist_1 == null) _ilist_1 = new BuilderTypeIList1(Builder.Current.GetType(typeof(IList<>)).Import());
                return _ilist_1;
            }
        }

		#endregion
				
		#region Int16
        private static BuilderTypeInt16 _int16;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Int16"/>. 
        /// </summary>
        public static BuilderTypeInt16 Int16
        {
            get
            {
                if (_int16 == null) _int16 = new BuilderTypeInt16(Builder.Current.GetType(typeof(Int16)).Import());
                return _int16;
            }
        }

		#endregion
				
		#region Int32
        private static BuilderTypeInt32 _int32;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Int32"/>. 
        /// </summary>
        public static BuilderTypeInt32 Int32
        {
            get
            {
                if (_int32 == null) _int32 = new BuilderTypeInt32(Builder.Current.GetType(typeof(Int32)).Import());
                return _int32;
            }
        }

		#endregion
				
		#region Int64
        private static BuilderTypeInt64 _int64;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Int64"/>. 
        /// </summary>
        public static BuilderTypeInt64 Int64
        {
            get
            {
                if (_int64 == null) _int64 = new BuilderTypeInt64(Builder.Current.GetType(typeof(Int64)).Import());
                return _int64;
            }
        }

		#endregion
				
		#region IntPtr
        private static BuilderTypeIntPtr _intptr;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.IntPtr"/>. 
        /// </summary>
        public static BuilderTypeIntPtr IntPtr
        {
            get
            {
                if (_intptr == null) _intptr = new BuilderTypeIntPtr(Builder.Current.GetType(typeof(IntPtr)).Import());
                return _intptr;
            }
        }

		#endregion
				
		#region List`1
        private static BuilderTypeList1 _list_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Collections.Generic.List{T}"/>. 
        /// </summary>
        public static BuilderTypeList1 List1
        {
            get
            {
                if (_list_1 == null) _list_1 = new BuilderTypeList1(Builder.Current.GetType(typeof(List<>)).Import());
                return _list_1;
            }
        }

		#endregion
				
		#region MethodBase
        private static BuilderTypeMethodBase _methodbase;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Reflection.MethodBase"/>. 
        /// </summary>
        public static BuilderTypeMethodBase MethodBase
        {
            get
            {
                if (_methodbase == null) _methodbase = new BuilderTypeMethodBase(Builder.Current.GetType(typeof(MethodBase)).Import());
                return _methodbase;
            }
        }

		#endregion
				
		#region Monitor
        private static BuilderTypeMonitor _monitor;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Threading.Monitor"/>. 
        /// </summary>
        public static BuilderTypeMonitor Monitor
        {
            get
            {
                if (_monitor == null) _monitor = new BuilderTypeMonitor(Builder.Current.GetType(typeof(Monitor)).Import());
                return _monitor;
            }
        }

		#endregion
				
		#region Nullable
        private static BuilderTypeNullable _nullable;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Nullable"/>. 
        /// </summary>
        public static BuilderTypeNullable Nullable
        {
            get
            {
                if (_nullable == null) _nullable = new BuilderTypeNullable(Builder.Current.GetType(typeof(Nullable)).Import());
                return _nullable;
            }
        }

		#endregion
				
		#region Nullable`1
        private static BuilderTypeNullable1 _nullable_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Nullable{T}"/>. 
        /// </summary>
        public static BuilderTypeNullable1 Nullable1
        {
            get
            {
                if (_nullable_1 == null) _nullable_1 = new BuilderTypeNullable1(Builder.Current.GetType(typeof(Nullable<>)).Import());
                return _nullable_1;
            }
        }

		#endregion
				
		#region Object
        private static BuilderTypeObject _object;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Object"/>. 
        /// </summary>
        public static BuilderTypeObject Object
        {
            get
            {
                if (_object == null) _object = new BuilderTypeObject(Builder.Current.GetType(typeof(Object)).Import());
                return _object;
            }
        }

		#endregion
				
		#region SByte
        private static BuilderTypeSByte _sbyte;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.SByte"/>. 
        /// </summary>
        public static BuilderTypeSByte SByte
        {
            get
            {
                if (_sbyte == null) _sbyte = new BuilderTypeSByte(Builder.Current.GetType(typeof(SByte)).Import());
                return _sbyte;
            }
        }

		#endregion
				
		#region Single
        private static BuilderTypeSingle _single;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Single"/>. 
        /// </summary>
        public static BuilderTypeSingle Single
        {
            get
            {
                if (_single == null) _single = new BuilderTypeSingle(Builder.Current.GetType(typeof(Single)).Import());
                return _single;
            }
        }

		#endregion
				
		#region String
        private static BuilderTypeString _string;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.String"/>. 
        /// </summary>
        public static BuilderTypeString String
        {
            get
            {
                if (_string == null) _string = new BuilderTypeString(Builder.Current.GetType(typeof(String)).Import());
                return _string;
            }
        }

		#endregion
				
		#region Task
        private static BuilderTypeTask _task;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Threading.Tasks.Task"/>. 
        /// </summary>
        public static BuilderTypeTask Task
        {
            get
            {
                if (_task == null) _task = new BuilderTypeTask(Builder.Current.GetType(typeof(Task)).Import());
                return _task;
            }
        }

		#endregion
				
		#region Task`1
        private static BuilderTypeTask1 _task_1;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Threading.Tasks.Task{TResult}"/>. 
        /// </summary>
        public static BuilderTypeTask1 Task1
        {
            get
            {
                if (_task_1 == null) _task_1 = new BuilderTypeTask1(Builder.Current.GetType(typeof(Task<>)).Import());
                return _task_1;
            }
        }

		#endregion
				
		#region Type
        private static BuilderTypeType _type;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.Type"/>. 
        /// </summary>
        public static BuilderTypeType Type
        {
            get
            {
                if (_type == null) _type = new BuilderTypeType(Builder.Current.GetType(typeof(Type)).Import());
                return _type;
            }
        }

		#endregion
				
		#region UInt16
        private static BuilderTypeUInt16 _uint16;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.UInt16"/>. 
        /// </summary>
        public static BuilderTypeUInt16 UInt16
        {
            get
            {
                if (_uint16 == null) _uint16 = new BuilderTypeUInt16(Builder.Current.GetType(typeof(UInt16)).Import());
                return _uint16;
            }
        }

		#endregion
				
		#region UInt32
        private static BuilderTypeUInt32 _uint32;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.UInt32"/>. 
        /// </summary>
        public static BuilderTypeUInt32 UInt32
        {
            get
            {
                if (_uint32 == null) _uint32 = new BuilderTypeUInt32(Builder.Current.GetType(typeof(UInt32)).Import());
                return _uint32;
            }
        }

		#endregion
				
		#region UInt64
        private static BuilderTypeUInt64 _uint64;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.UInt64"/>. 
        /// </summary>
        public static BuilderTypeUInt64 UInt64
        {
            get
            {
                if (_uint64 == null) _uint64 = new BuilderTypeUInt64(Builder.Current.GetType(typeof(UInt64)).Import());
                return _uint64;
            }
        }

		#endregion
				
		#region UIntPtr
        private static BuilderTypeUIntPtr _uintptr;
		
        /// <summary>
        /// Gets <see cref="BuilderType"/> representing <see cref="System.UIntPtr"/>. 
        /// </summary>
        public static BuilderTypeUIntPtr UIntPtr
        {
            get
            {
                if (_uintptr == null) _uintptr = new BuilderTypeUIntPtr(Builder.Current.GetType(typeof(UIntPtr)).Import());
                return _uintptr;
            }
        }

		#endregion
		
	}

	/// <exclude />
	public class TypeSystemExBase 
	{
		/// <exclude />
		internal BuilderType builderType;

        internal TypeSystemExBase(BuilderType builderType)
		{
			this.builderType = builderType;
		}
	}		
			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Array"/>
    /// </summary>
    public partial class BuilderTypeArray : TypeSystemExBase
	{
        internal BuilderTypeArray(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeArray value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeArray value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_createinstance_0_2;
				
		private Method var_createinstance_1_2;
				
		private Method var_createinstance_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Array CreateInstance(System.Type, Int32)<para/>
		/// System.Array CreateInstance(System.Type, Int32[])<para/>
		/// System.Array CreateInstance(System.Type, Int64[])<para/>
		/// </summary>
		public Method GetMethod_CreateInstance(TypeReference pelementType, TypeReference plength)
		{
						
						
			if(typeof(System.Type).AreEqual(pelementType) && typeof(System.Int32).AreEqual(plength))
			{
				if(this.var_createinstance_0_2 == null)
					this.var_createinstance_0_2 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength).Import();
			
				return this.var_createinstance_0_2;
			}
			
			if(typeof(System.Type).AreEqual(pelementType) && typeof(System.Int32[]).AreEqual(plength))
			{
				if(this.var_createinstance_1_2 == null)
					this.var_createinstance_1_2 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength).Import();
			
				return this.var_createinstance_1_2;
			}
			
			if(typeof(System.Type).AreEqual(pelementType) && typeof(System.Int64[]).AreEqual(plength))
			{
				if(this.var_createinstance_2_2 == null)
					this.var_createinstance_2_2 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength).Import();
			
				return this.var_createinstance_2_2;
			}
			
			return null;
			
		}
				
		private Method var_createinstance_0_3;
				
		private Method var_createinstance_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Array CreateInstance(System.Type, Int32, Int32)<para/>
		/// System.Array CreateInstance(System.Type, Int32[], Int32[])<para/>
		/// </summary>
		public Method GetMethod_CreateInstance(TypeReference pelementType, TypeReference plength1, TypeReference plength2)
		{
						
						
			if(typeof(System.Type).AreEqual(pelementType) && typeof(System.Int32).AreEqual(plength1) && typeof(System.Int32).AreEqual(plength2))
			{
				if(this.var_createinstance_0_3 == null)
					this.var_createinstance_0_3 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength1, plength2).Import();
			
				return this.var_createinstance_0_3;
			}
			
			if(typeof(System.Type).AreEqual(pelementType) && typeof(System.Int32[]).AreEqual(plength1) && typeof(System.Int32[]).AreEqual(plength2))
			{
				if(this.var_createinstance_1_3 == null)
					this.var_createinstance_1_3 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength1, plength2).Import();
			
				return this.var_createinstance_1_3;
			}
			
			return null;
			
		}
				
		private Method var_createinstance_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Array CreateInstance(System.Type, Int32, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_CreateInstance(TypeReference pelementType, TypeReference plength1, TypeReference plength2, TypeReference plength3)
		{
						
						
			if(this.var_createinstance_0_4 == null)
				this.var_createinstance_0_4 = this.builderType.GetMethod("CreateInstance", true, pelementType, plength1, plength2, plength3).Import();
			
			return this.var_createinstance_0_4;
						
		}
				
		private Method var_copy_0_3;
				
		private Method var_copy_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Copy(System.Array, System.Array, Int32)<para/>
		/// Void Copy(System.Array, System.Array, Int64)<para/>
		/// </summary>
		public Method GetMethod_Copy(TypeReference psourceArray, TypeReference pdestinationArray, TypeReference plength)
		{
						
						
			if(typeof(System.Array).AreEqual(psourceArray) && typeof(System.Array).AreEqual(pdestinationArray) && typeof(System.Int32).AreEqual(plength))
			{
				if(this.var_copy_0_3 == null)
					this.var_copy_0_3 = this.builderType.GetMethod("Copy", true, psourceArray, pdestinationArray, plength).Import();
			
				return this.var_copy_0_3;
			}
			
			if(typeof(System.Array).AreEqual(psourceArray) && typeof(System.Array).AreEqual(pdestinationArray) && typeof(System.Int64).AreEqual(plength))
			{
				if(this.var_copy_1_3 == null)
					this.var_copy_1_3 = this.builderType.GetMethod("Copy", true, psourceArray, pdestinationArray, plength).Import();
			
				return this.var_copy_1_3;
			}
			
			return null;
			
		}
				
		private Method var_copy_0_5;
				
		private Method var_copy_1_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Copy(System.Array, Int32, System.Array, Int32, Int32)<para/>
		/// Void Copy(System.Array, Int64, System.Array, Int64, Int64)<para/>
		/// </summary>
		public Method GetMethod_Copy(TypeReference psourceArray, TypeReference psourceIndex, TypeReference pdestinationArray, TypeReference pdestinationIndex, TypeReference plength)
		{
						
						
			if(typeof(System.Array).AreEqual(psourceArray) && typeof(System.Int32).AreEqual(psourceIndex) && typeof(System.Array).AreEqual(pdestinationArray) && typeof(System.Int32).AreEqual(pdestinationIndex) && typeof(System.Int32).AreEqual(plength))
			{
				if(this.var_copy_0_5 == null)
					this.var_copy_0_5 = this.builderType.GetMethod("Copy", true, psourceArray, psourceIndex, pdestinationArray, pdestinationIndex, plength).Import();
			
				return this.var_copy_0_5;
			}
			
			if(typeof(System.Array).AreEqual(psourceArray) && typeof(System.Int64).AreEqual(psourceIndex) && typeof(System.Array).AreEqual(pdestinationArray) && typeof(System.Int64).AreEqual(pdestinationIndex) && typeof(System.Int64).AreEqual(plength))
			{
				if(this.var_copy_1_5 == null)
					this.var_copy_1_5 = this.builderType.GetMethod("Copy", true, psourceArray, psourceIndex, pdestinationArray, pdestinationIndex, plength).Import();
			
				return this.var_copy_1_5;
			}
			
			return null;
			
		}
				
		private Method var_constrainedcopy_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void ConstrainedCopy(System.Array, Int32, System.Array, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_ConstrainedCopy(TypeReference psourceArray, TypeReference psourceIndex, TypeReference pdestinationArray, TypeReference pdestinationIndex, TypeReference plength)
		{
						
						
			if(this.var_constrainedcopy_0_5 == null)
				this.var_constrainedcopy_0_5 = this.builderType.GetMethod("ConstrainedCopy", true, psourceArray, psourceIndex, pdestinationArray, pdestinationIndex, plength).Import();
			
			return this.var_constrainedcopy_0_5;
						
		}
				
		private Method var_clear_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Clear(System.Array, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Clear(TypeReference parray, TypeReference pindex, TypeReference plength)
		{
						
						
			if(this.var_clear_0_3 == null)
				this.var_clear_0_3 = this.builderType.GetMethod("Clear", true, parray, pindex, plength).Import();
			
			return this.var_clear_0_3;
						
		}
				
		private Method var_getvalue_0_1;
				
		private Method var_getvalue_1_1;
				
		private Method var_getvalue_2_1;
				
		private Method var_getvalue_3_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object GetValue(Int32[])<para/>
		/// System.Object GetValue(Int32)<para/>
		/// System.Object GetValue(Int64)<para/>
		/// System.Object GetValue(Int64[])<para/>
		/// </summary>
		public Method GetMethod_GetValue(TypeReference pindices)
		{
						
						
			if(typeof(System.Int32[]).AreEqual(pindices))
			{
				if(this.var_getvalue_0_1 == null)
					this.var_getvalue_0_1 = this.builderType.GetMethod("GetValue", true, pindices).Import();
			
				return this.var_getvalue_0_1;
			}
			
			if(typeof(System.Int32).AreEqual(pindices))
			{
				if(this.var_getvalue_1_1 == null)
					this.var_getvalue_1_1 = this.builderType.GetMethod("GetValue", true, pindices).Import();
			
				return this.var_getvalue_1_1;
			}
			
			if(typeof(System.Int64).AreEqual(pindices))
			{
				if(this.var_getvalue_2_1 == null)
					this.var_getvalue_2_1 = this.builderType.GetMethod("GetValue", true, pindices).Import();
			
				return this.var_getvalue_2_1;
			}
			
			if(typeof(System.Int64[]).AreEqual(pindices))
			{
				if(this.var_getvalue_3_1 == null)
					this.var_getvalue_3_1 = this.builderType.GetMethod("GetValue", true, pindices).Import();
			
				return this.var_getvalue_3_1;
			}
			
			return null;
			
		}
				
		private Method var_getvalue_0_2;
				
		private Method var_getvalue_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object GetValue(Int32, Int32)<para/>
		/// System.Object GetValue(Int64, Int64)<para/>
		/// </summary>
		public Method GetMethod_GetValue(TypeReference pindex1, TypeReference pindex2)
		{
						
						
			if(typeof(System.Int32).AreEqual(pindex1) && typeof(System.Int32).AreEqual(pindex2))
			{
				if(this.var_getvalue_0_2 == null)
					this.var_getvalue_0_2 = this.builderType.GetMethod("GetValue", true, pindex1, pindex2).Import();
			
				return this.var_getvalue_0_2;
			}
			
			if(typeof(System.Int64).AreEqual(pindex1) && typeof(System.Int64).AreEqual(pindex2))
			{
				if(this.var_getvalue_1_2 == null)
					this.var_getvalue_1_2 = this.builderType.GetMethod("GetValue", true, pindex1, pindex2).Import();
			
				return this.var_getvalue_1_2;
			}
			
			return null;
			
		}
				
		private Method var_getvalue_0_3;
				
		private Method var_getvalue_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object GetValue(Int32, Int32, Int32)<para/>
		/// System.Object GetValue(Int64, Int64, Int64)<para/>
		/// </summary>
		public Method GetMethod_GetValue(TypeReference pindex1, TypeReference pindex2, TypeReference pindex3)
		{
						
						
			if(typeof(System.Int32).AreEqual(pindex1) && typeof(System.Int32).AreEqual(pindex2) && typeof(System.Int32).AreEqual(pindex3))
			{
				if(this.var_getvalue_0_3 == null)
					this.var_getvalue_0_3 = this.builderType.GetMethod("GetValue", true, pindex1, pindex2, pindex3).Import();
			
				return this.var_getvalue_0_3;
			}
			
			if(typeof(System.Int64).AreEqual(pindex1) && typeof(System.Int64).AreEqual(pindex2) && typeof(System.Int64).AreEqual(pindex3))
			{
				if(this.var_getvalue_1_3 == null)
					this.var_getvalue_1_3 = this.builderType.GetMethod("GetValue", true, pindex1, pindex2, pindex3).Import();
			
				return this.var_getvalue_1_3;
			}
			
			return null;
			
		}
				
		private Method var_setvalue_0_2;
				
		private Method var_setvalue_1_2;
				
		private Method var_setvalue_2_2;
				
		private Method var_setvalue_3_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void SetValue(System.Object, Int32)<para/>
		/// Void SetValue(System.Object, Int32[])<para/>
		/// Void SetValue(System.Object, Int64)<para/>
		/// Void SetValue(System.Object, Int64[])<para/>
		/// </summary>
		public Method GetMethod_SetValue(TypeReference pvalue, TypeReference pindex)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pindex))
			{
				if(this.var_setvalue_0_2 == null)
					this.var_setvalue_0_2 = this.builderType.GetMethod("SetValue", true, pvalue, pindex).Import();
			
				return this.var_setvalue_0_2;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int32[]).AreEqual(pindex))
			{
				if(this.var_setvalue_1_2 == null)
					this.var_setvalue_1_2 = this.builderType.GetMethod("SetValue", true, pvalue, pindex).Import();
			
				return this.var_setvalue_1_2;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int64).AreEqual(pindex))
			{
				if(this.var_setvalue_2_2 == null)
					this.var_setvalue_2_2 = this.builderType.GetMethod("SetValue", true, pvalue, pindex).Import();
			
				return this.var_setvalue_2_2;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int64[]).AreEqual(pindex))
			{
				if(this.var_setvalue_3_2 == null)
					this.var_setvalue_3_2 = this.builderType.GetMethod("SetValue", true, pvalue, pindex).Import();
			
				return this.var_setvalue_3_2;
			}
			
			return null;
			
		}
				
		private Method var_setvalue_0_3;
				
		private Method var_setvalue_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void SetValue(System.Object, Int32, Int32)<para/>
		/// Void SetValue(System.Object, Int64, Int64)<para/>
		/// </summary>
		public Method GetMethod_SetValue(TypeReference pvalue, TypeReference pindex1, TypeReference pindex2)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pindex1) && typeof(System.Int32).AreEqual(pindex2))
			{
				if(this.var_setvalue_0_3 == null)
					this.var_setvalue_0_3 = this.builderType.GetMethod("SetValue", true, pvalue, pindex1, pindex2).Import();
			
				return this.var_setvalue_0_3;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int64).AreEqual(pindex1) && typeof(System.Int64).AreEqual(pindex2))
			{
				if(this.var_setvalue_1_3 == null)
					this.var_setvalue_1_3 = this.builderType.GetMethod("SetValue", true, pvalue, pindex1, pindex2).Import();
			
				return this.var_setvalue_1_3;
			}
			
			return null;
			
		}
				
		private Method var_setvalue_0_4;
				
		private Method var_setvalue_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void SetValue(System.Object, Int32, Int32, Int32)<para/>
		/// Void SetValue(System.Object, Int64, Int64, Int64)<para/>
		/// </summary>
		public Method GetMethod_SetValue(TypeReference pvalue, TypeReference pindex1, TypeReference pindex2, TypeReference pindex3)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pindex1) && typeof(System.Int32).AreEqual(pindex2) && typeof(System.Int32).AreEqual(pindex3))
			{
				if(this.var_setvalue_0_4 == null)
					this.var_setvalue_0_4 = this.builderType.GetMethod("SetValue", true, pvalue, pindex1, pindex2, pindex3).Import();
			
				return this.var_setvalue_0_4;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Int64).AreEqual(pindex1) && typeof(System.Int64).AreEqual(pindex2) && typeof(System.Int64).AreEqual(pindex3))
			{
				if(this.var_setvalue_1_4 == null)
					this.var_setvalue_1_4 = this.builderType.GetMethod("SetValue", true, pvalue, pindex1, pindex2, pindex3).Import();
			
				return this.var_setvalue_1_4;
			}
			
			return null;
			
		}
				
		private Method var_get_length_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Length()<para/>
		/// </summary>
		public Method GetMethod_get_Length()
		{
						
			if(this.var_get_length_0_0 == null)
				this.var_get_length_0_0 = this.builderType.GetMethod("get_Length", true);

			return this.var_get_length_0_0;
						
						
		}
				
		private Method var_get_longlength_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 get_LongLength()<para/>
		/// </summary>
		public Method GetMethod_get_LongLength()
		{
						
			if(this.var_get_longlength_0_0 == null)
				this.var_get_longlength_0_0 = this.builderType.GetMethod("get_LongLength", true);

			return this.var_get_longlength_0_0;
						
						
		}
				
		private Method var_getlength_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetLength(Int32)<para/>
		/// </summary>
		public Method GetMethod_GetLength(TypeReference pdimension)
		{
						
						
			if(this.var_getlength_0_1 == null)
				this.var_getlength_0_1 = this.builderType.GetMethod("GetLength", true, pdimension).Import();
			
			return this.var_getlength_0_1;
						
		}
				
		private Method var_getlonglength_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 GetLongLength(Int32)<para/>
		/// </summary>
		public Method GetMethod_GetLongLength(TypeReference pdimension)
		{
						
						
			if(this.var_getlonglength_0_1 == null)
				this.var_getlonglength_0_1 = this.builderType.GetMethod("GetLongLength", true, pdimension).Import();
			
			return this.var_getlonglength_0_1;
						
		}
				
		private Method var_get_rank_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Rank()<para/>
		/// </summary>
		public Method GetMethod_get_Rank()
		{
						
			if(this.var_get_rank_0_0 == null)
				this.var_get_rank_0_0 = this.builderType.GetMethod("get_Rank", true);

			return this.var_get_rank_0_0;
						
						
		}
				
		private Method var_getupperbound_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetUpperBound(Int32)<para/>
		/// </summary>
		public Method GetMethod_GetUpperBound(TypeReference pdimension)
		{
						
						
			if(this.var_getupperbound_0_1 == null)
				this.var_getupperbound_0_1 = this.builderType.GetMethod("GetUpperBound", true, pdimension).Import();
			
			return this.var_getupperbound_0_1;
						
		}
				
		private Method var_getlowerbound_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetLowerBound(Int32)<para/>
		/// </summary>
		public Method GetMethod_GetLowerBound(TypeReference pdimension)
		{
						
						
			if(this.var_getlowerbound_0_1 == null)
				this.var_getlowerbound_0_1 = this.builderType.GetMethod("GetLowerBound", true, pdimension).Import();
			
			return this.var_getlowerbound_0_1;
						
		}
				
		private Method var_get_syncroot_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_SyncRoot()<para/>
		/// </summary>
		public Method GetMethod_get_SyncRoot()
		{
						
			if(this.var_get_syncroot_0_0 == null)
				this.var_get_syncroot_0_0 = this.builderType.GetMethod("get_SyncRoot", true);

			return this.var_get_syncroot_0_0;
						
						
		}
				
		private Method var_get_isreadonly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsReadOnly()<para/>
		/// </summary>
		public Method GetMethod_get_IsReadOnly()
		{
						
			if(this.var_get_isreadonly_0_0 == null)
				this.var_get_isreadonly_0_0 = this.builderType.GetMethod("get_IsReadOnly", true);

			return this.var_get_isreadonly_0_0;
						
						
		}
				
		private Method var_get_isfixedsize_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFixedSize()<para/>
		/// </summary>
		public Method GetMethod_get_IsFixedSize()
		{
						
			if(this.var_get_isfixedsize_0_0 == null)
				this.var_get_isfixedsize_0_0 = this.builderType.GetMethod("get_IsFixedSize", true);

			return this.var_get_isfixedsize_0_0;
						
						
		}
				
		private Method var_get_issynchronized_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSynchronized()<para/>
		/// </summary>
		public Method GetMethod_get_IsSynchronized()
		{
						
			if(this.var_get_issynchronized_0_0 == null)
				this.var_get_issynchronized_0_0 = this.builderType.GetMethod("get_IsSynchronized", true);

			return this.var_get_issynchronized_0_0;
						
						
		}
				
		private Method var_clone_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Clone()<para/>
		/// </summary>
		public Method GetMethod_Clone()
		{
						
			if(this.var_clone_0_0 == null)
				this.var_clone_0_0 = this.builderType.GetMethod("Clone", true);

			return this.var_clone_0_0;
						
						
		}
				
		private Method var_binarysearch_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 BinarySearch(System.Array, System.Object)<para/>
		/// </summary>
		public Method GetMethod_BinarySearch(TypeReference parray, TypeReference pvalue)
		{
						
						
			if(this.var_binarysearch_0_2 == null)
				this.var_binarysearch_0_2 = this.builderType.GetMethod("BinarySearch", true, parray, pvalue).Import();
			
			return this.var_binarysearch_0_2;
						
		}
				
		private Method var_binarysearch_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object)<para/>
		/// </summary>
		public Method GetMethod_BinarySearch(TypeReference parray, TypeReference pindex, TypeReference plength, TypeReference pvalue)
		{
						
						
			if(this.var_binarysearch_0_4 == null)
				this.var_binarysearch_0_4 = this.builderType.GetMethod("BinarySearch", true, parray, pindex, plength, pvalue).Import();
			
			return this.var_binarysearch_0_4;
						
		}
				
		private Method var_binarysearch_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 BinarySearch(System.Array, System.Object, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_BinarySearch(TypeReference parray, TypeReference pvalue, TypeReference pcomparer)
		{
						
						
			if(this.var_binarysearch_0_3 == null)
				this.var_binarysearch_0_3 = this.builderType.GetMethod("BinarySearch", true, parray, pvalue, pcomparer).Import();
			
			return this.var_binarysearch_0_3;
						
		}
				
		private Method var_binarysearch_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_BinarySearch(TypeReference parray, TypeReference pindex, TypeReference plength, TypeReference pvalue, TypeReference pcomparer)
		{
						
						
			if(this.var_binarysearch_0_5 == null)
				this.var_binarysearch_0_5 = this.builderType.GetMethod("BinarySearch", true, parray, pindex, plength, pvalue, pcomparer).Import();
			
			return this.var_binarysearch_0_5;
						
		}
				
		private Method var_copyto_0_2;
				
		private Method var_copyto_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void CopyTo(System.Array, Int32)<para/>
		/// Void CopyTo(System.Array, Int64)<para/>
		/// </summary>
		public Method GetMethod_CopyTo(TypeReference parray, TypeReference pindex)
		{
						
						
			if(typeof(System.Array).AreEqual(parray) && typeof(System.Int32).AreEqual(pindex))
			{
				if(this.var_copyto_0_2 == null)
					this.var_copyto_0_2 = this.builderType.GetMethod("CopyTo", true, parray, pindex).Import();
			
				return this.var_copyto_0_2;
			}
			
			if(typeof(System.Array).AreEqual(parray) && typeof(System.Int64).AreEqual(pindex))
			{
				if(this.var_copyto_1_2 == null)
					this.var_copyto_1_2 = this.builderType.GetMethod("CopyTo", true, parray, pindex).Import();
			
				return this.var_copyto_1_2;
			}
			
			return null;
			
		}
				
		private Method var_getenumerator_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.IEnumerator GetEnumerator()<para/>
		/// </summary>
		public Method GetMethod_GetEnumerator()
		{
						
			if(this.var_getenumerator_0_0 == null)
				this.var_getenumerator_0_0 = this.builderType.GetMethod("GetEnumerator", true);

			return this.var_getenumerator_0_0;
						
						
		}
				
		private Method var_indexof_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(System.Array, System.Object)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference parray, TypeReference pvalue)
		{
						
						
			if(this.var_indexof_0_2 == null)
				this.var_indexof_0_2 = this.builderType.GetMethod("IndexOf", true, parray, pvalue).Import();
			
			return this.var_indexof_0_2;
						
		}
				
		private Method var_indexof_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(System.Array, System.Object, Int32)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference parray, TypeReference pvalue, TypeReference pstartIndex)
		{
						
						
			if(this.var_indexof_0_3 == null)
				this.var_indexof_0_3 = this.builderType.GetMethod("IndexOf", true, parray, pvalue, pstartIndex).Import();
			
			return this.var_indexof_0_3;
						
		}
				
		private Method var_indexof_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(System.Array, System.Object, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference parray, TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_indexof_0_4 == null)
				this.var_indexof_0_4 = this.builderType.GetMethod("IndexOf", true, parray, pvalue, pstartIndex, pcount).Import();
			
			return this.var_indexof_0_4;
						
		}
				
		private Method var_lastindexof_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(System.Array, System.Object)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference parray, TypeReference pvalue)
		{
						
						
			if(this.var_lastindexof_0_2 == null)
				this.var_lastindexof_0_2 = this.builderType.GetMethod("LastIndexOf", true, parray, pvalue).Import();
			
			return this.var_lastindexof_0_2;
						
		}
				
		private Method var_lastindexof_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(System.Array, System.Object, Int32)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference parray, TypeReference pvalue, TypeReference pstartIndex)
		{
						
						
			if(this.var_lastindexof_0_3 == null)
				this.var_lastindexof_0_3 = this.builderType.GetMethod("LastIndexOf", true, parray, pvalue, pstartIndex).Import();
			
			return this.var_lastindexof_0_3;
						
		}
				
		private Method var_lastindexof_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(System.Array, System.Object, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference parray, TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_lastindexof_0_4 == null)
				this.var_lastindexof_0_4 = this.builderType.GetMethod("LastIndexOf", true, parray, pvalue, pstartIndex, pcount).Import();
			
			return this.var_lastindexof_0_4;
						
		}
				
		private Method var_reverse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Reverse(System.Array)<para/>
		/// </summary>
		public Method GetMethod_Reverse(TypeReference parray)
		{
						
						
			if(this.var_reverse_0_1 == null)
				this.var_reverse_0_1 = this.builderType.GetMethod("Reverse", true, parray).Import();
			
			return this.var_reverse_0_1;
						
		}
				
		private Method var_reverse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Reverse(System.Array, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Reverse(TypeReference parray, TypeReference pindex, TypeReference plength)
		{
						
						
			if(this.var_reverse_0_3 == null)
				this.var_reverse_0_3 = this.builderType.GetMethod("Reverse", true, parray, pindex, plength).Import();
			
			return this.var_reverse_0_3;
						
		}
				
		private Method var_sort_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Sort(System.Array)<para/>
		/// </summary>
		public Method GetMethod_Sort(TypeReference parray)
		{
						
						
			if(this.var_sort_0_1 == null)
				this.var_sort_0_1 = this.builderType.GetMethod("Sort", true, parray).Import();
			
			return this.var_sort_0_1;
						
		}
				
		private Method var_sort_0_2;
				
		private Method var_sort_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Sort(System.Array, System.Array)<para/>
		/// Void Sort(System.Array, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_Sort(TypeReference pkeys, TypeReference pitems)
		{
						
						
			if(typeof(System.Array).AreEqual(pkeys) && typeof(System.Array).AreEqual(pitems))
			{
				if(this.var_sort_0_2 == null)
					this.var_sort_0_2 = this.builderType.GetMethod("Sort", true, pkeys, pitems).Import();
			
				return this.var_sort_0_2;
			}
			
			if(typeof(System.Array).AreEqual(pkeys) && typeof(System.Collections.IComparer).AreEqual(pitems))
			{
				if(this.var_sort_1_2 == null)
					this.var_sort_1_2 = this.builderType.GetMethod("Sort", true, pkeys, pitems).Import();
			
				return this.var_sort_1_2;
			}
			
			return null;
			
		}
				
		private Method var_sort_0_3;
				
		private Method var_sort_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Sort(System.Array, Int32, Int32)<para/>
		/// Void Sort(System.Array, System.Array, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_Sort(TypeReference parray, TypeReference pindex, TypeReference plength)
		{
						
						
			if(typeof(System.Array).AreEqual(parray) && typeof(System.Int32).AreEqual(pindex) && typeof(System.Int32).AreEqual(plength))
			{
				if(this.var_sort_0_3 == null)
					this.var_sort_0_3 = this.builderType.GetMethod("Sort", true, parray, pindex, plength).Import();
			
				return this.var_sort_0_3;
			}
			
			if(typeof(System.Array).AreEqual(parray) && typeof(System.Array).AreEqual(pindex) && typeof(System.Collections.IComparer).AreEqual(plength))
			{
				if(this.var_sort_1_3 == null)
					this.var_sort_1_3 = this.builderType.GetMethod("Sort", true, parray, pindex, plength).Import();
			
				return this.var_sort_1_3;
			}
			
			return null;
			
		}
				
		private Method var_sort_0_4;
				
		private Method var_sort_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Sort(System.Array, System.Array, Int32, Int32)<para/>
		/// Void Sort(System.Array, Int32, Int32, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_Sort(TypeReference pkeys, TypeReference pitems, TypeReference pindex, TypeReference plength)
		{
						
						
			if(typeof(System.Array).AreEqual(pkeys) && typeof(System.Array).AreEqual(pitems) && typeof(System.Int32).AreEqual(pindex) && typeof(System.Int32).AreEqual(plength))
			{
				if(this.var_sort_0_4 == null)
					this.var_sort_0_4 = this.builderType.GetMethod("Sort", true, pkeys, pitems, pindex, plength).Import();
			
				return this.var_sort_0_4;
			}
			
			if(typeof(System.Array).AreEqual(pkeys) && typeof(System.Int32).AreEqual(pitems) && typeof(System.Int32).AreEqual(pindex) && typeof(System.Collections.IComparer).AreEqual(plength))
			{
				if(this.var_sort_1_4 == null)
					this.var_sort_1_4 = this.builderType.GetMethod("Sort", true, pkeys, pitems, pindex, plength).Import();
			
				return this.var_sort_1_4;
			}
			
			return null;
			
		}
				
		private Method var_sort_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Sort(System.Array, System.Array, Int32, Int32, System.Collections.IComparer)<para/>
		/// </summary>
		public Method GetMethod_Sort(TypeReference pkeys, TypeReference pitems, TypeReference pindex, TypeReference plength, TypeReference pcomparer)
		{
						
						
			if(this.var_sort_0_5 == null)
				this.var_sort_0_5 = this.builderType.GetMethod("Sort", true, pkeys, pitems, pindex, plength, pcomparer).Import();
			
			return this.var_sort_0_5;
						
		}
				
		private Method var_initialize_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Initialize()<para/>
		/// </summary>
		public Method GetMethod_Initialize()
		{
						
			if(this.var_initialize_0_0 == null)
				this.var_initialize_0_0 = this.builderType.GetMethod("Initialize", true);

			return this.var_initialize_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Boolean"/>
    /// </summary>
    public partial class BuilderTypeBoolean : TypeSystemExBase
	{
        internal BuilderTypeBoolean(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeBoolean value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeBoolean value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_1 == null)
				this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
			return this.var_tostring_0_1;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Boolean)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Boolean)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pobj).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pobj))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pobj).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference pvalue)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, pvalue).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Byte"/>
    /// </summary>
    public partial class BuilderTypeByte : TypeSystemExBase
	{
        internal BuilderTypeByte(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeByte value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeByte value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Byte)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Byte)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Byte).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Byte Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Char"/>
    /// </summary>
    public partial class BuilderTypeChar : TypeSystemExBase
	{
        internal BuilderTypeChar(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeChar value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeChar value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tolower_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToLower(Char, System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_ToLower(TypeReference pc, TypeReference pculture)
		{
						
						
			if(this.var_tolower_0_2 == null)
				this.var_tolower_0_2 = this.builderType.GetMethod("ToLower", true, pc, pculture).Import();
			
			return this.var_tolower_0_2;
						
		}
				
		private Method var_tolower_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToLower(Char)<para/>
		/// </summary>
		public Method GetMethod_ToLower(TypeReference pc)
		{
						
						
			if(this.var_tolower_0_1 == null)
				this.var_tolower_0_1 = this.builderType.GetMethod("ToLower", true, pc).Import();
			
			return this.var_tolower_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Char)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Char).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Char)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(Char)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.Char).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_isdigit_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDigit(Char)<para/>
		/// </summary>
		public Method GetMethod_IsDigit(TypeReference pc)
		{
						
						
			if(this.var_isdigit_0_1 == null)
				this.var_isdigit_0_1 = this.builderType.GetMethod("IsDigit", true, pc).Import();
			
			return this.var_isdigit_0_1;
						
		}
				
		private Method var_isletter_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLetter(Char)<para/>
		/// </summary>
		public Method GetMethod_IsLetter(TypeReference pc)
		{
						
						
			if(this.var_isletter_0_1 == null)
				this.var_isletter_0_1 = this.builderType.GetMethod("IsLetter", true, pc).Import();
			
			return this.var_isletter_0_1;
						
		}
				
		private Method var_iswhitespace_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsWhiteSpace(Char)<para/>
		/// </summary>
		public Method GetMethod_IsWhiteSpace(TypeReference pc)
		{
						
						
			if(this.var_iswhitespace_0_1 == null)
				this.var_iswhitespace_0_1 = this.builderType.GetMethod("IsWhiteSpace", true, pc).Import();
			
			return this.var_iswhitespace_0_1;
						
		}
				
		private Method var_isupper_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsUpper(Char)<para/>
		/// </summary>
		public Method GetMethod_IsUpper(TypeReference pc)
		{
						
						
			if(this.var_isupper_0_1 == null)
				this.var_isupper_0_1 = this.builderType.GetMethod("IsUpper", true, pc).Import();
			
			return this.var_isupper_0_1;
						
		}
				
		private Method var_islower_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLower(Char)<para/>
		/// </summary>
		public Method GetMethod_IsLower(TypeReference pc)
		{
						
						
			if(this.var_islower_0_1 == null)
				this.var_islower_0_1 = this.builderType.GetMethod("IsLower", true, pc).Import();
			
			return this.var_islower_0_1;
						
		}
				
		private Method var_ispunctuation_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsPunctuation(Char)<para/>
		/// </summary>
		public Method GetMethod_IsPunctuation(TypeReference pc)
		{
						
						
			if(this.var_ispunctuation_0_1 == null)
				this.var_ispunctuation_0_1 = this.builderType.GetMethod("IsPunctuation", true, pc).Import();
			
			return this.var_ispunctuation_0_1;
						
		}
				
		private Method var_isletterordigit_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLetterOrDigit(Char)<para/>
		/// </summary>
		public Method GetMethod_IsLetterOrDigit(TypeReference pc)
		{
						
						
			if(this.var_isletterordigit_0_1 == null)
				this.var_isletterordigit_0_1 = this.builderType.GetMethod("IsLetterOrDigit", true, pc).Import();
			
			return this.var_isletterordigit_0_1;
						
		}
				
		private Method var_toupper_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToUpper(Char, System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_ToUpper(TypeReference pc, TypeReference pculture)
		{
						
						
			if(this.var_toupper_0_2 == null)
				this.var_toupper_0_2 = this.builderType.GetMethod("ToUpper", true, pc, pculture).Import();
			
			return this.var_toupper_0_2;
						
		}
				
		private Method var_toupper_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToUpper(Char)<para/>
		/// </summary>
		public Method GetMethod_ToUpper(TypeReference pc)
		{
						
						
			if(this.var_toupper_0_1 == null)
				this.var_toupper_0_1 = this.builderType.GetMethod("ToUpper", true, pc).Import();
			
			return this.var_toupper_0_1;
						
		}
				
		private Method var_toupperinvariant_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToUpperInvariant(Char)<para/>
		/// </summary>
		public Method GetMethod_ToUpperInvariant(TypeReference pc)
		{
						
						
			if(this.var_toupperinvariant_0_1 == null)
				this.var_toupperinvariant_0_1 = this.builderType.GetMethod("ToUpperInvariant", true, pc).Import();
			
			return this.var_toupperinvariant_0_1;
						
		}
				
		private Method var_tolowerinvariant_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToLowerInvariant(Char)<para/>
		/// </summary>
		public Method GetMethod_ToLowerInvariant(TypeReference pc)
		{
						
						
			if(this.var_tolowerinvariant_0_1 == null)
				this.var_tolowerinvariant_0_1 = this.builderType.GetMethod("ToLowerInvariant", true, pc).Import();
			
			return this.var_tolowerinvariant_0_1;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_iscontrol_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsControl(Char)<para/>
		/// </summary>
		public Method GetMethod_IsControl(TypeReference pc)
		{
						
						
			if(this.var_iscontrol_0_1 == null)
				this.var_iscontrol_0_1 = this.builderType.GetMethod("IsControl", true, pc).Import();
			
			return this.var_iscontrol_0_1;
						
		}
				
		private Method var_iscontrol_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsControl(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsControl(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_iscontrol_0_2 == null)
				this.var_iscontrol_0_2 = this.builderType.GetMethod("IsControl", true, ps, pindex).Import();
			
			return this.var_iscontrol_0_2;
						
		}
				
		private Method var_isdigit_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDigit(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsDigit(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isdigit_0_2 == null)
				this.var_isdigit_0_2 = this.builderType.GetMethod("IsDigit", true, ps, pindex).Import();
			
			return this.var_isdigit_0_2;
						
		}
				
		private Method var_isletter_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLetter(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsLetter(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isletter_0_2 == null)
				this.var_isletter_0_2 = this.builderType.GetMethod("IsLetter", true, ps, pindex).Import();
			
			return this.var_isletter_0_2;
						
		}
				
		private Method var_isletterordigit_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLetterOrDigit(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsLetterOrDigit(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isletterordigit_0_2 == null)
				this.var_isletterordigit_0_2 = this.builderType.GetMethod("IsLetterOrDigit", true, ps, pindex).Import();
			
			return this.var_isletterordigit_0_2;
						
		}
				
		private Method var_islower_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLower(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsLower(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_islower_0_2 == null)
				this.var_islower_0_2 = this.builderType.GetMethod("IsLower", true, ps, pindex).Import();
			
			return this.var_islower_0_2;
						
		}
				
		private Method var_isnumber_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNumber(Char)<para/>
		/// </summary>
		public Method GetMethod_IsNumber(TypeReference pc)
		{
						
						
			if(this.var_isnumber_0_1 == null)
				this.var_isnumber_0_1 = this.builderType.GetMethod("IsNumber", true, pc).Import();
			
			return this.var_isnumber_0_1;
						
		}
				
		private Method var_isnumber_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNumber(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsNumber(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isnumber_0_2 == null)
				this.var_isnumber_0_2 = this.builderType.GetMethod("IsNumber", true, ps, pindex).Import();
			
			return this.var_isnumber_0_2;
						
		}
				
		private Method var_ispunctuation_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsPunctuation(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsPunctuation(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_ispunctuation_0_2 == null)
				this.var_ispunctuation_0_2 = this.builderType.GetMethod("IsPunctuation", true, ps, pindex).Import();
			
			return this.var_ispunctuation_0_2;
						
		}
				
		private Method var_isseparator_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSeparator(Char)<para/>
		/// </summary>
		public Method GetMethod_IsSeparator(TypeReference pc)
		{
						
						
			if(this.var_isseparator_0_1 == null)
				this.var_isseparator_0_1 = this.builderType.GetMethod("IsSeparator", true, pc).Import();
			
			return this.var_isseparator_0_1;
						
		}
				
		private Method var_isseparator_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSeparator(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsSeparator(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isseparator_0_2 == null)
				this.var_isseparator_0_2 = this.builderType.GetMethod("IsSeparator", true, ps, pindex).Import();
			
			return this.var_isseparator_0_2;
						
		}
				
		private Method var_issurrogate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSurrogate(Char)<para/>
		/// </summary>
		public Method GetMethod_IsSurrogate(TypeReference pc)
		{
						
						
			if(this.var_issurrogate_0_1 == null)
				this.var_issurrogate_0_1 = this.builderType.GetMethod("IsSurrogate", true, pc).Import();
			
			return this.var_issurrogate_0_1;
						
		}
				
		private Method var_issurrogate_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSurrogate(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsSurrogate(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_issurrogate_0_2 == null)
				this.var_issurrogate_0_2 = this.builderType.GetMethod("IsSurrogate", true, ps, pindex).Import();
			
			return this.var_issurrogate_0_2;
						
		}
				
		private Method var_issymbol_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSymbol(Char)<para/>
		/// </summary>
		public Method GetMethod_IsSymbol(TypeReference pc)
		{
						
						
			if(this.var_issymbol_0_1 == null)
				this.var_issymbol_0_1 = this.builderType.GetMethod("IsSymbol", true, pc).Import();
			
			return this.var_issymbol_0_1;
						
		}
				
		private Method var_issymbol_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSymbol(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsSymbol(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_issymbol_0_2 == null)
				this.var_issymbol_0_2 = this.builderType.GetMethod("IsSymbol", true, ps, pindex).Import();
			
			return this.var_issymbol_0_2;
						
		}
				
		private Method var_isupper_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsUpper(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsUpper(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_isupper_0_2 == null)
				this.var_isupper_0_2 = this.builderType.GetMethod("IsUpper", true, ps, pindex).Import();
			
			return this.var_isupper_0_2;
						
		}
				
		private Method var_iswhitespace_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsWhiteSpace(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsWhiteSpace(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_iswhitespace_0_2 == null)
				this.var_iswhitespace_0_2 = this.builderType.GetMethod("IsWhiteSpace", true, ps, pindex).Import();
			
			return this.var_iswhitespace_0_2;
						
		}
				
		private Method var_getunicodecategory_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(Char)<para/>
		/// </summary>
		public Method GetMethod_GetUnicodeCategory(TypeReference pc)
		{
						
						
			if(this.var_getunicodecategory_0_1 == null)
				this.var_getunicodecategory_0_1 = this.builderType.GetMethod("GetUnicodeCategory", true, pc).Import();
			
			return this.var_getunicodecategory_0_1;
						
		}
				
		private Method var_getunicodecategory_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_GetUnicodeCategory(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_getunicodecategory_0_2 == null)
				this.var_getunicodecategory_0_2 = this.builderType.GetMethod("GetUnicodeCategory", true, ps, pindex).Import();
			
			return this.var_getunicodecategory_0_2;
						
		}
				
		private Method var_getnumericvalue_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double GetNumericValue(Char)<para/>
		/// </summary>
		public Method GetMethod_GetNumericValue(TypeReference pc)
		{
						
						
			if(this.var_getnumericvalue_0_1 == null)
				this.var_getnumericvalue_0_1 = this.builderType.GetMethod("GetNumericValue", true, pc).Import();
			
			return this.var_getnumericvalue_0_1;
						
		}
				
		private Method var_getnumericvalue_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double GetNumericValue(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_GetNumericValue(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_getnumericvalue_0_2 == null)
				this.var_getnumericvalue_0_2 = this.builderType.GetMethod("GetNumericValue", true, ps, pindex).Import();
			
			return this.var_getnumericvalue_0_2;
						
		}
				
		private Method var_ishighsurrogate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsHighSurrogate(Char)<para/>
		/// </summary>
		public Method GetMethod_IsHighSurrogate(TypeReference pc)
		{
						
						
			if(this.var_ishighsurrogate_0_1 == null)
				this.var_ishighsurrogate_0_1 = this.builderType.GetMethod("IsHighSurrogate", true, pc).Import();
			
			return this.var_ishighsurrogate_0_1;
						
		}
				
		private Method var_ishighsurrogate_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsHighSurrogate(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsHighSurrogate(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_ishighsurrogate_0_2 == null)
				this.var_ishighsurrogate_0_2 = this.builderType.GetMethod("IsHighSurrogate", true, ps, pindex).Import();
			
			return this.var_ishighsurrogate_0_2;
						
		}
				
		private Method var_islowsurrogate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLowSurrogate(Char)<para/>
		/// </summary>
		public Method GetMethod_IsLowSurrogate(TypeReference pc)
		{
						
						
			if(this.var_islowsurrogate_0_1 == null)
				this.var_islowsurrogate_0_1 = this.builderType.GetMethod("IsLowSurrogate", true, pc).Import();
			
			return this.var_islowsurrogate_0_1;
						
		}
				
		private Method var_islowsurrogate_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLowSurrogate(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_IsLowSurrogate(TypeReference ps, TypeReference pindex)
		{
						
						
			if(this.var_islowsurrogate_0_2 == null)
				this.var_islowsurrogate_0_2 = this.builderType.GetMethod("IsLowSurrogate", true, ps, pindex).Import();
			
			return this.var_islowsurrogate_0_2;
						
		}
				
		private Method var_issurrogatepair_0_2;
				
		private Method var_issurrogatepair_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSurrogatePair(System.String, Int32)<para/>
		/// Boolean IsSurrogatePair(Char, Char)<para/>
		/// </summary>
		public Method GetMethod_IsSurrogatePair(TypeReference ps, TypeReference pindex)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Int32).AreEqual(pindex))
			{
				if(this.var_issurrogatepair_0_2 == null)
					this.var_issurrogatepair_0_2 = this.builderType.GetMethod("IsSurrogatePair", true, ps, pindex).Import();
			
				return this.var_issurrogatepair_0_2;
			}
			
			if(typeof(System.Char).AreEqual(ps) && typeof(System.Char).AreEqual(pindex))
			{
				if(this.var_issurrogatepair_1_2 == null)
					this.var_issurrogatepair_1_2 = this.builderType.GetMethod("IsSurrogatePair", true, ps, pindex).Import();
			
				return this.var_issurrogatepair_1_2;
			}
			
			return null;
			
		}
				
		private Method var_convertfromutf32_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ConvertFromUtf32(Int32)<para/>
		/// </summary>
		public Method GetMethod_ConvertFromUtf32(TypeReference putf32)
		{
						
						
			if(this.var_convertfromutf32_0_1 == null)
				this.var_convertfromutf32_0_1 = this.builderType.GetMethod("ConvertFromUtf32", true, putf32).Import();
			
			return this.var_convertfromutf32_0_1;
						
		}
				
		private Method var_converttoutf32_0_2;
				
		private Method var_converttoutf32_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ConvertToUtf32(Char, Char)<para/>
		/// Int32 ConvertToUtf32(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ConvertToUtf32(TypeReference phighSurrogate, TypeReference plowSurrogate)
		{
						
						
			if(typeof(System.Char).AreEqual(phighSurrogate) && typeof(System.Char).AreEqual(plowSurrogate))
			{
				if(this.var_converttoutf32_0_2 == null)
					this.var_converttoutf32_0_2 = this.builderType.GetMethod("ConvertToUtf32", true, phighSurrogate, plowSurrogate).Import();
			
				return this.var_converttoutf32_0_2;
			}
			
			if(typeof(System.String).AreEqual(phighSurrogate) && typeof(System.Int32).AreEqual(plowSurrogate))
			{
				if(this.var_converttoutf32_1_2 == null)
					this.var_converttoutf32_1_2 = this.builderType.GetMethod("ConvertToUtf32", true, phighSurrogate, plowSurrogate).Import();
			
				return this.var_converttoutf32_1_2;
			}
			
			return null;
			
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Convert"/>
    /// </summary>
    public partial class BuilderTypeConvert : TypeSystemExBase
	{
        internal BuilderTypeConvert(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeConvert value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeConvert value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_gettypecode_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode(System.Object)<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode(TypeReference pvalue)
		{
						
						
			if(this.var_gettypecode_0_1 == null)
				this.var_gettypecode_0_1 = this.builderType.GetMethod("GetTypeCode", true, pvalue).Import();
			
			return this.var_gettypecode_0_1;
						
		}
				
		private Method var_isdbnull_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDBNull(System.Object)<para/>
		/// </summary>
		public Method GetMethod_IsDBNull(TypeReference pvalue)
		{
						
						
			if(this.var_isdbnull_0_1 == null)
				this.var_isdbnull_0_1 = this.builderType.GetMethod("IsDBNull", true, pvalue).Import();
			
			return this.var_isdbnull_0_1;
						
		}
				
		private Method var_changetype_0_2;
				
		private Method var_changetype_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object ChangeType(System.Object, System.TypeCode)<para/>
		/// System.Object ChangeType(System.Object, System.Type)<para/>
		/// </summary>
		public Method GetMethod_ChangeType(TypeReference pvalue, TypeReference ptypeCode)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.TypeCode).AreEqual(ptypeCode))
			{
				if(this.var_changetype_0_2 == null)
					this.var_changetype_0_2 = this.builderType.GetMethod("ChangeType", true, pvalue, ptypeCode).Import();
			
				return this.var_changetype_0_2;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Type).AreEqual(ptypeCode))
			{
				if(this.var_changetype_1_2 == null)
					this.var_changetype_1_2 = this.builderType.GetMethod("ChangeType", true, pvalue, ptypeCode).Import();
			
				return this.var_changetype_1_2;
			}
			
			return null;
			
		}
				
		private Method var_changetype_0_3;
				
		private Method var_changetype_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object ChangeType(System.Object, System.TypeCode, System.IFormatProvider)<para/>
		/// System.Object ChangeType(System.Object, System.Type, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ChangeType(TypeReference pvalue, TypeReference ptypeCode, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.TypeCode).AreEqual(ptypeCode) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_changetype_0_3 == null)
					this.var_changetype_0_3 = this.builderType.GetMethod("ChangeType", true, pvalue, ptypeCode, pprovider).Import();
			
				return this.var_changetype_0_3;
			}
			
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.Type).AreEqual(ptypeCode) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_changetype_1_3 == null)
					this.var_changetype_1_3 = this.builderType.GetMethod("ChangeType", true, pvalue, ptypeCode, pprovider).Import();
			
				return this.var_changetype_1_3;
			}
			
			return null;
			
		}
				
		private Method var_toboolean_0_1;
				
		private Method var_toboolean_1_1;
				
		private Method var_toboolean_2_1;
				
		private Method var_toboolean_3_1;
				
		private Method var_toboolean_4_1;
				
		private Method var_toboolean_5_1;
				
		private Method var_toboolean_6_1;
				
		private Method var_toboolean_7_1;
				
		private Method var_toboolean_8_1;
				
		private Method var_toboolean_9_1;
				
		private Method var_toboolean_10_1;
				
		private Method var_toboolean_11_1;
				
		private Method var_toboolean_12_1;
				
		private Method var_toboolean_13_1;
				
		private Method var_toboolean_14_1;
				
		private Method var_toboolean_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean ToBoolean(System.Object)<para/>
		/// Boolean ToBoolean(Boolean)<para/>
		/// Boolean ToBoolean(SByte)<para/>
		/// Boolean ToBoolean(Char)<para/>
		/// Boolean ToBoolean(Byte)<para/>
		/// Boolean ToBoolean(Int16)<para/>
		/// Boolean ToBoolean(UInt16)<para/>
		/// Boolean ToBoolean(Int32)<para/>
		/// Boolean ToBoolean(UInt32)<para/>
		/// Boolean ToBoolean(Int64)<para/>
		/// Boolean ToBoolean(UInt64)<para/>
		/// Boolean ToBoolean(System.String)<para/>
		/// Boolean ToBoolean(Single)<para/>
		/// Boolean ToBoolean(Double)<para/>
		/// Boolean ToBoolean(System.Decimal)<para/>
		/// Boolean ToBoolean(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToBoolean(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_toboolean_0_1 == null)
					this.var_toboolean_0_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_toboolean_1_1 == null)
					this.var_toboolean_1_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_1_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_toboolean_2_1 == null)
					this.var_toboolean_2_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_2_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_toboolean_3_1 == null)
					this.var_toboolean_3_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_toboolean_4_1 == null)
					this.var_toboolean_4_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_toboolean_5_1 == null)
					this.var_toboolean_5_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_toboolean_6_1 == null)
					this.var_toboolean_6_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_toboolean_7_1 == null)
					this.var_toboolean_7_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_toboolean_8_1 == null)
					this.var_toboolean_8_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_toboolean_9_1 == null)
					this.var_toboolean_9_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_toboolean_10_1 == null)
					this.var_toboolean_10_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_10_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_toboolean_11_1 == null)
					this.var_toboolean_11_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_11_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_toboolean_12_1 == null)
					this.var_toboolean_12_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_12_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_toboolean_13_1 == null)
					this.var_toboolean_13_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_13_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_toboolean_14_1 == null)
					this.var_toboolean_14_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_toboolean_15_1 == null)
					this.var_toboolean_15_1 = this.builderType.GetMethod("ToBoolean", true, pvalue).Import();
			
				return this.var_toboolean_15_1;
			}
            			
			return null;
			
		}
				
		private Method var_toboolean_0_2;
				
		private Method var_toboolean_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean ToBoolean(System.Object, System.IFormatProvider)<para/>
		/// Boolean ToBoolean(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToBoolean(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toboolean_0_2 == null)
					this.var_toboolean_0_2 = this.builderType.GetMethod("ToBoolean", true, pvalue, pprovider).Import();
			
				return this.var_toboolean_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toboolean_1_2 == null)
					this.var_toboolean_1_2 = this.builderType.GetMethod("ToBoolean", true, pvalue, pprovider).Import();
			
				return this.var_toboolean_1_2;
			}
			
			return null;
			
		}
				
		private Method var_tochar_0_1;
				
		private Method var_tochar_1_1;
				
		private Method var_tochar_2_1;
				
		private Method var_tochar_3_1;
				
		private Method var_tochar_4_1;
				
		private Method var_tochar_5_1;
				
		private Method var_tochar_6_1;
				
		private Method var_tochar_7_1;
				
		private Method var_tochar_8_1;
				
		private Method var_tochar_9_1;
				
		private Method var_tochar_10_1;
				
		private Method var_tochar_11_1;
				
		private Method var_tochar_12_1;
				
		private Method var_tochar_13_1;
				
		private Method var_tochar_14_1;
				
		private Method var_tochar_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToChar(System.Object)<para/>
		/// Char ToChar(Boolean)<para/>
		/// Char ToChar(Char)<para/>
		/// Char ToChar(SByte)<para/>
		/// Char ToChar(Byte)<para/>
		/// Char ToChar(Int16)<para/>
		/// Char ToChar(UInt16)<para/>
		/// Char ToChar(Int32)<para/>
		/// Char ToChar(UInt32)<para/>
		/// Char ToChar(Int64)<para/>
		/// Char ToChar(UInt64)<para/>
		/// Char ToChar(System.String)<para/>
		/// Char ToChar(Single)<para/>
		/// Char ToChar(Double)<para/>
		/// Char ToChar(System.Decimal)<para/>
		/// Char ToChar(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToChar(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_tochar_0_1 == null)
					this.var_tochar_0_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_tochar_1_1 == null)
					this.var_tochar_1_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_tochar_2_1 == null)
					this.var_tochar_2_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_tochar_3_1 == null)
					this.var_tochar_3_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_tochar_4_1 == null)
					this.var_tochar_4_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_tochar_5_1 == null)
					this.var_tochar_5_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_tochar_6_1 == null)
					this.var_tochar_6_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_tochar_7_1 == null)
					this.var_tochar_7_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_tochar_8_1 == null)
					this.var_tochar_8_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_tochar_9_1 == null)
					this.var_tochar_9_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_tochar_10_1 == null)
					this.var_tochar_10_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_10_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_tochar_11_1 == null)
					this.var_tochar_11_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_11_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_tochar_12_1 == null)
					this.var_tochar_12_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_12_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_tochar_13_1 == null)
					this.var_tochar_13_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_13_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_tochar_14_1 == null)
					this.var_tochar_14_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_tochar_15_1 == null)
					this.var_tochar_15_1 = this.builderType.GetMethod("ToChar", true, pvalue).Import();
			
				return this.var_tochar_15_1;
			}
			
			return null;
			
		}
				
		private Method var_tochar_0_2;
				
		private Method var_tochar_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char ToChar(System.Object, System.IFormatProvider)<para/>
		/// Char ToChar(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToChar(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tochar_0_2 == null)
					this.var_tochar_0_2 = this.builderType.GetMethod("ToChar", true, pvalue, pprovider).Import();
			
				return this.var_tochar_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tochar_1_2 == null)
					this.var_tochar_1_2 = this.builderType.GetMethod("ToChar", true, pvalue, pprovider).Import();
			
				return this.var_tochar_1_2;
			}
			
			return null;
			
		}
				
		private Method var_tosbyte_0_1;
				
		private Method var_tosbyte_1_1;
				
		private Method var_tosbyte_2_1;
				
		private Method var_tosbyte_3_1;
				
		private Method var_tosbyte_4_1;
				
		private Method var_tosbyte_5_1;
				
		private Method var_tosbyte_6_1;
				
		private Method var_tosbyte_7_1;
				
		private Method var_tosbyte_8_1;
				
		private Method var_tosbyte_9_1;
				
		private Method var_tosbyte_10_1;
				
		private Method var_tosbyte_11_1;
				
		private Method var_tosbyte_12_1;
				
		private Method var_tosbyte_13_1;
				
		private Method var_tosbyte_14_1;
				
		private Method var_tosbyte_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte ToSByte(System.Object)<para/>
		/// SByte ToSByte(Boolean)<para/>
		/// SByte ToSByte(SByte)<para/>
		/// SByte ToSByte(Char)<para/>
		/// SByte ToSByte(Byte)<para/>
		/// SByte ToSByte(Int16)<para/>
		/// SByte ToSByte(UInt16)<para/>
		/// SByte ToSByte(Int32)<para/>
		/// SByte ToSByte(UInt32)<para/>
		/// SByte ToSByte(Int64)<para/>
		/// SByte ToSByte(UInt64)<para/>
		/// SByte ToSByte(Single)<para/>
		/// SByte ToSByte(Double)<para/>
		/// SByte ToSByte(System.Decimal)<para/>
		/// SByte ToSByte(System.String)<para/>
		/// SByte ToSByte(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToSByte(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_tosbyte_0_1 == null)
					this.var_tosbyte_0_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_tosbyte_1_1 == null)
					this.var_tosbyte_1_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_1_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_tosbyte_2_1 == null)
					this.var_tosbyte_2_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_2_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_tosbyte_3_1 == null)
					this.var_tosbyte_3_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_tosbyte_4_1 == null)
					this.var_tosbyte_4_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_tosbyte_5_1 == null)
					this.var_tosbyte_5_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_tosbyte_6_1 == null)
					this.var_tosbyte_6_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_tosbyte_7_1 == null)
					this.var_tosbyte_7_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_tosbyte_8_1 == null)
					this.var_tosbyte_8_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_tosbyte_9_1 == null)
					this.var_tosbyte_9_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_tosbyte_10_1 == null)
					this.var_tosbyte_10_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_tosbyte_11_1 == null)
					this.var_tosbyte_11_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_tosbyte_12_1 == null)
					this.var_tosbyte_12_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_tosbyte_13_1 == null)
					this.var_tosbyte_13_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_tosbyte_14_1 == null)
					this.var_tosbyte_14_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_tosbyte_15_1 == null)
					this.var_tosbyte_15_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
				return this.var_tosbyte_15_1;
			}
			
			return null;
			
		}
				
		private Method var_tosbyte_0_2;
				
		private Method var_tosbyte_1_2;
				
		private Method var_tosbyte_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte ToSByte(System.Object, System.IFormatProvider)<para/>
		/// SByte ToSByte(System.String, System.IFormatProvider)<para/>
		/// SByte ToSByte(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToSByte(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tosbyte_0_2 == null)
					this.var_tosbyte_0_2 = this.builderType.GetMethod("ToSByte", true, pvalue, pprovider).Import();
			
				return this.var_tosbyte_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tosbyte_1_2 == null)
					this.var_tosbyte_1_2 = this.builderType.GetMethod("ToSByte", true, pvalue, pprovider).Import();
			
				return this.var_tosbyte_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tosbyte_2_2 == null)
					this.var_tosbyte_2_2 = this.builderType.GetMethod("ToSByte", true, pvalue, pprovider).Import();
			
				return this.var_tosbyte_2_2;
			}
			
			return null;
			
		}
				
		private Method var_tobyte_0_1;
				
		private Method var_tobyte_1_1;
				
		private Method var_tobyte_2_1;
				
		private Method var_tobyte_3_1;
				
		private Method var_tobyte_4_1;
				
		private Method var_tobyte_5_1;
				
		private Method var_tobyte_6_1;
				
		private Method var_tobyte_7_1;
				
		private Method var_tobyte_8_1;
				
		private Method var_tobyte_9_1;
				
		private Method var_tobyte_10_1;
				
		private Method var_tobyte_11_1;
				
		private Method var_tobyte_12_1;
				
		private Method var_tobyte_13_1;
				
		private Method var_tobyte_14_1;
				
		private Method var_tobyte_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte ToByte(System.Object)<para/>
		/// Byte ToByte(Boolean)<para/>
		/// Byte ToByte(Byte)<para/>
		/// Byte ToByte(Char)<para/>
		/// Byte ToByte(SByte)<para/>
		/// Byte ToByte(Int16)<para/>
		/// Byte ToByte(UInt16)<para/>
		/// Byte ToByte(Int32)<para/>
		/// Byte ToByte(UInt32)<para/>
		/// Byte ToByte(Int64)<para/>
		/// Byte ToByte(UInt64)<para/>
		/// Byte ToByte(Single)<para/>
		/// Byte ToByte(Double)<para/>
		/// Byte ToByte(System.Decimal)<para/>
		/// Byte ToByte(System.String)<para/>
		/// Byte ToByte(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToByte(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_tobyte_0_1 == null)
					this.var_tobyte_0_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_tobyte_1_1 == null)
					this.var_tobyte_1_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_1_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_tobyte_2_1 == null)
					this.var_tobyte_2_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_2_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_tobyte_3_1 == null)
					this.var_tobyte_3_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_3_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_tobyte_4_1 == null)
					this.var_tobyte_4_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_tobyte_5_1 == null)
					this.var_tobyte_5_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_tobyte_6_1 == null)
					this.var_tobyte_6_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_tobyte_7_1 == null)
					this.var_tobyte_7_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_tobyte_8_1 == null)
					this.var_tobyte_8_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_tobyte_9_1 == null)
					this.var_tobyte_9_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_tobyte_10_1 == null)
					this.var_tobyte_10_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_tobyte_11_1 == null)
					this.var_tobyte_11_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_tobyte_12_1 == null)
					this.var_tobyte_12_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_tobyte_13_1 == null)
					this.var_tobyte_13_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_tobyte_14_1 == null)
					this.var_tobyte_14_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_tobyte_15_1 == null)
					this.var_tobyte_15_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
				return this.var_tobyte_15_1;
			}
			
			return null;
			
		}
				
		private Method var_tobyte_0_2;
				
		private Method var_tobyte_1_2;
				
		private Method var_tobyte_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte ToByte(System.Object, System.IFormatProvider)<para/>
		/// Byte ToByte(System.String, System.IFormatProvider)<para/>
		/// Byte ToByte(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToByte(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tobyte_0_2 == null)
					this.var_tobyte_0_2 = this.builderType.GetMethod("ToByte", true, pvalue, pprovider).Import();
			
				return this.var_tobyte_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tobyte_1_2 == null)
					this.var_tobyte_1_2 = this.builderType.GetMethod("ToByte", true, pvalue, pprovider).Import();
			
				return this.var_tobyte_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tobyte_2_2 == null)
					this.var_tobyte_2_2 = this.builderType.GetMethod("ToByte", true, pvalue, pprovider).Import();
			
				return this.var_tobyte_2_2;
			}
			
			return null;
			
		}
				
		private Method var_toint16_0_1;
				
		private Method var_toint16_1_1;
				
		private Method var_toint16_2_1;
				
		private Method var_toint16_3_1;
				
		private Method var_toint16_4_1;
				
		private Method var_toint16_5_1;
				
		private Method var_toint16_6_1;
				
		private Method var_toint16_7_1;
				
		private Method var_toint16_8_1;
				
		private Method var_toint16_9_1;
				
		private Method var_toint16_10_1;
				
		private Method var_toint16_11_1;
				
		private Method var_toint16_12_1;
				
		private Method var_toint16_13_1;
				
		private Method var_toint16_14_1;
				
		private Method var_toint16_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 ToInt16(System.Object)<para/>
		/// Int16 ToInt16(Boolean)<para/>
		/// Int16 ToInt16(Char)<para/>
		/// Int16 ToInt16(SByte)<para/>
		/// Int16 ToInt16(Byte)<para/>
		/// Int16 ToInt16(UInt16)<para/>
		/// Int16 ToInt16(Int32)<para/>
		/// Int16 ToInt16(UInt32)<para/>
		/// Int16 ToInt16(Int16)<para/>
		/// Int16 ToInt16(Int64)<para/>
		/// Int16 ToInt16(UInt64)<para/>
		/// Int16 ToInt16(Single)<para/>
		/// Int16 ToInt16(Double)<para/>
		/// Int16 ToInt16(System.Decimal)<para/>
		/// Int16 ToInt16(System.String)<para/>
		/// Int16 ToInt16(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToInt16(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_toint16_0_1 == null)
					this.var_toint16_0_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_toint16_1_1 == null)
					this.var_toint16_1_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_toint16_2_1 == null)
					this.var_toint16_2_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_toint16_3_1 == null)
					this.var_toint16_3_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_toint16_4_1 == null)
					this.var_toint16_4_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_4_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_toint16_5_1 == null)
					this.var_toint16_5_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_5_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_toint16_6_1 == null)
					this.var_toint16_6_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_6_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_toint16_7_1 == null)
					this.var_toint16_7_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_7_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_toint16_8_1 == null)
					this.var_toint16_8_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_toint16_9_1 == null)
					this.var_toint16_9_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_toint16_10_1 == null)
					this.var_toint16_10_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_toint16_11_1 == null)
					this.var_toint16_11_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_toint16_12_1 == null)
					this.var_toint16_12_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_toint16_13_1 == null)
					this.var_toint16_13_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_toint16_14_1 == null)
					this.var_toint16_14_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_toint16_15_1 == null)
					this.var_toint16_15_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
				return this.var_toint16_15_1;
			}
			
			return null;
			
		}
				
		private Method var_toint16_0_2;
				
		private Method var_toint16_1_2;
				
		private Method var_toint16_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 ToInt16(System.Object, System.IFormatProvider)<para/>
		/// Int16 ToInt16(System.String, System.IFormatProvider)<para/>
		/// Int16 ToInt16(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToInt16(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint16_0_2 == null)
					this.var_toint16_0_2 = this.builderType.GetMethod("ToInt16", true, pvalue, pprovider).Import();
			
				return this.var_toint16_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint16_1_2 == null)
					this.var_toint16_1_2 = this.builderType.GetMethod("ToInt16", true, pvalue, pprovider).Import();
			
				return this.var_toint16_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_toint16_2_2 == null)
					this.var_toint16_2_2 = this.builderType.GetMethod("ToInt16", true, pvalue, pprovider).Import();
			
				return this.var_toint16_2_2;
			}
			
			return null;
			
		}
				
		private Method var_touint16_0_1;
				
		private Method var_touint16_1_1;
				
		private Method var_touint16_2_1;
				
		private Method var_touint16_3_1;
				
		private Method var_touint16_4_1;
				
		private Method var_touint16_5_1;
				
		private Method var_touint16_6_1;
				
		private Method var_touint16_7_1;
				
		private Method var_touint16_8_1;
				
		private Method var_touint16_9_1;
				
		private Method var_touint16_10_1;
				
		private Method var_touint16_11_1;
				
		private Method var_touint16_12_1;
				
		private Method var_touint16_13_1;
				
		private Method var_touint16_14_1;
				
		private Method var_touint16_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 ToUInt16(System.Object)<para/>
		/// UInt16 ToUInt16(Boolean)<para/>
		/// UInt16 ToUInt16(Char)<para/>
		/// UInt16 ToUInt16(SByte)<para/>
		/// UInt16 ToUInt16(Byte)<para/>
		/// UInt16 ToUInt16(Int16)<para/>
		/// UInt16 ToUInt16(Int32)<para/>
		/// UInt16 ToUInt16(UInt16)<para/>
		/// UInt16 ToUInt16(UInt32)<para/>
		/// UInt16 ToUInt16(Int64)<para/>
		/// UInt16 ToUInt16(UInt64)<para/>
		/// UInt16 ToUInt16(Single)<para/>
		/// UInt16 ToUInt16(Double)<para/>
		/// UInt16 ToUInt16(System.Decimal)<para/>
		/// UInt16 ToUInt16(System.String)<para/>
		/// UInt16 ToUInt16(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToUInt16(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_touint16_0_1 == null)
					this.var_touint16_0_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_touint16_1_1 == null)
					this.var_touint16_1_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_touint16_2_1 == null)
					this.var_touint16_2_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_touint16_3_1 == null)
					this.var_touint16_3_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_touint16_4_1 == null)
					this.var_touint16_4_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_touint16_5_1 == null)
					this.var_touint16_5_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_5_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_touint16_6_1 == null)
					this.var_touint16_6_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_6_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_touint16_7_1 == null)
					this.var_touint16_7_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_touint16_8_1 == null)
					this.var_touint16_8_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_touint16_9_1 == null)
					this.var_touint16_9_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_touint16_10_1 == null)
					this.var_touint16_10_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_touint16_11_1 == null)
					this.var_touint16_11_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_touint16_12_1 == null)
					this.var_touint16_12_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_touint16_13_1 == null)
					this.var_touint16_13_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_touint16_14_1 == null)
					this.var_touint16_14_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_touint16_15_1 == null)
					this.var_touint16_15_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
				return this.var_touint16_15_1;
			}
			
			return null;
			
		}
				
		private Method var_touint16_0_2;
				
		private Method var_touint16_1_2;
				
		private Method var_touint16_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 ToUInt16(System.Object, System.IFormatProvider)<para/>
		/// UInt16 ToUInt16(System.String, System.IFormatProvider)<para/>
		/// UInt16 ToUInt16(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToUInt16(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint16_0_2 == null)
					this.var_touint16_0_2 = this.builderType.GetMethod("ToUInt16", true, pvalue, pprovider).Import();
			
				return this.var_touint16_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint16_1_2 == null)
					this.var_touint16_1_2 = this.builderType.GetMethod("ToUInt16", true, pvalue, pprovider).Import();
			
				return this.var_touint16_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_touint16_2_2 == null)
					this.var_touint16_2_2 = this.builderType.GetMethod("ToUInt16", true, pvalue, pprovider).Import();
			
				return this.var_touint16_2_2;
			}
			
			return null;
			
		}
				
		private Method var_toint32_0_1;
				
		private Method var_toint32_1_1;
				
		private Method var_toint32_2_1;
				
		private Method var_toint32_3_1;
				
		private Method var_toint32_4_1;
				
		private Method var_toint32_5_1;
				
		private Method var_toint32_6_1;
				
		private Method var_toint32_7_1;
				
		private Method var_toint32_8_1;
				
		private Method var_toint32_9_1;
				
		private Method var_toint32_10_1;
				
		private Method var_toint32_11_1;
				
		private Method var_toint32_12_1;
				
		private Method var_toint32_13_1;
				
		private Method var_toint32_14_1;
				
		private Method var_toint32_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToInt32(System.Object)<para/>
		/// Int32 ToInt32(Boolean)<para/>
		/// Int32 ToInt32(Char)<para/>
		/// Int32 ToInt32(SByte)<para/>
		/// Int32 ToInt32(Byte)<para/>
		/// Int32 ToInt32(Int16)<para/>
		/// Int32 ToInt32(UInt16)<para/>
		/// Int32 ToInt32(UInt32)<para/>
		/// Int32 ToInt32(Int32)<para/>
		/// Int32 ToInt32(Int64)<para/>
		/// Int32 ToInt32(UInt64)<para/>
		/// Int32 ToInt32(Single)<para/>
		/// Int32 ToInt32(Double)<para/>
		/// Int32 ToInt32(System.Decimal)<para/>
		/// Int32 ToInt32(System.String)<para/>
		/// Int32 ToInt32(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToInt32(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_toint32_0_1 == null)
					this.var_toint32_0_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_toint32_1_1 == null)
					this.var_toint32_1_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_toint32_2_1 == null)
					this.var_toint32_2_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_toint32_3_1 == null)
					this.var_toint32_3_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_toint32_4_1 == null)
					this.var_toint32_4_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_toint32_5_1 == null)
					this.var_toint32_5_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_toint32_6_1 == null)
					this.var_toint32_6_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_6_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_toint32_7_1 == null)
					this.var_toint32_7_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_7_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_toint32_8_1 == null)
					this.var_toint32_8_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_toint32_9_1 == null)
					this.var_toint32_9_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_toint32_10_1 == null)
					this.var_toint32_10_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_toint32_11_1 == null)
					this.var_toint32_11_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_toint32_12_1 == null)
					this.var_toint32_12_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_toint32_13_1 == null)
					this.var_toint32_13_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_toint32_14_1 == null)
					this.var_toint32_14_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_toint32_15_1 == null)
					this.var_toint32_15_1 = this.builderType.GetMethod("ToInt32", true, pvalue).Import();
			
				return this.var_toint32_15_1;
			}
			
			return null;
			
		}
				
		private Method var_toint32_0_2;
				
		private Method var_toint32_1_2;
				
		private Method var_toint32_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToInt32(System.Object, System.IFormatProvider)<para/>
		/// Int32 ToInt32(System.String, System.IFormatProvider)<para/>
		/// Int32 ToInt32(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToInt32(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint32_0_2 == null)
					this.var_toint32_0_2 = this.builderType.GetMethod("ToInt32", true, pvalue, pprovider).Import();
			
				return this.var_toint32_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint32_1_2 == null)
					this.var_toint32_1_2 = this.builderType.GetMethod("ToInt32", true, pvalue, pprovider).Import();
			
				return this.var_toint32_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_toint32_2_2 == null)
					this.var_toint32_2_2 = this.builderType.GetMethod("ToInt32", true, pvalue, pprovider).Import();
			
				return this.var_toint32_2_2;
			}
			
			return null;
			
		}
				
		private Method var_touint32_0_1;
				
		private Method var_touint32_1_1;
				
		private Method var_touint32_2_1;
				
		private Method var_touint32_3_1;
				
		private Method var_touint32_4_1;
				
		private Method var_touint32_5_1;
				
		private Method var_touint32_6_1;
				
		private Method var_touint32_7_1;
				
		private Method var_touint32_8_1;
				
		private Method var_touint32_9_1;
				
		private Method var_touint32_10_1;
				
		private Method var_touint32_11_1;
				
		private Method var_touint32_12_1;
				
		private Method var_touint32_13_1;
				
		private Method var_touint32_14_1;
				
		private Method var_touint32_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 ToUInt32(System.Object)<para/>
		/// UInt32 ToUInt32(Boolean)<para/>
		/// UInt32 ToUInt32(Char)<para/>
		/// UInt32 ToUInt32(SByte)<para/>
		/// UInt32 ToUInt32(Byte)<para/>
		/// UInt32 ToUInt32(Int16)<para/>
		/// UInt32 ToUInt32(UInt16)<para/>
		/// UInt32 ToUInt32(Int32)<para/>
		/// UInt32 ToUInt32(UInt32)<para/>
		/// UInt32 ToUInt32(Int64)<para/>
		/// UInt32 ToUInt32(UInt64)<para/>
		/// UInt32 ToUInt32(Single)<para/>
		/// UInt32 ToUInt32(Double)<para/>
		/// UInt32 ToUInt32(System.Decimal)<para/>
		/// UInt32 ToUInt32(System.String)<para/>
		/// UInt32 ToUInt32(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToUInt32(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_touint32_0_1 == null)
					this.var_touint32_0_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_touint32_1_1 == null)
					this.var_touint32_1_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_touint32_2_1 == null)
					this.var_touint32_2_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_touint32_3_1 == null)
					this.var_touint32_3_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_touint32_4_1 == null)
					this.var_touint32_4_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_touint32_5_1 == null)
					this.var_touint32_5_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_touint32_6_1 == null)
					this.var_touint32_6_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_touint32_7_1 == null)
					this.var_touint32_7_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_touint32_8_1 == null)
					this.var_touint32_8_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_touint32_9_1 == null)
					this.var_touint32_9_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_touint32_10_1 == null)
					this.var_touint32_10_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_touint32_11_1 == null)
					this.var_touint32_11_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_touint32_12_1 == null)
					this.var_touint32_12_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_touint32_13_1 == null)
					this.var_touint32_13_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_touint32_14_1 == null)
					this.var_touint32_14_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_touint32_15_1 == null)
					this.var_touint32_15_1 = this.builderType.GetMethod("ToUInt32", true, pvalue).Import();
			
				return this.var_touint32_15_1;
			}
			
			return null;
			
		}
				
		private Method var_touint32_0_2;
				
		private Method var_touint32_1_2;
				
		private Method var_touint32_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 ToUInt32(System.Object, System.IFormatProvider)<para/>
		/// UInt32 ToUInt32(System.String, System.IFormatProvider)<para/>
		/// UInt32 ToUInt32(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToUInt32(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint32_0_2 == null)
					this.var_touint32_0_2 = this.builderType.GetMethod("ToUInt32", true, pvalue, pprovider).Import();
			
				return this.var_touint32_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint32_1_2 == null)
					this.var_touint32_1_2 = this.builderType.GetMethod("ToUInt32", true, pvalue, pprovider).Import();
			
				return this.var_touint32_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_touint32_2_2 == null)
					this.var_touint32_2_2 = this.builderType.GetMethod("ToUInt32", true, pvalue, pprovider).Import();
			
				return this.var_touint32_2_2;
			}
			
			return null;
			
		}
				
		private Method var_toint64_0_1;
				
		private Method var_toint64_1_1;
				
		private Method var_toint64_2_1;
				
		private Method var_toint64_3_1;
				
		private Method var_toint64_4_1;
				
		private Method var_toint64_5_1;
				
		private Method var_toint64_6_1;
				
		private Method var_toint64_7_1;
				
		private Method var_toint64_8_1;
				
		private Method var_toint64_9_1;
				
		private Method var_toint64_10_1;
				
		private Method var_toint64_11_1;
				
		private Method var_toint64_12_1;
				
		private Method var_toint64_13_1;
				
		private Method var_toint64_14_1;
				
		private Method var_toint64_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToInt64(System.Object)<para/>
		/// Int64 ToInt64(Boolean)<para/>
		/// Int64 ToInt64(Char)<para/>
		/// Int64 ToInt64(SByte)<para/>
		/// Int64 ToInt64(Byte)<para/>
		/// Int64 ToInt64(Int16)<para/>
		/// Int64 ToInt64(UInt16)<para/>
		/// Int64 ToInt64(Int32)<para/>
		/// Int64 ToInt64(UInt32)<para/>
		/// Int64 ToInt64(UInt64)<para/>
		/// Int64 ToInt64(Int64)<para/>
		/// Int64 ToInt64(Single)<para/>
		/// Int64 ToInt64(Double)<para/>
		/// Int64 ToInt64(System.Decimal)<para/>
		/// Int64 ToInt64(System.String)<para/>
		/// Int64 ToInt64(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToInt64(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_toint64_0_1 == null)
					this.var_toint64_0_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_toint64_1_1 == null)
					this.var_toint64_1_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_toint64_2_1 == null)
					this.var_toint64_2_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_toint64_3_1 == null)
					this.var_toint64_3_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_toint64_4_1 == null)
					this.var_toint64_4_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_toint64_5_1 == null)
					this.var_toint64_5_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_toint64_6_1 == null)
					this.var_toint64_6_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_toint64_7_1 == null)
					this.var_toint64_7_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_toint64_8_1 == null)
					this.var_toint64_8_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_8_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_toint64_9_1 == null)
					this.var_toint64_9_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_9_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_toint64_10_1 == null)
					this.var_toint64_10_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_toint64_11_1 == null)
					this.var_toint64_11_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_toint64_12_1 == null)
					this.var_toint64_12_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_toint64_13_1 == null)
					this.var_toint64_13_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_toint64_14_1 == null)
					this.var_toint64_14_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_toint64_15_1 == null)
					this.var_toint64_15_1 = this.builderType.GetMethod("ToInt64", true, pvalue).Import();
			
				return this.var_toint64_15_1;
			}
			
			return null;
			
		}
				
		private Method var_toint64_0_2;
				
		private Method var_toint64_1_2;
				
		private Method var_toint64_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToInt64(System.Object, System.IFormatProvider)<para/>
		/// Int64 ToInt64(System.String, System.IFormatProvider)<para/>
		/// Int64 ToInt64(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToInt64(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint64_0_2 == null)
					this.var_toint64_0_2 = this.builderType.GetMethod("ToInt64", true, pvalue, pprovider).Import();
			
				return this.var_toint64_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_toint64_1_2 == null)
					this.var_toint64_1_2 = this.builderType.GetMethod("ToInt64", true, pvalue, pprovider).Import();
			
				return this.var_toint64_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_toint64_2_2 == null)
					this.var_toint64_2_2 = this.builderType.GetMethod("ToInt64", true, pvalue, pprovider).Import();
			
				return this.var_toint64_2_2;
			}
			
			return null;
			
		}
				
		private Method var_touint64_0_1;
				
		private Method var_touint64_1_1;
				
		private Method var_touint64_2_1;
				
		private Method var_touint64_3_1;
				
		private Method var_touint64_4_1;
				
		private Method var_touint64_5_1;
				
		private Method var_touint64_6_1;
				
		private Method var_touint64_7_1;
				
		private Method var_touint64_8_1;
				
		private Method var_touint64_9_1;
				
		private Method var_touint64_10_1;
				
		private Method var_touint64_11_1;
				
		private Method var_touint64_12_1;
				
		private Method var_touint64_13_1;
				
		private Method var_touint64_14_1;
				
		private Method var_touint64_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 ToUInt64(System.Object)<para/>
		/// UInt64 ToUInt64(Boolean)<para/>
		/// UInt64 ToUInt64(Char)<para/>
		/// UInt64 ToUInt64(SByte)<para/>
		/// UInt64 ToUInt64(Byte)<para/>
		/// UInt64 ToUInt64(Int16)<para/>
		/// UInt64 ToUInt64(UInt16)<para/>
		/// UInt64 ToUInt64(Int32)<para/>
		/// UInt64 ToUInt64(UInt32)<para/>
		/// UInt64 ToUInt64(Int64)<para/>
		/// UInt64 ToUInt64(UInt64)<para/>
		/// UInt64 ToUInt64(Single)<para/>
		/// UInt64 ToUInt64(Double)<para/>
		/// UInt64 ToUInt64(System.Decimal)<para/>
		/// UInt64 ToUInt64(System.String)<para/>
		/// UInt64 ToUInt64(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToUInt64(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_touint64_0_1 == null)
					this.var_touint64_0_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_touint64_1_1 == null)
					this.var_touint64_1_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_touint64_2_1 == null)
					this.var_touint64_2_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_touint64_3_1 == null)
					this.var_touint64_3_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_touint64_4_1 == null)
					this.var_touint64_4_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_touint64_5_1 == null)
					this.var_touint64_5_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_touint64_6_1 == null)
					this.var_touint64_6_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_touint64_7_1 == null)
					this.var_touint64_7_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_touint64_8_1 == null)
					this.var_touint64_8_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_touint64_9_1 == null)
					this.var_touint64_9_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_touint64_10_1 == null)
					this.var_touint64_10_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_touint64_11_1 == null)
					this.var_touint64_11_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_touint64_12_1 == null)
					this.var_touint64_12_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_touint64_13_1 == null)
					this.var_touint64_13_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_13_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_touint64_14_1 == null)
					this.var_touint64_14_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_touint64_15_1 == null)
					this.var_touint64_15_1 = this.builderType.GetMethod("ToUInt64", true, pvalue).Import();
			
				return this.var_touint64_15_1;
			}
			
			return null;
			
		}
				
		private Method var_touint64_0_2;
				
		private Method var_touint64_1_2;
				
		private Method var_touint64_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 ToUInt64(System.Object, System.IFormatProvider)<para/>
		/// UInt64 ToUInt64(System.String, System.IFormatProvider)<para/>
		/// UInt64 ToUInt64(System.String, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToUInt64(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint64_0_2 == null)
					this.var_touint64_0_2 = this.builderType.GetMethod("ToUInt64", true, pvalue, pprovider).Import();
			
				return this.var_touint64_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_touint64_1_2 == null)
					this.var_touint64_1_2 = this.builderType.GetMethod("ToUInt64", true, pvalue, pprovider).Import();
			
				return this.var_touint64_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_touint64_2_2 == null)
					this.var_touint64_2_2 = this.builderType.GetMethod("ToUInt64", true, pvalue, pprovider).Import();
			
				return this.var_touint64_2_2;
			}
			
			return null;
			
		}
				
		private Method var_tosingle_0_1;
				
		private Method var_tosingle_1_1;
				
		private Method var_tosingle_2_1;
				
		private Method var_tosingle_3_1;
				
		private Method var_tosingle_4_1;
				
		private Method var_tosingle_5_1;
				
		private Method var_tosingle_6_1;
				
		private Method var_tosingle_7_1;
				
		private Method var_tosingle_8_1;
				
		private Method var_tosingle_9_1;
				
		private Method var_tosingle_10_1;
				
		private Method var_tosingle_11_1;
				
		private Method var_tosingle_12_1;
				
		private Method var_tosingle_13_1;
				
		private Method var_tosingle_14_1;
				
		private Method var_tosingle_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single ToSingle(System.Object)<para/>
		/// Single ToSingle(SByte)<para/>
		/// Single ToSingle(Byte)<para/>
		/// Single ToSingle(Char)<para/>
		/// Single ToSingle(Int16)<para/>
		/// Single ToSingle(UInt16)<para/>
		/// Single ToSingle(Int32)<para/>
		/// Single ToSingle(UInt32)<para/>
		/// Single ToSingle(Int64)<para/>
		/// Single ToSingle(UInt64)<para/>
		/// Single ToSingle(Single)<para/>
		/// Single ToSingle(Double)<para/>
		/// Single ToSingle(System.Decimal)<para/>
		/// Single ToSingle(System.String)<para/>
		/// Single ToSingle(Boolean)<para/>
		/// Single ToSingle(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToSingle(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_tosingle_0_1 == null)
					this.var_tosingle_0_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_tosingle_1_1 == null)
					this.var_tosingle_1_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_1_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_tosingle_2_1 == null)
					this.var_tosingle_2_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_2_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_tosingle_3_1 == null)
					this.var_tosingle_3_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_3_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_tosingle_4_1 == null)
					this.var_tosingle_4_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_4_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_tosingle_5_1 == null)
					this.var_tosingle_5_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_5_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_tosingle_6_1 == null)
					this.var_tosingle_6_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_6_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_tosingle_7_1 == null)
					this.var_tosingle_7_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_7_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_tosingle_8_1 == null)
					this.var_tosingle_8_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_8_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_tosingle_9_1 == null)
					this.var_tosingle_9_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_9_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_tosingle_10_1 == null)
					this.var_tosingle_10_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_10_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_tosingle_11_1 == null)
					this.var_tosingle_11_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_11_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_tosingle_12_1 == null)
					this.var_tosingle_12_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_12_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_tosingle_13_1 == null)
					this.var_tosingle_13_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_13_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_tosingle_14_1 == null)
					this.var_tosingle_14_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_tosingle_15_1 == null)
					this.var_tosingle_15_1 = this.builderType.GetMethod("ToSingle", true, pvalue).Import();
			
				return this.var_tosingle_15_1;
			}
			
			return null;
			
		}
				
		private Method var_tosingle_0_2;
				
		private Method var_tosingle_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single ToSingle(System.Object, System.IFormatProvider)<para/>
		/// Single ToSingle(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToSingle(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tosingle_0_2 == null)
					this.var_tosingle_0_2 = this.builderType.GetMethod("ToSingle", true, pvalue, pprovider).Import();
			
				return this.var_tosingle_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tosingle_1_2 == null)
					this.var_tosingle_1_2 = this.builderType.GetMethod("ToSingle", true, pvalue, pprovider).Import();
			
				return this.var_tosingle_1_2;
			}
			
			return null;
			
		}
				
		private Method var_todouble_0_1;
				
		private Method var_todouble_1_1;
				
		private Method var_todouble_2_1;
				
		private Method var_todouble_3_1;
				
		private Method var_todouble_4_1;
				
		private Method var_todouble_5_1;
				
		private Method var_todouble_6_1;
				
		private Method var_todouble_7_1;
				
		private Method var_todouble_8_1;
				
		private Method var_todouble_9_1;
				
		private Method var_todouble_10_1;
				
		private Method var_todouble_11_1;
				
		private Method var_todouble_12_1;
				
		private Method var_todouble_13_1;
				
		private Method var_todouble_14_1;
				
		private Method var_todouble_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double ToDouble(System.Object)<para/>
		/// Double ToDouble(SByte)<para/>
		/// Double ToDouble(Byte)<para/>
		/// Double ToDouble(Int16)<para/>
		/// Double ToDouble(Char)<para/>
		/// Double ToDouble(UInt16)<para/>
		/// Double ToDouble(Int32)<para/>
		/// Double ToDouble(UInt32)<para/>
		/// Double ToDouble(Int64)<para/>
		/// Double ToDouble(UInt64)<para/>
		/// Double ToDouble(Single)<para/>
		/// Double ToDouble(Double)<para/>
		/// Double ToDouble(System.Decimal)<para/>
		/// Double ToDouble(System.String)<para/>
		/// Double ToDouble(Boolean)<para/>
		/// Double ToDouble(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToDouble(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_todouble_0_1 == null)
					this.var_todouble_0_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_todouble_1_1 == null)
					this.var_todouble_1_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_1_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_todouble_2_1 == null)
					this.var_todouble_2_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_2_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_todouble_3_1 == null)
					this.var_todouble_3_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_3_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_todouble_4_1 == null)
					this.var_todouble_4_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_4_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_todouble_5_1 == null)
					this.var_todouble_5_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_5_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_todouble_6_1 == null)
					this.var_todouble_6_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_6_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_todouble_7_1 == null)
					this.var_todouble_7_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_7_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_todouble_8_1 == null)
					this.var_todouble_8_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_8_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_todouble_9_1 == null)
					this.var_todouble_9_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_9_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_todouble_10_1 == null)
					this.var_todouble_10_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_10_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_todouble_11_1 == null)
					this.var_todouble_11_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_11_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_todouble_12_1 == null)
					this.var_todouble_12_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_12_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_todouble_13_1 == null)
					this.var_todouble_13_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_13_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_todouble_14_1 == null)
					this.var_todouble_14_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_todouble_15_1 == null)
					this.var_todouble_15_1 = this.builderType.GetMethod("ToDouble", true, pvalue).Import();
			
				return this.var_todouble_15_1;
			}
			
			return null;
			
		}
				
		private Method var_todouble_0_2;
				
		private Method var_todouble_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double ToDouble(System.Object, System.IFormatProvider)<para/>
		/// Double ToDouble(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToDouble(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todouble_0_2 == null)
					this.var_todouble_0_2 = this.builderType.GetMethod("ToDouble", true, pvalue, pprovider).Import();
			
				return this.var_todouble_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todouble_1_2 == null)
					this.var_todouble_1_2 = this.builderType.GetMethod("ToDouble", true, pvalue, pprovider).Import();
			
				return this.var_todouble_1_2;
			}
			
			return null;
			
		}
				
		private Method var_todecimal_0_1;
				
		private Method var_todecimal_1_1;
				
		private Method var_todecimal_2_1;
				
		private Method var_todecimal_3_1;
				
		private Method var_todecimal_4_1;
				
		private Method var_todecimal_5_1;
				
		private Method var_todecimal_6_1;
				
		private Method var_todecimal_7_1;
				
		private Method var_todecimal_8_1;
				
		private Method var_todecimal_9_1;
				
		private Method var_todecimal_10_1;
				
		private Method var_todecimal_11_1;
				
		private Method var_todecimal_12_1;
				
		private Method var_todecimal_13_1;
				
		private Method var_todecimal_14_1;
				
		private Method var_todecimal_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal ToDecimal(System.Object)<para/>
		/// System.Decimal ToDecimal(SByte)<para/>
		/// System.Decimal ToDecimal(Byte)<para/>
		/// System.Decimal ToDecimal(Char)<para/>
		/// System.Decimal ToDecimal(Int16)<para/>
		/// System.Decimal ToDecimal(UInt16)<para/>
		/// System.Decimal ToDecimal(Int32)<para/>
		/// System.Decimal ToDecimal(UInt32)<para/>
		/// System.Decimal ToDecimal(Int64)<para/>
		/// System.Decimal ToDecimal(UInt64)<para/>
		/// System.Decimal ToDecimal(Single)<para/>
		/// System.Decimal ToDecimal(Double)<para/>
		/// System.Decimal ToDecimal(System.String)<para/>
		/// System.Decimal ToDecimal(System.Decimal)<para/>
		/// System.Decimal ToDecimal(Boolean)<para/>
		/// System.Decimal ToDecimal(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_ToDecimal(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_todecimal_0_1 == null)
					this.var_todecimal_0_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_todecimal_1_1 == null)
					this.var_todecimal_1_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_1_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_todecimal_2_1 == null)
					this.var_todecimal_2_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_2_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_todecimal_3_1 == null)
					this.var_todecimal_3_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_3_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_todecimal_4_1 == null)
					this.var_todecimal_4_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_4_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_todecimal_5_1 == null)
					this.var_todecimal_5_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_5_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_todecimal_6_1 == null)
					this.var_todecimal_6_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_6_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_todecimal_7_1 == null)
					this.var_todecimal_7_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_7_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_todecimal_8_1 == null)
					this.var_todecimal_8_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_8_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_todecimal_9_1 == null)
					this.var_todecimal_9_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_9_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_todecimal_10_1 == null)
					this.var_todecimal_10_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_10_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_todecimal_11_1 == null)
					this.var_todecimal_11_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_11_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_todecimal_12_1 == null)
					this.var_todecimal_12_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_todecimal_13_1 == null)
					this.var_todecimal_13_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_13_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_todecimal_14_1 == null)
					this.var_todecimal_14_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_14_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_todecimal_15_1 == null)
					this.var_todecimal_15_1 = this.builderType.GetMethod("ToDecimal", true, pvalue).Import();
			
				return this.var_todecimal_15_1;
			}
			
			return null;
			
		}
				
		private Method var_todecimal_0_2;
				
		private Method var_todecimal_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal ToDecimal(System.Object, System.IFormatProvider)<para/>
		/// System.Decimal ToDecimal(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToDecimal(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todecimal_0_2 == null)
					this.var_todecimal_0_2 = this.builderType.GetMethod("ToDecimal", true, pvalue, pprovider).Import();
			
				return this.var_todecimal_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todecimal_1_2 == null)
					this.var_todecimal_1_2 = this.builderType.GetMethod("ToDecimal", true, pvalue, pprovider).Import();
			
				return this.var_todecimal_1_2;
			}
			
			return null;
			
		}
				
		private Method var_todatetime_0_1;
				
		private Method var_todatetime_1_1;
				
		private Method var_todatetime_2_1;
				
		private Method var_todatetime_3_1;
				
		private Method var_todatetime_4_1;
				
		private Method var_todatetime_5_1;
				
		private Method var_todatetime_6_1;
				
		private Method var_todatetime_7_1;
				
		private Method var_todatetime_8_1;
				
		private Method var_todatetime_9_1;
				
		private Method var_todatetime_10_1;
				
		private Method var_todatetime_11_1;
				
		private Method var_todatetime_12_1;
				
		private Method var_todatetime_13_1;
				
		private Method var_todatetime_14_1;
				
		private Method var_todatetime_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ToDateTime(System.DateTime)<para/>
		/// System.DateTime ToDateTime(System.Object)<para/>
		/// System.DateTime ToDateTime(System.String)<para/>
		/// System.DateTime ToDateTime(SByte)<para/>
		/// System.DateTime ToDateTime(Byte)<para/>
		/// System.DateTime ToDateTime(Int16)<para/>
		/// System.DateTime ToDateTime(UInt16)<para/>
		/// System.DateTime ToDateTime(Int32)<para/>
		/// System.DateTime ToDateTime(UInt32)<para/>
		/// System.DateTime ToDateTime(Int64)<para/>
		/// System.DateTime ToDateTime(UInt64)<para/>
		/// System.DateTime ToDateTime(Boolean)<para/>
		/// System.DateTime ToDateTime(Char)<para/>
		/// System.DateTime ToDateTime(Single)<para/>
		/// System.DateTime ToDateTime(Double)<para/>
		/// System.DateTime ToDateTime(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToDateTime(TypeReference pvalue)
		{
						
						
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_todatetime_0_1 == null)
					this.var_todatetime_0_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_0_1;
			}
			
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_todatetime_1_1 == null)
					this.var_todatetime_1_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_1_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_todatetime_2_1 == null)
					this.var_todatetime_2_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_todatetime_3_1 == null)
					this.var_todatetime_3_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_todatetime_4_1 == null)
					this.var_todatetime_4_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_todatetime_5_1 == null)
					this.var_todatetime_5_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_todatetime_6_1 == null)
					this.var_todatetime_6_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_todatetime_7_1 == null)
					this.var_todatetime_7_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_todatetime_8_1 == null)
					this.var_todatetime_8_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_todatetime_9_1 == null)
					this.var_todatetime_9_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_todatetime_10_1 == null)
					this.var_todatetime_10_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_10_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_todatetime_11_1 == null)
					this.var_todatetime_11_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_11_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_todatetime_12_1 == null)
					this.var_todatetime_12_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_12_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_todatetime_13_1 == null)
					this.var_todatetime_13_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_13_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_todatetime_14_1 == null)
					this.var_todatetime_14_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_14_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_todatetime_15_1 == null)
					this.var_todatetime_15_1 = this.builderType.GetMethod("ToDateTime", true, pvalue).Import();
			
				return this.var_todatetime_15_1;
			}
			
			return null;
			
		}
				
		private Method var_todatetime_0_2;
				
		private Method var_todatetime_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ToDateTime(System.Object, System.IFormatProvider)<para/>
		/// System.DateTime ToDateTime(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToDateTime(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todatetime_0_2 == null)
					this.var_todatetime_0_2 = this.builderType.GetMethod("ToDateTime", true, pvalue, pprovider).Import();
			
				return this.var_todatetime_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_todatetime_1_2 == null)
					this.var_todatetime_1_2 = this.builderType.GetMethod("ToDateTime", true, pvalue, pprovider).Import();
			
				return this.var_todatetime_1_2;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
				
		private Method var_tostring_2_1;
				
		private Method var_tostring_3_1;
				
		private Method var_tostring_4_1;
				
		private Method var_tostring_5_1;
				
		private Method var_tostring_6_1;
				
		private Method var_tostring_7_1;
				
		private Method var_tostring_8_1;
				
		private Method var_tostring_9_1;
				
		private Method var_tostring_10_1;
				
		private Method var_tostring_11_1;
				
		private Method var_tostring_12_1;
				
		private Method var_tostring_13_1;
				
		private Method var_tostring_14_1;
				
		private Method var_tostring_15_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.Object)<para/>
		/// System.String ToString(Boolean)<para/>
		/// System.String ToString(Char)<para/>
		/// System.String ToString(SByte)<para/>
		/// System.String ToString(Byte)<para/>
		/// System.String ToString(Int16)<para/>
		/// System.String ToString(UInt16)<para/>
		/// System.String ToString(Int32)<para/>
		/// System.String ToString(UInt32)<para/>
		/// System.String ToString(Int64)<para/>
		/// System.String ToString(UInt64)<para/>
		/// System.String ToString(Single)<para/>
		/// System.String ToString(Double)<para/>
		/// System.String ToString(System.Decimal)<para/>
		/// System.String ToString(System.DateTime)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_1_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_tostring_2_1 == null)
					this.var_tostring_2_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_2_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_tostring_3_1 == null)
					this.var_tostring_3_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_3_1;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_tostring_4_1 == null)
					this.var_tostring_4_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_4_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_tostring_5_1 == null)
					this.var_tostring_5_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_5_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_tostring_6_1 == null)
					this.var_tostring_6_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_6_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_tostring_7_1 == null)
					this.var_tostring_7_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_7_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_tostring_8_1 == null)
					this.var_tostring_8_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_8_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_tostring_9_1 == null)
					this.var_tostring_9_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_9_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_tostring_10_1 == null)
					this.var_tostring_10_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_10_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_tostring_11_1 == null)
					this.var_tostring_11_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_11_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_tostring_12_1 == null)
					this.var_tostring_12_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_12_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_tostring_13_1 == null)
					this.var_tostring_13_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_13_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_tostring_14_1 == null)
					this.var_tostring_14_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_14_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_tostring_15_1 == null)
					this.var_tostring_15_1 = this.builderType.GetMethod("ToString", true, pvalue).Import();
			
				return this.var_tostring_15_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
				
		private Method var_tostring_1_2;
				
		private Method var_tostring_2_2;
				
		private Method var_tostring_3_2;
				
		private Method var_tostring_4_2;
				
		private Method var_tostring_5_2;
				
		private Method var_tostring_6_2;
				
		private Method var_tostring_7_2;
				
		private Method var_tostring_8_2;
				
		private Method var_tostring_9_2;
				
		private Method var_tostring_10_2;
				
		private Method var_tostring_11_2;
				
		private Method var_tostring_12_2;
				
		private Method var_tostring_13_2;
				
		private Method var_tostring_14_2;
				
		private Method var_tostring_15_2;
				
		private Method var_tostring_16_2;
				
		private Method var_tostring_17_2;
				
		private Method var_tostring_18_2;
				
		private Method var_tostring_19_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.Object, System.IFormatProvider)<para/>
		/// System.String ToString(Boolean, System.IFormatProvider)<para/>
		/// System.String ToString(Char, System.IFormatProvider)<para/>
		/// System.String ToString(SByte, System.IFormatProvider)<para/>
		/// System.String ToString(Byte, System.IFormatProvider)<para/>
		/// System.String ToString(Int16, System.IFormatProvider)<para/>
		/// System.String ToString(UInt16, System.IFormatProvider)<para/>
		/// System.String ToString(Int32, System.IFormatProvider)<para/>
		/// System.String ToString(UInt32, System.IFormatProvider)<para/>
		/// System.String ToString(Int64, System.IFormatProvider)<para/>
		/// System.String ToString(UInt64, System.IFormatProvider)<para/>
		/// System.String ToString(Single, System.IFormatProvider)<para/>
		/// System.String ToString(Double, System.IFormatProvider)<para/>
		/// System.String ToString(System.Decimal, System.IFormatProvider)<para/>
		/// System.String ToString(System.DateTime, System.IFormatProvider)<para/>
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// System.String ToString(Byte, Int32)<para/>
		/// System.String ToString(Int16, Int32)<para/>
		/// System.String ToString(Int32, Int32)<para/>
		/// System.String ToString(Int64, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pvalue, TypeReference pprovider)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_2 == null)
					this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_0_2;
			}
			
			if(typeof(System.Boolean).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_1_2 == null)
					this.var_tostring_1_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_1_2;
			}
			
			if(typeof(System.Char).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_2_2 == null)
					this.var_tostring_2_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_2_2;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_3_2 == null)
					this.var_tostring_3_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_3_2;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_4_2 == null)
					this.var_tostring_4_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_4_2;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_5_2 == null)
					this.var_tostring_5_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_5_2;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_6_2 == null)
					this.var_tostring_6_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_6_2;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_7_2 == null)
					this.var_tostring_7_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_7_2;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_8_2 == null)
					this.var_tostring_8_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_8_2;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_9_2 == null)
					this.var_tostring_9_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_9_2;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_10_2 == null)
					this.var_tostring_10_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_10_2;
			}
			
			if(typeof(System.Single).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_11_2 == null)
					this.var_tostring_11_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_11_2;
			}
			
			if(typeof(System.Double).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_12_2 == null)
					this.var_tostring_12_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_12_2;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_13_2 == null)
					this.var_tostring_13_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_13_2;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_14_2 == null)
					this.var_tostring_14_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_14_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_15_2 == null)
					this.var_tostring_15_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_15_2;
			}
			
			if(typeof(System.Byte).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tostring_16_2 == null)
					this.var_tostring_16_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_16_2;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tostring_17_2 == null)
					this.var_tostring_17_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_17_2;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tostring_18_2 == null)
					this.var_tostring_18_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_18_2;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pprovider))
			{
				if(this.var_tostring_19_2 == null)
					this.var_tostring_19_2 = this.builderType.GetMethod("ToString", true, pvalue, pprovider).Import();
			
				return this.var_tostring_19_2;
			}
			
			return null;
			
		}
				
		private Method var_tobase64string_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToBase64String(Byte[])<para/>
		/// </summary>
		public Method GetMethod_ToBase64String(TypeReference pinArray)
		{
						
						
			if(this.var_tobase64string_0_1 == null)
				this.var_tobase64string_0_1 = this.builderType.GetMethod("ToBase64String", true, pinArray).Import();
			
			return this.var_tobase64string_0_1;
						
		}
				
		private Method var_tobase64string_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToBase64String(Byte[], System.Base64FormattingOptions)<para/>
		/// </summary>
		public Method GetMethod_ToBase64String(TypeReference pinArray, TypeReference poptions)
		{
						
						
			if(this.var_tobase64string_0_2 == null)
				this.var_tobase64string_0_2 = this.builderType.GetMethod("ToBase64String", true, pinArray, poptions).Import();
			
			return this.var_tobase64string_0_2;
						
		}
				
		private Method var_tobase64string_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToBase64String(Byte[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToBase64String(TypeReference pinArray, TypeReference poffset, TypeReference plength)
		{
						
						
			if(this.var_tobase64string_0_3 == null)
				this.var_tobase64string_0_3 = this.builderType.GetMethod("ToBase64String", true, pinArray, poffset, plength).Import();
			
			return this.var_tobase64string_0_3;
						
		}
				
		private Method var_tobase64string_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)<para/>
		/// </summary>
		public Method GetMethod_ToBase64String(TypeReference pinArray, TypeReference poffset, TypeReference plength, TypeReference poptions)
		{
						
						
			if(this.var_tobase64string_0_4 == null)
				this.var_tobase64string_0_4 = this.builderType.GetMethod("ToBase64String", true, pinArray, poffset, plength, poptions).Import();
			
			return this.var_tobase64string_0_4;
						
		}
				
		private Method var_tobase64chararray_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToBase64CharArray(Byte[], Int32, Int32, Char[], Int32)<para/>
		/// </summary>
		public Method GetMethod_ToBase64CharArray(TypeReference pinArray, TypeReference poffsetIn, TypeReference plength, TypeReference poutArray, TypeReference poffsetOut)
		{
						
						
			if(this.var_tobase64chararray_0_5 == null)
				this.var_tobase64chararray_0_5 = this.builderType.GetMethod("ToBase64CharArray", true, pinArray, poffsetIn, plength, poutArray, poffsetOut).Import();
			
			return this.var_tobase64chararray_0_5;
						
		}
				
		private Method var_tobase64chararray_0_6;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToBase64CharArray(Byte[], Int32, Int32, Char[], Int32, System.Base64FormattingOptions)<para/>
		/// </summary>
		public Method GetMethod_ToBase64CharArray(TypeReference pinArray, TypeReference poffsetIn, TypeReference plength, TypeReference poutArray, TypeReference poffsetOut, TypeReference poptions)
		{
						
						
			if(this.var_tobase64chararray_0_6 == null)
				this.var_tobase64chararray_0_6 = this.builderType.GetMethod("ToBase64CharArray", true, pinArray, poffsetIn, plength, poutArray, poffsetOut, poptions).Import();
			
			return this.var_tobase64chararray_0_6;
						
		}
				
		private Method var_frombase64string_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte[] FromBase64String(System.String)<para/>
		/// </summary>
		public Method GetMethod_FromBase64String(TypeReference ps)
		{
						
						
			if(this.var_frombase64string_0_1 == null)
				this.var_frombase64string_0_1 = this.builderType.GetMethod("FromBase64String", true, ps).Import();
			
			return this.var_frombase64string_0_1;
						
		}
				
		private Method var_frombase64chararray_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte[] FromBase64CharArray(Char[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_FromBase64CharArray(TypeReference pinArray, TypeReference poffset, TypeReference plength)
		{
						
						
			if(this.var_frombase64chararray_0_3 == null)
				this.var_frombase64chararray_0_3 = this.builderType.GetMethod("FromBase64CharArray", true, pinArray, poffset, plength).Import();
			
			return this.var_frombase64chararray_0_3;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.DateTime"/>
    /// </summary>
    public partial class BuilderTypeDateTime : TypeSystemExBase
	{
        internal BuilderTypeDateTime(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeDateTime value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeDateTime value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_add_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime Add(System.TimeSpan)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference pvalue)
		{
						
						
			if(this.var_add_0_1 == null)
				this.var_add_0_1 = this.builderType.GetMethod("Add", true, pvalue).Import();
			
			return this.var_add_0_1;
						
		}
				
		private Method var_adddays_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddDays(Double)<para/>
		/// </summary>
		public Method GetMethod_AddDays(TypeReference pvalue)
		{
						
						
			if(this.var_adddays_0_1 == null)
				this.var_adddays_0_1 = this.builderType.GetMethod("AddDays", true, pvalue).Import();
			
			return this.var_adddays_0_1;
						
		}
				
		private Method var_addhours_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddHours(Double)<para/>
		/// </summary>
		public Method GetMethod_AddHours(TypeReference pvalue)
		{
						
						
			if(this.var_addhours_0_1 == null)
				this.var_addhours_0_1 = this.builderType.GetMethod("AddHours", true, pvalue).Import();
			
			return this.var_addhours_0_1;
						
		}
				
		private Method var_addmilliseconds_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddMilliseconds(Double)<para/>
		/// </summary>
		public Method GetMethod_AddMilliseconds(TypeReference pvalue)
		{
						
						
			if(this.var_addmilliseconds_0_1 == null)
				this.var_addmilliseconds_0_1 = this.builderType.GetMethod("AddMilliseconds", true, pvalue).Import();
			
			return this.var_addmilliseconds_0_1;
						
		}
				
		private Method var_addminutes_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddMinutes(Double)<para/>
		/// </summary>
		public Method GetMethod_AddMinutes(TypeReference pvalue)
		{
						
						
			if(this.var_addminutes_0_1 == null)
				this.var_addminutes_0_1 = this.builderType.GetMethod("AddMinutes", true, pvalue).Import();
			
			return this.var_addminutes_0_1;
						
		}
				
		private Method var_addmonths_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddMonths(Int32)<para/>
		/// </summary>
		public Method GetMethod_AddMonths(TypeReference pmonths)
		{
						
						
			if(this.var_addmonths_0_1 == null)
				this.var_addmonths_0_1 = this.builderType.GetMethod("AddMonths", true, pmonths).Import();
			
			return this.var_addmonths_0_1;
						
		}
				
		private Method var_addseconds_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddSeconds(Double)<para/>
		/// </summary>
		public Method GetMethod_AddSeconds(TypeReference pvalue)
		{
						
						
			if(this.var_addseconds_0_1 == null)
				this.var_addseconds_0_1 = this.builderType.GetMethod("AddSeconds", true, pvalue).Import();
			
			return this.var_addseconds_0_1;
						
		}
				
		private Method var_addticks_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddTicks(Int64)<para/>
		/// </summary>
		public Method GetMethod_AddTicks(TypeReference pvalue)
		{
						
						
			if(this.var_addticks_0_1 == null)
				this.var_addticks_0_1 = this.builderType.GetMethod("AddTicks", true, pvalue).Import();
			
			return this.var_addticks_0_1;
						
		}
				
		private Method var_addyears_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime AddYears(Int32)<para/>
		/// </summary>
		public Method GetMethod_AddYears(TypeReference pvalue)
		{
						
						
			if(this.var_addyears_0_1 == null)
				this.var_addyears_0_1 = this.builderType.GetMethod("AddYears", true, pvalue).Import();
			
			return this.var_addyears_0_1;
						
		}
				
		private Method var_compare_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_compare_0_2 == null)
				this.var_compare_0_2 = this.builderType.GetMethod("Compare", true, pt1, pt2).Import();
			
			return this.var_compare_0_2;
						
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_daysinmonth_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 DaysInMonth(Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_DaysInMonth(TypeReference pyear, TypeReference pmonth)
		{
						
						
			if(this.var_daysinmonth_0_2 == null)
				this.var_daysinmonth_0_2 = this.builderType.GetMethod("DaysInMonth", true, pyear, pmonth).Import();
			
			return this.var_daysinmonth_0_2;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pvalue).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pvalue).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_equals_0_2 == null)
				this.var_equals_0_2 = this.builderType.GetMethod("Equals", true, pt1, pt2).Import();
			
			return this.var_equals_0_2;
						
		}
				
		private Method var_frombinary_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime FromBinary(Int64)<para/>
		/// </summary>
		public Method GetMethod_FromBinary(TypeReference pdateData)
		{
						
						
			if(this.var_frombinary_0_1 == null)
				this.var_frombinary_0_1 = this.builderType.GetMethod("FromBinary", true, pdateData).Import();
			
			return this.var_frombinary_0_1;
						
		}
				
		private Method var_fromfiletime_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime FromFileTime(Int64)<para/>
		/// </summary>
		public Method GetMethod_FromFileTime(TypeReference pfileTime)
		{
						
						
			if(this.var_fromfiletime_0_1 == null)
				this.var_fromfiletime_0_1 = this.builderType.GetMethod("FromFileTime", true, pfileTime).Import();
			
			return this.var_fromfiletime_0_1;
						
		}
				
		private Method var_fromfiletimeutc_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime FromFileTimeUtc(Int64)<para/>
		/// </summary>
		public Method GetMethod_FromFileTimeUtc(TypeReference pfileTime)
		{
						
						
			if(this.var_fromfiletimeutc_0_1 == null)
				this.var_fromfiletimeutc_0_1 = this.builderType.GetMethod("FromFileTimeUtc", true, pfileTime).Import();
			
			return this.var_fromfiletimeutc_0_1;
						
		}
				
		private Method var_fromoadate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime FromOADate(Double)<para/>
		/// </summary>
		public Method GetMethod_FromOADate(TypeReference pd)
		{
						
						
			if(this.var_fromoadate_0_1 == null)
				this.var_fromoadate_0_1 = this.builderType.GetMethod("FromOADate", true, pd).Import();
			
			return this.var_fromoadate_0_1;
						
		}
				
		private Method var_isdaylightsavingtime_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDaylightSavingTime()<para/>
		/// </summary>
		public Method GetMethod_IsDaylightSavingTime()
		{
						
			if(this.var_isdaylightsavingtime_0_0 == null)
				this.var_isdaylightsavingtime_0_0 = this.builderType.GetMethod("IsDaylightSavingTime", true);

			return this.var_isdaylightsavingtime_0_0;
						
						
		}
				
		private Method var_specifykind_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime SpecifyKind(System.DateTime, System.DateTimeKind)<para/>
		/// </summary>
		public Method GetMethod_SpecifyKind(TypeReference pvalue, TypeReference pkind)
		{
						
						
			if(this.var_specifykind_0_2 == null)
				this.var_specifykind_0_2 = this.builderType.GetMethod("SpecifyKind", true, pvalue, pkind).Import();
			
			return this.var_specifykind_0_2;
						
		}
				
		private Method var_tobinary_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToBinary()<para/>
		/// </summary>
		public Method GetMethod_ToBinary()
		{
						
			if(this.var_tobinary_0_0 == null)
				this.var_tobinary_0_0 = this.builderType.GetMethod("ToBinary", true);

			return this.var_tobinary_0_0;
						
						
		}
				
		private Method var_get_date_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime get_Date()<para/>
		/// </summary>
		public Method GetMethod_get_Date()
		{
						
			if(this.var_get_date_0_0 == null)
				this.var_get_date_0_0 = this.builderType.GetMethod("get_Date", true);

			return this.var_get_date_0_0;
						
						
		}
				
		private Method var_get_day_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Day()<para/>
		/// </summary>
		public Method GetMethod_get_Day()
		{
						
			if(this.var_get_day_0_0 == null)
				this.var_get_day_0_0 = this.builderType.GetMethod("get_Day", true);

			return this.var_get_day_0_0;
						
						
		}
				
		private Method var_get_dayofweek_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DayOfWeek get_DayOfWeek()<para/>
		/// </summary>
		public Method GetMethod_get_DayOfWeek()
		{
						
			if(this.var_get_dayofweek_0_0 == null)
				this.var_get_dayofweek_0_0 = this.builderType.GetMethod("get_DayOfWeek", true);

			return this.var_get_dayofweek_0_0;
						
						
		}
				
		private Method var_get_dayofyear_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_DayOfYear()<para/>
		/// </summary>
		public Method GetMethod_get_DayOfYear()
		{
						
			if(this.var_get_dayofyear_0_0 == null)
				this.var_get_dayofyear_0_0 = this.builderType.GetMethod("get_DayOfYear", true);

			return this.var_get_dayofyear_0_0;
						
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_get_hour_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Hour()<para/>
		/// </summary>
		public Method GetMethod_get_Hour()
		{
						
			if(this.var_get_hour_0_0 == null)
				this.var_get_hour_0_0 = this.builderType.GetMethod("get_Hour", true);

			return this.var_get_hour_0_0;
						
						
		}
				
		private Method var_get_kind_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTimeKind get_Kind()<para/>
		/// </summary>
		public Method GetMethod_get_Kind()
		{
						
			if(this.var_get_kind_0_0 == null)
				this.var_get_kind_0_0 = this.builderType.GetMethod("get_Kind", true);

			return this.var_get_kind_0_0;
						
						
		}
				
		private Method var_get_millisecond_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Millisecond()<para/>
		/// </summary>
		public Method GetMethod_get_Millisecond()
		{
						
			if(this.var_get_millisecond_0_0 == null)
				this.var_get_millisecond_0_0 = this.builderType.GetMethod("get_Millisecond", true);

			return this.var_get_millisecond_0_0;
						
						
		}
				
		private Method var_get_minute_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Minute()<para/>
		/// </summary>
		public Method GetMethod_get_Minute()
		{
						
			if(this.var_get_minute_0_0 == null)
				this.var_get_minute_0_0 = this.builderType.GetMethod("get_Minute", true);

			return this.var_get_minute_0_0;
						
						
		}
				
		private Method var_get_month_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Month()<para/>
		/// </summary>
		public Method GetMethod_get_Month()
		{
						
			if(this.var_get_month_0_0 == null)
				this.var_get_month_0_0 = this.builderType.GetMethod("get_Month", true);

			return this.var_get_month_0_0;
						
						
		}
				
		private Method var_get_now_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime get_Now()<para/>
		/// </summary>
		public Method GetMethod_get_Now()
		{
						
			if(this.var_get_now_0_0 == null)
				this.var_get_now_0_0 = this.builderType.GetMethod("get_Now", true);

			return this.var_get_now_0_0;
						
						
		}
				
		private Method var_get_utcnow_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime get_UtcNow()<para/>
		/// </summary>
		public Method GetMethod_get_UtcNow()
		{
						
			if(this.var_get_utcnow_0_0 == null)
				this.var_get_utcnow_0_0 = this.builderType.GetMethod("get_UtcNow", true);

			return this.var_get_utcnow_0_0;
						
						
		}
				
		private Method var_get_second_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Second()<para/>
		/// </summary>
		public Method GetMethod_get_Second()
		{
						
			if(this.var_get_second_0_0 == null)
				this.var_get_second_0_0 = this.builderType.GetMethod("get_Second", true);

			return this.var_get_second_0_0;
						
						
		}
				
		private Method var_get_ticks_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 get_Ticks()<para/>
		/// </summary>
		public Method GetMethod_get_Ticks()
		{
						
			if(this.var_get_ticks_0_0 == null)
				this.var_get_ticks_0_0 = this.builderType.GetMethod("get_Ticks", true);

			return this.var_get_ticks_0_0;
						
						
		}
				
		private Method var_get_timeofday_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TimeSpan get_TimeOfDay()<para/>
		/// </summary>
		public Method GetMethod_get_TimeOfDay()
		{
						
			if(this.var_get_timeofday_0_0 == null)
				this.var_get_timeofday_0_0 = this.builderType.GetMethod("get_TimeOfDay", true);

			return this.var_get_timeofday_0_0;
						
						
		}
				
		private Method var_get_today_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime get_Today()<para/>
		/// </summary>
		public Method GetMethod_get_Today()
		{
						
			if(this.var_get_today_0_0 == null)
				this.var_get_today_0_0 = this.builderType.GetMethod("get_Today", true);

			return this.var_get_today_0_0;
						
						
		}
				
		private Method var_get_year_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Year()<para/>
		/// </summary>
		public Method GetMethod_get_Year()
		{
						
			if(this.var_get_year_0_0 == null)
				this.var_get_year_0_0 = this.builderType.GetMethod("get_Year", true);

			return this.var_get_year_0_0;
						
						
		}
				
		private Method var_isleapyear_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsLeapYear(Int32)<para/>
		/// </summary>
		public Method GetMethod_IsLeapYear(TypeReference pyear)
		{
						
						
			if(this.var_isleapyear_0_1 == null)
				this.var_isleapyear_0_1 = this.builderType.GetMethod("IsLeapYear", true, pyear).Import();
			
			return this.var_isleapyear_0_1;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_2 == null)
				this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pprovider).Import();
			
			return this.var_parse_0_2;
						
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime Parse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pprovider, TypeReference pstyles)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pprovider, pstyles).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_parseexact_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ParseExact(TypeReference ps, TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_parseexact_0_3 == null)
				this.var_parseexact_0_3 = this.builderType.GetMethod("ParseExact", true, ps, pformat, pprovider).Import();
			
			return this.var_parseexact_0_3;
						
		}
				
		private Method var_parseexact_0_4;
				
		private Method var_parseexact_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)<para/>
		/// System.DateTime ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)<para/>
		/// </summary>
		public Method GetMethod_ParseExact(TypeReference ps, TypeReference pformat, TypeReference pprovider, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.String).AreEqual(pformat) && typeof(System.IFormatProvider).AreEqual(pprovider) && typeof(System.Globalization.DateTimeStyles).AreEqual(pstyle))
			{
				if(this.var_parseexact_0_4 == null)
					this.var_parseexact_0_4 = this.builderType.GetMethod("ParseExact", true, ps, pformat, pprovider, pstyle).Import();
			
				return this.var_parseexact_0_4;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.String[]).AreEqual(pformat) && typeof(System.IFormatProvider).AreEqual(pprovider) && typeof(System.Globalization.DateTimeStyles).AreEqual(pstyle))
			{
				if(this.var_parseexact_1_4 == null)
					this.var_parseexact_1_4 = this.builderType.GetMethod("ParseExact", true, ps, pformat, pprovider, pstyle).Import();
			
				return this.var_parseexact_1_4;
			}
			
			return null;
			
		}
				
		private Method var_subtract_0_1;
				
		private Method var_subtract_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TimeSpan Subtract(System.DateTime)<para/>
		/// System.DateTime Subtract(System.TimeSpan)<para/>
		/// </summary>
		public Method GetMethod_Subtract(TypeReference pvalue)
		{
						
						
			if(typeof(System.DateTime).AreEqual(pvalue))
			{
				if(this.var_subtract_0_1 == null)
					this.var_subtract_0_1 = this.builderType.GetMethod("Subtract", true, pvalue).Import();
			
				return this.var_subtract_0_1;
			}
			
			if(typeof(System.TimeSpan).AreEqual(pvalue))
			{
				if(this.var_subtract_1_1 == null)
					this.var_subtract_1_1 = this.builderType.GetMethod("Subtract", true, pvalue).Import();
			
				return this.var_subtract_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tooadate_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double ToOADate()<para/>
		/// </summary>
		public Method GetMethod_ToOADate()
		{
						
			if(this.var_tooadate_0_0 == null)
				this.var_tooadate_0_0 = this.builderType.GetMethod("ToOADate", true);

			return this.var_tooadate_0_0;
						
						
		}
				
		private Method var_tofiletime_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToFileTime()<para/>
		/// </summary>
		public Method GetMethod_ToFileTime()
		{
						
			if(this.var_tofiletime_0_0 == null)
				this.var_tofiletime_0_0 = this.builderType.GetMethod("ToFileTime", true);

			return this.var_tofiletime_0_0;
						
						
		}
				
		private Method var_tofiletimeutc_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToFileTimeUtc()<para/>
		/// </summary>
		public Method GetMethod_ToFileTimeUtc()
		{
						
			if(this.var_tofiletimeutc_0_0 == null)
				this.var_tofiletimeutc_0_0 = this.builderType.GetMethod("ToFileTimeUtc", true);

			return this.var_tofiletimeutc_0_0;
						
						
		}
				
		private Method var_tolocaltime_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ToLocalTime()<para/>
		/// </summary>
		public Method GetMethod_ToLocalTime()
		{
						
			if(this.var_tolocaltime_0_0 == null)
				this.var_tolocaltime_0_0 = this.builderType.GetMethod("ToLocalTime", true);

			return this.var_tolocaltime_0_0;
						
						
		}
				
		private Method var_tolongdatestring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToLongDateString()<para/>
		/// </summary>
		public Method GetMethod_ToLongDateString()
		{
						
			if(this.var_tolongdatestring_0_0 == null)
				this.var_tolongdatestring_0_0 = this.builderType.GetMethod("ToLongDateString", true);

			return this.var_tolongdatestring_0_0;
						
						
		}
				
		private Method var_tolongtimestring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToLongTimeString()<para/>
		/// </summary>
		public Method GetMethod_ToLongTimeString()
		{
						
			if(this.var_tolongtimestring_0_0 == null)
				this.var_tolongtimestring_0_0 = this.builderType.GetMethod("ToLongTimeString", true);

			return this.var_tolongtimestring_0_0;
						
						
		}
				
		private Method var_toshortdatestring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToShortDateString()<para/>
		/// </summary>
		public Method GetMethod_ToShortDateString()
		{
						
			if(this.var_toshortdatestring_0_0 == null)
				this.var_toshortdatestring_0_0 = this.builderType.GetMethod("ToShortDateString", true);

			return this.var_toshortdatestring_0_0;
						
						
		}
				
		private Method var_toshorttimestring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToShortTimeString()<para/>
		/// </summary>
		public Method GetMethod_ToShortTimeString()
		{
						
			if(this.var_toshorttimestring_0_0 == null)
				this.var_toshorttimestring_0_0 = this.builderType.GetMethod("ToShortTimeString", true);

			return this.var_toshorttimestring_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_touniversaltime_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime ToUniversalTime()<para/>
		/// </summary>
		public Method GetMethod_ToUniversalTime()
		{
						
			if(this.var_touniversaltime_0_0 == null)
				this.var_touniversaltime_0_0 = this.builderType.GetMethod("ToUniversalTime", true);

			return this.var_touniversaltime_0_0;
						
						
		}
				
		private Method var_op_addition_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime op_Addition(System.DateTime, System.TimeSpan)<para/>
		/// </summary>
		public Method GetMethod_op_Addition(TypeReference pd, TypeReference pt)
		{
						
						
			if(this.var_op_addition_0_2 == null)
				this.var_op_addition_0_2 = this.builderType.GetMethod("op_Addition", true, pd, pt).Import();
			
			return this.var_op_addition_0_2;
						
		}
				
		private Method var_op_subtraction_0_2;
				
		private Method var_op_subtraction_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.DateTime op_Subtraction(System.DateTime, System.TimeSpan)<para/>
		/// System.TimeSpan op_Subtraction(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_Subtraction(TypeReference pd, TypeReference pt)
		{
						
						
			if(typeof(System.DateTime).AreEqual(pd) && typeof(System.TimeSpan).AreEqual(pt))
			{
				if(this.var_op_subtraction_0_2 == null)
					this.var_op_subtraction_0_2 = this.builderType.GetMethod("op_Subtraction", true, pd, pt).Import();
			
				return this.var_op_subtraction_0_2;
			}
			
			if(typeof(System.DateTime).AreEqual(pd) && typeof(System.DateTime).AreEqual(pt))
			{
				if(this.var_op_subtraction_1_2 == null)
					this.var_op_subtraction_1_2 = this.builderType.GetMethod("op_Subtraction", true, pd, pt).Import();
			
				return this.var_op_subtraction_1_2;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pd1, pd2).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pd1, pd2).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_op_lessthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThan(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_LessThan(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_op_lessthan_0_2 == null)
				this.var_op_lessthan_0_2 = this.builderType.GetMethod("op_LessThan", true, pt1, pt2).Import();
			
			return this.var_op_lessthan_0_2;
						
		}
				
		private Method var_op_lessthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThanOrEqual(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_LessThanOrEqual(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_op_lessthanorequal_0_2 == null)
				this.var_op_lessthanorequal_0_2 = this.builderType.GetMethod("op_LessThanOrEqual", true, pt1, pt2).Import();
			
			return this.var_op_lessthanorequal_0_2;
						
		}
				
		private Method var_op_greaterthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThan(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThan(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_op_greaterthan_0_2 == null)
				this.var_op_greaterthan_0_2 = this.builderType.GetMethod("op_GreaterThan", true, pt1, pt2).Import();
			
			return this.var_op_greaterthan_0_2;
						
		}
				
		private Method var_op_greaterthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThanOrEqual(System.DateTime, System.DateTime)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThanOrEqual(TypeReference pt1, TypeReference pt2)
		{
						
						
			if(this.var_op_greaterthanorequal_0_2 == null)
				this.var_op_greaterthanorequal_0_2 = this.builderType.GetMethod("op_GreaterThanOrEqual", true, pt1, pt2).Import();
			
			return this.var_op_greaterthanorequal_0_2;
						
		}
				
		private Method var_getdatetimeformats_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] GetDateTimeFormats()<para/>
		/// </summary>
		public Method GetMethod_GetDateTimeFormats()
		{
						
			if(this.var_getdatetimeformats_0_0 == null)
				this.var_getdatetimeformats_0_0 = this.builderType.GetMethod("GetDateTimeFormats", true);

			return this.var_getdatetimeformats_0_0;
						
						
		}
				
		private Method var_getdatetimeformats_0_1;
				
		private Method var_getdatetimeformats_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] GetDateTimeFormats(System.IFormatProvider)<para/>
		/// System.String[] GetDateTimeFormats(Char)<para/>
		/// </summary>
		public Method GetMethod_GetDateTimeFormats(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_getdatetimeformats_0_1 == null)
					this.var_getdatetimeformats_0_1 = this.builderType.GetMethod("GetDateTimeFormats", true, pprovider).Import();
			
				return this.var_getdatetimeformats_0_1;
			}
			
			if(typeof(System.Char).AreEqual(pprovider))
			{
				if(this.var_getdatetimeformats_1_1 == null)
					this.var_getdatetimeformats_1_1 = this.builderType.GetMethod("GetDateTimeFormats", true, pprovider).Import();
			
				return this.var_getdatetimeformats_1_1;
			}
			
			return null;
			
		}
				
		private Method var_getdatetimeformats_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] GetDateTimeFormats(Char, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_GetDateTimeFormats(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_getdatetimeformats_0_2 == null)
				this.var_getdatetimeformats_0_2 = this.builderType.GetMethod("GetDateTimeFormats", true, pformat, pprovider).Import();
			
			return this.var_getdatetimeformats_0_2;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Decimal"/>
    /// </summary>
    public partial class BuilderTypeDecimal : TypeSystemExBase
	{
        internal BuilderTypeDecimal(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeDecimal value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeDecimal value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tooacurrency_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToOACurrency(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToOACurrency(TypeReference pvalue)
		{
						
						
			if(this.var_tooacurrency_0_1 == null)
				this.var_tooacurrency_0_1 = this.builderType.GetMethod("ToOACurrency", true, pvalue).Import();
			
			return this.var_tooacurrency_0_1;
						
		}
				
		private Method var_fromoacurrency_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal FromOACurrency(Int64)<para/>
		/// </summary>
		public Method GetMethod_FromOACurrency(TypeReference pcy)
		{
						
						
			if(this.var_fromoacurrency_0_1 == null)
				this.var_fromoacurrency_0_1 = this.builderType.GetMethod("FromOACurrency", true, pcy).Import();
			
			return this.var_fromoacurrency_0_1;
						
		}
				
		private Method var_add_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Add(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_add_0_2 == null)
				this.var_add_0_2 = this.builderType.GetMethod("Add", true, pd1, pd2).Import();
			
			return this.var_add_0_2;
						
		}
				
		private Method var_ceiling_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Ceiling(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Ceiling(TypeReference pd)
		{
						
						
			if(this.var_ceiling_0_1 == null)
				this.var_ceiling_0_1 = this.builderType.GetMethod("Ceiling", true, pd).Import();
			
			return this.var_ceiling_0_1;
						
		}
				
		private Method var_compare_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_compare_0_2 == null)
				this.var_compare_0_2 = this.builderType.GetMethod("Compare", true, pd1, pd2).Import();
			
			return this.var_compare_0_2;
						
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_divide_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Divide(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Divide(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_divide_0_2 == null)
				this.var_divide_0_2 = this.builderType.GetMethod("Divide", true, pd1, pd2).Import();
			
			return this.var_divide_0_2;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pvalue).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pvalue).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_equals_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_equals_0_2 == null)
				this.var_equals_0_2 = this.builderType.GetMethod("Equals", true, pd1, pd2).Import();
			
			return this.var_equals_0_2;
						
		}
				
		private Method var_floor_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Floor(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Floor(TypeReference pd)
		{
						
						
			if(this.var_floor_0_1 == null)
				this.var_floor_0_1 = this.builderType.GetMethod("Floor", true, pd).Import();
			
			return this.var_floor_0_1;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// System.Decimal Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_getbits_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32[] GetBits(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_GetBits(TypeReference pd)
		{
						
						
			if(this.var_getbits_0_1 == null)
				this.var_getbits_0_1 = this.builderType.GetMethod("GetBits", true, pd).Import();
			
			return this.var_getbits_0_1;
						
		}
				
		private Method var_remainder_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Remainder(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Remainder(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_remainder_0_2 == null)
				this.var_remainder_0_2 = this.builderType.GetMethod("Remainder", true, pd1, pd2).Import();
			
			return this.var_remainder_0_2;
						
		}
				
		private Method var_multiply_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Multiply(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Multiply(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_multiply_0_2 == null)
				this.var_multiply_0_2 = this.builderType.GetMethod("Multiply", true, pd1, pd2).Import();
			
			return this.var_multiply_0_2;
						
		}
				
		private Method var_negate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Negate(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Negate(TypeReference pd)
		{
						
						
			if(this.var_negate_0_1 == null)
				this.var_negate_0_1 = this.builderType.GetMethod("Negate", true, pd).Import();
			
			return this.var_negate_0_1;
						
		}
				
		private Method var_round_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Round(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Round(TypeReference pd)
		{
						
						
			if(this.var_round_0_1 == null)
				this.var_round_0_1 = this.builderType.GetMethod("Round", true, pd).Import();
			
			return this.var_round_0_1;
						
		}
				
		private Method var_round_0_2;
				
		private Method var_round_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Round(System.Decimal, Int32)<para/>
		/// System.Decimal Round(System.Decimal, System.MidpointRounding)<para/>
		/// </summary>
		public Method GetMethod_Round(TypeReference pd, TypeReference pdecimals)
		{
						
						
			if(typeof(System.Decimal).AreEqual(pd) && typeof(System.Int32).AreEqual(pdecimals))
			{
				if(this.var_round_0_2 == null)
					this.var_round_0_2 = this.builderType.GetMethod("Round", true, pd, pdecimals).Import();
			
				return this.var_round_0_2;
			}
			
			if(typeof(System.Decimal).AreEqual(pd) && typeof(System.MidpointRounding).AreEqual(pdecimals))
			{
				if(this.var_round_1_2 == null)
					this.var_round_1_2 = this.builderType.GetMethod("Round", true, pd, pdecimals).Import();
			
				return this.var_round_1_2;
			}
			
			return null;
			
		}
				
		private Method var_round_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Round(System.Decimal, Int32, System.MidpointRounding)<para/>
		/// </summary>
		public Method GetMethod_Round(TypeReference pd, TypeReference pdecimals, TypeReference pmode)
		{
						
						
			if(this.var_round_0_3 == null)
				this.var_round_0_3 = this.builderType.GetMethod("Round", true, pd, pdecimals, pmode).Import();
			
			return this.var_round_0_3;
						
		}
				
		private Method var_subtract_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Subtract(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Subtract(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_subtract_0_2 == null)
				this.var_subtract_0_2 = this.builderType.GetMethod("Subtract", true, pd1, pd2).Import();
			
			return this.var_subtract_0_2;
						
		}
				
		private Method var_tobyte_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Byte ToByte(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToByte(TypeReference pvalue)
		{
						
						
			if(this.var_tobyte_0_1 == null)
				this.var_tobyte_0_1 = this.builderType.GetMethod("ToByte", true, pvalue).Import();
			
			return this.var_tobyte_0_1;
						
		}
				
		private Method var_tosbyte_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte ToSByte(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToSByte(TypeReference pvalue)
		{
						
						
			if(this.var_tosbyte_0_1 == null)
				this.var_tosbyte_0_1 = this.builderType.GetMethod("ToSByte", true, pvalue).Import();
			
			return this.var_tosbyte_0_1;
						
		}
				
		private Method var_toint16_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 ToInt16(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToInt16(TypeReference pvalue)
		{
						
						
			if(this.var_toint16_0_1 == null)
				this.var_toint16_0_1 = this.builderType.GetMethod("ToInt16", true, pvalue).Import();
			
			return this.var_toint16_0_1;
						
		}
				
		private Method var_todouble_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double ToDouble(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToDouble(TypeReference pd)
		{
						
						
			if(this.var_todouble_0_1 == null)
				this.var_todouble_0_1 = this.builderType.GetMethod("ToDouble", true, pd).Import();
			
			return this.var_todouble_0_1;
						
		}
				
		private Method var_toint32_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToInt32(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToInt32(TypeReference pd)
		{
						
						
			if(this.var_toint32_0_1 == null)
				this.var_toint32_0_1 = this.builderType.GetMethod("ToInt32", true, pd).Import();
			
			return this.var_toint32_0_1;
						
		}
				
		private Method var_toint64_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToInt64(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToInt64(TypeReference pd)
		{
						
						
			if(this.var_toint64_0_1 == null)
				this.var_toint64_0_1 = this.builderType.GetMethod("ToInt64", true, pd).Import();
			
			return this.var_toint64_0_1;
						
		}
				
		private Method var_touint16_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 ToUInt16(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToUInt16(TypeReference pvalue)
		{
						
						
			if(this.var_touint16_0_1 == null)
				this.var_touint16_0_1 = this.builderType.GetMethod("ToUInt16", true, pvalue).Import();
			
			return this.var_touint16_0_1;
						
		}
				
		private Method var_touint32_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 ToUInt32(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToUInt32(TypeReference pd)
		{
						
						
			if(this.var_touint32_0_1 == null)
				this.var_touint32_0_1 = this.builderType.GetMethod("ToUInt32", true, pd).Import();
			
			return this.var_touint32_0_1;
						
		}
				
		private Method var_touint64_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 ToUInt64(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToUInt64(TypeReference pd)
		{
						
						
			if(this.var_touint64_0_1 == null)
				this.var_touint64_0_1 = this.builderType.GetMethod("ToUInt64", true, pd).Import();
			
			return this.var_touint64_0_1;
						
		}
				
		private Method var_tosingle_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single ToSingle(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_ToSingle(TypeReference pd)
		{
						
						
			if(this.var_tosingle_0_1 == null)
				this.var_tosingle_0_1 = this.builderType.GetMethod("ToSingle", true, pd).Import();
			
			return this.var_tosingle_0_1;
						
		}
				
		private Method var_truncate_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal Truncate(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_Truncate(TypeReference pd)
		{
						
						
			if(this.var_truncate_0_1 == null)
				this.var_truncate_0_1 = this.builderType.GetMethod("Truncate", true, pd).Import();
			
			return this.var_truncate_0_1;
						
		}
				
		private Method var_op_implicit_0_1;
				
		private Method var_op_implicit_1_1;
				
		private Method var_op_implicit_2_1;
				
		private Method var_op_implicit_3_1;
				
		private Method var_op_implicit_4_1;
				
		private Method var_op_implicit_5_1;
				
		private Method var_op_implicit_6_1;
				
		private Method var_op_implicit_7_1;
				
		private Method var_op_implicit_8_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Implicit(Byte)<para/>
		/// System.Decimal op_Implicit(SByte)<para/>
		/// System.Decimal op_Implicit(Int16)<para/>
		/// System.Decimal op_Implicit(UInt16)<para/>
		/// System.Decimal op_Implicit(Char)<para/>
		/// System.Decimal op_Implicit(Int32)<para/>
		/// System.Decimal op_Implicit(UInt32)<para/>
		/// System.Decimal op_Implicit(Int64)<para/>
		/// System.Decimal op_Implicit(UInt64)<para/>
		/// </summary>
		public Method GetMethod_op_Implicit(TypeReference pvalue)
		{
						
						
			if(typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_op_implicit_0_1 == null)
					this.var_op_implicit_0_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_op_implicit_1_1 == null)
					this.var_op_implicit_1_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_1_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_op_implicit_2_1 == null)
					this.var_op_implicit_2_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_2_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_op_implicit_3_1 == null)
					this.var_op_implicit_3_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_3_1;
			}
			
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_op_implicit_4_1 == null)
					this.var_op_implicit_4_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_4_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_op_implicit_5_1 == null)
					this.var_op_implicit_5_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_5_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_op_implicit_6_1 == null)
					this.var_op_implicit_6_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_6_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_op_implicit_7_1 == null)
					this.var_op_implicit_7_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_7_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_op_implicit_8_1 == null)
					this.var_op_implicit_8_1 = this.builderType.GetMethod("op_Implicit", true, pvalue).Import();
			
				return this.var_op_implicit_8_1;
			}
			
			return null;
			
		}
				
		private Method var_op_explicit_0_1;
				
		private Method var_op_explicit_1_1;
				
		private Method var_op_explicit_2_1;
				
		private Method var_op_explicit_3_1;
				
		private Method var_op_explicit_4_1;
				
		private Method var_op_explicit_5_1;
				
		private Method var_op_explicit_6_1;
				
		private Method var_op_explicit_7_1;
				
		private Method var_op_explicit_8_1;
				
		private Method var_op_explicit_9_1;
				
		private Method var_op_explicit_10_1;
				
		private Method var_op_explicit_11_1;
				
		private Method var_op_explicit_12_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Explicit(Single)<para/>
		/// System.Decimal op_Explicit(Double)<para/>
		/// Byte op_Explicit(System.Decimal)<para/>
		/// SByte op_Explicit(System.Decimal)<para/>
		/// Char op_Explicit(System.Decimal)<para/>
		/// Int16 op_Explicit(System.Decimal)<para/>
		/// UInt16 op_Explicit(System.Decimal)<para/>
		/// Int32 op_Explicit(System.Decimal)<para/>
		/// UInt32 op_Explicit(System.Decimal)<para/>
		/// Int64 op_Explicit(System.Decimal)<para/>
		/// UInt64 op_Explicit(System.Decimal)<para/>
		/// Single op_Explicit(System.Decimal)<para/>
		/// Double op_Explicit(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Explicit(TypeReference pvalue)
		{
						
						
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_op_explicit_0_1 == null)
					this.var_op_explicit_0_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_0_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_op_explicit_1_1 == null)
					this.var_op_explicit_1_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_1_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_2_1 == null)
					this.var_op_explicit_2_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_2_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_3_1 == null)
					this.var_op_explicit_3_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_3_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_4_1 == null)
					this.var_op_explicit_4_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_4_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_5_1 == null)
					this.var_op_explicit_5_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_5_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_6_1 == null)
					this.var_op_explicit_6_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_6_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_7_1 == null)
					this.var_op_explicit_7_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_7_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_8_1 == null)
					this.var_op_explicit_8_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_8_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_9_1 == null)
					this.var_op_explicit_9_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_9_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_10_1 == null)
					this.var_op_explicit_10_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_10_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_11_1 == null)
					this.var_op_explicit_11_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_11_1;
			}
			
			if(typeof(System.Decimal).AreEqual(pvalue))
			{
				if(this.var_op_explicit_12_1 == null)
					this.var_op_explicit_12_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_12_1;
			}
			
			return null;
			
		}
				
		private Method var_op_unaryplus_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_UnaryPlus(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_UnaryPlus(TypeReference pd)
		{
						
						
			if(this.var_op_unaryplus_0_1 == null)
				this.var_op_unaryplus_0_1 = this.builderType.GetMethod("op_UnaryPlus", true, pd).Import();
			
			return this.var_op_unaryplus_0_1;
						
		}
				
		private Method var_op_unarynegation_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_UnaryNegation(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_UnaryNegation(TypeReference pd)
		{
						
						
			if(this.var_op_unarynegation_0_1 == null)
				this.var_op_unarynegation_0_1 = this.builderType.GetMethod("op_UnaryNegation", true, pd).Import();
			
			return this.var_op_unarynegation_0_1;
						
		}
				
		private Method var_op_increment_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Increment(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Increment(TypeReference pd)
		{
						
						
			if(this.var_op_increment_0_1 == null)
				this.var_op_increment_0_1 = this.builderType.GetMethod("op_Increment", true, pd).Import();
			
			return this.var_op_increment_0_1;
						
		}
				
		private Method var_op_decrement_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Decrement(System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Decrement(TypeReference pd)
		{
						
						
			if(this.var_op_decrement_0_1 == null)
				this.var_op_decrement_0_1 = this.builderType.GetMethod("op_Decrement", true, pd).Import();
			
			return this.var_op_decrement_0_1;
						
		}
				
		private Method var_op_addition_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Addition(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Addition(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_addition_0_2 == null)
				this.var_op_addition_0_2 = this.builderType.GetMethod("op_Addition", true, pd1, pd2).Import();
			
			return this.var_op_addition_0_2;
						
		}
				
		private Method var_op_subtraction_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Subtraction(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Subtraction(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_subtraction_0_2 == null)
				this.var_op_subtraction_0_2 = this.builderType.GetMethod("op_Subtraction", true, pd1, pd2).Import();
			
			return this.var_op_subtraction_0_2;
						
		}
				
		private Method var_op_multiply_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Multiply(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Multiply(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_multiply_0_2 == null)
				this.var_op_multiply_0_2 = this.builderType.GetMethod("op_Multiply", true, pd1, pd2).Import();
			
			return this.var_op_multiply_0_2;
						
		}
				
		private Method var_op_division_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Division(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Division(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_division_0_2 == null)
				this.var_op_division_0_2 = this.builderType.GetMethod("op_Division", true, pd1, pd2).Import();
			
			return this.var_op_division_0_2;
						
		}
				
		private Method var_op_modulus_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Decimal op_Modulus(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Modulus(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_modulus_0_2 == null)
				this.var_op_modulus_0_2 = this.builderType.GetMethod("op_Modulus", true, pd1, pd2).Import();
			
			return this.var_op_modulus_0_2;
						
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pd1, pd2).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pd1, pd2).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_op_lessthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThan(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_LessThan(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_lessthan_0_2 == null)
				this.var_op_lessthan_0_2 = this.builderType.GetMethod("op_LessThan", true, pd1, pd2).Import();
			
			return this.var_op_lessthan_0_2;
						
		}
				
		private Method var_op_lessthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThanOrEqual(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_LessThanOrEqual(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_lessthanorequal_0_2 == null)
				this.var_op_lessthanorequal_0_2 = this.builderType.GetMethod("op_LessThanOrEqual", true, pd1, pd2).Import();
			
			return this.var_op_lessthanorequal_0_2;
						
		}
				
		private Method var_op_greaterthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThan(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThan(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_greaterthan_0_2 == null)
				this.var_op_greaterthan_0_2 = this.builderType.GetMethod("op_GreaterThan", true, pd1, pd2).Import();
			
			return this.var_op_greaterthan_0_2;
						
		}
				
		private Method var_op_greaterthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThanOrEqual(System.Decimal, System.Decimal)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThanOrEqual(TypeReference pd1, TypeReference pd2)
		{
						
						
			if(this.var_op_greaterthanorequal_0_2 == null)
				this.var_op_greaterthanorequal_0_2 = this.builderType.GetMethod("op_GreaterThanOrEqual", true, pd1, pd2).Import();
			
			return this.var_op_greaterthanorequal_0_2;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.Dictionary{TKey,TValue}"/>
    /// </summary>
    public partial class BuilderTypeDictionary2 : TypeSystemExBase
	{
        internal BuilderTypeDictionary2(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeDictionary2 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeDictionary2 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Double"/>
    /// </summary>
    public partial class BuilderTypeDouble : TypeSystemExBase
	{
        internal BuilderTypeDouble(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeDouble value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeDouble value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_isinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsInfinity(Double)<para/>
		/// </summary>
		public Method GetMethod_IsInfinity(TypeReference pd)
		{
						
						
			if(this.var_isinfinity_0_1 == null)
				this.var_isinfinity_0_1 = this.builderType.GetMethod("IsInfinity", true, pd).Import();
			
			return this.var_isinfinity_0_1;
						
		}
				
		private Method var_ispositiveinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsPositiveInfinity(Double)<para/>
		/// </summary>
		public Method GetMethod_IsPositiveInfinity(TypeReference pd)
		{
						
						
			if(this.var_ispositiveinfinity_0_1 == null)
				this.var_ispositiveinfinity_0_1 = this.builderType.GetMethod("IsPositiveInfinity", true, pd).Import();
			
			return this.var_ispositiveinfinity_0_1;
						
		}
				
		private Method var_isnegativeinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNegativeInfinity(Double)<para/>
		/// </summary>
		public Method GetMethod_IsNegativeInfinity(TypeReference pd)
		{
						
						
			if(this.var_isnegativeinfinity_0_1 == null)
				this.var_isnegativeinfinity_0_1 = this.builderType.GetMethod("IsNegativeInfinity", true, pd).Import();
			
			return this.var_isnegativeinfinity_0_1;
						
		}
				
		private Method var_isnan_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNaN(Double)<para/>
		/// </summary>
		public Method GetMethod_IsNaN(TypeReference pd)
		{
						
						
			if(this.var_isnan_0_1 == null)
				this.var_isnan_0_1 = this.builderType.GetMethod("IsNaN", true, pd).Import();
			
			return this.var_isnan_0_1;
						
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Double)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Double).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Double)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Double).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pleft, pright).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pleft, pright).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_op_lessthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThan(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_LessThan(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_lessthan_0_2 == null)
				this.var_op_lessthan_0_2 = this.builderType.GetMethod("op_LessThan", true, pleft, pright).Import();
			
			return this.var_op_lessthan_0_2;
						
		}
				
		private Method var_op_greaterthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThan(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThan(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_greaterthan_0_2 == null)
				this.var_op_greaterthan_0_2 = this.builderType.GetMethod("op_GreaterThan", true, pleft, pright).Import();
			
			return this.var_op_greaterthan_0_2;
						
		}
				
		private Method var_op_lessthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThanOrEqual(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_LessThanOrEqual(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_lessthanorequal_0_2 == null)
				this.var_op_lessthanorequal_0_2 = this.builderType.GetMethod("op_LessThanOrEqual", true, pleft, pright).Import();
			
			return this.var_op_lessthanorequal_0_2;
						
		}
				
		private Method var_op_greaterthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThanOrEqual(Double, Double)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThanOrEqual(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_greaterthanorequal_0_2 == null)
				this.var_op_greaterthanorequal_0_2 = this.builderType.GetMethod("op_GreaterThanOrEqual", true, pleft, pright).Import();
			
			return this.var_op_greaterthanorequal_0_2;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Double Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Enum"/>
    /// </summary>
    public partial class BuilderTypeEnum : TypeSystemExBase
	{
        internal BuilderTypeEnum(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeEnum value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeEnum value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_parse_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Parse(System.Type, System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference penumType, TypeReference pvalue)
		{
						
						
			if(this.var_parse_0_2 == null)
				this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, penumType, pvalue).Import();
			
			return this.var_parse_0_2;
						
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Parse(System.Type, System.String, Boolean)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference penumType, TypeReference pvalue, TypeReference pignoreCase)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, penumType, pvalue, pignoreCase).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_getunderlyingtype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetUnderlyingType(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetUnderlyingType(TypeReference penumType)
		{
						
						
			if(this.var_getunderlyingtype_0_1 == null)
				this.var_getunderlyingtype_0_1 = this.builderType.GetMethod("GetUnderlyingType", true, penumType).Import();
			
			return this.var_getunderlyingtype_0_1;
						
		}
				
		private Method var_getvalues_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Array GetValues(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetValues(TypeReference penumType)
		{
						
						
			if(this.var_getvalues_0_1 == null)
				this.var_getvalues_0_1 = this.builderType.GetMethod("GetValues", true, penumType).Import();
			
			return this.var_getvalues_0_1;
						
		}
				
		private Method var_getname_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String GetName(System.Type, System.Object)<para/>
		/// </summary>
		public Method GetMethod_GetName(TypeReference penumType, TypeReference pvalue)
		{
						
						
			if(this.var_getname_0_2 == null)
				this.var_getname_0_2 = this.builderType.GetMethod("GetName", true, penumType, pvalue).Import();
			
			return this.var_getname_0_2;
						
		}
				
		private Method var_getnames_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] GetNames(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetNames(TypeReference penumType)
		{
						
						
			if(this.var_getnames_0_1 == null)
				this.var_getnames_0_1 = this.builderType.GetMethod("GetNames", true, penumType).Import();
			
			return this.var_getnames_0_1;
						
		}
				
		private Method var_toobject_0_2;
				
		private Method var_toobject_1_2;
				
		private Method var_toobject_2_2;
				
		private Method var_toobject_3_2;
				
		private Method var_toobject_4_2;
				
		private Method var_toobject_5_2;
				
		private Method var_toobject_6_2;
				
		private Method var_toobject_7_2;
				
		private Method var_toobject_8_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object ToObject(System.Type, System.Object)<para/>
		/// System.Object ToObject(System.Type, SByte)<para/>
		/// System.Object ToObject(System.Type, Int16)<para/>
		/// System.Object ToObject(System.Type, Int32)<para/>
		/// System.Object ToObject(System.Type, Byte)<para/>
		/// System.Object ToObject(System.Type, UInt16)<para/>
		/// System.Object ToObject(System.Type, UInt32)<para/>
		/// System.Object ToObject(System.Type, Int64)<para/>
		/// System.Object ToObject(System.Type, UInt64)<para/>
		/// </summary>
		public Method GetMethod_ToObject(TypeReference penumType, TypeReference pvalue)
		{
						
						
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_toobject_0_2 == null)
					this.var_toobject_0_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_0_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.SByte).AreEqual(pvalue))
			{
				if(this.var_toobject_1_2 == null)
					this.var_toobject_1_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_1_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_toobject_2_2 == null)
					this.var_toobject_2_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_2_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_toobject_3_2 == null)
					this.var_toobject_3_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_3_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.Byte).AreEqual(pvalue))
			{
				if(this.var_toobject_4_2 == null)
					this.var_toobject_4_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_4_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_toobject_5_2 == null)
					this.var_toobject_5_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_5_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_toobject_6_2 == null)
					this.var_toobject_6_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_6_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_toobject_7_2 == null)
					this.var_toobject_7_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_7_2;
			}
			
			if(typeof(System.Type).AreEqual(penumType) && typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_toobject_8_2 == null)
					this.var_toobject_8_2 = this.builderType.GetMethod("ToObject", true, penumType, pvalue).Import();
			
				return this.var_toobject_8_2;
			}
			
			return null;
			
		}
				
		private Method var_isdefined_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDefined(System.Type, System.Object)<para/>
		/// </summary>
		public Method GetMethod_IsDefined(TypeReference penumType, TypeReference pvalue)
		{
						
						
			if(this.var_isdefined_0_2 == null)
				this.var_isdefined_0_2 = this.builderType.GetMethod("IsDefined", true, penumType, pvalue).Import();
			
			return this.var_isdefined_0_2;
						
		}
				
		private Method var_format_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Format(System.Type, System.Object, System.String)<para/>
		/// </summary>
		public Method GetMethod_Format(TypeReference penumType, TypeReference pvalue, TypeReference pformat)
		{
						
						
			if(this.var_format_0_3 == null)
				this.var_format_0_3 = this.builderType.GetMethod("Format", true, penumType, pvalue, pformat).Import();
			
			return this.var_format_0_3;
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_compareto_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference ptarget)
		{
						
						
			if(this.var_compareto_0_1 == null)
				this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, ptarget).Import();
			
			return this.var_compareto_0_1;
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_hasflag_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean HasFlag(System.Enum)<para/>
		/// </summary>
		public Method GetMethod_HasFlag(TypeReference pflag)
		{
						
						
			if(this.var_hasflag_0_1 == null)
				this.var_hasflag_0_1 = this.builderType.GetMethod("HasFlag", true, pflag).Import();
			
			return this.var_hasflag_0_1;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Linq.Enumerable"/>
    /// </summary>
    public partial class BuilderTypeEnumerable : TypeSystemExBase
	{
        internal BuilderTypeEnumerable(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeEnumerable value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeEnumerable value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_max_0_1;
				
		private Method var_max_1_1;
				
		private Method var_max_2_1;
				
		private Method var_max_3_1;
				
		private Method var_max_4_1;
				
		private Method var_max_5_1;
				
		private Method var_max_6_1;
				
		private Method var_max_7_1;
				
		private Method var_max_8_1;
				
		private Method var_max_9_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Max(System.Collections.Generic.IEnumerable`1[System.Int32])<para/>
		/// System.Nullable`1[System.Int32] Max(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int32]])<para/>
		/// Int64 Max(System.Collections.Generic.IEnumerable`1[System.Int64])<para/>
		/// System.Nullable`1[System.Int64] Max(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int64]])<para/>
		/// Double Max(System.Collections.Generic.IEnumerable`1[System.Double])<para/>
		/// System.Nullable`1[System.Double] Max(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Double]])<para/>
		/// Single Max(System.Collections.Generic.IEnumerable`1[System.Single])<para/>
		/// System.Nullable`1[System.Single] Max(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Single]])<para/>
		/// System.Decimal Max(System.Collections.Generic.IEnumerable`1[System.Decimal])<para/>
		/// System.Nullable`1[System.Decimal] Max(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Decimal]])<para/>
		/// </summary>
		public Method GetMethod_Max(TypeReference psource)
		{
						
						
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_0_1 == null)
					this.var_max_0_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_0_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_1_1 == null)
					this.var_max_1_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_1_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_2_1 == null)
					this.var_max_2_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_2_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_3_1 == null)
					this.var_max_3_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_3_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_4_1 == null)
					this.var_max_4_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_4_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_5_1 == null)
					this.var_max_5_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_5_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_6_1 == null)
					this.var_max_6_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_6_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_7_1 == null)
					this.var_max_7_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_7_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_8_1 == null)
					this.var_max_8_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_8_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_max_9_1 == null)
					this.var_max_9_1 = this.builderType.GetMethod("Max", true, psource).Import();
			
				return this.var_max_9_1;
			}
			
			return null;
			
		}
				
		private Method var_average_0_1;
				
		private Method var_average_1_1;
				
		private Method var_average_2_1;
				
		private Method var_average_3_1;
				
		private Method var_average_4_1;
				
		private Method var_average_5_1;
				
		private Method var_average_6_1;
				
		private Method var_average_7_1;
				
		private Method var_average_8_1;
				
		private Method var_average_9_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Double Average(System.Collections.Generic.IEnumerable`1[System.Int32])<para/>
		/// System.Nullable`1[System.Double] Average(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int32]])<para/>
		/// Double Average(System.Collections.Generic.IEnumerable`1[System.Int64])<para/>
		/// System.Nullable`1[System.Double] Average(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int64]])<para/>
		/// Single Average(System.Collections.Generic.IEnumerable`1[System.Single])<para/>
		/// System.Nullable`1[System.Single] Average(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Single]])<para/>
		/// Double Average(System.Collections.Generic.IEnumerable`1[System.Double])<para/>
		/// System.Nullable`1[System.Double] Average(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Double]])<para/>
		/// System.Decimal Average(System.Collections.Generic.IEnumerable`1[System.Decimal])<para/>
		/// System.Nullable`1[System.Decimal] Average(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Decimal]])<para/>
		/// </summary>
		public Method GetMethod_Average(TypeReference psource)
		{
						
						
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_0_1 == null)
					this.var_average_0_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_0_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_1_1 == null)
					this.var_average_1_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_1_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_2_1 == null)
					this.var_average_2_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_2_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_3_1 == null)
					this.var_average_3_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_3_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_4_1 == null)
					this.var_average_4_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_4_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_5_1 == null)
					this.var_average_5_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_5_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_6_1 == null)
					this.var_average_6_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_6_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_7_1 == null)
					this.var_average_7_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_7_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_8_1 == null)
					this.var_average_8_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_8_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_average_9_1 == null)
					this.var_average_9_1 = this.builderType.GetMethod("Average", true, psource).Import();
			
				return this.var_average_9_1;
			}
			
			return null;
			
		}
				
		private Method var_range_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.Generic.IEnumerable`1[System.Int32] Range(Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Range(TypeReference pstart, TypeReference pcount)
		{
						
						
			if(this.var_range_0_2 == null)
				this.var_range_0_2 = this.builderType.GetMethod("Range", true, pstart, pcount).Import();
			
			return this.var_range_0_2;
						
		}
				
		private Method var_sum_0_1;
				
		private Method var_sum_1_1;
				
		private Method var_sum_2_1;
				
		private Method var_sum_3_1;
				
		private Method var_sum_4_1;
				
		private Method var_sum_5_1;
				
		private Method var_sum_6_1;
				
		private Method var_sum_7_1;
				
		private Method var_sum_8_1;
				
		private Method var_sum_9_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Sum(System.Collections.Generic.IEnumerable`1[System.Int32])<para/>
		/// System.Nullable`1[System.Int32] Sum(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int32]])<para/>
		/// Int64 Sum(System.Collections.Generic.IEnumerable`1[System.Int64])<para/>
		/// System.Nullable`1[System.Int64] Sum(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int64]])<para/>
		/// Single Sum(System.Collections.Generic.IEnumerable`1[System.Single])<para/>
		/// System.Nullable`1[System.Single] Sum(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Single]])<para/>
		/// Double Sum(System.Collections.Generic.IEnumerable`1[System.Double])<para/>
		/// System.Nullable`1[System.Double] Sum(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Double]])<para/>
		/// System.Decimal Sum(System.Collections.Generic.IEnumerable`1[System.Decimal])<para/>
		/// System.Nullable`1[System.Decimal] Sum(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Decimal]])<para/>
		/// </summary>
		public Method GetMethod_Sum(TypeReference psource)
		{
						
						
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_0_1 == null)
					this.var_sum_0_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_0_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_1_1 == null)
					this.var_sum_1_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_1_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_2_1 == null)
					this.var_sum_2_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_2_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_3_1 == null)
					this.var_sum_3_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_3_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_4_1 == null)
					this.var_sum_4_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_4_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_5_1 == null)
					this.var_sum_5_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_5_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_6_1 == null)
					this.var_sum_6_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_6_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_7_1 == null)
					this.var_sum_7_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_7_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_8_1 == null)
					this.var_sum_8_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_8_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_sum_9_1 == null)
					this.var_sum_9_1 = this.builderType.GetMethod("Sum", true, psource).Import();
			
				return this.var_sum_9_1;
			}
			
			return null;
			
		}
				
		private Method var_min_0_1;
				
		private Method var_min_1_1;
				
		private Method var_min_2_1;
				
		private Method var_min_3_1;
				
		private Method var_min_4_1;
				
		private Method var_min_5_1;
				
		private Method var_min_6_1;
				
		private Method var_min_7_1;
				
		private Method var_min_8_1;
				
		private Method var_min_9_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Min(System.Collections.Generic.IEnumerable`1[System.Int32])<para/>
		/// System.Nullable`1[System.Int32] Min(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int32]])<para/>
		/// Int64 Min(System.Collections.Generic.IEnumerable`1[System.Int64])<para/>
		/// System.Nullable`1[System.Int64] Min(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Int64]])<para/>
		/// Single Min(System.Collections.Generic.IEnumerable`1[System.Single])<para/>
		/// System.Nullable`1[System.Single] Min(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Single]])<para/>
		/// Double Min(System.Collections.Generic.IEnumerable`1[System.Double])<para/>
		/// System.Nullable`1[System.Double] Min(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Double]])<para/>
		/// System.Decimal Min(System.Collections.Generic.IEnumerable`1[System.Decimal])<para/>
		/// System.Nullable`1[System.Decimal] Min(System.Collections.Generic.IEnumerable`1[System.Nullable`1[System.Decimal]])<para/>
		/// </summary>
		public Method GetMethod_Min(TypeReference psource)
		{
						
						
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_0_1 == null)
					this.var_min_0_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_0_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_1_1 == null)
					this.var_min_1_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_1_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_2_1 == null)
					this.var_min_2_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_2_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_3_1 == null)
					this.var_min_3_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_3_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_4_1 == null)
					this.var_min_4_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_4_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_5_1 == null)
					this.var_min_5_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_5_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_6_1 == null)
					this.var_min_6_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_6_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_7_1 == null)
					this.var_min_7_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_7_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_8_1 == null)
					this.var_min_8_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_8_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(psource))
			{
				if(this.var_min_9_1 == null)
					this.var_min_9_1 = this.builderType.GetMethod("Min", true, psource).Import();
			
				return this.var_min_9_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.EventArgs"/>
    /// </summary>
    public partial class BuilderTypeEventArgs : TypeSystemExBase
	{
        internal BuilderTypeEventArgs(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeEventArgs value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeEventArgs value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.EventHandler"/>
    /// </summary>
    public partial class BuilderTypeEventHandler : TypeSystemExBase
	{
        internal BuilderTypeEventHandler(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeEventHandler value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeEventHandler value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_invoke_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Invoke(System.Object, System.EventArgs)<para/>
		/// </summary>
		public Method GetMethod_Invoke(TypeReference psender, TypeReference pe)
		{
						
						
			if(this.var_invoke_0_2 == null)
				this.var_invoke_0_2 = this.builderType.GetMethod("Invoke", true, psender, pe).Import();
			
			return this.var_invoke_0_2;
						
		}
				
		private Method var_begininvoke_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.IAsyncResult BeginInvoke(System.Object, System.EventArgs, System.AsyncCallback, System.Object)<para/>
		/// </summary>
		public Method GetMethod_BeginInvoke(TypeReference psender, TypeReference pe, TypeReference pcallback, TypeReference pobject)
		{
						
						
			if(this.var_begininvoke_0_4 == null)
				this.var_begininvoke_0_4 = this.builderType.GetMethod("BeginInvoke", true, psender, pe, pcallback, pobject).Import();
			
			return this.var_begininvoke_0_4;
						
		}
				
		private Method var_endinvoke_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void EndInvoke(System.IAsyncResult)<para/>
		/// </summary>
		public Method GetMethod_EndInvoke(TypeReference presult)
		{
						
						
			if(this.var_endinvoke_0_1 == null)
				this.var_endinvoke_0_1 = this.builderType.GetMethod("EndInvoke", true, presult).Import();
			
			return this.var_endinvoke_0_1;
						
		}
				
		private Method var_getobjectdata_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)<para/>
		/// </summary>
		public Method GetMethod_GetObjectData(TypeReference pinfo, TypeReference pcontext)
		{
						
						
			if(this.var_getobjectdata_0_2 == null)
				this.var_getobjectdata_0_2 = this.builderType.GetMethod("GetObjectData", true, pinfo, pcontext).Import();
			
			return this.var_getobjectdata_0_2;
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_getinvocationlist_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Delegate[] GetInvocationList()<para/>
		/// </summary>
		public Method GetMethod_GetInvocationList()
		{
						
			if(this.var_getinvocationlist_0_0 == null)
				this.var_getinvocationlist_0_0 = this.builderType.GetMethod("GetInvocationList", true);

			return this.var_getinvocationlist_0_0;
						
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_dynamicinvoke_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object DynamicInvoke(System.Object[])<para/>
		/// </summary>
		public Method GetMethod_DynamicInvoke(TypeReference pargs)
		{
						
						
			if(this.var_dynamicinvoke_0_1 == null)
				this.var_dynamicinvoke_0_1 = this.builderType.GetMethod("DynamicInvoke", true, pargs).Import();
			
			return this.var_dynamicinvoke_0_1;
						
		}
				
		private Method var_get_method_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo get_Method()<para/>
		/// </summary>
		public Method GetMethod_get_Method()
		{
						
			if(this.var_get_method_0_0 == null)
				this.var_get_method_0_0 = this.builderType.GetMethod("get_Method", true);

			return this.var_get_method_0_0;
						
						
		}
				
		private Method var_get_target_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_Target()<para/>
		/// </summary>
		public Method GetMethod_get_Target()
		{
						
			if(this.var_get_target_0_0 == null)
				this.var_get_target_0_0 = this.builderType.GetMethod("get_Target", true);

			return this.var_get_target_0_0;
						
						
		}
				
		private Method var_clone_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Clone()<para/>
		/// </summary>
		public Method GetMethod_Clone()
		{
						
			if(this.var_clone_0_0 == null)
				this.var_clone_0_0 = this.builderType.GetMethod("Clone", true);

			return this.var_clone_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.EventHandler{TEventArgs}"/>
    /// </summary>
    public partial class BuilderTypeEventHandler1 : TypeSystemExBase
	{
        internal BuilderTypeEventHandler1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeEventHandler1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeEventHandler1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_getobjectdata_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)<para/>
		/// </summary>
		public Method GetMethod_GetObjectData(TypeReference pinfo, TypeReference pcontext)
		{
						
						
			if(this.var_getobjectdata_0_2 == null)
				this.var_getobjectdata_0_2 = this.builderType.GetMethod("GetObjectData", true, pinfo, pcontext).Import();
			
			return this.var_getobjectdata_0_2;
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_getinvocationlist_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Delegate[] GetInvocationList()<para/>
		/// </summary>
		public Method GetMethod_GetInvocationList()
		{
						
			if(this.var_getinvocationlist_0_0 == null)
				this.var_getinvocationlist_0_0 = this.builderType.GetMethod("GetInvocationList", true);

			return this.var_getinvocationlist_0_0;
						
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_dynamicinvoke_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object DynamicInvoke(System.Object[])<para/>
		/// </summary>
		public Method GetMethod_DynamicInvoke(TypeReference pargs)
		{
						
						
			if(this.var_dynamicinvoke_0_1 == null)
				this.var_dynamicinvoke_0_1 = this.builderType.GetMethod("DynamicInvoke", true, pargs).Import();
			
			return this.var_dynamicinvoke_0_1;
						
		}
				
		private Method var_get_method_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo get_Method()<para/>
		/// </summary>
		public Method GetMethod_get_Method()
		{
						
			if(this.var_get_method_0_0 == null)
				this.var_get_method_0_0 = this.builderType.GetMethod("get_Method", true);

			return this.var_get_method_0_0;
						
						
		}
				
		private Method var_get_target_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_Target()<para/>
		/// </summary>
		public Method GetMethod_get_Target()
		{
						
			if(this.var_get_target_0_0 == null)
				this.var_get_target_0_0 = this.builderType.GetMethod("get_Target", true);

			return this.var_get_target_0_0;
						
						
		}
				
		private Method var_clone_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Clone()<para/>
		/// </summary>
		public Method GetMethod_Clone()
		{
						
			if(this.var_clone_0_0 == null)
				this.var_clone_0_0 = this.builderType.GetMethod("Clone", true);

			return this.var_clone_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Exception"/>
    /// </summary>
    public partial class BuilderTypeException : TypeSystemExBase
	{
        internal BuilderTypeException(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeException value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeException value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_get_data_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.IDictionary get_Data()<para/>
		/// </summary>
		public Method GetMethod_get_Data()
		{
						
			if(this.var_get_data_0_0 == null)
				this.var_get_data_0_0 = this.builderType.GetMethod("get_Data", true);

			return this.var_get_data_0_0;
						
						
		}
				
		private Method var_get_message_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_Message()<para/>
		/// </summary>
		public Method GetMethod_get_Message()
		{
						
			if(this.var_get_message_0_0 == null)
				this.var_get_message_0_0 = this.builderType.GetMethod("get_Message", true);

			return this.var_get_message_0_0;
						
						
		}
				
		private Method var_getbaseexception_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Exception GetBaseException()<para/>
		/// </summary>
		public Method GetMethod_GetBaseException()
		{
						
			if(this.var_getbaseexception_0_0 == null)
				this.var_getbaseexception_0_0 = this.builderType.GetMethod("GetBaseException", true);

			return this.var_getbaseexception_0_0;
						
						
		}
				
		private Method var_get_innerexception_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Exception get_InnerException()<para/>
		/// </summary>
		public Method GetMethod_get_InnerException()
		{
						
			if(this.var_get_innerexception_0_0 == null)
				this.var_get_innerexception_0_0 = this.builderType.GetMethod("get_InnerException", true);

			return this.var_get_innerexception_0_0;
						
						
		}
				
		private Method var_get_targetsite_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBase get_TargetSite()<para/>
		/// </summary>
		public Method GetMethod_get_TargetSite()
		{
						
			if(this.var_get_targetsite_0_0 == null)
				this.var_get_targetsite_0_0 = this.builderType.GetMethod("get_TargetSite", true);

			return this.var_get_targetsite_0_0;
						
						
		}
				
		private Method var_get_stacktrace_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_StackTrace()<para/>
		/// </summary>
		public Method GetMethod_get_StackTrace()
		{
						
			if(this.var_get_stacktrace_0_0 == null)
				this.var_get_stacktrace_0_0 = this.builderType.GetMethod("get_StackTrace", true);

			return this.var_get_stacktrace_0_0;
						
						
		}
				
		private Method var_get_helplink_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_HelpLink()<para/>
		/// </summary>
		public Method GetMethod_get_HelpLink()
		{
						
			if(this.var_get_helplink_0_0 == null)
				this.var_get_helplink_0_0 = this.builderType.GetMethod("get_HelpLink", true);

			return this.var_get_helplink_0_0;
						
						
		}
				
		private Method var_set_helplink_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void set_HelpLink(System.String)<para/>
		/// </summary>
		public Method GetMethod_set_HelpLink(TypeReference pvalue)
		{
						
						
			if(this.var_set_helplink_0_1 == null)
				this.var_set_helplink_0_1 = this.builderType.GetMethod("set_HelpLink", true, pvalue).Import();
			
			return this.var_set_helplink_0_1;
						
		}
				
		private Method var_get_source_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_Source()<para/>
		/// </summary>
		public Method GetMethod_get_Source()
		{
						
			if(this.var_get_source_0_0 == null)
				this.var_get_source_0_0 = this.builderType.GetMethod("get_Source", true);

			return this.var_get_source_0_0;
						
						
		}
				
		private Method var_set_source_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void set_Source(System.String)<para/>
		/// </summary>
		public Method GetMethod_set_Source(TypeReference pvalue)
		{
						
						
			if(this.var_set_source_0_1 == null)
				this.var_set_source_0_1 = this.builderType.GetMethod("set_Source", true, pvalue).Import();
			
			return this.var_set_source_0_1;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_getobjectdata_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)<para/>
		/// </summary>
		public Method GetMethod_GetObjectData(TypeReference pinfo, TypeReference pcontext)
		{
						
						
			if(this.var_getobjectdata_0_2 == null)
				this.var_getobjectdata_0_2 = this.builderType.GetMethod("GetObjectData", true, pinfo, pcontext).Import();
			
			return this.var_getobjectdata_0_2;
						
		}
				
		private Method var_get_hresult_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_HResult()<para/>
		/// </summary>
		public Method GetMethod_get_HResult()
		{
						
			if(this.var_get_hresult_0_0 == null)
				this.var_get_hresult_0_0 = this.builderType.GetMethod("get_HResult", true);

			return this.var_get_hresult_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.ICollection{T}"/>
    /// </summary>
    public partial class BuilderTypeICollection1 : TypeSystemExBase
	{
        internal BuilderTypeICollection1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeICollection1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeICollection1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.IDictionary"/>
    /// </summary>
    public partial class BuilderTypeIDictionary : TypeSystemExBase
	{
        internal BuilderTypeIDictionary(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIDictionary value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIDictionary value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_get_item_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_Item(System.Object)<para/>
		/// </summary>
		public Method GetMethod_get_Item(TypeReference pkey)
		{
						
						
			if(this.var_get_item_0_1 == null)
				this.var_get_item_0_1 = this.builderType.GetMethod("get_Item", true, pkey).Import();
			
			return this.var_get_item_0_1;
						
		}
				
		private Method var_set_item_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void set_Item(System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_set_Item(TypeReference pkey, TypeReference pvalue)
		{
						
						
			if(this.var_set_item_0_2 == null)
				this.var_set_item_0_2 = this.builderType.GetMethod("set_Item", true, pkey, pvalue).Import();
			
			return this.var_set_item_0_2;
						
		}
				
		private Method var_get_keys_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.ICollection get_Keys()<para/>
		/// </summary>
		public Method GetMethod_get_Keys()
		{
						
			if(this.var_get_keys_0_0 == null)
				this.var_get_keys_0_0 = this.builderType.GetMethod("get_Keys", true);

			return this.var_get_keys_0_0;
						
						
		}
				
		private Method var_get_values_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.ICollection get_Values()<para/>
		/// </summary>
		public Method GetMethod_get_Values()
		{
						
			if(this.var_get_values_0_0 == null)
				this.var_get_values_0_0 = this.builderType.GetMethod("get_Values", true);

			return this.var_get_values_0_0;
						
						
		}
				
		private Method var_contains_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Contains(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Contains(TypeReference pkey)
		{
						
						
			if(this.var_contains_0_1 == null)
				this.var_contains_0_1 = this.builderType.GetMethod("Contains", true, pkey).Import();
			
			return this.var_contains_0_1;
						
		}
				
		private Method var_add_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Add(System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference pkey, TypeReference pvalue)
		{
						
						
			if(this.var_add_0_2 == null)
				this.var_add_0_2 = this.builderType.GetMethod("Add", true, pkey, pvalue).Import();
			
			return this.var_add_0_2;
						
		}
				
		private Method var_clear_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Clear()<para/>
		/// </summary>
		public Method GetMethod_Clear()
		{
						
			if(this.var_clear_0_0 == null)
				this.var_clear_0_0 = this.builderType.GetMethod("Clear", true);

			return this.var_clear_0_0;
						
						
		}
				
		private Method var_get_isreadonly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsReadOnly()<para/>
		/// </summary>
		public Method GetMethod_get_IsReadOnly()
		{
						
			if(this.var_get_isreadonly_0_0 == null)
				this.var_get_isreadonly_0_0 = this.builderType.GetMethod("get_IsReadOnly", true);

			return this.var_get_isreadonly_0_0;
						
						
		}
				
		private Method var_get_isfixedsize_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFixedSize()<para/>
		/// </summary>
		public Method GetMethod_get_IsFixedSize()
		{
						
			if(this.var_get_isfixedsize_0_0 == null)
				this.var_get_isfixedsize_0_0 = this.builderType.GetMethod("get_IsFixedSize", true);

			return this.var_get_isfixedsize_0_0;
						
						
		}
				
		private Method var_getenumerator_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.IDictionaryEnumerator GetEnumerator()<para/>
		/// </summary>
		public Method GetMethod_GetEnumerator()
		{
						
			if(this.var_getenumerator_0_0 == null)
				this.var_getenumerator_0_0 = this.builderType.GetMethod("GetEnumerator", true);

			return this.var_getenumerator_0_0;
						
						
		}
				
		private Method var_remove_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Remove(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Remove(TypeReference pkey)
		{
						
						
			if(this.var_remove_0_1 == null)
				this.var_remove_0_1 = this.builderType.GetMethod("Remove", true, pkey).Import();
			
			return this.var_remove_0_1;
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.IDictionary{TKey,TValue}"/>
    /// </summary>
    public partial class BuilderTypeIDictionary2 : TypeSystemExBase
	{
        internal BuilderTypeIDictionary2(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIDictionary2 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIDictionary2 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.IEnumerable"/>
    /// </summary>
    public partial class BuilderTypeIEnumerable : TypeSystemExBase
	{
        internal BuilderTypeIEnumerable(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIEnumerable value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIEnumerable value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_getenumerator_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.IEnumerator GetEnumerator()<para/>
		/// </summary>
		public Method GetMethod_GetEnumerator()
		{
						
			if(this.var_getenumerator_0_0 == null)
				this.var_getenumerator_0_0 = this.builderType.GetMethod("GetEnumerator", true);

			return this.var_getenumerator_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.IEnumerable{T}"/>
    /// </summary>
    public partial class BuilderTypeIEnumerable1 : TypeSystemExBase
	{
        internal BuilderTypeIEnumerable1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIEnumerable1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIEnumerable1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.IList"/>
    /// </summary>
    public partial class BuilderTypeIList : TypeSystemExBase
	{
        internal BuilderTypeIList(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIList value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIList value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_get_item_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_Item(Int32)<para/>
		/// </summary>
		public Method GetMethod_get_Item(TypeReference pindex)
		{
						
						
			if(this.var_get_item_0_1 == null)
				this.var_get_item_0_1 = this.builderType.GetMethod("get_Item", true, pindex).Import();
			
			return this.var_get_item_0_1;
						
		}
				
		private Method var_set_item_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void set_Item(Int32, System.Object)<para/>
		/// </summary>
		public Method GetMethod_set_Item(TypeReference pindex, TypeReference pvalue)
		{
						
						
			if(this.var_set_item_0_2 == null)
				this.var_set_item_0_2 = this.builderType.GetMethod("set_Item", true, pindex, pvalue).Import();
			
			return this.var_set_item_0_2;
						
		}
				
		private Method var_add_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Add(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference pvalue)
		{
						
						
			if(this.var_add_0_1 == null)
				this.var_add_0_1 = this.builderType.GetMethod("Add", true, pvalue).Import();
			
			return this.var_add_0_1;
						
		}
				
		private Method var_contains_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Contains(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Contains(TypeReference pvalue)
		{
						
						
			if(this.var_contains_0_1 == null)
				this.var_contains_0_1 = this.builderType.GetMethod("Contains", true, pvalue).Import();
			
			return this.var_contains_0_1;
						
		}
				
		private Method var_clear_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Clear()<para/>
		/// </summary>
		public Method GetMethod_Clear()
		{
						
			if(this.var_clear_0_0 == null)
				this.var_clear_0_0 = this.builderType.GetMethod("Clear", true);

			return this.var_clear_0_0;
						
						
		}
				
		private Method var_get_isreadonly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsReadOnly()<para/>
		/// </summary>
		public Method GetMethod_get_IsReadOnly()
		{
						
			if(this.var_get_isreadonly_0_0 == null)
				this.var_get_isreadonly_0_0 = this.builderType.GetMethod("get_IsReadOnly", true);

			return this.var_get_isreadonly_0_0;
						
						
		}
				
		private Method var_get_isfixedsize_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFixedSize()<para/>
		/// </summary>
		public Method GetMethod_get_IsFixedSize()
		{
						
			if(this.var_get_isfixedsize_0_0 == null)
				this.var_get_isfixedsize_0_0 = this.builderType.GetMethod("get_IsFixedSize", true);

			return this.var_get_isfixedsize_0_0;
						
						
		}
				
		private Method var_indexof_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(System.Object)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference pvalue)
		{
						
						
			if(this.var_indexof_0_1 == null)
				this.var_indexof_0_1 = this.builderType.GetMethod("IndexOf", true, pvalue).Import();
			
			return this.var_indexof_0_1;
						
		}
				
		private Method var_insert_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Insert(Int32, System.Object)<para/>
		/// </summary>
		public Method GetMethod_Insert(TypeReference pindex, TypeReference pvalue)
		{
						
						
			if(this.var_insert_0_2 == null)
				this.var_insert_0_2 = this.builderType.GetMethod("Insert", true, pindex, pvalue).Import();
			
			return this.var_insert_0_2;
						
		}
				
		private Method var_remove_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Remove(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Remove(TypeReference pvalue)
		{
						
						
			if(this.var_remove_0_1 == null)
				this.var_remove_0_1 = this.builderType.GetMethod("Remove", true, pvalue).Import();
			
			return this.var_remove_0_1;
						
		}
				
		private Method var_removeat_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void RemoveAt(Int32)<para/>
		/// </summary>
		public Method GetMethod_RemoveAt(TypeReference pindex)
		{
						
						
			if(this.var_removeat_0_1 == null)
				this.var_removeat_0_1 = this.builderType.GetMethod("RemoveAt", true, pindex).Import();
			
			return this.var_removeat_0_1;
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.IList{T}"/>
    /// </summary>
    public partial class BuilderTypeIList1 : TypeSystemExBase
	{
        internal BuilderTypeIList1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIList1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIList1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Int16"/>
    /// </summary>
    public partial class BuilderTypeInt16 : TypeSystemExBase
	{
        internal BuilderTypeInt16(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeInt16 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeInt16 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Int16)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Int16).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Int16)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Int16).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Int16 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int16 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Int32"/>
    /// </summary>
    public partial class BuilderTypeInt32 : TypeSystemExBase
	{
        internal BuilderTypeInt32(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeInt32 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeInt32 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Int32)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Int32)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Int32).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(typeof(System.String).AreEqual(pformat))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Int32 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Int64"/>
    /// </summary>
    public partial class BuilderTypeInt64 : TypeSystemExBase
	{
        internal BuilderTypeInt64(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeInt64 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeInt64 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Int64)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Int64)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Int64).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Int64 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.IntPtr"/>
    /// </summary>
    public partial class BuilderTypeIntPtr : TypeSystemExBase
	{
        internal BuilderTypeIntPtr(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeIntPtr value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeIntPtr value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_toint32_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 ToInt32()<para/>
		/// </summary>
		public Method GetMethod_ToInt32()
		{
						
			if(this.var_toint32_0_0 == null)
				this.var_toint32_0_0 = this.builderType.GetMethod("ToInt32", true);

			return this.var_toint32_0_0;
						
						
		}
				
		private Method var_toint64_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int64 ToInt64()<para/>
		/// </summary>
		public Method GetMethod_ToInt64()
		{
						
			if(this.var_toint64_0_0 == null)
				this.var_toint64_0_0 = this.builderType.GetMethod("ToInt64", true);

			return this.var_toint64_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat)
		{
						
						
			if(this.var_tostring_0_1 == null)
				this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pformat).Import();
			
			return this.var_tostring_0_1;
						
		}
				
		private Method var_op_explicit_0_1;
				
		private Method var_op_explicit_1_1;
				
		private Method var_op_explicit_2_1;
				
		private Method var_op_explicit_3_1;
				
		private Method var_op_explicit_4_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// IntPtr op_Explicit(Int32)<para/>
		/// IntPtr op_Explicit(Int64)<para/>
		/// Void* op_Explicit(IntPtr)<para/>
		/// Int32 op_Explicit(IntPtr)<para/>
		/// Int64 op_Explicit(IntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Explicit(TypeReference pvalue)
		{
						
						
			if(typeof(System.Int32).AreEqual(pvalue))
			{
				if(this.var_op_explicit_0_1 == null)
					this.var_op_explicit_0_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_0_1;
			}
			
			if(typeof(System.Int64).AreEqual(pvalue))
			{
				if(this.var_op_explicit_1_1 == null)
					this.var_op_explicit_1_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_1_1;
			}
			
			if(typeof(System.IntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_2_1 == null)
					this.var_op_explicit_2_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_2_1;
			}
			
			if(typeof(System.IntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_3_1 == null)
					this.var_op_explicit_3_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_3_1;
			}
			
			if(typeof(System.IntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_4_1 == null)
					this.var_op_explicit_4_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_4_1;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(IntPtr, IntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pvalue1, TypeReference pvalue2)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pvalue1, pvalue2).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(IntPtr, IntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pvalue1, TypeReference pvalue2)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pvalue1, pvalue2).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_add_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// IntPtr Add(IntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_add_0_2 == null)
				this.var_add_0_2 = this.builderType.GetMethod("Add", true, ppointer, poffset).Import();
			
			return this.var_add_0_2;
						
		}
				
		private Method var_op_addition_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// IntPtr op_Addition(IntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_op_Addition(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_op_addition_0_2 == null)
				this.var_op_addition_0_2 = this.builderType.GetMethod("op_Addition", true, ppointer, poffset).Import();
			
			return this.var_op_addition_0_2;
						
		}
				
		private Method var_subtract_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// IntPtr Subtract(IntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_Subtract(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_subtract_0_2 == null)
				this.var_subtract_0_2 = this.builderType.GetMethod("Subtract", true, ppointer, poffset).Import();
			
			return this.var_subtract_0_2;
						
		}
				
		private Method var_op_subtraction_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// IntPtr op_Subtraction(IntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_op_Subtraction(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_op_subtraction_0_2 == null)
				this.var_op_subtraction_0_2 = this.builderType.GetMethod("op_Subtraction", true, ppointer, poffset).Import();
			
			return this.var_op_subtraction_0_2;
						
		}
				
		private Method var_get_size_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Size()<para/>
		/// </summary>
		public Method GetMethod_get_Size()
		{
						
			if(this.var_get_size_0_0 == null)
				this.var_get_size_0_0 = this.builderType.GetMethod("get_Size", true);

			return this.var_get_size_0_0;
						
						
		}
				
		private Method var_topointer_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void* ToPointer()<para/>
		/// </summary>
		public Method GetMethod_ToPointer()
		{
						
			if(this.var_topointer_0_0 == null)
				this.var_topointer_0_0 = this.builderType.GetMethod("ToPointer", true);

			return this.var_topointer_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Collections.Generic.List{T}"/>
    /// </summary>
    public partial class BuilderTypeList1 : TypeSystemExBase
	{
        internal BuilderTypeList1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeList1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeList1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Reflection.MethodBase"/>
    /// </summary>
    public partial class BuilderTypeMethodBase : TypeSystemExBase
	{
        internal BuilderTypeMethodBase(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeMethodBase value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeMethodBase value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_getmethodfromhandle_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle)<para/>
		/// </summary>
		public Method GetMethod_GetMethodFromHandle(TypeReference phandle)
		{
						
						
			if(this.var_getmethodfromhandle_0_1 == null)
				this.var_getmethodfromhandle_0_1 = this.builderType.GetMethod("GetMethodFromHandle", true, phandle).Import();
			
			return this.var_getmethodfromhandle_0_1;
						
		}
				
		private Method var_getmethodfromhandle_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle, System.RuntimeTypeHandle)<para/>
		/// </summary>
		public Method GetMethod_GetMethodFromHandle(TypeReference phandle, TypeReference pdeclaringType)
		{
						
						
			if(this.var_getmethodfromhandle_0_2 == null)
				this.var_getmethodfromhandle_0_2 = this.builderType.GetMethod("GetMethodFromHandle", true, phandle, pdeclaringType).Import();
			
			return this.var_getmethodfromhandle_0_2;
						
		}
				
		private Method var_getcurrentmethod_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBase GetCurrentMethod()<para/>
		/// </summary>
		public Method GetMethod_GetCurrentMethod()
		{
						
			if(this.var_getcurrentmethod_0_0 == null)
				this.var_getcurrentmethod_0_0 = this.builderType.GetMethod("GetCurrentMethod", true);

			return this.var_getcurrentmethod_0_0;
						
						
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(System.Reflection.MethodBase, System.Reflection.MethodBase)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pleft, pright).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(System.Reflection.MethodBase, System.Reflection.MethodBase)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pleft, pright).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_getparameters_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ParameterInfo[] GetParameters()<para/>
		/// </summary>
		public Method GetMethod_GetParameters()
		{
						
			if(this.var_getparameters_0_0 == null)
				this.var_getparameters_0_0 = this.builderType.GetMethod("GetParameters", true);

			return this.var_getparameters_0_0;
						
						
		}
				
		private Method var_get_methodimplementationflags_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodImplAttributes get_MethodImplementationFlags()<para/>
		/// </summary>
		public Method GetMethod_get_MethodImplementationFlags()
		{
						
			if(this.var_get_methodimplementationflags_0_0 == null)
				this.var_get_methodimplementationflags_0_0 = this.builderType.GetMethod("get_MethodImplementationFlags", true);

			return this.var_get_methodimplementationflags_0_0;
						
						
		}
				
		private Method var_getmethodimplementationflags_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodImplAttributes GetMethodImplementationFlags()<para/>
		/// </summary>
		public Method GetMethod_GetMethodImplementationFlags()
		{
						
			if(this.var_getmethodimplementationflags_0_0 == null)
				this.var_getmethodimplementationflags_0_0 = this.builderType.GetMethod("GetMethodImplementationFlags", true);

			return this.var_getmethodimplementationflags_0_0;
						
						
		}
				
		private Method var_get_methodhandle_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.RuntimeMethodHandle get_MethodHandle()<para/>
		/// </summary>
		public Method GetMethod_get_MethodHandle()
		{
						
			if(this.var_get_methodhandle_0_0 == null)
				this.var_get_methodhandle_0_0 = this.builderType.GetMethod("get_MethodHandle", true);

			return this.var_get_methodhandle_0_0;
						
						
		}
				
		private Method var_get_attributes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodAttributes get_Attributes()<para/>
		/// </summary>
		public Method GetMethod_get_Attributes()
		{
						
			if(this.var_get_attributes_0_0 == null)
				this.var_get_attributes_0_0 = this.builderType.GetMethod("get_Attributes", true);

			return this.var_get_attributes_0_0;
						
						
		}
				
		private Method var_invoke_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_Invoke(TypeReference pobj, TypeReference pinvokeAttr, TypeReference pbinder, TypeReference pparameters, TypeReference pculture)
		{
						
						
			if(this.var_invoke_0_5 == null)
				this.var_invoke_0_5 = this.builderType.GetMethod("Invoke", true, pobj, pinvokeAttr, pbinder, pparameters, pculture).Import();
			
			return this.var_invoke_0_5;
						
		}
				
		private Method var_get_callingconvention_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.CallingConventions get_CallingConvention()<para/>
		/// </summary>
		public Method GetMethod_get_CallingConvention()
		{
						
			if(this.var_get_callingconvention_0_0 == null)
				this.var_get_callingconvention_0_0 = this.builderType.GetMethod("get_CallingConvention", true);

			return this.var_get_callingconvention_0_0;
						
						
		}
				
		private Method var_getgenericarguments_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetGenericArguments()<para/>
		/// </summary>
		public Method GetMethod_GetGenericArguments()
		{
						
			if(this.var_getgenericarguments_0_0 == null)
				this.var_getgenericarguments_0_0 = this.builderType.GetMethod("GetGenericArguments", true);

			return this.var_getgenericarguments_0_0;
						
						
		}
				
		private Method var_get_isgenericmethoddefinition_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsGenericMethodDefinition()<para/>
		/// </summary>
		public Method GetMethod_get_IsGenericMethodDefinition()
		{
						
			if(this.var_get_isgenericmethoddefinition_0_0 == null)
				this.var_get_isgenericmethoddefinition_0_0 = this.builderType.GetMethod("get_IsGenericMethodDefinition", true);

			return this.var_get_isgenericmethoddefinition_0_0;
						
						
		}
				
		private Method var_get_containsgenericparameters_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_ContainsGenericParameters()<para/>
		/// </summary>
		public Method GetMethod_get_ContainsGenericParameters()
		{
						
			if(this.var_get_containsgenericparameters_0_0 == null)
				this.var_get_containsgenericparameters_0_0 = this.builderType.GetMethod("get_ContainsGenericParameters", true);

			return this.var_get_containsgenericparameters_0_0;
						
						
		}
				
		private Method var_get_isgenericmethod_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsGenericMethod()<para/>
		/// </summary>
		public Method GetMethod_get_IsGenericMethod()
		{
						
			if(this.var_get_isgenericmethod_0_0 == null)
				this.var_get_isgenericmethod_0_0 = this.builderType.GetMethod("get_IsGenericMethod", true);

			return this.var_get_isgenericmethod_0_0;
						
						
		}
				
		private Method var_get_issecuritycritical_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecurityCritical()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecurityCritical()
		{
						
			if(this.var_get_issecuritycritical_0_0 == null)
				this.var_get_issecuritycritical_0_0 = this.builderType.GetMethod("get_IsSecurityCritical", true);

			return this.var_get_issecuritycritical_0_0;
						
						
		}
				
		private Method var_get_issecuritysafecritical_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecuritySafeCritical()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecuritySafeCritical()
		{
						
			if(this.var_get_issecuritysafecritical_0_0 == null)
				this.var_get_issecuritysafecritical_0_0 = this.builderType.GetMethod("get_IsSecuritySafeCritical", true);

			return this.var_get_issecuritysafecritical_0_0;
						
						
		}
				
		private Method var_get_issecuritytransparent_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecurityTransparent()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecurityTransparent()
		{
						
			if(this.var_get_issecuritytransparent_0_0 == null)
				this.var_get_issecuritytransparent_0_0 = this.builderType.GetMethod("get_IsSecurityTransparent", true);

			return this.var_get_issecuritytransparent_0_0;
						
						
		}
				
		private Method var_invoke_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Invoke(System.Object, System.Object[])<para/>
		/// </summary>
		public Method GetMethod_Invoke(TypeReference pobj, TypeReference pparameters)
		{
						
						
			if(this.var_invoke_0_2 == null)
				this.var_invoke_0_2 = this.builderType.GetMethod("Invoke", true, pobj, pparameters).Import();
			
			return this.var_invoke_0_2;
						
		}
				
		private Method var_get_ispublic_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsPublic()<para/>
		/// </summary>
		public Method GetMethod_get_IsPublic()
		{
						
			if(this.var_get_ispublic_0_0 == null)
				this.var_get_ispublic_0_0 = this.builderType.GetMethod("get_IsPublic", true);

			return this.var_get_ispublic_0_0;
						
						
		}
				
		private Method var_get_isprivate_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsPrivate()<para/>
		/// </summary>
		public Method GetMethod_get_IsPrivate()
		{
						
			if(this.var_get_isprivate_0_0 == null)
				this.var_get_isprivate_0_0 = this.builderType.GetMethod("get_IsPrivate", true);

			return this.var_get_isprivate_0_0;
						
						
		}
				
		private Method var_get_isfamily_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFamily()<para/>
		/// </summary>
		public Method GetMethod_get_IsFamily()
		{
						
			if(this.var_get_isfamily_0_0 == null)
				this.var_get_isfamily_0_0 = this.builderType.GetMethod("get_IsFamily", true);

			return this.var_get_isfamily_0_0;
						
						
		}
				
		private Method var_get_isassembly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAssembly()<para/>
		/// </summary>
		public Method GetMethod_get_IsAssembly()
		{
						
			if(this.var_get_isassembly_0_0 == null)
				this.var_get_isassembly_0_0 = this.builderType.GetMethod("get_IsAssembly", true);

			return this.var_get_isassembly_0_0;
						
						
		}
				
		private Method var_get_isfamilyandassembly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFamilyAndAssembly()<para/>
		/// </summary>
		public Method GetMethod_get_IsFamilyAndAssembly()
		{
						
			if(this.var_get_isfamilyandassembly_0_0 == null)
				this.var_get_isfamilyandassembly_0_0 = this.builderType.GetMethod("get_IsFamilyAndAssembly", true);

			return this.var_get_isfamilyandassembly_0_0;
						
						
		}
				
		private Method var_get_isfamilyorassembly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFamilyOrAssembly()<para/>
		/// </summary>
		public Method GetMethod_get_IsFamilyOrAssembly()
		{
						
			if(this.var_get_isfamilyorassembly_0_0 == null)
				this.var_get_isfamilyorassembly_0_0 = this.builderType.GetMethod("get_IsFamilyOrAssembly", true);

			return this.var_get_isfamilyorassembly_0_0;
						
						
		}
				
		private Method var_get_isstatic_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsStatic()<para/>
		/// </summary>
		public Method GetMethod_get_IsStatic()
		{
						
			if(this.var_get_isstatic_0_0 == null)
				this.var_get_isstatic_0_0 = this.builderType.GetMethod("get_IsStatic", true);

			return this.var_get_isstatic_0_0;
						
						
		}
				
		private Method var_get_isfinal_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFinal()<para/>
		/// </summary>
		public Method GetMethod_get_IsFinal()
		{
						
			if(this.var_get_isfinal_0_0 == null)
				this.var_get_isfinal_0_0 = this.builderType.GetMethod("get_IsFinal", true);

			return this.var_get_isfinal_0_0;
						
						
		}
				
		private Method var_get_isvirtual_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsVirtual()<para/>
		/// </summary>
		public Method GetMethod_get_IsVirtual()
		{
						
			if(this.var_get_isvirtual_0_0 == null)
				this.var_get_isvirtual_0_0 = this.builderType.GetMethod("get_IsVirtual", true);

			return this.var_get_isvirtual_0_0;
						
						
		}
				
		private Method var_get_ishidebysig_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsHideBySig()<para/>
		/// </summary>
		public Method GetMethod_get_IsHideBySig()
		{
						
			if(this.var_get_ishidebysig_0_0 == null)
				this.var_get_ishidebysig_0_0 = this.builderType.GetMethod("get_IsHideBySig", true);

			return this.var_get_ishidebysig_0_0;
						
						
		}
				
		private Method var_get_isabstract_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAbstract()<para/>
		/// </summary>
		public Method GetMethod_get_IsAbstract()
		{
						
			if(this.var_get_isabstract_0_0 == null)
				this.var_get_isabstract_0_0 = this.builderType.GetMethod("get_IsAbstract", true);

			return this.var_get_isabstract_0_0;
						
						
		}
				
		private Method var_get_isspecialname_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSpecialName()<para/>
		/// </summary>
		public Method GetMethod_get_IsSpecialName()
		{
						
			if(this.var_get_isspecialname_0_0 == null)
				this.var_get_isspecialname_0_0 = this.builderType.GetMethod("get_IsSpecialName", true);

			return this.var_get_isspecialname_0_0;
						
						
		}
				
		private Method var_get_isconstructor_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsConstructor()<para/>
		/// </summary>
		public Method GetMethod_get_IsConstructor()
		{
						
			if(this.var_get_isconstructor_0_0 == null)
				this.var_get_isconstructor_0_0 = this.builderType.GetMethod("get_IsConstructor", true);

			return this.var_get_isconstructor_0_0;
						
						
		}
				
		private Method var_getmethodbody_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBody GetMethodBody()<para/>
		/// </summary>
		public Method GetMethod_GetMethodBody()
		{
						
			if(this.var_getmethodbody_0_0 == null)
				this.var_getmethodbody_0_0 = this.builderType.GetMethod("GetMethodBody", true);

			return this.var_getmethodbody_0_0;
						
						
		}
				
		private Method var_get_membertype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberTypes get_MemberType()<para/>
		/// </summary>
		public Method GetMethod_get_MemberType()
		{
						
			if(this.var_get_membertype_0_0 == null)
				this.var_get_membertype_0_0 = this.builderType.GetMethod("get_MemberType", true);

			return this.var_get_membertype_0_0;
						
						
		}
				
		private Method var_get_name_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_Name()<para/>
		/// </summary>
		public Method GetMethod_get_Name()
		{
						
			if(this.var_get_name_0_0 == null)
				this.var_get_name_0_0 = this.builderType.GetMethod("get_Name", true);

			return this.var_get_name_0_0;
						
						
		}
				
		private Method var_get_declaringtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_DeclaringType()<para/>
		/// </summary>
		public Method GetMethod_get_DeclaringType()
		{
						
			if(this.var_get_declaringtype_0_0 == null)
				this.var_get_declaringtype_0_0 = this.builderType.GetMethod("get_DeclaringType", true);

			return this.var_get_declaringtype_0_0;
						
						
		}
				
		private Method var_get_reflectedtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_ReflectedType()<para/>
		/// </summary>
		public Method GetMethod_get_ReflectedType()
		{
						
			if(this.var_get_reflectedtype_0_0 == null)
				this.var_get_reflectedtype_0_0 = this.builderType.GetMethod("get_ReflectedType", true);

			return this.var_get_reflectedtype_0_0;
						
						
		}
				
		private Method var_get_customattributes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] get_CustomAttributes()<para/>
		/// </summary>
		public Method GetMethod_get_CustomAttributes()
		{
						
			if(this.var_get_customattributes_0_0 == null)
				this.var_get_customattributes_0_0 = this.builderType.GetMethod("get_CustomAttributes", true);

			return this.var_get_customattributes_0_0;
						
						
		}
				
		private Method var_getcustomattributes_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object[] GetCustomAttributes(Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributes(TypeReference pinherit)
		{
						
						
			if(this.var_getcustomattributes_0_1 == null)
				this.var_getcustomattributes_0_1 = this.builderType.GetMethod("GetCustomAttributes", true, pinherit).Import();
			
			return this.var_getcustomattributes_0_1;
						
		}
				
		private Method var_getcustomattributes_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributes(TypeReference pattributeType, TypeReference pinherit)
		{
						
						
			if(this.var_getcustomattributes_0_2 == null)
				this.var_getcustomattributes_0_2 = this.builderType.GetMethod("GetCustomAttributes", true, pattributeType, pinherit).Import();
			
			return this.var_getcustomattributes_0_2;
						
		}
				
		private Method var_isdefined_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDefined(System.Type, Boolean)<para/>
		/// </summary>
		public Method GetMethod_IsDefined(TypeReference pattributeType, TypeReference pinherit)
		{
						
						
			if(this.var_isdefined_0_2 == null)
				this.var_isdefined_0_2 = this.builderType.GetMethod("IsDefined", true, pattributeType, pinherit).Import();
			
			return this.var_isdefined_0_2;
						
		}
				
		private Method var_getcustomattributesdata_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributesData()
		{
						
			if(this.var_getcustomattributesdata_0_0 == null)
				this.var_getcustomattributesdata_0_0 = this.builderType.GetMethod("GetCustomAttributesData", true);

			return this.var_getcustomattributesdata_0_0;
						
						
		}
				
		private Method var_get_metadatatoken_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_MetadataToken()<para/>
		/// </summary>
		public Method GetMethod_get_MetadataToken()
		{
						
			if(this.var_get_metadatatoken_0_0 == null)
				this.var_get_metadatatoken_0_0 = this.builderType.GetMethod("get_MetadataToken", true);

			return this.var_get_metadatatoken_0_0;
						
						
		}
				
		private Method var_get_module_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.Module get_Module()<para/>
		/// </summary>
		public Method GetMethod_get_Module()
		{
						
			if(this.var_get_module_0_0 == null)
				this.var_get_module_0_0 = this.builderType.GetMethod("get_Module", true);

			return this.var_get_module_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Threading.Monitor"/>
    /// </summary>
    public partial class BuilderTypeMonitor : TypeSystemExBase
	{
        internal BuilderTypeMonitor(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeMonitor value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeMonitor value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_enter_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Enter(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Enter(TypeReference pobj)
		{
						
						
			if(this.var_enter_0_1 == null)
				this.var_enter_0_1 = this.builderType.GetMethod("Enter", true, pobj).Import();
			
			return this.var_enter_0_1;
						
		}
				
		private Method var_exit_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Exit(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Exit(TypeReference pobj)
		{
						
						
			if(this.var_exit_0_1 == null)
				this.var_exit_0_1 = this.builderType.GetMethod("Exit", true, pobj).Import();
			
			return this.var_exit_0_1;
						
		}
				
		private Method var_tryenter_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean TryEnter(System.Object)<para/>
		/// </summary>
		public Method GetMethod_TryEnter(TypeReference pobj)
		{
						
						
			if(this.var_tryenter_0_1 == null)
				this.var_tryenter_0_1 = this.builderType.GetMethod("TryEnter", true, pobj).Import();
			
			return this.var_tryenter_0_1;
						
		}
				
		private Method var_tryenter_0_2;
				
		private Method var_tryenter_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean TryEnter(System.Object, Int32)<para/>
		/// Boolean TryEnter(System.Object, System.TimeSpan)<para/>
		/// </summary>
		public Method GetMethod_TryEnter(TypeReference pobj, TypeReference pmillisecondsTimeout)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.Int32).AreEqual(pmillisecondsTimeout))
			{
				if(this.var_tryenter_0_2 == null)
					this.var_tryenter_0_2 = this.builderType.GetMethod("TryEnter", true, pobj, pmillisecondsTimeout).Import();
			
				return this.var_tryenter_0_2;
			}
			
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.TimeSpan).AreEqual(pmillisecondsTimeout))
			{
				if(this.var_tryenter_1_2 == null)
					this.var_tryenter_1_2 = this.builderType.GetMethod("TryEnter", true, pobj, pmillisecondsTimeout).Import();
			
				return this.var_tryenter_1_2;
			}
			
			return null;
			
		}
				
		private Method var_isentered_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsEntered(System.Object)<para/>
		/// </summary>
		public Method GetMethod_IsEntered(TypeReference pobj)
		{
						
						
			if(this.var_isentered_0_1 == null)
				this.var_isentered_0_1 = this.builderType.GetMethod("IsEntered", true, pobj).Import();
			
			return this.var_isentered_0_1;
						
		}
				
		private Method var_wait_0_3;
				
		private Method var_wait_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(System.Object, Int32, Boolean)<para/>
		/// Boolean Wait(System.Object, System.TimeSpan, Boolean)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference pobj, TypeReference pmillisecondsTimeout, TypeReference pexitContext)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.Int32).AreEqual(pmillisecondsTimeout) && typeof(System.Boolean).AreEqual(pexitContext))
			{
				if(this.var_wait_0_3 == null)
					this.var_wait_0_3 = this.builderType.GetMethod("Wait", true, pobj, pmillisecondsTimeout, pexitContext).Import();
			
				return this.var_wait_0_3;
			}
			
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.TimeSpan).AreEqual(pmillisecondsTimeout) && typeof(System.Boolean).AreEqual(pexitContext))
			{
				if(this.var_wait_1_3 == null)
					this.var_wait_1_3 = this.builderType.GetMethod("Wait", true, pobj, pmillisecondsTimeout, pexitContext).Import();
			
				return this.var_wait_1_3;
			}
			
			return null;
			
		}
				
		private Method var_wait_0_2;
				
		private Method var_wait_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(System.Object, Int32)<para/>
		/// Boolean Wait(System.Object, System.TimeSpan)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference pobj, TypeReference pmillisecondsTimeout)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.Int32).AreEqual(pmillisecondsTimeout))
			{
				if(this.var_wait_0_2 == null)
					this.var_wait_0_2 = this.builderType.GetMethod("Wait", true, pobj, pmillisecondsTimeout).Import();
			
				return this.var_wait_0_2;
			}
			
			if(typeof(System.Object).AreEqual(pobj) && typeof(System.TimeSpan).AreEqual(pmillisecondsTimeout))
			{
				if(this.var_wait_1_2 == null)
					this.var_wait_1_2 = this.builderType.GetMethod("Wait", true, pobj, pmillisecondsTimeout).Import();
			
				return this.var_wait_1_2;
			}
			
			return null;
			
		}
				
		private Method var_wait_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference pobj)
		{
						
						
			if(this.var_wait_0_1 == null)
				this.var_wait_0_1 = this.builderType.GetMethod("Wait", true, pobj).Import();
			
			return this.var_wait_0_1;
						
		}
				
		private Method var_pulse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Pulse(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Pulse(TypeReference pobj)
		{
						
						
			if(this.var_pulse_0_1 == null)
				this.var_pulse_0_1 = this.builderType.GetMethod("Pulse", true, pobj).Import();
			
			return this.var_pulse_0_1;
						
		}
				
		private Method var_pulseall_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void PulseAll(System.Object)<para/>
		/// </summary>
		public Method GetMethod_PulseAll(TypeReference pobj)
		{
						
						
			if(this.var_pulseall_0_1 == null)
				this.var_pulseall_0_1 = this.builderType.GetMethod("PulseAll", true, pobj).Import();
			
			return this.var_pulseall_0_1;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Nullable"/>
    /// </summary>
    public partial class BuilderTypeNullable : TypeSystemExBase
	{
        internal BuilderTypeNullable(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeNullable value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeNullable value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_getunderlyingtype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetUnderlyingType(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetUnderlyingType(TypeReference pnullableType)
		{
						
						
			if(this.var_getunderlyingtype_0_1 == null)
				this.var_getunderlyingtype_0_1 = this.builderType.GetMethod("GetUnderlyingType", true, pnullableType).Import();
			
			return this.var_getunderlyingtype_0_1;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Nullable{T}"/>
    /// </summary>
    public partial class BuilderTypeNullable1 : TypeSystemExBase
	{
        internal BuilderTypeNullable1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeNullable1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeNullable1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Object"/>
    /// </summary>
    public partial class BuilderTypeObject : TypeSystemExBase
	{
        internal BuilderTypeObject(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeObject value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeObject value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_equals_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobjA, TypeReference pobjB)
		{
						
						
			if(this.var_equals_0_2 == null)
				this.var_equals_0_2 = this.builderType.GetMethod("Equals", true, pobjA, pobjB).Import();
			
			return this.var_equals_0_2;
						
		}
				
		private Method var_referenceequals_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean ReferenceEquals(System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_ReferenceEquals(TypeReference pobjA, TypeReference pobjB)
		{
						
						
			if(this.var_referenceequals_0_2 == null)
				this.var_referenceequals_0_2 = this.builderType.GetMethod("ReferenceEquals", true, pobjA, pobjB).Import();
			
			return this.var_referenceequals_0_2;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.SByte"/>
    /// </summary>
    public partial class BuilderTypeSByte : TypeSystemExBase
	{
        internal BuilderTypeSByte(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeSByte value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeSByte value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(SByte)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pobj).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pobj))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pobj).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(SByte)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.SByte).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// SByte Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// SByte Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Single"/>
    /// </summary>
    public partial class BuilderTypeSingle : TypeSystemExBase
	{
        internal BuilderTypeSingle(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeSingle value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeSingle value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_isinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsInfinity(Single)<para/>
		/// </summary>
		public Method GetMethod_IsInfinity(TypeReference pf)
		{
						
						
			if(this.var_isinfinity_0_1 == null)
				this.var_isinfinity_0_1 = this.builderType.GetMethod("IsInfinity", true, pf).Import();
			
			return this.var_isinfinity_0_1;
						
		}
				
		private Method var_ispositiveinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsPositiveInfinity(Single)<para/>
		/// </summary>
		public Method GetMethod_IsPositiveInfinity(TypeReference pf)
		{
						
						
			if(this.var_ispositiveinfinity_0_1 == null)
				this.var_ispositiveinfinity_0_1 = this.builderType.GetMethod("IsPositiveInfinity", true, pf).Import();
			
			return this.var_ispositiveinfinity_0_1;
						
		}
				
		private Method var_isnegativeinfinity_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNegativeInfinity(Single)<para/>
		/// </summary>
		public Method GetMethod_IsNegativeInfinity(TypeReference pf)
		{
						
						
			if(this.var_isnegativeinfinity_0_1 == null)
				this.var_isnegativeinfinity_0_1 = this.builderType.GetMethod("IsNegativeInfinity", true, pf).Import();
			
			return this.var_isnegativeinfinity_0_1;
						
		}
				
		private Method var_isnan_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNaN(Single)<para/>
		/// </summary>
		public Method GetMethod_IsNaN(TypeReference pf)
		{
						
						
			if(this.var_isnan_0_1 == null)
				this.var_isnan_0_1 = this.builderType.GetMethod("IsNaN", true, pf).Import();
			
			return this.var_isnan_0_1;
						
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(Single)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.Single).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pleft, pright).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pleft, pright).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_op_lessthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThan(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_LessThan(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_lessthan_0_2 == null)
				this.var_op_lessthan_0_2 = this.builderType.GetMethod("op_LessThan", true, pleft, pright).Import();
			
			return this.var_op_lessthan_0_2;
						
		}
				
		private Method var_op_greaterthan_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThan(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThan(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_greaterthan_0_2 == null)
				this.var_op_greaterthan_0_2 = this.builderType.GetMethod("op_GreaterThan", true, pleft, pright).Import();
			
			return this.var_op_greaterthan_0_2;
						
		}
				
		private Method var_op_lessthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_LessThanOrEqual(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_LessThanOrEqual(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_lessthanorequal_0_2 == null)
				this.var_op_lessthanorequal_0_2 = this.builderType.GetMethod("op_LessThanOrEqual", true, pleft, pright).Import();
			
			return this.var_op_lessthanorequal_0_2;
						
		}
				
		private Method var_op_greaterthanorequal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_GreaterThanOrEqual(Single, Single)<para/>
		/// </summary>
		public Method GetMethod_op_GreaterThanOrEqual(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_greaterthanorequal_0_2 == null)
				this.var_op_greaterthanorequal_0_2 = this.builderType.GetMethod("op_GreaterThanOrEqual", true, pleft, pright).Import();
			
			return this.var_op_greaterthanorequal_0_2;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(Single)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Single).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// Single Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Single Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.String"/>
    /// </summary>
    public partial class BuilderTypeString : TypeSystemExBase
	{
        internal BuilderTypeString(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeString value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeString value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_get_length_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Length()<para/>
		/// </summary>
		public Method GetMethod_get_Length()
		{
						
			if(this.var_get_length_0_0 == null)
				this.var_get_length_0_0 = this.builderType.GetMethod("get_Length", true);

			return this.var_get_length_0_0;
						
						
		}
				
		private Method var_get_chars_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char get_Chars(Int32)<para/>
		/// </summary>
		public Method GetMethod_get_Chars(TypeReference pindex)
		{
						
						
			if(this.var_get_chars_0_1 == null)
				this.var_get_chars_0_1 = this.builderType.GetMethod("get_Chars", true, pindex).Import();
			
			return this.var_get_chars_0_1;
						
		}
				
		private Method var_join_0_2;
				
		private Method var_join_1_2;
				
		private Method var_join_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Join(System.String, System.String[])<para/>
		/// System.String Join(System.String, System.Object[])<para/>
		/// System.String Join(System.String, System.Collections.Generic.IEnumerable`1[System.String])<para/>
		/// </summary>
		public Method GetMethod_Join(TypeReference pseparator, TypeReference pvalue)
		{
						
						
			if(typeof(System.String).AreEqual(pseparator) && typeof(System.String[]).AreEqual(pvalue))
			{
				if(this.var_join_0_2 == null)
					this.var_join_0_2 = this.builderType.GetMethod("Join", true, pseparator, pvalue).Import();
			
				return this.var_join_0_2;
			}
			
			if(typeof(System.String).AreEqual(pseparator) && typeof(System.Object[]).AreEqual(pvalue))
			{
				if(this.var_join_1_2 == null)
					this.var_join_1_2 = this.builderType.GetMethod("Join", true, pseparator, pvalue).Import();
			
				return this.var_join_1_2;
			}
			
			if(typeof(System.String).AreEqual(pseparator) && typeof(System.Collections.Generic.IEnumerable<>).AreEqual(pvalue))
			{
				if(this.var_join_2_2 == null)
					this.var_join_2_2 = this.builderType.GetMethod("Join", true, pseparator, pvalue).Import();
			
				return this.var_join_2_2;
			}
			
			return null;
			
		}
				
		private Method var_join_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Join(System.String, System.String[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Join(TypeReference pseparator, TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_join_0_4 == null)
				this.var_join_0_4 = this.builderType.GetMethod("Join", true, pseparator, pvalue, pstartIndex, pcount).Import();
			
			return this.var_join_0_4;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(System.String)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.String).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_2;
				
		private Method var_equals_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.String, System.StringComparison)<para/>
		/// Boolean Equals(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pvalue, TypeReference pcomparisonType)
		{
						
						
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.StringComparison).AreEqual(pcomparisonType))
			{
				if(this.var_equals_0_2 == null)
					this.var_equals_0_2 = this.builderType.GetMethod("Equals", true, pvalue, pcomparisonType).Import();
			
				return this.var_equals_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.String).AreEqual(pcomparisonType))
			{
				if(this.var_equals_1_2 == null)
					this.var_equals_1_2 = this.builderType.GetMethod("Equals", true, pvalue, pcomparisonType).Import();
			
				return this.var_equals_1_2;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.String, System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pa, TypeReference pb, TypeReference pcomparisonType)
		{
						
						
			if(this.var_equals_0_3 == null)
				this.var_equals_0_3 = this.builderType.GetMethod("Equals", true, pa, pb, pcomparisonType).Import();
			
			return this.var_equals_0_3;
						
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pa, TypeReference pb)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pa, pb).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pa, TypeReference pb)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pa, pb).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_copyto_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void CopyTo(Int32, Char[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_CopyTo(TypeReference psourceIndex, TypeReference pdestination, TypeReference pdestinationIndex, TypeReference pcount)
		{
						
						
			if(this.var_copyto_0_4 == null)
				this.var_copyto_0_4 = this.builderType.GetMethod("CopyTo", true, psourceIndex, pdestination, pdestinationIndex, pcount).Import();
			
			return this.var_copyto_0_4;
						
		}
				
		private Method var_tochararray_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char[] ToCharArray()<para/>
		/// </summary>
		public Method GetMethod_ToCharArray()
		{
						
			if(this.var_tochararray_0_0 == null)
				this.var_tochararray_0_0 = this.builderType.GetMethod("ToCharArray", true);

			return this.var_tochararray_0_0;
						
						
		}
				
		private Method var_tochararray_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Char[] ToCharArray(Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_ToCharArray(TypeReference pstartIndex, TypeReference plength)
		{
						
						
			if(this.var_tochararray_0_2 == null)
				this.var_tochararray_0_2 = this.builderType.GetMethod("ToCharArray", true, pstartIndex, plength).Import();
			
			return this.var_tochararray_0_2;
						
		}
				
		private Method var_isnullorempty_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNullOrEmpty(System.String)<para/>
		/// </summary>
		public Method GetMethod_IsNullOrEmpty(TypeReference pvalue)
		{
						
						
			if(this.var_isnullorempty_0_1 == null)
				this.var_isnullorempty_0_1 = this.builderType.GetMethod("IsNullOrEmpty", true, pvalue).Import();
			
			return this.var_isnullorempty_0_1;
						
		}
				
		private Method var_isnullorwhitespace_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNullOrWhiteSpace(System.String)<para/>
		/// </summary>
		public Method GetMethod_IsNullOrWhiteSpace(TypeReference pvalue)
		{
						
						
			if(this.var_isnullorwhitespace_0_1 == null)
				this.var_isnullorwhitespace_0_1 = this.builderType.GetMethod("IsNullOrWhiteSpace", true, pvalue).Import();
			
			return this.var_isnullorwhitespace_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_split_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] Split(Char[])<para/>
		/// </summary>
		public Method GetMethod_Split(TypeReference pseparator)
		{
						
						
			if(this.var_split_0_1 == null)
				this.var_split_0_1 = this.builderType.GetMethod("Split", true, pseparator).Import();
			
			return this.var_split_0_1;
						
		}
				
		private Method var_split_0_2;
				
		private Method var_split_1_2;
				
		private Method var_split_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] Split(Char[], Int32)<para/>
		/// System.String[] Split(Char[], System.StringSplitOptions)<para/>
		/// System.String[] Split(System.String[], System.StringSplitOptions)<para/>
		/// </summary>
		public Method GetMethod_Split(TypeReference pseparator, TypeReference pcount)
		{
						
						
			if(typeof(System.Char[]).AreEqual(pseparator) && typeof(System.Int32).AreEqual(pcount))
			{
				if(this.var_split_0_2 == null)
					this.var_split_0_2 = this.builderType.GetMethod("Split", true, pseparator, pcount).Import();
			
				return this.var_split_0_2;
			}
			
			if(typeof(System.Char[]).AreEqual(pseparator) && typeof(System.StringSplitOptions).AreEqual(pcount))
			{
				if(this.var_split_1_2 == null)
					this.var_split_1_2 = this.builderType.GetMethod("Split", true, pseparator, pcount).Import();
			
				return this.var_split_1_2;
			}
			
			if(typeof(System.String[]).AreEqual(pseparator) && typeof(System.StringSplitOptions).AreEqual(pcount))
			{
				if(this.var_split_2_2 == null)
					this.var_split_2_2 = this.builderType.GetMethod("Split", true, pseparator, pcount).Import();
			
				return this.var_split_2_2;
			}
			
			return null;
			
		}
				
		private Method var_split_0_3;
				
		private Method var_split_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] Split(Char[], Int32, System.StringSplitOptions)<para/>
		/// System.String[] Split(System.String[], Int32, System.StringSplitOptions)<para/>
		/// </summary>
		public Method GetMethod_Split(TypeReference pseparator, TypeReference pcount, TypeReference poptions)
		{
						
						
			if(typeof(System.Char[]).AreEqual(pseparator) && typeof(System.Int32).AreEqual(pcount) && typeof(System.StringSplitOptions).AreEqual(poptions))
			{
				if(this.var_split_0_3 == null)
					this.var_split_0_3 = this.builderType.GetMethod("Split", true, pseparator, pcount, poptions).Import();
			
				return this.var_split_0_3;
			}
			
			if(typeof(System.String[]).AreEqual(pseparator) && typeof(System.Int32).AreEqual(pcount) && typeof(System.StringSplitOptions).AreEqual(poptions))
			{
				if(this.var_split_1_3 == null)
					this.var_split_1_3 = this.builderType.GetMethod("Split", true, pseparator, pcount, poptions).Import();
			
				return this.var_split_1_3;
			}
			
			return null;
			
		}
				
		private Method var_substring_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Substring(Int32)<para/>
		/// </summary>
		public Method GetMethod_Substring(TypeReference pstartIndex)
		{
						
						
			if(this.var_substring_0_1 == null)
				this.var_substring_0_1 = this.builderType.GetMethod("Substring", true, pstartIndex).Import();
			
			return this.var_substring_0_1;
						
		}
				
		private Method var_substring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Substring(Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Substring(TypeReference pstartIndex, TypeReference plength)
		{
						
						
			if(this.var_substring_0_2 == null)
				this.var_substring_0_2 = this.builderType.GetMethod("Substring", true, pstartIndex, plength).Import();
			
			return this.var_substring_0_2;
						
		}
				
		private Method var_trim_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Trim(Char[])<para/>
		/// </summary>
		public Method GetMethod_Trim(TypeReference ptrimChars)
		{
						
						
			if(this.var_trim_0_1 == null)
				this.var_trim_0_1 = this.builderType.GetMethod("Trim", true, ptrimChars).Import();
			
			return this.var_trim_0_1;
						
		}
				
		private Method var_trimstart_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String TrimStart(Char[])<para/>
		/// </summary>
		public Method GetMethod_TrimStart(TypeReference ptrimChars)
		{
						
						
			if(this.var_trimstart_0_1 == null)
				this.var_trimstart_0_1 = this.builderType.GetMethod("TrimStart", true, ptrimChars).Import();
			
			return this.var_trimstart_0_1;
						
		}
				
		private Method var_trimend_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String TrimEnd(Char[])<para/>
		/// </summary>
		public Method GetMethod_TrimEnd(TypeReference ptrimChars)
		{
						
						
			if(this.var_trimend_0_1 == null)
				this.var_trimend_0_1 = this.builderType.GetMethod("TrimEnd", true, ptrimChars).Import();
			
			return this.var_trimend_0_1;
						
		}
				
		private Method var_isnormalized_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNormalized()<para/>
		/// </summary>
		public Method GetMethod_IsNormalized()
		{
						
			if(this.var_isnormalized_0_0 == null)
				this.var_isnormalized_0_0 = this.builderType.GetMethod("IsNormalized", true);

			return this.var_isnormalized_0_0;
						
						
		}
				
		private Method var_isnormalized_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsNormalized(System.Text.NormalizationForm)<para/>
		/// </summary>
		public Method GetMethod_IsNormalized(TypeReference pnormalizationForm)
		{
						
						
			if(this.var_isnormalized_0_1 == null)
				this.var_isnormalized_0_1 = this.builderType.GetMethod("IsNormalized", true, pnormalizationForm).Import();
			
			return this.var_isnormalized_0_1;
						
		}
				
		private Method var_normalize_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Normalize()<para/>
		/// </summary>
		public Method GetMethod_Normalize()
		{
						
			if(this.var_normalize_0_0 == null)
				this.var_normalize_0_0 = this.builderType.GetMethod("Normalize", true);

			return this.var_normalize_0_0;
						
						
		}
				
		private Method var_normalize_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Normalize(System.Text.NormalizationForm)<para/>
		/// </summary>
		public Method GetMethod_Normalize(TypeReference pnormalizationForm)
		{
						
						
			if(this.var_normalize_0_1 == null)
				this.var_normalize_0_1 = this.builderType.GetMethod("Normalize", true, pnormalizationForm).Import();
			
			return this.var_normalize_0_1;
						
		}
				
		private Method var_compare_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pstrB)
		{
						
						
			if(this.var_compare_0_2 == null)
				this.var_compare_0_2 = this.builderType.GetMethod("Compare", true, pstrA, pstrB).Import();
			
			return this.var_compare_0_2;
						
		}
				
		private Method var_compare_0_3;
				
		private Method var_compare_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, System.String, Boolean)<para/>
		/// Int32 Compare(System.String, System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pstrB, TypeReference pignoreCase)
		{
						
						
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Boolean).AreEqual(pignoreCase))
			{
				if(this.var_compare_0_3 == null)
					this.var_compare_0_3 = this.builderType.GetMethod("Compare", true, pstrA, pstrB, pignoreCase).Import();
			
				return this.var_compare_0_3;
			}
			
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.String).AreEqual(pstrB) && typeof(System.StringComparison).AreEqual(pignoreCase))
			{
				if(this.var_compare_1_3 == null)
					this.var_compare_1_3 = this.builderType.GetMethod("Compare", true, pstrA, pstrB, pignoreCase).Import();
			
				return this.var_compare_1_3;
			}
			
			return null;
			
		}
				
		private Method var_compare_0_4;
				
		private Method var_compare_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)<para/>
		/// Int32 Compare(System.String, System.String, Boolean, System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pstrB, TypeReference pculture, TypeReference poptions)
		{
						
						
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Globalization.CultureInfo).AreEqual(pculture) && typeof(System.Globalization.CompareOptions).AreEqual(poptions))
			{
				if(this.var_compare_0_4 == null)
					this.var_compare_0_4 = this.builderType.GetMethod("Compare", true, pstrA, pstrB, pculture, poptions).Import();
			
				return this.var_compare_0_4;
			}
			
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Boolean).AreEqual(pculture) && typeof(System.Globalization.CultureInfo).AreEqual(poptions))
			{
				if(this.var_compare_1_4 == null)
					this.var_compare_1_4 = this.builderType.GetMethod("Compare", true, pstrA, pstrB, pculture, poptions).Import();
			
				return this.var_compare_1_4;
			}
			
			return null;
			
		}
				
		private Method var_compare_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pindexA, TypeReference pstrB, TypeReference pindexB, TypeReference plength)
		{
						
						
			if(this.var_compare_0_5 == null)
				this.var_compare_0_5 = this.builderType.GetMethod("Compare", true, pstrA, pindexA, pstrB, pindexB, plength).Import();
			
			return this.var_compare_0_5;
						
		}
				
		private Method var_compare_0_6;
				
		private Method var_compare_1_6;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean)<para/>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pindexA, TypeReference pstrB, TypeReference pindexB, TypeReference plength, TypeReference pignoreCase)
		{
						
						
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.Int32).AreEqual(pindexA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Int32).AreEqual(pindexB) && typeof(System.Int32).AreEqual(plength) && typeof(System.Boolean).AreEqual(pignoreCase))
			{
				if(this.var_compare_0_6 == null)
					this.var_compare_0_6 = this.builderType.GetMethod("Compare", true, pstrA, pindexA, pstrB, pindexB, plength, pignoreCase).Import();
			
				return this.var_compare_0_6;
			}
			
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.Int32).AreEqual(pindexA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Int32).AreEqual(pindexB) && typeof(System.Int32).AreEqual(plength) && typeof(System.StringComparison).AreEqual(pignoreCase))
			{
				if(this.var_compare_1_6 == null)
					this.var_compare_1_6 = this.builderType.GetMethod("Compare", true, pstrA, pindexA, pstrB, pindexB, plength, pignoreCase).Import();
			
				return this.var_compare_1_6;
			}
			
			return null;
			
		}
				
		private Method var_compare_0_7;
				
		private Method var_compare_1_7;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean, System.Globalization.CultureInfo)<para/>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.Globalization.CultureInfo, System.Globalization.CompareOptions)<para/>
		/// </summary>
		public Method GetMethod_Compare(TypeReference pstrA, TypeReference pindexA, TypeReference pstrB, TypeReference pindexB, TypeReference plength, TypeReference pignoreCase, TypeReference pculture)
		{
						
						
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.Int32).AreEqual(pindexA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Int32).AreEqual(pindexB) && typeof(System.Int32).AreEqual(plength) && typeof(System.Boolean).AreEqual(pignoreCase) && typeof(System.Globalization.CultureInfo).AreEqual(pculture))
			{
				if(this.var_compare_0_7 == null)
					this.var_compare_0_7 = this.builderType.GetMethod("Compare", true, pstrA, pindexA, pstrB, pindexB, plength, pignoreCase, pculture).Import();
			
				return this.var_compare_0_7;
			}
			
			if(typeof(System.String).AreEqual(pstrA) && typeof(System.Int32).AreEqual(pindexA) && typeof(System.String).AreEqual(pstrB) && typeof(System.Int32).AreEqual(pindexB) && typeof(System.Int32).AreEqual(plength) && typeof(System.Globalization.CultureInfo).AreEqual(pignoreCase) && typeof(System.Globalization.CompareOptions).AreEqual(pculture))
			{
				if(this.var_compare_1_7 == null)
					this.var_compare_1_7 = this.builderType.GetMethod("Compare", true, pstrA, pindexA, pstrB, pindexB, plength, pignoreCase, pculture).Import();
			
				return this.var_compare_1_7;
			}
			
			return null;
			
		}
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(System.String)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_compareordinal_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareOrdinal(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_CompareOrdinal(TypeReference pstrA, TypeReference pstrB)
		{
						
						
			if(this.var_compareordinal_0_2 == null)
				this.var_compareordinal_0_2 = this.builderType.GetMethod("CompareOrdinal", true, pstrA, pstrB).Import();
			
			return this.var_compareordinal_0_2;
						
		}
				
		private Method var_compareordinal_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareOrdinal(System.String, Int32, System.String, Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_CompareOrdinal(TypeReference pstrA, TypeReference pindexA, TypeReference pstrB, TypeReference pindexB, TypeReference plength)
		{
						
						
			if(this.var_compareordinal_0_5 == null)
				this.var_compareordinal_0_5 = this.builderType.GetMethod("CompareOrdinal", true, pstrA, pindexA, pstrB, pindexB, plength).Import();
			
			return this.var_compareordinal_0_5;
						
		}
				
		private Method var_contains_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Contains(System.String)<para/>
		/// </summary>
		public Method GetMethod_Contains(TypeReference pvalue)
		{
						
						
			if(this.var_contains_0_1 == null)
				this.var_contains_0_1 = this.builderType.GetMethod("Contains", true, pvalue).Import();
			
			return this.var_contains_0_1;
						
		}
				
		private Method var_endswith_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean EndsWith(System.String)<para/>
		/// </summary>
		public Method GetMethod_EndsWith(TypeReference pvalue)
		{
						
						
			if(this.var_endswith_0_1 == null)
				this.var_endswith_0_1 = this.builderType.GetMethod("EndsWith", true, pvalue).Import();
			
			return this.var_endswith_0_1;
						
		}
				
		private Method var_endswith_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean EndsWith(System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_EndsWith(TypeReference pvalue, TypeReference pcomparisonType)
		{
						
						
			if(this.var_endswith_0_2 == null)
				this.var_endswith_0_2 = this.builderType.GetMethod("EndsWith", true, pvalue, pcomparisonType).Import();
			
			return this.var_endswith_0_2;
						
		}
				
		private Method var_endswith_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean EndsWith(System.String, Boolean, System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_EndsWith(TypeReference pvalue, TypeReference pignoreCase, TypeReference pculture)
		{
						
						
			if(this.var_endswith_0_3 == null)
				this.var_endswith_0_3 = this.builderType.GetMethod("EndsWith", true, pvalue, pignoreCase, pculture).Import();
			
			return this.var_endswith_0_3;
						
		}
				
		private Method var_indexof_0_1;
				
		private Method var_indexof_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(Char)<para/>
		/// Int32 IndexOf(System.String)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference pvalue)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_indexof_0_1 == null)
					this.var_indexof_0_1 = this.builderType.GetMethod("IndexOf", true, pvalue).Import();
			
				return this.var_indexof_0_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_indexof_1_1 == null)
					this.var_indexof_1_1 = this.builderType.GetMethod("IndexOf", true, pvalue).Import();
			
				return this.var_indexof_1_1;
			}
			
			return null;
			
		}
				
		private Method var_indexof_0_2;
				
		private Method var_indexof_1_2;
				
		private Method var_indexof_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(Char, Int32)<para/>
		/// Int32 IndexOf(System.String, Int32)<para/>
		/// Int32 IndexOf(System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference pvalue, TypeReference pstartIndex)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex))
			{
				if(this.var_indexof_0_2 == null)
					this.var_indexof_0_2 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_indexof_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex))
			{
				if(this.var_indexof_1_2 == null)
					this.var_indexof_1_2 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_indexof_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.StringComparison).AreEqual(pstartIndex))
			{
				if(this.var_indexof_2_2 == null)
					this.var_indexof_2_2 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_indexof_2_2;
			}
			
			return null;
			
		}
				
		private Method var_indexof_0_3;
				
		private Method var_indexof_1_3;
				
		private Method var_indexof_2_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(Char, Int32, Int32)<para/>
		/// Int32 IndexOf(System.String, Int32, Int32)<para/>
		/// Int32 IndexOf(System.String, Int32, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.Int32).AreEqual(pcount))
			{
				if(this.var_indexof_0_3 == null)
					this.var_indexof_0_3 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_indexof_0_3;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.Int32).AreEqual(pcount))
			{
				if(this.var_indexof_1_3 == null)
					this.var_indexof_1_3 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_indexof_1_3;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.StringComparison).AreEqual(pcount))
			{
				if(this.var_indexof_2_3 == null)
					this.var_indexof_2_3 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_indexof_2_3;
			}
			
			return null;
			
		}
				
		private Method var_indexofany_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOfAny(Char[])<para/>
		/// </summary>
		public Method GetMethod_IndexOfAny(TypeReference panyOf)
		{
						
						
			if(this.var_indexofany_0_1 == null)
				this.var_indexofany_0_1 = this.builderType.GetMethod("IndexOfAny", true, panyOf).Import();
			
			return this.var_indexofany_0_1;
						
		}
				
		private Method var_indexofany_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOfAny(Char[], Int32)<para/>
		/// </summary>
		public Method GetMethod_IndexOfAny(TypeReference panyOf, TypeReference pstartIndex)
		{
						
						
			if(this.var_indexofany_0_2 == null)
				this.var_indexofany_0_2 = this.builderType.GetMethod("IndexOfAny", true, panyOf, pstartIndex).Import();
			
			return this.var_indexofany_0_2;
						
		}
				
		private Method var_indexofany_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOfAny(Char[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_IndexOfAny(TypeReference panyOf, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_indexofany_0_3 == null)
				this.var_indexofany_0_3 = this.builderType.GetMethod("IndexOfAny", true, panyOf, pstartIndex, pcount).Import();
			
			return this.var_indexofany_0_3;
						
		}
				
		private Method var_indexof_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 IndexOf(System.String, Int32, Int32, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_IndexOf(TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount, TypeReference pcomparisonType)
		{
						
						
			if(this.var_indexof_0_4 == null)
				this.var_indexof_0_4 = this.builderType.GetMethod("IndexOf", true, pvalue, pstartIndex, pcount, pcomparisonType).Import();
			
			return this.var_indexof_0_4;
						
		}
				
		private Method var_lastindexof_0_1;
				
		private Method var_lastindexof_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(Char)<para/>
		/// Int32 LastIndexOf(System.String)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference pvalue)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue))
			{
				if(this.var_lastindexof_0_1 == null)
					this.var_lastindexof_0_1 = this.builderType.GetMethod("LastIndexOf", true, pvalue).Import();
			
				return this.var_lastindexof_0_1;
			}
			
			if(typeof(System.String).AreEqual(pvalue))
			{
				if(this.var_lastindexof_1_1 == null)
					this.var_lastindexof_1_1 = this.builderType.GetMethod("LastIndexOf", true, pvalue).Import();
			
				return this.var_lastindexof_1_1;
			}
			
			return null;
			
		}
				
		private Method var_lastindexof_0_2;
				
		private Method var_lastindexof_1_2;
				
		private Method var_lastindexof_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(Char, Int32)<para/>
		/// Int32 LastIndexOf(System.String, Int32)<para/>
		/// Int32 LastIndexOf(System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference pvalue, TypeReference pstartIndex)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex))
			{
				if(this.var_lastindexof_0_2 == null)
					this.var_lastindexof_0_2 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_lastindexof_0_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex))
			{
				if(this.var_lastindexof_1_2 == null)
					this.var_lastindexof_1_2 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_lastindexof_1_2;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.StringComparison).AreEqual(pstartIndex))
			{
				if(this.var_lastindexof_2_2 == null)
					this.var_lastindexof_2_2 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex).Import();
			
				return this.var_lastindexof_2_2;
			}
			
			return null;
			
		}
				
		private Method var_lastindexof_0_3;
				
		private Method var_lastindexof_1_3;
				
		private Method var_lastindexof_2_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(Char, Int32, Int32)<para/>
		/// Int32 LastIndexOf(System.String, Int32, Int32)<para/>
		/// Int32 LastIndexOf(System.String, Int32, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(typeof(System.Char).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.Int32).AreEqual(pcount))
			{
				if(this.var_lastindexof_0_3 == null)
					this.var_lastindexof_0_3 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_lastindexof_0_3;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.Int32).AreEqual(pcount))
			{
				if(this.var_lastindexof_1_3 == null)
					this.var_lastindexof_1_3 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_lastindexof_1_3;
			}
			
			if(typeof(System.String).AreEqual(pvalue) && typeof(System.Int32).AreEqual(pstartIndex) && typeof(System.StringComparison).AreEqual(pcount))
			{
				if(this.var_lastindexof_2_3 == null)
					this.var_lastindexof_2_3 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex, pcount).Import();
			
				return this.var_lastindexof_2_3;
			}
			
			return null;
			
		}
				
		private Method var_lastindexofany_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOfAny(Char[])<para/>
		/// </summary>
		public Method GetMethod_LastIndexOfAny(TypeReference panyOf)
		{
						
						
			if(this.var_lastindexofany_0_1 == null)
				this.var_lastindexofany_0_1 = this.builderType.GetMethod("LastIndexOfAny", true, panyOf).Import();
			
			return this.var_lastindexofany_0_1;
						
		}
				
		private Method var_lastindexofany_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOfAny(Char[], Int32)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOfAny(TypeReference panyOf, TypeReference pstartIndex)
		{
						
						
			if(this.var_lastindexofany_0_2 == null)
				this.var_lastindexofany_0_2 = this.builderType.GetMethod("LastIndexOfAny", true, panyOf, pstartIndex).Import();
			
			return this.var_lastindexofany_0_2;
						
		}
				
		private Method var_lastindexofany_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOfAny(Char[], Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOfAny(TypeReference panyOf, TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_lastindexofany_0_3 == null)
				this.var_lastindexofany_0_3 = this.builderType.GetMethod("LastIndexOfAny", true, panyOf, pstartIndex, pcount).Import();
			
			return this.var_lastindexofany_0_3;
						
		}
				
		private Method var_lastindexof_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 LastIndexOf(System.String, Int32, Int32, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_LastIndexOf(TypeReference pvalue, TypeReference pstartIndex, TypeReference pcount, TypeReference pcomparisonType)
		{
						
						
			if(this.var_lastindexof_0_4 == null)
				this.var_lastindexof_0_4 = this.builderType.GetMethod("LastIndexOf", true, pvalue, pstartIndex, pcount, pcomparisonType).Import();
			
			return this.var_lastindexof_0_4;
						
		}
				
		private Method var_padleft_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String PadLeft(Int32)<para/>
		/// </summary>
		public Method GetMethod_PadLeft(TypeReference ptotalWidth)
		{
						
						
			if(this.var_padleft_0_1 == null)
				this.var_padleft_0_1 = this.builderType.GetMethod("PadLeft", true, ptotalWidth).Import();
			
			return this.var_padleft_0_1;
						
		}
				
		private Method var_padleft_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String PadLeft(Int32, Char)<para/>
		/// </summary>
		public Method GetMethod_PadLeft(TypeReference ptotalWidth, TypeReference ppaddingChar)
		{
						
						
			if(this.var_padleft_0_2 == null)
				this.var_padleft_0_2 = this.builderType.GetMethod("PadLeft", true, ptotalWidth, ppaddingChar).Import();
			
			return this.var_padleft_0_2;
						
		}
				
		private Method var_padright_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String PadRight(Int32)<para/>
		/// </summary>
		public Method GetMethod_PadRight(TypeReference ptotalWidth)
		{
						
						
			if(this.var_padright_0_1 == null)
				this.var_padright_0_1 = this.builderType.GetMethod("PadRight", true, ptotalWidth).Import();
			
			return this.var_padright_0_1;
						
		}
				
		private Method var_padright_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String PadRight(Int32, Char)<para/>
		/// </summary>
		public Method GetMethod_PadRight(TypeReference ptotalWidth, TypeReference ppaddingChar)
		{
						
						
			if(this.var_padright_0_2 == null)
				this.var_padright_0_2 = this.builderType.GetMethod("PadRight", true, ptotalWidth, ppaddingChar).Import();
			
			return this.var_padright_0_2;
						
		}
				
		private Method var_startswith_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean StartsWith(System.String)<para/>
		/// </summary>
		public Method GetMethod_StartsWith(TypeReference pvalue)
		{
						
						
			if(this.var_startswith_0_1 == null)
				this.var_startswith_0_1 = this.builderType.GetMethod("StartsWith", true, pvalue).Import();
			
			return this.var_startswith_0_1;
						
		}
				
		private Method var_startswith_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean StartsWith(System.String, System.StringComparison)<para/>
		/// </summary>
		public Method GetMethod_StartsWith(TypeReference pvalue, TypeReference pcomparisonType)
		{
						
						
			if(this.var_startswith_0_2 == null)
				this.var_startswith_0_2 = this.builderType.GetMethod("StartsWith", true, pvalue, pcomparisonType).Import();
			
			return this.var_startswith_0_2;
						
		}
				
		private Method var_startswith_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean StartsWith(System.String, Boolean, System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_StartsWith(TypeReference pvalue, TypeReference pignoreCase, TypeReference pculture)
		{
						
						
			if(this.var_startswith_0_3 == null)
				this.var_startswith_0_3 = this.builderType.GetMethod("StartsWith", true, pvalue, pignoreCase, pculture).Import();
			
			return this.var_startswith_0_3;
						
		}
				
		private Method var_tolower_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToLower()<para/>
		/// </summary>
		public Method GetMethod_ToLower()
		{
						
			if(this.var_tolower_0_0 == null)
				this.var_tolower_0_0 = this.builderType.GetMethod("ToLower", true);

			return this.var_tolower_0_0;
						
						
		}
				
		private Method var_tolower_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToLower(System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_ToLower(TypeReference pculture)
		{
						
						
			if(this.var_tolower_0_1 == null)
				this.var_tolower_0_1 = this.builderType.GetMethod("ToLower", true, pculture).Import();
			
			return this.var_tolower_0_1;
						
		}
				
		private Method var_tolowerinvariant_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToLowerInvariant()<para/>
		/// </summary>
		public Method GetMethod_ToLowerInvariant()
		{
						
			if(this.var_tolowerinvariant_0_0 == null)
				this.var_tolowerinvariant_0_0 = this.builderType.GetMethod("ToLowerInvariant", true);

			return this.var_tolowerinvariant_0_0;
						
						
		}
				
		private Method var_toupper_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToUpper()<para/>
		/// </summary>
		public Method GetMethod_ToUpper()
		{
						
			if(this.var_toupper_0_0 == null)
				this.var_toupper_0_0 = this.builderType.GetMethod("ToUpper", true);

			return this.var_toupper_0_0;
						
						
		}
				
		private Method var_toupper_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToUpper(System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_ToUpper(TypeReference pculture)
		{
						
						
			if(this.var_toupper_0_1 == null)
				this.var_toupper_0_1 = this.builderType.GetMethod("ToUpper", true, pculture).Import();
			
			return this.var_toupper_0_1;
						
		}
				
		private Method var_toupperinvariant_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToUpperInvariant()<para/>
		/// </summary>
		public Method GetMethod_ToUpperInvariant()
		{
						
			if(this.var_toupperinvariant_0_0 == null)
				this.var_toupperinvariant_0_0 = this.builderType.GetMethod("ToUpperInvariant", true);

			return this.var_toupperinvariant_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_1 == null)
				this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
			return this.var_tostring_0_1;
						
		}
				
		private Method var_clone_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object Clone()<para/>
		/// </summary>
		public Method GetMethod_Clone()
		{
						
			if(this.var_clone_0_0 == null)
				this.var_clone_0_0 = this.builderType.GetMethod("Clone", true);

			return this.var_clone_0_0;
						
						
		}
				
		private Method var_trim_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Trim()<para/>
		/// </summary>
		public Method GetMethod_Trim()
		{
						
			if(this.var_trim_0_0 == null)
				this.var_trim_0_0 = this.builderType.GetMethod("Trim", true);

			return this.var_trim_0_0;
						
						
		}
				
		private Method var_insert_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Insert(Int32, System.String)<para/>
		/// </summary>
		public Method GetMethod_Insert(TypeReference pstartIndex, TypeReference pvalue)
		{
						
						
			if(this.var_insert_0_2 == null)
				this.var_insert_0_2 = this.builderType.GetMethod("Insert", true, pstartIndex, pvalue).Import();
			
			return this.var_insert_0_2;
						
		}
				
		private Method var_replace_0_2;
				
		private Method var_replace_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Replace(Char, Char)<para/>
		/// System.String Replace(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Replace(TypeReference poldChar, TypeReference pnewChar)
		{
						
						
			if(typeof(System.Char).AreEqual(poldChar) && typeof(System.Char).AreEqual(pnewChar))
			{
				if(this.var_replace_0_2 == null)
					this.var_replace_0_2 = this.builderType.GetMethod("Replace", true, poldChar, pnewChar).Import();
			
				return this.var_replace_0_2;
			}
			
			if(typeof(System.String).AreEqual(poldChar) && typeof(System.String).AreEqual(pnewChar))
			{
				if(this.var_replace_1_2 == null)
					this.var_replace_1_2 = this.builderType.GetMethod("Replace", true, poldChar, pnewChar).Import();
			
				return this.var_replace_1_2;
			}
			
			return null;
			
		}
				
		private Method var_remove_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Remove(Int32, Int32)<para/>
		/// </summary>
		public Method GetMethod_Remove(TypeReference pstartIndex, TypeReference pcount)
		{
						
						
			if(this.var_remove_0_2 == null)
				this.var_remove_0_2 = this.builderType.GetMethod("Remove", true, pstartIndex, pcount).Import();
			
			return this.var_remove_0_2;
						
		}
				
		private Method var_remove_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Remove(Int32)<para/>
		/// </summary>
		public Method GetMethod_Remove(TypeReference pstartIndex)
		{
						
						
			if(this.var_remove_0_1 == null)
				this.var_remove_0_1 = this.builderType.GetMethod("Remove", true, pstartIndex).Import();
			
			return this.var_remove_0_1;
						
		}
				
		private Method var_format_0_2;
				
		private Method var_format_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Format(System.String, System.Object)<para/>
		/// System.String Format(System.String, System.Object[])<para/>
		/// </summary>
		public Method GetMethod_Format(TypeReference pformat, TypeReference parg0)
		{
						
						
			if(typeof(System.String).AreEqual(pformat) && typeof(System.Object).AreEqual(parg0))
			{
				if(this.var_format_0_2 == null)
					this.var_format_0_2 = this.builderType.GetMethod("Format", true, pformat, parg0).Import();
			
				return this.var_format_0_2;
			}
			
			if(typeof(System.String).AreEqual(pformat) && typeof(System.Object[]).AreEqual(parg0))
			{
				if(this.var_format_1_2 == null)
					this.var_format_1_2 = this.builderType.GetMethod("Format", true, pformat, parg0).Import();
			
				return this.var_format_1_2;
			}
			
			return null;
			
		}
				
		private Method var_format_0_3;
				
		private Method var_format_1_3;
				
		private Method var_format_2_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Format(System.String, System.Object, System.Object)<para/>
		/// System.String Format(System.IFormatProvider, System.String, System.Object)<para/>
		/// System.String Format(System.IFormatProvider, System.String, System.Object[])<para/>
		/// </summary>
		public Method GetMethod_Format(TypeReference pformat, TypeReference parg0, TypeReference parg1)
		{
						
						
			if(typeof(System.String).AreEqual(pformat) && typeof(System.Object).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1))
			{
				if(this.var_format_0_3 == null)
					this.var_format_0_3 = this.builderType.GetMethod("Format", true, pformat, parg0, parg1).Import();
			
				return this.var_format_0_3;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat) && typeof(System.String).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1))
			{
				if(this.var_format_1_3 == null)
					this.var_format_1_3 = this.builderType.GetMethod("Format", true, pformat, parg0, parg1).Import();
			
				return this.var_format_1_3;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat) && typeof(System.String).AreEqual(parg0) && typeof(System.Object[]).AreEqual(parg1))
			{
				if(this.var_format_2_3 == null)
					this.var_format_2_3 = this.builderType.GetMethod("Format", true, pformat, parg0, parg1).Import();
			
				return this.var_format_2_3;
			}
			
			return null;
			
		}
				
		private Method var_format_0_4;
				
		private Method var_format_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Format(System.String, System.Object, System.Object, System.Object)<para/>
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_Format(TypeReference pformat, TypeReference parg0, TypeReference parg1, TypeReference parg2)
		{
						
						
			if(typeof(System.String).AreEqual(pformat) && typeof(System.Object).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1) && typeof(System.Object).AreEqual(parg2))
			{
				if(this.var_format_0_4 == null)
					this.var_format_0_4 = this.builderType.GetMethod("Format", true, pformat, parg0, parg1, parg2).Import();
			
				return this.var_format_0_4;
			}
			
			if(typeof(System.IFormatProvider).AreEqual(pformat) && typeof(System.String).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1) && typeof(System.Object).AreEqual(parg2))
			{
				if(this.var_format_1_4 == null)
					this.var_format_1_4 = this.builderType.GetMethod("Format", true, pformat, parg0, parg1, parg2).Import();
			
				return this.var_format_1_4;
			}
			
			return null;
			
		}
				
		private Method var_format_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)<para/>
		/// </summary>
		public Method GetMethod_Format(TypeReference pprovider, TypeReference pformat, TypeReference parg0, TypeReference parg1, TypeReference parg2)
		{
						
						
			if(this.var_format_0_5 == null)
				this.var_format_0_5 = this.builderType.GetMethod("Format", true, pprovider, pformat, parg0, parg1, parg2).Import();
			
			return this.var_format_0_5;
						
		}
				
		private Method var_copy_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Copy(System.String)<para/>
		/// </summary>
		public Method GetMethod_Copy(TypeReference pstr)
		{
						
						
			if(this.var_copy_0_1 == null)
				this.var_copy_0_1 = this.builderType.GetMethod("Copy", true, pstr).Import();
			
			return this.var_copy_0_1;
						
		}
				
		private Method var_concat_0_1;
				
		private Method var_concat_1_1;
				
		private Method var_concat_2_1;
				
		private Method var_concat_3_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Concat(System.Object)<para/>
		/// System.String Concat(System.Object[])<para/>
		/// System.String Concat(System.Collections.Generic.IEnumerable`1[System.String])<para/>
		/// System.String Concat(System.String[])<para/>
		/// </summary>
		public Method GetMethod_Concat(TypeReference parg0)
		{
						
						
			if(typeof(System.Object).AreEqual(parg0))
			{
				if(this.var_concat_0_1 == null)
					this.var_concat_0_1 = this.builderType.GetMethod("Concat", true, parg0).Import();
			
				return this.var_concat_0_1;
			}
			
			if(typeof(System.Object[]).AreEqual(parg0))
			{
				if(this.var_concat_1_1 == null)
					this.var_concat_1_1 = this.builderType.GetMethod("Concat", true, parg0).Import();
			
				return this.var_concat_1_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(parg0))
			{
				if(this.var_concat_2_1 == null)
					this.var_concat_2_1 = this.builderType.GetMethod("Concat", true, parg0).Import();
			
				return this.var_concat_2_1;
			}
			
			if(typeof(System.String[]).AreEqual(parg0))
			{
				if(this.var_concat_3_1 == null)
					this.var_concat_3_1 = this.builderType.GetMethod("Concat", true, parg0).Import();
			
				return this.var_concat_3_1;
			}
			
			return null;
			
		}
				
		private Method var_concat_0_2;
				
		private Method var_concat_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Concat(System.Object, System.Object)<para/>
		/// System.String Concat(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Concat(TypeReference parg0, TypeReference parg1)
		{
						
						
			if(typeof(System.Object).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1))
			{
				if(this.var_concat_0_2 == null)
					this.var_concat_0_2 = this.builderType.GetMethod("Concat", true, parg0, parg1).Import();
			
				return this.var_concat_0_2;
			}
			
			if(typeof(System.String).AreEqual(parg0) && typeof(System.String).AreEqual(parg1))
			{
				if(this.var_concat_1_2 == null)
					this.var_concat_1_2 = this.builderType.GetMethod("Concat", true, parg0, parg1).Import();
			
				return this.var_concat_1_2;
			}
			
			return null;
			
		}
				
		private Method var_concat_0_3;
				
		private Method var_concat_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Concat(System.Object, System.Object, System.Object)<para/>
		/// System.String Concat(System.String, System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Concat(TypeReference parg0, TypeReference parg1, TypeReference parg2)
		{
						
						
			if(typeof(System.Object).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1) && typeof(System.Object).AreEqual(parg2))
			{
				if(this.var_concat_0_3 == null)
					this.var_concat_0_3 = this.builderType.GetMethod("Concat", true, parg0, parg1, parg2).Import();
			
				return this.var_concat_0_3;
			}
			
			if(typeof(System.String).AreEqual(parg0) && typeof(System.String).AreEqual(parg1) && typeof(System.String).AreEqual(parg2))
			{
				if(this.var_concat_1_3 == null)
					this.var_concat_1_3 = this.builderType.GetMethod("Concat", true, parg0, parg1, parg2).Import();
			
				return this.var_concat_1_3;
			}
			
			return null;
			
		}
				
		private Method var_concat_0_4;
				
		private Method var_concat_1_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Concat(System.Object, System.Object, System.Object, System.Object, ...)<para/>
		/// System.String Concat(System.String, System.String, System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_Concat(TypeReference parg0, TypeReference parg1, TypeReference parg2, TypeReference parg3)
		{
						
						
			if(typeof(System.Object).AreEqual(parg0) && typeof(System.Object).AreEqual(parg1) && typeof(System.Object).AreEqual(parg2) && typeof(System.Object).AreEqual(parg3))
			{
				if(this.var_concat_0_4 == null)
					this.var_concat_0_4 = this.builderType.GetMethod("Concat", true, parg0, parg1, parg2, parg3).Import();
			
				return this.var_concat_0_4;
			}
			
			if(typeof(System.String).AreEqual(parg0) && typeof(System.String).AreEqual(parg1) && typeof(System.String).AreEqual(parg2) && typeof(System.String).AreEqual(parg3))
			{
				if(this.var_concat_1_4 == null)
					this.var_concat_1_4 = this.builderType.GetMethod("Concat", true, parg0, parg1, parg2, parg3).Import();
			
				return this.var_concat_1_4;
			}
			
			return null;
			
		}
				
		private Method var_intern_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String Intern(System.String)<para/>
		/// </summary>
		public Method GetMethod_Intern(TypeReference pstr)
		{
						
						
			if(this.var_intern_0_1 == null)
				this.var_intern_0_1 = this.builderType.GetMethod("Intern", true, pstr).Import();
			
			return this.var_intern_0_1;
						
		}
				
		private Method var_isinterned_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String IsInterned(System.String)<para/>
		/// </summary>
		public Method GetMethod_IsInterned(TypeReference pstr)
		{
						
						
			if(this.var_isinterned_0_1 == null)
				this.var_isinterned_0_1 = this.builderType.GetMethod("IsInterned", true, pstr).Import();
			
			return this.var_isinterned_0_1;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_getenumerator_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.CharEnumerator GetEnumerator()<para/>
		/// </summary>
		public Method GetMethod_GetEnumerator()
		{
						
			if(this.var_getenumerator_0_0 == null)
				this.var_getenumerator_0_0 = this.builderType.GetMethod("GetEnumerator", true);

			return this.var_getenumerator_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Threading.Tasks.Task"/>
    /// </summary>
    public partial class BuilderTypeTask : TypeSystemExBase
	{
        internal BuilderTypeTask(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeTask value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeTask value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_start_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Start()<para/>
		/// </summary>
		public Method GetMethod_Start()
		{
						
			if(this.var_start_0_0 == null)
				this.var_start_0_0 = this.builderType.GetMethod("Start", true);

			return this.var_start_0_0;
						
						
		}
				
		private Method var_start_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Start(System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_Start(TypeReference pscheduler)
		{
						
						
			if(this.var_start_0_1 == null)
				this.var_start_0_1 = this.builderType.GetMethod("Start", true, pscheduler).Import();
			
			return this.var_start_0_1;
						
		}
				
		private Method var_runsynchronously_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void RunSynchronously()<para/>
		/// </summary>
		public Method GetMethod_RunSynchronously()
		{
						
			if(this.var_runsynchronously_0_0 == null)
				this.var_runsynchronously_0_0 = this.builderType.GetMethod("RunSynchronously", true);

			return this.var_runsynchronously_0_0;
						
						
		}
				
		private Method var_runsynchronously_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void RunSynchronously(System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_RunSynchronously(TypeReference pscheduler)
		{
						
						
			if(this.var_runsynchronously_0_1 == null)
				this.var_runsynchronously_0_1 = this.builderType.GetMethod("RunSynchronously", true, pscheduler).Import();
			
			return this.var_runsynchronously_0_1;
						
		}
				
		private Method var_get_id_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Id()<para/>
		/// </summary>
		public Method GetMethod_get_Id()
		{
						
			if(this.var_get_id_0_0 == null)
				this.var_get_id_0_0 = this.builderType.GetMethod("get_Id", true);

			return this.var_get_id_0_0;
						
						
		}
				
		private Method var_get_currentid_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Nullable`1[System.Int32] get_CurrentId()<para/>
		/// </summary>
		public Method GetMethod_get_CurrentId()
		{
						
			if(this.var_get_currentid_0_0 == null)
				this.var_get_currentid_0_0 = this.builderType.GetMethod("get_CurrentId", true);

			return this.var_get_currentid_0_0;
						
						
		}
				
		private Method var_get_exception_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.AggregateException get_Exception()<para/>
		/// </summary>
		public Method GetMethod_get_Exception()
		{
						
			if(this.var_get_exception_0_0 == null)
				this.var_get_exception_0_0 = this.builderType.GetMethod("get_Exception", true);

			return this.var_get_exception_0_0;
						
						
		}
				
		private Method var_get_status_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.TaskStatus get_Status()<para/>
		/// </summary>
		public Method GetMethod_get_Status()
		{
						
			if(this.var_get_status_0_0 == null)
				this.var_get_status_0_0 = this.builderType.GetMethod("get_Status", true);

			return this.var_get_status_0_0;
						
						
		}
				
		private Method var_get_iscanceled_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsCanceled()<para/>
		/// </summary>
		public Method GetMethod_get_IsCanceled()
		{
						
			if(this.var_get_iscanceled_0_0 == null)
				this.var_get_iscanceled_0_0 = this.builderType.GetMethod("get_IsCanceled", true);

			return this.var_get_iscanceled_0_0;
						
						
		}
				
		private Method var_get_iscompleted_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsCompleted()<para/>
		/// </summary>
		public Method GetMethod_get_IsCompleted()
		{
						
			if(this.var_get_iscompleted_0_0 == null)
				this.var_get_iscompleted_0_0 = this.builderType.GetMethod("get_IsCompleted", true);

			return this.var_get_iscompleted_0_0;
						
						
		}
				
		private Method var_get_creationoptions_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.TaskCreationOptions get_CreationOptions()<para/>
		/// </summary>
		public Method GetMethod_get_CreationOptions()
		{
						
			if(this.var_get_creationoptions_0_0 == null)
				this.var_get_creationoptions_0_0 = this.builderType.GetMethod("get_CreationOptions", true);

			return this.var_get_creationoptions_0_0;
						
						
		}
				
		private Method var_get_asyncstate_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_AsyncState()<para/>
		/// </summary>
		public Method GetMethod_get_AsyncState()
		{
						
			if(this.var_get_asyncstate_0_0 == null)
				this.var_get_asyncstate_0_0 = this.builderType.GetMethod("get_AsyncState", true);

			return this.var_get_asyncstate_0_0;
						
						
		}
				
		private Method var_get_factory_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.TaskFactory get_Factory()<para/>
		/// </summary>
		public Method GetMethod_get_Factory()
		{
						
			if(this.var_get_factory_0_0 == null)
				this.var_get_factory_0_0 = this.builderType.GetMethod("get_Factory", true);

			return this.var_get_factory_0_0;
						
						
		}
				
		private Method var_get_completedtask_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task get_CompletedTask()<para/>
		/// </summary>
		public Method GetMethod_get_CompletedTask()
		{
						
			if(this.var_get_completedtask_0_0 == null)
				this.var_get_completedtask_0_0 = this.builderType.GetMethod("get_CompletedTask", true);

			return this.var_get_completedtask_0_0;
						
						
		}
				
		private Method var_get_isfaulted_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFaulted()<para/>
		/// </summary>
		public Method GetMethod_get_IsFaulted()
		{
						
			if(this.var_get_isfaulted_0_0 == null)
				this.var_get_isfaulted_0_0 = this.builderType.GetMethod("get_IsFaulted", true);

			return this.var_get_isfaulted_0_0;
						
						
		}
				
		private Method var_dispose_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Dispose()<para/>
		/// </summary>
		public Method GetMethod_Dispose()
		{
						
			if(this.var_dispose_0_0 == null)
				this.var_dispose_0_0 = this.builderType.GetMethod("Dispose", true);

			return this.var_dispose_0_0;
						
						
		}
				
		private Method var_getawaiter_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()<para/>
		/// </summary>
		public Method GetMethod_GetAwaiter()
		{
						
			if(this.var_getawaiter_0_0 == null)
				this.var_getawaiter_0_0 = this.builderType.GetMethod("GetAwaiter", true);

			return this.var_getawaiter_0_0;
						
						
		}
				
		private Method var_configureawait_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(Boolean)<para/>
		/// </summary>
		public Method GetMethod_ConfigureAwait(TypeReference pcontinueOnCapturedContext)
		{
						
						
			if(this.var_configureawait_0_1 == null)
				this.var_configureawait_0_1 = this.builderType.GetMethod("ConfigureAwait", true, pcontinueOnCapturedContext).Import();
			
			return this.var_configureawait_0_1;
						
		}
				
		private Method var_yield_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.CompilerServices.YieldAwaitable Yield()<para/>
		/// </summary>
		public Method GetMethod_Yield()
		{
						
			if(this.var_yield_0_0 == null)
				this.var_yield_0_0 = this.builderType.GetMethod("Yield", true);

			return this.var_yield_0_0;
						
						
		}
				
		private Method var_wait_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Wait()<para/>
		/// </summary>
		public Method GetMethod_Wait()
		{
						
			if(this.var_wait_0_0 == null)
				this.var_wait_0_0 = this.builderType.GetMethod("Wait", true);

			return this.var_wait_0_0;
						
						
		}
				
		private Method var_wait_0_1;
				
		private Method var_wait_1_1;
				
		private Method var_wait_2_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(System.TimeSpan)<para/>
		/// Void Wait(System.Threading.CancellationToken)<para/>
		/// Boolean Wait(Int32)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference ptimeout)
		{
						
						
			if(typeof(System.TimeSpan).AreEqual(ptimeout))
			{
				if(this.var_wait_0_1 == null)
					this.var_wait_0_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_0_1;
			}
			
			if(typeof(System.Threading.CancellationToken).AreEqual(ptimeout))
			{
				if(this.var_wait_1_1 == null)
					this.var_wait_1_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_1_1;
			}
			
			if(typeof(System.Int32).AreEqual(ptimeout))
			{
				if(this.var_wait_2_1 == null)
					this.var_wait_2_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_2_1;
			}
			
			return null;
			
		}
				
		private Method var_wait_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(Int32, System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference pmillisecondsTimeout, TypeReference pcancellationToken)
		{
						
						
			if(this.var_wait_0_2 == null)
				this.var_wait_0_2 = this.builderType.GetMethod("Wait", true, pmillisecondsTimeout, pcancellationToken).Import();
			
			return this.var_wait_0_2;
						
		}
				
		private Method var_continuewith_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction)
		{
						
						
			if(this.var_continuewith_0_1 == null)
				this.var_continuewith_0_1 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction).Import();
			
			return this.var_continuewith_0_1;
						
		}
				
		private Method var_continuewith_0_2;
				
		private Method var_continuewith_1_2;
				
		private Method var_continuewith_2_2;
				
		private Method var_continuewith_3_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_0_2 == null)
					this.var_continuewith_0_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_0_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.Tasks.TaskScheduler).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_1_2 == null)
					this.var_continuewith_1_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_1_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.Tasks.TaskContinuationOptions).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_2_2 == null)
					this.var_continuewith_2_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_2_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_3_2 == null)
					this.var_continuewith_3_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_3_2;
			}
			
			return null;
			
		}
				
		private Method var_continuewith_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pcancellationToken, TypeReference pcontinuationOptions, TypeReference pscheduler)
		{
						
						
			if(this.var_continuewith_0_4 == null)
				this.var_continuewith_0_4 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken, pcontinuationOptions, pscheduler).Import();
			
			return this.var_continuewith_0_4;
						
		}
				
		private Method var_continuewith_0_3;
				
		private Method var_continuewith_1_3;
				
		private Method var_continuewith_2_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pstate, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_0_3 == null)
					this.var_continuewith_0_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_0_3;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.Tasks.TaskScheduler).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_1_3 == null)
					this.var_continuewith_1_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_1_3;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.Tasks.TaskContinuationOptions).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_2_3 == null)
					this.var_continuewith_2_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_2_3;
			}
			
			return null;
			
		}
				
		private Method var_continuewith_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pstate, TypeReference pcancellationToken, TypeReference pcontinuationOptions, TypeReference pscheduler)
		{
						
						
			if(this.var_continuewith_0_5 == null)
				this.var_continuewith_0_5 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken, pcontinuationOptions, pscheduler).Import();
			
			return this.var_continuewith_0_5;
						
		}
				
		private Method var_waitall_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void WaitAll(System.Threading.Tasks.Task[])<para/>
		/// </summary>
		public Method GetMethod_WaitAll(TypeReference ptasks)
		{
						
						
			if(this.var_waitall_0_1 == null)
				this.var_waitall_0_1 = this.builderType.GetMethod("WaitAll", true, ptasks).Import();
			
			return this.var_waitall_0_1;
						
		}
				
		private Method var_waitall_0_2;
				
		private Method var_waitall_1_2;
				
		private Method var_waitall_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean WaitAll(System.Threading.Tasks.Task[], System.TimeSpan)<para/>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32)<para/>
		/// Void WaitAll(System.Threading.Tasks.Task[], System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_WaitAll(TypeReference ptasks, TypeReference ptimeout)
		{
						
						
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.TimeSpan).AreEqual(ptimeout))
			{
				if(this.var_waitall_0_2 == null)
					this.var_waitall_0_2 = this.builderType.GetMethod("WaitAll", true, ptasks, ptimeout).Import();
			
				return this.var_waitall_0_2;
			}
			
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.Int32).AreEqual(ptimeout))
			{
				if(this.var_waitall_1_2 == null)
					this.var_waitall_1_2 = this.builderType.GetMethod("WaitAll", true, ptasks, ptimeout).Import();
			
				return this.var_waitall_1_2;
			}
			
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.Threading.CancellationToken).AreEqual(ptimeout))
			{
				if(this.var_waitall_2_2 == null)
					this.var_waitall_2_2 = this.builderType.GetMethod("WaitAll", true, ptasks, ptimeout).Import();
			
				return this.var_waitall_2_2;
			}
			
			return null;
			
		}
				
		private Method var_waitall_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_WaitAll(TypeReference ptasks, TypeReference pmillisecondsTimeout, TypeReference pcancellationToken)
		{
						
						
			if(this.var_waitall_0_3 == null)
				this.var_waitall_0_3 = this.builderType.GetMethod("WaitAll", true, ptasks, pmillisecondsTimeout, pcancellationToken).Import();
			
			return this.var_waitall_0_3;
						
		}
				
		private Method var_waitany_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 WaitAny(System.Threading.Tasks.Task[])<para/>
		/// </summary>
		public Method GetMethod_WaitAny(TypeReference ptasks)
		{
						
						
			if(this.var_waitany_0_1 == null)
				this.var_waitany_0_1 = this.builderType.GetMethod("WaitAny", true, ptasks).Import();
			
			return this.var_waitany_0_1;
						
		}
				
		private Method var_waitany_0_2;
				
		private Method var_waitany_1_2;
				
		private Method var_waitany_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.TimeSpan)<para/>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.Threading.CancellationToken)<para/>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32)<para/>
		/// </summary>
		public Method GetMethod_WaitAny(TypeReference ptasks, TypeReference ptimeout)
		{
						
						
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.TimeSpan).AreEqual(ptimeout))
			{
				if(this.var_waitany_0_2 == null)
					this.var_waitany_0_2 = this.builderType.GetMethod("WaitAny", true, ptasks, ptimeout).Import();
			
				return this.var_waitany_0_2;
			}
			
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.Threading.CancellationToken).AreEqual(ptimeout))
			{
				if(this.var_waitany_1_2 == null)
					this.var_waitany_1_2 = this.builderType.GetMethod("WaitAny", true, ptasks, ptimeout).Import();
			
				return this.var_waitany_1_2;
			}
			
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks) && typeof(System.Int32).AreEqual(ptimeout))
			{
				if(this.var_waitany_2_2 == null)
					this.var_waitany_2_2 = this.builderType.GetMethod("WaitAny", true, ptasks, ptimeout).Import();
			
				return this.var_waitany_2_2;
			}
			
			return null;
			
		}
				
		private Method var_waitany_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_WaitAny(TypeReference ptasks, TypeReference pmillisecondsTimeout, TypeReference pcancellationToken)
		{
						
						
			if(this.var_waitany_0_3 == null)
				this.var_waitany_0_3 = this.builderType.GetMethod("WaitAny", true, ptasks, pmillisecondsTimeout, pcancellationToken).Import();
			
			return this.var_waitany_0_3;
						
		}
				
		private Method var_fromexception_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task FromException(System.Exception)<para/>
		/// </summary>
		public Method GetMethod_FromException(TypeReference pexception)
		{
						
						
			if(this.var_fromexception_0_1 == null)
				this.var_fromexception_0_1 = this.builderType.GetMethod("FromException", true, pexception).Import();
			
			return this.var_fromexception_0_1;
						
		}
				
		private Method var_fromcanceled_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_FromCanceled(TypeReference pcancellationToken)
		{
						
						
			if(this.var_fromcanceled_0_1 == null)
				this.var_fromcanceled_0_1 = this.builderType.GetMethod("FromCanceled", true, pcancellationToken).Import();
			
			return this.var_fromcanceled_0_1;
						
		}
				
		private Method var_run_0_1;
				
		private Method var_run_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task Run(System.Action)<para/>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task])<para/>
		/// </summary>
		public Method GetMethod_Run(TypeReference paction)
		{
						
						
			if(typeof(System.Action).AreEqual(paction))
			{
				if(this.var_run_0_1 == null)
					this.var_run_0_1 = this.builderType.GetMethod("Run", true, paction).Import();
			
				return this.var_run_0_1;
			}
			
			if(typeof(System.Func<>).AreEqual(paction))
			{
				if(this.var_run_1_1 == null)
					this.var_run_1_1 = this.builderType.GetMethod("Run", true, paction).Import();
			
				return this.var_run_1_1;
			}
			
			return null;
			
		}
				
		private Method var_run_0_2;
				
		private Method var_run_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task Run(System.Action, System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_Run(TypeReference paction, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.Action).AreEqual(paction) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_run_0_2 == null)
					this.var_run_0_2 = this.builderType.GetMethod("Run", true, paction, pcancellationToken).Import();
			
				return this.var_run_0_2;
			}
			
			if(typeof(System.Func<>).AreEqual(paction) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_run_1_2 == null)
					this.var_run_1_2 = this.builderType.GetMethod("Run", true, paction, pcancellationToken).Import();
			
				return this.var_run_1_2;
			}
			
			return null;
			
		}
				
		private Method var_delay_0_1;
				
		private Method var_delay_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task Delay(System.TimeSpan)<para/>
		/// System.Threading.Tasks.Task Delay(Int32)<para/>
		/// </summary>
		public Method GetMethod_Delay(TypeReference pdelay)
		{
						
						
			if(typeof(System.TimeSpan).AreEqual(pdelay))
			{
				if(this.var_delay_0_1 == null)
					this.var_delay_0_1 = this.builderType.GetMethod("Delay", true, pdelay).Import();
			
				return this.var_delay_0_1;
			}
			
			if(typeof(System.Int32).AreEqual(pdelay))
			{
				if(this.var_delay_1_1 == null)
					this.var_delay_1_1 = this.builderType.GetMethod("Delay", true, pdelay).Import();
			
				return this.var_delay_1_1;
			}
			
			return null;
			
		}
				
		private Method var_delay_0_2;
				
		private Method var_delay_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task Delay(System.TimeSpan, System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task Delay(Int32, System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_Delay(TypeReference pdelay, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.TimeSpan).AreEqual(pdelay) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_delay_0_2 == null)
					this.var_delay_0_2 = this.builderType.GetMethod("Delay", true, pdelay, pcancellationToken).Import();
			
				return this.var_delay_0_2;
			}
			
			if(typeof(System.Int32).AreEqual(pdelay) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_delay_1_2 == null)
					this.var_delay_1_2 = this.builderType.GetMethod("Delay", true, pdelay, pcancellationToken).Import();
			
				return this.var_delay_1_2;
			}
			
			return null;
			
		}
				
		private Method var_whenall_0_1;
				
		private Method var_whenall_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])<para/>
		/// System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[])<para/>
		/// </summary>
		public Method GetMethod_WhenAll(TypeReference ptasks)
		{
						
						
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(ptasks))
			{
				if(this.var_whenall_0_1 == null)
					this.var_whenall_0_1 = this.builderType.GetMethod("WhenAll", true, ptasks).Import();
			
				return this.var_whenall_0_1;
			}
			
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks))
			{
				if(this.var_whenall_1_1 == null)
					this.var_whenall_1_1 = this.builderType.GetMethod("WhenAll", true, ptasks).Import();
			
				return this.var_whenall_1_1;
			}
			
			return null;
			
		}
				
		private Method var_whenany_0_1;
				
		private Method var_whenany_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Threading.Tasks.Task[])<para/>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])<para/>
		/// </summary>
		public Method GetMethod_WhenAny(TypeReference ptasks)
		{
						
						
			if(typeof(System.Threading.Tasks.Task[]).AreEqual(ptasks))
			{
				if(this.var_whenany_0_1 == null)
					this.var_whenany_0_1 = this.builderType.GetMethod("WhenAny", true, ptasks).Import();
			
				return this.var_whenany_0_1;
			}
			
			if(typeof(System.Collections.Generic.IEnumerable<>).AreEqual(ptasks))
			{
				if(this.var_whenany_1_1 == null)
					this.var_whenany_1_1 = this.builderType.GetMethod("WhenAny", true, ptasks).Import();
			
				return this.var_whenany_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Threading.Tasks.Task{TResult}"/>
    /// </summary>
    public partial class BuilderTypeTask1 : TypeSystemExBase
	{
        internal BuilderTypeTask1(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeTask1 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeTask1 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_start_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Start()<para/>
		/// </summary>
		public Method GetMethod_Start()
		{
						
			if(this.var_start_0_0 == null)
				this.var_start_0_0 = this.builderType.GetMethod("Start", true);

			return this.var_start_0_0;
						
						
		}
				
		private Method var_start_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Start(System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_Start(TypeReference pscheduler)
		{
						
						
			if(this.var_start_0_1 == null)
				this.var_start_0_1 = this.builderType.GetMethod("Start", true, pscheduler).Import();
			
			return this.var_start_0_1;
						
		}
				
		private Method var_runsynchronously_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void RunSynchronously()<para/>
		/// </summary>
		public Method GetMethod_RunSynchronously()
		{
						
			if(this.var_runsynchronously_0_0 == null)
				this.var_runsynchronously_0_0 = this.builderType.GetMethod("RunSynchronously", true);

			return this.var_runsynchronously_0_0;
						
						
		}
				
		private Method var_runsynchronously_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void RunSynchronously(System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_RunSynchronously(TypeReference pscheduler)
		{
						
						
			if(this.var_runsynchronously_0_1 == null)
				this.var_runsynchronously_0_1 = this.builderType.GetMethod("RunSynchronously", true, pscheduler).Import();
			
			return this.var_runsynchronously_0_1;
						
		}
				
		private Method var_get_id_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Id()<para/>
		/// </summary>
		public Method GetMethod_get_Id()
		{
						
			if(this.var_get_id_0_0 == null)
				this.var_get_id_0_0 = this.builderType.GetMethod("get_Id", true);

			return this.var_get_id_0_0;
						
						
		}
				
		private Method var_get_exception_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.AggregateException get_Exception()<para/>
		/// </summary>
		public Method GetMethod_get_Exception()
		{
						
			if(this.var_get_exception_0_0 == null)
				this.var_get_exception_0_0 = this.builderType.GetMethod("get_Exception", true);

			return this.var_get_exception_0_0;
						
						
		}
				
		private Method var_get_status_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.TaskStatus get_Status()<para/>
		/// </summary>
		public Method GetMethod_get_Status()
		{
						
			if(this.var_get_status_0_0 == null)
				this.var_get_status_0_0 = this.builderType.GetMethod("get_Status", true);

			return this.var_get_status_0_0;
						
						
		}
				
		private Method var_get_iscanceled_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsCanceled()<para/>
		/// </summary>
		public Method GetMethod_get_IsCanceled()
		{
						
			if(this.var_get_iscanceled_0_0 == null)
				this.var_get_iscanceled_0_0 = this.builderType.GetMethod("get_IsCanceled", true);

			return this.var_get_iscanceled_0_0;
						
						
		}
				
		private Method var_get_iscompleted_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsCompleted()<para/>
		/// </summary>
		public Method GetMethod_get_IsCompleted()
		{
						
			if(this.var_get_iscompleted_0_0 == null)
				this.var_get_iscompleted_0_0 = this.builderType.GetMethod("get_IsCompleted", true);

			return this.var_get_iscompleted_0_0;
						
						
		}
				
		private Method var_get_creationoptions_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.TaskCreationOptions get_CreationOptions()<para/>
		/// </summary>
		public Method GetMethod_get_CreationOptions()
		{
						
			if(this.var_get_creationoptions_0_0 == null)
				this.var_get_creationoptions_0_0 = this.builderType.GetMethod("get_CreationOptions", true);

			return this.var_get_creationoptions_0_0;
						
						
		}
				
		private Method var_get_asyncstate_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object get_AsyncState()<para/>
		/// </summary>
		public Method GetMethod_get_AsyncState()
		{
						
			if(this.var_get_asyncstate_0_0 == null)
				this.var_get_asyncstate_0_0 = this.builderType.GetMethod("get_AsyncState", true);

			return this.var_get_asyncstate_0_0;
						
						
		}
				
		private Method var_get_isfaulted_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsFaulted()<para/>
		/// </summary>
		public Method GetMethod_get_IsFaulted()
		{
						
			if(this.var_get_isfaulted_0_0 == null)
				this.var_get_isfaulted_0_0 = this.builderType.GetMethod("get_IsFaulted", true);

			return this.var_get_isfaulted_0_0;
						
						
		}
				
		private Method var_dispose_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Dispose()<para/>
		/// </summary>
		public Method GetMethod_Dispose()
		{
						
			if(this.var_dispose_0_0 == null)
				this.var_dispose_0_0 = this.builderType.GetMethod("Dispose", true);

			return this.var_dispose_0_0;
						
						
		}
				
		private Method var_getawaiter_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()<para/>
		/// </summary>
		public Method GetMethod_GetAwaiter()
		{
						
			if(this.var_getawaiter_0_0 == null)
				this.var_getawaiter_0_0 = this.builderType.GetMethod("GetAwaiter", true);

			return this.var_getawaiter_0_0;
						
						
		}
				
		private Method var_configureawait_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(Boolean)<para/>
		/// </summary>
		public Method GetMethod_ConfigureAwait(TypeReference pcontinueOnCapturedContext)
		{
						
						
			if(this.var_configureawait_0_1 == null)
				this.var_configureawait_0_1 = this.builderType.GetMethod("ConfigureAwait", true, pcontinueOnCapturedContext).Import();
			
			return this.var_configureawait_0_1;
						
		}
				
		private Method var_wait_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void Wait()<para/>
		/// </summary>
		public Method GetMethod_Wait()
		{
						
			if(this.var_wait_0_0 == null)
				this.var_wait_0_0 = this.builderType.GetMethod("Wait", true);

			return this.var_wait_0_0;
						
						
		}
				
		private Method var_wait_0_1;
				
		private Method var_wait_1_1;
				
		private Method var_wait_2_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(System.TimeSpan)<para/>
		/// Void Wait(System.Threading.CancellationToken)<para/>
		/// Boolean Wait(Int32)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference ptimeout)
		{
						
						
			if(typeof(System.TimeSpan).AreEqual(ptimeout))
			{
				if(this.var_wait_0_1 == null)
					this.var_wait_0_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_0_1;
			}
			
			if(typeof(System.Threading.CancellationToken).AreEqual(ptimeout))
			{
				if(this.var_wait_1_1 == null)
					this.var_wait_1_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_1_1;
			}
			
			if(typeof(System.Int32).AreEqual(ptimeout))
			{
				if(this.var_wait_2_1 == null)
					this.var_wait_2_1 = this.builderType.GetMethod("Wait", true, ptimeout).Import();
			
				return this.var_wait_2_1;
			}
			
			return null;
			
		}
				
		private Method var_wait_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Wait(Int32, System.Threading.CancellationToken)<para/>
		/// </summary>
		public Method GetMethod_Wait(TypeReference pmillisecondsTimeout, TypeReference pcancellationToken)
		{
						
						
			if(this.var_wait_0_2 == null)
				this.var_wait_0_2 = this.builderType.GetMethod("Wait", true, pmillisecondsTimeout, pcancellationToken).Import();
			
			return this.var_wait_0_2;
						
		}
				
		private Method var_continuewith_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction)
		{
						
						
			if(this.var_continuewith_0_1 == null)
				this.var_continuewith_0_1 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction).Import();
			
			return this.var_continuewith_0_1;
						
		}
				
		private Method var_continuewith_0_2;
				
		private Method var_continuewith_1_2;
				
		private Method var_continuewith_2_2;
				
		private Method var_continuewith_3_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_0_2 == null)
					this.var_continuewith_0_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_0_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.Tasks.TaskScheduler).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_1_2 == null)
					this.var_continuewith_1_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_1_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Threading.Tasks.TaskContinuationOptions).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_2_2 == null)
					this.var_continuewith_2_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_2_2;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_3_2 == null)
					this.var_continuewith_3_2 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken).Import();
			
				return this.var_continuewith_3_2;
			}
			
			return null;
			
		}
				
		private Method var_continuewith_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pcancellationToken, TypeReference pcontinuationOptions, TypeReference pscheduler)
		{
						
						
			if(this.var_continuewith_0_4 == null)
				this.var_continuewith_0_4 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pcancellationToken, pcontinuationOptions, pscheduler).Import();
			
			return this.var_continuewith_0_4;
						
		}
				
		private Method var_continuewith_0_3;
				
		private Method var_continuewith_1_3;
				
		private Method var_continuewith_2_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler)<para/>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pstate, TypeReference pcancellationToken)
		{
						
						
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.CancellationToken).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_0_3 == null)
					this.var_continuewith_0_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_0_3;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.Tasks.TaskScheduler).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_1_3 == null)
					this.var_continuewith_1_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_1_3;
			}
			
			if(typeof(System.Action<>).AreEqual(pcontinuationAction) && typeof(System.Object).AreEqual(pstate) && typeof(System.Threading.Tasks.TaskContinuationOptions).AreEqual(pcancellationToken))
			{
				if(this.var_continuewith_2_3 == null)
					this.var_continuewith_2_3 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken).Import();
			
				return this.var_continuewith_2_3;
			}
			
			return null;
			
		}
				
		private Method var_continuewith_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)<para/>
		/// </summary>
		public Method GetMethod_ContinueWith(TypeReference pcontinuationAction, TypeReference pstate, TypeReference pcancellationToken, TypeReference pcontinuationOptions, TypeReference pscheduler)
		{
						
						
			if(this.var_continuewith_0_5 == null)
				this.var_continuewith_0_5 = this.builderType.GetMethod("ContinueWith", true, pcontinuationAction, pstate, pcancellationToken, pcontinuationOptions, pscheduler).Import();
			
			return this.var_continuewith_0_5;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.Type"/>
    /// </summary>
    public partial class BuilderTypeType : TypeSystemExBase
	{
        internal BuilderTypeType(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeType value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeType value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_gettypefromhandle_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromHandle(System.RuntimeTypeHandle)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromHandle(TypeReference phandle)
		{
						
						
			if(this.var_gettypefromhandle_0_1 == null)
				this.var_gettypefromhandle_0_1 = this.builderType.GetMethod("GetTypeFromHandle", true, phandle).Import();
			
			return this.var_gettypefromhandle_0_1;
						
		}
				
		private Method var_get_membertype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberTypes get_MemberType()<para/>
		/// </summary>
		public Method GetMethod_get_MemberType()
		{
						
			if(this.var_get_membertype_0_0 == null)
				this.var_get_membertype_0_0 = this.builderType.GetMethod("get_MemberType", true);

			return this.var_get_membertype_0_0;
						
						
		}
				
		private Method var_get_declaringtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_DeclaringType()<para/>
		/// </summary>
		public Method GetMethod_get_DeclaringType()
		{
						
			if(this.var_get_declaringtype_0_0 == null)
				this.var_get_declaringtype_0_0 = this.builderType.GetMethod("get_DeclaringType", true);

			return this.var_get_declaringtype_0_0;
						
						
		}
				
		private Method var_get_declaringmethod_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodBase get_DeclaringMethod()<para/>
		/// </summary>
		public Method GetMethod_get_DeclaringMethod()
		{
						
			if(this.var_get_declaringmethod_0_0 == null)
				this.var_get_declaringmethod_0_0 = this.builderType.GetMethod("get_DeclaringMethod", true);

			return this.var_get_declaringmethod_0_0;
						
						
		}
				
		private Method var_get_reflectedtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_ReflectedType()<para/>
		/// </summary>
		public Method GetMethod_get_ReflectedType()
		{
						
			if(this.var_get_reflectedtype_0_0 == null)
				this.var_get_reflectedtype_0_0 = this.builderType.GetMethod("get_ReflectedType", true);

			return this.var_get_reflectedtype_0_0;
						
						
		}
				
		private Method var_gettype_0_3;
				
		private Method var_gettype_1_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType(System.String, Boolean, Boolean)<para/>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type])<para/>
		/// </summary>
		public Method GetMethod_GetType(TypeReference ptypeName, TypeReference pthrowOnError, TypeReference pignoreCase)
		{
						
						
			if(typeof(System.String).AreEqual(ptypeName) && typeof(System.Boolean).AreEqual(pthrowOnError) && typeof(System.Boolean).AreEqual(pignoreCase))
			{
				if(this.var_gettype_0_3 == null)
					this.var_gettype_0_3 = this.builderType.GetMethod("GetType", true, ptypeName, pthrowOnError, pignoreCase).Import();
			
				return this.var_gettype_0_3;
			}
			
			if(typeof(System.String).AreEqual(ptypeName) && typeof(System.Func<>).AreEqual(pthrowOnError) && typeof(System.Func<>).AreEqual(pignoreCase))
			{
				if(this.var_gettype_1_3 == null)
					this.var_gettype_1_3 = this.builderType.GetMethod("GetType", true, ptypeName, pthrowOnError, pignoreCase).Import();
			
				return this.var_gettype_1_3;
			}
			
			return null;
			
		}
				
		private Method var_gettype_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType(System.String, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetType(TypeReference ptypeName, TypeReference pthrowOnError)
		{
						
						
			if(this.var_gettype_0_2 == null)
				this.var_gettype_0_2 = this.builderType.GetMethod("GetType", true, ptypeName, pthrowOnError).Import();
			
			return this.var_gettype_0_2;
						
		}
				
		private Method var_gettype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetType(TypeReference ptypeName)
		{
						
						
			if(this.var_gettype_0_1 == null)
				this.var_gettype_0_1 = this.builderType.GetMethod("GetType", true, ptypeName).Import();
			
			return this.var_gettype_0_1;
						
		}
				
		private Method var_gettype_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetType(TypeReference ptypeName, TypeReference passemblyResolver, TypeReference ptypeResolver, TypeReference pthrowOnError)
		{
						
						
			if(this.var_gettype_0_4 == null)
				this.var_gettype_0_4 = this.builderType.GetMethod("GetType", true, ptypeName, passemblyResolver, ptypeResolver, pthrowOnError).Import();
			
			return this.var_gettype_0_4;
						
		}
				
		private Method var_gettype_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetType(TypeReference ptypeName, TypeReference passemblyResolver, TypeReference ptypeResolver, TypeReference pthrowOnError, TypeReference pignoreCase)
		{
						
						
			if(this.var_gettype_0_5 == null)
				this.var_gettype_0_5 = this.builderType.GetMethod("GetType", true, ptypeName, passemblyResolver, ptypeResolver, pthrowOnError, pignoreCase).Import();
			
			return this.var_gettype_0_5;
						
		}
				
		private Method var_reflectiononlygettype_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type ReflectionOnlyGetType(System.String, Boolean, Boolean)<para/>
		/// </summary>
		public Method GetMethod_ReflectionOnlyGetType(TypeReference ptypeName, TypeReference pthrowIfNotFound, TypeReference pignoreCase)
		{
						
						
			if(this.var_reflectiononlygettype_0_3 == null)
				this.var_reflectiononlygettype_0_3 = this.builderType.GetMethod("ReflectionOnlyGetType", true, ptypeName, pthrowIfNotFound, pignoreCase).Import();
			
			return this.var_reflectiononlygettype_0_3;
						
		}
				
		private Method var_makepointertype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type MakePointerType()<para/>
		/// </summary>
		public Method GetMethod_MakePointerType()
		{
						
			if(this.var_makepointertype_0_0 == null)
				this.var_makepointertype_0_0 = this.builderType.GetMethod("MakePointerType", true);

			return this.var_makepointertype_0_0;
						
						
		}
				
		private Method var_get_structlayoutattribute_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Runtime.InteropServices.StructLayoutAttribute get_StructLayoutAttribute()<para/>
		/// </summary>
		public Method GetMethod_get_StructLayoutAttribute()
		{
						
			if(this.var_get_structlayoutattribute_0_0 == null)
				this.var_get_structlayoutattribute_0_0 = this.builderType.GetMethod("get_StructLayoutAttribute", true);

			return this.var_get_structlayoutattribute_0_0;
						
						
		}
				
		private Method var_makebyreftype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type MakeByRefType()<para/>
		/// </summary>
		public Method GetMethod_MakeByRefType()
		{
						
			if(this.var_makebyreftype_0_0 == null)
				this.var_makebyreftype_0_0 = this.builderType.GetMethod("MakeByRefType", true);

			return this.var_makebyreftype_0_0;
						
						
		}
				
		private Method var_makearraytype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type MakeArrayType()<para/>
		/// </summary>
		public Method GetMethod_MakeArrayType()
		{
						
			if(this.var_makearraytype_0_0 == null)
				this.var_makearraytype_0_0 = this.builderType.GetMethod("MakeArrayType", true);

			return this.var_makearraytype_0_0;
						
						
		}
				
		private Method var_makearraytype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type MakeArrayType(Int32)<para/>
		/// </summary>
		public Method GetMethod_MakeArrayType(TypeReference prank)
		{
						
						
			if(this.var_makearraytype_0_1 == null)
				this.var_makearraytype_0_1 = this.builderType.GetMethod("MakeArrayType", true, prank).Import();
			
			return this.var_makearraytype_0_1;
						
		}
				
		private Method var_gettypefromprogid_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromProgID(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromProgID(TypeReference pprogID)
		{
						
						
			if(this.var_gettypefromprogid_0_1 == null)
				this.var_gettypefromprogid_0_1 = this.builderType.GetMethod("GetTypeFromProgID", true, pprogID).Import();
			
			return this.var_gettypefromprogid_0_1;
						
		}
				
		private Method var_gettypefromprogid_0_2;
				
		private Method var_gettypefromprogid_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromProgID(System.String, Boolean)<para/>
		/// System.Type GetTypeFromProgID(System.String, System.String)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromProgID(TypeReference pprogID, TypeReference pthrowOnError)
		{
						
						
			if(typeof(System.String).AreEqual(pprogID) && typeof(System.Boolean).AreEqual(pthrowOnError))
			{
				if(this.var_gettypefromprogid_0_2 == null)
					this.var_gettypefromprogid_0_2 = this.builderType.GetMethod("GetTypeFromProgID", true, pprogID, pthrowOnError).Import();
			
				return this.var_gettypefromprogid_0_2;
			}
			
			if(typeof(System.String).AreEqual(pprogID) && typeof(System.String).AreEqual(pthrowOnError))
			{
				if(this.var_gettypefromprogid_1_2 == null)
					this.var_gettypefromprogid_1_2 = this.builderType.GetMethod("GetTypeFromProgID", true, pprogID, pthrowOnError).Import();
			
				return this.var_gettypefromprogid_1_2;
			}
			
			return null;
			
		}
				
		private Method var_gettypefromprogid_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromProgID(System.String, System.String, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromProgID(TypeReference pprogID, TypeReference pserver, TypeReference pthrowOnError)
		{
						
						
			if(this.var_gettypefromprogid_0_3 == null)
				this.var_gettypefromprogid_0_3 = this.builderType.GetMethod("GetTypeFromProgID", true, pprogID, pserver, pthrowOnError).Import();
			
			return this.var_gettypefromprogid_0_3;
						
		}
				
		private Method var_gettypefromclsid_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromCLSID(System.Guid)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromCLSID(TypeReference pclsid)
		{
						
						
			if(this.var_gettypefromclsid_0_1 == null)
				this.var_gettypefromclsid_0_1 = this.builderType.GetMethod("GetTypeFromCLSID", true, pclsid).Import();
			
			return this.var_gettypefromclsid_0_1;
						
		}
				
		private Method var_gettypefromclsid_0_2;
				
		private Method var_gettypefromclsid_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromCLSID(System.Guid, Boolean)<para/>
		/// System.Type GetTypeFromCLSID(System.Guid, System.String)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromCLSID(TypeReference pclsid, TypeReference pthrowOnError)
		{
						
						
			if(typeof(System.Guid).AreEqual(pclsid) && typeof(System.Boolean).AreEqual(pthrowOnError))
			{
				if(this.var_gettypefromclsid_0_2 == null)
					this.var_gettypefromclsid_0_2 = this.builderType.GetMethod("GetTypeFromCLSID", true, pclsid, pthrowOnError).Import();
			
				return this.var_gettypefromclsid_0_2;
			}
			
			if(typeof(System.Guid).AreEqual(pclsid) && typeof(System.String).AreEqual(pthrowOnError))
			{
				if(this.var_gettypefromclsid_1_2 == null)
					this.var_gettypefromclsid_1_2 = this.builderType.GetMethod("GetTypeFromCLSID", true, pclsid, pthrowOnError).Import();
			
				return this.var_gettypefromclsid_1_2;
			}
			
			return null;
			
		}
				
		private Method var_gettypefromclsid_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetTypeFromCLSID(System.Guid, System.String, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetTypeFromCLSID(TypeReference pclsid, TypeReference pserver, TypeReference pthrowOnError)
		{
						
						
			if(this.var_gettypefromclsid_0_3 == null)
				this.var_gettypefromclsid_0_3 = this.builderType.GetMethod("GetTypeFromCLSID", true, pclsid, pserver, pthrowOnError).Import();
			
			return this.var_gettypefromclsid_0_3;
						
		}
				
		private Method var_gettypecode_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode(TypeReference ptype)
		{
						
						
			if(this.var_gettypecode_0_1 == null)
				this.var_gettypecode_0_1 = this.builderType.GetMethod("GetTypeCode", true, ptype).Import();
			
			return this.var_gettypecode_0_1;
						
		}
				
		private Method var_get_guid_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Guid get_GUID()<para/>
		/// </summary>
		public Method GetMethod_get_GUID()
		{
						
			if(this.var_get_guid_0_0 == null)
				this.var_get_guid_0_0 = this.builderType.GetMethod("get_GUID", true);

			return this.var_get_guid_0_0;
						
						
		}
				
		private Method var_get_defaultbinder_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.Binder get_DefaultBinder()<para/>
		/// </summary>
		public Method GetMethod_get_DefaultBinder()
		{
						
			if(this.var_get_defaultbinder_0_0 == null)
				this.var_get_defaultbinder_0_0 = this.builderType.GetMethod("get_DefaultBinder", true);

			return this.var_get_defaultbinder_0_0;
						
						
		}
				
		private Method var_invokemember_0_8;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])<para/>
		/// </summary>
		public Method GetMethod_InvokeMember(TypeReference pname, TypeReference pinvokeAttr, TypeReference pbinder, TypeReference ptarget, TypeReference pargs, TypeReference pmodifiers, TypeReference pculture, TypeReference pnamedParameters)
		{
						
						
			if(this.var_invokemember_0_8 == null)
				this.var_invokemember_0_8 = this.builderType.GetMethod("InvokeMember", true, pname, pinvokeAttr, pbinder, ptarget, pargs, pmodifiers, pculture, pnamedParameters).Import();
			
			return this.var_invokemember_0_8;
						
		}
				
		private Method var_invokemember_0_6;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)<para/>
		/// </summary>
		public Method GetMethod_InvokeMember(TypeReference pname, TypeReference pinvokeAttr, TypeReference pbinder, TypeReference ptarget, TypeReference pargs, TypeReference pculture)
		{
						
						
			if(this.var_invokemember_0_6 == null)
				this.var_invokemember_0_6 = this.builderType.GetMethod("InvokeMember", true, pname, pinvokeAttr, pbinder, ptarget, pargs, pculture).Import();
			
			return this.var_invokemember_0_6;
						
		}
				
		private Method var_invokemember_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])<para/>
		/// </summary>
		public Method GetMethod_InvokeMember(TypeReference pname, TypeReference pinvokeAttr, TypeReference pbinder, TypeReference ptarget, TypeReference pargs)
		{
						
						
			if(this.var_invokemember_0_5 == null)
				this.var_invokemember_0_5 = this.builderType.GetMethod("InvokeMember", true, pname, pinvokeAttr, pbinder, ptarget, pargs).Import();
			
			return this.var_invokemember_0_5;
						
		}
				
		private Method var_get_module_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.Module get_Module()<para/>
		/// </summary>
		public Method GetMethod_get_Module()
		{
						
			if(this.var_get_module_0_0 == null)
				this.var_get_module_0_0 = this.builderType.GetMethod("get_Module", true);

			return this.var_get_module_0_0;
						
						
		}
				
		private Method var_get_assembly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.Assembly get_Assembly()<para/>
		/// </summary>
		public Method GetMethod_get_Assembly()
		{
						
			if(this.var_get_assembly_0_0 == null)
				this.var_get_assembly_0_0 = this.builderType.GetMethod("get_Assembly", true);

			return this.var_get_assembly_0_0;
						
						
		}
				
		private Method var_get_typehandle_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.RuntimeTypeHandle get_TypeHandle()<para/>
		/// </summary>
		public Method GetMethod_get_TypeHandle()
		{
						
			if(this.var_get_typehandle_0_0 == null)
				this.var_get_typehandle_0_0 = this.builderType.GetMethod("get_TypeHandle", true);

			return this.var_get_typehandle_0_0;
						
						
		}
				
		private Method var_gettypehandle_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.RuntimeTypeHandle GetTypeHandle(System.Object)<para/>
		/// </summary>
		public Method GetMethod_GetTypeHandle(TypeReference po)
		{
						
						
			if(this.var_gettypehandle_0_1 == null)
				this.var_gettypehandle_0_1 = this.builderType.GetMethod("GetTypeHandle", true, po).Import();
			
			return this.var_gettypehandle_0_1;
						
		}
				
		private Method var_get_fullname_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_FullName()<para/>
		/// </summary>
		public Method GetMethod_get_FullName()
		{
						
			if(this.var_get_fullname_0_0 == null)
				this.var_get_fullname_0_0 = this.builderType.GetMethod("get_FullName", true);

			return this.var_get_fullname_0_0;
						
						
		}
				
		private Method var_get_namespace_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_Namespace()<para/>
		/// </summary>
		public Method GetMethod_get_Namespace()
		{
						
			if(this.var_get_namespace_0_0 == null)
				this.var_get_namespace_0_0 = this.builderType.GetMethod("get_Namespace", true);

			return this.var_get_namespace_0_0;
						
						
		}
				
		private Method var_get_assemblyqualifiedname_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_AssemblyQualifiedName()<para/>
		/// </summary>
		public Method GetMethod_get_AssemblyQualifiedName()
		{
						
			if(this.var_get_assemblyqualifiedname_0_0 == null)
				this.var_get_assemblyqualifiedname_0_0 = this.builderType.GetMethod("get_AssemblyQualifiedName", true);

			return this.var_get_assemblyqualifiedname_0_0;
						
						
		}
				
		private Method var_getarrayrank_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetArrayRank()<para/>
		/// </summary>
		public Method GetMethod_GetArrayRank()
		{
						
			if(this.var_getarrayrank_0_0 == null)
				this.var_getarrayrank_0_0 = this.builderType.GetMethod("GetArrayRank", true);

			return this.var_getarrayrank_0_0;
						
						
		}
				
		private Method var_get_basetype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_BaseType()<para/>
		/// </summary>
		public Method GetMethod_get_BaseType()
		{
						
			if(this.var_get_basetype_0_0 == null)
				this.var_get_basetype_0_0 = this.builderType.GetMethod("get_BaseType", true);

			return this.var_get_basetype_0_0;
						
						
		}
				
		private Method var_getconstructor_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetConstructor(TypeReference pbindingAttr, TypeReference pbinder, TypeReference pcallConvention, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getconstructor_0_5 == null)
				this.var_getconstructor_0_5 = this.builderType.GetMethod("GetConstructor", true, pbindingAttr, pbinder, pcallConvention, ptypes, pmodifiers).Import();
			
			return this.var_getconstructor_0_5;
						
		}
				
		private Method var_getconstructor_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetConstructor(TypeReference pbindingAttr, TypeReference pbinder, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getconstructor_0_4 == null)
				this.var_getconstructor_0_4 = this.builderType.GetMethod("GetConstructor", true, pbindingAttr, pbinder, ptypes, pmodifiers).Import();
			
			return this.var_getconstructor_0_4;
						
		}
				
		private Method var_getconstructor_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])<para/>
		/// </summary>
		public Method GetMethod_GetConstructor(TypeReference ptypes)
		{
						
						
			if(this.var_getconstructor_0_1 == null)
				this.var_getconstructor_0_1 = this.builderType.GetMethod("GetConstructor", true, ptypes).Import();
			
			return this.var_getconstructor_0_1;
						
		}
				
		private Method var_getconstructors_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo[] GetConstructors()<para/>
		/// </summary>
		public Method GetMethod_GetConstructors()
		{
						
			if(this.var_getconstructors_0_0 == null)
				this.var_getconstructors_0_0 = this.builderType.GetMethod("GetConstructors", true);

			return this.var_getconstructors_0_0;
						
						
		}
				
		private Method var_getconstructors_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetConstructors(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getconstructors_0_1 == null)
				this.var_getconstructors_0_1 = this.builderType.GetMethod("GetConstructors", true, pbindingAttr).Import();
			
			return this.var_getconstructors_0_1;
						
		}
				
		private Method var_get_typeinitializer_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.ConstructorInfo get_TypeInitializer()<para/>
		/// </summary>
		public Method GetMethod_get_TypeInitializer()
		{
						
			if(this.var_get_typeinitializer_0_0 == null)
				this.var_get_typeinitializer_0_0 = this.builderType.GetMethod("get_TypeInitializer", true);

			return this.var_get_typeinitializer_0_0;
						
						
		}
				
		private Method var_getmethod_0_6;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetMethod(TypeReference pname, TypeReference pbindingAttr, TypeReference pbinder, TypeReference pcallConvention, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getmethod_0_6 == null)
				this.var_getmethod_0_6 = this.builderType.GetMethod("GetMethod", true, pname, pbindingAttr, pbinder, pcallConvention, ptypes, pmodifiers).Import();
			
			return this.var_getmethod_0_6;
						
		}
				
		private Method var_getmethod_0_5;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetMethod(TypeReference pname, TypeReference pbindingAttr, TypeReference pbinder, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getmethod_0_5 == null)
				this.var_getmethod_0_5 = this.builderType.GetMethod("GetMethod", true, pname, pbindingAttr, pbinder, ptypes, pmodifiers).Import();
			
			return this.var_getmethod_0_5;
						
		}
				
		private Method var_getmethod_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetMethod(TypeReference pname, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getmethod_0_3 == null)
				this.var_getmethod_0_3 = this.builderType.GetMethod("GetMethod", true, pname, ptypes, pmodifiers).Import();
			
			return this.var_getmethod_0_3;
						
		}
				
		private Method var_getmethod_0_2;
				
		private Method var_getmethod_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])<para/>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetMethod(TypeReference pname, TypeReference ptypes)
		{
						
						
			if(typeof(System.String).AreEqual(pname) && typeof(System.Type[]).AreEqual(ptypes))
			{
				if(this.var_getmethod_0_2 == null)
					this.var_getmethod_0_2 = this.builderType.GetMethod("GetMethod", true, pname, ptypes).Import();
			
				return this.var_getmethod_0_2;
			}
			
			if(typeof(System.String).AreEqual(pname) && typeof(System.Reflection.BindingFlags).AreEqual(ptypes))
			{
				if(this.var_getmethod_1_2 == null)
					this.var_getmethod_1_2 = this.builderType.GetMethod("GetMethod", true, pname, ptypes).Import();
			
				return this.var_getmethod_1_2;
			}
			
			return null;
			
		}
				
		private Method var_getmethod_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo GetMethod(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetMethod(TypeReference pname)
		{
						
						
			if(this.var_getmethod_0_1 == null)
				this.var_getmethod_0_1 = this.builderType.GetMethod("GetMethod", true, pname).Import();
			
			return this.var_getmethod_0_1;
						
		}
				
		private Method var_getmethods_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo[] GetMethods()<para/>
		/// </summary>
		public Method GetMethod_GetMethods()
		{
						
			if(this.var_getmethods_0_0 == null)
				this.var_getmethods_0_0 = this.builderType.GetMethod("GetMethods", true);

			return this.var_getmethods_0_0;
						
						
		}
				
		private Method var_getmethods_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetMethods(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getmethods_0_1 == null)
				this.var_getmethods_0_1 = this.builderType.GetMethod("GetMethods", true, pbindingAttr).Import();
			
			return this.var_getmethods_0_1;
						
		}
				
		private Method var_getfield_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetField(TypeReference pname, TypeReference pbindingAttr)
		{
						
						
			if(this.var_getfield_0_2 == null)
				this.var_getfield_0_2 = this.builderType.GetMethod("GetField", true, pname, pbindingAttr).Import();
			
			return this.var_getfield_0_2;
						
		}
				
		private Method var_getfield_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.FieldInfo GetField(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetField(TypeReference pname)
		{
						
						
			if(this.var_getfield_0_1 == null)
				this.var_getfield_0_1 = this.builderType.GetMethod("GetField", true, pname).Import();
			
			return this.var_getfield_0_1;
						
		}
				
		private Method var_getfields_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.FieldInfo[] GetFields()<para/>
		/// </summary>
		public Method GetMethod_GetFields()
		{
						
			if(this.var_getfields_0_0 == null)
				this.var_getfields_0_0 = this.builderType.GetMethod("GetFields", true);

			return this.var_getfields_0_0;
						
						
		}
				
		private Method var_getfields_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetFields(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getfields_0_1 == null)
				this.var_getfields_0_1 = this.builderType.GetMethod("GetFields", true, pbindingAttr).Import();
			
			return this.var_getfields_0_1;
						
		}
				
		private Method var_getinterface_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetInterface(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetInterface(TypeReference pname)
		{
						
						
			if(this.var_getinterface_0_1 == null)
				this.var_getinterface_0_1 = this.builderType.GetMethod("GetInterface", true, pname).Import();
			
			return this.var_getinterface_0_1;
						
		}
				
		private Method var_getinterface_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetInterface(System.String, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetInterface(TypeReference pname, TypeReference pignoreCase)
		{
						
						
			if(this.var_getinterface_0_2 == null)
				this.var_getinterface_0_2 = this.builderType.GetMethod("GetInterface", true, pname, pignoreCase).Import();
			
			return this.var_getinterface_0_2;
						
		}
				
		private Method var_getinterfaces_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetInterfaces()<para/>
		/// </summary>
		public Method GetMethod_GetInterfaces()
		{
						
			if(this.var_getinterfaces_0_0 == null)
				this.var_getinterfaces_0_0 = this.builderType.GetMethod("GetInterfaces", true);

			return this.var_getinterfaces_0_0;
						
						
		}
				
		private Method var_findinterfaces_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)<para/>
		/// </summary>
		public Method GetMethod_FindInterfaces(TypeReference pfilter, TypeReference pfilterCriteria)
		{
						
						
			if(this.var_findinterfaces_0_2 == null)
				this.var_findinterfaces_0_2 = this.builderType.GetMethod("FindInterfaces", true, pfilter, pfilterCriteria).Import();
			
			return this.var_findinterfaces_0_2;
						
		}
				
		private Method var_getevent_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.EventInfo GetEvent(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetEvent(TypeReference pname)
		{
						
						
			if(this.var_getevent_0_1 == null)
				this.var_getevent_0_1 = this.builderType.GetMethod("GetEvent", true, pname).Import();
			
			return this.var_getevent_0_1;
						
		}
				
		private Method var_getevent_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetEvent(TypeReference pname, TypeReference pbindingAttr)
		{
						
						
			if(this.var_getevent_0_2 == null)
				this.var_getevent_0_2 = this.builderType.GetMethod("GetEvent", true, pname, pbindingAttr).Import();
			
			return this.var_getevent_0_2;
						
		}
				
		private Method var_getevents_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.EventInfo[] GetEvents()<para/>
		/// </summary>
		public Method GetMethod_GetEvents()
		{
						
			if(this.var_getevents_0_0 == null)
				this.var_getevents_0_0 = this.builderType.GetMethod("GetEvents", true);

			return this.var_getevents_0_0;
						
						
		}
				
		private Method var_getevents_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetEvents(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getevents_0_1 == null)
				this.var_getevents_0_1 = this.builderType.GetMethod("GetEvents", true, pbindingAttr).Import();
			
			return this.var_getevents_0_1;
						
		}
				
		private Method var_getproperty_0_6;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetProperty(TypeReference pname, TypeReference pbindingAttr, TypeReference pbinder, TypeReference preturnType, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getproperty_0_6 == null)
				this.var_getproperty_0_6 = this.builderType.GetMethod("GetProperty", true, pname, pbindingAttr, pbinder, preturnType, ptypes, pmodifiers).Import();
			
			return this.var_getproperty_0_6;
						
		}
				
		private Method var_getproperty_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])<para/>
		/// </summary>
		public Method GetMethod_GetProperty(TypeReference pname, TypeReference preturnType, TypeReference ptypes, TypeReference pmodifiers)
		{
						
						
			if(this.var_getproperty_0_4 == null)
				this.var_getproperty_0_4 = this.builderType.GetMethod("GetProperty", true, pname, preturnType, ptypes, pmodifiers).Import();
			
			return this.var_getproperty_0_4;
						
		}
				
		private Method var_getproperty_0_2;
				
		private Method var_getproperty_1_2;
				
		private Method var_getproperty_2_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)<para/>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])<para/>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetProperty(TypeReference pname, TypeReference pbindingAttr)
		{
						
						
			if(typeof(System.String).AreEqual(pname) && typeof(System.Reflection.BindingFlags).AreEqual(pbindingAttr))
			{
				if(this.var_getproperty_0_2 == null)
					this.var_getproperty_0_2 = this.builderType.GetMethod("GetProperty", true, pname, pbindingAttr).Import();
			
				return this.var_getproperty_0_2;
			}
			
			if(typeof(System.String).AreEqual(pname) && typeof(System.Type[]).AreEqual(pbindingAttr))
			{
				if(this.var_getproperty_1_2 == null)
					this.var_getproperty_1_2 = this.builderType.GetMethod("GetProperty", true, pname, pbindingAttr).Import();
			
				return this.var_getproperty_1_2;
			}
			
			if(typeof(System.String).AreEqual(pname) && typeof(System.Type).AreEqual(pbindingAttr))
			{
				if(this.var_getproperty_2_2 == null)
					this.var_getproperty_2_2 = this.builderType.GetMethod("GetProperty", true, pname, pbindingAttr).Import();
			
				return this.var_getproperty_2_2;
			}
			
			return null;
			
		}
				
		private Method var_getproperty_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])<para/>
		/// </summary>
		public Method GetMethod_GetProperty(TypeReference pname, TypeReference preturnType, TypeReference ptypes)
		{
						
						
			if(this.var_getproperty_0_3 == null)
				this.var_getproperty_0_3 = this.builderType.GetMethod("GetProperty", true, pname, preturnType, ptypes).Import();
			
			return this.var_getproperty_0_3;
						
		}
				
		private Method var_getproperty_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo GetProperty(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetProperty(TypeReference pname)
		{
						
						
			if(this.var_getproperty_0_1 == null)
				this.var_getproperty_0_1 = this.builderType.GetMethod("GetProperty", true, pname).Import();
			
			return this.var_getproperty_0_1;
						
		}
				
		private Method var_getproperties_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetProperties(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getproperties_0_1 == null)
				this.var_getproperties_0_1 = this.builderType.GetMethod("GetProperties", true, pbindingAttr).Import();
			
			return this.var_getproperties_0_1;
						
		}
				
		private Method var_getproperties_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.PropertyInfo[] GetProperties()<para/>
		/// </summary>
		public Method GetMethod_GetProperties()
		{
						
			if(this.var_getproperties_0_0 == null)
				this.var_getproperties_0_0 = this.builderType.GetMethod("GetProperties", true);

			return this.var_getproperties_0_0;
						
						
		}
				
		private Method var_getnestedtypes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetNestedTypes()<para/>
		/// </summary>
		public Method GetMethod_GetNestedTypes()
		{
						
			if(this.var_getnestedtypes_0_0 == null)
				this.var_getnestedtypes_0_0 = this.builderType.GetMethod("GetNestedTypes", true);

			return this.var_getnestedtypes_0_0;
						
						
		}
				
		private Method var_getnestedtypes_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetNestedTypes(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getnestedtypes_0_1 == null)
				this.var_getnestedtypes_0_1 = this.builderType.GetMethod("GetNestedTypes", true, pbindingAttr).Import();
			
			return this.var_getnestedtypes_0_1;
						
		}
				
		private Method var_getnestedtype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetNestedType(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetNestedType(TypeReference pname)
		{
						
						
			if(this.var_getnestedtype_0_1 == null)
				this.var_getnestedtype_0_1 = this.builderType.GetMethod("GetNestedType", true, pname).Import();
			
			return this.var_getnestedtype_0_1;
						
		}
				
		private Method var_getnestedtype_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetNestedType(TypeReference pname, TypeReference pbindingAttr)
		{
						
						
			if(this.var_getnestedtype_0_2 == null)
				this.var_getnestedtype_0_2 = this.builderType.GetMethod("GetNestedType", true, pname, pbindingAttr).Import();
			
			return this.var_getnestedtype_0_2;
						
		}
				
		private Method var_getmember_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetMember(System.String)<para/>
		/// </summary>
		public Method GetMethod_GetMember(TypeReference pname)
		{
						
						
			if(this.var_getmember_0_1 == null)
				this.var_getmember_0_1 = this.builderType.GetMethod("GetMember", true, pname).Import();
			
			return this.var_getmember_0_1;
						
		}
				
		private Method var_getmember_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetMember(TypeReference pname, TypeReference pbindingAttr)
		{
						
						
			if(this.var_getmember_0_2 == null)
				this.var_getmember_0_2 = this.builderType.GetMethod("GetMember", true, pname, pbindingAttr).Import();
			
			return this.var_getmember_0_2;
						
		}
				
		private Method var_getmember_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetMember(TypeReference pname, TypeReference ptype, TypeReference pbindingAttr)
		{
						
						
			if(this.var_getmember_0_3 == null)
				this.var_getmember_0_3 = this.builderType.GetMethod("GetMember", true, pname, ptype, pbindingAttr).Import();
			
			return this.var_getmember_0_3;
						
		}
				
		private Method var_getmembers_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetMembers()<para/>
		/// </summary>
		public Method GetMethod_GetMembers()
		{
						
			if(this.var_getmembers_0_0 == null)
				this.var_getmembers_0_0 = this.builderType.GetMethod("GetMembers", true);

			return this.var_getmembers_0_0;
						
						
		}
				
		private Method var_getmembers_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)<para/>
		/// </summary>
		public Method GetMethod_GetMembers(TypeReference pbindingAttr)
		{
						
						
			if(this.var_getmembers_0_1 == null)
				this.var_getmembers_0_1 = this.builderType.GetMethod("GetMembers", true, pbindingAttr).Import();
			
			return this.var_getmembers_0_1;
						
		}
				
		private Method var_getdefaultmembers_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] GetDefaultMembers()<para/>
		/// </summary>
		public Method GetMethod_GetDefaultMembers()
		{
						
			if(this.var_getdefaultmembers_0_0 == null)
				this.var_getdefaultmembers_0_0 = this.builderType.GetMethod("GetDefaultMembers", true);

			return this.var_getdefaultmembers_0_0;
						
						
		}
				
		private Method var_findmembers_0_4;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)<para/>
		/// </summary>
		public Method GetMethod_FindMembers(TypeReference pmemberType, TypeReference pbindingAttr, TypeReference pfilter, TypeReference pfilterCriteria)
		{
						
						
			if(this.var_findmembers_0_4 == null)
				this.var_findmembers_0_4 = this.builderType.GetMethod("FindMembers", true, pmemberType, pbindingAttr, pfilter, pfilterCriteria).Import();
			
			return this.var_findmembers_0_4;
						
		}
				
		private Method var_get_isnested_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNested()<para/>
		/// </summary>
		public Method GetMethod_get_IsNested()
		{
						
			if(this.var_get_isnested_0_0 == null)
				this.var_get_isnested_0_0 = this.builderType.GetMethod("get_IsNested", true);

			return this.var_get_isnested_0_0;
						
						
		}
				
		private Method var_get_attributes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.TypeAttributes get_Attributes()<para/>
		/// </summary>
		public Method GetMethod_get_Attributes()
		{
						
			if(this.var_get_attributes_0_0 == null)
				this.var_get_attributes_0_0 = this.builderType.GetMethod("get_Attributes", true);

			return this.var_get_attributes_0_0;
						
						
		}
				
		private Method var_get_genericparameterattributes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.GenericParameterAttributes get_GenericParameterAttributes()<para/>
		/// </summary>
		public Method GetMethod_get_GenericParameterAttributes()
		{
						
			if(this.var_get_genericparameterattributes_0_0 == null)
				this.var_get_genericparameterattributes_0_0 = this.builderType.GetMethod("get_GenericParameterAttributes", true);

			return this.var_get_genericparameterattributes_0_0;
						
						
		}
				
		private Method var_get_isvisible_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsVisible()<para/>
		/// </summary>
		public Method GetMethod_get_IsVisible()
		{
						
			if(this.var_get_isvisible_0_0 == null)
				this.var_get_isvisible_0_0 = this.builderType.GetMethod("get_IsVisible", true);

			return this.var_get_isvisible_0_0;
						
						
		}
				
		private Method var_get_isnotpublic_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNotPublic()<para/>
		/// </summary>
		public Method GetMethod_get_IsNotPublic()
		{
						
			if(this.var_get_isnotpublic_0_0 == null)
				this.var_get_isnotpublic_0_0 = this.builderType.GetMethod("get_IsNotPublic", true);

			return this.var_get_isnotpublic_0_0;
						
						
		}
				
		private Method var_get_ispublic_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsPublic()<para/>
		/// </summary>
		public Method GetMethod_get_IsPublic()
		{
						
			if(this.var_get_ispublic_0_0 == null)
				this.var_get_ispublic_0_0 = this.builderType.GetMethod("get_IsPublic", true);

			return this.var_get_ispublic_0_0;
						
						
		}
				
		private Method var_get_isnestedpublic_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedPublic()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedPublic()
		{
						
			if(this.var_get_isnestedpublic_0_0 == null)
				this.var_get_isnestedpublic_0_0 = this.builderType.GetMethod("get_IsNestedPublic", true);

			return this.var_get_isnestedpublic_0_0;
						
						
		}
				
		private Method var_get_isnestedprivate_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedPrivate()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedPrivate()
		{
						
			if(this.var_get_isnestedprivate_0_0 == null)
				this.var_get_isnestedprivate_0_0 = this.builderType.GetMethod("get_IsNestedPrivate", true);

			return this.var_get_isnestedprivate_0_0;
						
						
		}
				
		private Method var_get_isnestedfamily_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedFamily()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedFamily()
		{
						
			if(this.var_get_isnestedfamily_0_0 == null)
				this.var_get_isnestedfamily_0_0 = this.builderType.GetMethod("get_IsNestedFamily", true);

			return this.var_get_isnestedfamily_0_0;
						
						
		}
				
		private Method var_get_isnestedassembly_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedAssembly()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedAssembly()
		{
						
			if(this.var_get_isnestedassembly_0_0 == null)
				this.var_get_isnestedassembly_0_0 = this.builderType.GetMethod("get_IsNestedAssembly", true);

			return this.var_get_isnestedassembly_0_0;
						
						
		}
				
		private Method var_get_isnestedfamandassem_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedFamANDAssem()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedFamANDAssem()
		{
						
			if(this.var_get_isnestedfamandassem_0_0 == null)
				this.var_get_isnestedfamandassem_0_0 = this.builderType.GetMethod("get_IsNestedFamANDAssem", true);

			return this.var_get_isnestedfamandassem_0_0;
						
						
		}
				
		private Method var_get_isnestedfamorassem_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsNestedFamORAssem()<para/>
		/// </summary>
		public Method GetMethod_get_IsNestedFamORAssem()
		{
						
			if(this.var_get_isnestedfamorassem_0_0 == null)
				this.var_get_isnestedfamorassem_0_0 = this.builderType.GetMethod("get_IsNestedFamORAssem", true);

			return this.var_get_isnestedfamorassem_0_0;
						
						
		}
				
		private Method var_get_isautolayout_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAutoLayout()<para/>
		/// </summary>
		public Method GetMethod_get_IsAutoLayout()
		{
						
			if(this.var_get_isautolayout_0_0 == null)
				this.var_get_isautolayout_0_0 = this.builderType.GetMethod("get_IsAutoLayout", true);

			return this.var_get_isautolayout_0_0;
						
						
		}
				
		private Method var_get_islayoutsequential_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsLayoutSequential()<para/>
		/// </summary>
		public Method GetMethod_get_IsLayoutSequential()
		{
						
			if(this.var_get_islayoutsequential_0_0 == null)
				this.var_get_islayoutsequential_0_0 = this.builderType.GetMethod("get_IsLayoutSequential", true);

			return this.var_get_islayoutsequential_0_0;
						
						
		}
				
		private Method var_get_isexplicitlayout_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsExplicitLayout()<para/>
		/// </summary>
		public Method GetMethod_get_IsExplicitLayout()
		{
						
			if(this.var_get_isexplicitlayout_0_0 == null)
				this.var_get_isexplicitlayout_0_0 = this.builderType.GetMethod("get_IsExplicitLayout", true);

			return this.var_get_isexplicitlayout_0_0;
						
						
		}
				
		private Method var_get_isclass_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsClass()<para/>
		/// </summary>
		public Method GetMethod_get_IsClass()
		{
						
			if(this.var_get_isclass_0_0 == null)
				this.var_get_isclass_0_0 = this.builderType.GetMethod("get_IsClass", true);

			return this.var_get_isclass_0_0;
						
						
		}
				
		private Method var_get_isinterface_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsInterface()<para/>
		/// </summary>
		public Method GetMethod_get_IsInterface()
		{
						
			if(this.var_get_isinterface_0_0 == null)
				this.var_get_isinterface_0_0 = this.builderType.GetMethod("get_IsInterface", true);

			return this.var_get_isinterface_0_0;
						
						
		}
				
		private Method var_get_isvaluetype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsValueType()<para/>
		/// </summary>
		public Method GetMethod_get_IsValueType()
		{
						
			if(this.var_get_isvaluetype_0_0 == null)
				this.var_get_isvaluetype_0_0 = this.builderType.GetMethod("get_IsValueType", true);

			return this.var_get_isvaluetype_0_0;
						
						
		}
				
		private Method var_get_isabstract_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAbstract()<para/>
		/// </summary>
		public Method GetMethod_get_IsAbstract()
		{
						
			if(this.var_get_isabstract_0_0 == null)
				this.var_get_isabstract_0_0 = this.builderType.GetMethod("get_IsAbstract", true);

			return this.var_get_isabstract_0_0;
						
						
		}
				
		private Method var_get_issealed_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSealed()<para/>
		/// </summary>
		public Method GetMethod_get_IsSealed()
		{
						
			if(this.var_get_issealed_0_0 == null)
				this.var_get_issealed_0_0 = this.builderType.GetMethod("get_IsSealed", true);

			return this.var_get_issealed_0_0;
						
						
		}
				
		private Method var_get_isenum_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsEnum()<para/>
		/// </summary>
		public Method GetMethod_get_IsEnum()
		{
						
			if(this.var_get_isenum_0_0 == null)
				this.var_get_isenum_0_0 = this.builderType.GetMethod("get_IsEnum", true);

			return this.var_get_isenum_0_0;
						
						
		}
				
		private Method var_get_isspecialname_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSpecialName()<para/>
		/// </summary>
		public Method GetMethod_get_IsSpecialName()
		{
						
			if(this.var_get_isspecialname_0_0 == null)
				this.var_get_isspecialname_0_0 = this.builderType.GetMethod("get_IsSpecialName", true);

			return this.var_get_isspecialname_0_0;
						
						
		}
				
		private Method var_get_isimport_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsImport()<para/>
		/// </summary>
		public Method GetMethod_get_IsImport()
		{
						
			if(this.var_get_isimport_0_0 == null)
				this.var_get_isimport_0_0 = this.builderType.GetMethod("get_IsImport", true);

			return this.var_get_isimport_0_0;
						
						
		}
				
		private Method var_get_isserializable_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSerializable()<para/>
		/// </summary>
		public Method GetMethod_get_IsSerializable()
		{
						
			if(this.var_get_isserializable_0_0 == null)
				this.var_get_isserializable_0_0 = this.builderType.GetMethod("get_IsSerializable", true);

			return this.var_get_isserializable_0_0;
						
						
		}
				
		private Method var_get_isansiclass_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAnsiClass()<para/>
		/// </summary>
		public Method GetMethod_get_IsAnsiClass()
		{
						
			if(this.var_get_isansiclass_0_0 == null)
				this.var_get_isansiclass_0_0 = this.builderType.GetMethod("get_IsAnsiClass", true);

			return this.var_get_isansiclass_0_0;
						
						
		}
				
		private Method var_get_isunicodeclass_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsUnicodeClass()<para/>
		/// </summary>
		public Method GetMethod_get_IsUnicodeClass()
		{
						
			if(this.var_get_isunicodeclass_0_0 == null)
				this.var_get_isunicodeclass_0_0 = this.builderType.GetMethod("get_IsUnicodeClass", true);

			return this.var_get_isunicodeclass_0_0;
						
						
		}
				
		private Method var_get_isautoclass_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsAutoClass()<para/>
		/// </summary>
		public Method GetMethod_get_IsAutoClass()
		{
						
			if(this.var_get_isautoclass_0_0 == null)
				this.var_get_isautoclass_0_0 = this.builderType.GetMethod("get_IsAutoClass", true);

			return this.var_get_isautoclass_0_0;
						
						
		}
				
		private Method var_get_isarray_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsArray()<para/>
		/// </summary>
		public Method GetMethod_get_IsArray()
		{
						
			if(this.var_get_isarray_0_0 == null)
				this.var_get_isarray_0_0 = this.builderType.GetMethod("get_IsArray", true);

			return this.var_get_isarray_0_0;
						
						
		}
				
		private Method var_get_isgenerictype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsGenericType()<para/>
		/// </summary>
		public Method GetMethod_get_IsGenericType()
		{
						
			if(this.var_get_isgenerictype_0_0 == null)
				this.var_get_isgenerictype_0_0 = this.builderType.GetMethod("get_IsGenericType", true);

			return this.var_get_isgenerictype_0_0;
						
						
		}
				
		private Method var_get_isgenerictypedefinition_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsGenericTypeDefinition()<para/>
		/// </summary>
		public Method GetMethod_get_IsGenericTypeDefinition()
		{
						
			if(this.var_get_isgenerictypedefinition_0_0 == null)
				this.var_get_isgenerictypedefinition_0_0 = this.builderType.GetMethod("get_IsGenericTypeDefinition", true);

			return this.var_get_isgenerictypedefinition_0_0;
						
						
		}
				
		private Method var_get_isconstructedgenerictype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsConstructedGenericType()<para/>
		/// </summary>
		public Method GetMethod_get_IsConstructedGenericType()
		{
						
			if(this.var_get_isconstructedgenerictype_0_0 == null)
				this.var_get_isconstructedgenerictype_0_0 = this.builderType.GetMethod("get_IsConstructedGenericType", true);

			return this.var_get_isconstructedgenerictype_0_0;
						
						
		}
				
		private Method var_get_isgenericparameter_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsGenericParameter()<para/>
		/// </summary>
		public Method GetMethod_get_IsGenericParameter()
		{
						
			if(this.var_get_isgenericparameter_0_0 == null)
				this.var_get_isgenericparameter_0_0 = this.builderType.GetMethod("get_IsGenericParameter", true);

			return this.var_get_isgenericparameter_0_0;
						
						
		}
				
		private Method var_get_genericparameterposition_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_GenericParameterPosition()<para/>
		/// </summary>
		public Method GetMethod_get_GenericParameterPosition()
		{
						
			if(this.var_get_genericparameterposition_0_0 == null)
				this.var_get_genericparameterposition_0_0 = this.builderType.GetMethod("get_GenericParameterPosition", true);

			return this.var_get_genericparameterposition_0_0;
						
						
		}
				
		private Method var_get_containsgenericparameters_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_ContainsGenericParameters()<para/>
		/// </summary>
		public Method GetMethod_get_ContainsGenericParameters()
		{
						
			if(this.var_get_containsgenericparameters_0_0 == null)
				this.var_get_containsgenericparameters_0_0 = this.builderType.GetMethod("get_ContainsGenericParameters", true);

			return this.var_get_containsgenericparameters_0_0;
						
						
		}
				
		private Method var_getgenericparameterconstraints_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetGenericParameterConstraints()<para/>
		/// </summary>
		public Method GetMethod_GetGenericParameterConstraints()
		{
						
			if(this.var_getgenericparameterconstraints_0_0 == null)
				this.var_getgenericparameterconstraints_0_0 = this.builderType.GetMethod("GetGenericParameterConstraints", true);

			return this.var_getgenericparameterconstraints_0_0;
						
						
		}
				
		private Method var_get_isbyref_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsByRef()<para/>
		/// </summary>
		public Method GetMethod_get_IsByRef()
		{
						
			if(this.var_get_isbyref_0_0 == null)
				this.var_get_isbyref_0_0 = this.builderType.GetMethod("get_IsByRef", true);

			return this.var_get_isbyref_0_0;
						
						
		}
				
		private Method var_get_ispointer_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsPointer()<para/>
		/// </summary>
		public Method GetMethod_get_IsPointer()
		{
						
			if(this.var_get_ispointer_0_0 == null)
				this.var_get_ispointer_0_0 = this.builderType.GetMethod("get_IsPointer", true);

			return this.var_get_ispointer_0_0;
						
						
		}
				
		private Method var_get_isprimitive_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsPrimitive()<para/>
		/// </summary>
		public Method GetMethod_get_IsPrimitive()
		{
						
			if(this.var_get_isprimitive_0_0 == null)
				this.var_get_isprimitive_0_0 = this.builderType.GetMethod("get_IsPrimitive", true);

			return this.var_get_isprimitive_0_0;
						
						
		}
				
		private Method var_get_iscomobject_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsCOMObject()<para/>
		/// </summary>
		public Method GetMethod_get_IsCOMObject()
		{
						
			if(this.var_get_iscomobject_0_0 == null)
				this.var_get_iscomobject_0_0 = this.builderType.GetMethod("get_IsCOMObject", true);

			return this.var_get_iscomobject_0_0;
						
						
		}
				
		private Method var_get_haselementtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_HasElementType()<para/>
		/// </summary>
		public Method GetMethod_get_HasElementType()
		{
						
			if(this.var_get_haselementtype_0_0 == null)
				this.var_get_haselementtype_0_0 = this.builderType.GetMethod("get_HasElementType", true);

			return this.var_get_haselementtype_0_0;
						
						
		}
				
		private Method var_get_iscontextful_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsContextful()<para/>
		/// </summary>
		public Method GetMethod_get_IsContextful()
		{
						
			if(this.var_get_iscontextful_0_0 == null)
				this.var_get_iscontextful_0_0 = this.builderType.GetMethod("get_IsContextful", true);

			return this.var_get_iscontextful_0_0;
						
						
		}
				
		private Method var_get_ismarshalbyref_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsMarshalByRef()<para/>
		/// </summary>
		public Method GetMethod_get_IsMarshalByRef()
		{
						
			if(this.var_get_ismarshalbyref_0_0 == null)
				this.var_get_ismarshalbyref_0_0 = this.builderType.GetMethod("get_IsMarshalByRef", true);

			return this.var_get_ismarshalbyref_0_0;
						
						
		}
				
		private Method var_makegenerictype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type MakeGenericType(System.Type[])<para/>
		/// </summary>
		public Method GetMethod_MakeGenericType(TypeReference ptypeArguments)
		{
						
						
			if(this.var_makegenerictype_0_1 == null)
				this.var_makegenerictype_0_1 = this.builderType.GetMethod("MakeGenericType", true, ptypeArguments).Import();
			
			return this.var_makegenerictype_0_1;
						
		}
				
		private Method var_getelementtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetElementType()<para/>
		/// </summary>
		public Method GetMethod_GetElementType()
		{
						
			if(this.var_getelementtype_0_0 == null)
				this.var_getelementtype_0_0 = this.builderType.GetMethod("GetElementType", true);

			return this.var_getelementtype_0_0;
						
						
		}
				
		private Method var_getgenericarguments_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetGenericArguments()<para/>
		/// </summary>
		public Method GetMethod_GetGenericArguments()
		{
						
			if(this.var_getgenericarguments_0_0 == null)
				this.var_getgenericarguments_0_0 = this.builderType.GetMethod("GetGenericArguments", true);

			return this.var_getgenericarguments_0_0;
						
						
		}
				
		private Method var_get_generictypearguments_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] get_GenericTypeArguments()<para/>
		/// </summary>
		public Method GetMethod_get_GenericTypeArguments()
		{
						
			if(this.var_get_generictypearguments_0_0 == null)
				this.var_get_generictypearguments_0_0 = this.builderType.GetMethod("get_GenericTypeArguments", true);

			return this.var_get_generictypearguments_0_0;
						
						
		}
				
		private Method var_getgenerictypedefinition_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetGenericTypeDefinition()<para/>
		/// </summary>
		public Method GetMethod_GetGenericTypeDefinition()
		{
						
			if(this.var_getgenerictypedefinition_0_0 == null)
				this.var_getgenerictypedefinition_0_0 = this.builderType.GetMethod("GetGenericTypeDefinition", true);

			return this.var_getgenerictypedefinition_0_0;
						
						
		}
				
		private Method var_getenumnames_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String[] GetEnumNames()<para/>
		/// </summary>
		public Method GetMethod_GetEnumNames()
		{
						
			if(this.var_getenumnames_0_0 == null)
				this.var_getenumnames_0_0 = this.builderType.GetMethod("GetEnumNames", true);

			return this.var_getenumnames_0_0;
						
						
		}
				
		private Method var_getenumvalues_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Array GetEnumValues()<para/>
		/// </summary>
		public Method GetMethod_GetEnumValues()
		{
						
			if(this.var_getenumvalues_0_0 == null)
				this.var_getenumvalues_0_0 = this.builderType.GetMethod("GetEnumValues", true);

			return this.var_getenumvalues_0_0;
						
						
		}
				
		private Method var_getenumunderlyingtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetEnumUnderlyingType()<para/>
		/// </summary>
		public Method GetMethod_GetEnumUnderlyingType()
		{
						
			if(this.var_getenumunderlyingtype_0_0 == null)
				this.var_getenumunderlyingtype_0_0 = this.builderType.GetMethod("GetEnumUnderlyingType", true);

			return this.var_getenumunderlyingtype_0_0;
						
						
		}
				
		private Method var_isenumdefined_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsEnumDefined(System.Object)<para/>
		/// </summary>
		public Method GetMethod_IsEnumDefined(TypeReference pvalue)
		{
						
						
			if(this.var_isenumdefined_0_1 == null)
				this.var_isenumdefined_0_1 = this.builderType.GetMethod("IsEnumDefined", true, pvalue).Import();
			
			return this.var_isenumdefined_0_1;
						
		}
				
		private Method var_getenumname_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String GetEnumName(System.Object)<para/>
		/// </summary>
		public Method GetMethod_GetEnumName(TypeReference pvalue)
		{
						
						
			if(this.var_getenumname_0_1 == null)
				this.var_getenumname_0_1 = this.builderType.GetMethod("GetEnumName", true, pvalue).Import();
			
			return this.var_getenumname_0_1;
						
		}
				
		private Method var_get_issecuritycritical_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecurityCritical()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecurityCritical()
		{
						
			if(this.var_get_issecuritycritical_0_0 == null)
				this.var_get_issecuritycritical_0_0 = this.builderType.GetMethod("get_IsSecurityCritical", true);

			return this.var_get_issecuritycritical_0_0;
						
						
		}
				
		private Method var_get_issecuritysafecritical_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecuritySafeCritical()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecuritySafeCritical()
		{
						
			if(this.var_get_issecuritysafecritical_0_0 == null)
				this.var_get_issecuritysafecritical_0_0 = this.builderType.GetMethod("get_IsSecuritySafeCritical", true);

			return this.var_get_issecuritysafecritical_0_0;
						
						
		}
				
		private Method var_get_issecuritytransparent_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean get_IsSecurityTransparent()<para/>
		/// </summary>
		public Method GetMethod_get_IsSecurityTransparent()
		{
						
			if(this.var_get_issecuritytransparent_0_0 == null)
				this.var_get_issecuritytransparent_0_0 = this.builderType.GetMethod("get_IsSecurityTransparent", true);

			return this.var_get_issecuritytransparent_0_0;
						
						
		}
				
		private Method var_get_underlyingsystemtype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type get_UnderlyingSystemType()<para/>
		/// </summary>
		public Method GetMethod_get_UnderlyingSystemType()
		{
						
			if(this.var_get_underlyingsystemtype_0_0 == null)
				this.var_get_underlyingsystemtype_0_0 = this.builderType.GetMethod("get_UnderlyingSystemType", true);

			return this.var_get_underlyingsystemtype_0_0;
						
						
		}
				
		private Method var_issubclassof_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsSubclassOf(System.Type)<para/>
		/// </summary>
		public Method GetMethod_IsSubclassOf(TypeReference pc)
		{
						
						
			if(this.var_issubclassof_0_1 == null)
				this.var_issubclassof_0_1 = this.builderType.GetMethod("IsSubclassOf", true, pc).Import();
			
			return this.var_issubclassof_0_1;
						
		}
				
		private Method var_isinstanceoftype_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsInstanceOfType(System.Object)<para/>
		/// </summary>
		public Method GetMethod_IsInstanceOfType(TypeReference po)
		{
						
						
			if(this.var_isinstanceoftype_0_1 == null)
				this.var_isinstanceoftype_0_1 = this.builderType.GetMethod("IsInstanceOfType", true, po).Import();
			
			return this.var_isinstanceoftype_0_1;
						
		}
				
		private Method var_isassignablefrom_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsAssignableFrom(System.Type)<para/>
		/// </summary>
		public Method GetMethod_IsAssignableFrom(TypeReference pc)
		{
						
						
			if(this.var_isassignablefrom_0_1 == null)
				this.var_isassignablefrom_0_1 = this.builderType.GetMethod("IsAssignableFrom", true, pc).Import();
			
			return this.var_isassignablefrom_0_1;
						
		}
				
		private Method var_isequivalentto_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsEquivalentTo(System.Type)<para/>
		/// </summary>
		public Method GetMethod_IsEquivalentTo(TypeReference pother)
		{
						
						
			if(this.var_isequivalentto_0_1 == null)
				this.var_isequivalentto_0_1 = this.builderType.GetMethod("IsEquivalentTo", true, pother).Import();
			
			return this.var_isequivalentto_0_1;
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_gettypearray_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type[] GetTypeArray(System.Object[])<para/>
		/// </summary>
		public Method GetMethod_GetTypeArray(TypeReference pargs)
		{
						
						
			if(this.var_gettypearray_0_1 == null)
				this.var_gettypearray_0_1 = this.builderType.GetMethod("GetTypeArray", true, pargs).Import();
			
			return this.var_gettypearray_0_1;
						
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(System.Type)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference po)
		{
						
						
			if(typeof(System.Object).AreEqual(po))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, po).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.Type).AreEqual(po))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, po).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(System.Type, System.Type)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pleft, pright).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(System.Type, System.Type)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pleft, TypeReference pright)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pleft, pright).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_getinterfacemap_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)<para/>
		/// </summary>
		public Method GetMethod_GetInterfaceMap(TypeReference pinterfaceType)
		{
						
						
			if(this.var_getinterfacemap_0_1 == null)
				this.var_getinterfacemap_0_1 = this.builderType.GetMethod("GetInterfaceMap", true, pinterfaceType).Import();
			
			return this.var_getinterfacemap_0_1;
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
				
		private Method var_get_name_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String get_Name()<para/>
		/// </summary>
		public Method GetMethod_get_Name()
		{
						
			if(this.var_get_name_0_0 == null)
				this.var_get_name_0_0 = this.builderType.GetMethod("get_Name", true);

			return this.var_get_name_0_0;
						
						
		}
				
		private Method var_get_customattributes_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] get_CustomAttributes()<para/>
		/// </summary>
		public Method GetMethod_get_CustomAttributes()
		{
						
			if(this.var_get_customattributes_0_0 == null)
				this.var_get_customattributes_0_0 = this.builderType.GetMethod("get_CustomAttributes", true);

			return this.var_get_customattributes_0_0;
						
						
		}
				
		private Method var_getcustomattributes_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object[] GetCustomAttributes(Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributes(TypeReference pinherit)
		{
						
						
			if(this.var_getcustomattributes_0_1 == null)
				this.var_getcustomattributes_0_1 = this.builderType.GetMethod("GetCustomAttributes", true, pinherit).Import();
			
			return this.var_getcustomattributes_0_1;
						
		}
				
		private Method var_getcustomattributes_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributes(TypeReference pattributeType, TypeReference pinherit)
		{
						
						
			if(this.var_getcustomattributes_0_2 == null)
				this.var_getcustomattributes_0_2 = this.builderType.GetMethod("GetCustomAttributes", true, pattributeType, pinherit).Import();
			
			return this.var_getcustomattributes_0_2;
						
		}
				
		private Method var_isdefined_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean IsDefined(System.Type, Boolean)<para/>
		/// </summary>
		public Method GetMethod_IsDefined(TypeReference pattributeType, TypeReference pinherit)
		{
						
						
			if(this.var_isdefined_0_2 == null)
				this.var_isdefined_0_2 = this.builderType.GetMethod("IsDefined", true, pattributeType, pinherit).Import();
			
			return this.var_isdefined_0_2;
						
		}
				
		private Method var_getcustomattributesdata_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()<para/>
		/// </summary>
		public Method GetMethod_GetCustomAttributesData()
		{
						
			if(this.var_getcustomattributesdata_0_0 == null)
				this.var_getcustomattributesdata_0_0 = this.builderType.GetMethod("GetCustomAttributesData", true);

			return this.var_getcustomattributesdata_0_0;
						
						
		}
				
		private Method var_get_metadatatoken_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_MetadataToken()<para/>
		/// </summary>
		public Method GetMethod_get_MetadataToken()
		{
						
			if(this.var_get_metadatatoken_0_0 == null)
				this.var_get_metadatatoken_0_0 = this.builderType.GetMethod("get_MetadataToken", true);

			return this.var_get_metadatatoken_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.UInt16"/>
    /// </summary>
    public partial class BuilderTypeUInt16 : TypeSystemExBase
	{
        internal BuilderTypeUInt16(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeUInt16 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeUInt16 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(UInt16)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(UInt16)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.UInt16).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// UInt16 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt16 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.UInt32"/>
    /// </summary>
    public partial class BuilderTypeUInt32 : TypeSystemExBase
	{
        internal BuilderTypeUInt32(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeUInt32 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeUInt32 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(UInt32)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(UInt32)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.UInt32).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// UInt32 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.UInt64"/>
    /// </summary>
    public partial class BuilderTypeUInt64 : TypeSystemExBase
	{
        internal BuilderTypeUInt64(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeUInt64 value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeUInt64 value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_compareto_0_1;
				
		private Method var_compareto_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 CompareTo(System.Object)<para/>
		/// Int32 CompareTo(UInt64)<para/>
		/// </summary>
		public Method GetMethod_CompareTo(TypeReference pvalue)
		{
						
						
			if(typeof(System.Object).AreEqual(pvalue))
			{
				if(this.var_compareto_0_1 == null)
					this.var_compareto_0_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_0_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_compareto_1_1 == null)
					this.var_compareto_1_1 = this.builderType.GetMethod("CompareTo", true, pvalue).Import();
			
				return this.var_compareto_1_1;
			}
			
			return null;
			
		}
				
		private Method var_equals_0_1;
				
		private Method var_equals_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// Boolean Equals(UInt64)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(typeof(System.Object).AreEqual(pobj))
			{
				if(this.var_equals_0_1 == null)
					this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_0_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pobj))
			{
				if(this.var_equals_1_1 == null)
					this.var_equals_1_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
				return this.var_equals_1_1;
			}
			
			return null;
			
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_tostring_0_1;
				
		private Method var_tostring_1_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.IFormatProvider)<para/>
		/// System.String ToString(System.String)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pprovider)
		{
						
						
			if(typeof(System.IFormatProvider).AreEqual(pprovider))
			{
				if(this.var_tostring_0_1 == null)
					this.var_tostring_0_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_0_1;
			}
			
			if(typeof(System.String).AreEqual(pprovider))
			{
				if(this.var_tostring_1_1 == null)
					this.var_tostring_1_1 = this.builderType.GetMethod("ToString", true, pprovider).Import();
			
				return this.var_tostring_1_1;
			}
			
			return null;
			
		}
				
		private Method var_tostring_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_ToString(TypeReference pformat, TypeReference pprovider)
		{
						
						
			if(this.var_tostring_0_2 == null)
				this.var_tostring_0_2 = this.builderType.GetMethod("ToString", true, pformat, pprovider).Import();
			
			return this.var_tostring_0_2;
						
		}
				
		private Method var_parse_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 Parse(System.String)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps)
		{
						
						
			if(this.var_parse_0_1 == null)
				this.var_parse_0_1 = this.builderType.GetMethod("Parse", true, ps).Import();
			
			return this.var_parse_0_1;
						
		}
				
		private Method var_parse_0_2;
				
		private Method var_parse_1_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 Parse(System.String, System.Globalization.NumberStyles)<para/>
		/// UInt64 Parse(System.String, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle)
		{
						
						
			if(typeof(System.String).AreEqual(ps) && typeof(System.Globalization.NumberStyles).AreEqual(pstyle))
			{
				if(this.var_parse_0_2 == null)
					this.var_parse_0_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_0_2;
			}
			
			if(typeof(System.String).AreEqual(ps) && typeof(System.IFormatProvider).AreEqual(pstyle))
			{
				if(this.var_parse_1_2 == null)
					this.var_parse_1_2 = this.builderType.GetMethod("Parse", true, ps, pstyle).Import();
			
				return this.var_parse_1_2;
			}
			
			return null;
			
		}
				
		private Method var_parse_0_3;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)<para/>
		/// </summary>
		public Method GetMethod_Parse(TypeReference ps, TypeReference pstyle, TypeReference pprovider)
		{
						
						
			if(this.var_parse_0_3 == null)
				this.var_parse_0_3 = this.builderType.GetMethod("Parse", true, ps, pstyle, pprovider).Import();
			
			return this.var_parse_0_3;
						
		}
				
		private Method var_gettypecode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.TypeCode GetTypeCode()<para/>
		/// </summary>
		public Method GetMethod_GetTypeCode()
		{
						
			if(this.var_gettypecode_0_0 == null)
				this.var_gettypecode_0_0 = this.builderType.GetMethod("GetTypeCode", true);

			return this.var_gettypecode_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

			
    /// <summary>
    /// Provides a wrapper class for <see cref="System.UIntPtr"/>
    /// </summary>
    public partial class BuilderTypeUIntPtr : TypeSystemExBase
	{
        internal BuilderTypeUIntPtr(BuilderType builderType) : base(builderType)
		{
		}

		/// <exclude />
		public static implicit operator BuilderType(BuilderTypeUIntPtr value) => value.builderType;
		
		/// <exclude />
		public static implicit operator TypeReference(BuilderTypeUIntPtr value) => value.builderType.typeReference;

		/// <exclude />
		public BuilderType BuilderType => this.builderType;
		
				
		private Method var_equals_0_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean Equals(System.Object)<para/>
		/// </summary>
		public Method GetMethod_Equals(TypeReference pobj)
		{
						
						
			if(this.var_equals_0_1 == null)
				this.var_equals_0_1 = this.builderType.GetMethod("Equals", true, pobj).Import();
			
			return this.var_equals_0_1;
						
		}
				
		private Method var_gethashcode_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 GetHashCode()<para/>
		/// </summary>
		public Method GetMethod_GetHashCode()
		{
						
			if(this.var_gethashcode_0_0 == null)
				this.var_gethashcode_0_0 = this.builderType.GetMethod("GetHashCode", true);

			return this.var_gethashcode_0_0;
						
						
		}
				
		private Method var_touint32_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt32 ToUInt32()<para/>
		/// </summary>
		public Method GetMethod_ToUInt32()
		{
						
			if(this.var_touint32_0_0 == null)
				this.var_touint32_0_0 = this.builderType.GetMethod("ToUInt32", true);

			return this.var_touint32_0_0;
						
						
		}
				
		private Method var_touint64_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UInt64 ToUInt64()<para/>
		/// </summary>
		public Method GetMethod_ToUInt64()
		{
						
			if(this.var_touint64_0_0 == null)
				this.var_touint64_0_0 = this.builderType.GetMethod("ToUInt64", true);

			return this.var_touint64_0_0;
						
						
		}
				
		private Method var_tostring_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.String ToString()<para/>
		/// </summary>
		public Method GetMethod_ToString()
		{
						
			if(this.var_tostring_0_0 == null)
				this.var_tostring_0_0 = this.builderType.GetMethod("ToString", true);

			return this.var_tostring_0_0;
						
						
		}
				
		private Method var_op_explicit_0_1;
				
		private Method var_op_explicit_1_1;
				
		private Method var_op_explicit_2_1;
				
		private Method var_op_explicit_3_1;
				
		private Method var_op_explicit_4_1;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UIntPtr op_Explicit(UInt32)<para/>
		/// UIntPtr op_Explicit(UInt64)<para/>
		/// UInt32 op_Explicit(UIntPtr)<para/>
		/// UInt64 op_Explicit(UIntPtr)<para/>
		/// Void* op_Explicit(UIntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Explicit(TypeReference pvalue)
		{
						
						
			if(typeof(System.UInt32).AreEqual(pvalue))
			{
				if(this.var_op_explicit_0_1 == null)
					this.var_op_explicit_0_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_0_1;
			}
			
			if(typeof(System.UInt64).AreEqual(pvalue))
			{
				if(this.var_op_explicit_1_1 == null)
					this.var_op_explicit_1_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_1_1;
			}
			
			if(typeof(System.UIntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_2_1 == null)
					this.var_op_explicit_2_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_2_1;
			}
			
			if(typeof(System.UIntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_3_1 == null)
					this.var_op_explicit_3_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_3_1;
			}
			
			if(typeof(System.UIntPtr).AreEqual(pvalue))
			{
				if(this.var_op_explicit_4_1 == null)
					this.var_op_explicit_4_1 = this.builderType.GetMethod("op_Explicit", true, pvalue).Import();
			
				return this.var_op_explicit_4_1;
			}
			
			return null;
			
		}
				
		private Method var_op_equality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Equality(UIntPtr, UIntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Equality(TypeReference pvalue1, TypeReference pvalue2)
		{
						
						
			if(this.var_op_equality_0_2 == null)
				this.var_op_equality_0_2 = this.builderType.GetMethod("op_Equality", true, pvalue1, pvalue2).Import();
			
			return this.var_op_equality_0_2;
						
		}
				
		private Method var_op_inequality_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Boolean op_Inequality(UIntPtr, UIntPtr)<para/>
		/// </summary>
		public Method GetMethod_op_Inequality(TypeReference pvalue1, TypeReference pvalue2)
		{
						
						
			if(this.var_op_inequality_0_2 == null)
				this.var_op_inequality_0_2 = this.builderType.GetMethod("op_Inequality", true, pvalue1, pvalue2).Import();
			
			return this.var_op_inequality_0_2;
						
		}
				
		private Method var_add_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UIntPtr Add(UIntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_Add(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_add_0_2 == null)
				this.var_add_0_2 = this.builderType.GetMethod("Add", true, ppointer, poffset).Import();
			
			return this.var_add_0_2;
						
		}
				
		private Method var_op_addition_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UIntPtr op_Addition(UIntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_op_Addition(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_op_addition_0_2 == null)
				this.var_op_addition_0_2 = this.builderType.GetMethod("op_Addition", true, ppointer, poffset).Import();
			
			return this.var_op_addition_0_2;
						
		}
				
		private Method var_subtract_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UIntPtr Subtract(UIntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_Subtract(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_subtract_0_2 == null)
				this.var_subtract_0_2 = this.builderType.GetMethod("Subtract", true, ppointer, poffset).Import();
			
			return this.var_subtract_0_2;
						
		}
				
		private Method var_op_subtraction_0_2;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// UIntPtr op_Subtraction(UIntPtr, Int32)<para/>
		/// </summary>
		public Method GetMethod_op_Subtraction(TypeReference ppointer, TypeReference poffset)
		{
						
						
			if(this.var_op_subtraction_0_2 == null)
				this.var_op_subtraction_0_2 = this.builderType.GetMethod("op_Subtraction", true, ppointer, poffset).Import();
			
			return this.var_op_subtraction_0_2;
						
		}
				
		private Method var_get_size_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Int32 get_Size()<para/>
		/// </summary>
		public Method GetMethod_get_Size()
		{
						
			if(this.var_get_size_0_0 == null)
				this.var_get_size_0_0 = this.builderType.GetMethod("get_Size", true);

			return this.var_get_size_0_0;
						
						
		}
				
		private Method var_topointer_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// Void* ToPointer()<para/>
		/// </summary>
		public Method GetMethod_ToPointer()
		{
						
			if(this.var_topointer_0_0 == null)
				this.var_topointer_0_0 = this.builderType.GetMethod("ToPointer", true);

			return this.var_topointer_0_0;
						
						
		}
				
		private Method var_gettype_0_0;
		
		/// <summary>
		/// Represents the following method:
		/// <para />
		/// System.Type GetType()<para/>
		/// </summary>
		public Method GetMethod_GetType()
		{
						
			if(this.var_gettype_0_0 == null)
				this.var_gettype_0_0 = this.builderType.GetMethod("GetType", true);

			return this.var_gettype_0_0;
						
						
		}
		
	}

	}

