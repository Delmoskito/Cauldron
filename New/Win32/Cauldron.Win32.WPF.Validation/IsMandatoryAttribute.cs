﻿using Cauldron.Core.Collections;
using Cauldron.XAML.Validation.ViewModels;
using System;
using System.Collections;
using System.Reflection;
using System.Security;
using System.Threading.Tasks;

namespace Cauldron.XAML.Validation
{
    /// <summary>
    /// Validates a property for mandatory value.
    /// <para/>
    /// Value is null or empty will cause a validation error
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class IsMandatoryAttribute : ValidatorAttributeBase
    {
        private string isEnabledPropertyName;

        /// <summary>
        /// Initializes a new instance of <see cref="IsMandatoryAttribute"/>
        /// </summary>
        /// <param name="errorMessageKey">The key of the localized error message string</param>
        public IsMandatoryAttribute(string errorMessageKey) : base(errorMessageKey)
        {
            this.isEnabledPropertyName = null;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="IsMandatoryAttribute"/>
        /// </summary>
        /// <param name="isEnabledPropertyName">The name of the property that can "turn off" the mandatory attribute.
        /// The property's <see cref="Type"/> has to be <see cref="bool"/>.
        /// If the property returns true, the <see cref="IsMandatoryAttribute"/> is enabled; otherwise disabled.</param>
        /// <param name="errorMessageKey">The key of the localized error message string</param>
        public IsMandatoryAttribute(string isEnabledPropertyName, string errorMessageKey) : base(errorMessageKey)
        {
            this.isEnabledPropertyName = isEnabledPropertyName;
        }

        /// <summary>
        /// Gets a value that if true indicates that this validator will be invoked everytime the
        /// property has changed
        /// </summary>
        public override bool AlwaysValidate { get { return false; } }

        /// <summary>
        /// Gets a value that indicates if the attribute can be deactivated
        /// </summary>
        public bool IsDeactivatable => this.isEnabledPropertyName != null;

        /// <exclude />
        internal bool IsEnabled(object context, PropertyInfo propertyInfo)
        {
            try
            {
                var propertyValue = (bool?)context.GetPropertyValue(this.isEnabledPropertyName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

                if (propertyValue.HasValue && propertyValue.Value)
                    return true;
            }
            catch (InvalidCastException e)
            {
                throw new InvalidCastException($"IsMandatoryAttribute: The IsEnabledProperty '{this.isEnabledPropertyName}' does not return a bool. Property: '{propertyInfo.Name}'", e);
            }

            return false;
        }

        /// <summary>
        /// Invokes the validation on the specified context with the specified parameters
        /// </summary>
        /// <param name="sender">The property that invoked the validation</param>
        /// <param name="context">The Viewmodel context that has to be validated</param>
        /// <param name="propertyInfo">The <see cref="PropertyInfo"/> of the validated property</param>
        /// <param name="value">The value of the property</param>
        /// <returns>Has to return true on validation error otherwise false</returns>
        protected override Task<bool> OnValidateAsync(PropertyInfo sender, IValidatableViewModel context, PropertyInfo propertyInfo, object value)
        {
            if (this.isEnabledPropertyName != null && !this.IsEnabled(context, propertyInfo))
                return Task.FromResult(true);

            if (value == null)
                return Task.FromResult(true);

            if (propertyInfo.PropertyType == typeof(string))
                return Task.FromResult(string.IsNullOrEmpty(value.ToString()));

            if (propertyInfo.PropertyType == typeof(bool))
                return Task.FromResult(!(bool)value);

            if (value is IEnumerable && (value as IEnumerable).Count_() == 0)
                return Task.FromResult(true);

            if (propertyInfo.PropertyType == typeof(SecureString))
                return Task.FromResult((value as SecureString).Length == 0);

            return Task.FromResult(false);
        }
    }
}