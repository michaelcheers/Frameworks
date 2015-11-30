﻿using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngPaste directive.
    /// </summary>
    public static class PasteDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-paste (ngPaste)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-paste')")]
        public static string GetNGPaste(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-paste (ngPaste)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-paste', {value})")]
        public static void SetNGPaste(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-paste (ngPaste) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-paste')")]
        public static void RemoveNGPaste(this Element el)
        {
        }
    }
}