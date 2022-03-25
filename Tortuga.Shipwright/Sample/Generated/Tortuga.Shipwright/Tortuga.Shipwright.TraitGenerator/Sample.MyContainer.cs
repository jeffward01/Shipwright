﻿//This file was generated by Tortuga Shipwright

namespace Sample
{
	partial class MyContainer: Sample.IMath, Sample.IHasPets
	{

		private bool __TraitsRegistered;

		// These fields and/or properties hold the traits. They should not be referenced directly.
		private Sample.MyTrait ___Trait0 = new();
		private Sample.MyTrait __Trait0
		{
			get
			{
				if (!__TraitsRegistered) __RegisterTraits();
				return ___Trait0;
			}
		}

		// Explicit interface implementation Sample.IMath
		System.Int32 Sample.IMath.Add(System.Int32 a, System.Int32 b)
		{
			return ((Sample.IMath)__Trait0).Add(a, b);
		}

		
		System.Int32 Sample.IMath.BaseValue
		{
			get => ((Sample.IMath)__Trait0).BaseValue;
			set => ((Sample.IMath)__Trait0).BaseValue = value;
		}
		
		System.Int32 Sample.IMath.Counter
		{
			get => ((Sample.IMath)__Trait0).Counter;
			set => ((Sample.IMath)__Trait0).Counter = value;
		}
		event System.EventHandler<System.EventArgs>? Sample.IMath.ValueChanged
		{
			add { ((Sample.IMath)__Trait0).ValueChanged += value;}
			remove { ((Sample.IMath)__Trait0).ValueChanged -= value;}
		}
		// Exposing trait Sample.MyTrait

		
		public System.String AllPets()
		{
			return __Trait0.AllPets();
		}

		/// <summary>
		/// Gets or sets the counter.
		/// </summary>
		/// <value>The counter.</value>
		/// <remarks>This should be copied from the trait to the container.</remarks>
		public   System.Int32 Counter
		{
			get => __Trait0.Counter;
			set => __Trait0.Counter = value;
		}
		
		public   System.String Name
		{
			get => __Trait0.Name;
		}
		
		[System.Obsolete]
		public   System.Boolean OldMethodA
		{
			get => __Trait0.OldMethodA;
			set => __Trait0.OldMethodA = value;
		}
		
		[System.Obsolete(@"This is a message")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Always)]
		public   System.Boolean OldMethodB
		{
			get => __Trait0.OldMethodB;
			set => __Trait0.OldMethodB = value;
		}
		
		[System.Obsolete(@"This is a
 message with ""quotes""", true)]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		public   System.Boolean OldMethodC
		{
			get => __Trait0.OldMethodC;
			set => __Trait0.OldMethodC = value;
		}
		
		public event System.EventHandler<System.EventArgs>? ValueChanged
		{
			add { __Trait0.ValueChanged += value;}
			remove { __Trait0.ValueChanged -= value;}
		}
		private partial System.String OnGetName( );

		private void __RegisterTraits()
		{
			__TraitsRegistered = true;
			__Trait0.OnGetName = OnGetName;
			__Trait0.Container = this;
			__Trait0.CustomerKeyProvider = this as Sample.IHasCustomerKey;
		}

	}
}
