﻿namespace Sendloop.Extension {
    internal static class ObjectExt {

        /// <summary>
        /// If obj value is null then return true else false
        /// </summary>
        /// <param name="obj">
        /// Any type a value.
        /// </param>
        /// <returns>
        /// Return a boolean value.
        /// </returns>
        internal static bool IsNull(this object obj)
            => obj == null;

        /// <summary>
        /// If obj value not null then return true else false.
        /// </summary>
        /// <param name="obj">
        /// Any type a value.
        /// </param>
        /// <returns>
        /// Return a boolean value.
        /// </returns>
        internal static bool IsNotNull(this object obj)
            => obj != null;
    }
}
