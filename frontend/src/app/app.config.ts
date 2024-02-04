import { ApplicationConfig, DEFAULT_CURRENCY_CODE } from '@angular/core'
import { provideRouter } from '@angular/router'

import { routes } from './app.routes'
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async'

export const appConfig: ApplicationConfig = {
    providers: [
        provideRouter(routes), provideAnimationsAsync(),
        { provide: DEFAULT_CURRENCY_CODE, useValue: 'EUR' }
    ]
}
