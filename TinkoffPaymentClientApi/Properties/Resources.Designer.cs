﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TinkoffPaymentClientApi.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TinkoffPaymentClientApi.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email should be provided when SendEmail is true.
        /// </summary>
        internal static string Charge_EmailShouldBeProvidedWhenSendEmailIsTrue {
            get {
                return ResourceManager.GetString("Charge_EmailShouldBeProvidedWhenSendEmailIsTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CustomerKey should be provided for recurrent payments.
        /// </summary>
        internal static string Init_CustomerKeyShouldBeProvidedForRecurrentPayments {
            get {
                return ResourceManager.GetString("Init_CustomerKeyShouldBeProvidedForRecurrentPayments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Should be greater then zero.
        /// </summary>
        internal static string Init_ShouldBeGreaterThenZero {
            get {
                return ResourceManager.GetString("Init_ShouldBeGreaterThenZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Numerator should be less then Denominator.
        /// </summary>
        internal static string NumeratorShouldBeLessThenDenominator {
            get {
                return ResourceManager.GetString("NumeratorShouldBeLessThenDenominator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while processing {0} for {1}: {2}, Body: {3}.
        /// </summary>
        internal static string ProcessResponse_ErrorOccuredWhileProcessing0For12Body3 {
            get {
                return ResourceManager.GetString("ProcessResponse_ErrorOccuredWhileProcessing0For12Body3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong answer received from {0} for {1}, Status: {2}, Body: {3}.
        /// </summary>
        internal static string ProcessResponse_WrongAnswerReveivedFrom0For1Status2Body3 {
            get {
                return ResourceManager.GetString("ProcessResponse_WrongAnswerReveivedFrom0For1Status2Body3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Phone or Email should be provided.
        /// </summary>
        internal static string Receipt_PhoneOrEmailShouldBeProvided {
            get {
                return ResourceManager.GetString("Receipt_PhoneOrEmailShouldBeProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Should not be empty.
        /// </summary>
        internal static string TinkoffPaymentClient_ShouldNotBeEmpty {
            get {
                return ResourceManager.GetString("TinkoffPaymentClient_ShouldNotBeEmpty", resourceCulture);
            }
        }
    }
}
