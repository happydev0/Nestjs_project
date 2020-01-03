﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Autofac.Extensions.Hosting {
    using Autofac.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Use autofac
    /// </summary>
    public static class WebHostBuilderEx {

        /// <summary>
        /// Add autofac
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IWebHostBuilder UseAutofac(this IWebHostBuilder builder) {
            return builder.ConfigureServices(s => s.AddAutofac());
        }
    }
}