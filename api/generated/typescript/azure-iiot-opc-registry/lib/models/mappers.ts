/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRest from "@azure/ms-rest-js";


export const EndpointActivationFilterApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointActivationFilterApiModel",
  type: {
    name: "Composite",
    className: "EndpointActivationFilterApiModel",
    modelProperties: {
      trustLists: {
        serializedName: "trustLists",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      securityPolicies: {
        serializedName: "securityPolicies",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      securityMode: {
        serializedName: "securityMode",
        type: {
          name: "Enum",
          allowedValues: [
            "Best",
            "Sign",
            "SignAndEncrypt",
            "None"
          ]
        }
      }
    }
  }
};

export const ServerRegistrationRequestApiModel: msRest.CompositeMapper = {
  serializedName: "ServerRegistrationRequestApiModel",
  type: {
    name: "Composite",
    className: "ServerRegistrationRequestApiModel",
    modelProperties: {
      discoveryUrl: {
        required: true,
        serializedName: "discoveryUrl",
        type: {
          name: "String"
        }
      },
      id: {
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      activationFilter: {
        serializedName: "activationFilter",
        type: {
          name: "Composite",
          className: "EndpointActivationFilterApiModel"
        }
      }
    }
  }
};

export const ApplicationRegistrationRequestApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationRegistrationRequestApiModel",
  type: {
    name: "Composite",
    className: "ApplicationRegistrationRequestApiModel",
    modelProperties: {
      applicationUri: {
        required: true,
        serializedName: "applicationUri",
        type: {
          name: "String"
        }
      },
      applicationType: {
        serializedName: "applicationType",
        type: {
          name: "Enum",
          allowedValues: [
            "Server",
            "Client",
            "ClientAndServer",
            "DiscoveryServer"
          ]
        }
      },
      productUri: {
        serializedName: "productUri",
        type: {
          name: "String"
        }
      },
      applicationName: {
        serializedName: "applicationName",
        type: {
          name: "String"
        }
      },
      locale: {
        serializedName: "locale",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      localizedNames: {
        serializedName: "localizedNames",
        type: {
          name: "Dictionary",
          value: {
            type: {
              name: "String"
            }
          }
        }
      },
      capabilities: {
        serializedName: "capabilities",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryUrls: {
        serializedName: "discoveryUrls",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryProfileUri: {
        serializedName: "discoveryProfileUri",
        type: {
          name: "String"
        }
      },
      gatewayServerUri: {
        serializedName: "gatewayServerUri",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const ApplicationRegistrationResponseApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationRegistrationResponseApiModel",
  type: {
    name: "Composite",
    className: "ApplicationRegistrationResponseApiModel",
    modelProperties: {
      id: {
        serializedName: "id",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const RegistryOperationApiModel: msRest.CompositeMapper = {
  serializedName: "RegistryOperationApiModel",
  type: {
    name: "Composite",
    className: "RegistryOperationApiModel",
    modelProperties: {
      authorityId: {
        required: true,
        serializedName: "authorityId",
        type: {
          name: "String"
        }
      },
      time: {
        required: true,
        serializedName: "time",
        type: {
          name: "DateTime"
        }
      }
    }
  }
};

export const ApplicationInfoApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationInfoApiModel",
  type: {
    name: "Composite",
    className: "ApplicationInfoApiModel",
    modelProperties: {
      applicationId: {
        serializedName: "applicationId",
        type: {
          name: "String"
        }
      },
      applicationType: {
        serializedName: "applicationType",
        type: {
          name: "Enum",
          allowedValues: [
            "Server",
            "Client",
            "ClientAndServer",
            "DiscoveryServer"
          ]
        }
      },
      applicationUri: {
        serializedName: "applicationUri",
        type: {
          name: "String"
        }
      },
      productUri: {
        serializedName: "productUri",
        type: {
          name: "String"
        }
      },
      applicationName: {
        serializedName: "applicationName",
        type: {
          name: "String"
        }
      },
      locale: {
        serializedName: "locale",
        type: {
          name: "String"
        }
      },
      localizedNames: {
        serializedName: "localizedNames",
        type: {
          name: "Dictionary",
          value: {
            type: {
              name: "String"
            }
          }
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      },
      capabilities: {
        serializedName: "capabilities",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryUrls: {
        serializedName: "discoveryUrls",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryProfileUri: {
        serializedName: "discoveryProfileUri",
        type: {
          name: "String"
        }
      },
      gatewayServerUri: {
        serializedName: "gatewayServerUri",
        type: {
          name: "String"
        }
      },
      hostAddresses: {
        serializedName: "hostAddresses",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      discovererId: {
        serializedName: "discovererId",
        type: {
          name: "String"
        }
      },
      notSeenSince: {
        serializedName: "notSeenSince",
        type: {
          name: "DateTime"
        }
      },
      created: {
        serializedName: "created",
        type: {
          name: "Composite",
          className: "RegistryOperationApiModel"
        }
      },
      updated: {
        serializedName: "updated",
        type: {
          name: "Composite",
          className: "RegistryOperationApiModel"
        }
      }
    }
  }
};

export const ApplicationInfoListApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationInfoListApiModel",
  type: {
    name: "Composite",
    className: "ApplicationInfoListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "ApplicationInfoApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const DiscoveryConfigApiModel: msRest.CompositeMapper = {
  serializedName: "DiscoveryConfigApiModel",
  type: {
    name: "Composite",
    className: "DiscoveryConfigApiModel",
    modelProperties: {
      addressRangesToScan: {
        serializedName: "addressRangesToScan",
        type: {
          name: "String"
        }
      },
      networkProbeTimeoutMs: {
        serializedName: "networkProbeTimeoutMs",
        type: {
          name: "Number"
        }
      },
      maxNetworkProbes: {
        serializedName: "maxNetworkProbes",
        type: {
          name: "Number"
        }
      },
      portRangesToScan: {
        serializedName: "portRangesToScan",
        type: {
          name: "String"
        }
      },
      portProbeTimeoutMs: {
        serializedName: "portProbeTimeoutMs",
        type: {
          name: "Number"
        }
      },
      maxPortProbes: {
        serializedName: "maxPortProbes",
        type: {
          name: "Number"
        }
      },
      minPortProbesPercent: {
        serializedName: "minPortProbesPercent",
        type: {
          name: "Number"
        }
      },
      idleTimeBetweenScansSec: {
        serializedName: "idleTimeBetweenScansSec",
        type: {
          name: "Number"
        }
      },
      discoveryUrls: {
        serializedName: "discoveryUrls",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      locales: {
        serializedName: "locales",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      activationFilter: {
        serializedName: "activationFilter",
        type: {
          name: "Composite",
          className: "EndpointActivationFilterApiModel"
        }
      }
    }
  }
};

export const DiscoveryRequestApiModel: msRest.CompositeMapper = {
  serializedName: "DiscoveryRequestApiModel",
  type: {
    name: "Composite",
    className: "DiscoveryRequestApiModel",
    modelProperties: {
      id: {
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      discovery: {
        serializedName: "discovery",
        type: {
          name: "Enum",
          allowedValues: [
            "Off",
            "Local",
            "Network",
            "Fast",
            "Scan"
          ]
        }
      },
      configuration: {
        serializedName: "configuration",
        type: {
          name: "Composite",
          className: "DiscoveryConfigApiModel"
        }
      }
    }
  }
};

export const EndpointApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointApiModel",
  type: {
    name: "Composite",
    className: "EndpointApiModel",
    modelProperties: {
      url: {
        required: true,
        serializedName: "url",
        type: {
          name: "String"
        }
      },
      alternativeUrls: {
        serializedName: "alternativeUrls",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      securityMode: {
        serializedName: "securityMode",
        type: {
          name: "Enum",
          allowedValues: [
            "Best",
            "Sign",
            "SignAndEncrypt",
            "None"
          ]
        }
      },
      securityPolicy: {
        serializedName: "securityPolicy",
        type: {
          name: "String"
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      }
    }
  }
};

export const AuthenticationMethodApiModel: msRest.CompositeMapper = {
  serializedName: "AuthenticationMethodApiModel",
  type: {
    name: "Composite",
    className: "AuthenticationMethodApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      credentialType: {
        serializedName: "credentialType",
        type: {
          name: "Enum",
          allowedValues: [
            "None",
            "UserName",
            "X509Certificate",
            "JwtToken"
          ]
        }
      },
      securityPolicy: {
        serializedName: "securityPolicy",
        type: {
          name: "String"
        }
      },
      configuration: {
        serializedName: "configuration",
        type: {
          name: "Object"
        }
      }
    }
  }
};

export const EndpointRegistrationApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointRegistrationApiModel",
  type: {
    name: "Composite",
    className: "EndpointRegistrationApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      endpointUrl: {
        serializedName: "endpointUrl",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      supervisorId: {
        serializedName: "supervisorId",
        type: {
          name: "String"
        }
      },
      discovererId: {
        serializedName: "discovererId",
        type: {
          name: "String"
        }
      },
      endpoint: {
        required: true,
        serializedName: "endpoint",
        type: {
          name: "Composite",
          className: "EndpointApiModel"
        }
      },
      securityLevel: {
        serializedName: "securityLevel",
        type: {
          name: "Number"
        }
      },
      authenticationMethods: {
        serializedName: "authenticationMethods",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "AuthenticationMethodApiModel"
            }
          }
        }
      }
    }
  }
};

export const ApplicationRegistrationApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationRegistrationApiModel",
  type: {
    name: "Composite",
    className: "ApplicationRegistrationApiModel",
    modelProperties: {
      application: {
        required: true,
        serializedName: "application",
        type: {
          name: "Composite",
          className: "ApplicationInfoApiModel"
        }
      },
      endpoints: {
        serializedName: "endpoints",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "EndpointRegistrationApiModel"
            }
          }
        }
      },
      securityAssessment: {
        serializedName: "securityAssessment",
        type: {
          name: "Enum",
          allowedValues: [
            "Low",
            "Medium",
            "High"
          ]
        }
      }
    }
  }
};

export const ApplicationRegistrationUpdateApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationRegistrationUpdateApiModel",
  type: {
    name: "Composite",
    className: "ApplicationRegistrationUpdateApiModel",
    modelProperties: {
      productUri: {
        serializedName: "productUri",
        type: {
          name: "String"
        }
      },
      applicationName: {
        serializedName: "applicationName",
        type: {
          name: "String"
        }
      },
      locale: {
        serializedName: "locale",
        type: {
          name: "String"
        }
      },
      localizedNames: {
        serializedName: "localizedNames",
        type: {
          name: "Dictionary",
          value: {
            type: {
              name: "String"
            }
          }
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      },
      capabilities: {
        serializedName: "capabilities",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryUrls: {
        serializedName: "discoveryUrls",
        constraints: {
          UniqueItems: true
        },
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      discoveryProfileUri: {
        serializedName: "discoveryProfileUri",
        type: {
          name: "String"
        }
      },
      gatewayServerUri: {
        serializedName: "gatewayServerUri",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const ApplicationSiteListApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationSiteListApiModel",
  type: {
    name: "Composite",
    className: "ApplicationSiteListApiModel",
    modelProperties: {
      sites: {
        serializedName: "sites",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "String"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const ApplicationRegistrationQueryApiModel: msRest.CompositeMapper = {
  serializedName: "ApplicationRegistrationQueryApiModel",
  type: {
    name: "Composite",
    className: "ApplicationRegistrationQueryApiModel",
    modelProperties: {
      applicationType: {
        serializedName: "applicationType",
        type: {
          name: "Enum",
          allowedValues: [
            "Server",
            "Client",
            "ClientAndServer",
            "DiscoveryServer"
          ]
        }
      },
      applicationUri: {
        serializedName: "applicationUri",
        type: {
          name: "String"
        }
      },
      productUri: {
        serializedName: "productUri",
        type: {
          name: "String"
        }
      },
      applicationName: {
        serializedName: "applicationName",
        type: {
          name: "String"
        }
      },
      locale: {
        serializedName: "locale",
        type: {
          name: "String"
        }
      },
      capability: {
        serializedName: "capability",
        type: {
          name: "String"
        }
      },
      discoveryProfileUri: {
        serializedName: "discoveryProfileUri",
        type: {
          name: "String"
        }
      },
      gatewayServerUri: {
        serializedName: "gatewayServerUri",
        type: {
          name: "String"
        }
      },
      siteOrGatewayId: {
        serializedName: "siteOrGatewayId",
        type: {
          name: "String"
        }
      },
      includeNotSeenSince: {
        serializedName: "includeNotSeenSince",
        type: {
          name: "Boolean"
        }
      },
      discovererId: {
        serializedName: "discovererId",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const DiscovererApiModel: msRest.CompositeMapper = {
  serializedName: "DiscovererApiModel",
  type: {
    name: "Composite",
    className: "DiscovererApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      discovery: {
        serializedName: "discovery",
        type: {
          name: "Enum",
          allowedValues: [
            "Off",
            "Local",
            "Network",
            "Fast",
            "Scan"
          ]
        }
      },
      discoveryConfig: {
        serializedName: "discoveryConfig",
        type: {
          name: "Composite",
          className: "DiscoveryConfigApiModel"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      },
      outOfSync: {
        serializedName: "outOfSync",
        type: {
          name: "Boolean"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const DiscovererUpdateApiModel: msRest.CompositeMapper = {
  serializedName: "DiscovererUpdateApiModel",
  type: {
    name: "Composite",
    className: "DiscovererUpdateApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      discovery: {
        serializedName: "discovery",
        type: {
          name: "Enum",
          allowedValues: [
            "Off",
            "Local",
            "Network",
            "Fast",
            "Scan"
          ]
        }
      },
      discoveryConfig: {
        serializedName: "discoveryConfig",
        type: {
          name: "Composite",
          className: "DiscoveryConfigApiModel"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      }
    }
  }
};

export const DiscovererListApiModel: msRest.CompositeMapper = {
  serializedName: "DiscovererListApiModel",
  type: {
    name: "Composite",
    className: "DiscovererListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "DiscovererApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const DiscovererQueryApiModel: msRest.CompositeMapper = {
  serializedName: "DiscovererQueryApiModel",
  type: {
    name: "Composite",
    className: "DiscovererQueryApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      discovery: {
        serializedName: "discovery",
        type: {
          name: "Enum",
          allowedValues: [
            "Off",
            "Local",
            "Network",
            "Fast",
            "Scan"
          ]
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const EndpointInfoApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointInfoApiModel",
  type: {
    name: "Composite",
    className: "EndpointInfoApiModel",
    modelProperties: {
      registration: {
        required: true,
        serializedName: "registration",
        type: {
          name: "Composite",
          className: "EndpointRegistrationApiModel"
        }
      },
      applicationId: {
        required: true,
        serializedName: "applicationId",
        type: {
          name: "String"
        }
      },
      activationState: {
        serializedName: "activationState",
        type: {
          name: "Enum",
          allowedValues: [
            "Deactivated",
            "Activated",
            "ActivatedAndConnected"
          ]
        }
      },
      endpointState: {
        serializedName: "endpointState",
        type: {
          name: "Enum",
          allowedValues: [
            "Connecting",
            "NotReachable",
            "Busy",
            "NoTrust",
            "CertificateInvalid",
            "Ready",
            "Error"
          ]
        }
      },
      outOfSync: {
        serializedName: "outOfSync",
        type: {
          name: "Boolean"
        }
      },
      notSeenSince: {
        serializedName: "notSeenSince",
        type: {
          name: "DateTime"
        }
      }
    }
  }
};

export const EndpointInfoListApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointInfoListApiModel",
  type: {
    name: "Composite",
    className: "EndpointInfoListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "EndpointInfoApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const EndpointRegistrationQueryApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointRegistrationQueryApiModel",
  type: {
    name: "Composite",
    className: "EndpointRegistrationQueryApiModel",
    modelProperties: {
      url: {
        serializedName: "url",
        type: {
          name: "String"
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      },
      securityMode: {
        serializedName: "securityMode",
        type: {
          name: "Enum",
          allowedValues: [
            "Best",
            "Sign",
            "SignAndEncrypt",
            "None"
          ]
        }
      },
      securityPolicy: {
        serializedName: "securityPolicy",
        type: {
          name: "String"
        }
      },
      activated: {
        serializedName: "activated",
        type: {
          name: "Boolean"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      },
      endpointState: {
        serializedName: "endpointState",
        type: {
          name: "Enum",
          allowedValues: [
            "Connecting",
            "NotReachable",
            "Busy",
            "NoTrust",
            "CertificateInvalid",
            "Ready",
            "Error"
          ]
        }
      },
      includeNotSeenSince: {
        serializedName: "includeNotSeenSince",
        type: {
          name: "Boolean"
        }
      },
      discovererId: {
        serializedName: "discovererId",
        type: {
          name: "String"
        }
      },
      applicationId: {
        serializedName: "applicationId",
        type: {
          name: "String"
        }
      },
      supervisorId: {
        serializedName: "supervisorId",
        type: {
          name: "String"
        }
      },
      siteOrGatewayId: {
        serializedName: "siteOrGatewayId",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const GatewayApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayApiModel",
  type: {
    name: "Composite",
    className: "GatewayApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const SupervisorApiModel: msRest.CompositeMapper = {
  serializedName: "SupervisorApiModel",
  type: {
    name: "Composite",
    className: "SupervisorApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      },
      outOfSync: {
        serializedName: "outOfSync",
        type: {
          name: "Boolean"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const PublisherConfigApiModel: msRest.CompositeMapper = {
  serializedName: "PublisherConfigApiModel",
  type: {
    name: "Composite",
    className: "PublisherConfigApiModel",
    modelProperties: {
      capabilities: {
        serializedName: "capabilities",
        type: {
          name: "Dictionary",
          value: {
            type: {
              name: "String"
            }
          }
        }
      },
      jobCheckInterval: {
        serializedName: "jobCheckInterval",
        type: {
          name: "String"
        }
      },
      heartbeatInterval: {
        serializedName: "heartbeatInterval",
        type: {
          name: "String"
        }
      },
      maxWorkers: {
        serializedName: "maxWorkers",
        type: {
          name: "Number"
        }
      },
      jobOrchestratorUrl: {
        serializedName: "jobOrchestratorUrl",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const PublisherApiModel: msRest.CompositeMapper = {
  serializedName: "PublisherApiModel",
  type: {
    name: "Composite",
    className: "PublisherApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      certificate: {
        serializedName: "certificate",
        type: {
          name: "ByteArray"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      },
      configuration: {
        serializedName: "configuration",
        type: {
          name: "Composite",
          className: "PublisherConfigApiModel"
        }
      },
      outOfSync: {
        serializedName: "outOfSync",
        type: {
          name: "Boolean"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const GatewayModulesApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayModulesApiModel",
  type: {
    name: "Composite",
    className: "GatewayModulesApiModel",
    modelProperties: {
      supervisor: {
        serializedName: "supervisor",
        type: {
          name: "Composite",
          className: "SupervisorApiModel"
        }
      },
      publisher: {
        serializedName: "publisher",
        type: {
          name: "Composite",
          className: "PublisherApiModel"
        }
      },
      discoverer: {
        serializedName: "discoverer",
        type: {
          name: "Composite",
          className: "DiscovererApiModel"
        }
      }
    }
  }
};

export const GatewayInfoApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayInfoApiModel",
  type: {
    name: "Composite",
    className: "GatewayInfoApiModel",
    modelProperties: {
      gateway: {
        required: true,
        serializedName: "gateway",
        type: {
          name: "Composite",
          className: "GatewayApiModel"
        }
      },
      modules: {
        serializedName: "modules",
        type: {
          name: "Composite",
          className: "GatewayModulesApiModel"
        }
      }
    }
  }
};

export const GatewayUpdateApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayUpdateApiModel",
  type: {
    name: "Composite",
    className: "GatewayUpdateApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const GatewayListApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayListApiModel",
  type: {
    name: "Composite",
    className: "GatewayListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "GatewayApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const GatewayQueryApiModel: msRest.CompositeMapper = {
  serializedName: "GatewayQueryApiModel",
  type: {
    name: "Composite",
    className: "GatewayQueryApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const PublisherUpdateApiModel: msRest.CompositeMapper = {
  serializedName: "PublisherUpdateApiModel",
  type: {
    name: "Composite",
    className: "PublisherUpdateApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      configuration: {
        serializedName: "configuration",
        type: {
          name: "Composite",
          className: "PublisherConfigApiModel"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      }
    }
  }
};

export const PublisherListApiModel: msRest.CompositeMapper = {
  serializedName: "PublisherListApiModel",
  type: {
    name: "Composite",
    className: "PublisherListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "PublisherApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const PublisherQueryApiModel: msRest.CompositeMapper = {
  serializedName: "PublisherQueryApiModel",
  type: {
    name: "Composite",
    className: "PublisherQueryApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};

export const SupervisorUpdateApiModel: msRest.CompositeMapper = {
  serializedName: "SupervisorUpdateApiModel",
  type: {
    name: "Composite",
    className: "SupervisorUpdateApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      logLevel: {
        serializedName: "logLevel",
        type: {
          name: "Enum",
          allowedValues: [
            "Error",
            "Information",
            "Debug",
            "Verbose"
          ]
        }
      }
    }
  }
};

export const EndpointActivationStatusApiModel: msRest.CompositeMapper = {
  serializedName: "EndpointActivationStatusApiModel",
  type: {
    name: "Composite",
    className: "EndpointActivationStatusApiModel",
    modelProperties: {
      id: {
        required: true,
        serializedName: "id",
        type: {
          name: "String"
        }
      },
      activationState: {
        serializedName: "activationState",
        type: {
          name: "Enum",
          allowedValues: [
            "Deactivated",
            "Activated",
            "ActivatedAndConnected"
          ]
        }
      }
    }
  }
};

export const SupervisorStatusApiModel: msRest.CompositeMapper = {
  serializedName: "SupervisorStatusApiModel",
  type: {
    name: "Composite",
    className: "SupervisorStatusApiModel",
    modelProperties: {
      deviceId: {
        required: true,
        serializedName: "deviceId",
        type: {
          name: "String"
        }
      },
      moduleId: {
        serializedName: "moduleId",
        type: {
          name: "String"
        }
      },
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      endpoints: {
        serializedName: "endpoints",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "EndpointActivationStatusApiModel"
            }
          }
        }
      }
    }
  }
};

export const SupervisorListApiModel: msRest.CompositeMapper = {
  serializedName: "SupervisorListApiModel",
  type: {
    name: "Composite",
    className: "SupervisorListApiModel",
    modelProperties: {
      items: {
        serializedName: "items",
        type: {
          name: "Sequence",
          element: {
            type: {
              name: "Composite",
              className: "SupervisorApiModel"
            }
          }
        }
      },
      continuationToken: {
        serializedName: "continuationToken",
        type: {
          name: "String"
        }
      }
    }
  }
};

export const SupervisorQueryApiModel: msRest.CompositeMapper = {
  serializedName: "SupervisorQueryApiModel",
  type: {
    name: "Composite",
    className: "SupervisorQueryApiModel",
    modelProperties: {
      siteId: {
        serializedName: "siteId",
        type: {
          name: "String"
        }
      },
      connected: {
        serializedName: "connected",
        type: {
          name: "Boolean"
        }
      }
    }
  }
};
