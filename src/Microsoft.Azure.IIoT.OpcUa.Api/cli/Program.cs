// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Cli {
    using Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models;
    using Microsoft.Azure.IIoT.OpcUa.Api.Registry.Clients;
    using Microsoft.Azure.IIoT.OpcUa.Api.Registry;
    using Microsoft.Azure.IIoT.OpcUa.Api.Twin.Models;
    using Microsoft.Azure.IIoT.OpcUa.Api.Twin.Clients;
    using Microsoft.Azure.IIoT.OpcUa.Api.Twin;
    using Microsoft.Azure.IIoT.Auth.Azure;
    using Microsoft.Azure.IIoT.Http.Default;
    using Microsoft.Azure.IIoT.Http.Auth;
    using Microsoft.Azure.IIoT.Diagnostics;
    using Microsoft.Azure.IIoT.Utils;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Autofac;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Diagnostics;

    /// <summary>
    /// Api command line interface
    /// </summary>
    public class Program {

        /// <summary>
        /// Configure Dependency injection
        /// </summary>
        public static IContainer ConfigureContainer(IConfigurationRoot configuration) {
            var builder = new ContainerBuilder();

            // Register configuration interfaces
            builder.RegisterInstance(
                new ApiConfig {
                    Configuration = configuration
                })
                .AsImplementedInterfaces().SingleInstance();

            // Register logger
            builder.RegisterType<TraceLogger>()
                .AsImplementedInterfaces().SingleInstance();

            // Register http client implementation
            builder.RegisterType<HttpClient>()
                .AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<HttpClientFactory>()
                .AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<HttpHandlerFactory>()
                .AsImplementedInterfaces().SingleInstance();

            // Use bearer authentication
            builder.RegisterType<HttpBearerAuthentication>()
                .AsImplementedInterfaces().SingleInstance();
            // Use device code token provider to get tokens
            builder.RegisterType<DeviceCodeTokenProvider>()
                .AsImplementedInterfaces().SingleInstance();

            // Register twin services and ...
            builder.RegisterType<TwinServiceClient>()
                .AsImplementedInterfaces().SingleInstance();

            // registry services and ...
            builder.RegisterType<RegistryServiceClient>()
                .AsImplementedInterfaces().SingleInstance();

            return builder.Build();
        }

        /// <summary>
        /// Main entry point
        /// </summary>
        public static void Main(string[] args) {

            // Load hosting configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", true)
                .Build();

            // Set up dependency injection for the module host
            var container = ConfigureContainer(config);

            using (var scope = container.BeginLifetimeScope()) {
                RunAsync(args, scope).Wait();
            }
        }

        /// <summary>
        /// Run client
        /// </summary>
        public static async Task RunAsync(string[] args, IComponentContext context) {
            var twin = context.Resolve<ITwinServiceApi>();
            var registry = context.Resolve<IRegistryServiceApi>();
            var interactive = false;
            do {
                if (interactive) {
                    Console.Write("> ");
                    args = CliOptions.ParseAsCommandLine(Console.ReadLine());
                }
                try {
                    if (args.Length < 1) {
                        throw new ArgumentException("Need a command!");
                    }

                    CliOptions options;
                    var command = args[0].ToLowerInvariant();
                    switch (command) {
                        case "exit":
                            interactive = false;
                            break;
                        case "console":
                            interactive = true;
                            break;
                        case "status":
                            options = new CliOptions(args);
                            await GetStatusAsync(twin, registry, options);
                            break;
                        case "apps":
                            if (args.Length < 2) {
                                throw new ArgumentException("Need a command!");
                            }
                            command = args[1].ToLowerInvariant();
                            options = new CliOptions(args, 2);
                            switch (command) {
                                case "sites":
                                    await ListSitesAsync(registry, options);
                                    break;
                                case "register":
                                    await RegisterApplicationAsync(registry, options);
                                    break;
                                case "add":
                                    await RegisterServerAsync(registry, options);
                                    break;
                                case "discover":
                                    await DiscoverServerAsync(registry, options);
                                    break;
                                case "update":
                                    await UpdateApplicationAsync(registry, options);
                                    break;
                                case "unregister":
                                    await UnregisterApplicationAsync(registry, options);
                                    break;
                                case "purge":
                                    await PurgeDisabledApplicationsAsync(registry, options);
                                    break;
                                case "list":
                                    await ListApplicationsAsync(registry, options);
                                    break;
                                case "query":
                                    await QueryApplicationsAsync(registry, options);
                                    break;
                                case "get":
                                    await GetApplicationAsync(registry, options);
                                    break;
                                case "-?":
                                case "-h":
                                case "--help":
                                case "help":
                                    PrintApplicationsHelp();
                                    break;
                                default:
                                    throw new ArgumentException($"Unknown command {command}.");
                            }
                            break;
                        case "twins":
                            if (args.Length < 2) {
                                throw new ArgumentException("Need a command!");
                            }
                            command = args[1].ToLowerInvariant();
                            options = new CliOptions(args, 2);
                            switch (command) {
                                case "update":
                                    await UpdateTwinAsync(registry, options);
                                    break;
                                case "get":
                                    await GetTwinAsync(registry, options);
                                    break;
                                case "list":
                                    await ListTwinsAsync(registry, options);
                                    break;
                                case "query":
                                    await QueryTwinsAsync(registry, options);
                                    break;
                                case "activate":
                                    await ActivateTwinsAsync(registry, options);
                                    break;
                                case "deactivate":
                                    await DeactivateTwinsAsync(registry, options);
                                    break;
                                case "-?":
                                case "-h":
                                case "--help":
                                case "help":
                                    PrintTwinsHelp();
                                    break;
                                default:
                                    throw new ArgumentException($"Unknown command {command}.");
                            }
                            break;
                        case "supervisors":
                            if (args.Length < 2) {
                                throw new ArgumentException("Need a command!");
                            }
                            command = args[1].ToLowerInvariant();
                            options = new CliOptions(args, 2);
                            switch (command) {
                                case "get":
                                    await GetSupervisorAsync(registry, options);
                                    break;
                                case "update":
                                    await UpdateSupervisorAsync(registry, options);
                                    break;
                                case "list":
                                    await ListSupervisorsAsync(registry, options);
                                    break;
                                case "query":
                                    await QuerySupervisorsAsync(registry, options);
                                    break;
                                case "-?":
                                case "-h":
                                case "--help":
                                case "help":
                                    PrintSupervisorsHelp();
                                    break;
                                default:
                                    throw new ArgumentException($"Unknown command {command}.");
                            }
                            break;
                        case "nodes":
                            if (args.Length < 2) {
                                throw new ArgumentException("Need a command!");
                            }
                            command = args[1].ToLowerInvariant();
                            options = new CliOptions(args, 2);
                            switch (command) {
                                case "browse":
                                    await BrowseAsync(twin, options);
                                    break;
                                case "publish":
                                    await PublishAsync(twin, options);
                                    break;
                                case "nodes":
                                    await ListNodesAsync(twin, options);
                                    break;
                                case "read":
                                    await ReadAsync(twin, options);
                                    break;
                                case "write":
                                    await WriteAsync(twin, options);
                                    break;
                                case "metadata":
                                    await MethodMetadataAsync(twin, options);
                                    break;
                                case "call":
                                    await MethodCallAsync(twin, options);
                                    break;
                                case "-?":
                                case "-h":
                                case "--help":
                                case "help":
                                    PrintNodesHelp();
                                    break;
                                default:
                                    throw new ArgumentException($"Unknown command {command}.");
                            }
                            break;

                        case "-?":
                        case "-h":
                        case "--help":
                        case "help":
                            PrintHelp();
                            break;
                        default:
                            throw new ArgumentException($"Unknown command {command}.");
                    }
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                    if (!interactive) {
                        PrintHelp();
                        return;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("==================");
                    Console.WriteLine(e);
                    Console.WriteLine("==================");
                }
            }
            while (interactive);
        }

        /// <summary>
        /// Call method
        /// </summary>
        private static async Task MethodCallAsync(ITwinServiceApi service,
            CliOptions options) {
            var result = await service.NodeMethodCallAsync(
                options.GetValue<string>("-i", "--id"),
                new MethodCallRequestApiModel {
                    MethodId = options.GetValue<string>("-n", "--nodeid"),
                    ObjectId = options.GetValue<string>("-o", "--objectid")

                    // ...
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Read value
        /// </summary>
        private static async Task MethodMetadataAsync(ITwinServiceApi service,
            CliOptions options) {
            var result = await service.NodeMethodGetMetadataAsync(
                options.GetValue<string>("-i", "--id"),
                new MethodMetadataRequestApiModel {
                    MethodId = options.GetValue<string>("-n", "--nodeid")
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Write value
        /// </summary>
        private static async Task WriteAsync(ITwinServiceApi service,
            CliOptions options) {
            var result = await service.NodeValueWriteAsync(
                options.GetValue<string>("-i", "--id"),
                new ValueWriteRequestApiModel {
                    NodeId = options.GetValue<string>("-n", "--nodeid"),
                    DataType = options.GetValueOrDefault<string>("-t", "--datatype", null),
                    Value = options.GetValue<string>("-v", "--value")
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Read value
        /// </summary>
        private static async Task ReadAsync(ITwinServiceApi service,
            CliOptions options) {
            var result = await service.NodeValueReadAsync(
                options.GetValue<string>("-i", "--id"),
                new ValueReadRequestApiModel {
                    NodeId = options.GetValue<string>("-n", "--nodeid")
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Publish node
        /// </summary>
        private static async Task PublishAsync(ITwinServiceApi service,
            CliOptions options) {
            var result = await service.NodePublishAsync(
                options.GetValue<string>("-i", "--id"),
                new PublishRequestApiModel {
                    NodeId = options.GetValue<string>("-n", "--nodeid"),
                    Enabled = options.GetValueOrDefault("-x", "--delete", false) ? (bool?)null :
                        !options.GetValueOrDefault("-d", "--disable", false)
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Browse nodes
        /// </summary>
        private static async Task BrowseAsync(ITwinServiceApi service,
            CliOptions options) {
            var id = options.GetValue<string>("-i", "--id");
            var silent = options.GetValueOrDefault("-s", "--silent", false);
            var recursive = options.GetValueOrDefault("-r", "--recursive", false);
            var readDuringBrowse = options.GetValueOrDefault<bool>("-v", "--readvalue", null);
            var request = new BrowseRequestApiModel {
                TargetNodesOnly = options.GetValueOrDefault<bool>("-t", "--targets", null),
                ReadVariableValues = readDuringBrowse,
                MaxReferencesToReturn = options.GetValueOrDefault<uint>("-x", "--maxrefs", null),
                Direction = options.GetValueOrDefault<BrowseDirection>("-d", "--direction", null)
            };
            var nodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
                options.GetValueOrDefault<string>("-n", "--nodeid", null)
            };
            var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var nodesRead = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var errors = 0;
            var sw = Stopwatch.StartNew();
            while (nodes.Count > 0) {
                request.NodeId = nodes.First();
                nodes.Remove(request.NodeId);
                try {
                    var result = await service.NodeBrowseAsync(id, request);
                    visited.Add(request.NodeId);
                    if (!silent) {
                        PrintResult(options, result);
                    }
                    if (readDuringBrowse ?? false) {
                        continue;
                    }
                    // Do recursive browse
                    if (recursive) {
                        foreach (var r in result.References) {
                            if (!visited.Contains(r.Id)) {
                                nodes.Add(r.Id);
                            }
                            if (!visited.Contains(r.Target.Id)) {
                                nodes.Add(r.Target.Id);
                            }
                            if (nodesRead.Contains(r.Target.Id)) {
                                continue; // We have read this one already
                            }
                            if (!r.Target.NodeClass.HasValue ||
                                r.Target.NodeClass.Value != NodeClass.Variable) {
                                continue;
                            }
                            if (!silent) {
                                Console.WriteLine($"Reading {r.Target.Id}");
                            }
                            try {
                                nodesRead.Add(r.Target.Id);
                                var read = await service.NodeValueReadAsync(id,
                                    new ValueReadRequestApiModel {
                                        NodeId = r.Target.Id
                                    });
                                if (!silent) {
                                    PrintResult(options, read);
                                }
                            }
                            catch (Exception ex) {
                                Console.WriteLine($"Reading {r.Target.Id} resulted in {ex}");
                                errors++;
                            }
                        }
                    }
                }
                catch(Exception e) {
                    Console.WriteLine($"Browse {request.NodeId} resulted in {e}");
                    errors++;
                }
            }
            Console.WriteLine($"Browse took {sw.Elapsed}. Visited " +
                $"{visited.Count} nodes and read {nodesRead.Count} of them with {errors} errors.");
        }

        /// <summary>
        /// List published nodes
        /// </summary>
        private static async Task ListNodesAsync(ITwinServiceApi service,
            CliOptions options) {
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.ListAllPublishedNodesAsync(
                    options.GetValue<string>("-i", "--id"));
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.ListPublishedNodesAsync(
                    options.GetValueOrDefault<string>("-C", "--continuation", null),
                    options.GetValue<string>("-i", "--id"));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// List supervisor registrations
        /// </summary>
        private static async Task ListSupervisorsAsync(IRegistryServiceApi service,
            CliOptions options) {
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.ListAllSupervisorsAsync();
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.ListSupervisorsAsync(
                    options.GetValueOrDefault<string>("-C", "--continuation", null),
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Query supervisor registrations
        /// </summary>
        private static async Task QuerySupervisorsAsync(IRegistryServiceApi service,
            CliOptions options) {
            var query = new SupervisorQueryApiModel {
                Connected = options.GetValueOrDefault<bool>("-c", "--connected", null),
                Discovery = options.GetValueOrDefault<DiscoveryMode>("-d", "--discovery", null),
                SiteId = options.GetValueOrDefault<string>("-s", "--siteId", null)
            };
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.QueryAllSupervisorsAsync(query);
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.QuerySupervisorsAsync(query,
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Get supervisor
        /// </summary>
        private static async Task GetSupervisorAsync(IRegistryServiceApi service,
            CliOptions options) {
            var result = await service.GetSupervisorAsync(
                options.GetValue<string>("-i", "--id"));
            PrintResult(options, result);
        }

        /// <summary>
        /// Update twin
        /// </summary>
        private static async Task UpdateSupervisorAsync(IRegistryServiceApi service,
            CliOptions options) {
            var config = new DiscoveryConfigApiModel();

            if (options.GetValueOrDefault("-a", "--activate", false)) {
                config.ActivationFilter = new TwinActivationFilterApiModel {
                    SecurityMode = SecurityMode.None
                };
            }

            var addressRange = options.GetValueOrDefault<string>("-r", "--address-ranges", null);
            if (addressRange != null) {
                if (addressRange == "true") {
                    config.AddressRangesToScan = "";
                }
                else {
                    config.AddressRangesToScan = addressRange;
                }
            }

            var portRange = options.GetValueOrDefault<string>("-p", "--port-ranges", null);
            if (portRange != null) {
                if (portRange == "true") {
                    config.PortRangesToScan = "";
                }
                else {
                    config.PortRangesToScan = portRange;
                }
            }

            var netProbes = options.GetValueOrDefault<int>("-R", "--address-probes", null);
            if (netProbes != null && netProbes != 0) {
                config.MaxNetworkProbes = netProbes;
            }

            var portProbes = options.GetValueOrDefault<int>("-P", "--port-probes", null);
            if (portProbes != null && portProbes != 0) {
                config.MaxPortProbes = portProbes;
            }

            await service.UpdateSupervisorAsync(
                new SupervisorUpdateApiModel {
                    Id = options.GetValue<string>("-i", "--id"),
                    SiteId = options.GetValueOrDefault<string>("-s", "--siteId", null),
                    Discovery = options.GetValueOrDefault<DiscoveryMode>("-d", "--discovery", null),
                    DiscoveryConfig = config,
                });
        }

        /// <summary>
        /// Registers application
        /// </summary>
        private static async Task RegisterApplicationAsync(IRegistryServiceApi service,
            CliOptions options) {
            var result = await service.RegisterAsync(
                new ApplicationRegistrationRequestApiModel {
                    ApplicationUri = options.GetValue<string>("-u", "--url"),
                    ApplicationName = options.GetValueOrDefault<string>("-n", "--name", null),
                    Locale = options.GetValueOrDefault<string>("-l", "--locale", null),
                    ApplicationType = options.GetValueOrDefault<ApplicationType>("-t", "--type", null),
                    ProductUri = options.GetValueOrDefault<string>("-p", "--product", null),
                    DiscoveryUrls = new HashSet<string> {
                        options.GetValue<string>("-d", "--discoveryUrl")
                    }
                });
            PrintResult(options, result);
        }

        /// <summary>
        /// Registers server
        /// </summary>
        private static async Task RegisterServerAsync(IRegistryServiceApi service,
            CliOptions options) {
            var activate = options.GetValueOrDefault("-a", "--activate", false);
            await service.RegisterAsync(
                new ServerRegistrationRequestApiModel {
                    RegistrationId = Guid.NewGuid().ToString(),
                    DiscoveryUrl = options.GetValue<string>("-u", "--url"),
                    ActivationFilter = !activate ? null : new TwinActivationFilterApiModel {
                        SecurityMode = SecurityMode.None
                    }
                });
        }

        /// <summary>
        /// Discover servers
        /// </summary>
        private static async Task DiscoverServerAsync(IRegistryServiceApi service,
            CliOptions options) {
            var activate = options.GetValueOrDefault("-a", "--activate", false);
            await service.DiscoverAsync(
                new DiscoveryRequestApiModel {
                    Id = Guid.NewGuid().ToString(),
                    Discovery = options.GetValueOrDefault<DiscoveryMode>("-d", "--discovery", null),
                    Configuration = new DiscoveryConfigApiModel {
                        ActivationFilter = !activate ? null : new TwinActivationFilterApiModel {
                            SecurityMode = SecurityMode.None
                        }
                    }
                });
        }

        /// <summary>
        /// Update application
        /// </summary>
        private static async Task UpdateApplicationAsync(IRegistryServiceApi service,
            CliOptions options) {
            await service.UpdateApplicationAsync(
                new ApplicationRegistrationUpdateApiModel {
                    Id = options.GetValue<string>("-i", "--id"),
                    // ...
                    ApplicationName = options.GetValueOrDefault<string>("-n", "--name", null),
                    Locale = options.GetValueOrDefault<string>("-l", "--locale", null)
                });
        }

        /// <summary>
        /// Unregister application
        /// </summary>
        private static Task UnregisterApplicationAsync(IRegistryServiceApi service,
            CliOptions options) {
            return service.UnregisterApplicationAsync(
                options.GetValue<string>("-i", "--id"));
        }

        /// <summary>
        /// Purge disabled applications not seen since specified amount of time.
        /// </summary>
        private static Task PurgeDisabledApplicationsAsync(IRegistryServiceApi service,
            CliOptions options) {
            return service.PurgeDisabledApplicationsAsync(
                options.GetValue<TimeSpan>("-f", "--for"));
        }

        /// <summary>
        /// List applications
        /// </summary>
        private static async Task ListApplicationsAsync(IRegistryServiceApi service,
            CliOptions options) {
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.ListAllApplicationsAsync();
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.ListApplicationsAsync(
                    options.GetValueOrDefault<string>("-C", "--continuation", null),
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// List sites
        /// </summary>
        private static async Task ListSitesAsync(IRegistryServiceApi service,
            CliOptions options) {
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.ListAllSitesAsync();
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.ListSitesAsync(
                    options.GetValueOrDefault<string>("-C", "--continuation", null),
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Query applications
        /// </summary>
        private static async Task QueryApplicationsAsync(IRegistryServiceApi service,
            CliOptions options) {
            var query = new ApplicationRegistrationQueryApiModel {
                ApplicationUri = options.GetValueOrDefault<string>("-u", "--uri", null),
                ProductUri = options.GetValueOrDefault<string>("-p", "--product", null),
                ApplicationType = options.GetValueOrDefault<ApplicationType>("-t", "--type", null),
                ApplicationName = options.GetValueOrDefault<string>("-n", "--name", null),
                Locale = options.GetValueOrDefault<string>("-l", "--locale", null),
                IncludeNotSeenSince = options.GetValueOrDefault<bool>("-d", "--deleted", null)
            };
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.QueryAllApplicationsAsync(query);
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.QueryApplicationsAsync(query,
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Get application
        /// </summary>
        private static async Task GetApplicationAsync(IRegistryServiceApi service,
            CliOptions options) {
            var result = await service.GetApplicationAsync(
                options.GetValue<string>("-i", "--id"));
            PrintResult(options, result);
        }

        /// <summary>
        /// List twin registrations
        /// </summary>
        private static async Task ListTwinsAsync(IRegistryServiceApi service,
            CliOptions options) {
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.ListAllTwinsAsync(
                    options.GetValueOrDefault<bool>("-s", "--server", null));
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.ListTwinsAsync(
                    options.GetValueOrDefault<string>("-C", "--continuation", null),
                    options.GetValueOrDefault<bool>("-s", "--server", null),
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Query twins
        /// </summary>
        private static async Task QueryTwinsAsync(IRegistryServiceApi service,
            CliOptions options) {
            var query = new TwinRegistrationQueryApiModel {
                Url = options.GetValueOrDefault<string>("-u", "--uri", null),
                SecurityMode = options.GetValueOrDefault<SecurityMode>("-m", "--mode", null),
                SecurityPolicy = options.GetValueOrDefault<string>("-l", "--policy", null),
                Connected = options.GetValueOrDefault<bool>("-c", "--connected", null),
                Activated = options.GetValueOrDefault<bool>("-a", "--activated", null),
                IncludeNotSeenSince = options.GetValueOrDefault<bool>("-d", "--deleted", null)
            };
            if (options.GetValueOrDefault("-A", "--all", false)) {
                var result = await service.QueryAllTwinsAsync(query,
                    options.GetValueOrDefault<bool>("-s", "--server", null));
                PrintResult(options, result);
                Console.WriteLine($"{result.Count()} item(s) found...");
            }
            else {
                var result = await service.QueryTwinsAsync(query,
                    options.GetValueOrDefault<bool>("-s", "--server", null),
                    options.GetValueOrDefault<int>("-P", "--page-size", null));
                PrintResult(options, result);
            }
        }

        /// <summary>
        /// Activate twins
        /// </summary>
        private static async Task ActivateTwinsAsync(IRegistryServiceApi service,
            CliOptions options) {

            var id = options.GetValueOrDefault<string>("-i", "--id", null);
            if (id != null) {
                await service.ActivateTwinAsync(id);
                return;
            }

            // Activate all sign and encrypt twins
            var result = await service.QueryAllTwinsAsync(new TwinRegistrationQueryApiModel {
                SecurityMode = options.GetValueOrDefault<SecurityMode>("-m", "mode", null),
                Activated = false
            });
            foreach (var item in result) {
                await service.ActivateTwinAsync(item.Registration.Id);
            }
        }

        /// <summary>
        /// Update twin
        /// </summary>
        private static async Task UpdateTwinAsync(IRegistryServiceApi service,
            CliOptions options) {
            await service.UpdateTwinAsync(
                new TwinRegistrationUpdateApiModel {
                    Id = options.GetValue<string>("-i", "--id"),
                    Duplicate = options.GetValue<bool>("-d", "--duplicate"),

                    // ...
                });
        }

        /// <summary>
        /// Deactivate twins
        /// </summary>
        private static async Task DeactivateTwinsAsync(IRegistryServiceApi service,
            CliOptions options) {

            var id = options.GetValueOrDefault<string>("-i", "--id", null);
            if (id != null) {
                await service.DeactivateTwinAsync(id);
                return;
            }

            // Activate all sign and encrypt twins
            var result = await service.QueryAllTwinsAsync(new TwinRegistrationQueryApiModel {
                SecurityMode = options.GetValueOrDefault<SecurityMode>("-m", "mode", null),
                Activated = true
            });
            foreach (var item in result) {
                await service.DeactivateTwinAsync(item.Registration.Id);
            }
        }

        /// <summary>
        /// Get twin
        /// </summary>
        private static async Task GetTwinAsync(IRegistryServiceApi service,
            CliOptions options) {
            var result = await service.GetTwinAsync(
                options.GetValue<string>("-i", "--id"),
                options.GetValueOrDefault<bool>("-s", "--server", null));
            PrintResult(options, result);
        }

        /// <summary>
        /// Get status
        /// </summary>
        private static async Task GetStatusAsync(ITwinServiceApi twin,
            IRegistryServiceApi registry,
            CliOptions options) {
            try {
                var result = await twin.GetServiceStatusAsync();
                PrintResult(options, result);
            }
            catch (Exception ex) {
                PrintResult(options, ex);
            }
            try {
                var result = await registry.GetServiceStatusAsync();
                PrintResult(options, result);
            }
            catch (Exception ex) {
                PrintResult(options, ex);
            }
        }

        /// <summary>
        /// Print result
        /// </summary>
        private static void PrintResult<T>(CliOptions options, T status) {
            Console.WriteLine("==================");
            Console.WriteLine(JsonConvert.SerializeObject(status,
                options.GetValueOrDefault("-F", "--format", Formatting.Indented)));
            Console.WriteLine("==================");
        }


        /// <summary>
        /// Configuration - wraps a configuration root
        /// </summary>
        private class ApiConfig : ITwinConfig, IRegistryConfig, IClientConfig {

            /// <summary>
            /// Configuration
            /// </summary>
            public IConfigurationRoot Configuration { get; set; }

            /// <summary>
            /// Service configuration
            /// </summary>

            /// <summary>OPC twin endpoint url</summary>
            public string OpcUaTwinServiceUrl =>
                Configuration.GetValue(kOpcUaTwinServiceUrlKey,
                    Configuration.GetValue("PCS_TWIN_SERVICE_URL",
                        "http://localhost:9041"));
            /// <summary>OPC twin endpoint url</summary>
            public string OpcUaRegistryServiceUrl =>
                Configuration.GetValue(kOpcUaRegistryServiceUrlKey,
                    Configuration.GetValue("PCS_TWIN_REGISTRY_URL",
                        "http://localhost:9042"));

            public string OpcUaTwinServiceResourceId =>
                Configuration.GetValue(kOpcUaTwinServiceIdKey,
                    Configuration.GetValue("OPC_TWIN_APP_ID",
                         Configuration.GetValue<string>("IIOT_AUTH_APP_ID")));
            public string OpcUaRegistryServiceResourceId =>
                Configuration.GetValue(kOpcUaRegistryServiceIdKey,
                    Configuration.GetValue("OPC_REGISTRY_APP_ID",
                         Configuration.GetValue<string>("IIOT_AUTH_APP_ID")));

            /// <summary>
            /// Client configuration
            /// </summary>

            public string AppId =>
                Configuration.GetValue(kOpcUaTwinServiceIdKey,
                    Configuration.GetValue("OPC_TWIN_CLI_APP_ID",
                         Configuration.GetValue<string>("IIOT_AUTH_CLIENT_ID")));

            public string TenantId =>
                Configuration.GetValue<string>("OPC_TWIN_CLI_TENANT_ID");

            public string Authority => null;
            public string AppSecret => null;

            private const string kOpcUaTwinServiceUrlKey = "OpcTwinServiceUrl";
            private const string kOpcUaRegistryServiceUrlKey = "OpcRegistryServiceUrl";

            private const string kOpcUaTwinServiceIdKey = "OpcTwinServiceResourceId";
            private const string kOpcUaRegistryServiceIdKey = "OpcRegistryServiceResourceId";
        }

        /// <summary>
        /// Print help
        /// </summary>
        private static void PrintHelp() {
            Console.WriteLine(
                @"
OpcUaTwinCtrl cli - Allows to script opc twin web service api.
usage:      OpcUaTwinCtrl command [options]

Commands and Options

     console     Run in interactive mode. Enter commands after the >
     exit        Exit interactive mode and thus the cli.
     apps        Manage applications
     twins       Manage Twins
     supervisors Manage supervisors
     nodes       Call nodes services on twin
     status      Print service status
     help, -h, -? --help
                 Prints out this help.
"
                );
        }

        /// <summary>
        /// Print help
        /// </summary>
        private static void PrintApplicationsHelp() {
            Console.WriteLine(
                @"
Manage applications registry.

Commands and Options

     sites       List application sites
        with ...
        -C, --continuation
                        Continuation from previous result.
        -P, --page-size Size of page
        -A, --all       Return all sites (unpaged)
        -F, --format    Json format for result

     list        List applications
        with ...
        -C, --continuation
                        Continuation from previous result.
        -P, --page-size Size of page
        -A, --all       Return all application infos (unpaged)
        -F, --format    Json format for result

     add         Register server and twins through discovery url
        with ...
        -u, --url       Url of the discovery endpoint (mandatory)
        -a, --activate  Activate all twins during onboarding.

     discover    Discover applications and twins through config.
        with ...
        -d, --discovery Set discovery mode to use
        -a, --activate  Activate all twins during onboarding.

     register    Register Application
        with ...
        -u, --url       Uri of the application (mandatory)
        -n  --name      Application name of the application
        -t, --type      Application type (default to Server)
        -p, --product   Product uri of the application
        -d, --discovery Url of the discovery endpoint
        -F, --format    Json format for result

     query       Find applications
        with ...
        -P, --page-size Size of page
        -A, --all       Return all application infos (unpaged)
        -u, --uri       Application uri of the application.
        -n  --name      Application name of the application
        -t, --type      Application type (default to all)
        -p, --product   Product uri of the application
        -d, --deleted   Include soft deleted applications.
        -F, --format    Json format for result

     get         Get application
        with ...
        -i, --id        Id of application to get (mandatory)
        -F, --format    Json format for result

     update      Update application
        with ...
        -i, --id        Id of application to update (mandatory)
        -n, --name      Application name

     unregister  Unregister application
        with ...
        -i, --id        Id of application to unregister (mandatory)

     purge       Purge applications not seen ...
        with ...
        -f, --for       ... a specified amount of time (mandatory)

     help, -h, -? --help
                 Prints out this help.
"
                );
        }


        /// <summary>
        /// Print help
        /// </summary>
        private static void PrintTwinsHelp() {
            Console.WriteLine(
                @"
Manage Twins in registry.

Commands and Options

     list        List twins
        with ...
        -s, --server    Return only server state (default:false)
        -C, --continuation
                        Continuation from previous result.
        -P, --page-size Size of page
        -A, --all       Return all endpoints (unpaged)
        -F, --format    Json format for result

     query       Find twins
        -s, --server    Return only server state (default:false)
        -u, --uri       Endpoint uri to seach for
        -m, --mode      Security mode to search for
        -p, --policy    Security policy to match
        -a, --activated Only return activated or deactivated.
        -c, --connected Only return connected or disconnected.
        -d, --deleted   Include soft deleted twins.
        -P, --page-size Size of page
        -A, --all       Return all endpoints (unpaged)
        -F, --format    Json format for result

     activate    Activate twins with specified
        with ...
        -i, --id        Id of twin or ...
        -m, --mode      Security mode (default:SignAndEncrypt)

     get         Get twin
        with ...
        -i, --id        Id of twin to retrieve (mandatory)
        -s, --server    Return only server state (default:false)
        -F, --format    Json format for result

     update      Update twin
        with ...
        -i, --id        Id of twin
        -d, --duplicate Create duplicate twin identity.

     deactivate  Deactivate twins with specified
        with ...
        -i, --id        Id of twin or ...
        -m, --mode      Security mode (default:SignAndEncrypt)

     help, -h, -? --help
                 Prints out this help.
"
                );
        }

        /// <summary>
        /// Print help
        /// </summary>
        private static void PrintNodesHelp() {
            Console.WriteLine(
                @"
Access Nodes on twin.

Commands and Options

     browse      Browse nodes on twin
        with ...
        -i, --id        Id of twin to browse (mandatory)
        -n, --nodeid    Node to browse
        -x, --maxrefs   Max number of references
        -x, --direction Browse direction (Forward, Backward, Both)
        -r, --recursive Browse recursively and read node values
        -v, --readvalue Read node values in browse
        -t, --targets   Only return target nodes
        -s, --silent    Only show errors
        -F, --format    Json format for result

     next        Browse next nodes
        with ...
        -C, --continuation
                        Continuation from previous result.
        -F, --format    Json format for result

     publish     Publish node values on twin
        with ...
        -i, --id        Id of twin to publish value from (mandatory)
        -n, --nodeid    Node to browse (mandatory)
        -d, --disable   Disable (Pause) publishing (default: false)
        -x, --delete    Delete publish state (default: false)

     list        List published nodes on twin
        with ...
        -i, --id        Id of twin with published nodes (mandatory)
        -C, --continuation
                        Continuation from previous result.
        -A, --all       Return all twins (unpaged)
        -F, --format    Json format for result

     read        Read node value on twin
        with ...
        -i, --id        Id of twin to read value from (mandatory)
        -n, --nodeid    Node to read value from (mandatory)
        -F, --format    Json format for result

     write       Write node value on twin
        with ...
        -i, --id        Id of twin to write value on (mandatory)
        -n, --nodeid    Node to write value to (mandatory)
        -t, --datatype  Datatype of value (mandatory)
        -v, --value     Value to write (mandatory)

     metadata    Get Call meta data
        with ...
        -i, --id        Id of twin with meta data (mandatory)
        -n, --nodeid    Method Node to get meta data for (mandatory)
        -F, --format    Json format for result

     call        Call method node on twin
        with ...
        -i, --id        Id of twin to call method on (mandatory)
        -n, --nodeid    Method Node to call (mandatory)
        -o, --objectid  Object context for method

     help, -h, -? --help
                Prints out this help.
"
                );
        }

        /// <summary>
        /// Print help
        /// </summary>
        private static void PrintSupervisorsHelp() {
            Console.WriteLine(
                @"
Manage and configure Twin supervisors

Commands and Options

     list        List supervisors
        with ...
        -C, --continuation
                        Continuation from previous result.
        -P, --page-size Size of page
        -A, --all       Return all supervisors (unpaged)
        -F, --format    Json format for result

     query       Find supervisors
        -c, --connected Only return connected or disconnected.
        -d, --discovery Discovery state.
        -s, --siteId    Site of the supervisors.
        -P, --page-size Size of page
        -A, --all       Return all endpoints (unpaged)
        -F, --format    Json format for result

     get         Get supervisor
        with ...
        -i, --id        Id of supervisor to retrieve (mandatory)
        -F, --format    Json format for result

     update      Update supervisor
        with ...
        -i, --id        Id of twin to update (mandatory)
        -s, --siteId    Updated site of the supervisor.
        -d, --discovery Set supervisor discovery mode
        -a, --activate  Activate all twins during onboarding.
        -p, --port-ranges
                        Port ranges to scan.
        -r, --address-ranges
                        Address range to scan.
        -P, --port-probes
                        Max port probes to use.
        -R, --address-probes
                        Max networking probes to use.

     help, -h, -? --help
                Prints out this help.
"
                );
        }

    }
}
