﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcTwin.WebService {
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using System.IO;
    using System.Collections.Generic;

    /// <summary>
    /// Main entry point
    /// </summary>
    public static class Program {

        /// <summary>
        /// Main entry point to run the micro service process
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {

            // Load hosting configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddCommandLine(args)
                .AddEnvironmentVariables("ASPNETCORE_")
                .AddJsonFile("hosting.json", true)
                .AddInMemoryCollection(new Dictionary<string, string> {
                    { "urls", "http://*:9042" }
                })
                .Build();

            // Build host
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel(options => {
                    options.AddServerHeader = false;
                })
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            // Run endpoint
            host.Run();
        }
    }
}
