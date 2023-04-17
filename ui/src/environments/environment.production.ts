export const environment = {
    production: true,
    name: 'live',
    title: 'Fwks UI',
    authServer: {
        url: 'http://live-keycloak-instance/auth',
        realm: 'dev-service',
        clientId: 'development',
        scopes: 'openid profile email roles',
    },
}
