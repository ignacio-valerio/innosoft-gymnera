import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44323/',
  redirectUri: baseUrl,
  clientId: 'Gymnera_App',
  responseType: 'code',
  scope: 'offline_access Gymnera',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Gymnera',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44323',
      rootNamespace: 'Gymnera',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
